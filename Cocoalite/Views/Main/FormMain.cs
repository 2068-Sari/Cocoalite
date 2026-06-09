using System;
using System.Windows.Forms;
using Cocoalite.Helpers;


namespace Cocoalite.Views
{
    public partial class FormMain : Form
    {
        private UserControl? activeControl = null;

        private ContextMenuStrip menuAkun = new ContextMenuStrip();
        private ToolStripMenuItem menuKelolaProfile = new ToolStripMenuItem("Kelola Profile");
        private ToolStripMenuItem menuKelolaQc = new ToolStripMenuItem("Kelola QC");

        public FormMain()
        {
            InitializeComponent();
            SiapkanMenuAkun();
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

        private void SiapkanMenuAkun()
        {
            menuAkun.Items.Clear();

            menuKelolaProfile.Click += menuKelolaProfile_Click;
            menuKelolaQc.Click += menuKelolaQc_Click;

            menuAkun.Items.Add(menuKelolaProfile);
            menuAkun.Items.Add(menuKelolaQc);

            btnProfile.Text = "Akun ▼";
            btnProfile.Size = new Size(110, 30);

            // Tombol Kelola QC yang lama tidak dipakai lagi
            btnKelolaQc.Visible = false;

            // Supaya nama user juga bisa diklik untuk membuka menu akun
            lblUserName.Cursor = Cursors.Hand;
            lblUserName.Click += lblUserName_Click;
        }

        private void AturHakAkses()
        {
            if (LoginSession.IsAdmin())
            {
                btnDashboard.Visible = true;
                btnSupplier.Visible = true;
                btnReceiving.Visible = true;

                // Admin tidak boleh akses Quality Control
                btnQualityControl.Visible = false;

                btnBatch.Visible = true;
                btnInventory.Visible = true;
                btnShipment.Visible = true;
                btnActivityLog.Visible = true;
                btnReport.Visible = true;

                btnProfile.Visible = false;
                btnKelolaQc.Visible = false;

                
                menuKelolaQc.Visible = true;

                AturPosisiMenuAdmin();
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

                btnProfile.Visible = false;
                btnKelolaQc.Visible = false;

                
                menuKelolaQc.Visible = false;

                AturPosisiMenuQC();
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

            lblUserName.Text = infoUser + " ▼";
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

        private void AturPosisiMenuQC()
        {
            btnDashboard.Location = new Point(30, 150);
            btnQualityControl.Location = new Point(30, 205);
            btnReport.Location = new Point(30, 260);

            btnDashboard.Size = new Size(180, 40);
            btnQualityControl.Size = new Size(180, 40);
            btnReport.Size = new Size(180, 40);

            // Logout tetap di bawah seperti posisi awal
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.Location = new Point(30, panelSidebar.Height - 85);
            btnLogout.Size = new Size(190, 40);
        }

        private void AturPosisiMenuAdmin()
        {
            btnDashboard.Location = new Point(30, 130);
            btnSupplier.Location = new Point(30, 178);
            btnReceiving.Location = new Point(30, 226);
            btnBatch.Location = new Point(30, 274);
            btnInventory.Location = new Point(30, 322);
            btnShipment.Location = new Point(30, 370);
            btnActivityLog.Location = new Point(30, 418);
            btnReport.Location = new Point(30, 466);

            btnDashboard.Size = new Size(180, 40);
            btnSupplier.Size = new Size(180, 40);
            btnReceiving.Size = new Size(180, 40);
            btnBatch.Size = new Size(180, 40);
            btnInventory.Size = new Size(180, 40);
            btnShipment.Size = new Size(180, 40);
            btnActivityLog.Size = new Size(180, 40);
            btnReport.Size = new Size(180, 40);

            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.Location = new Point(30, panelSidebar.Height - 85);
            btnLogout.Size = new Size(190, 40);
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

        private void menuKelolaProfile_Click(object? sender, EventArgs e)
        {
            TampilkanControl(new ProfileControl());
        }

        private void menuKelolaQc_Click(object? sender, EventArgs e)
        {
            TampilkanControl(new KelolaQcControl());
        }

        private void lblUserName_Click(object? sender, EventArgs e)
        {
            menuAkun.Show(lblUserName, new Point(0, lblUserName.Height));
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
            if (!LoginSession.IsQualityController())
            {
                MessageBox.Show(
                    "Fitur Quality Control hanya dapat diakses oleh user QC.",
                    "Akses Ditolak",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            menuAkun.Show(btnProfile, new Point(0, btnProfile.Height));
        }

        private void btnKelolaQc_Click(object sender, EventArgs e)
        {
            TampilkanControl(new KelolaQcControl());
        }
    }
}