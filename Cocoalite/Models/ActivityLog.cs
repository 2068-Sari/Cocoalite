using System;

namespace Cocoalite.Models
{
    internal class ActivityLog
    {
        private string activity = "";

        public int LogId { get; set; }
        public int UserId { get; set; }
        public DateTime LogTime { get; set; }

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
            return $"User ID: {UserId} | Aktivitas: {Activity} | Waktu: {LogTime}";
        }
    }
}