using System;
using System.Data;
using Npgsql;
using Cocoalite.Helpers;
using Cocoalite.Models.Entity;

namespace Cocoalite.Models.Context
{
    internal class BatchContext
    {
        private readonly DbConnection db = new DbConnection();

        public DataTable GetApprovedQc()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        qc.qc_id, r.receiving_code || ' - ' || qc.grade AS qc_display
                    FROM quality_control qc
                    JOIN receiving r ON qc.receiving_id = r.receiving_id
                    WHERE qc.qc_status = 'Approved'
                    ORDER BY qc.qc_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public DataTable GetAllBatch()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT batch_id, qc_id, batch_code, batch_date, batch_weight, batch_status
                    FROM batches
                    ORDER BY batch_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public void InsertBatch(Batch batch)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    CALL add_batch(
                @qc_id, @batch_code, @batch_date, @batch_weight
            )";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@qc_id", batch.QcId);
                    cmd.Parameters.AddWithValue("@batch_code", batch.BatchCode);
                    cmd.Parameters.AddWithValue("@batch_date", batch.BatchDate);
                    cmd.Parameters.AddWithValue("@batch_weight", batch.BatchWeight);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateBatch(Batch batch)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE batches
                    SET
                        qc_id = @qc_id,
                        batch_code = @batch_code,
                        batch_date = @batch_date,
                        batch_weight = @batch_weight,
                        batch_status = @batch_status
                    WHERE batch_id = @batch_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@batch_id", batch.BatchId);
                    cmd.Parameters.AddWithValue("@qc_id", batch.QcId);
                    cmd.Parameters.AddWithValue("@batch_code", batch.BatchCode);
                    cmd.Parameters.AddWithValue("@batch_date", batch.BatchDate);
                    cmd.Parameters.AddWithValue("@batch_weight", batch.BatchWeight);
                    cmd.Parameters.AddWithValue("@batch_status", batch.BatchStatus);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteBatch(int batchId)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    DELETE FROM batches
                    WHERE batch_id = @batch_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@batch_id", batchId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}