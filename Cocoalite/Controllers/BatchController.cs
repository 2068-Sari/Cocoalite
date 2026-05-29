using System.Data;
using Npgsql;
using Cocoalite.Helpers;

namespace Cocoalite.Controllers
{
    internal class BatchController
    {
        private readonly DbConnection db =
            new DbConnection();

        public DataTable GetApprovedQc()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        qc.qc_id,
                        CONCAT(r.receiving_code, ' | ', qc.grade) AS qc_display
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
            SELECT
                b.batch_id,
                qc.qc_id,
                CONCAT(r.receiving_code, ' | ', qc.grade) AS qc_display,
                qc.grade,
                b.batch_code,
                b.batch_date,
                b.batch_weight,
                b.batch_status
            FROM batches b
            JOIN quality_control qc
                ON b.qc_id = qc.qc_id
            JOIN receiving r
                ON qc.receiving_id = r.receiving_id
            ORDER BY b.batch_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }
        //public DataTable GetAllBatch()
        //{
        //    DataTable table = new DataTable();

        //    using (var conn = db.GetConnection())
        //    {
        //        conn.Open();

        //        string query = @"
        //            SELECT
        //                b.batch_id,
        //                qc.grade,
        //                b.batch_code,
        //                b.batch_date,
        //                b.batch_weight,
        //                b.batch_status
        //            FROM batches b
        //            JOIN quality_control qc
        //                ON b.qc_id = qc.qc_id
        //            ORDER BY b.batch_id";

        //        using (var cmd = new NpgsqlCommand(query, conn))
        //        using (var adapter = new NpgsqlDataAdapter(cmd))
        //        {
        //            adapter.Fill(table);
        //        }
        //    }
        //    return table;
        //}
        public void AddBatch(
            int qcId,
            string batchCode,
            DateTime batchDate,
            decimal batchWeight,
            string batchStatus)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    INSERT INTO batches
                    (qc_id, batch_code, batch_date, batch_weight, batch_status)
                    VALUES
                    (@qcId, @batchCode, @batchDate, @batchWeight, @batchStatus)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@qcId", qcId);
                    cmd.Parameters.AddWithValue("@batchCode", batchCode);
                    cmd.Parameters.AddWithValue("@batchDate", batchDate);
                    cmd.Parameters.AddWithValue("@batchWeight", batchWeight);
                    cmd.Parameters.AddWithValue("@batchStatus", batchStatus);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateBatch(
            int batchId,
            int qcId,
            string batchCode,
            DateTime batchDate,
            decimal batchWeight,
            string batchStatus)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
            UPDATE batches
            SET
                qc_id = @qcId,
                batch_code = @batchCode,
                batch_date = @batchDate,
                batch_weight = @batchWeight,
                batch_status = @batchStatus
            WHERE batch_id = @batchId";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@batchId", batchId);
                    cmd.Parameters.AddWithValue("@qcId", qcId);
                    cmd.Parameters.AddWithValue("@batchCode", batchCode);
                    cmd.Parameters.AddWithValue("@batchDate", batchDate);
                    cmd.Parameters.AddWithValue("@batchWeight", batchWeight);
                    cmd.Parameters.AddWithValue("@batchStatus", batchStatus);

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
                    WHERE batch_id = @batch_id
                ";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@batch_id", batchId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}