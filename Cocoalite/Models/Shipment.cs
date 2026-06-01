using System;
using System.Collections.Generic;
using System.Text;
using Cocoalite.Interfaces;


namespace Cocoalite.Models
{
    internal class Shipment : IDapatDilaporkan
    {
        private string shipmentCode = "";
        private string destination = "";
        private decimal shipmentWeight;
        private string shipmentStatus = "Pending";

        public int ShipmentId { get; set; }
        public int BatchId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string VehicleNumber { get; set; } = "";
        public string DriverName { get; set; } = "";

        public string ShipmentCode
        {
            get
            {
                return shipmentCode;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Kode shipment tidak boleh kosong.");
                }

                shipmentCode = value;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tujuan pengiriman tidak boleh kosong.");
                }

                destination = value;
            }
        }

        public decimal ShipmentWeight
        {
            get
            {
                return shipmentWeight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Berat pengiriman harus lebih dari 0.");
                }

                shipmentWeight = value;
            }
        }

        public string ShipmentStatus
        {
            get
            {
                return shipmentStatus;
            }
        }

        public void TandaiDikirim()
        {
            shipmentStatus = "Shipped";
        }

        public void TandaiDiterima()
        {
            shipmentStatus = "Delivered";
        }

        public void BatalkanPengiriman()
        {
            shipmentStatus = "Cancelled";
        }

        public string TampilkanInfoShipment()
        {
            return $"Kode: {ShipmentCode} | Tujuan: {Destination} | Berat: {ShipmentWeight} kg | Status: {ShipmentStatus}";
        }

        public string BuatLaporan()
        {
            return $"Laporan Pengiriman - {ShipmentCode}, Tujuan: {Destination}, Berat: {ShipmentWeight} kg, Status: {ShipmentStatus}";
        }
    }
}