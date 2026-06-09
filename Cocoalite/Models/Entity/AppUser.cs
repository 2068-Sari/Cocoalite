using Cocoalite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cocoalite.Models.Entity
{
    public abstract class AppUser : IPengguna
    {
        private string fullName = "";
        private string username = "";

        public int UserId { get; set; }

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nama lengkap tidak boleh kosong.");
                }

                fullName = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username tidak boleh kosong.");
                }

                username = value;
            }
        }

        public string Role { get; protected set; } = "";

        public abstract string TampilkanHakAkses();

        public virtual string TampilkanInfoUser()
        {
            return $"{FullName} ({Role})";
        }
    }
}
