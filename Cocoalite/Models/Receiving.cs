using System;
using System.Collections.Generic;
using System.Text;

namespace Cocoalite.Models
{
    internal class Receiving
    {
        public int ReceivingId { get; set; }

        public int SupplierId { get; set; }

        public int ReceivedBy { get; set; }

        public string ReceivingCode { get; set; }

        public DateTime ReceivingDate { get; set; }

        public decimal CocoaWeight { get; set; }

        public string VehicleNumber { get; set; }
    }
}
