using Cocoalite.Controllers;
using Cocoalite.Helpers;
using Cocoalite.Models.Entity;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Cocoalite.Views
{
    public partial class ShipmentControl : UserControl
    {
        private int selectedShipmentId = 0;
        private string selectedShipmentStatus = "";

        public ShipmentControl()
        {
            InitializeComponent();
        }

        private void ShipmentControl_Load(object sender, EventArgs e)
        {
            LoadBatch();
            LoadStatus();
            LoadShipment();
            AturDataGridView();
            AturTampilanPanelDanTabel();
        }

        private void LoadBatch()
        {
            try
            {
                ShipmentController controller = new ShipmentController();

                cbBatch.DataSource = controller.GetAllBatch();
                cbBatch.DisplayMember = "batch_code";
                cbBatch.ValueMember = "batch_id";
                cbBatch.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadStatus()
        {
            cbShipmentStatus.Items.Clear();
            cbShipmentStatus.Items.Add("Pending");
            cbShipmentStatus.Items.Add("Shipped");
            cbShipmentStatus.Items.Add("Delivered");
            cbShipmentStatus.Items.Add("Cancelled");
            cbShipmentStatus.SelectedIndex = 0;
        }

        private void LoadShipment()
        {
            try
            {
                ShipmentController controller = new ShipmentController();

                dgvShipment.DataSource = controller.GetAllShipment();

                AturHeaderKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AturDataGridView()
        {
            dgvShipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShipment.MultiSelect = false;
            dgvShipment.ReadOnly = true;
            dgvShipment.AllowUserToAddRows = false;
            dgvShipment.AllowUserToDeleteRows = false;
            dgvShipment.RowHeadersVisible = false;
        }

        private void AturTampilanPanelDanTabel()
        {
            StylePanel(panelForm);
            StylePanel(panelTable);
            StyleDataGridView(dgvShipment);
        }

        private void StylePanel(Panel panel)
        {
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.None;
            panel.Padding = new Padding(20);

            panel.Paint -= Panel_Paint;
            panel.Paint += Panel_Paint;
        }

        private void Panel_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is not Panel panel)
            {
                return;
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                0,
                0,
                panel.Width - 1,
                panel.Height - 1
            );

            using (GraphicsPath path = GetRoundedRectangle(rect, 14))
            using (SolidBrush backgroundBrush = new SolidBrush(Color.White))
            using (Pen borderPen = new Pen(Color.FromArgb(215, 195, 175), 1))
            {
                e.Graphics.FillPath(backgroundBrush, path);
                e.Graphics.DrawPath(borderPen, path);
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            return path;
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(230, 220, 210);

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 42;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(92, 49, 13);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(74, 44, 30);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 129, 74);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 246, 240);

            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 36;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ScrollBars = ScrollBars.Both;
        }
        private void AturHeaderKolom()
        {
            if (dgvShipment.Columns.Contains("shipment_id"))
            {
                dgvShipment.Columns["shipment_id"].HeaderText = "ID";
                dgvShipment.Columns["shipment_id"].Width = 50;
            }

            if (dgvShipment.Columns.Contains("batch_id"))
            {
                dgvShipment.Columns["batch_id"].Visible = false;
            }

            if (dgvShipment.Columns.Contains("created_by"))
            {
                dgvShipment.Columns["created_by"].Visible = false;
            }

            if (dgvShipment.Columns.Contains("batch_code"))
            {
                dgvShipment.Columns["batch_code"].HeaderText = "Batch Code";
            }

            if (dgvShipment.Columns.Contains("full_name"))
            {
                dgvShipment.Columns["full_name"].HeaderText = "Created By";
            }

            if (dgvShipment.Columns.Contains("shipment_code"))
            {
                dgvShipment.Columns["shipment_code"].HeaderText = "Shipment Code";
            }

            if (dgvShipment.Columns.Contains("destination"))
            {
                dgvShipment.Columns["destination"].HeaderText = "Destination";
            }

            if (dgvShipment.Columns.Contains("shipment_date"))
            {
                dgvShipment.Columns["shipment_date"].HeaderText = "Shipment Date";
            }

            if (dgvShipment.Columns.Contains("shipment_weight"))
            {
                dgvShipment.Columns["shipment_weight"].HeaderText = "Shipment Weight";
            }

            if (dgvShipment.Columns.Contains("shipment_status"))
            {
                dgvShipment.Columns["shipment_status"].HeaderText = "Shipment Status";
            }

            if (dgvShipment.Columns.Contains("vehicle_number"))
            {
                dgvShipment.Columns["vehicle_number"].HeaderText = "Vehicle Number";
            }

            if (dgvShipment.Columns.Contains("driver_name"))
            {
                dgvShipment.Columns["driver_name"].HeaderText = "Driver Name";
            }

            if (dgvShipment.Columns.Contains("created_at"))
            {
                dgvShipment.Columns["created_at"].HeaderText = "Created At";
            }
        }

        private void ClearForm()
        {
            selectedShipmentId = 0;
            selectedShipmentStatus = "";

            cbBatch.SelectedIndex = -1;
            txtShipmentCode.Clear();
            txtDestination.Clear();
            dtpShipmentDate.Value = DateTime.Now;
            txtShipmentWeight.Clear();
            cbShipmentStatus.SelectedIndex = 0;
            txtVehicleNumber.Clear();
            txtDriverName.Clear();
            cbBatch.Focus();
        }
        private bool ValidasiInput(bool isUpdate = false)
        {
            if (cbBatch.SelectedIndex == -1 || cbBatch.SelectedValue == null)
            {
                MessageBox.Show("Batch harus dipilih!");
                cbBatch.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Tujuan pengiriman tidak boleh kosong!");
                txtDestination.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtShipmentWeight.Text))
            {
                MessageBox.Show("Berat shipment tidak boleh kosong!");
                txtShipmentWeight.Focus();
                return false;
            }

            if (!decimal.TryParse(txtShipmentWeight.Text, out decimal weight))
            {
                MessageBox.Show("Berat shipment harus berupa angka!");
                txtShipmentWeight.Focus();
                return false;
            }

            if (weight <= 0)
            {
                MessageBox.Show("Berat shipment harus lebih dari 0!");
                txtShipmentWeight.Focus();
                return false;
            }

            if (isUpdate && cbShipmentStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Status shipment harus dipilih!");
                cbShipmentStatus.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtVehicleNumber.Text))
            {
                MessageBox.Show("Nomor kendaraan tidak boleh kosong!");
                txtVehicleNumber.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDriverName.Text))
            {
                MessageBox.Show("Nama driver tidak boleh kosong!");
                txtDriverName.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput(false))
            {
                return;
            }

            try
            {
                if (LoginSession.CurrentUser == null)
                {
                    MessageBox.Show("Session login tidak ditemukan.");
                    return;
                }

                Shipment shipment = new Shipment();

                shipment.BatchId = Convert.ToInt32(cbBatch.SelectedValue);
                shipment.CreatedBy = LoginSession.CurrentUser.UserId;
                shipment.GenerateShipmentCode();
                shipment.Destination = txtDestination.Text.Trim();
                shipment.ShipmentDate = DateOnly.FromDateTime(dtpShipmentDate.Value);
                shipment.ShipmentWeight = decimal.Parse(txtShipmentWeight.Text);
                shipment.VehicleNumber = txtVehicleNumber.Text.Trim();
                shipment.DriverName = txtDriverName.Text.Trim();

                ShipmentController controller = new ShipmentController();
                controller.AddShipment(shipment);

                MessageBox.Show("Data shipment berhasil ditambahkan dengan status Pending.");

                LoadShipment();
                LoadBatch();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedShipmentId == 0)
            {
                MessageBox.Show("Pilih data shipment terlebih dahulu!");
                return;
            }

            if (!ValidasiInput())
            {
                return;
            }

            string statusBaru = cbShipmentStatus.Text.Trim();

            if (selectedShipmentStatus == "Cancelled")
            {
                MessageBox.Show(
                    "Shipment yang sudah Cancelled tidak dapat diubah lagi.",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (selectedShipmentStatus == "Delivered" && statusBaru == "Cancelled")
            {
                MessageBox.Show(
                    "Shipment yang sudah Delivered tidak dapat dibatalkan.",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (statusBaru == "Cancelled")
            {
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin membatalkan shipment ini?\n\nStok akan dikembalikan otomatis ke inventory.",
                    "Konfirmasi Pembatalan Shipment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                ShipmentController controller = new ShipmentController();

                controller.UpdateShipment(
                     selectedShipmentId,
                     txtDestination.Text.Trim(),
                     dtpShipmentDate.Value,
                     selectedShipmentStatus,
                     statusBaru,
                     txtVehicleNumber.Text.Trim(),
                     txtDriverName.Text.Trim()
 );

                MessageBox.Show("Data shipment berhasil diperbarui!");

                LoadShipment();
                LoadBatch();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedShipmentId == 0)
            {
                MessageBox.Show("Pilih data shipment terlebih dahulu!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data shipment ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                ShipmentController controller = new ShipmentController();
                controller.DeleteShipment(selectedShipmentId);

                MessageBox.Show("Data shipment berhasil dihapus!");

                LoadShipment();
                LoadBatch();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvShipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvShipment.Rows[e.RowIndex];

            selectedShipmentId = Convert.ToInt32(row.Cells["shipment_id"].Value);

            if (dgvShipment.Columns.Contains("batch_id"))
            {
                cbBatch.SelectedValue = Convert.ToInt32(row.Cells["batch_id"].Value);
            }

            txtShipmentCode.Text = row.Cells["shipment_code"].Value?.ToString() ?? "";
            txtDestination.Text = row.Cells["destination"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["shipment_date"].Value?.ToString(), out DateTime date))
            {
                dtpShipmentDate.Value = date;
            }

            txtShipmentWeight.Text = row.Cells["shipment_weight"].Value?.ToString() ?? "";

            if (dgvShipment.Columns.Contains("shipment_status"))
            {
                selectedShipmentStatus = row.Cells["shipment_status"].Value?.ToString() ?? "Pending";
                cbShipmentStatus.SelectedItem = selectedShipmentStatus;
            }

            txtVehicleNumber.Text = row.Cells["vehicle_number"].Value?.ToString() ?? "";
            txtDriverName.Text = row.Cells["driver_name"].Value?.ToString() ?? "";
        }
    }
}