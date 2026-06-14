using System;
using System.Text;
using System.Linq;
using Cocoalite.Interfaces;

namespace Cocoalite.Models.Entity
{
    public class QualityControl : IDapatDilaporkan, IProsesQC
    {
        private int _qcId;
        private int _receivingId;
        private int _inspectedBy;
        private DateTime _inspectionDate;
        private string _grade = "";
        private string _qcStatus = "";
        private string _inspectionNotes = "";

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

        public int QcId
        {
            get => _qcId;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("QC ID tidak boleh negatif.");
                }

                _qcId = value;
            }
        }

        public int ReceivingId
        {
            get => _receivingId;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Receiving ID tidak valid.");
                }

                _receivingId = value;
            }
        }

        public int InspectedBy
        {
            get => _inspectedBy;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("User pemeriksa tidak valid.");
                }

                _inspectedBy = value;
            }
        }

        public DateTime InspectionDate
        {
            get => _inspectionDate;
            set
            {
                if (value == default)
                    throw new ArgumentException("Tanggal inspeksi tidak valid.");
                _inspectionDate = value;
            }
        }

        public string Grade
        {
            get => _grade;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Grade tidak boleh kosong.");

                string newGrade = value.Trim();

                if (!AllowedGrades.Contains(newGrade))
                    throw new ArgumentException("Grade tidak valid.");

                _grade = newGrade;
            }
        }

        public string QcStatus
        {
            get => _qcStatus;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Status QC tidak boleh kosong.");

                string newStatus = value.Trim();

                if (!AllowedStatuses.Contains(newStatus))
                    throw new ArgumentException("Status QC tidak valid.");

                _qcStatus = newStatus;
            }
        }

        public string InspectionNotes
        {
            get => _inspectionNotes;
            set { _inspectionNotes = value ?? ""; }
        }

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
        /// Menghitung grade langsung dari Parameter domain object,
        /// tanpa bergantung pada database.
        /// </summary>
        public void TerapkanHasilDariParameter()
        {
            string hasilGrade = Parameter.TentukanGrade();
            TerapkanHasilPemeriksaan(hasilGrade);
        }

        public string TampilkanInfoQualityControl()
        {
            return
                $"QC ID: {_qcId} | " +
                $"Receiving ID: {_receivingId} | " +
                $"Grade: {_grade} | " +
                $"Status: {_qcStatus}";
        }

        public string BuatLaporan()
        {
            StringBuilder laporan = new StringBuilder();

            laporan.AppendLine("LAPORAN QUALITY CONTROL");
            laporan.AppendLine("==============================");
            laporan.AppendLine($"QC ID              : {_qcId}");
            laporan.AppendLine($"Receiving ID       : {_receivingId}");
            laporan.AppendLine($"Inspected By       : {_inspectedBy}");
            laporan.AppendLine($"Moisture Level     : {Parameter.MoistureLevel}%");
            laporan.AppendLine($"Fermentation Level : {Parameter.FermentationLevel}%");
            laporan.AppendLine($"Defect Level       : {Parameter.DefectLevel}%");
            laporan.AppendLine($"Bean Size          : {Parameter.BeanSize}");
            laporan.AppendLine($"Grade              : {_grade}");
            laporan.AppendLine($"QC Status          : {_qcStatus}");
            laporan.AppendLine($"Inspection Notes   : {_inspectionNotes}");
            laporan.AppendLine($"Inspection Date    : {_inspectionDate:dd-MM-yyyy}");
            laporan.AppendLine("==============================");

            return laporan.ToString();
        }
    }
}