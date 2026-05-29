using System;
using System.Data;
using Npgsql;
using Cocoalite.Helpers;

namespace Cocoalite.Controllers
{
    internal class InventoryController
    {
        private readonly DbConnection db = new DbConnection();

        public DataTable GetAllInventory()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        i.inventory_id,
                        b.batch_id,
                        b.batch_code,
                        i.stock_in,
                        i.stock_out,
                        i.current_stock,
                        i.inventory_status,
                        i.created_at
                    FROM inventory i
                    JOIN batches b ON i.batch_id = b.batch_id
                    ORDER BY i.inventory_id";

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
                        batch_id,
                        batch_code
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

        public void AddInventory(
            int batchId,
            decimal stockIn,
            decimal stockOut,
            decimal currentStock,
            string inventoryStatus)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    INSERT INTO inventory
                    (batch_id, stock_in, stock_out, current_stock, inventory_status)
                    VALUES
                    (@batchId, @stockIn, @stockOut, @currentStock, @inventoryStatus)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@batchId", batchId);
                    cmd.Parameters.AddWithValue("@stockIn", stockIn);
                    cmd.Parameters.AddWithValue("@stockOut", stockOut);
                    cmd.Parameters.AddWithValue("@currentStock", currentStock);
                    cmd.Parameters.AddWithValue("@inventoryStatus", inventoryStatus);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateInventory(
            int inventoryId,
            int batchId,
            decimal stockIn,
            decimal stockOut,
            decimal currentStock,
            string inventoryStatus)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE inventory
                    SET
                        batch_id = @batchId,
                        stock_in = @stockIn,
                        stock_out = @stockOut,
                        current_stock = @currentStock,
                        inventory_status = @inventoryStatus
                    WHERE inventory_id = @inventoryId";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@inventoryId", inventoryId);
                    cmd.Parameters.AddWithValue("@batchId", batchId);
                    cmd.Parameters.AddWithValue("@stockIn", stockIn);
                    cmd.Parameters.AddWithValue("@stockOut", stockOut);
                    cmd.Parameters.AddWithValue("@currentStock", currentStock);
                    cmd.Parameters.AddWithValue("@inventoryStatus", inventoryStatus);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteInventory(int inventoryId)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    DELETE FROM inventory
                    WHERE inventory_id = @inventoryId";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@inventoryId", inventoryId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}