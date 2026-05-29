using System;
using System.Data;
using Npgsql;
using Cocoalite.Helpers;

namespace Cocoalite.Controllers
{
    internal class ShipmentController
    {
        private readonly DbConnection db = new DbConnection();

        public DataTable GetAllShipment()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        s.shipment_id,
                        b.batch_id,
                        b.batch_code,
                        s.created_by,
                        u.full_name AS created_by_name,
                        s.shipment_code,
                        s.destination,
                        s.shipment_date,
                        s.shipment_weight,
                        s.shipment_status,
                        s.vehicle_number,
                        s.driver_name,
                        s.created_at
                    FROM shipments s
                    JOIN batches b ON s.batch_id = b.batch_id
                    JOIN users u ON s.created_by = u.user_id
                    ORDER BY s.shipment_id";

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
            WHERE role = 'admin'
            ORDER BY user_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public void AddShipment(
            int batchId,
            int createdBy,
            string shipmentCode,
            string destination,
            DateTime shipmentDate,
            decimal shipmentWeight,
            string shipmentStatus,
            string vehicleNumber,
            string driverName)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    CALL create_shipment(
                        @batch_id,
                        @created_by,
                        @shipment_code,
                        @destination,
                        @shipment_date,
                        @shipment_weight,
                        @vehicle_number,
                        @driver_name
                    )";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@batch_id", batchId);
                    cmd.Parameters.AddWithValue("@created_by", createdBy);
                    cmd.Parameters.AddWithValue("@shipment_code", shipmentCode);
                    cmd.Parameters.AddWithValue("@destination", destination);
                    cmd.Parameters.AddWithValue("@shipment_date", DateOnly.FromDateTime(shipmentDate));
                    cmd.Parameters.AddWithValue("@shipment_weight", shipmentWeight);
                    cmd.Parameters.AddWithValue("@vehicle_number", vehicleNumber);
                    cmd.Parameters.AddWithValue("@driver_name", driverName);

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
                    cmd.Parameters.AddWithValue("@shipment_date", DateOnly.FromDateTime(shipmentDate));
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
                    DELETE FROM shipments
                    WHERE shipment_id = @shipment_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@shipment_id", shipmentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}