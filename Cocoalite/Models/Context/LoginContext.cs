using Cocoalite.Helpers;
using Cocoalite.Models.Entity;
using Npgsql;
using System;
using System.Data;

namespace Cocoalite.Models.Context
{
    internal class LoginContext
    {
        private readonly DbConnection db = new DbConnection();

        public AppUser? GetUserByLogin(string username, string password)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT  user_id, full_name, username, role
                    FROM users
                    WHERE username = @username
                    AND password_hash = @password";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = Convert.ToInt32(reader["user_id"]);
                            string fullName = reader["full_name"].ToString() ?? "";
                            string userName = reader["username"].ToString() ?? "";
                            string role = reader["role"].ToString()?.ToLower() ?? "";

                            AppUser user;

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
                                throw new Exception("Role user tidak dikenali.");
                            }

                            user.UserId = userId;
                            user.FullName = fullName;
                            user.Username = userName;

                            return user;
                        }
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
            AND password = @old_password";

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
            SET password = @new_password
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
            WHERE role = 'QC'
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

                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
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
                password,
                role,
                created_at
            )
            VALUES (
                @full_name,
                @username,
                @password,
                'QC',
                CURRENT_TIMESTAMP
            )";

                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@full_name", fullName);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

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

                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
            }

            return null;
        }
    }
}