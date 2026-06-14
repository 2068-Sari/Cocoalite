using System;
using Cocoalite.Helpers;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    
    public class Receiving : IDapatDilaporkan
    {


        private int _receivingId;
        private int _supplierId;
        private int _receivedBy;
        private DateTime _receivingDate;
        private string _receivingCode = "";
        private decimal _cocoaWeight;
        private string _vehicleNumber = "";
        private Supplier? _supplier;
        public Receiving() { }

        public Receiving(Supplier supplier)
        {
            if (supplier == null)
                throw new ArgumentException("Supplier tidak boleh kosong.");

            if (supplier.SupplierId <= 0)
                throw new ArgumentException(
                    "Supplier yang dipilih belum tersimpan di database.");

            _supplier = supplier;
            _supplierId = supplier.SupplierId;
        }

        public int ReceivingId
        {
            get => _receivingId;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Receiving ID tidak boleh negatif.");

                _receivingId = value;
            }
        }

        public int SupplierId
        {
            get => _supplierId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException(
                        "Supplier ID tidak valid. Receiving wajib terhubung ke supplier yang ada.");

                if (_supplierId != value)
                    _supplier = null;

                _supplierId = value;
            }
        }

        public Supplier? Supplier
        {
            get => _supplier;
            private set => _supplier = value;
        }
        public void SetSupplier(Supplier supplier)
        {
            if (supplier == null)
                throw new ArgumentException("Supplier tidak boleh kosong.");

            if (supplier.SupplierId <= 0)
                throw new ArgumentException(
                    "Supplier yang dipilih belum tersimpan di database.");

            _supplier = supplier;
            _supplierId = supplier.SupplierId;
        }

        public int ReceivedBy
        {
            get => _receivedBy;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("User penerima tidak valid.");

                _receivedBy = value;
            }
        }

        public DateTime ReceivingDate
        {
            get => _receivingDate;
            set
            {
                if (value == default)
                    throw new ArgumentException("Tanggal penerimaan tidak boleh kosong.");

                _receivingDate = value;
            }
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
            string namaSupplier = _supplier?.SupplierName ?? $"(ID: {_supplierId})";

            return
                $"Receiving: {_receivingCode} | " +
                $"Supplier: {namaSupplier} | " +
                $"Berat: {_cocoaWeight} kg | " +
                $"Kendaraan: {_vehicleNumber}";
        }

        public string BuatLaporan()
        {
            string namaSupplier = _supplier?.SupplierName ?? $"(ID: {_supplierId})";

            return
                $"LAPORAN RECEIVING\n" +
                $"==============================\n" +
                $"Receiving ID     : {_receivingId}\n" +
                $"Kode             : {_receivingCode}\n" +
                $"Supplier ID      : {_supplierId}\n" +
                $"Supplier         : {namaSupplier}\n" +
                $"Tanggal          : {_receivingDate:dd-MM-yyyy}\n" +
                $"Berat Kakao      : {_cocoaWeight} kg\n" +
                $"Nomor Kendaraan  : {_vehicleNumber}\n" +
                $"==============================";
        }
    }
}