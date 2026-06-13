using Cocoalite.Controllers;
using Cocoalite.Models.Entity;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Cocoalite.Views
{
    public partial class InventoryControl : UserControl
    {
        private int selectedInventoryId = 0;

        public InventoryControl()
        {
            InitializeComponent();
        }

        private void InventoryControl_Load(object sender, EventArgs e)
        {
            LoadBatch();
            LoadInventory();
            AturDataGridView();
            AturTampilanPanelDanTabel();
        }

        private void LoadBatch()
        {
            try
            {
                InventoryController controller = new InventoryController();

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

        private void LoadInventory()
        {
            try
            {
                InventoryController controller = new InventoryController();

                dgvInventory.DataSource = controller.GetAllInventory();

                AturHeaderKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AturDataGridView()
        {
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;
            dgvInventory.ReadOnly = true;
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.RowHeadersVisible = false;
        }
        private void AturTampilanPanelDanTabel()
        {
            StylePanel(panelForm);
            StylePanel(panelTable);
            StyleDataGridView(dgvInventory);
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
            if (dgvInventory.Columns.Contains("inventory_id"))
            {
                dgvInventory.Columns["inventory_id"].HeaderText = "ID";
                dgvInventory.Columns["inventory_id"].Width = 50;
            }

            if (dgvInventory.Columns.Contains("batch_id"))
            {
                dgvInventory.Columns["batch_id"].Visible = false;
            }

            if (dgvInventory.Columns.Contains("batch_code"))
            {
                dgvInventory.Columns["batch_code"].HeaderText = "Batch Code";
            }

            if (dgvInventory.Columns.Contains("stock_quantity"))
            {
                dgvInventory.Columns["stock_quantity"].HeaderText = "Stock Quantity";
            }

            if (dgvInventory.Columns.Contains("warehouse_location"))
            {
                dgvInventory.Columns["warehouse_location"].HeaderText = "Warehouse Location";
            }

            if (dgvInventory.Columns.Contains("inventory_status"))
            {
                dgvInventory.Columns["inventory_status"].HeaderText = "Inventory Status";
            }

            if (dgvInventory.Columns.Contains("updated_at"))
            {
                dgvInventory.Columns["updated_at"].HeaderText = "Updated At";
            }
        }

        private void ClearForm()
        {
            selectedInventoryId = 0;
            cbBatch.SelectedIndex = -1;
            txtStockQuantity.Clear();
            txtWarehouseLocation.Clear();
            txtInventoryStatus.Clear();
            cbBatch.Focus();
        }

        private bool ValidasiInput()
        {
            if (cbBatch.SelectedIndex == -1 || cbBatch.SelectedValue == null)
            {
                MessageBox.Show("Batch harus dipilih!");
                cbBatch.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStockQuantity.Text))
            {
                MessageBox.Show("Stock quantity tidak boleh kosong!");
                txtStockQuantity.Focus();
                return false;
            }

            if (!decimal.TryParse(txtStockQuantity.Text, out decimal stock))
            {
                MessageBox.Show("Stock quantity harus berupa angka!");
                txtStockQuantity.Focus();
                return false;
            }

            if (stock < 0)
            {
                MessageBox.Show("Stock quantity tidak boleh negatif!");
                txtStockQuantity.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtWarehouseLocation.Text))
            {
                MessageBox.Show("Warehouse location tidak boleh kosong!");
                txtWarehouseLocation.Focus();
                return false;
            }

            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            try
            {
                decimal stock = decimal.Parse(txtStockQuantity.Text);

                // PERBAIKAN: Domain model yang menentukan status, bukan View.
                Inventory preview = new Inventory();
                preview.StockQuantity = stock;
                txtInventoryStatus.Text = preview.InventoryStatus;

                InventoryController controller = new InventoryController();
                controller.AddInventory(
                    Convert.ToInt32(cbBatch.SelectedValue),
                    stock,
                    txtWarehouseLocation.Text.Trim()
                );

                MessageBox.Show("Data inventory berhasil ditambahkan!");
                LoadInventory();
                ClearForm();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedInventoryId == 0)
            {
                MessageBox.Show("Pilih data inventory terlebih dahulu!");
                return;
            }

            if (!ValidasiInput()) return;

            try
            {
                decimal stock = decimal.Parse(txtStockQuantity.Text);

                // PERBAIKAN: Domain model yang menentukan status, bukan View.
                Inventory preview = new Inventory();
                preview.StockQuantity = stock;
                txtInventoryStatus.Text = preview.InventoryStatus;

                InventoryController controller = new InventoryController();
                controller.UpdateInventory(
                    selectedInventoryId,
                    Convert.ToInt32(cbBatch.SelectedValue),
                    stock,
                    txtWarehouseLocation.Text.Trim()
                );

                MessageBox.Show("Data inventory berhasil diperbarui!");
                LoadInventory();
                ClearForm();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedInventoryId == 0)
            {
                MessageBox.Show("Pilih data inventory terlebih dahulu!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data inventory ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No) return;

            try
            {
                InventoryController controller = new InventoryController();
                controller.DeleteInventory(selectedInventoryId);

                MessageBox.Show("Data inventory berhasil dihapus!");
                LoadInventory();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Data inventory tidak dapat dihapus jika sudah digunakan pada proses shipment.\n\nDetail: " + ex.Message
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearForm(); }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvInventory.Rows[e.RowIndex];

            selectedInventoryId = Convert.ToInt32(row.Cells["inventory_id"].Value);

            if (dgvInventory.Columns.Contains("batch_id"))
                cbBatch.SelectedValue = Convert.ToInt32(row.Cells["batch_id"].Value);

            txtStockQuantity.Text = row.Cells["stock_quantity"].Value?.ToString() ?? "";
            txtWarehouseLocation.Text = row.Cells["warehouse_location"].Value?.ToString() ?? "";

            if (dgvInventory.Columns.Contains("inventory_status"))
                txtInventoryStatus.Text = row.Cells["inventory_status"].Value?.ToString() ?? "";
        }
    }
}