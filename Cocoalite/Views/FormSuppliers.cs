using System;
using System.Windows.Forms;
using Cocoalite.Controllers;

namespace Cocoalite.Views
{
    public partial class FormSuppliers : Form
    {
        private int selectedSupplierId = 0;

        public FormSuppliers()
        {
            InitializeComponent();
        }

        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            LoadSuppliers();

            dgv1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv1.MultiSelect = false;
        }

        private void LoadSuppliers()
        {
            try
            {
                SupplierController controller = new SupplierController();
                dgv1.DataSource = controller.GetAllSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            selectedSupplierId = 0;
            txtSupplierName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (
                txtSupplierName.Text == "" ||
                txtAddress.Text == "" ||
                txtPhone.Text == "" ||
                txtEmail.Text == ""
            )
            {
                MessageBox.Show("Semua field harus diisi!");
                return;
            }

            try
            {
                SupplierController controller = new SupplierController();

                controller.AddSupplier(
                    txtSupplierName.Text,
                    txtAddress.Text,
                    txtPhone.Text,
                    txtEmail.Text
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv1.Rows[e.RowIndex];

                selectedSupplierId =
                    Convert.ToInt32(row.Cells["supplier_id"].Value);

                txtSupplierName.Text =
                    row.Cells["supplier_name"].Value?.ToString();

                txtAddress.Text =
                    row.Cells["address"].Value?.ToString();

                txtPhone.Text =
                    row.Cells["phone_number"].Value?.ToString();

                txtEmail.Text =
                    row.Cells["email"].Value?.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == 0)
            {
                MessageBox.Show("Pilih data supplier dulu!");
                return;
            }

            if (
                txtSupplierName.Text == "" ||
                txtAddress.Text == "" ||
                txtPhone.Text == "" ||
                txtEmail.Text == ""
            )
            {
                MessageBox.Show("Semua field harus diisi!");
                return;
            }

            try
            {
                SupplierController controller = new SupplierController();

                controller.UpdateSupplier(
                    selectedSupplierId,
                    txtSupplierName.Text,
                    txtAddress.Text,
                    txtPhone.Text,
                    txtEmail.Text
                );

                MessageBox.Show("Supplier berhasil diupdate!");

                LoadSuppliers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == 0)
            {
                MessageBox.Show("Pilih supplier dulu!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus supplier ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    SupplierController controller =
                        new SupplierController();

                    controller.DeleteSupplier(selectedSupplierId);

                    MessageBox.Show("Supplier berhasil dihapus!");

                    LoadSuppliers();
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