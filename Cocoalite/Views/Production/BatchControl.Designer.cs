namespace Cocoalite.Views
{
    partial class BatchControl : UserControl
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

            lblQc = new Label();
            cbQc = new ComboBox();

            lblBatchCode = new Label();
            txtBatchCode = new TextBox();

            lblBatchStatus = new Label();
            cbBatchStatus = new ComboBox();

            lblBatchDate = new Label();
            dtpBatchDate = new DateTimePicker();

            lblBatchWeight = new Label();
            txtBatchWeight = new TextBox();

            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            panelTable = new Panel();
            lblTableTitle = new Label();
            dgvBatch = new DataGridView();

            panelForm.SuspendLayout();
            panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatch).BeginInit();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(55, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(306, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manajemen Batch";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(58, 88);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(536, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Kelola batch kakao berdasarkan hasil Quality Control yang Approved.";

            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.BorderStyle = BorderStyle.None;
            panelForm.Controls.Add(lblQc);
            panelForm.Controls.Add(cbQc);
            panelForm.Controls.Add(lblBatchCode);
            panelForm.Controls.Add(txtBatchCode);
            panelForm.Controls.Add(lblBatchStatus);
            panelForm.Controls.Add(cbBatchStatus);
            panelForm.Controls.Add(lblBatchDate);
            panelForm.Controls.Add(dtpBatchDate);
            panelForm.Controls.Add(lblBatchWeight);
            panelForm.Controls.Add(txtBatchWeight);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnUpdate);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnClear);
            panelForm.Location = new Point(55, 135);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1050, 230);
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.TabIndex = 2;

            // 
            // lblQc
            // 
            lblQc.AutoSize = false;
            lblQc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQc.ForeColor = Color.FromArgb(74, 44, 30);
            lblQc.Location = new Point(45, 35);
            lblQc.Name = "lblQc";
            lblQc.Size = new Size(150, 27);
            lblQc.TabIndex = 0;
            lblQc.Text = "QC Approved";
            lblQc.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // cbQc
            // 
            cbQc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQc.Font = new Font("Segoe UI", 9F);
            cbQc.FormattingEnabled = true;
            cbQc.Location = new Point(220, 35);
            cbQc.Name = "cbQc";
            cbQc.Size = new Size(310, 28);
            cbQc.TabIndex = 1;

            // 
            // lblBatchCode
            // 
            lblBatchCode.AutoSize = false;
            lblBatchCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatchCode.ForeColor = Color.FromArgb(74, 44, 30);
            lblBatchCode.Location = new Point(45, 78);
            lblBatchCode.Name = "lblBatchCode";
            lblBatchCode.Size = new Size(150, 27);
            lblBatchCode.TabIndex = 2;
            lblBatchCode.Text = "Batch Code";
            lblBatchCode.TextAlign = ContentAlignment.MiddleLeft;


            lblBatchCode.Visible = false;
            txtBatchCode.Visible = false;
            // 
            // txtBatchCode
            // 
            txtBatchCode.Font = new Font("Segoe UI", 9F);
            txtBatchCode.Location = new Point(220, 78);
            txtBatchCode.Name = "txtBatchCode";
            txtBatchCode.Size = new Size(310, 27);
            txtBatchCode.TabIndex = 3;

            // 
            // lblBatchStatus
            // 
            lblBatchStatus.AutoSize = false;
            lblBatchStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatchStatus.ForeColor = Color.FromArgb(74, 44, 30);
            lblBatchStatus.Location = new Point(45, 78);
            lblBatchStatus.Name = "lblBatchStatus";
            lblBatchStatus.Size = new Size(150, 27);
            lblBatchStatus.TabIndex = 4;
            lblBatchStatus.Text = "Batch Status";
            lblBatchStatus.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // cbBatchStatus
            // 
            cbBatchStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBatchStatus.Font = new Font("Segoe UI", 9F);
            cbBatchStatus.FormattingEnabled = true;
            cbBatchStatus.Location = new Point(220, 78);
            cbBatchStatus.Name = "cbBatchStatus";
            cbBatchStatus.Size = new Size(310, 28);
            cbBatchStatus.TabIndex = 5;

            // 
            // lblBatchDate
            // 
            lblBatchDate.AutoSize = false;
            lblBatchDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatchDate.ForeColor = Color.FromArgb(74, 44, 30);
            lblBatchDate.Location = new Point(610, 35);
            lblBatchDate.Name = "lblBatchDate";
            lblBatchDate.Size = new Size(150, 27);
            lblBatchDate.TabIndex = 6;
            lblBatchDate.Text = "Batch Date";
            lblBatchDate.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // dtpBatchDate
            // 
            dtpBatchDate.Font = new Font("Segoe UI", 9F);
            dtpBatchDate.Format = DateTimePickerFormat.Short;
            dtpBatchDate.Location = new Point(790, 35);
            dtpBatchDate.Name = "dtpBatchDate";
            dtpBatchDate.Size = new Size(260, 27);
            dtpBatchDate.TabIndex = 7;

            // 
            // lblBatchWeight
            // 
            lblBatchWeight.AutoSize = false;
            lblBatchWeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatchWeight.ForeColor = Color.FromArgb(74, 44, 30);
            lblBatchWeight.Location = new Point(610, 78);
            lblBatchWeight.Name = "lblBatchWeight";
            lblBatchWeight.Size = new Size(150, 27);
            lblBatchWeight.TabIndex = 8;
            lblBatchWeight.Text = "Batch Weight";
            lblBatchWeight.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // txtBatchWeight
            // 
            txtBatchWeight.Font = new Font("Segoe UI", 9F);
            txtBatchWeight.Location = new Point(790, 78);
            txtBatchWeight.Name = "txtBatchWeight";
            txtBatchWeight.Size = new Size(260, 27);
            txtBatchWeight.TabIndex = 9;

            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(92, 49, 13);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(220, 170);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 40);
            btnSave.TabIndex = 10;
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
            btnUpdate.Location = new Point(430, 170);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 40);
            btnUpdate.TabIndex = 11;
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
            btnDelete.Location = new Point(640, 170);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 40);
            btnDelete.TabIndex = 12;
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
            btnClear.Location = new Point(850, 170);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 40);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // 
            // panelTable
            // 
            panelTable.BackColor = Color.White;
            panelTable.BorderStyle = BorderStyle.None;
            panelTable.Controls.Add(lblTableTitle);
            panelTable.Controls.Add(dgvBatch);
            panelTable.Location = new Point(55, 405);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(1050, 310);
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
            lblTableTitle.Size = new Size(112, 25);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Daftar Batch";

            // 
            // dgvBatch
            // 
            dgvBatch.BackgroundColor = Color.White;
            dgvBatch.BorderStyle = BorderStyle.None;
            dgvBatch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatch.Location = new Point(25, 60);
            dgvBatch.Name = "dgvBatch";
            dgvBatch.RowHeadersVisible = false;
            dgvBatch.RowHeadersWidth = 51;
            dgvBatch.Size = new Size(1000, 225);
            dgvBatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBatch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatch.MultiSelect = false;
            dgvBatch.ReadOnly = true;
            dgvBatch.AllowUserToAddRows = false;
            dgvBatch.AllowUserToDeleteRows = false;
            dgvBatch.TabIndex = 1;
            dgvBatch.CellClick += dgvBatch_CellClick;

            // 
            // BatchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelForm);
            Controls.Add(panelTable);
            Name = "BatchControl";
            Size = new Size(1250, 740);
            Load += BatchControl_Load;

            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelTable.ResumeLayout(false);
            panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;

        private Panel panelForm;
        private Label lblQc;
        private ComboBox cbQc;
        private Label lblBatchCode;
        private TextBox txtBatchCode;
        private Label lblBatchDate;
        private DateTimePicker dtpBatchDate;
        private Label lblBatchWeight;
        private TextBox txtBatchWeight;
        private Label lblBatchStatus;
        private ComboBox cbBatchStatus;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private Panel panelTable;
        private Label lblTableTitle;
        private DataGridView dgvBatch;
    }
}