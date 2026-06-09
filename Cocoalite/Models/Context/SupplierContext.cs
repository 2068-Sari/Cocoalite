using System;
using System.Data;
using Npgsql;
using Cocoalite.Helpers;
using Cocoalite.Interfaces;
using Cocoalite.Models.Entity;

namespace Cocoalite.Models.Context
{
    internal class SupplierContext : ISupplierContext
    {
        private readonly DbConnection db = new DbConnection();

        public DataTable GetAllSuppliers()
        {
            DataTable table = new DataTable();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT supplier_id, supplier_name, address, phone_number, email, created_at
                    FROM suppliers
                    WHERE is_delete = FALSE
                    ORDER BY supplier_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public void InsertSupplier(Supplier supplier)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"
                    INSERT INTO suppliers
                    ( supplier_name, address, phone_number, email )
                    VALUES
                    ( @supplier_name, @address, @phone_number, @email )";

                        using (var cmd = new NpgsqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@supplier_name", supplier.SupplierName);
                            cmd.Parameters.AddWithValue("@address", supplier.Address);
                            cmd.Parameters.AddWithValue("@phone_number", supplier.PhoneNumber);
                            cmd.Parameters.AddWithValue("@email", supplier.Email);

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

        public void UpdateSupplier(Supplier supplier)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE suppliers
                    SET
                        supplier_name = @supplier_name,
                        address = @address,
                        phone_number = @phone_number,
                        email = @email
                    WHERE supplier_id = @supplier_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@supplier_id", supplier.SupplierId);
                    cmd.Parameters.AddWithValue("@supplier_name", supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@address", supplier.Address);
                    cmd.Parameters.AddWithValue("@phone_number", supplier.PhoneNumber);
                    cmd.Parameters.AddWithValue("@email", supplier.Email);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSupplier(int supplierId)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE suppliers
                    SET is_delete = TRUE
                    WHERE supplier_id = @supplier_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@supplier_id", supplierId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}