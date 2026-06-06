namespace Cocoalite.Views
{
    partial class DashboardControl : UserControl
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

            panelSupplier = new Panel();
            lblSupplierTitle = new Label();
            lblTotalSupplier = new Label();

            panelReceiving = new Panel();
            lblReceivingTitle = new Label();
            lblTotalReceiving = new Label();

            panelQc = new Panel();
            lblQcTitle = new Label();
            lblTotalQc = new Label();

            panelBatch = new Panel();
            lblBatchTitle = new Label();
            lblTotalBatch = new Label();

            panelStok = new Panel();
            lblStokTitle = new Label();
            lblTotalStok = new Label();

            panelShipment = new Panel();
            lblShipmentTitle = new Label();
            lblTotalShipment = new Label();

            SuspendLayout();

            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            Size = new Size(1250, 700);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelSupplier);
            Controls.Add(panelReceiving);
            Controls.Add(panelQc);
            Controls.Add(panelBatch);
            Controls.Add(panelStok);
            Controls.Add(panelShipment);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(120, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(344, 46);
            lblTitle.Text = "Dashboard Overview";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(123, 110);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(418, 23);
            lblSubtitle.Text = "Ringkasan data operasional sistem CocoaLite.";

            // Card Supplier
            CreateCard(panelSupplier, lblSupplierTitle, lblTotalSupplier,
                "Total Supplier", "0", 150, 175);

            CreateCard(panelReceiving, lblReceivingTitle, lblTotalReceiving,
                "Total Receiving", "0", 500, 175);

            CreateCard(panelQc, lblQcTitle, lblTotalQc,
                "Total QC", "0", 850, 175);

            CreateCard(panelBatch, lblBatchTitle, lblTotalBatch,
                "Total Batch", "0", 150, 350);

            CreateCard(panelStok, lblStokTitle, lblTotalStok,
                "Total Stok", "0 kg", 500, 350);

            CreateCard(panelShipment, lblShipmentTitle, lblTotalShipment,
                "Total Shipment", "0", 850, 350);

            ResumeLayout(false);
            PerformLayout();
        }

        private void CreateCard(
            Panel panel,
            Label title,
            Label value,
            string titleText,
            string valueText,
            int x,
            int y)
        {
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Location = new Point(x, y);
            panel.Name = "panel" + titleText.Replace(" ", "");
            panel.Size = new Size(330, 130);
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panel.TabIndex = 0;

            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(120, 86, 60);
            title.Location = new Point(25, 22);
            title.Name = "lbl" + titleText.Replace(" ", "") + "Title";
            title.Text = titleText;

            value.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            value.ForeColor = Color.FromArgb(74, 44, 30);
            value.Location = new Point(25, 62);
            value.Name = "lbl" + titleText.Replace(" ", "");
            value.Size = new Size(260, 52);
            value.Text = valueText;
            value.TextAlign = ContentAlignment.MiddleLeft;

            panel.Controls.Add(title);
            panel.Controls.Add(value);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;

        private Panel panelSupplier;
        private Label lblSupplierTitle;
        private Label lblTotalSupplier;

        private Panel panelReceiving;
        private Label lblReceivingTitle;
        private Label lblTotalReceiving;

        private Panel panelQc;
        private Label lblQcTitle;
        private Label lblTotalQc;

        private Panel panelBatch;
        private Label lblBatchTitle;
        private Label lblTotalBatch;

        private Panel panelStok;
        private Label lblStokTitle;
        private Label lblTotalStok;

        private Panel panelShipment;
        private Label lblShipmentTitle;
        private Label lblTotalShipment;
    }
}