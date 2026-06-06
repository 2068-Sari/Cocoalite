namespace Cocoalite.Views
{
    partial class SupplierControl
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

            panelForm = new Panel();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            panelTable = new Panel();
            lblTableTitle = new Label();
            dgv1 = new DataGridView();

            panelForm.SuspendLayout();
            panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(55, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(386, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manajemen Supplier";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(58, 88);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(525, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Kelola data pemasok kakao yang bekerja sama dengan perusahaan.";

            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(lblSupplierName);
            panelForm.Controls.Add(txtSupplierName);
            panelForm.Controls.Add(lblAddress);
            panelForm.Controls.Add(txtAddress);
            panelForm.Controls.Add(lblPhone);
            panelForm.Controls.Add(txtPhone);
            panelForm.Controls.Add(lblEmail);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnUpdate);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnClear);
            panelForm.Name = "panelForm";
            panelForm.Location = new Point(55, 135);
            panelForm.Size = new Size(1050, 180);
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.TabIndex = 2;

            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSupplierName.ForeColor = Color.FromArgb(74, 44, 30);
            lblSupplierName.Location = new Point(35, 35);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(112, 20);
            lblSupplierName.TabIndex = 0;
            lblSupplierName.Text = "Supplier Name";

            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 9F);
            txtSupplierName.Location = new Point(175, 32);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(300, 27);
            txtSupplierName.TabIndex = 1;

            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(74, 44, 30);
            lblAddress.Location = new Point(35, 75);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(66, 20);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";

            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9F);
            txtAddress.Location = new Point(175, 72);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 27);
            txtAddress.TabIndex = 3;

            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(74, 44, 30);
            lblPhone.Location = new Point(560, 35);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";

            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9F);
            txtPhone.Location = new Point(660, 32);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 27);
            txtPhone.TabIndex = 5;

            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(74, 44, 30);
            lblEmail.Location = new Point(560, 75);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";

            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(660, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 7;

            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(92, 49, 13);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(175, 120);
            btnSave.Size = new Size(140, 40);
            btnSave.Name = "btnSave";
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(165, 80, 35);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(390, 120);
            btnUpdate.Size = new Size(140, 40);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;

            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(120, 40, 30);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(605, 120);
            btnDelete.Size = new Size(140, 40);
            btnDelete.Name = "btnDelete";
            btnDelete.TabIndex = 10;
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
            btnClear.Location = new Point(820, 120);
            btnClear.Size = new Size(140, 40);
            btnClear.Name = "btnClear";
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // 
            // panelTable
            // 
            panelTable.BackColor = Color.White;
            panelTable.BorderStyle = BorderStyle.FixedSingle;
            panelTable.Controls.Add(lblTableTitle);
            panelTable.Controls.Add(dgv1);
            panelTable.Name = "panelTable";
            panelTable.Location = new Point(55, 365);
            panelTable.Size = new Size(1050, 300);
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
            lblTableTitle.Size = new Size(149, 25);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Daftar Supplier";

            // 
            // dgv1
            // 
            dgv1.BackgroundColor = Color.White;
            dgv1.BorderStyle = BorderStyle.None;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Name = "dgv1";
            dgv1.RowHeadersVisible = false;
            dgv1.RowHeadersWidth = 51;
            dgv1.Location = new Point(25, 60);
            dgv1.Size = new Size(1000, 235);
            dgv1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.MultiSelect = false;
            dgv1.ReadOnly = true;
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.TabIndex = 1;
            dgv1.CellClick += dgv1_CellClick;

            // 
            // SupplierControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelForm);
            Controls.Add(panelTable);
            Name = "SupplierControl";
            Size = new Size(1250, 700);
            Load += SupplierControl_Load;

            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelTable.ResumeLayout(false);
            panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;

        private Panel panelForm;
        private Label lblSupplierName;
        private TextBox txtSupplierName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private Panel panelTable;
        private Label lblTableTitle;
        private DataGridView dgv1;
    }
}