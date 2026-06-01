using System;
using System.Data;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;

namespace Cocoalite.Controllers
{
    internal class InventoryController
    {
        private readonly InventoryContext _context = new InventoryContext();

        public DataTable GetAllInventory()
        {
            DataTable data = _context.GetAllInventory();

            if (data != null)
            {
                return data;
            }

            return new DataTable();
        }

        public DataTable GetAllBatch()
        {
            DataTable data = _context.GetAllBatch();

            if (data != null)
            {
                return data;
            }

            return new DataTable();
        }

        public void AddInventory(
            int batchId,
            decimal stockQuantity,
            string warehouseLocation)
        {
            Inventory inventory = new Inventory();

            inventory.BatchId = batchId;
            inventory.StockQuantity = stockQuantity;
            inventory.WarehouseLocation = warehouseLocation;

            _context.InsertInventory(inventory);
        }

        public void UpdateInventory(
            int inventoryId,
            int batchId,
            decimal stockQuantity,
            string warehouseLocation)
        {
            if (inventoryId <= 0)
            {
                throw new ArgumentException("ID inventory tidak valid.");
            }

            Inventory inventory = new Inventory();

            inventory.InventoryId = inventoryId;
            inventory.BatchId = batchId;
            inventory.StockQuantity = stockQuantity;
            inventory.WarehouseLocation = warehouseLocation;

            _context.UpdateInventory(inventory);
        }

        public void DeleteInventory(int inventoryId)
        {
            if (inventoryId <= 0)
            {
                throw new ArgumentException("ID inventory tidak valid.");
            }

            _context.DeleteInventory(inventoryId);
        }
    }
}