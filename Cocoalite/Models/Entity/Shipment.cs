using System;
using System.Linq;
using System.Text;
using Cocoalite.Helpers;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    public class Shipment : IDapatDilaporkan, IProsesPengiriman
    {
        private string _shipmentCode = "";
        private string _destination = "";
        private decimal _shipmentWeight;
        private string _shipmentStatus = "Pending";

        public int ShipmentId { get; set; }
        public int BatchId { get; set; }
        public int CreatedBy { get; set; }
        public DateOnly ShipmentDate { get; set; }
        public string VehicleNumber { get; set; } = "";
        public string DriverName { get; set; } = "";

        public string ShipmentCode
        {
            get => _shipmentCode;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Kode shipment tidak boleh kosong.");

                _shipmentCode = value.Trim();
            }
        }

        public void GenerateShipmentCode()
        {
            ShipmentCode = CodeGenerator.GenerateShipmentCode();
        }

        public string Destination
        {
            get => _destination;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tujuan pengiriman tidak boleh kosong.");

                _destination = value.Trim();
            }
        }

        public decimal ShipmentWeight
        {
            get => _shipmentWeight;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Berat pengiriman harus lebih dari 0.");

                _shipmentWeight = value;
            }
        }

        private static readonly string[] AllowedStatuses =
        {
            "Pending",
            "Shipped",
            "Delivered",
            "Cancelled"
        };

        public string ShipmentStatus
        {
            get => _shipmentStatus;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Status shipment tidak boleh kosong.");
                }

                string status = value.Trim();

                if (!AllowedStatuses.Contains(status))
                {
                    throw new ArgumentException("Status shipment tidak valid.");
                }

                _shipmentStatus = status;
            }
        }

        public void TandaiDikirim()
        {
            ShipmentStatus = "Shipped";
        }

        public void TandaiDiterima()
        {
            ShipmentStatus = "Delivered";
        }

        public void BatalkanPengiriman()
        {
            ShipmentStatus = "Cancelled";
        }

        public string TampilkanInfoShipment()
        {
            return
                $"Kode: {ShipmentCode} | " +
                $"Tujuan: {Destination} | " +
                $"Berat: {ShipmentWeight} kg | " +
                $"Status: {ShipmentStatus}";
        }

        public string BuatLaporan()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LAPORAN SHIPMENT");
            sb.AppendLine("==============================");
            sb.AppendLine($"Shipment ID      : {ShipmentId}");
            sb.AppendLine($"Batch ID         : {BatchId}");
            sb.AppendLine($"Created By       : {CreatedBy}");
            sb.AppendLine($"Shipment Code    : {ShipmentCode}");
            sb.AppendLine($"Destination      : {Destination}");
            sb.AppendLine($"Shipment Date    : {ShipmentDate:dd-MM-yyyy}");
            sb.AppendLine($"Shipment Weight  : {ShipmentWeight} kg");
            sb.AppendLine($"Shipment Status  : {ShipmentStatus}");
            sb.AppendLine($"Vehicle Number   : {VehicleNumber}");
            sb.AppendLine($"Driver Name      : {DriverName}");
            sb.AppendLine("==============================");

            return sb.ToString();
        }
    }
}