using Cocoalite.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cocoalite.Views
{
    public partial class FormBatch : Form
    {
        private int selectedBatchId = 0;
        public FormBatch()
        {
            InitializeComponent();
        }

        private void FormBatch_Load(object sender, EventArgs e)
        {
            try
            {
                BatchController controller =
                    new BatchController();

                cbQc.DataSource =
                    controller.GetApprovedQc();

                cbQc.DisplayMember = "qc_display";

                cbQc.ValueMember =
                    "qc_id";

                dgvBatch.DataSource =
                    controller.GetAllBatch();

                dgvBatch.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvBatch.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvBatch.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadBatch()
        {
            BatchController controller = new BatchController();

            dgvBatch.DataSource = controller.GetAllBatch();
        }
        private void ClearForm()
        {
            selectedBatchId = 0;

            txtBatchCode.Clear();
            txtBatchWeight.Clear();

            if (cbQc.Items.Count > 0)
                cbQc.SelectedIndex = 0;

            if (cbBatchStatus.Items.Count > 0)
                cbBatchStatus.SelectedIndex = 0;

            dtpBatchDate.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BatchController controller =
                    new BatchController();

                controller.AddBatch(
                    Convert.ToInt32(cbQc.SelectedValue),
                    txtBatchCode.Text,
                    dtpBatchDate.Value,
                    Convert.ToDecimal(txtBatchWeight.Text),
                    cbBatchStatus.Text
                );

                MessageBox.Show(
                    "Data batch berhasil ditambahkan!");

                LoadBatch();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBatch.Rows[e.RowIndex];

                selectedBatchId = Convert.ToInt32(row.Cells["batch_id"].Value);

                cbQc.SelectedValue = Convert.ToInt32(row.Cells["qc_id"].Value);
                txtBatchCode.Text = row.Cells["batch_code"].Value?.ToString() ?? "";

                object? dateValue = row.Cells["batch_date"].Value;

                if (dateValue != null && dateValue != DBNull.Value)
                {
                    if (dateValue is DateTime dateTime)
                    {
                        dtpBatchDate.Value = dateTime;
                    }
                    else if (dateValue is DateOnly dateOnly)
                    {
                        dtpBatchDate.Value = dateOnly.ToDateTime(TimeOnly.MinValue);
                    }
                    else
                    {
                        dtpBatchDate.Value = Convert.ToDateTime(dateValue);
                    }
                }
                txtBatchWeight.Text = row.Cells["batch_weight"].Value?.ToString() ?? "";
                cbBatchStatus.Text = row.Cells["batch_status"].Value?.ToString() ?? "";
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedBatchId == 0)
                {
                    MessageBox.Show("Pilih data batch dulu!");
                    return;
                }

                BatchController controller = new BatchController();

                int qcId = Convert.ToInt32(cbQc.SelectedValue);
                string batchCode = txtBatchCode.Text;
                DateTime batchDate = dtpBatchDate.Value;
                string batchStatus = cbBatchStatus.Text;

                controller.UpdateBatch(
                    selectedBatchId,
                    qcId,
                    batchCode,
                    batchDate,
                    batchStatus
                );

                MessageBox.Show("Data batch berhasil diupdate");

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
            if (selectedBatchId == 0)
            {
                MessageBox.Show("Pilih data batch dulu!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data batch ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    BatchController controller = new BatchController();

                    controller.DeleteBatch(selectedBatchId);

                    MessageBox.Show("Data batch berhasil dihapus!");

                    LoadBatch();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
