
namespace Cocoalite.Views
{
    partial class ReportControl : UserControl
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

            panelFilter = new Panel();
            lblJenisLaporan = new Label();
            cbJenisLaporan = new ComboBox();
            btnGenerate = new Button();
            btnClear = new Button();
            btnDownloadPdf = new Button();

            panelReport = new Panel();
            lblReportTitle = new Label();
            txtReport = new TextBox();

            panelFilter.SuspendLayout();
            panelReport.SuspendLayout();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(55, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(329, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Laporan Sistem";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(58, 88);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(574, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Generate laporan inventory, quality control, dan shipment CocoaLite.";

            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.White;
            panelFilter.BorderStyle = BorderStyle.FixedSingle;
            panelFilter.Controls.Add(lblJenisLaporan);
            panelFilter.Controls.Add(cbJenisLaporan);
            panelFilter.Controls.Add(btnGenerate);
            panelFilter.Controls.Add(btnClear);
            panelFilter.Controls.Add(btnDownloadPdf);
            panelFilter.Location = new Point(55, 135);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1050, 130);
            panelFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFilter.TabIndex = 2;

            // 
            // lblJenisLaporan
            // 
            lblJenisLaporan.AutoSize = false;
            lblJenisLaporan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblJenisLaporan.ForeColor = Color.FromArgb(74, 44, 30);
            lblJenisLaporan.Location = new Point(45, 45);
            lblJenisLaporan.Name = "lblJenisLaporan";
            lblJenisLaporan.Size = new Size(150, 27);
            lblJenisLaporan.TabIndex = 0;
            lblJenisLaporan.Text = "Jenis Laporan";
            lblJenisLaporan.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // cbJenisLaporan
            // 
            cbJenisLaporan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJenisLaporan.Font = new Font("Segoe UI", 9F);
            cbJenisLaporan.FormattingEnabled = true;
            cbJenisLaporan.Location = new Point(220, 45);
            cbJenisLaporan.Name = "cbJenisLaporan";
            cbJenisLaporan.Size = new Size(310, 28);
            cbJenisLaporan.TabIndex = 1;

            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(92, 49, 13);
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(580, 43);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(160, 35);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;

            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 248, 240);
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(92, 49, 13);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(74, 44, 30);
            btnClear.Location = new Point(760, 43);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 35);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // 
            // btnDownloadPdf
            // 
            btnDownloadPdf.BackColor = Color.FromArgb(120, 40, 30);
            btnDownloadPdf.FlatAppearance.BorderSize = 0;
            btnDownloadPdf.FlatStyle = FlatStyle.Flat;
            btnDownloadPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDownloadPdf.ForeColor = Color.White;
            btnDownloadPdf.Location = new Point(895, 43);
            btnDownloadPdf.Name = "btnDownloadPdf";
            btnDownloadPdf.Size = new Size(150, 35);
            btnDownloadPdf.TabIndex = 4;
            btnDownloadPdf.Text = "Download PDF";
            btnDownloadPdf.UseVisualStyleBackColor = false;
            btnDownloadPdf.Click += btnDownloadPdf_Click;
            // 
            // panelReport
            // 
            panelReport.BackColor = Color.White;
            panelReport.BorderStyle = BorderStyle.FixedSingle;
            panelReport.Controls.Add(lblReportTitle);
            panelReport.Controls.Add(txtReport);
            panelReport.Location = new Point(55, 305);
            panelReport.Name = "panelReport";
            panelReport.Size = new Size(1050, 410);
            panelReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelReport.TabIndex = 3;

            // 
            // lblReportTitle
            // 
            lblReportTitle.AutoSize = true;
            lblReportTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblReportTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblReportTitle.Location = new Point(25, 20);
            lblReportTitle.Name = "lblReportTitle";
            lblReportTitle.Size = new Size(139, 25);
            lblReportTitle.TabIndex = 0;
            lblReportTitle.Text = "Hasil Laporan";

            // 
            // txtReport
            // 
            txtReport.BackColor = Color.White;
            txtReport.BorderStyle = BorderStyle.FixedSingle;
            txtReport.Font = new Font("Consolas", 10F);
            txtReport.Location = new Point(25, 60);
            txtReport.Multiline = true;
            txtReport.Name = "txtReport";
            txtReport.ReadOnly = true;
            txtReport.ScrollBars = ScrollBars.Both;
            txtReport.Size = new Size(1000, 320);
            txtReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtReport.TabIndex = 1;
            txtReport.WordWrap = false;

            // 
            // ReportControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelFilter);
            Controls.Add(panelReport);
            Name = "ReportControl";
            Size = new Size(1250, 740);
            Load += ReportControl_Load;

            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            panelReport.ResumeLayout(false);
            panelReport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;

        private Panel panelFilter;
        private Label lblJenisLaporan;
        private ComboBox cbJenisLaporan;
        private Button btnGenerate;
        private Button btnClear;
        private Button btnDownloadPdf;

        private Panel panelReport;
        private Label lblReportTitle;
        private TextBox txtReport;
    }
}