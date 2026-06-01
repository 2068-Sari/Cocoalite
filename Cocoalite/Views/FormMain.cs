using System;
using System.Windows.Forms;
using Cocoalite.Helpers;

namespace Cocoalite.Views
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!LoginSession.IsLoggedIn())
            {
                MessageBox.Show("Silakan login terlebih dahulu.");
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Close();
                return;
            }

            AturHakAkses();
            TampilkanInfoUserLogin();
        }

        private void AturHakAkses()
        {
            if (LoginSession.IsAdmin())
            {
                btnSupplier.Visible = true;
                btnReceiving.Visible = true;
                btnQualityControl.Visible = true;
                btnBatch.Visible = true;
                btnInventory.Visible = true;
                btnShipment.Visible = true;
                btnDashboard.Visible = true;
                btnActivityLog.Visible = true;
            }
            else if (LoginSession.IsQualityController())
            {
                btnSupplier.Visible = false;
                btnReceiving.Visible = false;
                btnQualityControl.Visible = true;
                btnBatch.Visible = false;
                btnInventory.Visible = false;
                btnShipment.Visible = false;
                btnDashboard.Visible = true;
                btnActivityLog.Visible = false;
            }
            else
            {
                MessageBox.Show("Role tidak dikenali.");
            }
        }

        private void TampilkanInfoUserLogin()
        {
            string infoUser = LoginSession.CurrentUser?.TampilkanInfoUser() ?? "";
            string hakAkses = LoginSession.CurrentUser?.TampilkanHakAkses() ?? "";

            this.Text = "CocoaLite - " + infoUser;

            MessageBox.Show(hakAkses);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormSuppliers form = new FormSuppliers();
            form.ShowDialog();
        }

        private void btnReceiving_Click(object sender, EventArgs e)
        {
            FormReceiving form = new FormReceiving();
            form.ShowDialog();
        }

        private void btnQualityControl_Click(object sender, EventArgs e)
        {
            FormQualityControl form = new FormQualityControl();
            form.ShowDialog();
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            FormBatch form = new FormBatch();
            form.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            FormInventory form = new FormInventory();
            form.ShowDialog();
        }

        private void btnShipment_Click(object sender, EventArgs e)
        {
            FormShipment form = new FormShipment();
            form.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard form = new FormDashboard();
            form.ShowDialog();
        }

        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            FormActivityLog form = new FormActivityLog();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginSession.Clear();

            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            this.Close();
        }
    }
}