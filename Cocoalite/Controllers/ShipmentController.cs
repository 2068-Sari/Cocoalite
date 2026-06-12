using System;
using System.Collections.Generic;
using System.Data;
using Cocoalite.Interfaces;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;
using Cocoalite.Models.Service;


namespace Cocoalite.Controllers
{
    public class ShipmentController
    {
        private readonly IShipmentContext _context;
        private readonly CocoaWorkflowManager _workflowManager;

        public ShipmentController()
        {
            _context = new ShipmentContext();
            _workflowManager = new CocoaWorkflowManager();
        }

        public ShipmentController(IShipmentContext context)
        {
            _context = context;
            _workflowManager = new CocoaWorkflowManager();
        }
        public List<Shipment> GetReportShipment()
        {
            return _context.GetReportShipment();
        }
        public DataTable GetAllBatch()
        {
            return _context.GetAllBatch();
        }

        public DataTable GetAllUsers()
        {
            return _context.GetAllUsers();
        }

        public DataTable GetAllShipment()
        {
            DataTable data = _context.GetAllShipment();

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
                throw new ArgumentNullException(
                    nameof(shipment),
                    "Objek shipment kosong."
                );
            }

            if (shipment.BatchId <= 0)
            {
                throw new ArgumentException("Batch shipment tidak valid.");
            }

            if (shipment.CreatedBy <= 0)
            {
                throw new ArgumentException("User pembuat shipment tidak valid.");
            }

            Inventory? inventory =
                _context.GetInventoryByBatchId(shipment.BatchId);

            if (inventory == null)
            {
                throw new ArgumentException(
                    "Inventory untuk batch ini belum tersedia."
                );
            }

            _workflowManager.PastikanShipmentBisaDibuat(
                inventory,
                shipment
            );

            _context.InsertShipment(shipment);
        }

        public void UpdateShipment(
     int shipmentId,
     string destination,
     DateTime shipmentDate,
     string statusLama,
     string statusBaru,
     string vehicleNumber,
     string driverName)
        {
            if (shipmentId <= 0)
            {
                throw new ArgumentException("ID shipment tidak valid.");
            }

            _workflowManager.PastikanTransisiStatusShipment(
                statusLama,
                statusBaru
            );

            Shipment shipment = new Shipment();

            shipment.ShipmentId = shipmentId;
            shipment.Destination = destination;
            shipment.ShipmentDate = DateOnly.FromDateTime(shipmentDate);
            shipment.ShipmentStatus = statusBaru;
            shipment.VehicleNumber = vehicleNumber;
            shipment.DriverName = driverName;

            _context.UpdateShipment(shipment);
        }

        public void DeleteShipment(int shipmentId)
        {
            if (shipmentId <= 0)
            {
                throw new ArgumentException("ID shipment tidak valid.");
            }

            _context.DeleteShipment(shipmentId);
        }
    }
}