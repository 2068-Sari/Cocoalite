using System;
using System.Collections.Generic;
using System.Text;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    internal class Inventory : IDapatDilaporkan
    {
        private decimal stockQuantity;
        private string warehouseLocation = "";
        private string inventoryStatus = "Empty";

        public int InventoryId { get; set; }
        public int BatchId { get; set; }
        public DateTime UpdatedAt { get; set; }

        public decimal StockQuantity
        {
            get
            {
                return stockQuantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Stok tidak boleh negatif.");
                }

                stockQuantity = value;
                TentukanStatusStok();
            }
        }

        public string WarehouseLocation
        {
            get
            {
                return warehouseLocation;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Lokasi gudang tidak boleh kosong.");
                }

                warehouseLocation = value;
            }
        }

        public string InventoryStatus
        {
            get
            {
                return inventoryStatus;
            }
        }

        private void TentukanStatusStok()
        {
            if (stockQuantity == 0)
            {
                inventoryStatus = "Empty";
            }
            else if (stockQuantity < 300)
            {
                inventoryStatus = "Low Stock";
            }
            else
            {
                inventoryStatus = "Available";
            }
        }

        public string TampilkanInfoInventory()
        {
            return $"Batch ID: {BatchId} | Stok: {StockQuantity} kg | Lokasi: {WarehouseLocation} | Status: {InventoryStatus}";
        }

        public string BuatLaporan()
        {
            return $"Laporan Inventory - Batch ID: {BatchId}, Stok: {StockQuantity} kg, Lokasi: {WarehouseLocation}, Status: {InventoryStatus}";
        }
    }
}
