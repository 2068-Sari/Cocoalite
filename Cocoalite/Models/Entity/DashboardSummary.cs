using System;
using System.Text;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    internal class DashboardSummary : IDapatDilaporkan
    {
        // =====================================================================
        // Private backing fields — encapsulasi mencegah nilai tidak valid
        // masuk ke dalam objek. Nilai negatif tidak bermakna untuk data summary
        // operasional, sehingga validasi ini adalah business rule yang sah.
        // =====================================================================
        private int _totalSupplier;
        private int _totalReceiving;
        private int _totalQc;
        private int _totalBatch;
        private decimal _totalStok;
        private int _totalShipment;

        public int TotalSupplier
        {
            get => _totalSupplier;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Total supplier tidak boleh negatif.");

                _totalSupplier = value;
            }
        }

        public int TotalReceiving
        {
            get => _totalReceiving;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Total receiving tidak boleh negatif.");

                _totalReceiving = value;
            }
        }

        public int TotalQc
        {
            get => _totalQc;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Total QC tidak boleh negatif.");

                _totalQc = value;
            }
        }

        public int TotalBatch
        {
            get => _totalBatch;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Total batch tidak boleh negatif.");

                _totalBatch = value;
            }
        }

        public decimal TotalStok
        {
            get => _totalStok;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Total stok tidak boleh negatif.");

                _totalStok = value;
            }
        }

        public int TotalShipment
        {
            get => _totalShipment;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Total shipment tidak boleh negatif.");

                _totalShipment = value;
            }
        }

        // =====================================================================
        // Business rule: stok dianggap kritis jika di bawah 300 kg.
        // Threshold konsisten dengan aturan "Low Stock" di class Inventory.
        // Logika ini melekat di domain model, bukan di UI.
        // =====================================================================
        public bool ApakahStokKritis()
        {
            return _totalStok < 300m;
        }

        // =====================================================================
        // Menghitung rasio shipment terhadap jumlah batch sebagai
        // indikator efisiensi distribusi. Mengembalikan 0 jika belum ada batch.
        // =====================================================================
        public decimal HitungRasioShipmentPerBatch()
        {
            if (_totalBatch == 0)
                return 0m;

            return Math.Round((decimal)_totalShipment / _totalBatch, 2);
        }

        public string TampilkanInfoDashboard()
        {
            return
                $"Supplier: {TotalSupplier} | " +
                $"Receiving: {TotalReceiving} | " +
                $"QC: {TotalQc} | " +
                $"Batch: {TotalBatch} | " +
                $"Stok: {TotalStok} kg | " +
                $"Shipment: {TotalShipment}";
        }

        // =====================================================================
        // Implementasi kontrak IDapatDilaporkan.
        // Menghasilkan ringkasan operasional sistem secara terformat,
        // termasuk indikator status stok dan rasio distribusi.
        // =====================================================================
        public string BuatLaporan()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LAPORAN RINGKASAN DASHBOARD");
            sb.AppendLine("==============================");
            sb.AppendLine($"Total Supplier   : {TotalSupplier}");
            sb.AppendLine($"Total Receiving  : {TotalReceiving}");
            sb.AppendLine($"Total QC         : {TotalQc}");
            sb.AppendLine($"Total Batch      : {TotalBatch}");
            sb.AppendLine($"Total Stok       : {TotalStok} kg");
            sb.AppendLine($"Total Shipment   : {TotalShipment}");
            sb.AppendLine($"Status Stok      : {(ApakahStokKritis() ? "KRITIS" : "Normal")}");
            sb.AppendLine($"Rasio Distribusi : {HitungRasioShipmentPerBatch()} shipment/batch");
            sb.AppendLine("==============================");

            return sb.ToString();
        }
    }
}