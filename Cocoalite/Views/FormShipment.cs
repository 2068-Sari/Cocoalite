using Cocoalite.Controllers;
using Cocoalite.Models.Entity;
using System;
using System.Windows.Forms;

namespace Cocoalite.Views
{
    public partial class FormShipment : Form
    {
        private int selectedShipmentId = 0;

        public FormShipment()
        {
            InitializeComponent();
        }

        private void FormShipment_Load(object sender, EventArgs e)
        {
            try
            {
                ShipmentController controller = new ShipmentController();

                cbBatch.DataSource = controller.GetAllBatch();
                cbBatch.DisplayMember = "batch_code";
                cbBatch.ValueMember = "batch_id";

                cbCreatedBy.DataSource = controller.GetAllUsers();
                cbCreatedBy.DisplayMember = "full_name";
                cbCreatedBy.ValueMember = "user_id";

                cbShipmentStatus.Items.Clear();
                cbShipmentStatus.Items.Add("Pending");
                cbShipmentStatus.Items.Add("Shipped");
                cbShipmentStatus.Items.Add("Delivered");
                cbShipmentStatus.Items.Add("Cancelled");

                if (cbShipmentStatus.Items.Count > 0)
                {
                    cbShipmentStatus.SelectedIndex = 0;
                }

                LoadShipment();

                dgvShipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvShipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvShipment.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadShipment()
        {
            ShipmentController controller = new ShipmentController();
            dgvShipment.DataSource = controller.GetAllShipment();
        }

        private void ClearForm()
        {
            selectedShipmentId = 0;

            if (cbBatch.Items.Count > 0)
            {
                cbBatch.SelectedIndex = 0;
            }

            if (cbCreatedBy.Items.Count > 0)
            {
                cbCreatedBy.SelectedIndex = 0;
            }

            txtShipmentCode.Clear();
            txtDestination.Clear();
            dtpShipmentDate.Value = DateTime.Now;
            txtShipmentWeight.Clear();

            if (cbShipmentStatus.Items.Count > 0)
            {
                cbShipmentStatus.SelectedIndex = 0;
            }

            txtVehicleNumber.Clear();
            txtDriverName.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ShipmentController controller = new ShipmentController();

                Shipment shipment = new Shipment();

                shipment.BatchId = Convert.ToInt32(cbBatch.SelectedValue);
                shipment.CreatedBy = Convert.ToInt32(cbCreatedBy.SelectedValue);
                shipment.ShipmentCode = txtShipmentCode.Text;
                shipment.Destination = txtDestination.Text;
                shipment.ShipmentDate = DateOnly.FromDateTime(dtpShipmentDate.Value);
                shipment.ShipmentWeight = Convert.ToDecimal(txtShipmentWeight.Text);
                shipment.VehicleNumber = txtVehicleNumber.Text;
                shipment.DriverName = txtDriverName.Text;

                string shipmentStatus = cbShipmentStatus.Text;

                if (shipmentStatus == "Shipped")
                {
                    shipment.TandaiDikirim();
                }
                else if (shipmentStatus == "Delivered")
                {
                    shipment.TandaiDiterima();
                }
                else if (shipmentStatus == "Cancelled")
                {
                    shipment.BatalkanPengiriman();
                }

                controller.AddShipment(shipment);

                MessageBox.Show("Data shipment berhasil ditambahkan");

                LoadShipment();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvShipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvShipment.Rows[e.RowIndex];

                selectedShipmentId =
                    Convert.ToInt32(row.Cells["shipment_id"].Value);

                cbBatch.SelectedValue =
                    Convert.ToInt32(row.Cells["batch_id"].Value);

                cbCreatedBy.SelectedValue =
                    Convert.ToInt32(row.Cells["created_by"].Value);

                txtShipmentCode.Text =
                    row.Cells["shipment_code"].Value?.ToString() ?? "";

                txtDestination.Text =
                    row.Cells["destination"].Value?.ToString() ?? "";

                object? shipmentDateValue = row.Cells["shipment_date"].Value;

                if (shipmentDateValue is DateOnly dateOnly)
                {
                    dtpShipmentDate.Value = dateOnly.ToDateTime(TimeOnly.MinValue);
                }
                else
                {
                    dtpShipmentDate.Value = Convert.ToDateTime(shipmentDateValue);
                }

                txtShipmentWeight.Text =
                    row.Cells["shipment_weight"].Value?.ToString() ?? "";

                cbShipmentStatus.Text =
                    row.Cells["shipment_status"].Value?.ToString() ?? "";

                txtVehicleNumber.Text =
                    row.Cells["vehicle_number"].Value?.ToString() ?? "";

                txtDriverName.Text =
                    row.Cells["driver_name"].Value?.ToString() ?? "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedShipmentId == 0)
                {
                    MessageBox.Show("Pilih data shipment dulu!");
                    return;
                }

                ShipmentController controller = new ShipmentController();

                string destination = txtDestination.Text;
                DateTime shipmentDate = dtpShipmentDate.Value;
                string shipmentStatus = cbShipmentStatus.Text;
                string vehicleNumber = txtVehicleNumber.Text;
                string driverName = txtDriverName.Text;

                controller.UpdateShipment(
                    selectedShipmentId,
                    destination,
                    shipmentDate,
                    shipmentStatus,
                    vehicleNumber,
                    driverName
                );

                MessageBox.Show("Data shipment berhasil diupdate");

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
                MessageBox.Show("Pilih data shipment dulu!");
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menghapus data shipment ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    ShipmentController controller = new ShipmentController();

                    controller.DeleteShipment(selectedShipmentId);

                    MessageBox.Show("Data shipment berhasil dihapus");

                    LoadShipment();
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