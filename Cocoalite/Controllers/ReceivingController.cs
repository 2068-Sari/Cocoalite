using System;
using System.Data;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;

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

            Receiving receiving = new Receiving();

            receiving.Supplier.SupplierId = supplierId;
            receiving.ReceivedBy = receivedBy;
            receiving.ReceivingCode = receivingCode;
            receiving.ReceivingDate = receivingDate;
            receiving.CocoaWeight = cocoaWeight;
            receiving.VehicleNumber = vehicleNumber;

            _context.InsertReceiving(
                receiving.Supplier.SupplierId,
                receiving.ReceivedBy,
                receiving.ReceivingCode,
                receiving.ReceivingDate,
                receiving.CocoaWeight,
                receiving.VehicleNumber
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

            Receiving receiving = new Receiving();

            receiving.ReceivingId = receivingId;
            receiving.Supplier.SupplierId = supplierId;
            receiving.ReceivingCode = receivingCode;
            receiving.ReceivingDate = receivingDate;
            receiving.CocoaWeight = cocoaWeight;
            receiving.VehicleNumber = vehicleNumber;

            _context.UpdateReceiving(
                receiving.ReceivingId,
                receiving.Supplier.SupplierId,
                receiving.ReceivingCode,
                receiving.ReceivingDate,
                receiving.CocoaWeight,
                receiving.VehicleNumber
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