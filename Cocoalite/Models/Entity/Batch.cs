using System;
using System.Collections.Generic;
using System.Text;
using Cocoalite.Helpers;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    public class Batch : IDapatDilaporkan
    {
        private string _batchCode = "";
        private decimal _batchWeight;
        private string _batchStatus = "";
        private readonly List<Shipment> _daftarShipment;

        public int BatchId { get; set; }
        public int QcId { get; set; }
        public DateOnly BatchDate { get; set; }

        public Batch()
        {
            _daftarShipment = new List<Shipment>();
        }

        public Batch(string batchCode, decimal batchWeight, string batchStatus, List<Shipment> daftarShipment)
        {
            BatchCode = batchCode;
            BatchWeight = batchWeight;
            BatchStatus = batchStatus;
            _daftarShipment = daftarShipment ?? new List<Shipment>();
        }

        public string BatchCode
        {
            get => _batchCode;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Kode batch tidak boleh kosong.");

                _batchCode = value.Trim();
            }
        }

        public void GenerateBatchCode()
        {
            BatchCode = CodeGenerator.GenerateBatchCode();
        }

        public decimal BatchWeight
        {
            get => _batchWeight;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Berat batch harus lebih dari 0.");

                _batchWeight = value;
            }
        }

        public string BatchStatus
        {
            get => _batchStatus;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Status batch tidak boleh kosong.");

                _batchStatus = value.Trim();
            }
        }

        public IReadOnlyList<Shipment> DaftarShipment => _daftarShipment.AsReadOnly();

        public void TambahShipment(Shipment shipment)
        {
            if (shipment == null)
                throw new ArgumentException("Data shipment tidak boleh kosong.");

            _daftarShipment.Add(shipment);
        }

        public string TampilkanInfoBatch()
        {
            return $"Batch: {BatchCode} | Berat: {BatchWeight} kg | Status: {BatchStatus} | Jumlah Shipment: {_daftarShipment.Count}";
        }

        public string GetInfoDaftarShipment()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Shipment shipment in _daftarShipment)
            {
                sb.AppendLine(shipment.TampilkanInfoShipment());
            }

            return sb.ToString();
        }

        public string BuatLaporan()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LAPORAN BATCH");
            sb.AppendLine("==============================");
            sb.AppendLine($"Batch ID     : {BatchId}");
            sb.AppendLine($"QC ID        : {QcId}");
            sb.AppendLine($"Kode Batch   : {BatchCode}");
            sb.AppendLine($"Tanggal      : {BatchDate:dd-MM-yyyy}");
            sb.AppendLine($"Berat        : {BatchWeight} kg");
            sb.AppendLine($"Status       : {BatchStatus}");
            sb.AppendLine($"Jml Shipment : {_daftarShipment.Count}");
            sb.AppendLine("==============================");

            return sb.ToString();
        }
    }
}