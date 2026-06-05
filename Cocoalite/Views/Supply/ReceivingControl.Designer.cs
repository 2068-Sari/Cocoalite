namespace Cocoalite.Views
{
    partial class ReceivingControl
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
            lblSupplier = new Label();
            cbSupplier = new ComboBox();
            lblReceivingCode = new Label();
            txtReceivingCode = new TextBox();
            lblReceivingDate = new Label();
            dtpReceivingDate = new DateTimePicker();
            lblCocoaWeight = new Label();
            txtCocoaWeight = new TextBox();
            lblVehicleNumber = new Label();
            txtVehicleNumber = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            panelTable = new Panel();
            lblTableTitle = new Label();
            dgvReceiving = new DataGridView();
            panelForm.SuspendLayout();
            panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReceiving).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(35, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(353, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Penerimaan Kakao";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(40, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(540, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Catat bahan baku kakao yang diterima dari supplier perusahaan.";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(lblSupplier);
            panelForm.Controls.Add(cbSupplier);
            panelForm.Controls.Add(lblReceivingCode);
            panelForm.Controls.Add(txtReceivingCode);
            panelForm.Controls.Add(lblReceivingDate);
            panelForm.Controls.Add(dtpReceivingDate);
            panelForm.Controls.Add(lblCocoaWeight);
            panelForm.Controls.Add(txtCocoaWeight);
            panelForm.Controls.Add(lblVehicleNumber);
            panelForm.Controls.Add(txtVehicleNumber);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnUpdate);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnClear);
            panelForm.Location = new Point(40, 120);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(780, 200);
            panelForm.TabIndex = 2;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSupplier.ForeColor = Color.FromArgb(74, 44, 30);
            lblSupplier.Location = new Point(25, 22);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(66, 20);
            lblSupplier.TabIndex = 0;
            lblSupplier.Text = "Supplier";
            // 
            // cbSupplier
            // 
            cbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(165, 19);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(220, 28);
            cbSupplier.TabIndex = 1;
            // 
            // lblReceivingCode
            // 
            lblReceivingCode.AutoSize = true;
            lblReceivingCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblReceivingCode.ForeColor = Color.FromArgb(74, 44, 30);
            lblReceivingCode.Location = new Point(25, 62);
            lblReceivingCode.Name = "lblReceivingCode";
            lblReceivingCode.Size = new Size(119, 20);
            lblReceivingCode.TabIndex = 2;
            lblReceivingCode.Text = "Receiving Code";
            // 
            // txtReceivingCode
            // 
            txtReceivingCode.Location = new Point(165, 59);
            txtReceivingCode.Name = "txtReceivingCode";
            txtReceivingCode.Size = new Size(220, 27);
            txtReceivingCode.TabIndex = 3;
            // 
            // lblReceivingDate
            // 
            lblReceivingDate.AutoSize = true;
            lblReceivingDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblReceivingDate.ForeColor = Color.FromArgb(74, 44, 30);
            lblReceivingDate.Location = new Point(420, 22);
            lblReceivingDate.Name = "lblReceivingDate";
            lblReceivingDate.Size = new Size(118, 20);
            lblReceivingDate.TabIndex = 4;
            lblReceivingDate.Text = "Receiving Date";
            // 
            // dtpReceivingDate
            // 
            dtpReceivingDate.Format = DateTimePickerFormat.Short;
            dtpReceivingDate.Location = new Point(550, 19);
            dtpReceivingDate.Name = "dtpReceivingDate";
            dtpReceivingDate.Size = new Size(190, 27);
            dtpReceivingDate.TabIndex = 5;
            // 
            // lblCocoaWeight
            // 
            lblCocoaWeight.AutoSize = true;
            lblCocoaWeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCocoaWeight.ForeColor = Color.FromArgb(74, 44, 30);
            lblCocoaWeight.Location = new Point(420, 62);
            lblCocoaWeight.Name = "lblCocoaWeight";
            lblCocoaWeight.Size = new Size(121, 20);
            lblCocoaWeight.TabIndex = 6;
            lblCocoaWeight.Text = "Cocoa Weight";
            // 
            // txtCocoaWeight
            // 
            txtCocoaWeight.Location = new Point(550, 59);
            txtCocoaWeight.Name = "txtCocoaWeight";
            txtCocoaWeight.Size = new Size(190, 27);
            txtCocoaWeight.TabIndex = 7;
            // 
            // lblVehicleNumber
            // 
            lblVehicleNumber.AutoSize = true;
            lblVehicleNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVehicleNumber.ForeColor = Color.FromArgb(74, 44, 30);
            lblVehicleNumber.Location = new Point(25, 102);
            lblVehicleNumber.Name = "lblVehicleNumber";
            lblVehicleNumber.Size = new Size(126, 20);
            lblVehicleNumber.TabIndex = 8;
            lblVehicleNumber.Text = "Vehicle Number";
            // 
            // txtVehicleNumber
            // 
            txtVehicleNumber.Location = new Point(165, 99);
            txtVehicleNumber.Name = "txtVehicleNumber";
            txtVehicleNumber.Size = new Size(220, 27);
            txtVehicleNumber.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(92, 49, 13);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(165, 145);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 35);
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
            btnUpdate.Location = new Point(305, 145);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 35);
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
            btnDelete.Location = new Point(445, 145);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
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
            btnClear.Location = new Point(585, 145);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 35);
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
            panelTable.Controls.Add(dgvReceiving);
            panelTable.Location = new Point(40, 340);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(780, 155);
            panelTable.TabIndex = 3;
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTableTitle.Location = new Point(20, 12);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(139, 23);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Daftar Receiving";
            // 
            // dgvReceiving
            // 
            dgvReceiving.BackgroundColor = Color.White;
            dgvReceiving.BorderStyle = BorderStyle.None;
            dgvReceiving.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceiving.Location = new Point(20, 42);
            dgvReceiving.Name = "dgvReceiving";
            dgvReceiving.RowHeadersWidth = 51;
            dgvReceiving.Size = new Size(735, 95);
            dgvReceiving.TabIndex = 1;
            dgvReceiving.CellClick += dgvReceiving_CellClick;
            // 
            // FormReceiving
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            ClientSize = new Size(860, 520);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelForm);
            Controls.Add(panelTable);
            Name = "FormReceiving";
            Text = "FormReceiving";
            Load += ReceivingControl_Load;
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelTable.ResumeLayout(false);
            panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReceiving).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelForm;
        private Label lblSupplier;
        private ComboBox cbSupplier;
        private Label lblReceivingCode;
        private TextBox txtReceivingCode;
        private Label lblReceivingDate;
        private DateTimePicker dtpReceivingDate;
        private Label lblCocoaWeight;
        private TextBox txtCocoaWeight;
        private Label lblVehicleNumber;
        private TextBox txtVehicleNumber;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Panel panelTable;
        private Label lblTableTitle;
        private DataGridView dgvReceiving;
    }
}