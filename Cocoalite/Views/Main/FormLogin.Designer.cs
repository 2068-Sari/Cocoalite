namespace Cocoalite.Views
{
    partial class FormLogin
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
            panelLeft = new Panel();
            lblAppName = new Label();
            lblAppSubtitle = new Label();
            lblDescription = new Label();
            lblCompany = new Label();
            panelLogin = new Panel();
            lblLoginTitle = new Label();
            lblLoginSubtitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            btnExit = new Button();
            lblFooter = new Label();
            panelLeft.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(92, 49, 13);
            panelLeft.Controls.Add(lblAppName);
            panelLeft.Controls.Add(lblAppSubtitle);
            panelLeft.Controls.Add(lblDescription);
            panelLeft.Controls.Add(lblCompany);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(360, 560);
            panelLeft.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(45, 95);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(249, 62);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "CocoaLite";
            // 
            // lblAppSubtitle
            // 
            lblAppSubtitle.AutoSize = true;
            lblAppSubtitle.Font = new Font("Segoe UI", 13F);
            lblAppSubtitle.ForeColor = Color.FromArgb(255, 226, 198);
            lblAppSubtitle.Location = new Point(52, 155);
            lblAppSubtitle.Name = "lblAppSubtitle";
            lblAppSubtitle.Size = new Size(206, 30);
            lblAppSubtitle.TabIndex = 1;
            lblAppSubtitle.Text = "Cacao Management";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(255, 240, 225);
            lblDescription.Location = new Point(52, 230);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(250, 100);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Sistem informasi untuk mengelola supplier, receiving, quality control, batch, inventory, dan shipment kakao.";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCompany.ForeColor = Color.White;
            lblCompany.Location = new Point(52, 475);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(219, 23);
            lblCompany.TabIndex = 3;
            lblCompany.Text = "PT Cacao Prima Nusantara";
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.Controls.Add(lblLoginTitle);
            panelLogin.Controls.Add(lblLoginSubtitle);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(chkShowPassword);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(btnExit);
            panelLogin.Controls.Add(lblFooter);
            panelLogin.Location = new Point(420, 70);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(420, 420);
            panelLogin.TabIndex = 1;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblLoginTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblLoginTitle.Location = new Point(35, 35);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(125, 50);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Login";
            // 
            // lblLoginSubtitle
            // 
            lblLoginSubtitle.AutoSize = true;
            lblLoginSubtitle.Font = new Font("Segoe UI", 10F);
            lblLoginSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblLoginSubtitle.Location = new Point(40, 85);
            lblLoginSubtitle.Name = "lblLoginSubtitle";
            lblLoginSubtitle.Size = new Size(285, 23);
            lblLoginSubtitle.TabIndex = 1;
            lblLoginSubtitle.Text = "Masuk untuk mengakses CocoaLite.";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(74, 44, 30);
            lblUsername.Location = new Point(40, 135);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(40, 160);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(335, 30);
            txtUsername.TabIndex = 3;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(74, 44, 30);
            lblPassword.Location = new Point(40, 205);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(40, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(335, 30);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.ForeColor = Color.FromArgb(74, 44, 30);
            chkShowPassword.Location = new Point(40, 270);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(137, 24);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(92, 49, 13);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 42);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 248, 240);
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(92, 49, 13);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(74, 44, 30);
            btnExit.Location = new Point(215, 315);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 42);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblFooter
            // 
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(120, 86, 60);
            lblFooter.Location = new Point(40, 375);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(335, 25);
            lblFooter.TabIndex = 9;
            lblFooter.Text = "Gunakan akun Admin atau Quality Controller.";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            ClientSize = new Size(900, 560);
            Controls.Add(panelLogin);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CocoaLite - Login";
            Load += FormLogin_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Label lblAppName;
        private Label lblAppSubtitle;
        private Label lblDescription;
        private Label lblCompany;
        private Panel panelLogin;
        private Label lblLoginTitle;
        private Label lblLoginSubtitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label lblFooter;
    }
}