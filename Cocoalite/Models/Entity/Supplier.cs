using System;
using System.Text.RegularExpressions;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    public class Supplier : IDapatDilaporkan
    {
        private static readonly Regex _emailRegex = new Regex(
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private string _supplierName = "";
        private string _address = "";
        private string _phoneNumber = "";
        private string _email = "";

        public int SupplierId { get; set; }

        public string SupplierName
        {
            get => _supplierName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nama supplier tidak boleh kosong.");

                _supplierName = value.Trim();
            }
        }

        public string Address
        {
            get => _address;
            set => _address = value?.Trim() ?? "";
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) &&
                    !Regex.IsMatch(value.Trim(), @"^[0-9\s\+\-\(\)]{7,20}$"))
                {
                    throw new ArgumentException("Format nomor telepon tidak valid.");
                }

                _phoneNumber = value?.Trim() ?? "";
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) &&
                    !_emailRegex.IsMatch(value.Trim()))
                {
                    throw new ArgumentException("Format email supplier tidak valid. Contoh: nama@domain.com");
                }

                _email = value?.Trim() ?? "";
            }
        }

        public string TampilkanInfoSupplier()
        {
            return $"Supplier: {SupplierName} | Telepon: {PhoneNumber} | Email: {Email}";
        }

        public string BuatLaporan()
        {
            return
                $"LAPORAN SUPPLIER\n" +
                $"==============================\n" +
                $"Supplier ID  : {SupplierId}\n" +
                $"Nama         : {SupplierName}\n" +
                $"Alamat       : {Address}\n" +
                $"Telepon      : {PhoneNumber}\n" +
                $"Email        : {Email}\n" +
                $"==============================";
        }
    }
}