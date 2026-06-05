using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Cocoalite.Models.Entity
{
    internal class Supplier
    {
        private string supplierName = "";
        private string address = "";
        private string phoneNumber = "";
        private string email = "";

        public int SupplierId { get; set; }

        public string SupplierName
        {
            get
            {
                return supplierName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nama supplier tidak boleh kosong.");
                }

                supplierName = value;
            }
        }

        public string Address
        {
            get { return address; }
            set { address = value ?? ""; }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) &&
                    !Regex.IsMatch(value.Trim(), @"^[0-9\s\+\-\(\)]{7,20}$"))
                {
                    throw new ArgumentException("Format nomor telepon tidak valid.");
                }

                phoneNumber = value?.Trim() ?? "";
            }
        }


        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && !value.Contains("@"))
                {
                    throw new ArgumentException("Format email supplier tidak valid.");
                }

                email = value ?? "";
            }
        }

        public string TampilkanInfoSupplier()
        {
            return $"Supplier: {SupplierName} | Telepon: {PhoneNumber} | Email: {Email}";
        }
    }
}