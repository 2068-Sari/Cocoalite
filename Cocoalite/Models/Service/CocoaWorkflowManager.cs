using System;
using System.Collections.Generic;
using Cocoalite.Models.Entity;

namespace Cocoalite.Models.Service
{
    internal class CocoaWorkflowManager
    {
        private readonly List<(string Tahap, string Keterangan)> daftarAlurProses;

        public CocoaWorkflowManager()
        {
            daftarAlurProses = new List<(string Tahap, string Keterangan)>();

            daftarAlurProses.Add((
                "Supplier",
                "Supplier menyediakan bahan baku kakao untuk perusahaan."
            ));

            daftarAlurProses.Add((
                "Receiving",
                "Admin mencatat penerimaan kakao dari supplier."
            ));

            daftarAlurProses.Add((
                "Quality Control",
                "Quality Controller memeriksa moisture, fermentation, defect, dan bean size."
            ));

            daftarAlurProses.Add((
                "Batch",
                "Data Quality Control yang Approved dapat diproses menjadi batch."
            ));

            daftarAlurProses.Add((
                "Inventory",
                "Batch yang sudah dibuat masuk ke stok gudang."
            ));

            daftarAlurProses.Add((
                "Shipment",
                "Stok batch dikirim ke tujuan distribusi."
            ));
        }

        public IReadOnlyList<(string Tahap, string Keterangan)> AmbilAlurProses()
        {
            return daftarAlurProses.AsReadOnly();
        }

        public bool ApakahQcBisaMenjadiBatch(QualityControl qc)
        {
            if (qc == null)
            {
                throw new ArgumentException("Data Quality Control tidak boleh kosong.");
            }

            return qc.QcStatus == "Approved" && qc.Grade != "Reject";
        }

        public void PastikanShipmentBisaDibuat(
            Inventory inventory,
            Shipment shipment)
                {
            if (inventory == null)
            {
                throw new ArgumentException("Data inventory tidak boleh kosong.");
            }

            if (shipment == null)
            {
                throw new ArgumentException("Data shipment tidak boleh kosong.");
            }

            if (shipment.ShipmentWeight <= 0)
            {
                throw new ArgumentException("Berat shipment harus lebih dari 0.");
            }

            if (inventory.StockQuantity < shipment.ShipmentWeight)
            {
                throw new ArgumentException(
                    "Stok inventory tidak mencukupi untuk melakukan shipment."
                );
            }

            if (inventory.InventoryStatus == "Empty")
            {
                throw new ArgumentException(
                    "Shipment tidak dapat dilakukan karena stok inventory kosong."
                );
            }
        }

        public void PastikanTransisiStatusShipment(
            string statusLama,
            string statusBaru)
        {
            if (string.IsNullOrWhiteSpace(statusBaru))
            {
                throw new ArgumentException("Status shipment tidak boleh kosong.");
            }

            if (statusLama == "Cancelled")
            {
                throw new ArgumentException(
                    "Shipment yang sudah Cancelled tidak dapat diubah lagi."
                );
            }

            if (statusLama == "Delivered" && statusBaru == "Cancelled")
            {
                throw new ArgumentException(
                    "Shipment yang sudah Delivered tidak dapat dibatalkan."
                );
            }
        }

        public string TentukanStatusBatch(
            decimal stokTersisa,
            decimal beratBatch)
        {
            if (beratBatch <= 0)
            {
                throw new ArgumentException("Berat batch harus lebih dari 0.");
            }

            if (stokTersisa == 0)
            {
                return "Distributed";
            }

            if (stokTersisa < beratBatch)
            {
                return "Partially Distributed";
            }

            return "Available";
        }

        public string JelaskanAlurProses()
        {
            string hasil = "Alur CocoaLite:" + Environment.NewLine;

            foreach ((string Tahap, string Keterangan) alur in daftarAlurProses)
            {
                hasil += "- " + alur.Tahap + ": " + alur.Keterangan + Environment.NewLine;
            }

            return hasil;
        }
    }
}