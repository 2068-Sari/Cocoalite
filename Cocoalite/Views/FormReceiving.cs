using System;
using System.Windows.Forms;
using Cocoalite.Controllers;

namespace Cocoalite.Views
{
    public partial class FormReceiving : Form
    {
        private int selectedReceivingId = 0;

        public FormReceiving()
        {
            InitializeComponent();
        }

        private void FormReceiving_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadReceiving();

            dgvReceiving.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReceiving.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceiving.MultiSelect = false;
        }

        private void LoadSuppliers()
        {
            try
            {
                ReceivingController controller = new ReceivingController();

                cbSupplier.DataSource = controller.GetSuppliers();
                cbSupplier.DisplayMember = "supplier_name";
                cbSupplier.ValueMember = "supplier_id";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            selectedReceivingId = 0;
            txtReceivingCode.Clear();
            txtCocoaWeight.Clear();
            txtVehicleNumber.Clear();

            if (cbSupplier.Items.Count > 0)
                cbSupplier.SelectedIndex = 0;

            dtpReceivingDate.Value = DateTime.Now;
        }

        private bool IsInputValid()
        {
            if (txtReceivingCode.Text == "" ||
                txtCocoaWeight.Text == "" ||
                txtVehicleNumber.Text == "")
            {
                MessageBox.Show("Semua field harus diisi!");
                return false;
            }

            if (!decimal.TryParse(txtCocoaWeight.Text, out _))
            {
                MessageBox.Show("Cocoa weight harus berupa angka!");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
                return;

            try
            {
                ReceivingController controller = new ReceivingController();

                controller.AddReceiving(
                    Convert.ToInt32(cbSupplier.SelectedValue),
                    1,
                    txtReceivingCode.Text,
                    dtpReceivingDate.Value,
                    Convert.ToDecimal(txtCocoaWeight.Text),
                    txtVehicleNumber.Text
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

        private void dgvReceiving_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReceiving.Rows[e.RowIndex];

                selectedReceivingId = Convert.ToInt32(row.Cells["receiving_id"].Value);

                txtReceivingCode.Text = row.Cells["receiving_code"].Value?.ToString();
                cbSupplier.Text = row.Cells["supplier_name"].Value?.ToString();
                object? dateValue = row.Cells["receiving_date"].Value;

                if (dateValue is DateOnly dateOnly)
                {
                    dtpReceivingDate.Value = dateOnly.ToDateTime(TimeOnly.MinValue);
                }
                else if (dateValue != null)
                {
                    dtpReceivingDate.Value = Convert.ToDateTime(dateValue);
                }
                else
                {
                    dtpReceivingDate.Value = DateTime.Now;
                }
                txtCocoaWeight.Text = row.Cells["cocoa_weight"].Value?.ToString();
                txtVehicleNumber.Text = row.Cells["vehicle_number"].Value?.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedReceivingId == 0)
            {
                MessageBox.Show("Pilih data receiving dulu!");
                return;
            }

            if (!IsInputValid())
                return;

            try
            {
                ReceivingController controller = new ReceivingController();

                controller.UpdateReceiving(
                    selectedReceivingId,
                    Convert.ToInt32(cbSupplier.SelectedValue),
                    txtReceivingCode.Text,
                    dtpReceivingDate.Value,
                    Convert.ToDecimal(txtCocoaWeight.Text),
                    txtVehicleNumber.Text
                );

                MessageBox.Show("Data receiving berhasil diupdate!");

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
                MessageBox.Show("Pilih data receiving dulu!");
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
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