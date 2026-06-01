using System;
using System.Data;
using Cocoalite.Models.Context;

namespace Cocoalite.Controllers
{
    internal class ReceivingController
    {
        private readonly ReceivingContext _context =
            new ReceivingContext();

        public DataTable GetSuppliers()
        {
            DataTable data = _context.GetSuppliers();

            if (data != null)
            {
                return data;
            }

            return new DataTable();
        }

        public DataTable GetAllReceiving()
        {
            DataTable data = _context.GetAllReceiving();

            if (data != null)
            {
                return data;
            }

            return new DataTable();
        }

        public void AddReceiving(
            int supplierId,
            int receivedBy,
            string receivingCode,
            DateTime receivingDate,
            decimal cocoaWeight,
            string vehicleNumber)
        {
            if (supplierId <= 0)
            {
                throw new ArgumentException("Supplier tidak valid.");
            }

            if (receivedBy <= 0)
            {
                throw new ArgumentException("User penerima tidak valid.");
            }

            if (string.IsNullOrWhiteSpace(receivingCode))
            {
                throw new ArgumentException("Kode receiving tidak boleh kosong.");
            }

            if (cocoaWeight <= 0)
            {
                throw new ArgumentException("Berat kakao harus lebih dari 0.");
            }

            _context.InsertReceiving(
                supplierId,
                receivedBy,
                receivingCode,
                receivingDate,
                cocoaWeight,
                vehicleNumber
            );
        }

        public void UpdateReceiving(
            int receivingId,
            int supplierId,
            string receivingCode,
            DateTime receivingDate,
            decimal cocoaWeight,
            string vehicleNumber)
        {
            if (receivingId <= 0)
            {
                throw new ArgumentException("ID receiving tidak valid.");
            }

            if (supplierId <= 0)
            {
                throw new ArgumentException("Supplier tidak valid.");
            }

            if (string.IsNullOrWhiteSpace(receivingCode))
            {
                throw new ArgumentException("Kode receiving tidak boleh kosong.");
            }

            if (cocoaWeight <= 0)
            {
                throw new ArgumentException("Berat kakao harus lebih dari 0.");
            }

            _context.UpdateReceiving(
                receivingId,
                supplierId,
                receivingCode,
                receivingDate,
                cocoaWeight,
                vehicleNumber
            );
        }

        public void DeleteReceiving(int receivingId)
        {
            if (receivingId <= 0)
            {
                throw new ArgumentException("ID receiving tidak valid.");
            }

            _context.DeleteReceiving(receivingId);
        }
    }
}