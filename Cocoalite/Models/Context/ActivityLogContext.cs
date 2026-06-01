using System;
using System.Collections.Generic;
using Npgsql;
using Cocoalite.Helpers;
using Cocoalite.Models.Entity;

namespace Cocoalite.Models.Context
{
    internal class ActivityLogContext
    {
        private readonly DbConnection db = new DbConnection();

        public List<ActivityLog> GetAll()
        {
            List<ActivityLog> logs = new List<ActivityLog>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT l.log_id, l.user_id,  COALESCE(u.full_name, '-') AS full_name, l.activity,l.log_time
                    FROM activity_logs l
                    LEFT JOIN users u ON l.user_id = u.user_id
                    ORDER BY l.log_time DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ActivityLog log = new ActivityLog();

                        log.LogId = Convert.ToInt32(reader["log_id"]);
                        log.UserId = Convert.ToInt32(reader["user_id"]);
                        log.FullName = reader["full_name"].ToString() ?? "";
                        log.Activity = reader["activity"].ToString() ?? "";
                        log.LogTime = Convert.ToDateTime(reader["log_time"]);

                        logs.Add(log);
                    }
                }
            }

            return logs;
        }
    }
}