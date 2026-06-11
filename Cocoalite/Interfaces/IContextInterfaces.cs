using System;
using System.Data;
using System.Collections.Generic;
using Cocoalite.Models.Entity;

namespace Cocoalite.Interfaces
{
    public interface ILoginContext
    {
        AppUser? GetUserByLogin(string username, string password);

        bool ChangePassword(
            int userId,
            string oldPassword,
            string newPassword);

        DataTable GetAllQcUsers();

        bool IsUsernameExists(string username);

        void AddQcUser(
            string fullName,
            string username,
            string password,
            string recoveryCode); 

        void DeleteQcUser(int userId);
        bool ResetPasswordBySecurityAnswer(
            string username,
            string securityAnswer,
            string newPassword);

        void SetRecoveryCode(int userId, string recoveryCode);
    }

    public interface IReceivingContext
    {
        DataTable GetSuppliers();

        DataTable GetAllReceiving();

        void InsertReceiving(
            int supplierId,
            int receivedBy,
            string receivingCode,
            DateTime receivingDate,
            decimal cocoaWeight,
            string vehicleNumber);

        void UpdateReceiving(
            int receivingId,
            int supplierId,
            string receivingCode,
            DateTime receivingDate,
            decimal cocoaWeight,
            string vehicleNumber);

        void DeleteReceiving(int receivingId);
    }

    public interface IBatchContext
    {
        DataTable GetApprovedQc();

        DataTable GetAllBatch();

        void InsertBatch(Batch batch);

        void UpdateBatch(Batch batch);

        void DeleteBatch(int batchId);
    }
    public interface IShipmentContext
    {
        List<Shipment> GetReportShipment();

        DataTable GetAllBatch();

        DataTable GetAllUsers();

        DataTable GetAllShipment();

        void InsertShipment(Shipment shipment);

        void UpdateShipment(
            int shipmentId,
            string destination,
            DateTime shipmentDate,
            string shipmentStatus,
            string vehicleNumber,
            string driverName);

        void DeleteShipment(int shipmentId);
    }
    public interface IInventoryContext
    {
        DataTable GetAllInventory();

        List<Inventory> GetReportInventory();

        DataTable GetAllBatch();

        void InsertInventory(Inventory inventory);

        void UpdateInventory(Inventory inventory);

        void DeleteInventory(int inventoryId);
    }
    public interface IQualityControlContext
    {
        DataTable GetAllQualityControl();

        List<QualityControl> GetReportQualityControl();

        DataTable GetAllReceiving();

        string DetermineGrade(
            decimal moistureLevel,
            decimal fermentationLevel,
            decimal defectLevel);

        void InsertQualityControl(QualityControl qc);

        void UpdateQualityControl(QualityControl qc);

        void DeleteQualityControl(int qcId);
    }

    public interface ISupplierContext
    {
        DataTable GetAllSuppliers();

        void InsertSupplier(Supplier supplier);

        void UpdateSupplier(Supplier supplier);

        void DeleteSupplier(int supplierId);
    }
}