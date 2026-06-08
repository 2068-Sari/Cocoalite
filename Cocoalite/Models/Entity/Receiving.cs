using System;
using System.Collections.Generic;
using System.Text;

namespace Cocoalite.Models.Entity
{
    internal class Receiving
    {
        private string receivingCode = "";
        private decimal cocoaWeight;
        private string vehicleNumber = "";

        public int ReceivingId { get; set; }
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
        }

        public string ReceivingCode
        {
            get
            {
                return receivingCode;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Kode receiving tidak boleh kosong.");
                }

                receivingCode = value;
            }
        }

        public void GenerateReceivingCode()
        {
            Random random = new Random();
            int number = random.Next(1, 1000);

            ReceivingCode = "RCV-" + number.ToString("D3");
        }

        public decimal CocoaWeight
        {
            get
            {
                return cocoaWeight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Berat kakao harus lebih dari 0.");
                }

                cocoaWeight = value;
            }
        }

        public string VehicleNumber
        {
            get
            {
                return vehicleNumber;
            }
            set
            {
                vehicleNumber = value ?? "";
            }
        }

        public string TampilkanInfoReceiving()
        {
            return $"Receiving: {ReceivingCode} | Supplier: {Supplier.SupplierName} | Berat: {CocoaWeight} kg | Kendaraan: {VehicleNumber}";
        }
    }
}
