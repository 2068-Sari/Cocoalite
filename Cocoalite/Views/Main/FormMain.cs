using System;
using System.Windows.Forms;
using Cocoalite.Helpers;


namespace Cocoalite.Views
{
    public partial class FormMain : Form
    {
        private UserControl? activeControl = null;

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

            TampilkanControl(new DashboardControl());
            SetActiveMenu(btnDashboard);
        }

        private void AturHakAkses()
        {
            if (LoginSession.IsAdmin())
            {
                btnDashboard.Visible = true;
                btnSupplier.Visible = true;
                btnReceiving.Visible = true;
                btnQualityControl.Visible = true;
                btnBatch.Visible = true;
                btnInventory.Visible = true;
                btnShipment.Visible = true;
                btnActivityLog.Visible = true;
                btnReport.Visible = true;
            }
            else if (LoginSession.IsQualityController())
            {
                btnDashboard.Visible = true;
                btnSupplier.Visible = false;
                btnReceiving.Visible = false;
                btnQualityControl.Visible = true;
                btnBatch.Visible = false;
                btnInventory.Visible = false;
                btnShipment.Visible = false;
                btnActivityLog.Visible = false;
                btnReport.Visible = true;
            }
            else
            {
                MessageBox.Show("Role tidak dikenali.");
            }
        }

        private void TampilkanInfoUserLogin()
        {
            string infoUser = LoginSession.CurrentUser?.TampilkanInfoUser() ?? "-";
            string role = LoginSession.CurrentUser?.Role ?? "-";

            Text = "CocoaLite - " + infoUser;

            lblUserName.Text = infoUser;
            lblRole.Text = "Role: " + role;
            lblWelcome.Text = "Selamat datang, " + infoUser;
        }

        private void TampilkanControl(UserControl control)
        {
            if (activeControl != null)
            {
                panelContent.Controls.Remove(activeControl);
                activeControl.Dispose();
            }

            activeControl = control;

            control.Dock = DockStyle.Fill;

            panelContent.Controls.Clear();
            panelContent.Controls.Add(control);

            control.BringToFront();
        }

        private void SetActiveMenu(Button activeButton)
        {
            ResetMenuButton();

            activeButton.BackColor = System.Drawing.Color.FromArgb(111, 78, 55);
            activeButton.ForeColor = System.Drawing.Color.White;
        }

        private void ResetMenuButton()
        {
            Button[] menuButtons =
            {
                btnDashboard,
                btnSupplier,
                btnReceiving,
                btnQualityControl,
                btnBatch,
                btnInventory,
                btnShipment,
                btnActivityLog,
                btnReport

            };

            foreach (Button button in menuButtons)
            {
                button.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
                button.ForeColor = System.Drawing.Color.FromArgb(74, 44, 30);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            TampilkanControl(new DashboardControl());
            SetActiveMenu(btnDashboard);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            TampilkanControl(new SupplierControl());
            SetActiveMenu(btnSupplier);
        }

        private void btnReceiving_Click(object sender, EventArgs e)
        {
            TampilkanControl(new ReceivingControl());
            SetActiveMenu(btnReceiving);
        }

        private void btnQualityControl_Click(object sender, EventArgs e)
        {
            TampilkanControl(new QualityControlControl());
            SetActiveMenu(btnQualityControl);
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            TampilkanControl(new BatchControl());
            SetActiveMenu(btnBatch);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            TampilkanControl(new InventoryControl());
            SetActiveMenu(btnInventory);
        }

        private void btnShipment_Click(object sender, EventArgs e)
        {
            TampilkanControl(new ShipmentControl());
            SetActiveMenu(btnShipment);
        }

        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            TampilkanControl(new ActivityLogControl());
            SetActiveMenu(btnActivityLog);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            TampilkanControl(new ReportControl());
            SetActiveMenu(btnReport);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LoginSession.Clear();

                FormLogin formLogin = new FormLogin();
                formLogin.Show();

                this.Close();
            }
        }
    }
}