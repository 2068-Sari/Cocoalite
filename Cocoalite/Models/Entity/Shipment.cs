using System;
using System.Linq;
using System.Text;
using Cocoalite.Helpers;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    public class Shipment : IDapatDilaporkan, IProsesPengiriman
    {
        private int _shipmentId;
        private int _batchId;
        private int _createdBy;
        private DateOnly _shipmentDate;
        private string _shipmentCode = "";
        private string _destination = "";
        private decimal _shipmentWeight;
        private string _shipmentStatus = "Pending";
        private string _vehicleNumber = "";
        private string _driverName = "";

        private static readonly string[] AllowedStatuses =
        {
            "Pending",
            "Shipped",
            "Delivered",
            "Cancelled"
        };

        public int ShipmentId
        {
            get => _shipmentId;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Shipment ID tidak boleh negatif.");

                _shipmentId = value;
            }
        }

        public int BatchId
        {
            get => _batchId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Batch ID tidak valid. Shipment harus terhubung ke batch yang ada.");

                _batchId = value;
            }
        }

        public int CreatedBy
        {
            get => _createdBy;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("User pembuat shipment tidak valid.");

                _createdBy = value;
            }
        }

        public DateOnly ShipmentDate
        {
            get => _shipmentDate;
            set
            {
                if (value == default)
                    throw new ArgumentException("Tanggal shipment tidak boleh kosong.");

                _shipmentDate = value;
            }
        }

        public string VehicleNumber
        {
            get => _vehicleNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nomor kendaraan tidak boleh kosong.");

                _vehicleNumber = value.Trim();
            }
        }

        public string DriverName
        {
            get => _driverName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nama driver tidak boleh kosong.");

                _driverName = value.Trim();
            }
        }

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

        public string ShipmentStatus
        {
            get => _shipmentStatus;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Status shipment tidak boleh kosong.");

                string status = value.Trim();

                if (!AllowedStatuses.Contains(status))
                    throw new ArgumentException(
                        $"Status shipment tidak valid. Nilai yang diizinkan: {string.Join(", ", AllowedStatuses)}");

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
                $"Kode: {_shipmentCode} | " +
                $"Tujuan: {_destination} | " +
                $"Berat: {_shipmentWeight} kg | " +
                $"Status: {_shipmentStatus}";
        }

        public string BuatLaporan()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LAPORAN SHIPMENT");
            sb.AppendLine("==============================");
            sb.AppendLine($"Shipment ID      : {_shipmentId}");
            sb.AppendLine($"Batch ID         : {_batchId}");
            sb.AppendLine($"Created By       : {_createdBy}");
            sb.AppendLine($"Shipment Code    : {_shipmentCode}");
            sb.AppendLine($"Destination      : {_destination}");
            sb.AppendLine($"Shipment Date    : {_shipmentDate:dd-MM-yyyy}");
            sb.AppendLine($"Shipment Weight  : {_shipmentWeight} kg");
            sb.AppendLine($"Shipment Status  : {_shipmentStatus}");
            sb.AppendLine($"Vehicle Number   : {_vehicleNumber}");
            sb.AppendLine($"Driver Name      : {_driverName}");
            sb.AppendLine("==============================");

            return sb.ToString();
        }
    }
}