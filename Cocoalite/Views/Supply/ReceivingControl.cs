using System;
using System.Windows.Forms;
using Cocoalite.Controllers;
using Cocoalite.Helpers;

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

            if (string.IsNullOrWhiteSpace(txtReceivingCode.Text))
            {
                MessageBox.Show("Kode receiving tidak boleh kosong!");
                txtReceivingCode.Focus();
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

            if (weight <= 0)
            {
                MessageBox.Show("Berat kakao harus lebih dari 0!");
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

                ReceivingController controller = new ReceivingController();

                controller.AddReceiving(
                    Convert.ToInt32(cbSupplier.SelectedValue),
                    LoginSession.CurrentUser.UserId,
                    txtReceivingCode.Text.Trim(),
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