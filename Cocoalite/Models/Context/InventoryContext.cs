using System;
using System.Data;
using Npgsql;
using Cocoalite.Helpers;
using Cocoalite.Models.Entity;

namespace Cocoalite.Models.Context
{
    internal class InventoryContext
    {
        private readonly DbConnection db = new DbConnection();

        public DataTable GetAllInventory()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT inventory_id, batch_id, batch_code, stock_quantity,  warehouse_location, inventory_status, updated_at
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
                    SELECT batch_id, batch_code
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

        public void InsertInventory(Inventory inventory)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    INSERT INTO inventory
                        (batch_id, stock_quantity, warehouse_location)
                    VALUES
                        (@batch_id, @stock_quantity, @warehouse_location)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@batch_id", inventory.BatchId);
                    cmd.Parameters.AddWithValue("@stock_quantity", inventory.StockQuantity);
                    cmd.Parameters.AddWithValue("@warehouse_location", inventory.WarehouseLocation);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateInventory(Inventory inventory)
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
                    cmd.Parameters.AddWithValue("@inventory_id", inventory.InventoryId);
                    cmd.Parameters.AddWithValue("@batch_id", inventory.BatchId);
                    cmd.Parameters.AddWithValue("@stock_quantity", inventory.StockQuantity);
                    cmd.Parameters.AddWithValue("@warehouse_location", inventory.WarehouseLocation);

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