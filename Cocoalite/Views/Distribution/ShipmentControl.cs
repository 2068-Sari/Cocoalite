using System;
using System.Windows.Forms;
using Cocoalite.Controllers;
using Cocoalite.Helpers;
using Cocoalite.Models.Entity;

namespace Cocoalite.Views
{
    public partial class ShipmentControl : UserControl
    {
        private int selectedShipmentId = 0;

        public ShipmentControl()
        {
            InitializeComponent();
        }

        private void ShipmentControl_Load(object sender, EventArgs e)
        {
            LoadBatch();
            LoadStatus();
            LoadShipment();
            AturDataGridView();
        }

        private void LoadBatch()
        {
            try
            {
                ShipmentController controller = new ShipmentController();

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

        private void LoadStatus()
        {
            cbShipmentStatus.Items.Clear();
            cbShipmentStatus.Items.Add("Pending");
            cbShipmentStatus.Items.Add("Shipped");
            cbShipmentStatus.Items.Add("Delivered");
            cbShipmentStatus.SelectedIndex = 0;
        }

        private void LoadShipment()
        {
            try
            {
                ShipmentController controller = new ShipmentController();

                dgvShipment.DataSource = controller.GetAllShipment();

                AturHeaderKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AturDataGridView()
        {
            dgvShipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShipment.MultiSelect = false;
            dgvShipment.ReadOnly = true;
            dgvShipment.AllowUserToAddRows = false;
            dgvShipment.AllowUserToDeleteRows = false;
            dgvShipment.RowHeadersVisible = false;
        }

        private void AturHeaderKolom()
        {
            if (dgvShipment.Columns.Contains("shipment_id"))
            {
                dgvShipment.Columns["shipment_id"].HeaderText = "ID";
                dgvShipment.Columns["shipment_id"].Width = 50;
            }

            if (dgvShipment.Columns.Contains("batch_id"))
            {
                dgvShipment.Columns["batch_id"].Visible = false;
            }

            if (dgvShipment.Columns.Contains("created_by"))
            {
                dgvShipment.Columns["created_by"].Visible = false;
            }

            if (dgvShipment.Columns.Contains("batch_code"))
            {
                dgvShipment.Columns["batch_code"].HeaderText = "Batch Code";
            }

            if (dgvShipment.Columns.Contains("full_name"))
            {
                dgvShipment.Columns["full_name"].HeaderText = "Created By";
            }

            if (dgvShipment.Columns.Contains("shipment_code"))
            {
                dgvShipment.Columns["shipment_code"].HeaderText = "Shipment Code";
            }

            if (dgvShipment.Columns.Contains("destination"))
            {
                dgvShipment.Columns["destination"].HeaderText = "Destination";
            }

            if (dgvShipment.Columns.Contains("shipment_date"))
            {
                dgvShipment.Columns["shipment_date"].HeaderText = "Shipment Date";
            }

            if (dgvShipment.Columns.Contains("shipment_weight"))
            {
                dgvShipment.Columns["shipment_weight"].HeaderText = "Shipment Weight";
            }

            if (dgvShipment.Columns.Contains("shipment_status"))
            {
                dgvShipment.Columns["shipment_status"].HeaderText = "Shipment Status";
            }

            if (dgvShipment.Columns.Contains("vehicle_number"))
            {
                dgvShipment.Columns["vehicle_number"].HeaderText = "Vehicle Number";
            }

            if (dgvShipment.Columns.Contains("driver_name"))
            {
                dgvShipment.Columns["driver_name"].HeaderText = "Driver Name";
            }

            if (dgvShipment.Columns.Contains("created_at"))
            {
                dgvShipment.Columns["created_at"].HeaderText = "Created At";
            }
        }

        private void ClearForm()
        {
            selectedShipmentId = 0;
            cbBatch.SelectedIndex = -1;
            txtShipmentCode.Clear();
            txtDestination.Clear();
            dtpShipmentDate.Value = DateTime.Now;
            txtShipmentWeight.Clear();
            cbShipmentStatus.SelectedIndex = 0;
            txtVehicleNumber.Clear();
            txtDriverName.Clear();
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

            if (string.IsNullOrWhiteSpace(txtShipmentCode.Text))
            {
                MessageBox.Show("Kode shipment tidak boleh kosong!");
                txtShipmentCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Tujuan pengiriman tidak boleh kosong!");
                txtDestination.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtShipmentWeight.Text))
            {
                MessageBox.Show("Berat shipment tidak boleh kosong!");
                txtShipmentWeight.Focus();
                return false;
            }

            if (!decimal.TryParse(txtShipmentWeight.Text, out decimal weight))
            {
                MessageBox.Show("Berat shipment harus berupa angka!");
                txtShipmentWeight.Focus();
                return false;
            }

            if (weight <= 0)
            {
                MessageBox.Show("Berat shipment harus lebih dari 0!");
                txtShipmentWeight.Focus();
                return false;
            }

            if (cbShipmentStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Status shipment harus dipilih!");
                cbShipmentStatus.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtVehicleNumber.Text))
            {
                MessageBox.Show("Nomor kendaraan tidak boleh kosong!");
                txtVehicleNumber.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDriverName.Text))
            {
                MessageBox.Show("Nama driver tidak boleh kosong!");
                txtDriverName.Focus();
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

                Shipment shipment = new Shipment();

                shipment.BatchId = Convert.ToInt32(cbBatch.SelectedValue);
                shipment.CreatedBy = LoginSession.CurrentUser.UserId;
                shipment.ShipmentCode = txtShipmentCode.Text.Trim();
                shipment.Destination = txtDestination.Text.Trim();
                shipment.ShipmentDate = DateOnly.FromDateTime(dtpShipmentDate.Value);
                shipment.ShipmentWeight = decimal.Parse(txtShipmentWeight.Text);
                if (cbShipmentStatus.Text == "Shipped")
                {
                    shipment.TandaiDikirim();
                }
                else if (cbShipmentStatus.Text == "Delivered")
                {
                    shipment.TandaiDiterima();
                }
                else if (cbShipmentStatus.Text == "Cancelled")
                {
                    shipment.BatalkanPengiriman();
                }
                shipment.VehicleNumber = txtVehicleNumber.Text.Trim();
                shipment.DriverName = txtDriverName.Text.Trim();

                ShipmentController controller = new ShipmentController();
                controller.AddShipment(shipment);

                MessageBox.Show("Data shipment berhasil ditambahkan!");

                LoadShipment();
                LoadBatch();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedShipmentId == 0)
            {
                MessageBox.Show("Pilih data shipment terlebih dahulu!");
                return;
            }

            if (!ValidasiInput())
            {
                return;
            }

            try
            {
                Shipment shipment = new Shipment();

                shipment.ShipmentId = selectedShipmentId;
                shipment.BatchId = Convert.ToInt32(cbBatch.SelectedValue);
                shipment.ShipmentCode = txtShipmentCode.Text.Trim();
                shipment.Destination = txtDestination.Text.Trim();
                shipment.ShipmentDate = DateOnly.FromDateTime(dtpShipmentDate.Value);
                shipment.ShipmentWeight = decimal.Parse(txtShipmentWeight.Text);
                if (cbShipmentStatus.Text == "Shipped")
                {
                    shipment.TandaiDikirim();
                }
                else if (cbShipmentStatus.Text == "Delivered")
                {
                    shipment.TandaiDiterima();
                }
                else if (cbShipmentStatus.Text == "Cancelled")
                {
                    shipment.BatalkanPengiriman();
                }
                shipment.VehicleNumber = txtVehicleNumber.Text.Trim();
                shipment.DriverName = txtDriverName.Text.Trim();

                ShipmentController controller = new ShipmentController();

                controller.UpdateShipment(
                    selectedShipmentId,
                    txtDestination.Text.Trim(),
                    dtpShipmentDate.Value,
                    cbShipmentStatus.Text,
                    txtVehicleNumber.Text.Trim(),
                    txtDriverName.Text.Trim()
                );

                MessageBox.Show("Data shipment berhasil diperbarui!");

                LoadShipment();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedShipmentId == 0)
            {
                MessageBox.Show("Pilih data shipment terlebih dahulu!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data shipment ini?",
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
                ShipmentController controller = new ShipmentController();
                controller.DeleteShipment(selectedShipmentId);

                MessageBox.Show("Data shipment berhasil dihapus!");

                LoadShipment();
                LoadBatch();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvShipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvShipment.Rows[e.RowIndex];

            selectedShipmentId = Convert.ToInt32(row.Cells["shipment_id"].Value);

            if (dgvShipment.Columns.Contains("batch_id"))
            {
                cbBatch.SelectedValue = Convert.ToInt32(row.Cells["batch_id"].Value);
            }

            txtShipmentCode.Text = row.Cells["shipment_code"].Value?.ToString() ?? "";
            txtDestination.Text = row.Cells["destination"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["shipment_date"].Value?.ToString(), out DateTime date))
            {
                dtpShipmentDate.Value = date;
            }

            txtShipmentWeight.Text = row.Cells["shipment_weight"].Value?.ToString() ?? "";

            if (dgvShipment.Columns.Contains("shipment_status"))
            {
                cbShipmentStatus.SelectedItem = row.Cells["shipment_status"].Value?.ToString() ?? "Pending";
            }

            txtVehicleNumber.Text = row.Cells["vehicle_number"].Value?.ToString() ?? "";
            txtDriverName.Text = row.Cells["driver_name"].Value?.ToString() ?? "";
        }
    }
}