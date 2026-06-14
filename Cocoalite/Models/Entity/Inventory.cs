using System;
using System.Text;
using System.Linq;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    public class Inventory : IDapatDilaporkan
    {
        private int _inventoryId;
        private int _batchId;
        private DateTime _updatedAt;
        private decimal _stockQuantity;
        private string _warehouseLocation = "";
        private string _inventoryStatus = "Empty";


        public int InventoryId
        {
            get => _inventoryId;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Inventory ID tidak boleh negatif.");
                }

                _inventoryId = value;
            }
        }

        public int BatchId
        {
            get => _batchId;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Batch ID tidak valid.");
                }

                _batchId = value;
            }
        }

        public DateTime UpdatedAt
        {
            get => _updatedAt;
            set
            {
                if (value == default)
                    throw new ArgumentException("Waktu update tidak valid.");
                _updatedAt = value;
            }
        }

        public decimal StockQuantity
        {
            get => _stockQuantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stok tidak boleh negatif.");
                _stockQuantity = value;
                TentukanStatusStok();
            }
        }

        private static readonly string[] AllowedWarehouseLocations =
        {
            "Gudang Utama",
            "Gudang A",
            "Gudang B",
            "Gudang C"
         };
        public string WarehouseLocation
        {
            get
            {
                return _warehouseLocation;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Lokasi gudang tidak boleh kosong.");
                }

                string lokasi = value.Trim();

                if (!AllowedWarehouseLocations.Contains(lokasi))
                {
                    throw new ArgumentException("Lokasi gudang tidak valid.");
                }

                _warehouseLocation = lokasi;
            }
        }

        // InventoryStatus hanya bisa dibaca dari luar — tidak ada setter publik.
        // Status ditentukan secara otomatis oleh business rule di TentukanStatusStok().
        public string InventoryStatus => _inventoryStatus;

        private void TentukanStatusStok()
        {
            if (_stockQuantity == 0)
                _inventoryStatus = "Empty";
            else if (_stockQuantity < 300)
                _inventoryStatus = "Low Stock";
            else
                _inventoryStatus = "Available";
        }

        public string TampilkanInfoInventory()
        {
            return
                $"Batch ID: {_batchId} | " +
                $"Stok: {_stockQuantity} kg | " +
                $"Lokasi: {_warehouseLocation} | " +
                $"Status: {_inventoryStatus}";
        }

        public string BuatLaporan()
        {
            StringBuilder laporan = new StringBuilder();

            laporan.AppendLine("LAPORAN INVENTORY");
            laporan.AppendLine("==============================");
            laporan.AppendLine($"Inventory ID      : {_inventoryId}");
            laporan.AppendLine($"Batch ID          : {_batchId}");
            laporan.AppendLine($"Stock Quantity    : {_stockQuantity} kg");
            laporan.AppendLine($"Warehouse Location: {_warehouseLocation}");
            laporan.AppendLine($"Inventory Status  : {_inventoryStatus}");
            laporan.AppendLine($"Updated At        : {_updatedAt:dd-MM-yyyy HH:mm}");
            laporan.AppendLine("==============================");

            return laporan.ToString();
        }
    }
}
