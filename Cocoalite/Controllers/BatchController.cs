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
                        qc_id,
                        grade
                    FROM quality_control
                    WHERE qc_status = 'Approved'
                    ORDER BY qc_id";

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
                        qc.grade,
                        b.batch_code,
                        b.batch_date,
                        b.batch_weight,
                        b.batch_status
                    FROM batches b
                    JOIN quality_control qc
                        ON b.qc_id = qc.qc_id
                    ORDER BY b.batch_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }
    }
}