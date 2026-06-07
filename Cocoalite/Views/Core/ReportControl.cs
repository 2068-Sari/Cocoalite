using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Cocoalite.Controllers;
using Cocoalite.Helpers;
using Cocoalite.Interfaces;
using Cocoalite.Models.Entity;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


namespace Cocoalite.Views
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
        }

        private void ReportControl_Load(object sender, EventArgs e)
        {
            LoadJenisLaporan();
        }

        private void LoadJenisLaporan()
        {
            cbJenisLaporan.Items.Clear();
            cbJenisLaporan.DropDownStyle = ComboBoxStyle.DropDownList;

            if (LoginSession.IsAdmin())
            {
                cbJenisLaporan.Items.Add("Inventory");
                cbJenisLaporan.Items.Add("Quality Control");
                cbJenisLaporan.Items.Add("Shipment");
                cbJenisLaporan.Items.Add("Gabungan");
            }
            else if (LoginSession.IsQualityController())
            {
                cbJenisLaporan.Items.Add("Quality Control");
            }

            cbJenisLaporan.SelectedIndex = -1;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cbJenisLaporan.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Pilih jenis laporan terlebih dahulu.",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                ReportController controller = new ReportController();

                string jenisLaporan = cbJenisLaporan.Text;
                if (LoginSession.IsQualityController() && jenisLaporan != "Quality Control")
                {
                    MessageBox.Show(
                        "Role QC hanya dapat mengakses laporan Quality Control.",
                        "Akses Ditolak",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (jenisLaporan == "Inventory")
                {
                    InventoryController inventoryController =
                        new InventoryController();

                    List<Inventory> daftarInventory =
                        inventoryController.GetReportInventory();

                    if (daftarInventory.Count == 0)
                    {
                        txtReport.Text = "Belum ada data Inventory.";
                        return;
                    }

                    StringBuilder laporan = new StringBuilder();

                    laporan.AppendLine("LAPORAN INVENTORY COCOALITE");
                    laporan.AppendLine("PT Cacao Prima Nusantara");
                    laporan.AppendLine("Tanggal Cetak: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
                    laporan.AppendLine();
                    laporan.AppendLine(new string('=', 115));

                    laporan.AppendLine(
                        "No".PadRight(5) +
                        "Inventory ID".PadRight(15) +
                        "Batch ID".PadRight(12) +
                        "Stock".PadRight(15) +
                        "Warehouse".PadRight(25) +
                        "Status".PadRight(15) +
                        "Updated At"
                    );

                    laporan.AppendLine(new string('=', 115));

                    int nomor = 1;

                    foreach (Inventory inventory in daftarInventory)
                    {
                        laporan.AppendLine(
                            nomor.ToString().PadRight(5) +
                            inventory.InventoryId.ToString().PadRight(15) +
                            inventory.BatchId.ToString().PadRight(12) +
                            (inventory.StockQuantity.ToString("N2") + " kg").PadRight(15) +
                            inventory.WarehouseLocation.PadRight(25) +
                            inventory.InventoryStatus.PadRight(15) +
                            inventory.UpdatedAt.ToString("dd-MM-yyyy HH:mm")
                        );

                        nomor++;
                    }

                    laporan.AppendLine(new string('=', 115));
                    laporan.AppendLine("Total Data Inventory: " + daftarInventory.Count);
                    laporan.AppendLine("Total Stok          : " +
                        daftarInventory.Sum(i => i.StockQuantity).ToString("N2") + " kg");

                    txtReport.Text = laporan.ToString();
                }
                else if (jenisLaporan == "Quality Control")
                {
                    QualityControlController qcController =
                        new QualityControlController();

                    List<QualityControl> daftarQc =
                        qcController.GetReportQualityControl();

                    if (daftarQc.Count == 0)
                    {
                        txtReport.Text = "Belum ada data Quality Control.";
                        return;
                    }

                    StringBuilder laporan = new StringBuilder();

                    laporan.AppendLine("LAPORAN QUALITY CONTROL COCOALITE");
                    laporan.AppendLine("PT Cacao Prima Nusantara");
                    laporan.AppendLine("Tanggal Cetak: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
                    laporan.AppendLine();

                    laporan.AppendLine(new string('=', 135));

                    laporan.AppendLine(
                        "No".PadRight(5) +
                        "QC ID".PadRight(8) +
                        "Receiving".PadRight(12) +
                        "Moisture".PadRight(12) +
                        "Fermentasi".PadRight(14) +
                        "Defect".PadRight(10) +
                        "Bean Size".PadRight(12) +
                        "Grade".PadRight(12) +
                        "Status".PadRight(12) +
                        "Inspection Date".PadRight(18) +
                        "Notes"
                    );

                    laporan.AppendLine(new string('=', 135));

                    int nomor = 1;

                    foreach (QualityControl qc in daftarQc)
                    {
                        string notes = qc.InspectionNotes;

                        if (notes.Length > 25)
                        {
                            notes = notes.Substring(0, 25) + "...";
                        }

                        laporan.AppendLine(
                            nomor.ToString().PadRight(5) +
                            qc.QcId.ToString().PadRight(8) +
                            qc.ReceivingId.ToString().PadRight(12) +
                            qc.Parameter.MoistureLevel.ToString("N2").PadRight(12) +
                            qc.Parameter.FermentationLevel.ToString("N2").PadRight(14) +
                            qc.Parameter.DefectLevel.ToString("N2").PadRight(10) +
                            qc.Parameter.BeanSize.PadRight(12) +
                            qc.Grade.PadRight(12) +
                            qc.QcStatus.PadRight(12) +
                            qc.InspectionDate.ToString("dd-MM-yyyy").PadRight(18) +
                            notes
                        );

                        nomor++;
                    }

                    laporan.AppendLine(new string('=', 135));
                    laporan.AppendLine("Total Data QC: " + daftarQc.Count);
                    laporan.AppendLine();

                    int totalApproved = daftarQc.Count(qc => qc.QcStatus == "Approved");
                    int totalRejected = daftarQc.Count(qc => qc.QcStatus == "Rejected");

                    laporan.AppendLine("RINGKASAN");
                    laporan.AppendLine("----------------------------------------");
                    laporan.AppendLine("Total Approved : " + totalApproved);
                    laporan.AppendLine("Total Rejected : " + totalRejected);
                    laporan.AppendLine("----------------------------------------");

                    txtReport.Text = laporan.ToString();
                }

                else if (jenisLaporan == "Shipment")
                {
                    ShipmentController shipmentController =
                        new ShipmentController();

                    List<Shipment> daftarShipment =
                        shipmentController.GetReportShipment();

                    if (daftarShipment.Count == 0)
                    {
                        txtReport.Text = "Belum ada data Shipment.";
                        return;
                    }

                    StringBuilder laporan = new StringBuilder();

                    laporan.AppendLine("LAPORAN SHIPMENT COCOALITE");
                    laporan.AppendLine("PT Cacao Prima Nusantara");
                    laporan.AppendLine("Tanggal Cetak: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
                    laporan.AppendLine();
                    laporan.AppendLine(new string('=', 145));

                    laporan.AppendLine(
                        "No".PadRight(5) +
                        "Shipment ID".PadRight(14) +
                        "Batch ID".PadRight(10) +
                        "Code".PadRight(18) +
                        "Destination".PadRight(25) +
                        "Date".PadRight(14) +
                        "Weight".PadRight(14) +
                        "Status".PadRight(14) +
                        "Vehicle".PadRight(15) +
                        "Driver"
                    );

                    laporan.AppendLine(new string('=', 145));

                    int nomor = 1;

                    foreach (Shipment shipment in daftarShipment)
                    {
                        string destination = shipment.Destination;

                        if (destination.Length > 22)
                        {
                            destination = destination.Substring(0, 22) + "...";
                        }

                        laporan.AppendLine(
                            nomor.ToString().PadRight(5) +
                            shipment.ShipmentId.ToString().PadRight(14) +
                            shipment.BatchId.ToString().PadRight(10) +
                            shipment.ShipmentCode.PadRight(18) +
                            destination.PadRight(25) +
                            shipment.ShipmentDate.ToString("dd-MM-yyyy").PadRight(14) +
                            (shipment.ShipmentWeight.ToString("N2") + " kg").PadRight(14) +
                            shipment.ShipmentStatus.PadRight(14) +
                            shipment.VehicleNumber.PadRight(15) +
                            shipment.DriverName
                        );

                        nomor++;
                    }

                    laporan.AppendLine(new string('=', 145));
                    laporan.AppendLine("Total Data Shipment : " + daftarShipment.Count);
                    laporan.AppendLine("Total Berat Kirim   : " +
                        daftarShipment.Sum(s => s.ShipmentWeight).ToString("N2") + " kg");

                    laporan.AppendLine();
                    laporan.AppendLine("RINGKASAN STATUS");
                    laporan.AppendLine("----------------------------------------");
                    laporan.AppendLine("Pending   : " + daftarShipment.Count(s => s.ShipmentStatus == "Pending"));
                    laporan.AppendLine("Shipped   : " + daftarShipment.Count(s => s.ShipmentStatus == "Shipped"));
                    laporan.AppendLine("Delivered : " + daftarShipment.Count(s => s.ShipmentStatus == "Delivered"));
                    laporan.AppendLine("Cancelled : " + daftarShipment.Count(s => s.ShipmentStatus == "Cancelled"));

                    txtReport.Text = laporan.ToString();
                }
                else if (jenisLaporan == "Gabungan")
                {
                    if (!LoginSession.IsAdmin())
                    {
                        MessageBox.Show(
                            "Laporan gabungan hanya dapat diakses oleh Admin.",
                            "Akses Ditolak",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }

                    InventoryController inventoryController =
                        new InventoryController();

                    QualityControlController qcController =
                        new QualityControlController();

                    ShipmentController shipmentController =
                        new ShipmentController();

                    List<Inventory> daftarInventory =
                        inventoryController.GetReportInventory();

                    List<QualityControl> daftarQc =
                        qcController.GetReportQualityControl();

                    List<Shipment> daftarShipment =
                        shipmentController.GetReportShipment();

                    StringBuilder laporan = new StringBuilder();

                    laporan.AppendLine("LAPORAN GABUNGAN OPERASIONAL COCOALITE");
                    laporan.AppendLine("PT Cacao Prima Nusantara");
                    laporan.AppendLine("Tanggal Cetak: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
                    laporan.AppendLine("====================================================");
                    laporan.AppendLine();

                    laporan.AppendLine("RINGKASAN INVENTORY");
                    laporan.AppendLine("----------------------------------------");
                    laporan.AppendLine("Total Data Inventory : " + daftarInventory.Count);
                    laporan.AppendLine("Total Stok           : " +
                        daftarInventory.Sum(i => i.StockQuantity).ToString("N2") + " kg");
                    laporan.AppendLine();

                    laporan.AppendLine("RINGKASAN QUALITY CONTROL");
                    laporan.AppendLine("----------------------------------------");
                    laporan.AppendLine("Total Data QC : " + daftarQc.Count);
                    laporan.AppendLine("Approved      : " + daftarQc.Count(q => q.QcStatus == "Approved"));
                    laporan.AppendLine("Rejected      : " + daftarQc.Count(q => q.QcStatus == "Rejected"));
                    laporan.AppendLine();

                    laporan.AppendLine("RINGKASAN SHIPMENT");
                    laporan.AppendLine("----------------------------------------");
                    laporan.AppendLine("Total Data Shipment : " + daftarShipment.Count);
                    laporan.AppendLine("Total Berat Kirim   : " +
                        daftarShipment.Sum(s => s.ShipmentWeight).ToString("N2") + " kg");
                    laporan.AppendLine("Pending             : " + daftarShipment.Count(s => s.ShipmentStatus == "Pending"));
                    laporan.AppendLine("Shipped             : " + daftarShipment.Count(s => s.ShipmentStatus == "Shipped"));
                    laporan.AppendLine("Delivered           : " + daftarShipment.Count(s => s.ShipmentStatus == "Delivered"));
                    laporan.AppendLine("Cancelled           : " + daftarShipment.Count(s => s.ShipmentStatus == "Cancelled"));

                    txtReport.Text = laporan.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal membuat laporan: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnDownloadPdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReport.Text))
            {
                MessageBox.Show(
                    "Generate laporan terlebih dahulu sebelum mengunduh PDF.",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
            saveFileDialog.Title = "Simpan Laporan PDF";
            saveFileDialog.FileName =
                "Laporan_CocoaLite_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                ".pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string isiLaporan = txtReport.Text;
                    string jenisLaporan = cbJenisLaporan.Text;

                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4.Landscape());
                            page.Margin(30);

                            page.DefaultTextStyle(textStyle =>
                                textStyle.FontSize(10)
                            );

                            page.Header()
                                .Column(column =>
                                {
                                    column.Item()
                                        .Text("CocoaLite - Sistem Informasi Manajemen Kakao")
                                        .FontSize(16)
                                        .Bold()
                                        .FontColor(Colors.Brown.Darken4);

                                    column.Item()
                                        .Text("PT Cacao Prima Nusantara")
                                        .FontSize(10)
                                        .FontColor(Colors.Grey.Darken2);

                                    column.Item()
                                        .Text("Jenis Laporan: " + jenisLaporan)
                                        .FontSize(10)
                                        .FontColor(Colors.Grey.Darken2);

                                    column.Item()
                                        .Text("Tanggal Cetak: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"))
                                        .FontSize(10)
                                        .FontColor(Colors.Grey.Darken2);
                                });

                            page.Content()
                                .PaddingTop(20)
                                .Border(1)
                                .BorderColor(Colors.Grey.Lighten2)
                                .Padding(15)
                                .Text(isiLaporan)
                                .FontFamily("Consolas")
                                .FontSize(8);

                            page.Footer()
                                .AlignCenter()
                                .Text(text =>
                                {
                                    text.Span("Generated by CocoaLite App - Halaman ");
                                    text.CurrentPageNumber();
                                    text.Span(" / ");
                                    text.TotalPages();
                                });
                        });
                    })
                    .GeneratePdf(saveFileDialog.FileName);

                    MessageBox.Show(
                        "Laporan berhasil disimpan sebagai PDF.",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal menyimpan PDF: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbJenisLaporan.SelectedIndex = -1;
            txtReport.Clear();
        }
    }
}