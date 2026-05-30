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
                inventory_id,
                batch_id,
                batch_code,
                stock_quantity,
                warehouse_location,
                inventory_status,
                updated_at
            FROM vw_inventory_status
            ORDER BY inventory_id";

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

        //!!!
        public void AddInventory(
            int batchId,
            decimal stockQuantity,
            string warehouseLocation)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string checkQuery = @"
                    SELECT COUNT(*)
                    FROM inventory
                    WHERE batch_id = @batch_id";

                using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@batch_id", batchId);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        throw new Exception("Inventory untuk batch ini sudah ada.");
                    }
                }

                string query = @"
                    INSERT INTO inventory 
                        (batch_id, stock_quantity, warehouse_location)
                    VALUES 
                        (@batch_id, @stock_quantity, @warehouse_location)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@batch_id", batchId);
                    cmd.Parameters.AddWithValue("@stock_quantity", stockQuantity);
                    cmd.Parameters.AddWithValue("@warehouse_location", warehouseLocation);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateInventory(
            int inventoryId,
            int batchId,
            decimal stockQuantity,
            string warehouseLocation)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE inventory
                    SET
                        batch_id = @batch_id,
                        stock_quantity = @stock_quantity,
                        warehouse_location = @warehouse_location,
                        updated_at = CURRENT_TIMESTAMP
                    WHERE inventory_id = @inventory_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@inventory_id", inventoryId);
                    cmd.Parameters.AddWithValue("@batch_id", batchId);
                    cmd.Parameters.AddWithValue("@stock_quantity", stockQuantity);
                    cmd.Parameters.AddWithValue("@warehouse_location", warehouseLocation);

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
                    WHERE inventory_id = @inventory_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@inventory_id", inventoryId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}