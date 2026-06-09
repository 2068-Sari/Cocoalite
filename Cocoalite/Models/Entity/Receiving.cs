using System;
using Cocoalite.Helpers;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    public class Receiving : IDapatDilaporkan
    {
        private string _receivingCode = "";
        private decimal _cocoaWeight;
        private string _vehicleNumber = "";

        public int ReceivingId { get; set; }
        public int SupplierId { get; set; }
        public int ReceivedBy { get; set; }
        public DateTime ReceivingDate { get; set; }
        public Supplier Supplier { get; set; }

        public Receiving()
        {
            Supplier = new Supplier();
        }

        public Receiving(Supplier supplier)
        {
            Supplier = supplier ?? throw new ArgumentException("Supplier tidak boleh kosong.");
            SupplierId = supplier.SupplierId;
        }

        public string ReceivingCode
        {
            get => _receivingCode;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Kode receiving tidak boleh kosong.");

                _receivingCode = value.Trim();
            }
        }

        public void GenerateReceivingCode()
        {
            ReceivingCode = CodeGenerator.GenerateReceivingCode();
        }

        public decimal CocoaWeight
        {
            get => _cocoaWeight;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Berat kakao harus lebih dari 0.");

                _cocoaWeight = value;
            }
        }

        public string VehicleNumber
        {
            get => _vehicleNumber;
            set => _vehicleNumber = value?.Trim() ?? "";
        }

        public string TampilkanInfoReceiving()
        {
            return $"Receiving: {ReceivingCode} | Supplier: {Supplier.SupplierName} | Berat: {CocoaWeight} kg | Kendaraan: {VehicleNumber}";
        }

        public string BuatLaporan()
        {
            return
                $"LAPORAN RECEIVING\n" +
                $"==============================\n" +
                $"Receiving ID     : {ReceivingId}\n" +
                $"Kode             : {ReceivingCode}\n" +
                $"Supplier ID      : {SupplierId}\n" +
                $"Supplier         : {Supplier.SupplierName}\n" +
                $"Tanggal          : {ReceivingDate:dd-MM-yyyy}\n" +
                $"Berat Kakao      : {CocoaWeight} kg\n" +
                $"Nomor Kendaraan  : {VehicleNumber}\n" +
                $"==============================";
        }
    }
}