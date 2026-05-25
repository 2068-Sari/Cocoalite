using System.Data;
using Npgsql;
using Cocoalite.Helpers;

namespace Cocoalite.Controllers
{
    internal class ReceivingController
    {
        private readonly DbConnection db = new DbConnection();

        public DataTable GetSuppliers()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT supplier_id, supplier_name FROM suppliers ORDER BY supplier_name";

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
            SELECT 
                r.receiving_id,
                r.receiving_code,
                s.supplier_name,
                r.receiving_date,
                r.cocoa_weight,
                r.vehicle_number
            FROM receiving r
            JOIN suppliers s ON r.supplier_id = s.supplier_id
            ORDER BY r.receiving_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }
        public void AddReceiving(
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

                string query = @"
            INSERT INTO receiving
            (supplier_id, received_by, receiving_code, receiving_date, cocoa_weight, vehicle_number)
            VALUES
            (@supplierId, @receivedBy, @receivingCode, @receivingDate, @cocoaWeight, @vehicleNumber)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@supplierId", supplierId);
                    cmd.Parameters.AddWithValue("@receivedBy", receivedBy);
                    cmd.Parameters.AddWithValue("@receivingCode", receivingCode);
                    cmd.Parameters.AddWithValue("@receivingDate", receivingDate);
                    cmd.Parameters.AddWithValue("@cocoaWeight", cocoaWeight);
                    cmd.Parameters.AddWithValue("@vehicleNumber", vehicleNumber);

                    cmd.ExecuteNonQuery();
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
                        supplier_id = @supplierId,
                        receiving_code = @receivingCode,
                        receiving_date = @receivingDate,
                        cocoa_weight = @cocoaWeight,
                        vehicle_number = @vehicleNumber
                    WHERE receiving_id = @receivingId";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receivingId", receivingId);
                    cmd.Parameters.AddWithValue("@supplierId", supplierId);
                    cmd.Parameters.AddWithValue("@receivingCode", receivingCode);
                    cmd.Parameters.AddWithValue("@receivingDate", receivingDate);
                    cmd.Parameters.AddWithValue("@cocoaWeight", cocoaWeight);
                    cmd.Parameters.AddWithValue("@vehicleNumber", vehicleNumber);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteReceiving(int receivingId)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query =
                    "DELETE FROM receiving WHERE receiving_id = @receivingId";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receivingId", receivingId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}