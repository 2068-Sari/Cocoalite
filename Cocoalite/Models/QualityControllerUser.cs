using System;
using System.Collections.Generic;
using System.Text;

namespace Cocoalite.Models
{
    internal class QualityControllerUser : AppUser
    {
        public QualityControllerUser()
        {
            Role = "qc";
        }

        public override string TampilkanHakAkses()
        {
            return "Quality Controller melakukan pemeriksaan kualitas kakao, menentukan grade, dan approval atau reject batch.";
        }

        public override string TampilkanInfoUser()
        {
            return $"Quality Controller: {FullName}";
        }
    }
}