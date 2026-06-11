using Cocoalite.Interfaces;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data;

namespace Cocoalite.Controllers
{
    public class ShipmentController
    {
        private readonly IShipmentContext context;

        public ShipmentController()
        {
            context = new ShipmentContext();
        }

        public ShipmentController(IShipmentContext context)
        {
            this.context = context;
        }
        public List<Shipment> GetReportShipment()
        {
            return context.GetReportShipment();
        }
        public DataTable GetAllBatch()
        {
            return context.GetAllBatch();
        }

        public DataTable GetAllUsers()
        {
            return context.GetAllUsers();
        }

        public DataTable GetAllShipment()
        {
            DataTable data = context.GetAllShipment();

            if (data != null)
            {
                return data;
            }
            else
            {
                return new DataTable();
            }
        }

        public void AddShipment(Shipment shipment)
        {
            if (shipment == null)
            {
                throw new ArgumentNullException(nameof(shipment), "Objek shipment kosong.");
            }

            context.InsertShipment(shipment);
        }

        public void UpdateShipment(
            int shipmentId,
            string destination,
            DateTime shipmentDate,
            string shipmentStatus,
            string vehicleNumber,
            string driverName)
        {
            if (shipmentId <= 0)
            {
                throw new ArgumentException("ID shipment tidak valid.");
            }

            if (string.IsNullOrWhiteSpace(destination))
            {
                throw new ArgumentException("Tujuan pengiriman tidak boleh kosong.");
            }

            context.UpdateShipment( shipmentId, destination, shipmentDate,  shipmentStatus,
                vehicleNumber, driverName
            );
        }

        public void DeleteShipment(int shipmentId)
        {
            if (shipmentId <= 0)
            {
                throw new ArgumentException("ID shipment tidak valid.");
            }

            context.DeleteShipment(shipmentId);
        }
    }
}