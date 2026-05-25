using System;
using System.Collections.Generic;
using System.Text;

namespace Cocoalite.Models
{
    internal class QualityControl
    {
        public int QcId { get; set; }

        public int ReceivingId { get; set; }

        public int InspectedBy { get; set; }

        public decimal MoistureLevel { get; set; }

        public decimal FermentationLevel { get; set; }

        public decimal DefectLevel { get; set; }

        public string BeanSize { get; set; }

        public string Grade { get; set; }

        public string QcStatus { get; set; }

        public string InspectionNotes { get; set; }

        public DateTime InspectionDate { get; set; }
    }
}
