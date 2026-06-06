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
            lblBatchDate = new Label();
            dtpBatchDate = new DateTimePicker();
            lblBatchWeight = new Label();
            txtBatchWeight = new TextBox();
            lblBatchStatus = new Label();
            cbBatchStatus = new ComboBox();
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
            lblTitle.Location = new Point(55, 35);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(306, 46);
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
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(lblQc);
            panelForm.Controls.Add(cbQc);
            panelForm.Controls.Add(lblBatchCode);
            panelForm.Controls.Add(txtBatchCode);
            panelForm.Controls.Add(lblBatchDate);
            panelForm.Controls.Add(dtpBatchDate);
            panelForm.Controls.Add(lblBatchWeight);
            panelForm.Controls.Add(txtBatchWeight);
            panelForm.Controls.Add(lblBatchStatus);
            panelForm.Controls.Add(cbBatchStatus);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnUpdate);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnClear);
            panelForm.Location = new Point(55, 135);
            panelForm.Size = new Size(1050, 210);
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.BorderStyle = BorderStyle.None;
            panelForm.Name = "panelForm";
            panelForm.TabIndex = 2;
            // 
            // lblQc
            // 
            lblQc.AutoSize = true;
            lblQc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQc.ForeColor = Color.FromArgb(74, 44, 30);
            lblQc.Location = new Point(25, 22);
            lblQc.Name = "lblQc";
            lblQc.Size = new Size(102, 20);
            lblQc.TabIndex = 0;
            lblQc.Text = "QC Approved";
            // 
            // cbQc
            // 
            cbQc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQc.FormattingEnabled = true;
            cbQc.Location = new Point(160, 19);
            cbQc.Name = "cbQc";
            cbQc.Size = new Size(220, 28);
            cbQc.TabIndex = 1;
            // 
            // lblBatchCode
            // 
            lblBatchCode.AutoSize = true;
            lblBatchCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatchCode.ForeColor = Color.FromArgb(74, 44, 30);
            lblBatchCode.Location = new Point(25, 62);
            lblBatchCode.Name = "lblBatchCode";
            lblBatchCode.Size = new Size(88, 20);
            lblBatchCode.TabIndex = 2;
            lblBatchCode.Text = "Batch Code";
            // 
            // txtBatchCode
            // 
            txtBatchCode.Location = new Point(160, 59);
            txtBatchCode.Name = "txtBatchCode";
            txtBatchCode.Size = new Size(220, 27);
            txtBatchCode.TabIndex = 3;
            // 
            // lblBatchDate
            // 
            lblBatchDate.AutoSize = true;
            lblBatchDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatchDate.ForeColor = Color.FromArgb(74, 44, 30);
            lblBatchDate.Location = new Point(420, 22);
            lblBatchDate.Name = "lblBatchDate";
            lblBatchDate.Size = new Size(86, 20);
            lblBatchDate.TabIndex = 4;
            lblBatchDate.Text = "Batch Date";
            // 
            // dtpBatchDate
            // 
            dtpBatchDate.Format = DateTimePickerFormat.Short;
            dtpBatchDate.Location = new Point(550, 19);
            dtpBatchDate.Name = "dtpBatchDate";
            dtpBatchDate.Size = new Size(190, 27);
            dtpBatchDate.TabIndex = 5;
            // 
            // lblBatchWeight
            // 
            lblBatchWeight.AutoSize = true;
            lblBatchWeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatchWeight.ForeColor = Color.FromArgb(74, 44, 30);
            lblBatchWeight.Location = new Point(420, 62);
            lblBatchWeight.Name = "lblBatchWeight";
            lblBatchWeight.Size = new Size(104, 20);
            lblBatchWeight.TabIndex = 6;
            lblBatchWeight.Text = "Batch Weight";
            // 
            // txtBatchWeight
            // 
            txtBatchWeight.Location = new Point(550, 59);
            txtBatchWeight.Name = "txtBatchWeight";
            txtBatchWeight.Size = new Size(190, 27);
            txtBatchWeight.TabIndex = 7;
            // 
            // lblBatchStatus
            // 
            lblBatchStatus.AutoSize = true;
            lblBatchStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatchStatus.ForeColor = Color.FromArgb(74, 44, 30);
            lblBatchStatus.Location = new Point(25, 102);
            lblBatchStatus.Name = "lblBatchStatus";
            lblBatchStatus.Size = new Size(97, 20);
            lblBatchStatus.TabIndex = 8;
            lblBatchStatus.Text = "Batch Status";
            // 
            // cbBatchStatus
            // 
            cbBatchStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBatchStatus.FormattingEnabled = true;
            cbBatchStatus.Location = new Point(160, 99);
            cbBatchStatus.Name = "cbBatchStatus";
            cbBatchStatus.Size = new Size(220, 28);
            cbBatchStatus.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(92, 49, 13);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(175, 155);
            btnSave.Size = new Size(140, 40);
            btnSave.Name = "btnSave";
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
            btnUpdate.Location = new Point(390, 155);
            btnUpdate.Size = new Size(140, 40);
            btnUpdate.Name = "btnUpdate";
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
            btnDelete.Location = new Point(605, 155);
            btnDelete.Size = new Size(140, 40);
            btnDelete.Name = "btnDelete";
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
            btnClear.Location = new Point(820, 155);
            btnClear.Size = new Size(140, 40);
            btnClear.Name = "btnClear";
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panelTable
            // 
            panelTable.BackColor = Color.White;
            panelTable.BorderStyle = BorderStyle.FixedSingle;
            panelTable.Controls.Add(lblTableTitle);
            panelTable.Controls.Add(dgvBatch);
            panelTable.Location = new Point(55, 385);
            panelTable.Size = new Size(1050, 300);
            panelTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTable.BorderStyle = BorderStyle.None;
            panelTable.Name = "panelTable";
            panelTable.TabIndex = 3;
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTableTitle.Location = new Point(20, 12);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(112, 23);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Daftar Batch";
            // 
            // dgvBatch
            // 
            dgvBatch.BackgroundColor = Color.White;
            dgvBatch.BorderStyle = BorderStyle.None;
            dgvBatch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatch.Location = new Point(25, 60);
            dgvBatch.Size = new Size(1000, 215);
            dgvBatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBatch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatch.RowHeadersVisible = false;
            dgvBatch.Name = "dgvBatch";
            dgvBatch.RowHeadersWidth = 51;
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
            Size = new Size(1161, 690);
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