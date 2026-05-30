using System.Data;
using Npgsql;
using Cocoalite.Helpers;

namespace Cocoalite.Controllers
{
    internal class LoginController
    {
        private readonly DbConnection db = new DbConnection();

        public bool Login(string username, string password)
        {
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
                    AND password_hash = @password";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            LoginSession.UserId = Convert.ToInt32(reader["user_id"]);
                            LoginSession.FullName = reader["full_name"].ToString() ?? "";
                            LoginSession.Username = reader["username"].ToString() ?? "";
                            LoginSession.Role = reader["role"].ToString() ?? "";

                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}