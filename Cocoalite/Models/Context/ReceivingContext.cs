using System;
using System.Data;
using Npgsql;
using Cocoalite.Helpers;
using Cocoalite.Models.Entity;

namespace Cocoalite.Models.Context
{
    internal class ReceivingContext
    {
        private readonly DbConnection db = new DbConnection();

        public DataTable GetSuppliers()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT supplier_id, supplier_name
                    FROM suppliers
                    ORDER BY supplier_name";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public DataTable GetAllReceiving()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT r.receiving_id, r.supplier_id,  s.supplier_name, r.received_by,
                        r.receiving_code, r.receiving_date, r.cocoa_weight, r.vehicle_number, r.created_at
                    FROM receiving r
                    JOIN suppliers s ON r.supplier_id = s.supplier_id
                    WHERE is_delete = FALSE
                    ORDER BY r.receiving_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public void InsertReceiving(
            int supplierId,
            int receivedBy,
            string receivingCode,
            DateTime receivingDate,
            decimal cocoaWeight,
            string vehicleNumber)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"
                    INSERT INTO receiving
                    ( supplier_id, received_by, receiving_code,  receiving_date, cocoa_weight, vehicle_number
                    )
                    VALUES
                    ( @supplier_id, @received_by, @receiving_code, @receiving_date, @cocoa_weight, @vehicle_number
                    )";

                        using (var cmd = new NpgsqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@supplier_id", supplierId);
                            cmd.Parameters.AddWithValue("@received_by", receivedBy);
                            cmd.Parameters.AddWithValue("@receiving_code", receivingCode);
                            cmd.Parameters.AddWithValue("@receiving_date", receivingDate);
                            cmd.Parameters.AddWithValue("@cocoa_weight", cocoaWeight);
                            cmd.Parameters.AddWithValue("@vehicle_number", vehicleNumber);

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

        public void UpdateReceiving(
            int receivingId,
            int supplierId,
            string receivingCode,
            DateTime receivingDate,
            decimal cocoaWeight,
            string vehicleNumber)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE receiving
                    SET
                        supplier_id = @supplier_id,
                        receiving_code = @receiving_code,
                        receiving_date = @receiving_date,
                        cocoa_weight = @cocoa_weight,
                        vehicle_number = @vehicle_number
                    WHERE receiving_id = @receiving_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiving_id", receivingId);
                    cmd.Parameters.AddWithValue("@supplier_id", supplierId);
                    cmd.Parameters.AddWithValue("@receiving_code", receivingCode);
                    cmd.Parameters.AddWithValue("@receiving_date", receivingDate);
                    cmd.Parameters.AddWithValue("@cocoa_weight", cocoaWeight);
                    cmd.Parameters.AddWithValue("@vehicle_number", vehicleNumber);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteReceiving(int receivingId)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE receiving
                    SET is_delete = TRUE
                    WHERE receiving_id = @receiving_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiving_id", receivingId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}