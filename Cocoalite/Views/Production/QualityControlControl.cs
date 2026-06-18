using System;
using System.Windows.Forms;
using Cocoalite.Controllers;
using Cocoalite.Helpers;
using Cocoalite.Models.Entity;
using System.Drawing.Drawing2D;

namespace Cocoalite.Views
{
    public partial class QualityControlControl : UserControl
    {
        private int selectedQcId = 0;

        public QualityControlControl()
        {
            InitializeComponent();
        }

        private void QualityControlControl_Load(object sender, EventArgs e)
        {
            LoadReceiving();
            LoadQualityControl();
            LoadStatus();
            AturDataGridView();
            AturTampilanPanelDanTabel();
        }

        private void LoadReceiving(int? currentReceivingId = null)
        {
            try
            {
                QualityControlController controller = new QualityControlController();

                cbReceiving.DataSource = controller.GetAllReceiving(currentReceivingId);
                cbReceiving.DisplayMember = "receiving_display";
                cbReceiving.ValueMember = "receiving_id";
                cbReceiving.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadStatus()
        {
            cbQcStatus.Items.Clear();
            cbQcStatus.Items.Add("Approved");
            cbQcStatus.Items.Add("Rejected");
            cbQcStatus.SelectedIndex = -1;
        }

        private void LoadQualityControl()
        {
            try
            {
                QualityControlController controller = new QualityControlController();
                dgvQualityControl.DataSource = controller.GetAllQualityControl();

                AturHeaderKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AturDataGridView()
        {
            dgvQualityControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQualityControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQualityControl.MultiSelect = false;
            dgvQualityControl.ReadOnly = true;
            dgvQualityControl.AllowUserToAddRows = false;
            dgvQualityControl.AllowUserToDeleteRows = false;
            dgvQualityControl.RowHeadersVisible = false;
        }

        private void AturTampilanPanelDanTabel()
        {
            StylePanel(panelForm);
            StylePanel(panelTable);
            StyleDataGridView(dgvQualityControl);
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

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }
        private void AturHeaderKolom()
        {
            if (dgvQualityControl.Columns.Contains("qc_id"))
            {
                dgvQualityControl.Columns["qc_id"].HeaderText = "ID";
                dgvQualityControl.Columns["qc_id"].Width = 50;
            }

            if (dgvQualityControl.Columns.Contains("receiving_id"))
            {
                dgvQualityControl.Columns["receiving_id"].Visible = false;
            }

            if (dgvQualityControl.Columns.Contains("receiving_code"))
            {
                dgvQualityControl.Columns["receiving_code"].HeaderText = "Receiving Code";
            }

            if (dgvQualityControl.Columns.Contains("inspected_by"))
            {
                dgvQualityControl.Columns["inspected_by"].Visible = false;
            }

            if (dgvQualityControl.Columns.Contains("full_name"))
            {
                dgvQualityControl.Columns["full_name"].HeaderText = "Inspected By";
            }

            if (dgvQualityControl.Columns.Contains("moisture_level"))
            {
                dgvQualityControl.Columns["moisture_level"].HeaderText = "Moisture";
            }

            if (dgvQualityControl.Columns.Contains("fermentation_level"))
            {
                dgvQualityControl.Columns["fermentation_level"].HeaderText = "Fermentation";
            }

            if (dgvQualityControl.Columns.Contains("defect_level"))
            {
                dgvQualityControl.Columns["defect_level"].HeaderText = "Defect";
            }

            if (dgvQualityControl.Columns.Contains("bean_size"))
            {
                dgvQualityControl.Columns["bean_size"].HeaderText = "Bean Size";
            }

            if (dgvQualityControl.Columns.Contains("grade"))
            {
                dgvQualityControl.Columns["grade"].HeaderText = "Grade";
            }

            if (dgvQualityControl.Columns.Contains("qc_status"))
            {
                dgvQualityControl.Columns["qc_status"].HeaderText = "QC Status";
            }

            if (dgvQualityControl.Columns.Contains("inspection_notes"))
            {
                dgvQualityControl.Columns["inspection_notes"].HeaderText = "Notes";
            }

            if (dgvQualityControl.Columns.Contains("inspection_date"))
            {
                dgvQualityControl.Columns["inspection_date"].HeaderText = "Inspection Date";
            }

            if (dgvQualityControl.Columns.Contains("created_at"))
            {
                dgvQualityControl.Columns["created_at"].HeaderText = "Created At";
            }
        }

        private void ClearForm()
        {
            selectedQcId = 0;
            cbReceiving.SelectedIndex = -1;
            txtMoisture.Clear();
            txtFermentation.Clear();
            txtDefect.Clear();
            cbBeanSize.SelectedIndex = -1;
            txtGrade.Clear();
            cbQcStatus.SelectedIndex = -1;
            txtNotes.Clear();
            dtpInspectionDate.Value = DateTime.Now;
            cbReceiving.Focus();
        }

        private bool ValidasiInput()
        {
            // ================================================================
            // ValidasiInput hanya memeriksa hal-hal yang bersifat FORMAT UI:
            // apakah field dipilih/diisi dan apakah teks bisa diparse sebagai
            // angka. Validasi business rule (range 0–100, whitelist grade, dsb.)
            // sepenuhnya diserahkan kepada setter di QualityParameter dan
            // QualityControl — bukan di sini.
            // ================================================================

            if (cbReceiving.SelectedIndex == -1 || cbReceiving.SelectedValue == null)
            {
                MessageBox.Show("Receiving harus dipilih!");
                cbReceiving.Focus();
                return false;
            }

            if (!decimal.TryParse(txtMoisture.Text, out _))
            {
                MessageBox.Show("Moisture harus berupa angka!");
                txtMoisture.Focus();
                return false;
            }

            if (!decimal.TryParse(txtFermentation.Text, out _))
            {
                MessageBox.Show("Fermentation harus berupa angka!");
                txtFermentation.Focus();
                return false;
            }

            if (!decimal.TryParse(txtDefect.Text, out _))
            {
                MessageBox.Show("Defect harus berupa angka!");
                txtDefect.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbBeanSize.Text))
            {
                MessageBox.Show("Bean size tidak boleh kosong!");
                cbBeanSize.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("Grade belum ditentukan. Klik tombol Determine Grade terlebih dahulu!");
                return false;
            }

            if (cbQcStatus.SelectedIndex == -1)
            {
                MessageBox.Show("QC status harus dipilih!");
                cbQcStatus.Focus();
                return false;
            }

            return true;
        }

        private void btnDetermineGrade_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtMoisture.Text, out decimal moisture))
                {
                    MessageBox.Show("Moisture harus berupa angka!");
                    txtMoisture.Focus();
                    return;
                }

                if (!decimal.TryParse(txtFermentation.Text, out decimal fermentation))
                {
                    MessageBox.Show("Fermentation harus berupa angka!");
                    txtFermentation.Focus();
                    return;
                }

                if (!decimal.TryParse(txtDefect.Text, out decimal defect))
                {
                    MessageBox.Show("Defect harus berupa angka!");
                    txtDefect.Focus();
                    return;
                }

                QualityControlController controller = new QualityControlController();

                // Validasi range 0–100 dilempar oleh setter QualityParameter
                // di dalam DetermineGrade(). Exception ditangkap di bawah.
                string grade = controller.DetermineGrade(moisture, fermentation, defect);

                txtGrade.Text = grade;
                cbQcStatus.SelectedItem = (grade == "Reject") ? "Rejected" : "Approved";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;

            try
            {
                if (LoginSession.CurrentUser == null)
                {
                    MessageBox.Show("Session login tidak ditemukan. Silakan login ulang.");
                    return;
                }

                QualityControlController controller = new QualityControlController();

                QualityControl qc = new QualityControl();

                qc.ReceivingId = Convert.ToInt32(cbReceiving.SelectedValue);
                qc.InspectedBy = LoginSession.CurrentUser.UserId;

                // Setter QualityParameter melempar ArgumentException jika
                // nilai di luar range 0–100 — ditangkap oleh catch di bawah.
                qc.IsiParameter(
                    decimal.Parse(txtMoisture.Text),
                    decimal.Parse(txtFermentation.Text),
                    decimal.Parse(txtDefect.Text),
                    cbBeanSize.Text.Trim()
                );

                qc.TerapkanHasilPemeriksaan(txtGrade.Text.Trim());
                qc.InspectionNotes = txtNotes.Text.Trim();
                qc.InspectionDate = dtpInspectionDate.Value;

                controller.AddQualityControl(qc);

                MessageBox.Show("Data quality control berhasil ditambahkan!");

                LoadQualityControl();
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
            if (selectedQcId == 0)
            {
                MessageBox.Show("Pilih data quality control terlebih dahulu!");
                return;
            }

            if (!ValidasiInput())
                return;

            try
            {
                QualityControlController controller = new QualityControlController();

                QualityControl qc = new QualityControl();

                qc.QcId = selectedQcId;
                qc.ReceivingId = Convert.ToInt32(cbReceiving.SelectedValue);

                qc.IsiParameter(
                    decimal.Parse(txtMoisture.Text),
                    decimal.Parse(txtFermentation.Text),
                    decimal.Parse(txtDefect.Text),
                    cbBeanSize.Text.Trim()
                );

                qc.TerapkanHasilPemeriksaan(txtGrade.Text.Trim());
                qc.InspectionNotes = txtNotes.Text.Trim();
                qc.InspectionDate = dtpInspectionDate.Value;

                controller.UpdateQualityControl(qc);

                MessageBox.Show("Data quality control berhasil diperbarui!");

                LoadQualityControl();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedQcId == 0)
            {
                MessageBox.Show("Pilih data quality control terlebih dahulu!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data quality control ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            try
            {
                QualityControlController controller = new QualityControlController();
                controller.DeleteQualityControl(selectedQcId);

                MessageBox.Show("Data quality control berhasil dihapus!");

                LoadQualityControl();
                LoadReceiving();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Data quality control tidak dapat dihapus jika sudah digunakan pada batch.\n\nDetail: " + ex.Message
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvQualityControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvQualityControl.Rows[e.RowIndex];

            selectedQcId = Convert.ToInt32(row.Cells["qc_id"].Value);

            if (dgvQualityControl.Columns.Contains("receiving_id"))
                cbReceiving.SelectedValue = Convert.ToInt32(row.Cells["receiving_id"].Value);

            txtMoisture.Text = row.Cells["moisture_level"].Value?.ToString() ?? "";
            txtFermentation.Text = row.Cells["fermentation_level"].Value?.ToString() ?? "";
            txtDefect.Text = row.Cells["defect_level"].Value?.ToString() ?? "";
            cbBeanSize.Text = row.Cells["bean_size"].Value?.ToString() ?? "";
            txtGrade.Text = row.Cells["grade"].Value?.ToString() ?? "";

            if (dgvQualityControl.Columns.Contains("qc_status"))
                cbQcStatus.SelectedItem = row.Cells["qc_status"].Value?.ToString() ?? "";

            txtNotes.Text = row.Cells["inspection_notes"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["inspection_date"].Value?.ToString(), out DateTime date))
                dtpInspectionDate.Value = date;
        }
    }
}