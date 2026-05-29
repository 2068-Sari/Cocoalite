using System.Data;
using Npgsql;
using Cocoalite.Helpers;

namespace Cocoalite.Controllers
{
    internal class DashboardController
    {
        private readonly DbConnection db = new DbConnection();

        public DataTable GetDashboardSummary()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        total_supplier,
                        total_receiving,
                        total_qc,
                        total_batch,
                        total_stok,
                        total_shipment
                    FROM vw_dashboard_summary";

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