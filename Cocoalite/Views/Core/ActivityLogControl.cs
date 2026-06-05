using System;
using System.Windows.Forms;
using Cocoalite.Controllers;

namespace Cocoalite.Views
{
    public partial class ActivityLogControl : UserControl
    {
        public ActivityLogControl()
        {
            InitializeComponent();
        }

        private void ActivityLogControl_Load(object sender, EventArgs e)
        {
            LoadActivityLog();
            AturDataGridView();
        }

        private void LoadActivityLog()
        {
            try
            {
                ActivityLogController controller = new ActivityLogController();

                dgvActivityLog.DataSource = controller.GetAllActivityLogs();

                AturHeaderKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AturDataGridView()
        {
            dgvActivityLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivityLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActivityLog.MultiSelect = false;
            dgvActivityLog.ReadOnly = true;
            dgvActivityLog.AllowUserToAddRows = false;
            dgvActivityLog.AllowUserToDeleteRows = false;
            dgvActivityLog.RowHeadersVisible = false;
        }

        private void AturHeaderKolom()
        {
            if (dgvActivityLog.Columns.Contains("log_id"))
            {
                dgvActivityLog.Columns["log_id"].HeaderText = "ID";
                dgvActivityLog.Columns["log_id"].Width = 50;
            }

            if (dgvActivityLog.Columns.Contains("user_id"))
            {
                dgvActivityLog.Columns["user_id"].Visible = false;
            }

            if (dgvActivityLog.Columns.Contains("full_name"))
            {
                dgvActivityLog.Columns["full_name"].HeaderText = "User";
            }

            if (dgvActivityLog.Columns.Contains("activity"))
            {
                dgvActivityLog.Columns["activity"].HeaderText = "Activity";
            }

            if (dgvActivityLog.Columns.Contains("log_time"))
            {
                dgvActivityLog.Columns["log_time"].HeaderText = "Log Time";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadActivityLog();
        }
    }
}