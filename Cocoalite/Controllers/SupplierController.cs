using System;
using System.Data;
using Cocoalite.Interfaces;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;

namespace Cocoalite.Controllers
{
    internal class SupplierController
    {
        private readonly ISupplierContext _context;

        public SupplierController()
        {
            _context = new SupplierContext();
        }

        public SupplierController(ISupplierContext context)
        {
            _context = context;
        }

        public DataTable GetAllSuppliers()
        {
            DataTable data = _context.GetAllSuppliers();

            if (data != null)
            {
                return data;
            }

            return new DataTable();
        }

        public void AddSupplier(
            string name,
            string address,
            string phone,
            string email)
        {
            Supplier supplier = new Supplier();

            supplier.SupplierName = name;
            supplier.Address = address;
            supplier.PhoneNumber = phone;
            supplier.Email = email;

            _context.InsertSupplier(supplier);
        }

        public void UpdateSupplier(
            int id,
            string name,
            string address,
            string phone,
            string email)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID supplier tidak valid.");
            }

            Supplier supplier = new Supplier();

            supplier.SupplierId = id;
            supplier.SupplierName = name;
            supplier.Address = address;
            supplier.PhoneNumber = phone;
            supplier.Email = email;

            _context.UpdateSupplier(supplier);
        }

        public void DeleteSupplier(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID supplier tidak valid.");
            }

            _context.DeleteSupplier(id);
        }
    }
}