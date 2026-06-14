using System;
using System.Windows.Forms;
using Cocoalite.Controllers;
using System.Drawing.Drawing2D;

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
            AturTampilanPanelDanTabel();
        }

        private void LoadActivityLog()
        {
            try
            {
                ActivityLogController controller = new ActivityLogController();

                dgvActivityLog.DataSource = controller.GetAllActivityLogs();

                AturHeaderKolom();
                AturDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AturDataGridView()
        {
            dgvActivityLog.BackgroundColor = Color.White;
            dgvActivityLog.BorderStyle = BorderStyle.None;
            dgvActivityLog.GridColor = Color.FromArgb(230, 220, 210);

            dgvActivityLog.EnableHeadersVisualStyles = false;
            dgvActivityLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvActivityLog.ColumnHeadersHeight = 42;

            dgvActivityLog.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(92, 49, 13);
            dgvActivityLog.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvActivityLog.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvActivityLog.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvActivityLog.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);

            dgvActivityLog.DefaultCellStyle.BackColor = Color.White;
            dgvActivityLog.DefaultCellStyle.ForeColor = Color.FromArgb(74, 44, 30);
            dgvActivityLog.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvActivityLog.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 129, 74);
            dgvActivityLog.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvActivityLog.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);

            dgvActivityLog.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 246, 240);

            dgvActivityLog.RowHeadersVisible = false;
            dgvActivityLog.RowTemplate.Height = 38;

            dgvActivityLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActivityLog.MultiSelect = false;
            dgvActivityLog.ReadOnly = true;
            dgvActivityLog.AllowUserToAddRows = false;
            dgvActivityLog.AllowUserToDeleteRows = false;
            dgvActivityLog.AllowUserToResizeRows = false;

            dgvActivityLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivityLog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvActivityLog.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvActivityLog.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void AturTampilanPanelDanTabel()
        {
            StylePanel(panelTable);
            StyleDataGridView(dgvActivityLog);
        }
        private void StylePanel(Panel panel)
        {
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.None;
            panel.Padding = new Padding(20);

            panel.Paint -= Panel_Paint;
            panel.Paint += Panel_Paint;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadActivityLog();
        }

        private void Panel_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is not Panel panel)
            {
                return;
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

            using (GraphicsPath path = GetRoundedRectangle(rect, 12))
            using (Pen borderPen = new Pen(Color.FromArgb(215, 195, 175), 1))
            using (SolidBrush backgroundBrush = new SolidBrush(Color.White))
            {
                e.Graphics.FillPath(backgroundBrush, path);
                e.Graphics.DrawPath(borderPen, path);
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            return path;
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(230, 220, 210);

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 42;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(92, 49, 13);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 6, 0);

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(74, 44, 30);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 129, 74);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Padding = new Padding(6, 4, 6, 4);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 246, 240);

            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 36;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void AturHeaderKolom()
        {
            if (dgvActivityLog.Columns.Contains("LogId"))
            {
                dgvActivityLog.Columns["LogId"].HeaderText = "Log ID";
                dgvActivityLog.Columns["LogId"].Width = 70;
                dgvActivityLog.Columns["LogId"].DisplayIndex = 0;
            }

            if (dgvActivityLog.Columns.Contains("UserId"))
            {
                dgvActivityLog.Columns["UserId"].Visible = false;
            }

            if (dgvActivityLog.Columns.Contains("FullName"))
            {
                dgvActivityLog.Columns["FullName"].HeaderText = "User";
                dgvActivityLog.Columns["FullName"].Width = 180;
                dgvActivityLog.Columns["FullName"].DisplayIndex = 1;
            }

            if (dgvActivityLog.Columns.Contains("Activity"))
            {
                dgvActivityLog.Columns["Activity"].HeaderText = "Activity";
                dgvActivityLog.Columns["Activity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvActivityLog.Columns["Activity"].DisplayIndex = 2;
            }

            if (dgvActivityLog.Columns.Contains("LogTime"))
            {
                dgvActivityLog.Columns["LogTime"].HeaderText = "Log Time";
                dgvActivityLog.Columns["LogTime"].Width = 180;
                dgvActivityLog.Columns["LogTime"].DisplayIndex = 3;
                dgvActivityLog.Columns["LogTime"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
        }
    }
}