using System.Collections.Generic;
using System.Text;
using Cocoalite.Interfaces;

namespace Cocoalite.Controllers
{
    internal class ReportController
    {
        public string BuatLaporanGabungan(List<IDapatDilaporkan> daftarLaporan)
        {
            StringBuilder laporan = new StringBuilder();

            laporan.AppendLine("LAPORAN OPERASIONAL COCOALITE");
            laporan.AppendLine("PT Cacao Prima Nusantara");
            laporan.AppendLine("========================================");
            laporan.AppendLine();

            foreach (IDapatDilaporkan item in daftarLaporan)
            {
                laporan.AppendLine(item.BuatLaporan());
                laporan.AppendLine();
            }

            return laporan.ToString();
        }

        public string BuatLaporanTunggal(IDapatDilaporkan item)
        {
            return item.BuatLaporan();
        }
    }
}