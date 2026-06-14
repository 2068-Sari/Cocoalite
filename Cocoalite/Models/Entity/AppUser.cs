using Cocoalite.Interfaces;
using System;

namespace Cocoalite.Models.Entity
{
    public abstract class AppUser : IPengguna
    {
        // =====================================================================
        // Private backing fields untuk semua atribut.
        // UserId harus > 0 setelah diisi dari database.
        // FullName dan Username divalidasi agar tidak kosong (business rule).
        // Role diset oleh subclass melalui protected set — tidak bisa diubah
        // dari luar, mencegah eskalasi hak akses secara tidak sah.
        // =====================================================================
        private int _userId;
        private string _fullName = "";
        private string _username = "";

        public int UserId
        {
            get => _userId;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("User ID tidak boleh negatif.");
                }

                _userId = value;
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nama lengkap tidak boleh kosong.");
                _fullName = value;
            }
        }

        public string Username
        {
            get => _username;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Username tidak boleh kosong.");
                _username = value;
            }
        }

        public string Role { get; protected set; } = "";

        public abstract string TampilkanHakAkses();

        public virtual string TampilkanInfoUser()
        {
            return $"{_fullName} ({Role})";
        }
    }
}