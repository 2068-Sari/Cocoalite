using System;
using System.Data;
using Npgsql;
using Cocoalite.Helpers;
using Cocoalite.Interfaces;
using Cocoalite.Models.Entity;

namespace Cocoalite.Models.Context
{
    internal class LoginContext : ILoginContext
    {
        private readonly DbConnection db = new DbConnection();

        public AppUser? GetUserByLogin(string username, string password)
        {
            AppUser? user = null;

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        user_id,
                        full_name,
                        username,
                        role,
                        password_hash
                    FROM users
                    WHERE username = @username
                    AND is_deleted = false
                    LIMIT 1";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["password_hash"].ToString() ?? "";
                            bool isPasswordValid = PasswordHasher.Verify(password, storedHash);

                            if (!isPasswordValid)
                                return null;

                            string role = reader["role"].ToString()?.Trim().ToLower() ?? "";

                            if (role == "admin")
                                user = new AdminUser();
                            else if (role == "qc")
                                user = new QualityControllerUser();
                            else
                                return null;

                            user.UserId = Convert.ToInt32(reader["user_id"]);
                            user.FullName = reader["full_name"].ToString() ?? "";
                            user.Username = reader["username"].ToString() ?? "";
                        }
                    }
                }
            }

            return user;
        }

        public bool ChangePassword(
            int userId,
            string oldPassword,
            string newPassword)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string checkQuery = @"
                    SELECT password_hash
                    FROM users
                    WHERE user_id = @user_id";

                string storedHash = "";

                using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@user_id", userId);

                    object? result = checkCmd.ExecuteScalar();

                    if (result == null)
                        return false;

                    storedHash = result.ToString() ?? "";
                }

                if (!PasswordHasher.Verify(oldPassword, storedHash))
                    return false;

                string updateQuery = @"
                    UPDATE users
                    SET password_hash = @new_password_hash
                    WHERE user_id = @user_id";

                using (var updateCmd = new NpgsqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@user_id", userId);
                    updateCmd.Parameters.AddWithValue("@new_password_hash", PasswordHasher.Hash(newPassword));

                    updateCmd.ExecuteNonQuery();
                }
            }

            return true;
        }

        public bool ResetPasswordBySecurityAnswer(
            string username,
            string securityAnswer,
            string newPassword)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string selectQuery = @"
                    SELECT user_id, recovery_code_hash
                    FROM users
                    WHERE username = @username
                    AND is_deleted = FALSE";

                using (var selectCmd = new NpgsqlCommand(selectQuery, conn))
                {
                    selectCmd.Parameters.AddWithValue("@username", username.Trim());

                    using (var reader = selectCmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new Exception("Username tidak ditemukan.");

                        int userId = Convert.ToInt32(reader["user_id"]);
                        string recoveryCodeHash = reader["recovery_code_hash"]?.ToString() ?? "";

                        if (string.IsNullOrWhiteSpace(recoveryCodeHash))
                            throw new Exception("Akun ini belum memiliki kode pemulihan.");

                        bool isAnswerValid = PasswordHasher.Verify(
                            securityAnswer.Trim(),
                            recoveryCodeHash
                        );

                        if (!isAnswerValid)
                            throw new Exception("Kode pemulihan salah.");

                        reader.Close();

                        string newPasswordHash = PasswordHasher.Hash(newPassword);

                        string updateQuery = @"
                            UPDATE users
                            SET password_hash = @password_hash
                            WHERE user_id = @user_id";

                        using (var updateCmd = new NpgsqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@password_hash", newPasswordHash);
                            updateCmd.Parameters.AddWithValue("@user_id", userId);

                            int affectedRows = updateCmd.ExecuteNonQuery();
                            return affectedRows > 0;
                        }
                    }
                }
            }
        }

        public void SetRecoveryCode(int userId, string recoveryCode)
        {
            string recoveryCodeHash = PasswordHasher.Hash(recoveryCode);

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE users
                    SET recovery_code_hash = @recovery_code_hash
                    WHERE user_id = @user_id
                    AND is_deleted = FALSE";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@recovery_code_hash", recoveryCodeHash);
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows == 0)
                        throw new Exception("User tidak ditemukan atau sudah tidak aktif.");
                }
            }
        }

        public DataTable GetAllQcUsers()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        user_id,
                        full_name,
                        username,
                        role,
                        created_at
                    FROM users
                    WHERE LOWER(role) = 'qc'
                    AND is_deleted = false
                    ORDER BY user_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public bool IsUsernameExists(string username)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM users
                    WHERE username = @username
                    AND is_deleted = FALSE";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void AddQcUser(
            string fullName,
            string username,
            string password,
            string recoveryCode)
        {
            if (IsUsernameExists(username))
                throw new ArgumentException("Username sudah digunakan.");

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    INSERT INTO users (
                        full_name,
                        username,
                        password_hash,
                        recovery_code_hash,
                        role,
                        created_at
                    )
                    VALUES (
                        @full_name,
                        @username,
                        @password_hash,
                        @recovery_code_hash,
                        'qc',
                        CURRENT_TIMESTAMP
                    )";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@full_name", fullName.Trim());
                    cmd.Parameters.AddWithValue("@username", username.Trim());
                    cmd.Parameters.AddWithValue("@password_hash", PasswordHasher.Hash(password));
                    cmd.Parameters.AddWithValue("@recovery_code_hash", PasswordHasher.Hash(recoveryCode));

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteQcUser(int userId)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE users
                    SET is_deleted = TRUE
                    WHERE user_id = @user_id
                    AND role = 'qc'";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}