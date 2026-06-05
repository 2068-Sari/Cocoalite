using System;
using System.Windows.Forms;
using Cocoalite.Controllers;

namespace Cocoalite.Views
{
    public partial class SupplierControl : UserControl
    {
        private int selectedSupplierId = 0;

        public SupplierControl()
        {
            InitializeComponent();
        }

        private void SupplierControl_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            AturDataGridView();
        }

        private void LoadSuppliers()
        {
            try
            {
                SupplierController controller = new SupplierController();
                dgv1.DataSource = controller.GetAllSuppliers();

                AturHeaderKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AturDataGridView()
        {
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.MultiSelect = false;
            dgv1.ReadOnly = true;
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.RowHeadersVisible = false;
        }

        private void AturHeaderKolom()
        {
            if (dgv1.Columns.Contains("supplier_id"))
            {
                dgv1.Columns["supplier_id"].HeaderText = "ID";
                dgv1.Columns["supplier_id"].Width = 50;
            }

            if (dgv1.Columns.Contains("supplier_name"))
            {
                dgv1.Columns["supplier_name"].HeaderText = "Supplier Name";
            }

            if (dgv1.Columns.Contains("address"))
            {
                dgv1.Columns["address"].HeaderText = "Address";
            }

            if (dgv1.Columns.Contains("phone_number"))
            {
                dgv1.Columns["phone_number"].HeaderText = "Phone";
            }

            if (dgv1.Columns.Contains("email"))
            {
                dgv1.Columns["email"].HeaderText = "Email";
            }

            if (dgv1.Columns.Contains("created_at"))
            {
                dgv1.Columns["created_at"].HeaderText = "Created At";
            }
        }

        private void ClearForm()
        {
            selectedSupplierId = 0;
            txtSupplierName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtSupplierName.Focus();
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Nama supplier tidak boleh kosong!");
                txtSupplierName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Alamat supplier tidak boleh kosong!");
                txtAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Nomor telepon supplier tidak boleh kosong!");
                txtPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email supplier tidak boleh kosong!");
                txtEmail.Focus();
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
                SupplierController controller = new SupplierController();

                controller.AddSupplier(
                    txtSupplierName.Text.Trim(),
                    txtAddress.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim()
                );

                MessageBox.Show("Supplier berhasil ditambahkan!");

                LoadSuppliers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == 0)
            {
                MessageBox.Show("Pilih data supplier terlebih dahulu!");
                return;
            }

            if (!ValidasiInput())
            {
                return;
            }

            try
            {
                SupplierController controller = new SupplierController();

                controller.UpdateSupplier(
                    selectedSupplierId,
                    txtSupplierName.Text.Trim(),
                    txtAddress.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim()
                );

                MessageBox.Show("Supplier berhasil diperbarui!");

                LoadSuppliers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == 0)
            {
                MessageBox.Show("Pilih data supplier terlebih dahulu!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus supplier ini?",
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
                SupplierController controller = new SupplierController();
                controller.DeleteSupplier(selectedSupplierId);

                MessageBox.Show("Supplier berhasil dihapus!");

                LoadSuppliers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Data supplier tidak dapat dihapus jika sudah digunakan pada data receiving.\n\nDetail: " + ex.Message
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgv1.Rows[e.RowIndex];

            selectedSupplierId = Convert.ToInt32(row.Cells["supplier_id"].Value);

            txtSupplierName.Text = row.Cells["supplier_name"].Value?.ToString() ?? "";
            txtAddress.Text = row.Cells["address"].Value?.ToString() ?? "";
            txtPhone.Text = row.Cells["phone_number"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["email"].Value?.ToString() ?? "";
        }
    }
}