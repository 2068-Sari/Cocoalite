namespace Cocoalite.Views
{
    partial class ProfileControl
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelProfile = new Panel();
            lblFullName = new Label();
            lblFullNameValue = new Label();
            lblUsername = new Label();
            lblUsernameValue = new Label();
            lblRole = new Label();
            lblRoleValue = new Label();
            lblOldPassword = new Label();
            txtOldPassword = new TextBox();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnUpdatePassword = new Button();
            panelProfile.SuspendLayout();
            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(55, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Profile";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(58, 88);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(420, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Kelola informasi akun dan ubah password pengguna.";

            panelProfile.BackColor = Color.White;
            panelProfile.BorderStyle = BorderStyle.FixedSingle;
            panelProfile.Controls.Add(lblFullName);
            panelProfile.Controls.Add(lblFullNameValue);
            panelProfile.Controls.Add(lblUsername);
            panelProfile.Controls.Add(lblUsernameValue);
            panelProfile.Controls.Add(lblRole);
            panelProfile.Controls.Add(lblRoleValue);
            panelProfile.Controls.Add(lblOldPassword);
            panelProfile.Controls.Add(txtOldPassword);
            panelProfile.Controls.Add(lblNewPassword);
            panelProfile.Controls.Add(txtNewPassword);
            panelProfile.Controls.Add(lblConfirmPassword);
            panelProfile.Controls.Add(txtConfirmPassword);
            panelProfile.Controls.Add(btnUpdatePassword);
            panelProfile.Location = new Point(55, 135);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(700, 380);
            panelProfile.TabIndex = 2;

            lblFullName.AutoSize = false;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(74, 44, 30);
            lblFullName.Location = new Point(40, 35);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(150, 27);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;

            lblFullNameValue.AutoSize = false;
            lblFullNameValue.Font = new Font("Segoe UI", 9F);
            lblFullNameValue.ForeColor = Color.FromArgb(74, 44, 30);
            lblFullNameValue.Location = new Point(230, 35);
            lblFullNameValue.Name = "lblFullNameValue";
            lblFullNameValue.Size = new Size(380, 27);
            lblFullNameValue.TabIndex = 1;
            lblFullNameValue.Text = "-";
            lblFullNameValue.TextAlign = ContentAlignment.MiddleLeft;

            lblUsername.AutoSize = false;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(74, 44, 30);
            lblUsername.Location = new Point(40, 75);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(150, 27);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;

            lblUsernameValue.AutoSize = false;
            lblUsernameValue.Font = new Font("Segoe UI", 9F);
            lblUsernameValue.ForeColor = Color.FromArgb(74, 44, 30);
            lblUsernameValue.Location = new Point(230, 75);
            lblUsernameValue.Name = "lblUsernameValue";
            lblUsernameValue.Size = new Size(380, 27);
            lblUsernameValue.TabIndex = 3;
            lblUsernameValue.Text = "-";
            lblUsernameValue.TextAlign = ContentAlignment.MiddleLeft;

            lblRole.AutoSize = false;
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRole.ForeColor = Color.FromArgb(74, 44, 30);
            lblRole.Location = new Point(40, 115);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(150, 27);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role";
            lblRole.TextAlign = ContentAlignment.MiddleLeft;

            lblRoleValue.AutoSize = false;
            lblRoleValue.Font = new Font("Segoe UI", 9F);
            lblRoleValue.ForeColor = Color.FromArgb(74, 44, 30);
            lblRoleValue.Location = new Point(230, 115);
            lblRoleValue.Name = "lblRoleValue";
            lblRoleValue.Size = new Size(380, 27);
            lblRoleValue.TabIndex = 5;
            lblRoleValue.Text = "-";
            lblRoleValue.TextAlign = ContentAlignment.MiddleLeft;

            lblOldPassword.AutoSize = false;
            lblOldPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOldPassword.ForeColor = Color.FromArgb(74, 44, 30);
            lblOldPassword.Location = new Point(40, 170);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(170, 27);
            lblOldPassword.TabIndex = 6;
            lblOldPassword.Text = "Password Lama";
            lblOldPassword.TextAlign = ContentAlignment.MiddleLeft;

            txtOldPassword.Font = new Font("Segoe UI", 9F);
            txtOldPassword.Location = new Point(230, 170);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(330, 27);
            txtOldPassword.TabIndex = 7;

            lblNewPassword.AutoSize = false;
            lblNewPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNewPassword.ForeColor = Color.FromArgb(74, 44, 30);
            lblNewPassword.Location = new Point(40, 215);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(170, 27);
            lblNewPassword.TabIndex = 8;
            lblNewPassword.Text = "Password Baru";
            lblNewPassword.TextAlign = ContentAlignment.MiddleLeft;

            txtNewPassword.Font = new Font("Segoe UI", 9F);
            txtNewPassword.Location = new Point(230, 215);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(330, 27);
            txtNewPassword.TabIndex = 9;

            lblConfirmPassword.AutoSize = false;
            lblConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(74, 44, 30);
            lblConfirmPassword.Location = new Point(40, 260);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(180, 27);
            lblConfirmPassword.TabIndex = 10;
            lblConfirmPassword.Text = "Konfirmasi Password";
            lblConfirmPassword.TextAlign = ContentAlignment.MiddleLeft;

            txtConfirmPassword.Font = new Font("Segoe UI", 9F);
            txtConfirmPassword.Location = new Point(230, 260);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(330, 27);
            txtConfirmPassword.TabIndex = 11;

            btnUpdatePassword.BackColor = Color.FromArgb(92, 49, 13);
            btnUpdatePassword.FlatAppearance.BorderSize = 0;
            btnUpdatePassword.FlatStyle = FlatStyle.Flat;
            btnUpdatePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdatePassword.ForeColor = Color.White;
            btnUpdatePassword.Location = new Point(230, 315);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(180, 40);
            btnUpdatePassword.TabIndex = 12;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelProfile);
            Name = "ProfileControl";
            Size = new Size(1250, 740);
            Load += ProfileControl_Load;

            panelProfile.ResumeLayout(false);
            panelProfile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelProfile;
        private Label lblFullName;
        private Label lblFullNameValue;
        private Label lblUsername;
        private Label lblUsernameValue;
        private Label lblRole;
        private Label lblRoleValue;
        private Label lblOldPassword;
        private TextBox txtOldPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnUpdatePassword;
    }
}