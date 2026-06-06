namespace Cocoalite.Views
{
    partial class FormMain
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
            panelSidebar = new Panel();
            lblMenuTitle = new Label();
            lblMenuSubtitle = new Label();
            btnDashboard = new Button();
            btnSupplier = new Button();
            btnReceiving = new Button();
            btnQualityControl = new Button();
            btnBatch = new Button();
            btnInventory = new Button();
            btnShipment = new Button();
            btnActivityLog = new Button();
            btnLogout = new Button();
            panelHeader = new Panel();
            lblHeaderTitle = new Label();
            lblHeaderSubtitle = new Label();
            lblUserName = new Label();
            lblRole = new Label();
            panelContent = new Panel();
            panelWelcome = new Panel();
            lblWelcome = new Label();
            lblInstruction = new Label();
            panelSidebar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(92, 49, 13);
            panelSidebar.Controls.Add(lblMenuTitle);
            panelSidebar.Controls.Add(lblMenuSubtitle);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(btnSupplier);
            panelSidebar.Controls.Add(btnReceiving);
            panelSidebar.Controls.Add(btnQualityControl);
            panelSidebar.Controls.Add(btnBatch);
            panelSidebar.Controls.Add(btnInventory);
            panelSidebar.Controls.Add(btnShipment);
            panelSidebar.Controls.Add(btnActivityLog);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 700);
            panelSidebar.TabIndex = 0;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblMenuTitle.ForeColor = Color.White;
            lblMenuTitle.Location = new Point(35, 38);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Text = "CocoaLite";
            // 
            // lblMenuSubtitle
            // 
            lblMenuSubtitle.AutoSize = true;
            lblMenuSubtitle.Font = new Font("Segoe UI", 10F);
            lblMenuSubtitle.ForeColor = Color.FromArgb(255, 226, 198);
            lblMenuSubtitle.Location = new Point(38, 88);
            lblMenuSubtitle.Name = "lblMenuSubtitle";
            lblMenuSubtitle.Text = "Cacao Management";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(255, 248, 240);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.FromArgb(74, 44, 30);
            btnDashboard.Location = new Point(30, 130);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(180, 38);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = Color.FromArgb(255, 248, 240);
            btnSupplier.FlatAppearance.BorderSize = 0;
            btnSupplier.FlatStyle = FlatStyle.Flat;
            btnSupplier.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSupplier.ForeColor = Color.FromArgb(74, 44, 30);
            btnSupplier.Location = new Point(30, 178);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(180, 38);
            btnSupplier.TabIndex = 3;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = false;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // btnReceiving
            // 
            btnReceiving.BackColor = Color.FromArgb(255, 248, 240);
            btnReceiving.FlatAppearance.BorderSize = 0;
            btnReceiving.FlatStyle = FlatStyle.Flat;
            btnReceiving.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReceiving.ForeColor = Color.FromArgb(74, 44, 30);
            btnReceiving.Location = new Point(30, 226);
            btnReceiving.Name = "btnReceiving";
            btnReceiving.Size = new Size(180, 38);
            btnReceiving.TabIndex = 4;
            btnReceiving.Text = "Receiving";
            btnReceiving.UseVisualStyleBackColor = false;
            btnReceiving.Click += btnReceiving_Click;
            // 
            // btnQualityControl
            // 
            btnQualityControl.BackColor = Color.FromArgb(255, 248, 240);
            btnQualityControl.FlatAppearance.BorderSize = 0;
            btnQualityControl.FlatStyle = FlatStyle.Flat;
            btnQualityControl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQualityControl.ForeColor = Color.FromArgb(74, 44, 30);
            btnQualityControl.Location = new Point(30, 274);
            btnQualityControl.Name = "btnQualityControl";
            btnQualityControl.Size = new Size(180, 38);
            btnQualityControl.TabIndex = 5;
            btnQualityControl.Text = "Quality Control";
            btnQualityControl.UseVisualStyleBackColor = false;
            btnQualityControl.Click += btnQualityControl_Click;
            // 
            // btnBatch
            // 
            btnBatch.BackColor = Color.FromArgb(255, 248, 240);
            btnBatch.FlatAppearance.BorderSize = 0;
            btnBatch.FlatStyle = FlatStyle.Flat;
            btnBatch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBatch.ForeColor = Color.FromArgb(74, 44, 30);
            btnBatch.Location = new Point(30, 322);
            btnBatch.Name = "btnBatch";
            btnBatch.Size = new Size(180, 38);
            btnBatch.TabIndex = 6;
            btnBatch.Text = "Batch";
            btnBatch.UseVisualStyleBackColor = false;
            btnBatch.Click += btnBatch_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(255, 248, 240);
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInventory.ForeColor = Color.FromArgb(74, 44, 30);
            btnInventory.Location = new Point(30, 370);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(180, 38);
            btnInventory.TabIndex = 7;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnShipment
            // 
            btnShipment.BackColor = Color.FromArgb(255, 248, 240);
            btnShipment.FlatAppearance.BorderSize = 0;
            btnShipment.FlatStyle = FlatStyle.Flat;
            btnShipment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnShipment.ForeColor = Color.FromArgb(74, 44, 30);
            btnShipment.Location = new Point(30, 418);
            btnShipment.Name = "btnShipment";
            btnShipment.Size = new Size(180, 38);
            btnShipment.TabIndex = 8;
            btnShipment.Text = "Shipment";
            btnShipment.UseVisualStyleBackColor = false;
            btnShipment.Click += btnShipment_Click;
            // 
            // btnActivityLog
            // 
            btnActivityLog.BackColor = Color.FromArgb(255, 248, 240);
            btnActivityLog.FlatAppearance.BorderSize = 0;
            btnActivityLog.FlatStyle = FlatStyle.Flat;
            btnActivityLog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActivityLog.ForeColor = Color.FromArgb(74, 44, 30);
            btnActivityLog.Location = new Point(30, 466);
            btnActivityLog.Name = "btnActivityLog";
            btnActivityLog.Size = new Size(180, 38);
            btnActivityLog.TabIndex = 9;
            btnActivityLog.Text = "Activity Log";
            btnActivityLog.UseVisualStyleBackColor = false;
            btnActivityLog.Click += btnActivityLog_Click;
            // 
            // btnLogout
            // 
            btnLogout.Name = "btnLogout";
            btnLogout.Location = new Point(30, 575);
            btnLogout.Size = new Size(190, 40);
            btnLogout.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            btnLogout.BackColor = Color.FromArgb(180, 85, 35);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Text = "Logout";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(255, 248, 240);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Controls.Add(lblHeaderSubtitle);
            panelHeader.Controls.Add(lblUserName);
            panelHeader.Controls.Add(lblRole);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(250, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(850, 110);
            panelHeader.TabIndex = 1;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblHeaderTitle.Location = new Point(32, 24);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Text = "Sistem Informasi Manajemen Kakao";
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 10F);
            lblHeaderSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblHeaderSubtitle.Location = new Point(35, 68);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Text = "PT Cacao Prima Nusantara - CocoaLite App";
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUserName.ForeColor = Color.FromArgb(74, 44, 30);
            lblUserName.Location = new Point(560, 25);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(270, 25);
            lblUserName.Text = "User";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRole.Font = new Font("Segoe UI", 9F);
            lblRole.ForeColor = Color.FromArgb(120, 86, 60);
            lblRole.Location = new Point(560, 55);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(270, 25);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role: -";
            lblRole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(250, 246, 240);
            panelContent.Controls.Add(panelWelcome);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(250, 110);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(0);
            panelContent.Size = new Size(850, 510);
            panelContent.TabIndex = 2;
            // 
            // panelWelcome
            // 
            panelWelcome.BackColor = Color.White;
            panelWelcome.Controls.Add(lblWelcome);
            panelWelcome.Controls.Add(lblInstruction);
            panelWelcome.Location = new Point(35, 35);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(760, 150);
            panelWelcome.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(74, 44, 30);
            lblWelcome.Location = new Point(28, 28);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(408, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Selamat datang di CocoaLite";
            // 
            // lblInstruction
            // 
            lblInstruction.Font = new Font("Segoe UI", 10F);
            lblInstruction.ForeColor = Color.FromArgb(120, 86, 60);
            lblInstruction.Location = new Point(32, 80);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(680, 50);
            lblInstruction.TabIndex = 1;
            lblInstruction.Text = "Pilih menu pada sidebar untuk mengelola supplier, receiving, quality control, batch, inventory, shipment, dashboard, dan activity log.";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            ClientSize = new Size(1200, 700);
            MinimumSize = new Size(1200, 700);
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Name = "FormMain";
            Text = "CocoaLite";
            Load += FormMain_Load;


            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label lblMenuTitle;
        private Label lblMenuSubtitle;
        private Button btnDashboard;
        private Button btnSupplier;
        private Button btnReceiving;
        private Button btnQualityControl;
        private Button btnBatch;
        private Button btnInventory;
        private Button btnShipment;
        private Button btnActivityLog;
        private Button btnLogout;
        private Panel panelHeader;
        private Label lblHeaderTitle;
        private Label lblHeaderSubtitle;
        private Label lblUserName;
        private Label lblRole;
        private Panel panelContent;
        private Panel panelWelcome;
        private Label lblWelcome;
        private Label lblInstruction;
    }
}