using System;
using System.Windows.Forms;
using Cocoalite.Controllers;


namespace Cocoalite.Views
{
    public partial class BatchControl : UserControl
    {
        private int selectedBatchId = 0;

        public BatchControl()
        {
            InitializeComponent();
        }

        private void BatchControl_Load(object sender, EventArgs e)
        {
            LoadApprovedQc();
            LoadBatch();
            LoadStatus();
            AturDataGridView();
        }

        private void LoadApprovedQc()
        {
            try
            {
                BatchController controller = new BatchController();

                cbQc.DataSource = controller.GetApprovedQc();
                cbQc.DisplayMember = "qc_display";
                cbQc.ValueMember = "qc_id";
                cbQc.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadStatus()
        {
            cbBatchStatus.Items.Clear();
            cbBatchStatus.Items.Add("Available");
            cbBatchStatus.Items.Add("Partially Distributed");
            cbBatchStatus.Items.Add("Distributed");
            cbBatchStatus.SelectedIndex = 0;
        }

        private void LoadBatch()
        {
            try
            {
                BatchController controller = new BatchController();
                dgvBatch.DataSource = controller.GetAllBatch();

                AturHeaderKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AturDataGridView()
        {
            dgvBatch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatch.MultiSelect = false;
            dgvBatch.ReadOnly = true;
            dgvBatch.AllowUserToAddRows = false;
            dgvBatch.AllowUserToDeleteRows = false;
            dgvBatch.RowHeadersVisible = false;
        }

        private void AturHeaderKolom()
        {
            if (dgvBatch.Columns.Contains("batch_id"))
            {
                dgvBatch.Columns["batch_id"].HeaderText = "ID";
                dgvBatch.Columns["batch_id"].Width = 50;
            }

            if (dgvBatch.Columns.Contains("qc_id"))
            {
                dgvBatch.Columns["qc_id"].Visible = false;
            }

            if (dgvBatch.Columns.Contains("receiving_code"))
            {
                dgvBatch.Columns["receiving_code"].HeaderText = "Receiving Code";
            }

            if (dgvBatch.Columns.Contains("grade"))
            {
                dgvBatch.Columns["grade"].HeaderText = "Grade";
            }

            if (dgvBatch.Columns.Contains("batch_code"))
            {
                dgvBatch.Columns["batch_code"].HeaderText = "Batch Code";
            }

            if (dgvBatch.Columns.Contains("batch_date"))
            {
                dgvBatch.Columns["batch_date"].HeaderText = "Batch Date";
            }

            if (dgvBatch.Columns.Contains("batch_weight"))
            {
                dgvBatch.Columns["batch_weight"].HeaderText = "Batch Weight";
            }

            if (dgvBatch.Columns.Contains("batch_status"))
            {
                dgvBatch.Columns["batch_status"].HeaderText = "Batch Status";
            }

            if (dgvBatch.Columns.Contains("created_at"))
            {
                dgvBatch.Columns["created_at"].HeaderText = "Created At";
            }
        }

        private void ClearForm()
        {
            selectedBatchId = 0;
            cbQc.SelectedIndex = -1;
            txtBatchCode.Clear();
            dtpBatchDate.Value = DateTime.Now;
            txtBatchWeight.Clear();
            cbBatchStatus.SelectedIndex = 0;
            cbQc.Focus();
        }

        private bool ValidasiInput()
        {
            if (cbQc.SelectedIndex == -1 || cbQc.SelectedValue == null)
            {
                MessageBox.Show("QC Approved harus dipilih!");
                cbQc.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBatchCode.Text))
            {
                MessageBox.Show("Kode batch tidak boleh kosong!");
                txtBatchCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBatchWeight.Text))
            {
                MessageBox.Show("Berat batch tidak boleh kosong!");
                txtBatchWeight.Focus();
                return false;
            }

            if (!decimal.TryParse(txtBatchWeight.Text, out decimal weight))
            {
                MessageBox.Show("Berat batch harus berupa angka!");
                txtBatchWeight.Focus();
                return false;
            }

            if (weight <= 0)
            {
                MessageBox.Show("Berat batch harus lebih dari 0!");
                txtBatchWeight.Focus();
                return false;
            }

            if (cbBatchStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Status batch harus dipilih!");
                cbBatchStatus.Focus();
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
                BatchController controller = new BatchController();

                controller.UpdateBatch(
                    selectedBatchId,
                    Convert.ToInt32(cbQc.SelectedValue),
                    txtBatchCode.Text.Trim(),
                    dtpBatchDate.Value,
                    decimal.Parse(txtBatchWeight.Text),
                    cbBatchStatus.Text
                );

                MessageBox.Show("Data batch berhasil ditambahkan!");

                LoadBatch();
                LoadApprovedQc();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBatchId == 0)
            {
                MessageBox.Show("Pilih data batch terlebih dahulu!");
                return;
            }

            if (!ValidasiInput())
            {
                return;
            }

            try
            {
                BatchController controller = new BatchController();

                controller.AddBatch(
                    Convert.ToInt32(cbQc.SelectedValue),
                    txtBatchCode.Text.Trim(),
                    dtpBatchDate.Value,
                    decimal.Parse(txtBatchWeight.Text),
                    cbBatchStatus.Text
                );

                MessageBox.Show("Data batch berhasil diperbarui!");

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
                MessageBox.Show("Pilih data batch terlebih dahulu!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data batch ini?",
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
                BatchController controller = new BatchController();
                controller.DeleteBatch(selectedBatchId);

                MessageBox.Show("Data batch berhasil dihapus!");

                LoadBatch();
                LoadApprovedQc();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Data batch tidak dapat dihapus jika sudah digunakan pada inventory atau shipment.\n\nDetail: " + ex.Message
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvBatch.Rows[e.RowIndex];

            selectedBatchId = Convert.ToInt32(row.Cells["batch_id"].Value);

            if (dgvBatch.Columns.Contains("qc_id"))
            {
                cbQc.SelectedValue = Convert.ToInt32(row.Cells["qc_id"].Value);
            }

            txtBatchCode.Text = row.Cells["batch_code"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["batch_date"].Value?.ToString(), out DateTime date))
            {
                dtpBatchDate.Value = date;
            }

            txtBatchWeight.Text = row.Cells["batch_weight"].Value?.ToString() ?? "";

            if (dgvBatch.Columns.Contains("batch_status"))
            {
                cbBatchStatus.SelectedItem = row.Cells["batch_status"].Value?.ToString() ?? "Available";
            }
        }
    }
}