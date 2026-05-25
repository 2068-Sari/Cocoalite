namespace Cocoalite.Views
{
    partial class FormQualityControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbReceiving = new ComboBox();
            txtMoisture = new TextBox();
            txtFermentation = new TextBox();
            txtDefect = new TextBox();
            cbBeanSize = new ComboBox();
            cbGrade = new ComboBox();
            cbQcStatus = new ComboBox();
            txtNotes = new TextBox();
            dtpInspectionDate = new DateTimePicker();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvQc = new DataGridView();
            lblReceiving = new Label();
            lblMoisture = new Label();
            lblFermentation = new Label();
            lblDefect = new Label();
            lblBeanSize = new Label();
            lblGrade = new Label();
            lblQcStatus = new Label();
            lblNotes = new Label();
            lblInspectionDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQc).BeginInit();
            SuspendLayout();
            // 
            // cbReceiving
            // 
            cbReceiving.FormattingEnabled = true;
            cbReceiving.Location = new Point(320, 36);
            cbReceiving.Name = "cbReceiving";
            cbReceiving.Size = new Size(237, 28);
            cbReceiving.TabIndex = 0;
            // 
            // txtMoisture
            // 
            txtMoisture.Location = new Point(320, 70);
            txtMoisture.Name = "txtMoisture";
            txtMoisture.Size = new Size(237, 27);
            txtMoisture.TabIndex = 1;
            // 
            // txtFermentation
            // 
            txtFermentation.Location = new Point(320, 103);
            txtFermentation.Name = "txtFermentation";
            txtFermentation.Size = new Size(237, 27);
            txtFermentation.TabIndex = 2;
            // 
            // txtDefect
            // 
            txtDefect.Location = new Point(320, 136);
            txtDefect.Name = "txtDefect";
            txtDefect.Size = new Size(237, 27);
            txtDefect.TabIndex = 3;
            // 
            // cbBeanSize
            // 
            cbBeanSize.FormattingEnabled = true;
            cbBeanSize.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            cbBeanSize.Location = new Point(320, 169);
            cbBeanSize.Name = "cbBeanSize";
            cbBeanSize.Size = new Size(237, 28);
            cbBeanSize.TabIndex = 4;
            // 
            // cbGrade
            // 
            cbGrade.FormattingEnabled = true;
            cbGrade.Items.AddRange(new object[] { "Grade A", "Grade B", "Grade C", "Reject" });
            cbGrade.Location = new Point(320, 203);
            cbGrade.Name = "cbGrade";
            cbGrade.Size = new Size(237, 28);
            cbGrade.TabIndex = 5;
            // 
            // cbQcStatus
            // 
            cbQcStatus.FormattingEnabled = true;
            cbQcStatus.Items.AddRange(new object[] { "Approved", "Rejected" });
            cbQcStatus.Location = new Point(320, 237);
            cbQcStatus.Name = "cbQcStatus";
            cbQcStatus.Size = new Size(237, 28);
            cbQcStatus.TabIndex = 6;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(320, 271);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(237, 27);
            txtNotes.TabIndex = 7;
            // 
            // dtpInspectionDate
            // 
            dtpInspectionDate.Location = new Point(320, 304);
            dtpInspectionDate.Name = "dtpInspectionDate";
            dtpInspectionDate.Size = new Size(237, 27);
            dtpInspectionDate.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(132, 364);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(248, 364);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(361, 364);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(479, 364);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvQc
            // 
            dgvQc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQc.Location = new Point(137, 399);
            dgvQc.Name = "dgvQc";
            dgvQc.RowHeadersWidth = 51;
            dgvQc.Size = new Size(746, 167);
            dgvQc.TabIndex = 13;
            dgvQc.CellClick += dgvQc_CellClick;
            // 
            // lblReceiving
            // 
            lblReceiving.AutoSize = true;
            lblReceiving.Location = new Point(137, 44);
            lblReceiving.Name = "lblReceiving";
            lblReceiving.Size = new Size(73, 20);
            lblReceiving.TabIndex = 14;
            lblReceiving.Text = "Receiving";
            // 
            // lblMoisture
            // 
            lblMoisture.AutoSize = true;
            lblMoisture.Location = new Point(137, 77);
            lblMoisture.Name = "lblMoisture";
            lblMoisture.Size = new Size(67, 20);
            lblMoisture.TabIndex = 15;
            lblMoisture.Text = "Moisture";
            // 
            // lblFermentation
            // 
            lblFermentation.AutoSize = true;
            lblFermentation.Location = new Point(137, 110);
            lblFermentation.Name = "lblFermentation";
            lblFermentation.Size = new Size(97, 20);
            lblFermentation.TabIndex = 16;
            lblFermentation.Text = "Fermentation";
            // 
            // lblDefect
            // 
            lblDefect.AutoSize = true;
            lblDefect.Location = new Point(137, 143);
            lblDefect.Name = "lblDefect";
            lblDefect.Size = new Size(53, 20);
            lblDefect.TabIndex = 17;
            lblDefect.Text = "Defect";
            lblDefect.Click += label4_Click;
            // 
            // lblBeanSize
            // 
            lblBeanSize.AutoSize = true;
            lblBeanSize.Location = new Point(137, 177);
            lblBeanSize.Name = "lblBeanSize";
            lblBeanSize.Size = new Size(73, 20);
            lblBeanSize.TabIndex = 18;
            lblBeanSize.Text = "Bean Size";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(137, 211);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(49, 20);
            lblGrade.TabIndex = 19;
            lblGrade.Text = "Grade";
            // 
            // lblQcStatus
            // 
            lblQcStatus.AutoSize = true;
            lblQcStatus.Location = new Point(137, 245);
            lblQcStatus.Name = "lblQcStatus";
            lblQcStatus.Size = new Size(73, 20);
            lblQcStatus.TabIndex = 20;
            lblQcStatus.Text = "QC Status";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(137, 278);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(48, 20);
            lblNotes.TabIndex = 21;
            lblNotes.Text = "Notes";
            // 
            // lblInspectionDate
            // 
            lblInspectionDate.AutoSize = true;
            lblInspectionDate.Location = new Point(137, 311);
            lblInspectionDate.Name = "lblInspectionDate";
            lblInspectionDate.Size = new Size(113, 20);
            lblInspectionDate.TabIndex = 22;
            lblInspectionDate.Text = "Inspection Date";
            // 
            // FormQualityControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 603);
            Controls.Add(lblInspectionDate);
            Controls.Add(lblNotes);
            Controls.Add(lblQcStatus);
            Controls.Add(lblGrade);
            Controls.Add(lblBeanSize);
            Controls.Add(lblDefect);
            Controls.Add(lblFermentation);
            Controls.Add(lblMoisture);
            Controls.Add(lblReceiving);
            Controls.Add(dgvQc);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dtpInspectionDate);
            Controls.Add(txtNotes);
            Controls.Add(cbQcStatus);
            Controls.Add(cbGrade);
            Controls.Add(cbBeanSize);
            Controls.Add(txtDefect);
            Controls.Add(txtFermentation);
            Controls.Add(txtMoisture);
            Controls.Add(cbReceiving);
            Name = "FormQualityControl";
            Text = "FormQualityControl";
            Load += FormQualityControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbReceiving;
        private TextBox txtMoisture;
        private TextBox txtFermentation;
        private TextBox txtDefect;
        private ComboBox cbBeanSize;
        private ComboBox cbGrade;
        private ComboBox cbQcStatus;
        private TextBox txtNotes;
        private DateTimePicker dtpInspectionDate;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvQc;
        private Label lblReceiving;
        private Label lblMoisture;
        private Label lblFermentation;
        private Label lblDefect;
        private Label lblBeanSize;
        private Label lblGrade;
        private Label lblQcStatus;
        private Label lblNotes;
        private Label lblInspectionDate;
    }
}