using System;
using System.Windows.Forms;
using Cocoalite.Controllers;

namespace Cocoalite.Views
{
    public partial class KelolaQcControl : UserControl
    {
        private int selectedUserId = 0;

        public KelolaQcControl()
        {
            InitializeComponent();
        }

        private void KelolaQcControl_Load(object sender, EventArgs e)
        {
            txtFullName.MaxLength = 100;
            txtUsername.MaxLength = 30;
            txtPassword.MaxLength = 20;
            txtRecoveryCode.MaxLength = 30;

            LoadQcUsers();
            AturDataGridView();
        }
        private void LoadQcUsers()
        {
            try
            {
                LoginController controller = new LoginController();

                dgvQcUsers.DataSource = controller.GetAllQcUsers();

                AturHeaderKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AturDataGridView()
        {
            dgvQcUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQcUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQcUsers.MultiSelect = false;
            dgvQcUsers.ReadOnly = true;
            dgvQcUsers.AllowUserToAddRows = false;
            dgvQcUsers.AllowUserToDeleteRows = false;
            dgvQcUsers.RowHeadersVisible = false;
        }

        private void AturHeaderKolom()
        {
            if (dgvQcUsers.Columns.Contains("user_id"))
            {
                dgvQcUsers.Columns["user_id"].HeaderText = "ID";
                dgvQcUsers.Columns["user_id"].Width = 50;
            }

            if (dgvQcUsers.Columns.Contains("full_name"))
            {
                dgvQcUsers.Columns["full_name"].HeaderText = "Full Name";
            }

            if (dgvQcUsers.Columns.Contains("username"))
            {
                dgvQcUsers.Columns["username"].HeaderText = "Username";
            }

            if (dgvQcUsers.Columns.Contains("role"))
            {
                dgvQcUsers.Columns["role"].HeaderText = "Role";
            }

            if (dgvQcUsers.Columns.Contains("created_at"))
            {
                dgvQcUsers.Columns["created_at"].HeaderText = "Created At";
            }
        }

        private bool ValidasiInput()
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string recoveryCode = txtRecoveryCode.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Full name harus diisi.");
                txtFullName.Focus();
                return false;
            }

            if (fullName.Length > 100)
            {
                MessageBox.Show("Full name maksimal 100 karakter.");
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username harus diisi.");
                txtUsername.Focus();
                return false;
            }

            if (username.Length < 4)
            {
                MessageBox.Show("Username minimal 4 karakter.");
                txtUsername.Focus();
                return false;
            }

            if (username.Length > 30)
            {
                MessageBox.Show("Username maksimal 30 karakter.");
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password harus diisi.");
                txtPassword.Focus();
                return false;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter.");
                txtPassword.Focus();
                return false;
            }

            if (password.Length > 20)
            {
                MessageBox.Show("Password maksimal 20 karakter.");
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(recoveryCode))
            {
                MessageBox.Show("Kode pemulihan harus diisi.");
                txtRecoveryCode.Focus();
                return false;
            }

            if (recoveryCode.Length < 4)
            {
                MessageBox.Show("Kode pemulihan minimal 4 karakter.");
                txtRecoveryCode.Focus();
                return false;
            }

            if (recoveryCode.Length > 30)
            {
                MessageBox.Show("Kode pemulihan maksimal 30 karakter.");
                txtRecoveryCode.Focus();
                return false;
            }

            return true;

        }

     private void ClearForm()
        {
            selectedUserId = 0;
            txtFullName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtRecoveryCode.Clear();
            txtFullName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
            {
                return;
            }

            try
            {
                LoginController controller = new LoginController();

                controller.AddQcUser(
                    txtFullName.Text.Trim(),
                    txtUsername.Text.Trim(),
                    txtPassword.Text.Trim(),
                    txtRecoveryCode.Text.Trim()
                );

                MessageBox.Show("Akun QC berhasil ditambahkan.");

                LoadQcUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menambahkan akun QC: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Pilih akun QC terlebih dahulu.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus akun QC ini?",
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
                LoginController controller = new LoginController();

                controller.DeleteQcUser(selectedUserId);

                MessageBox.Show("Akun QC berhasil dihapus.");

                LoadQcUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Akun QC tidak dapat dihapus jika sudah digunakan pada data Quality Control.\n\nDetail: " + ex.Message,
                    "Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvQcUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvQcUsers.Rows[e.RowIndex];

            selectedUserId = Convert.ToInt32(row.Cells["user_id"].Value);

            txtFullName.Text = row.Cells["full_name"].Value?.ToString() ?? "";
            txtUsername.Text = row.Cells["username"].Value?.ToString() ?? "";
            txtPassword.Clear();
            txtRecoveryCode.Clear();
        }
    }
}