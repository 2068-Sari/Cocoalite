using Cocoalite.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cocoalite.Views
{
    public partial class FormBatch : Form
    {
        public FormBatch()
        {
            InitializeComponent();
        }
    
    private void FormBatch_Load(object sender, EventArgs e)
        {
            try
            {
                BatchController controller =
                    new BatchController();

                cbQc.DataSource =
                    controller.GetApprovedQc();

                cbQc.DisplayMember =
                    "grade";

                cbQc.ValueMember =
                    "qc_id";

                dgvBatch.DataSource =
                    controller.GetAllBatch();

                dgvBatch.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvBatch.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvBatch.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
