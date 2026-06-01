using System;
using Cocoalite.Interfaces;

namespace Cocoalite.Models
{
    internal class QualityControl : IDapatDilaporkan
    {
        private string grade = "";
        private string qcStatus = "";
        private string inspectionNotes = "";

        public int QcId { get; set; }
        public int ReceivingId { get; set; }
        public int InspectedBy { get; set; }

        public QualityParameter Parameter { get; private set; }

        public QualityControl()
        {
            Parameter = new QualityParameter();
        }

        public string Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Grade tidak boleh kosong.");
                }

                grade = value;
            }
        }

        public string QcStatus
        {
            get
            {
                return qcStatus;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Status QC tidak boleh kosong.");
                }

                qcStatus = value;
            }
        }

        public string InspectionNotes
        {
            get
            {
                return inspectionNotes;
            }
            set
            {
                inspectionNotes = value ?? "";
            }
        }

        public DateTime InspectionDate { get; set; }

        public void IsiParameter(
            decimal moistureLevel,
            decimal fermentationLevel,
            decimal defectLevel,
            string beanSize)
        {
            Parameter.MoistureLevel = moistureLevel;
            Parameter.FermentationLevel = fermentationLevel;
            Parameter.DefectLevel = defectLevel;
            Parameter.BeanSize = beanSize;
        }

        public string TampilkanInfoQualityControl()
        {
            return $"QC ID: {QcId} | Receiving ID: {ReceivingId} | Grade: {Grade} | Status: {QcStatus}";
        }

        public string BuatLaporan()
        {
            return $"Laporan QC - Receiving ID: {ReceivingId}, Grade: {Grade}, Status: {QcStatus}, Parameter: {Parameter.TampilkanInfoParameter()}";
        }
    }
}