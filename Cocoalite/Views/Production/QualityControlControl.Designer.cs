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
            cbBeanSize = new ComboBox();
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
            panelForm.BorderStyle = BorderStyle.None;
            panelForm.Controls.Add(lblReceiving);
            panelForm.Controls.Add(cbReceiving);
            panelForm.Controls.Add(lblMoisture);
            panelForm.Controls.Add(txtMoisture);
            panelForm.Controls.Add(lblFermentation);
            panelForm.Controls.Add(txtFermentation);
            panelForm.Controls.Add(lblDefect);
            panelForm.Controls.Add(txtDefect);
            panelForm.Controls.Add(lblBeanSize);
            panelForm.Controls.Add(cbBeanSize);
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
            panelForm.Size = new Size(1050, 285);
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.BorderStyle = BorderStyle.None;
            // lblReceiving
            lblReceiving.AutoSize = false;
            lblReceiving.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblReceiving.ForeColor = Color.FromArgb(74, 44, 30);
            lblReceiving.Location = new Point(45, 35);
            lblReceiving.Name = "lblReceiving";
            lblReceiving.Size = new Size(150, 27);
            lblReceiving.Text = "Receiving";
            lblReceiving.TextAlign = ContentAlignment.MiddleLeft;

            // cbReceiving
            cbReceiving.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReceiving.Font = new Font("Segoe UI", 9F);
            cbReceiving.Location = new Point(220, 35);
            cbReceiving.Size = new Size(310, 28);

            // lblMoisture
            lblMoisture.AutoSize = false;
            lblMoisture.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMoisture.ForeColor = Color.FromArgb(74, 44, 30);
            lblMoisture.Location = new Point(45, 78);
            lblMoisture.Size = new Size(150, 27);
            lblMoisture.Text = "Moisture %";
            lblMoisture.TextAlign = ContentAlignment.MiddleLeft;

            // txtMoisture
            txtMoisture.Font = new Font("Segoe UI", 9F);
            txtMoisture.Location = new Point(220, 78);
            txtMoisture.Size = new Size(310, 27);

            // lblFermentation
            lblFermentation.AutoSize = false;
            lblFermentation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFermentation.ForeColor = Color.FromArgb(74, 44, 30);
            lblFermentation.Location = new Point(45, 121);
            lblFermentation.Size = new Size(150, 27);
            lblFermentation.Text = "Fermentation %";
            lblFermentation.TextAlign = ContentAlignment.MiddleLeft;

            // txtFermentation
            txtFermentation.Font = new Font("Segoe UI", 9F);
            txtFermentation.Location = new Point(220, 121);
            txtFermentation.Size = new Size(310, 27);

            // lblDefect
            lblDefect.AutoSize = false;
            lblDefect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDefect.ForeColor = Color.FromArgb(74, 44, 30);
            lblDefect.Location = new Point(45, 164);
            lblDefect.Size = new Size(150, 27);
            lblDefect.Text = "Defect %";
            lblDefect.TextAlign = ContentAlignment.MiddleLeft;

            // txtDefect
            txtDefect.Font = new Font("Segoe UI", 9F);
            txtDefect.Location = new Point(220, 164);
            txtDefect.Size = new Size(310, 27);

            // lblNotes
            lblNotes.AutoSize = false;
            lblNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotes.ForeColor = Color.FromArgb(74, 44, 30);
            lblNotes.Location = new Point(45, 207);
            lblNotes.Size = new Size(150, 27);
            lblNotes.Text = "Notes";
            lblNotes.TextAlign = ContentAlignment.MiddleLeft;

            // txtNotes
            txtNotes.Font = new Font("Segoe UI", 9F);
            txtNotes.Location = new Point(220, 207);
            txtNotes.Size = new Size(310, 27);

            // lblBeanSize
            lblBeanSize.AutoSize = false;
            lblBeanSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBeanSize.ForeColor = Color.FromArgb(74, 44, 30);
            lblBeanSize.Location = new Point(610, 35);
            lblBeanSize.Size = new Size(150, 27);
            lblBeanSize.Text = "Bean Size";
            lblBeanSize.TextAlign = ContentAlignment.MiddleLeft;

            // cbBeanSize
            cbBeanSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBeanSize.Font = new Font("Segoe UI", 9F);
            cbBeanSize.FormattingEnabled = true;
            cbBeanSize.Items.AddRange(new object[]
            {
                 "Small",
                 "Medium",
                 "Large"
            });
            cbBeanSize.Location = new Point(790, 35);
            cbBeanSize.Name = "cbBeanSize";
            cbBeanSize.Size = new Size(260, 28);
            cbBeanSize.TabIndex = 10;

            // lblGrade
            lblGrade.AutoSize = false;
            lblGrade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGrade.ForeColor = Color.FromArgb(74, 44, 30);
            lblGrade.Location = new Point(610, 78);
            lblGrade.Size = new Size(150, 27);
            lblGrade.Text = "Grade";
            lblGrade.TextAlign = ContentAlignment.MiddleLeft;

            // txtGrade
            txtGrade.Font = new Font("Segoe UI", 9F);
            txtGrade.Location = new Point(790, 78);
            txtGrade.Name = "txtGrade";
            txtGrade.ReadOnly = true;
            txtGrade.Size = new Size(155, 27);
            txtGrade.TabIndex = 12;

            // btnDetermineGrade
            btnDetermineGrade.BackColor = Color.FromArgb(92, 49, 13);
            btnDetermineGrade.FlatAppearance.BorderSize = 0;
            btnDetermineGrade.FlatStyle = FlatStyle.Flat;
            btnDetermineGrade.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDetermineGrade.ForeColor = Color.White;
            btnDetermineGrade.Location = new Point(960, 78);
            btnDetermineGrade.Name = "btnDetermineGrade";
            btnDetermineGrade.Size = new Size(90, 27);
            btnDetermineGrade.TabIndex = 13;
            btnDetermineGrade.Text = "Grade";
            btnDetermineGrade.UseVisualStyleBackColor = false;
            btnDetermineGrade.Click += btnDetermineGrade_Click;

            // lblQcStatus
            lblQcStatus.AutoSize = false;
            lblQcStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQcStatus.ForeColor = Color.FromArgb(74, 44, 30);
            lblQcStatus.Location = new Point(610, 121);
            lblQcStatus.Size = new Size(150, 27);
            lblQcStatus.Text = "QC Status";
            lblQcStatus.TextAlign = ContentAlignment.MiddleLeft;

            // cbQcStatus
            cbQcStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQcStatus.Font = new Font("Segoe UI", 9F);
            cbQcStatus.FormattingEnabled = true;
            cbQcStatus.Items.AddRange(new object[]
            {
                "Approved",
                "Rejected"
            });
            cbQcStatus.Location = new Point(790, 121);
            cbQcStatus.Name = "cbQcStatus";
            cbQcStatus.Size = new Size(260, 28);
            cbQcStatus.TabIndex = 15;

            // lblInspectionDate
            lblInspectionDate.AutoSize = false;
            lblInspectionDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInspectionDate.ForeColor = Color.FromArgb(74, 44, 30);
            lblInspectionDate.Location = new Point(610, 164);
            lblInspectionDate.Size = new Size(150, 27);
            lblInspectionDate.Text = "Inspection Date";
            lblInspectionDate.TextAlign = ContentAlignment.MiddleLeft;

            // dtpInspectionDate
            dtpInspectionDate.Font = new Font("Segoe UI", 9F);
            dtpInspectionDate.Format = DateTimePickerFormat.Short;
            dtpInspectionDate.Location = new Point(790, 164);
            dtpInspectionDate.Size = new Size(260, 27);

            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(92, 49, 13);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(220, 245);
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
            btnUpdate.Location = new Point(430, 245);
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
            btnDelete.Location = new Point(640, 245);
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
            btnClear.Location = new Point(850, 245);
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
            panelTable.BorderStyle = BorderStyle.None;
            panelTable.Controls.Add(lblTableTitle);
            panelTable.Controls.Add(dgvQualityControl);
            panelTable.Location = new Point(55, 465);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(1050, 270);
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
            lblTableTitle.Size = new Size(220, 25);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Daftar Quality Control";

            // 
            // dgvQualityControl
            // 
            dgvQualityControl.BackgroundColor = Color.White;
            dgvQualityControl.BorderStyle = BorderStyle.None;
            dgvQualityControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQualityControl.Location = new Point(25, 60);
            dgvQualityControl.Name = "dgvQualityControl";
            dgvQualityControl.RowHeadersVisible = false;
            dgvQualityControl.RowHeadersWidth = 51;
            dgvQualityControl.Size = new Size(1000, 185);
            dgvQualityControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvQualityControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQualityControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQualityControl.MultiSelect = false;
            dgvQualityControl.ReadOnly = true;
            dgvQualityControl.AllowUserToAddRows = false;
            dgvQualityControl.AllowUserToDeleteRows = false;
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
        private ComboBox cbBeanSize;
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