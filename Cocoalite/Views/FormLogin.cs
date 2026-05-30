using System;
using System.Windows.Forms;
using Cocoalite.Controllers;
using Cocoalite.Helpers;

namespace Cocoalite.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Username dan password harus diisi!");
                    return;
                }

                LoginController controller = new LoginController();

                bool success = controller.Login(
                    txtUsername.Text,
                    txtPassword.Text
                );

                if (success)
                {
                    MessageBox.Show(
                        "Login berhasil sebagai " + LoginSession.Role
                    );

                    FormMain formMain = new FormMain();
                    formMain.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}