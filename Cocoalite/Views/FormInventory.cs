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

                cbInventoryStatus.Items.Clear();
                cbInventoryStatus.Items.Add("Available");
                cbInventoryStatus.Items.Add("Low Stock");
                cbInventoryStatus.Items.Add("Empty");

                if (cbInventoryStatus.Items.Count > 0)
                {
                    cbInventoryStatus.SelectedIndex = 0;
                }

                LoadInventory();

                dgvInventory.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvInventory.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

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

            txtStockIn.Clear();
            txtStockOut.Clear();
            txtCurrentStock.Clear();

            if (cbInventoryStatus.Items.Count > 0)
            {
                cbInventoryStatus.SelectedIndex = 0;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbBatch.SelectedValue == null ||
                txtStockIn.Text == "" ||
                txtStockOut.Text == "" ||
                txtCurrentStock.Text == "" ||
                cbInventoryStatus.Text == "")
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            try
            {
                InventoryController controller = new InventoryController();

                int batchId = Convert.ToInt32(cbBatch.SelectedValue);
                decimal stockIn = Convert.ToDecimal(txtStockIn.Text);
                decimal stockOut = Convert.ToDecimal(txtStockOut.Text);
                decimal currentStock = Convert.ToDecimal(txtCurrentStock.Text);
                string inventoryStatus = cbInventoryStatus.Text;

                controller.AddInventory(
                    batchId,
                    stockIn,
                    stockOut,
                    currentStock,
                    inventoryStatus
                );

                MessageBox.Show("Data inventory berhasil disimpan!");

                LoadInventory();
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

                txtStockIn.Text =
                    row.Cells["stock_in"].Value?.ToString() ?? "";

                txtStockOut.Text =
                    row.Cells["stock_out"].Value?.ToString() ?? "";

                txtCurrentStock.Text =
                    row.Cells["current_stock"].Value?.ToString() ?? "";

                cbInventoryStatus.Text =
                    row.Cells["inventory_status"].Value?.ToString() ?? "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedInventoryId == 0)
            {
                MessageBox.Show("Pilih data inventory dulu!");
                return;
            }

            if (cbBatch.SelectedValue == null ||
                txtStockIn.Text == "" ||
                txtStockOut.Text == "" ||
                txtCurrentStock.Text == "" ||
                cbInventoryStatus.Text == "")
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            try
            {
                InventoryController controller = new InventoryController();

                int batchId = Convert.ToInt32(cbBatch.SelectedValue);
                decimal stockIn = Convert.ToDecimal(txtStockIn.Text);
                decimal stockOut = Convert.ToDecimal(txtStockOut.Text);
                decimal currentStock = Convert.ToDecimal(txtCurrentStock.Text);
                string inventoryStatus = cbInventoryStatus.Text;

                controller.UpdateInventory(
                    selectedInventoryId,
                    batchId,
                    stockIn,
                    stockOut,
                    currentStock,
                    inventoryStatus
                );

                MessageBox.Show("Data inventory berhasil diupdate!");

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
