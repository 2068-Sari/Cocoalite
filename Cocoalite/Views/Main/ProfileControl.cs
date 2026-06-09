using System;
using System.Windows.Forms;
using Cocoalite.Controllers;
using Cocoalite.Helpers;

namespace Cocoalite.Views
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
            lblFullNameValue.Text = LoginSession.CurrentUser?.FullName ?? "-";
            lblUsernameValue.Text = LoginSession.CurrentUser?.Username ?? "-";
            lblRoleValue.Text = LoginSession.CurrentUser?.Role ?? "-";

            txtOldPassword.MaxLength = 20;
            txtNewPassword.MaxLength = 20;
            txtConfirmPassword.MaxLength = 20;
        }
        private bool ValidasiInput()
        {
            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(oldPassword))
            {
                MessageBox.Show("Password lama harus diisi.");
                txtOldPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Password baru harus diisi.");
                txtNewPassword.Focus();
                return false;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Password baru minimal 6 karakter.");
                txtNewPassword.Focus();
                return false;
            }

            if (newPassword.Length > 20)
            {
                MessageBox.Show("Password baru maksimal 20 karakter.");
                txtNewPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Konfirmasi password harus diisi.");
                txtConfirmPassword.Focus();
                return false;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Konfirmasi password tidak sama.");
                txtConfirmPassword.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
            {
                return;
            }

            try
            {
                if (LoginSession.CurrentUser == null)
                {
                    MessageBox.Show("Session login tidak ditemukan.");
                    return;
                }

                LoginController controller = new LoginController();

                bool berhasil = controller.ChangePassword(
                    LoginSession.CurrentUser.UserId,
                    txtOldPassword.Text.Trim(),
                    txtNewPassword.Text.Trim()
                );

                if (!berhasil)
                {
                    MessageBox.Show(
                        "Password lama salah.",
                        "Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                MessageBox.Show(
                    "Password berhasil diperbarui.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtOldPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah password: " + ex.Message);
            }
        }
    }
}