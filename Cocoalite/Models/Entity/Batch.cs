using System;
using System.Collections.Generic;
using System.Text;

namespace Cocoalite.Models.Entity
{
    public class Batch
    {
        private string batchCode = "";
        private decimal batchWeight;
        private string batchStatus = "";
        private List<Shipment> daftarShipment;

        public int BatchId { get; set; }
        public int QcId { get; set; }
        public DateOnly BatchDate { get; set; }

        public Batch()
        {
            daftarShipment = new List<Shipment>();
        }

        public Batch(string batchCode, decimal batchWeight, string batchStatus, List<Shipment> daftarShipment)
        {
            BatchCode = batchCode;
            BatchWeight = batchWeight;
            BatchStatus = batchStatus;
            this.daftarShipment = daftarShipment;
        }

        public string BatchCode
        {
            get { return batchCode; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Kode batch tidak boleh kosong.");
                }

                batchCode = value;
            }
        }

        public void GenerateBatchCode()
        {
            Random random = new Random();
            int number = random.Next(1, 1000);

            BatchCode = "BTH-" + number.ToString("D3");
        }
        public decimal BatchWeight
        {
            get { return batchWeight;}
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Berat batch harus lebih dari 0.");
                }

                batchWeight = value;
            }
        }

        public string BatchStatus
        {
            get
            { return batchStatus;}
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Status batch tidak boleh kosong.");
                }

                batchStatus = value;
            }
        }

        public List<Shipment> DaftarShipment
        {
            get
            {
                return daftarShipment;
            }
        }

        public void TambahShipment(Shipment shipment)
        {
            if (shipment == null)
            {
                throw new ArgumentException("Data shipment tidak boleh kosong.");
            }

            daftarShipment.Add(shipment);
        }

        public string TampilkanInfoBatch()
        {
            return $"Batch: {BatchCode} | Berat: {BatchWeight} kg | Status: {BatchStatus} | Jumlah Shipment: {daftarShipment.Count}";
        }

        public void TampilkanDaftarShipment()
        {
            foreach (Shipment shipment in daftarShipment)
            {
                Console.WriteLine(shipment.TampilkanInfoShipment());
            }
        }
    }
}