using System;
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
                }
            }

            return null;
        }
    }
}