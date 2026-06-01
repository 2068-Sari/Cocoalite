namespace Cocoalite.Models.Entity
{
    internal class DashboardSummary
    {
        public int TotalSupplier { get; set; }
        public int TotalReceiving { get; set; }
        public int TotalQc { get; set; }
        public int TotalBatch { get; set; }
        public decimal TotalStok { get; set; }
        public int TotalShipment { get; set; }

        public string TampilkanInfoDashboard()
        {
            return $"Supplier: {TotalSupplier} | Receiving: {TotalReceiving} | QC: {TotalQc} | Batch: {TotalBatch} | Stok: {TotalStok} kg | Shipment: {TotalShipment}";
        }
    }
}