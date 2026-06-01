using System;
using Npgsql;
using Cocoalite.Helpers;
using Cocoalite.Models.Entity;

namespace Cocoalite.Models.Context
{
    internal class DashboardContext
    {
        private readonly DbConnection db = new DbConnection();

        public DashboardSummary GetSummary()
        {
            DashboardSummary summary = new DashboardSummary();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT  total_supplier, total_receiving, total_qc, total_batch, total_stok, total_shipment
                    FROM vw_dashboard_summary";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        summary.TotalSupplier =
                            Convert.ToInt32(reader["total_supplier"]);

                        summary.TotalReceiving =
                            Convert.ToInt32(reader["total_receiving"]);

                        summary.TotalQc =
                            Convert.ToInt32(reader["total_qc"]);

                        summary.TotalBatch =
                            Convert.ToInt32(reader["total_batch"]);

                        summary.TotalStok =
                            Convert.ToDecimal(reader["total_stok"]);

                        summary.TotalShipment =
                            Convert.ToInt32(reader["total_shipment"]);
                    }
                }
            }

            return summary;
        }
    }
}