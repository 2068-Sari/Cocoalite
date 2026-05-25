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
    public partial class FormQualityControl : Form
    {
        private int selectedQcId = 0;
        public FormQualityControl()
        {
            InitializeComponent();
        }

        private void FormQualityControl_Load(object sender, EventArgs e)
        {
            try
            {
                QualityControlController controller =
                    new QualityControlController();

                cbReceiving.DataSource =
                    controller.GetReceiving();

                cbReceiving.DisplayMember =
                    "receiving_code";

                cbReceiving.ValueMember =
                    "receiving_id";

                dgvQc.DataSource =
                    controller.GetAllQualityControl();

                dgvQc.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvQc.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvQc.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadQualityControl()
        {
            QualityControlController controller = new QualityControlController();
            dgvQc.DataSource = controller.GetAllQualityControl();
        }

        private void ClearForm()
        {
            selectedQcId = 0;
            txtMoisture.Clear();
            txtFermentation.Clear();
            txtDefect.Clear();
            txtNotes.Clear();

            if (cbReceiving.Items.Count > 0)
                cbReceiving.SelectedIndex = 0;

            if (cbBeanSize.Items.Count > 0)
                cbBeanSize.SelectedIndex = 0;

            if (cbGrade.Items.Count > 0)
                cbGrade.SelectedIndex = 0;

            if (cbQcStatus.Items.Count > 0)
                cbQcStatus.SelectedIndex = 0;

            dtpInspectionDate.Value = DateTime.Now;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                QualityControlController controller = new QualityControlController();

                controller.AddQualityControl(
                    Convert.ToInt32(cbReceiving.SelectedValue),
                    2, //angka sementarsa untuk inspected_by = QC
                    Convert.ToDecimal(txtMoisture.Text),
                    Convert.ToDecimal(txtFermentation.Text),
                    Convert.ToDecimal(txtDefect.Text),
                    cbBeanSize.Text,
                    cbGrade.Text,
                    cbQcStatus.Text,
                    txtNotes.Text,
                    dtpInspectionDate.Value
                );

                MessageBox.Show("Data quality control berhasil ditambahkan!");

                LoadQualityControl();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvQc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvQc.Rows[e.RowIndex];

                selectedQcId =
                    Convert.ToInt32(row.Cells["qc_id"].Value);

                cbReceiving.Text =
                    row.Cells["receiving_code"].Value?.ToString();

                txtMoisture.Text =
                    row.Cells["moisture_level"].Value?.ToString();

                txtFermentation.Text =
                    row.Cells["fermentation_level"].Value?.ToString();

                txtDefect.Text =
                    row.Cells["defect_level"].Value?.ToString();

                cbBeanSize.Text =
                    row.Cells["bean_size"].Value?.ToString();

                cbGrade.Text =
                    row.Cells["grade"].Value?.ToString();

                cbQcStatus.Text =
                    row.Cells["qc_status"].Value?.ToString();

                txtNotes.Text =
                    row.Cells["inspection_notes"].Value?.ToString();

                dtpInspectionDate.Value =
                    Convert.ToDateTime(row.Cells["inspection_date"].Value);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedQcId == 0)
            {
                MessageBox.Show("Pilih data QC dulu!");
                return;
            }

            try
            {
                QualityControlController controller = new QualityControlController();

                controller.UpdateQualityControl(
                    selectedQcId,
                    Convert.ToInt32(cbReceiving.SelectedValue),
                    Convert.ToDecimal(txtMoisture.Text),
                    Convert.ToDecimal(txtFermentation.Text),
                    Convert.ToDecimal(txtDefect.Text),
                    cbBeanSize.Text,
                    cbGrade.Text,
                    cbQcStatus.Text,
                    txtNotes.Text,
                    dtpInspectionDate.Value
                );

                MessageBox.Show("Data quality control berhasil diupdate!");

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
                MessageBox.Show("Pilih data QC dulu!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data QC ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    QualityControlController controller = new QualityControlController();

                    controller.DeleteQualityControl(selectedQcId);

                    MessageBox.Show("Data quality control berhasil dihapus!");

                    LoadQualityControl();
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
