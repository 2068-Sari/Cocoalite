using System;
using System.Windows.Forms;
using Cocoalite.Controllers;
using Cocoalite.Models.Entity;

namespace Cocoalite.Views
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            try
            {
                DashboardController controller = new DashboardController();
                DashboardSummary summary = controller.GetDashboardSummary();

                lblTotalSupplier.Text = summary.TotalSupplier.ToString();
                lblTotalReceiving.Text = summary.TotalReceiving.ToString();
                lblTotalQc.Text = summary.TotalQc.ToString();
                lblTotalBatch.Text = summary.TotalBatch.ToString();
                lblTotalStok.Text = summary.TotalStok.ToString("N2") + " kg";
                lblTotalShipment.Text = summary.TotalShipment.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}