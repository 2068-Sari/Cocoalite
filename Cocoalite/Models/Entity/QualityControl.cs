using System;
using System.Text;
using System.Linq;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    public class QualityControl : IDapatDilaporkan, IProsesQC
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

        private static readonly string[] AllowedGrades =
        {
            "Grade A",
            "Grade B",
            "Grade C",
            "Reject"
        };

        private static readonly string[] AllowedStatuses =
        {
            "Approved",
            "Rejected"
        };

        public string Grade
        {
            get { return grade; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Grade tidak boleh kosong.");

                string newGrade = value.Trim();

                if (!AllowedGrades.Contains(newGrade))
                    throw new ArgumentException("Grade tidak valid.");

                grade = newGrade;
            }
        }

        public string QcStatus
        {
            get { return qcStatus; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Status QC tidak boleh kosong.");

                string newStatus = value.Trim();

                if (!AllowedStatuses.Contains(newStatus))
                    throw new ArgumentException("Status QC tidak valid.");

                qcStatus = newStatus;
            }
        }

        public string InspectionNotes
        {
            get { return inspectionNotes; }
            set { inspectionNotes = value ?? ""; }
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

        public void TerapkanHasilPemeriksaan(string hasilGrade)
        {
            Grade = hasilGrade;
            QcStatus = (Grade == "Reject") ? "Rejected" : "Approved";
        }

        /// <summary>
        /// Alternatif TerapkanHasilPemeriksaan yang menghitung grade langsung
        /// dari Parameter domain object, tanpa bergantung pada database.
        /// Memanfaatkan QualityParameter.TentukanGrade() sebagai business rule
        /// yang melekat di domain model (bukan di stored function DB).
        /// </summary>
        public void TerapkanHasilDariParameter()
        {
            string hasilGrade = Parameter.TentukanGrade();
            TerapkanHasilPemeriksaan(hasilGrade);
        }

        public string TampilkanInfoQualityControl()
        {
            return
                $"QC ID: {QcId} | " +
                $"Receiving ID: {ReceivingId} | " +
                $"Grade: {Grade} | " +
                $"Status: {QcStatus}";
        }

        public string BuatLaporan()
        {
            StringBuilder laporan = new StringBuilder();

            laporan.AppendLine("LAPORAN QUALITY CONTROL");
            laporan.AppendLine("==============================");
            laporan.AppendLine($"QC ID              : {QcId}");
            laporan.AppendLine($"Receiving ID       : {ReceivingId}");
            laporan.AppendLine($"Inspected By       : {InspectedBy}");
            laporan.AppendLine($"Moisture Level     : {Parameter.MoistureLevel}%");
            laporan.AppendLine($"Fermentation Level : {Parameter.FermentationLevel}%");
            laporan.AppendLine($"Defect Level       : {Parameter.DefectLevel}%");
            laporan.AppendLine($"Bean Size          : {Parameter.BeanSize}");
            laporan.AppendLine($"Grade              : {Grade}");
            laporan.AppendLine($"QC Status          : {QcStatus}");
            laporan.AppendLine($"Inspection Notes   : {InspectionNotes}");
            laporan.AppendLine($"Inspection Date    : {InspectionDate:dd-MM-yyyy}");
            laporan.AppendLine("==============================");

            return laporan.ToString();
        }
    }
}