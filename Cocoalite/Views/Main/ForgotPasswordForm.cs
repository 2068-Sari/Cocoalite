using Cocoalite.Controllers;
using System;
using System.Windows.Forms;

namespace Cocoalite.Views
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            txtNewPassword.MaxLength = 20;
            txtConfirmPassword.MaxLength = 20;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                LoginController controller = new LoginController();

                bool success = controller.ResetPasswordBySecurityAnswer(
                    txtUsername.Text.Trim(),
                    txtSecurityAnswer.Text.Trim(),
                    txtNewPassword.Text.Trim(),
                    txtConfirmPassword.Text.Trim()
                );

                if (success)
                {
                    MessageBox.Show(
                        "Password berhasil direset. Silakan login menggunakan password baru.",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Reset Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool showPassword = chkShowPassword.Checked;

            txtNewPassword.UseSystemPasswordChar = !showPassword;
            txtConfirmPassword.UseSystemPasswordChar = !showPassword;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}