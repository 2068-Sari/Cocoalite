using System;
using System.Windows.Forms;
using Cocoalite.Controllers;
using System.Drawing.Drawing2D;

namespace Cocoalite.Views
{
    public partial class SupplierControl : UserControl
    {
        private int selectedSupplierId = 0;

        public SupplierControl()
        {
            InitializeComponent();
        }

        private void SupplierControl_Load(object sender, EventArgs e)
        {
            txtSupplierName.MaxLength = 100;
            txtPhone.MaxLength = 15;
            txtEmail.MaxLength = 100;

            AturTampilanButton();
            AturTampilanTable();
            LoadSuppliers();
            AturDataGridView();
        }

        private void AturTampilanButton()
        {
            StyleFilledButton(btnSave,
                Color.FromArgb(92, 49, 13),
                Color.White);

            StyleFilledButton(btnUpdate,
                Color.FromArgb(180, 95, 40),
                Color.White);

            StyleFilledButton(btnDelete,
                Color.FromArgb(140, 40, 30),
                Color.White);

            StyleOutlineButton(btnClear,
                Color.FromArgb(92, 49, 13),
                Color.FromArgb(255, 248, 240),
                Color.FromArgb(74, 44, 30));

            SetRoundedButton(btnSave, 10);
            SetRoundedButton(btnUpdate, 10);
            SetRoundedButton(btnDelete, 10);
            SetRoundedButton(btnClear, 10);
        }

        private void StyleFilledButton(Button btn, Color backColor, Color foreColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = foreColor;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            Color originalColor = backColor;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = ControlPaint.Light(originalColor, 0.1f);
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = originalColor;
            };
        }

        private void StyleOutlineButton(Button btn, Color borderColor, Color backColor, Color foreColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = foreColor;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = borderColor;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            Color originalBack = backColor;
            Color originalFore = foreColor;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = borderColor;
                btn.ForeColor = Color.White;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = originalBack;
                btn.ForeColor = originalFore;
            };
        }

        private void SetRoundedButton(Button btn, int radius)
        {
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            GraphicsPath path = GetRoundedPath(rect, radius);
            btn.Region = new Region(path);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void AturTampilanTable()
        {
            dgv1.BackgroundColor = Color.White;
            dgv1.BorderStyle = BorderStyle.None;
            dgv1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv1.GridColor = Color.FromArgb(230, 220, 210);

            dgv1.EnableHeadersVisualStyles = false;
            dgv1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(92, 49, 13);
            dgv1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv1.ColumnHeadersHeight = 42;

            dgv1.DefaultCellStyle.BackColor = Color.White;
            dgv1.DefaultCellStyle.ForeColor = Color.FromArgb(74, 44, 30);
            dgv1.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dgv1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 129, 74);
            dgv1.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv1.DefaultCellStyle.Padding = new Padding(4, 3, 4, 3);

            dgv1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 246, 240);

            dgv1.RowHeadersVisible = false;
            dgv1.RowTemplate.Height = 34;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.MultiSelect = false;

            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AllowUserToResizeRows = false;
            dgv1.ReadOnly = true;

            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void LoadSuppliers()
        {
            try
            {
                SupplierController controller = new SupplierController();
                dgv1.DataSource = controller.GetAllSuppliers();

                AturHeaderKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AturDataGridView()
        {
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.MultiSelect = false;
            dgv1.ReadOnly = true;
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.RowHeadersVisible = false;
        }

        private void AturHeaderKolom()
        {
            if (dgv1.Columns.Contains("supplier_id"))
            {
                dgv1.Columns["supplier_id"].HeaderText = "ID";
                dgv1.Columns["supplier_id"].Width = 50;
            }

            if (dgv1.Columns.Contains("supplier_name"))
            {
                dgv1.Columns["supplier_name"].HeaderText = "Supplier Name";
            }

            if (dgv1.Columns.Contains("address"))
            {
                dgv1.Columns["address"].HeaderText = "Address";
            }

            if (dgv1.Columns.Contains("phone_number"))
            {
                dgv1.Columns["phone_number"].HeaderText = "Phone";
            }

            if (dgv1.Columns.Contains("email"))
            {
                dgv1.Columns["email"].HeaderText = "Email";
            }

            if (dgv1.Columns.Contains("created_at"))
            {
                dgv1.Columns["created_at"].HeaderText = "Created At";
            }
        }

        private void ClearForm()
        {
            selectedSupplierId = 0;
            txtSupplierName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtSupplierName.Focus();
        }

        /// <summary>
        /// PERBAIKAN: Hanya cek kelengkapan field (UX). Validasi format telepon,
        /// email, panjang nama diserahkan ke setter domain model Supplier.
        /// </summary>
        private bool ValidasiInputLengkap()
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            { MessageBox.Show("Nama supplier tidak boleh kosong!"); txtSupplierName.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            { MessageBox.Show("Alamat supplier tidak boleh kosong!"); txtAddress.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            { MessageBox.Show("Nomor telepon supplier tidak boleh kosong!"); txtPhone.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            { MessageBox.Show("Email supplier tidak boleh kosong!"); txtEmail.Focus(); return false; }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidasiInputLengkap()) return;

            try
            {
                SupplierController controller = new SupplierController();
                controller.AddSupplier(
                    txtSupplierName.Text.Trim(),
                    txtAddress.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim()
                );
                MessageBox.Show("Supplier berhasil ditambahkan!");
                LoadSuppliers(); ClearForm();
            }
            catch (ArgumentException ex)
            {
                // Validasi format dari setter Supplier (telepon, email, dsb.)
                MessageBox.Show(ex.Message, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == 0)
            { MessageBox.Show("Pilih data supplier terlebih dahulu!"); return; }

            if (!ValidasiInputLengkap()) return;

            try
            {
                SupplierController controller = new SupplierController();
                controller.UpdateSupplier(
                    selectedSupplierId,
                    txtSupplierName.Text.Trim(),
                    txtAddress.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim()
                );
                MessageBox.Show("Supplier berhasil diperbarui!");
                LoadSuppliers(); ClearForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == 0)
            { MessageBox.Show("Pilih data supplier terlebih dahulu!"); return; }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus supplier ini?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                SupplierController controller = new SupplierController();
                controller.DeleteSupplier(selectedSupplierId);
                MessageBox.Show("Supplier berhasil dihapus!");
                LoadSuppliers(); ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Data supplier tidak dapat dihapus jika sudah digunakan pada data receiving.\n\nDetail: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearForm(); }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgv1.Rows[e.RowIndex];
            selectedSupplierId = Convert.ToInt32(row.Cells["supplier_id"].Value);
            txtSupplierName.Text = row.Cells["supplier_name"].Value?.ToString() ?? "";
            txtAddress.Text = row.Cells["address"].Value?.ToString() ?? "";
            txtPhone.Text = row.Cells["phone_number"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["email"].Value?.ToString() ?? "";
        }
    }
}