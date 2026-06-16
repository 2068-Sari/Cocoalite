using Cocoalite.Controllers;
using Cocoalite.Helpers;
using Cocoalite.Models.Entity;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Cocoalite.Views
{
    public partial class ReceivingControl : UserControl
    {
        private int selectedReceivingId = 0;

        public ReceivingControl()
        {
            InitializeComponent();
        }

        private void ReceivingControl_Load(object sender, EventArgs e)
        {
            LoadSupplier();
            LoadReceiving();
            AturDataGridView();
            AturTampilanPanelDanTabel();
        }

        private void LoadSupplier()
        {
            try
            {
                ReceivingController controller = new ReceivingController();

                cbSupplier.DataSource = controller.GetSuppliers();
                cbSupplier.DisplayMember = "supplier_name";
                cbSupplier.ValueMember = "supplier_id";
                cbSupplier.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadReceiving()
        {
            try
            {
                ReceivingController controller = new ReceivingController();
                dgvReceiving.DataSource = controller.GetAllReceiving();

                AturHeaderKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AturDataGridView()
        {
            dgvReceiving.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReceiving.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceiving.MultiSelect = false;
            dgvReceiving.ReadOnly = true;
            dgvReceiving.AllowUserToAddRows = false;
            dgvReceiving.AllowUserToDeleteRows = false;
            dgvReceiving.RowHeadersVisible = false;
        }
        private void AturTampilanPanelDanTabel()
        {
            StylePanel(panelForm);
            StylePanel(panelTable);
            StyleDataGridView(dgvReceiving);
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

            using (GraphicsPath path = GetRoundedRectangle(rect, 12))
            using (Pen borderPen = new Pen(Color.FromArgb(215, 195, 175), 1))
            using (SolidBrush backgroundBrush = new SolidBrush(Color.White))
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
        //dgv
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
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 6, 0);

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(74, 44, 30);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 129, 74);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Padding = new Padding(6, 4, 6, 4);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 246, 240);

            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 36;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void AturHeaderKolom()
        {
            if (dgvReceiving.Columns.Contains("receiving_id"))
            {
                dgvReceiving.Columns["receiving_id"].HeaderText = "ID";
                dgvReceiving.Columns["receiving_id"].Width = 50;
            }

            if (dgvReceiving.Columns.Contains("supplier_id"))
            {
                dgvReceiving.Columns["supplier_id"].Visible = false;
            }

            if (dgvReceiving.Columns.Contains("supplier_name"))
            {
                dgvReceiving.Columns["supplier_name"].HeaderText = "Supplier";
            }

            if (dgvReceiving.Columns.Contains("received_by"))
            {
                dgvReceiving.Columns["received_by"].Visible = false;
            }

            if (dgvReceiving.Columns.Contains("full_name"))
            {
                dgvReceiving.Columns["full_name"].HeaderText = "Received By";
            }

            if (dgvReceiving.Columns.Contains("receiving_code"))
            {
                dgvReceiving.Columns["receiving_code"].HeaderText = "Receiving Code";
            }

            if (dgvReceiving.Columns.Contains("receiving_date"))
            {
                dgvReceiving.Columns["receiving_date"].HeaderText = "Receiving Date";
            }

            if (dgvReceiving.Columns.Contains("cocoa_weight"))
            {
                dgvReceiving.Columns["cocoa_weight"].HeaderText = "Cocoa Weight";
            }

            if (dgvReceiving.Columns.Contains("vehicle_number"))
            {
                dgvReceiving.Columns["vehicle_number"].HeaderText = "Vehicle Number";
            }

            if (dgvReceiving.Columns.Contains("created_at"))
            {
                dgvReceiving.Columns["created_at"].HeaderText = "Created At";
            }
        }

        private void ClearForm()
        {
            selectedReceivingId = 0;
            cbSupplier.SelectedIndex = -1;
            txtReceivingCode.Clear();
            dtpReceivingDate.Value = DateTime.Now;
            txtCocoaWeight.Clear();
            txtVehicleNumber.Clear();
            cbSupplier.Focus();
        }

        private bool ValidasiInput()
        {
            if (cbSupplier.SelectedIndex == -1 || cbSupplier.SelectedValue == null)
            {
                MessageBox.Show("Supplier harus dipilih!");
                cbSupplier.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCocoaWeight.Text))
            {
                MessageBox.Show("Berat kakao tidak boleh kosong!");
                txtCocoaWeight.Focus();
                return false;
            }

            if (!decimal.TryParse(txtCocoaWeight.Text, out decimal weight))
            {
                MessageBox.Show("Berat kakao harus berupa angka!");
                txtCocoaWeight.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
            {
                return;
            }

            try
            {
                if (LoginSession.CurrentUser == null)
                {
                    MessageBox.Show("Session login tidak ditemukan. Silakan login ulang.");
                    return;
                }

                Receiving receiving = new Receiving();

                receiving.GenerateReceivingCode();

                txtReceivingCode.Text = receiving.ReceivingCode;

                ReceivingController controller = new ReceivingController();

                controller.AddReceiving(
                    Convert.ToInt32(cbSupplier.SelectedValue),
                    LoginSession.CurrentUser.UserId,
                    receiving.ReceivingCode,
                    dtpReceivingDate.Value,
                    decimal.Parse(txtCocoaWeight.Text),
                    txtVehicleNumber.Text.Trim()
                );

                MessageBox.Show("Data receiving berhasil ditambahkan!");

                LoadReceiving();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedReceivingId == 0)
            {
                MessageBox.Show("Pilih data receiving terlebih dahulu!");
                return;
            }

            if (!ValidasiInput())
            {
                return;
            }

            try
            {
                ReceivingController controller = new ReceivingController();

                controller.UpdateReceiving(
                    selectedReceivingId,
                    Convert.ToInt32(cbSupplier.SelectedValue),
                    txtReceivingCode.Text.Trim(),
                    dtpReceivingDate.Value,
                    decimal.Parse(txtCocoaWeight.Text),
                    txtVehicleNumber.Text.Trim()
                );

                MessageBox.Show("Data receiving berhasil diperbarui!");

                LoadReceiving();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedReceivingId == 0)
            {
                MessageBox.Show("Pilih data receiving terlebih dahulu!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data receiving ini?",
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
                ReceivingController controller = new ReceivingController();
                controller.DeleteReceiving(selectedReceivingId);

                MessageBox.Show("Data receiving berhasil dihapus!");

                LoadReceiving();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Data receiving tidak dapat dihapus jika sudah digunakan pada Quality Control.\n\nDetail: " + ex.Message
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvReceiving_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvReceiving.Rows[e.RowIndex];

            selectedReceivingId = Convert.ToInt32(row.Cells["receiving_id"].Value);

            if (dgvReceiving.Columns.Contains("supplier_id"))
            {
                cbSupplier.SelectedValue = Convert.ToInt32(row.Cells["supplier_id"].Value);
            }

            txtReceivingCode.Text = row.Cells["receiving_code"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["receiving_date"].Value?.ToString(), out DateTime date))
            {
                dtpReceivingDate.Value = date;
            }

            txtCocoaWeight.Text = row.Cells["cocoa_weight"].Value?.ToString() ?? "";
            txtVehicleNumber.Text = row.Cells["vehicle_number"].Value?.ToString() ?? "";
        }
    }
}