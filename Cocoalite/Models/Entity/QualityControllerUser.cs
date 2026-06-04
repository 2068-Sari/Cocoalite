using System;
using System.Collections.Generic;
using System.Text;

namespace Cocoalite.Models.Entity
{
    internal class QualityControllerUser : AppUser
    {
        public QualityControllerUser()
        {
            Role = "qc";
        }

        public override string TampilkanHakAkses()
        {
            return "Quality Controller melakukan pemeriksaan kualitas kakao, menentukan grade, serta memberikan status Approved atau Rejected pada hasil QC.";
        }

        public override string TampilkanInfoUser()
        {
            return $"Quality Controller: {FullName}";
        }
    }
}