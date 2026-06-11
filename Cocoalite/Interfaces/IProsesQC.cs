using System;
using System.Collections.Generic;
using System.Text;

namespace Cocoalite.Interfaces
{
    public interface IProsesQC
    {
        void IsiParameter(
            decimal moistureLevel,
            decimal fermentationLevel,
            decimal defectLevel,
            string beanSize);
    }
}