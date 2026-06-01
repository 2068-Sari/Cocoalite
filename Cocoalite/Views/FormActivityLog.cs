
using System;
using System.Windows.Forms;
using Cocoalite.Controllers;

namespace Cocoalite.Views
{
    public partial class FormActivityLog : Form
    {
        public FormActivityLog()
        {
            InitializeComponent();
        }

        private void FormActivityLog_Load(object sender, EventArgs e)
        {
            LoadActivityLog();
        }

        private void LoadActivityLog()
        {
            try
            {
                ActivityLogController controller = new ActivityLogController();

                dgvActivityLog.DataSource = controller.GetAllActivityLogs();

                dgvActivityLog.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvActivityLog.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvActivityLog.MultiSelect = false;
                dgvActivityLog.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}