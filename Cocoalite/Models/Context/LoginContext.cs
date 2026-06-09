using System;
using System.Data;
using Npgsql;
using Cocoalite.Helpers;
using Cocoalite.Models.Entity;

namespace Cocoalite.Models.Context
{
    internal class LoginContext
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
                role
            FROM users
            WHERE username = @username
            AND password_hash = @password
            LIMIT 1";

                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
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
            SELECT COUNT(*)
            FROM users
            WHERE user_id = @user_id
            AND password_hash = @old_password";

                using (var checkCmd = new Npgsql.NpgsqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@user_id", userId);
                    checkCmd.Parameters.AddWithValue("@old_password", oldPassword);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        return false;
                    }
                }

                string updateQuery = @"
            UPDATE users
            SET password_hash = @new_password
            WHERE user_id = @user_id";

                using (var updateCmd = new Npgsql.NpgsqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@user_id", userId);
                    updateCmd.Parameters.AddWithValue("@new_password", newPassword);

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

                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                using (var adapter = new Npgsql.NpgsqlDataAdapter(cmd))
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

                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@full_name", fullName);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password_hash", password);

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