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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Username harus diisi!");
                    txtUsername.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Password harus diisi!");
                    txtPassword.Focus();
                    return;
                }

                LoginController controller = new LoginController();

                bool success = controller.Login(
                    txtUsername.Text.Trim(),
                    txtPassword.Text.Trim()
                );

                if (success)
                {
                    FormMain formMain = new FormMain();
                    formMain.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!");
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen goldPen = new Pen(Color.FromArgb(230, 180, 120), 4);
            Brush goldBrush = new SolidBrush(Color.FromArgb(230, 180, 120));

            // badan biji kakao
            Rectangle pod = new Rectangle(45, 25, 50, 75);
            g.DrawEllipse(goldPen, pod);

            // garis tengah
            g.DrawLine(goldPen, 70, 30, 70, 95);

            // biji-biji kecil
            for (int i = 0; i < 5; i++)
            {
                g.FillEllipse(goldBrush, 60, 38 + (i * 11), 8, 8);
                g.FillEllipse(goldBrush, 73, 38 + (i * 11), 8, 8);
            }

            // daun kiri dan kanan
            g.DrawEllipse(goldPen, new Rectangle(35, 5, 35, 25));
            g.DrawEllipse(goldPen, new Rectangle(70, 5, 35, 25));

            goldPen.Dispose();
            goldBrush.Dispose();
        }
    }
}