using System;

namespace Cocoalite.Models.Entity
{
    internal class ActivityLog
    {
        public int LogId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; } = "";
        public DateTime LogTime { get; set; }

        private string activity = "";
        public string Activity
        {
            get
            {
                return activity;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aktivitas tidak boleh kosong.");
                }

                activity = value;
            }
        }

        public string TampilkanInfoLog()
        {
            return $"User : {FullName} | Aktivitas: {Activity} | Waktu: {LogTime}";
        }
    }
}