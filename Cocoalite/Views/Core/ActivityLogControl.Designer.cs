namespace Cocoalite.Views
{
    partial class ActivityLogControl : UserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelTable = new Panel();
            lblTableTitle = new Label();
            btnRefresh = new Button();
            dgvActivityLog = new DataGridView();
            panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivityLog).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(35, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(210, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Activity Log";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(40, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(501, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Riwayat aktivitas pengguna dalam sistem manajemen CocoaLite.";
            // 
            // panelTable
            // 
            panelTable.BackColor = Color.White;
            panelTable.BorderStyle = BorderStyle.FixedSingle;
            panelTable.Controls.Add(lblTableTitle);
            panelTable.Controls.Add(btnRefresh);
            panelTable.Controls.Add(dgvActivityLog);
            panelTable.Location = new Point(40, 120);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(780, 375);
            panelTable.TabIndex = 2;
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTableTitle.Location = new Point(20, 18);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(178, 25);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Daftar Activity Log";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(92, 49, 13);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(635, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 35);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvActivityLog
            // 
            dgvActivityLog.BackgroundColor = Color.White;
            dgvActivityLog.BorderStyle = BorderStyle.None;
            dgvActivityLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivityLog.Location = new Point(20, 65);
            dgvActivityLog.Name = "dgvActivityLog";
            dgvActivityLog.RowHeadersWidth = 51;
            dgvActivityLog.Size = new Size(987, 406);
            dgvActivityLog.TabIndex = 2;
            // 
            // ActivityLogControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelTable);
            Name = "ActivityLogControl";
            Size = new Size(1159, 675);
            Load += ActivityLogControl_Load;
            panelTable.ResumeLayout(false);
            panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivityLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelTable;
        private Label lblTableTitle;
        private Button btnRefresh;
        private DataGridView dgvActivityLog;
    }
}