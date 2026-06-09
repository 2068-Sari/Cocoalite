using System;
using System.Data;
using Npgsql;
using Cocoalite.Helpers;
using Cocoalite.Interfaces;
using System.Collections.Generic;
using Cocoalite.Models.Entity;

namespace Cocoalite.Models.Context
{
    internal class InventoryContext : IInventoryContext
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
        public List<Inventory> GetReportInventory()
        {
            List<Inventory> list = new List<Inventory>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        inventory_id,
                        batch_id,
                        stock_quantity,
                        warehouse_location,
                        updated_at
                    FROM inventory
                    WHERE is_delete = FALSE
                    ORDER BY inventory_id";

                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Inventory inventory = new Inventory();

                        inventory.InventoryId =
                            Convert.ToInt32(reader["inventory_id"]);

                        inventory.BatchId =
                            Convert.ToInt32(reader["batch_id"]);

                        inventory.StockQuantity =
                            Convert.ToDecimal(reader["stock_quantity"]);

                        inventory.WarehouseLocation =
                            reader["warehouse_location"].ToString() ?? "";

                        inventory.UpdatedAt =
                            Convert.ToDateTime(reader["updated_at"]);

                        list.Add(inventory);
                    }
                }
            }

            return list;
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
                    WHERE is_delete = FALSE
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

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"
                            INSERT INTO inventory
                                (batch_id, stock_quantity, warehouse_location)
                            VALUES
                                (@batch_id, @stock_quantity, @warehouse_location)";

                        using (var cmd = new NpgsqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@batch_id", inventory.BatchId);
                            cmd.Parameters.AddWithValue("@stock_quantity", inventory.StockQuantity);
                            cmd.Parameters.AddWithValue("@warehouse_location", inventory.WarehouseLocation);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
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
                    UPDATE inventory 
                    SET is_delete = TRUE 
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