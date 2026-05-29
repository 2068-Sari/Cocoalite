using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Cocoalite.Controllers;

namespace Cocoalite.Views
{
    public partial class FormInventory : Form
    {
        private int selectedInventoryId = 0;

        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            try
            {
                InventoryController controller = new InventoryController();

                cbBatch.DataSource = controller.GetAllBatch();
                cbBatch.DisplayMember = "batch_code";
                cbBatch.ValueMember = "batch_id";

                dgvInventory.DataSource = controller.GetAllInventory();
                dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvInventory.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadInventory()
        {
            InventoryController controller = new InventoryController();
            dgvInventory.DataSource = controller.GetAllInventory();
        }

        private void ClearForm()
        {
            selectedInventoryId = 0;

            if (cbBatch.Items.Count > 0)
            {
                cbBatch.SelectedIndex = 0;
            }

            txtStockQuantity.Clear();
            txtWarehouseLocation.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                InventoryController controller = new InventoryController();

                int batchId = Convert.ToInt32(cbBatch.SelectedValue);
                decimal stockQuantity = Convert.ToDecimal(txtStockQuantity.Text);
                string warehouseLocation = txtWarehouseLocation.Text;

                controller.AddInventory(batchId, stockQuantity, warehouseLocation);

                MessageBox.Show("Data inventory berhasil ditambahkan");

                dgvInventory.DataSource = controller.GetAllInventory();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];

                selectedInventoryId =
                    Convert.ToInt32(row.Cells["inventory_id"].Value);

                cbBatch.SelectedValue =
                    Convert.ToInt32(row.Cells["batch_id"].Value);

                txtStockQuantity.Text =
                    row.Cells["stock_quantity"].Value?.ToString() ?? "";

                txtWarehouseLocation.Text =
                    row.Cells["warehouse_location"].Value?.ToString() ?? "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                InventoryController controller = new InventoryController();

                int inventoryId = selectedInventoryId;
                int batchId = Convert.ToInt32(cbBatch.SelectedValue);
                decimal stockQuantity = Convert.ToDecimal(txtStockQuantity.Text);
                string warehouseLocation = txtWarehouseLocation.Text;

                controller.UpdateInventory(
                    inventoryId,
                    batchId,
                    stockQuantity,
                    warehouseLocation
                );

                MessageBox.Show("Data inventory berhasil diupdate");

                dgvInventory.DataSource = controller.GetAllInventory();
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
                MessageBox.Show("Pilih data inventory dulu!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data inventory ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
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
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
