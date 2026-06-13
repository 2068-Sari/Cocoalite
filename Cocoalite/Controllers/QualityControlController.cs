using System;
using System.Data;
using System.Collections.Generic;
using Cocoalite.Interfaces;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;

namespace Cocoalite.Controllers
{
    internal class QualityControlController
    {
        private readonly IQualityControlContext _context;

        public QualityControlController()
        {
            _context = new QualityControlContext();
        }

        public QualityControlController(IQualityControlContext context)
        {
            _context = context;
        }

        public DataTable GetAllQualityControl()
        {
            DataTable data = _context.GetAllQualityControl();

            if (data != null)
            {
                return data;
            }

            return new DataTable();
        }

        public List<QualityControl> GetReportQualityControl()
        {
            return _context.GetReportQualityControl();
        }

        public DataTable GetAllReceiving()
        {
            DataTable data = _context.GetAllReceiving();

            if (data != null)
            {
                return data;
            }

            return new DataTable();
        }

        /// <summary>
        /// Menentukan grade kakao berdasarkan parameter kualitas.
        ///
        /// PERBAIKAN: Tidak lagi memanggil database. Grade sekarang dihitung
        /// langsung oleh domain model QualityParameter.TentukanGrade(), yang
        /// merupakan satu-satunya sumber kebenaran untuk business rule ini.
        /// </summary>
        public string DetermineGrade(
            decimal moistureLevel,
            decimal fermentationLevel,
            decimal defectLevel)
        {
            // Validasi range diurus oleh setter QualityParameter (lempar ArgumentException)
            QualityParameter parameter = new QualityParameter();
            parameter.MoistureLevel = moistureLevel;
            parameter.FermentationLevel = fermentationLevel;
            parameter.DefectLevel = defectLevel;

            // Domain model yang menentukan grade — bukan stored function DB
            return parameter.TentukanGrade();
        }

        public void AddQualityControl(QualityControl qc)
        {
            if (qc == null)
            {
                throw new ArgumentNullException(nameof(qc), "Objek Quality Control kosong.");
            }

            _context.InsertQualityControl(qc);
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

            _context.UpdateQualityControl(qc);
        }

        public void DeleteQualityControl(int qcId)
        {
            if (qcId <= 0)
            {
                throw new ArgumentException("ID Quality Control tidak valid.");
            }

            _context.DeleteQualityControl(qcId);
        }
    }
}