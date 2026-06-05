using System;
using System.Windows.Forms;
using Cocoalite.Controllers;

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

        private string TentukanStatusInventory(decimal stock)
        {
            if (stock == 0)
            {
                return "Empty";
            }

            if (stock < 300)
            {
                return "Low Stock";
            }

            return "Available";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
            {
                return;
            }

            try
            {
                decimal stock = decimal.Parse(txtStockQuantity.Text);
                txtInventoryStatus.Text = TentukanStatusInventory(stock);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedInventoryId == 0)
            {
                MessageBox.Show("Pilih data inventory terlebih dahulu!");
                return;
            }

            if (!ValidasiInput())
            {
                return;
            }

            try
            {
                decimal stock = decimal.Parse(txtStockQuantity.Text);
                txtInventoryStatus.Text = TentukanStatusInventory(stock);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            if (result == DialogResult.No)
            {
                return;
            }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvInventory.Rows[e.RowIndex];

            selectedInventoryId = Convert.ToInt32(row.Cells["inventory_id"].Value);

            if (dgvInventory.Columns.Contains("batch_id"))
            {
                cbBatch.SelectedValue = Convert.ToInt32(row.Cells["batch_id"].Value);
            }

            txtStockQuantity.Text = row.Cells["stock_quantity"].Value?.ToString() ?? "";
            txtWarehouseLocation.Text = row.Cells["warehouse_location"].Value?.ToString() ?? "";

            if (dgvInventory.Columns.Contains("inventory_status"))
            {
                txtInventoryStatus.Text = row.Cells["inventory_status"].Value?.ToString() ?? "";
            }
        }
    }
}