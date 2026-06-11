namespace Cocoalite.Views
{
    partial class ForgotPasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUsername;
        private Label lblSecurityAnswer;
        private Label lblNewPassword;
        private Label lblConfirmPassword;

        private TextBox txtUsername;
        private TextBox txtSecurityAnswer;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;

        private CheckBox chkShowPassword;

        private Button btnResetPassword;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            lblSecurityAnswer = new Label();
            lblNewPassword = new Label();
            lblConfirmPassword = new Label();

            txtUsername = new TextBox();
            txtSecurityAnswer = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();

            chkShowPassword = new CheckBox();

            btnResetPassword = new Button();
            btnBack = new Button();

            SuspendLayout();

            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            ClientSize = new Size(500, 520);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);

            Controls.Add(lblUsername);
            Controls.Add(txtUsername);

            Controls.Add(lblSecurityAnswer);
            Controls.Add(txtSecurityAnswer);

            Controls.Add(lblNewPassword);
            Controls.Add(txtNewPassword);

            Controls.Add(lblConfirmPassword);
            Controls.Add(txtConfirmPassword);

            Controls.Add(chkShowPassword);

            Controls.Add(btnResetPassword);
            Controls.Add(btnBack);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lupa Password - CocoaLite";
            Load += ForgotPasswordForm_Load;

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(120, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(260, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Lupa Password";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 80, 55);
            lblSubtitle.Location = new Point(75, 88);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(350, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Masukkan data verifikasi untuk reset password";

            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(74, 44, 30);
            lblUsername.Location = new Point(70, 140);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";

            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(70, 168);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(360, 30);
            txtUsername.TabIndex = 3;

            // 
            // lblSecurityAnswer
            // 
            lblSecurityAnswer.AutoSize = true;
            lblSecurityAnswer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSecurityAnswer.ForeColor = Color.FromArgb(74, 44, 30);
            lblSecurityAnswer.Location = new Point(70, 215);
            lblSecurityAnswer.Name = "lblSecurityAnswer";
            lblSecurityAnswer.Size = new Size(157, 23);
            lblSecurityAnswer.TabIndex = 4;
            lblSecurityAnswer.Text = "Kode Pemulihan";

            // 
            // txtSecurityAnswer
            // 
            txtSecurityAnswer.Font = new Font("Segoe UI", 10F);
            txtSecurityAnswer.Location = new Point(70, 243);
            txtSecurityAnswer.Name = "txtSecurityAnswer";
            txtSecurityAnswer.Size = new Size(360, 30);
            txtSecurityAnswer.TabIndex = 5;

            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNewPassword.ForeColor = Color.FromArgb(74, 44, 30);
            lblNewPassword.Location = new Point(70, 290);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(126, 23);
            lblNewPassword.TabIndex = 6;
            lblNewPassword.Text = "Password Baru";

            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 10F);
            txtNewPassword.Location = new Point(70, 318);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(360, 30);
            txtNewPassword.TabIndex = 7;

            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(74, 44, 30);
            lblConfirmPassword.Location = new Point(70, 365);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(183, 23);
            lblConfirmPassword.TabIndex = 8;
            lblConfirmPassword.Text = "Konfirmasi Password";

            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(70, 393);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(360, 30);
            txtConfirmPassword.TabIndex = 9;

            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.ForeColor = Color.FromArgb(74, 44, 30);
            chkShowPassword.Location = new Point(70, 430);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(150, 24);
            chkShowPassword.TabIndex = 10;
            chkShowPassword.Text = "Tampilkan Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.FromArgb(92, 49, 13);
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(70, 465);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(170, 40);
            btnResetPassword.TabIndex = 11;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;

            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(170, 86, 37);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(260, 465);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(170, 40);
            btnBack.TabIndex = 12;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}