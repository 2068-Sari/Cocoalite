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
                            {
                                return null;
                            }

                            string role = reader["role"].ToString() ?? "";
                            role = role.Trim().ToLower();

                            if (role == "admin")
                            {
                                user = new AdminUser();
                            }
                            else if (role == "qc")
                            {
                                user = new QualityControllerUser();
                            }
                            else
                            {
                                return null;
                            }

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
                    {
                        return false;
                    }

                    storedHash = result.ToString() ?? "";
                }

                bool isOldPasswordValid = PasswordHasher.Verify(oldPassword, storedHash);

                if (!isOldPasswordValid)
                {
                    return false;
                }

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
                    WHERE username = @username";

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
            string password)
        {
            if (IsUsernameExists(username))
            {
                throw new ArgumentException("Username sudah digunakan.");
            }

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    INSERT INTO users (
                        full_name,
                        username,
                        password_hash,
                        role,
                        created_at
                    )
                    VALUES (
                        @full_name,
                        @username,
                        @password_hash,
                        'QC',
                        CURRENT_TIMESTAMP
                    )";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@full_name", fullName);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password_hash", PasswordHasher.Hash(password));

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
                    DELETE FROM users
                    WHERE user_id = @user_id
                    AND role = 'QC'";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}