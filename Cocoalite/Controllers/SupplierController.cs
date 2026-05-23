using System.Data;
using Npgsql;
using Cocoalite.Helpers;

namespace Cocoalite.Controllers
{
    internal class SupplierController
    {
        private readonly DbConnection db = new DbConnection();

        public DataTable GetAllSuppliers()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM suppliers ORDER BY supplier_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public void AddSupplier(string name, string address, string phone, string email)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    INSERT INTO suppliers
                    (supplier_name, address, phone_number, email)
                    VALUES
                    (@name, @address, @phone, @email)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateSupplier(int id, string name, string address, string phone, string email)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
            UPDATE suppliers
            SET
                supplier_name = @name,
                address = @address,
                phone_number = @phone,
                email = @email
            WHERE supplier_id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteSupplier(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query =
                    "DELETE FROM suppliers WHERE supplier_id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}