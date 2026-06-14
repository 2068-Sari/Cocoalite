using System;
using System.Text;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    internal class ActivityLog : IDapatDilaporkan
    {
        private int logId;
        private int userId;
        private string fullName = "";
        private DateTime logTime;
        private string activity = "";

        public int LogId
        {
            get => logId;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Log ID tidak boleh negatif.");
                }

                logId = value;
            }
        }

        public int UserId
        {
            get => userId;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("User ID tidak valid.");
                }

                userId = value;
            }
        }

        public string FullName
        {
            get => fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nama user pada log tidak boleh kosong.");
                }

                fullName = value.Trim();
            }
        }

        public DateTime LogTime
        {
            get => logTime;
            set
            {
                if (value == default)
                {
                    throw new ArgumentException("Waktu log tidak valid.");
                }

                logTime = value;
            }
        }

        public string Activity
        {
            get => activity;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aktivitas tidak boleh kosong.");
                }

                activity = value.Trim();
            }
        }

        public string TampilkanInfoLog()
        {
            return $"User : {FullName} | Aktivitas: {Activity} | Waktu: {LogTime}";
        }

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