using System;
using System.Text;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    internal class DashboardSummary : IDapatDilaporkan
    {
        public int TotalSupplier { get; set; }
        public int TotalReceiving { get; set; }
        public int TotalQc { get; set; }
        public int TotalBatch { get; set; }
        public decimal TotalStok { get; set; }
        public int TotalShipment { get; set; }

        /// <summary>
        /// Business rule: stok dianggap kritis jika di bawah 300 kg.
        /// Threshold konsisten dengan aturan "Low Stock" di class Inventory.
        /// Logika ini melekat di domain model, bukan di UI.
        /// </summary>
        public bool ApakahStokKritis()
        {
            return TotalStok < 300m;
        }

        /// <summary>
        /// Menghitung rasio shipment terhadap jumlah batch sebagai
        /// indikator efisiensi distribusi. Mengembalikan 0 jika belum ada batch.
        /// </summary>
        public decimal HitungRasioShipmentPerBatch()
        {
            if (TotalBatch == 0)
                return 0m;

            return Math.Round((decimal)TotalShipment / TotalBatch, 2);
        }

        public string TampilkanInfoDashboard()
        {
            return $"Supplier: {TotalSupplier} | Receiving: {TotalReceiving} | QC: {TotalQc} | Batch: {TotalBatch} | Stok: {TotalStok} kg | Shipment: {TotalShipment}";
        }

        /// <summary>
        /// Implementasi kontrak IDapatDilaporkan.
        /// Menghasilkan ringkasan operasional sistem secara terformat,
        /// termasuk indikator status stok dan rasio distribusi.
        /// </summary>
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