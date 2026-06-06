namespace Cocoalite.Views
{
    partial class QualityControlControl
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
            lblReceiving = new Label();
            cbReceiving = new ComboBox();
            lblMoisture = new Label();
            txtMoisture = new TextBox();
            lblFermentation = new Label();
            txtFermentation = new TextBox();
            lblDefect = new Label();
            txtDefect = new TextBox();
            lblBeanSize = new Label();
            txtBeanSize = new TextBox();
            lblGrade = new Label();
            txtGrade = new TextBox();
            btnDetermineGrade = new Button();
            lblQcStatus = new Label();
            cbQcStatus = new ComboBox();
            lblInspectionDate = new Label();
            dtpInspectionDate = new DateTimePicker();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            panelTable = new Panel();
            lblTableTitle = new Label();
            dgvQualityControl = new DataGridView();
            panelForm.SuspendLayout();
            panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQualityControl).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.Location = new Point(55, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(266, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quality Control";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(58, 88);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(588, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Pemeriksaan kualitas kakao berdasarkan moisture, fermentation, dan defect.";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(lblReceiving);
            panelForm.Controls.Add(cbReceiving);
            panelForm.Controls.Add(lblMoisture);
            panelForm.Controls.Add(txtMoisture);
            panelForm.Controls.Add(lblFermentation);
            panelForm.Controls.Add(txtFermentation);
            panelForm.Controls.Add(lblDefect);
            panelForm.Controls.Add(txtDefect);
            panelForm.Controls.Add(lblBeanSize);
            panelForm.Controls.Add(txtBeanSize);
            panelForm.Controls.Add(lblGrade);
            panelForm.Controls.Add(txtGrade);
            panelForm.Controls.Add(btnDetermineGrade);
            panelForm.Controls.Add(lblQcStatus);
            panelForm.Controls.Add(cbQcStatus);
            panelForm.Controls.Add(lblInspectionDate);
            panelForm.Controls.Add(dtpInspectionDate);
            panelForm.Controls.Add(lblNotes);
            panelForm.Controls.Add(txtNotes);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnUpdate);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnClear);
            panelForm.Name = "panelForm";
            panelForm.Location = new Point(55, 135);
            panelForm.Size = new Size(1050, 260);
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.BorderStyle = BorderStyle.None;
            // 
            // lblReceiving
            // 
            lblReceiving.AutoSize = true;
            lblReceiving.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblReceiving.ForeColor = Color.FromArgb(74, 44, 30);
            lblReceiving.Location = new Point(20, 18);
            lblReceiving.Name = "lblReceiving";
            lblReceiving.Size = new Size(76, 20);
            lblReceiving.TabIndex = 0;
            lblReceiving.Text = "Receiving";
            // 
            // cbReceiving
            // 
            cbReceiving.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReceiving.FormattingEnabled = true;
            cbReceiving.Location = new Point(150, 15);
            cbReceiving.Name = "cbReceiving";
            cbReceiving.Size = new Size(220, 28);
            cbReceiving.TabIndex = 1;
            // 
            // lblMoisture
            // 
            lblMoisture.AutoSize = true;
            lblMoisture.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMoisture.ForeColor = Color.FromArgb(74, 44, 30);
            lblMoisture.Location = new Point(20, 58);
            lblMoisture.Name = "lblMoisture";
            lblMoisture.Size = new Size(89, 20);
            lblMoisture.TabIndex = 2;
            lblMoisture.Text = "Moisture %";
            // 
            // txtMoisture
            // 
            txtMoisture.Location = new Point(150, 55);
            txtMoisture.Name = "txtMoisture";
            txtMoisture.Size = new Size(220, 27);
            txtMoisture.TabIndex = 3;
            // 
            // lblFermentation
            // 
            lblFermentation.AutoSize = true;
            lblFermentation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFermentation.ForeColor = Color.FromArgb(74, 44, 30);
            lblFermentation.Location = new Point(20, 98);
            lblFermentation.Name = "lblFermentation";
            lblFermentation.Size = new Size(121, 20);
            lblFermentation.TabIndex = 4;
            lblFermentation.Text = "Fermentation %";
            // 
            // txtFermentation
            // 
            txtFermentation.Location = new Point(150, 95);
            txtFermentation.Name = "txtFermentation";
            txtFermentation.Size = new Size(220, 27);
            txtFermentation.TabIndex = 5;
            // 
            // lblDefect
            // 
            lblDefect.AutoSize = true;
            lblDefect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDefect.ForeColor = Color.FromArgb(74, 44, 30);
            lblDefect.Location = new Point(20, 138);
            lblDefect.Name = "lblDefect";
            lblDefect.Size = new Size(72, 20);
            lblDefect.TabIndex = 6;
            lblDefect.Text = "Defect %";
            // 
            // txtDefect
            // 
            txtDefect.Location = new Point(150, 135);
            txtDefect.Name = "txtDefect";
            txtDefect.Size = new Size(220, 27);
            txtDefect.TabIndex = 7;
            // 
            // lblBeanSize
            // 
            lblBeanSize.AutoSize = true;
            lblBeanSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBeanSize.ForeColor = Color.FromArgb(74, 44, 30);
            lblBeanSize.Location = new Point(405, 18);
            lblBeanSize.Name = "lblBeanSize";
            lblBeanSize.Size = new Size(75, 20);
            lblBeanSize.TabIndex = 8;
            lblBeanSize.Text = "Bean Size";
            // 
            // txtBeanSize
            // 
            txtBeanSize.Location = new Point(535, 15);
            txtBeanSize.Name = "txtBeanSize";
            txtBeanSize.Size = new Size(205, 27);
            txtBeanSize.TabIndex = 9;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGrade.ForeColor = Color.FromArgb(74, 44, 30);
            lblGrade.Location = new Point(405, 58);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(51, 20);
            lblGrade.TabIndex = 10;
            lblGrade.Text = "Grade";
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(535, 55);
            txtGrade.Name = "txtGrade";
            txtGrade.ReadOnly = true;
            txtGrade.Size = new Size(120, 27);
            txtGrade.TabIndex = 11;
            // 
            // btnDetermineGrade
            // 
            btnDetermineGrade.BackColor = Color.FromArgb(92, 49, 13);
            btnDetermineGrade.FlatAppearance.BorderSize = 0;
            btnDetermineGrade.FlatStyle = FlatStyle.Flat;
            btnDetermineGrade.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDetermineGrade.ForeColor = Color.White;
            btnDetermineGrade.Location = new Point(665, 55);
            btnDetermineGrade.Name = "btnDetermineGrade";
            btnDetermineGrade.Size = new Size(75, 28);
            btnDetermineGrade.TabIndex = 12;
            btnDetermineGrade.Text = "Grade";
            btnDetermineGrade.UseVisualStyleBackColor = false;
            btnDetermineGrade.Click += btnDetermineGrade_Click;
            // 
            // lblQcStatus
            // 
            lblQcStatus.AutoSize = true;
            lblQcStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQcStatus.ForeColor = Color.FromArgb(74, 44, 30);
            lblQcStatus.Location = new Point(405, 98);
            lblQcStatus.Name = "lblQcStatus";
            lblQcStatus.Size = new Size(77, 20);
            lblQcStatus.TabIndex = 13;
            lblQcStatus.Text = "QC Status";
            // 
            // cbQcStatus
            // 
            cbQcStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQcStatus.FormattingEnabled = true;
            cbQcStatus.Location = new Point(535, 95);
            cbQcStatus.Name = "cbQcStatus";
            cbQcStatus.Size = new Size(205, 28);
            cbQcStatus.TabIndex = 14;
            // 
            // lblInspectionDate
            // 
            lblInspectionDate.AutoSize = true;
            lblInspectionDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInspectionDate.ForeColor = Color.FromArgb(74, 44, 30);
            lblInspectionDate.Location = new Point(405, 138);
            lblInspectionDate.Name = "lblInspectionDate";
            lblInspectionDate.Size = new Size(119, 20);
            lblInspectionDate.TabIndex = 15;
            lblInspectionDate.Text = "Inspection Date";
            // 
            // dtpInspectionDate
            // 
            dtpInspectionDate.Format = DateTimePickerFormat.Short;
            dtpInspectionDate.Location = new Point(535, 135);
            dtpInspectionDate.Name = "dtpInspectionDate";
            dtpInspectionDate.Size = new Size(205, 27);
            dtpInspectionDate.TabIndex = 16;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotes.ForeColor = Color.FromArgb(74, 44, 30);
            lblNotes.Location = new Point(20, 178);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(51, 20);
            lblNotes.TabIndex = 17;
            lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(150, 175);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(590, 27);
            txtNotes.TabIndex = 18;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(92, 49, 13);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(175, 205);
            btnSave.Size = new Size(140, 40);
            btnSave.Name = "btnSave";
            btnSave.TabIndex = 19;
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
            btnUpdate.Location = new Point(390, 205);
            btnUpdate.Size = new Size(140, 40);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.TabIndex = 20;
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
            btnDelete.Location = new Point(605, 205);
            btnDelete.Size = new Size(140, 40);
            btnDelete.Name = "btnDelete";
            btnDelete.TabIndex = 21;
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
            btnClear.Location = new Point(820, 205);
            btnClear.Size = new Size(140, 40);
            btnClear.Name = "btnClear";
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panelTable
            // 
            panelTable.BackColor = Color.White;
            panelTable.BorderStyle = BorderStyle.FixedSingle;
            panelTable.Controls.Add(lblTableTitle);
            panelTable.Controls.Add(dgvQualityControl);
            panelTable.Location = new Point(40, 370);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(780, 125);
            panelTable.TabIndex = 3;
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(74, 44, 30);
            panelTable.Location = new Point(55, 435);
            panelTable.Size = new Size(1050, 250);
            panelTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTable.BorderStyle = BorderStyle.None;
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Daftar Quality Control";
            // 
            // dgvQualityControl
            // 
            dgvQualityControl.BackgroundColor = Color.White;
            dgvQualityControl.BorderStyle = BorderStyle.None;
            dgvQualityControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQualityControl.Location = new Point(25, 60);
            dgvQualityControl.Size = new Size(1000, 165);
            dgvQualityControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvQualityControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQualityControl.RowHeadersVisible = false;
            dgvQualityControl.Name = "dgvQualityControl";
            dgvQualityControl.RowHeadersWidth = 51;
            dgvQualityControl.TabIndex = 1;
            dgvQualityControl.CellClick += dgvQualityControl_CellClick;
            // 
            // QualityControlControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelForm);
            Controls.Add(panelTable);
            Name = "QualityControlControl";
            Size = new Size(1154, 705);
            Load += QualityControlControl_Load;
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelTable.ResumeLayout(false);
            panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQualityControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelForm;
        private Label lblReceiving;
        private ComboBox cbReceiving;
        private Label lblMoisture;
        private TextBox txtMoisture;
        private Label lblFermentation;
        private TextBox txtFermentation;
        private Label lblDefect;
        private TextBox txtDefect;
        private Label lblBeanSize;
        private TextBox txtBeanSize;
        private Label lblGrade;
        private TextBox txtGrade;
        private Button btnDetermineGrade;
        private Label lblQcStatus;
        private ComboBox cbQcStatus;
        private Label lblInspectionDate;
        private DateTimePicker dtpInspectionDate;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Panel panelTable;
        private Label lblTableTitle;
        private DataGridView dgvQualityControl;
    }
}