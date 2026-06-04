using System;
using System.Data;
using Npgsql;
using Cocoalite.Helpers;
using Cocoalite.Models.Entity;

namespace Cocoalite.Models.Context
{
    internal class ShipmentContext
    {
        private readonly DbConnection db = new DbConnection();

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

        public DataTable GetAllUsers()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        user_id,
                        full_name
                    FROM users
                    ORDER BY user_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public DataTable GetAllShipment()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        shipment_id,
                        batch_id,
                        created_by,
                        shipment_code,
                        destination,
                        shipment_date,
                        shipment_weight,
                        shipment_status,
                        vehicle_number,
                        driver_name,
                        created_at
                    FROM shipments
                    WHERE is_delete = false
                    ORDER BY shipment_id
";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public void InsertShipment(Shipment shipment)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    CALL create_shipment( @batch_id, @created_by,  @shipment_code,
                        @destination, @shipment_date, @shipment_weight, @vehicle_number, @driver_name
                    )";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@batch_id", shipment.BatchId);
                    cmd.Parameters.AddWithValue("@created_by", shipment.CreatedBy);
                    cmd.Parameters.AddWithValue("@shipment_code", shipment.ShipmentCode);
                    cmd.Parameters.AddWithValue("@destination", shipment.Destination);
                    cmd.Parameters.AddWithValue("@shipment_date", shipment.ShipmentDate);
                    cmd.Parameters.AddWithValue("@shipment_weight", shipment.ShipmentWeight);
                    cmd.Parameters.AddWithValue("@vehicle_number", shipment.VehicleNumber);
                    cmd.Parameters.AddWithValue("@driver_name", shipment.DriverName);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateShipment(
            int shipmentId,
            string destination,
            DateTime shipmentDate,
            string shipmentStatus,
            string vehicleNumber,
            string driverName)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE shipments
                    SET
                        destination = @destination,
                        shipment_date = @shipment_date,
                        shipment_status = @shipment_status,
                        vehicle_number = @vehicle_number,
                        driver_name = @driver_name
                    WHERE shipment_id = @shipment_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@shipment_id", shipmentId);
                    cmd.Parameters.AddWithValue("@destination", destination);
                    cmd.Parameters.AddWithValue("@shipment_date", shipmentDate);
                    cmd.Parameters.AddWithValue("@shipment_status", shipmentStatus);
                    cmd.Parameters.AddWithValue("@vehicle_number", vehicleNumber);
                    cmd.Parameters.AddWithValue("@driver_name", driverName);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteShipment(int shipmentId)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE shipments
                    SET is_delete = true
                    WHERE shipment_id = @shipment_id AND is_delete = false";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@shipment_id", shipmentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}