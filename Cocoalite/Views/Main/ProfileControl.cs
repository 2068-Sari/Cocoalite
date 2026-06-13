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

        /// <summary>
        /// PERBAIKAN: Hanya cek kelengkapan dan kesesuaian password vs konfirmasi.
        /// Aturan panjang password (6-20) dihapus — itu business rule milik Controller.
        /// Cek password == konfirmasi tetap di sini karena ini UX concern murni
        /// (mencegah typo sebelum request dikirim ke Controller).
        /// </summary>
        private bool ValidasiInputLengkap()
        {
            if (string.IsNullOrWhiteSpace(txtOldPassword.Text))
            { MessageBox.Show("Password lama harus diisi."); txtOldPassword.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            { MessageBox.Show("Password baru harus diisi."); txtNewPassword.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            { MessageBox.Show("Konfirmasi password harus diisi."); txtConfirmPassword.Focus(); return false; }

            // Ini UX concern: mencegah typo sebelum request dikirim.
            // Bukan business rule — tidak ada logika bisnis di sini.
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            { MessageBox.Show("Konfirmasi password tidak sama."); txtConfirmPassword.Focus(); return false; }

            return true;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (!ValidasiInputLengkap()) return;

            try
            {
                if (LoginSession.CurrentUser == null)
                { MessageBox.Show("Session login tidak ditemukan."); return; }

                LoginController controller = new LoginController();

                bool berhasil = controller.ChangePassword(
                    LoginSession.CurrentUser.UserId,
                    txtOldPassword.Text.Trim(),
                    txtNewPassword.Text.Trim()
                );

                if (!berhasil)
                {
                    MessageBox.Show("Password lama salah.", "Gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Password berhasil diperbarui.", "Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtOldPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
            }
            catch (ArgumentException ex)
            {
                // Business rule dari LoginController (panjang password, dsb.)
                MessageBox.Show(ex.Message, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah password: " + ex.Message);
            }
        }
    }
}