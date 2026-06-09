namespace Cocoalite.Views
{
    partial class KelolaQcControl : UserControl
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

            panelForm = new Panel();
            lblFullName = new Label();
            txtFullName = new TextBox();

            lblUsername = new Label();
            txtUsername = new TextBox();

            lblPassword = new Label();
            txtPassword = new TextBox();

            btnSave = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            panelTable = new Panel();
            lblTableTitle = new Label();
            dgvQcUsers = new DataGridView();

            panelForm.SuspendLayout();
            panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQcUsers).BeginInit();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(55, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Kelola QC";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(58, 88);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(470, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Tambah dan kelola akun Quality Controller CocoaLite.";

            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(lblFullName);
            panelForm.Controls.Add(txtFullName);
            panelForm.Controls.Add(lblUsername);
            panelForm.Controls.Add(txtUsername);
            panelForm.Controls.Add(lblPassword);
            panelForm.Controls.Add(txtPassword);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnClear);
            panelForm.Location = new Point(55, 135);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1050, 210);
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.TabIndex = 2;

            // 
            // lblFullName
            // 
            lblFullName.AutoSize = false;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(74, 44, 30);
            lblFullName.Location = new Point(45, 35);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(150, 27);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9F);
            txtFullName.Location = new Point(220, 35);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(310, 27);
            txtFullName.TabIndex = 1;

            // 
            // lblUsername
            // 
            lblUsername.AutoSize = false;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(74, 44, 30);
            lblUsername.Location = new Point(610, 35);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(150, 27);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.Location = new Point(790, 35);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(260, 27);
            txtUsername.TabIndex = 3;

            // 
            // lblPassword
            // 
            lblPassword.AutoSize = false;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(74, 44, 30);
            lblPassword.Location = new Point(45, 85);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(150, 27);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.Location = new Point(220, 85);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(310, 27);
            txtPassword.TabIndex = 5;

            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(92, 49, 13);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(220, 145);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(120, 40, 30);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(430, 145);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;

            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 248, 240);
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(92, 49, 13);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(74, 44, 30);
            btnClear.Location = new Point(640, 145);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 40);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // 
            // panelTable
            // 
            panelTable.BackColor = Color.White;
            panelTable.BorderStyle = BorderStyle.FixedSingle;
            panelTable.Controls.Add(lblTableTitle);
            panelTable.Controls.Add(dgvQcUsers);
            panelTable.Location = new Point(55, 385);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(1050, 330);
            panelTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTable.TabIndex = 3;

            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTableTitle.Location = new Point(25, 20);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(100, 25);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Daftar QC";

            // 
            // dgvQcUsers
            // 
            dgvQcUsers.BackgroundColor = Color.White;
            dgvQcUsers.BorderStyle = BorderStyle.None;
            dgvQcUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQcUsers.Location = new Point(25, 60);
            dgvQcUsers.Name = "dgvQcUsers";
            dgvQcUsers.RowHeadersVisible = false;
            dgvQcUsers.RowHeadersWidth = 51;
            dgvQcUsers.Size = new Size(1000, 245);
            dgvQcUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvQcUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQcUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQcUsers.MultiSelect = false;
            dgvQcUsers.ReadOnly = true;
            dgvQcUsers.AllowUserToAddRows = false;
            dgvQcUsers.AllowUserToDeleteRows = false;
            dgvQcUsers.TabIndex = 1;
            dgvQcUsers.CellClick += dgvQcUsers_CellClick;

            // 
            // KelolaQcControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelForm);
            Controls.Add(panelTable);
            Name = "KelolaQcControl";
            Size = new Size(1250, 740);
            Load += KelolaQcControl_Load;

            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelTable.ResumeLayout(false);
            panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQcUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;

        private Panel panelForm;
        private Label lblFullName;
        private TextBox txtFullName;

        private Label lblUsername;
        private TextBox txtUsername;

        private Label lblPassword;
        private TextBox txtPassword;

        private Button btnSave;
        private Button btnDelete;
        private Button btnClear;

        private Panel panelTable;
        private Label lblTableTitle;
        private DataGridView dgvQcUsers;
    }
}