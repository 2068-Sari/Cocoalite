using System;
using System.Data;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;

namespace Cocoalite.Controllers
{
    internal class QualityControlController
    {
        private readonly QualityControlContext context =
            new QualityControlContext();

        public DataTable GetAllQualityControl()
        {
            DataTable data = context.GetAllQualityControl();

            if (data != null)
            {
                return data;
            }

            return new DataTable();
        }

        public DataTable GetAllReceiving()
        {
            DataTable data = context.GetAllReceiving();

            if (data != null)
            {
                return data;
            }

            return new DataTable();
        }

        public string DetermineGrade(
            decimal moistureLevel,
            decimal fermentationLevel,
            decimal defectLevel)
        {
            return context.DetermineGrade(
                moistureLevel,
                fermentationLevel,
                defectLevel
            );
        }

        public void AddQualityControl(QualityControl qc)
        {
            if (qc == null)
            {
                throw new ArgumentNullException(nameof(qc), "Objek Quality Control kosong.");
            }

            context.InsertQualityControl(qc);
        }

        public void UpdateQualityControl(QualityControl qc)
        {
            if (qc == null)
            {
                throw new ArgumentNullException(nameof(qc), "Objek Quality Control kosong.");
            }

            if (qc.QcId <= 0)
            {
                throw new ArgumentException("ID Quality Control tidak valid.");
            }

            context.UpdateQualityControl(qc);
        }

        public void DeleteQualityControl(int qcId)
        {
            if (qcId <= 0)
            {
                throw new ArgumentException("ID Quality Control tidak valid.");
            }

            context.DeleteQualityControl(qcId);
        }
    }
}