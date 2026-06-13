using System;
using System.Text;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    internal class ActivityLog : IDapatDilaporkan
    {
        public int LogId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; } = "";
        public DateTime LogTime { get; set; }

        private string activity = "";
        public string Activity
        {
            get { return activity; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Aktivitas tidak boleh kosong.");

                activity = value;
            }
        }

        public string TampilkanInfoLog()
        {
            return $"User : {FullName} | Aktivitas: {Activity} | Waktu: {LogTime}";
        }

        /// <summary>
        /// Implementasi kontrak IDapatDilaporkan.
        /// Konsisten dengan BuatLaporan() di Batch, Shipment, Inventory, dsb.
        /// </summary>
        public string BuatLaporan()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LAPORAN ACTIVITY LOG");
            sb.AppendLine("==============================");
            sb.AppendLine($"Log ID     : {LogId}");
            sb.AppendLine($"User ID    : {UserId}");
            sb.AppendLine($"Nama User  : {FullName}");
            sb.AppendLine($"Aktivitas  : {Activity}");
            sb.AppendLine($"Waktu      : {LogTime:dd-MM-yyyy HH:mm:ss}");
            sb.AppendLine("==============================");

            return sb.ToString();
        }
    }
}