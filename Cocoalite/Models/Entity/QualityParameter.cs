using System;
using System.Collections.Generic;
using System.Text;

namespace Cocoalite.Models.Entity
{
    internal class QualityParameter
    {
        private decimal moistureLevel;
        private decimal fermentationLevel;
        private decimal defectLevel;
        private string beanSize = "";


        public decimal MoistureLevel
        {
            get
            {
                return moistureLevel;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Moisture level harus berada antara 0 sampai 100.");
                }

                moistureLevel = value;
            }
        }

        public decimal FermentationLevel
        {
            get
            {
                return fermentationLevel;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Fermentation level harus berada antara 0 sampai 100.");
                }

                fermentationLevel = value;
            }
        }

        public decimal DefectLevel
        {
            get
            {
                return defectLevel;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Defect level harus berada antara 0 sampai 100.");
                }

                defectLevel = value;
            }
        }

        public string BeanSize
        {
            get
            {
                return beanSize;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Bean size tidak boleh kosong.");
                }

                beanSize = value;
            }
        }

        public string TampilkanInfoParameter()
        {
            return $"Moisture: {MoistureLevel}, Fermentation: {FermentationLevel}, Defect: {DefectLevel}, Bean Size: {BeanSize}";
        }
    }
}
