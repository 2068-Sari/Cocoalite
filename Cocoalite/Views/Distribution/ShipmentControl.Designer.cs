namespace Cocoalite.Views
{
    partial class ShipmentControl : UserControl
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
            lblBatch = new Label();
            cbBatch = new ComboBox();
            lblShipmentCode = new Label();
            txtShipmentCode = new TextBox();
            lblDestination = new Label();
            txtDestination = new TextBox();
            lblShipmentDate = new Label();
            dtpShipmentDate = new DateTimePicker();
            lblShipmentWeight = new Label();
            txtShipmentWeight = new TextBox();
            lblShipmentStatus = new Label();
            cbShipmentStatus = new ComboBox();
            lblVehicleNumber = new Label();
            txtVehicleNumber = new TextBox();
            lblDriverName = new Label();
            txtDriverName = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            panelTable = new Panel();
            lblTableTitle = new Label();
            dgvShipment = new DataGridView();
            panelForm.SuspendLayout();
            panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShipment).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(35, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(370, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manajemen Shipment";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(40, 64);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(512, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Kelola data pengiriman kakao dari batch menuju tujuan distribusi.";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(lblBatch);
            panelForm.Controls.Add(cbBatch);
            panelForm.Controls.Add(lblShipmentCode);
            panelForm.Controls.Add(txtShipmentCode);
            panelForm.Controls.Add(lblDestination);
            panelForm.Controls.Add(txtDestination);
            panelForm.Controls.Add(lblShipmentDate);
            panelForm.Controls.Add(dtpShipmentDate);
            panelForm.Controls.Add(lblShipmentWeight);
            panelForm.Controls.Add(txtShipmentWeight);
            panelForm.Controls.Add(lblShipmentStatus);
            panelForm.Controls.Add(cbShipmentStatus);
            panelForm.Controls.Add(lblVehicleNumber);
            panelForm.Controls.Add(txtVehicleNumber);
            panelForm.Controls.Add(lblDriverName);
            panelForm.Controls.Add(txtDriverName);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnUpdate);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnClear);
            panelForm.Location = new Point(40, 100);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(799, 229);
            panelForm.TabIndex = 2;
            // 
            // lblBatch
            // 
            lblBatch.AutoSize = true;
            lblBatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatch.ForeColor = Color.FromArgb(74, 44, 30);
            lblBatch.Location = new Point(25, 18);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new Size(49, 20);
            lblBatch.TabIndex = 0;
            lblBatch.Text = "Batch";
            // 
            // cbBatch
            // 
            cbBatch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBatch.FormattingEnabled = true;
            cbBatch.Location = new Point(170, 15);
            cbBatch.Name = "cbBatch";
            cbBatch.Size = new Size(220, 28);
            cbBatch.TabIndex = 1;
            // 
            // lblShipmentCode
            // 
            lblShipmentCode.AutoSize = true;
            lblShipmentCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShipmentCode.ForeColor = Color.FromArgb(74, 44, 30);
            lblShipmentCode.Location = new Point(25, 58);
            lblShipmentCode.Name = "lblShipmentCode";
            lblShipmentCode.Size = new Size(115, 20);
            lblShipmentCode.TabIndex = 2;
            lblShipmentCode.Text = "Shipment Code";
            // 
            // txtShipmentCode
            // 
            txtShipmentCode.Location = new Point(170, 55);
            txtShipmentCode.Name = "txtShipmentCode";
            txtShipmentCode.Size = new Size(220, 27);
            txtShipmentCode.TabIndex = 3;
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDestination.ForeColor = Color.FromArgb(74, 44, 30);
            lblDestination.Location = new Point(25, 98);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(90, 20);
            lblDestination.TabIndex = 4;
            lblDestination.Text = "Destination";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(170, 95);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(220, 27);
            txtDestination.TabIndex = 5;
            // 
            // lblShipmentDate
            // 
            lblShipmentDate.AutoSize = true;
            lblShipmentDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShipmentDate.ForeColor = Color.FromArgb(74, 44, 30);
            lblShipmentDate.Location = new Point(420, 18);
            lblShipmentDate.Name = "lblShipmentDate";
            lblShipmentDate.Size = new Size(113, 20);
            lblShipmentDate.TabIndex = 6;
            lblShipmentDate.Text = "Shipment Date";
            // 
            // dtpShipmentDate
            // 
            dtpShipmentDate.Format = DateTimePickerFormat.Short;
            dtpShipmentDate.Location = new Point(555, 15);
            dtpShipmentDate.Name = "dtpShipmentDate";
            dtpShipmentDate.Size = new Size(190, 27);
            dtpShipmentDate.TabIndex = 7;
            // 
            // lblShipmentWeight
            // 
            lblShipmentWeight.AutoSize = true;
            lblShipmentWeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShipmentWeight.ForeColor = Color.FromArgb(74, 44, 30);
            lblShipmentWeight.Location = new Point(420, 58);
            lblShipmentWeight.Name = "lblShipmentWeight";
            lblShipmentWeight.Size = new Size(131, 20);
            lblShipmentWeight.TabIndex = 8;
            lblShipmentWeight.Text = "Shipment Weight";
            // 
            // txtShipmentWeight
            // 
            txtShipmentWeight.Location = new Point(555, 55);
            txtShipmentWeight.Name = "txtShipmentWeight";
            txtShipmentWeight.Size = new Size(190, 27);
            txtShipmentWeight.TabIndex = 9;
            // 
            // lblShipmentStatus
            // 
            lblShipmentStatus.AutoSize = true;
            lblShipmentStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShipmentStatus.ForeColor = Color.FromArgb(74, 44, 30);
            lblShipmentStatus.Location = new Point(420, 98);
            lblShipmentStatus.Name = "lblShipmentStatus";
            lblShipmentStatus.Size = new Size(124, 20);
            lblShipmentStatus.TabIndex = 10;
            lblShipmentStatus.Text = "Shipment Status";
            // 
            // cbShipmentStatus
            // 
            cbShipmentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbShipmentStatus.FormattingEnabled = true;
            cbShipmentStatus.Location = new Point(555, 95);
            cbShipmentStatus.Name = "cbShipmentStatus";
            cbShipmentStatus.Size = new Size(190, 28);
            cbShipmentStatus.TabIndex = 11;
            // 
            // lblVehicleNumber
            // 
            lblVehicleNumber.AutoSize = true;
            lblVehicleNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVehicleNumber.ForeColor = Color.FromArgb(74, 44, 30);
            lblVehicleNumber.Location = new Point(25, 138);
            lblVehicleNumber.Name = "lblVehicleNumber";
            lblVehicleNumber.Size = new Size(120, 20);
            lblVehicleNumber.TabIndex = 12;
            lblVehicleNumber.Text = "Vehicle Number";
            // 
            // txtVehicleNumber
            // 
            txtVehicleNumber.Location = new Point(170, 135);
            txtVehicleNumber.Name = "txtVehicleNumber";
            txtVehicleNumber.Size = new Size(220, 27);
            txtVehicleNumber.TabIndex = 13;
            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = true;
            lblDriverName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDriverName.ForeColor = Color.FromArgb(74, 44, 30);
            lblDriverName.Location = new Point(420, 138);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Size = new Size(98, 20);
            lblDriverName.TabIndex = 14;
            lblDriverName.Text = "Driver Name";
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(555, 135);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(190, 27);
            txtDriverName.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(92, 49, 13);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(170, 190);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 35);
            btnSave.TabIndex = 16;
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
            btnUpdate.Location = new Point(310, 190);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 35);
            btnUpdate.TabIndex = 17;
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
            btnDelete.Location = new Point(450, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 18;
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
            btnClear.Location = new Point(590, 190);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 35);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panelTable
            // 
            panelTable.BackColor = Color.White;
            panelTable.BorderStyle = BorderStyle.FixedSingle;
            panelTable.Controls.Add(lblTableTitle);
            panelTable.Controls.Add(dgvShipment);
            panelTable.Location = new Point(40, 370);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(957, 293);
            panelTable.TabIndex = 3;
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTableTitle.Location = new Point(20, 10);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(145, 23);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Daftar Shipment";
            // 
            // dgvShipment
            // 
            dgvShipment.BackgroundColor = Color.White;
            dgvShipment.BorderStyle = BorderStyle.None;
            dgvShipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShipment.Location = new Point(10, 50);
            dgvShipment.Name = "dgvShipment";
            dgvShipment.RowHeadersWidth = 51;
            dgvShipment.Size = new Size(735, 70);
            dgvShipment.TabIndex = 1;
            dgvShipment.CellClick += dgvShipment_CellClick;
            // 
            // ShipmentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelForm);
            Controls.Add(panelTable);
            Name = "ShipmentControl";
            Size = new Size(1156, 694);
            Load += ShipmentControl_Load;
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelTable.ResumeLayout(false);
            panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShipment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelForm;
        private Label lblBatch;
        private ComboBox cbBatch;
        private Label lblShipmentCode;
        private TextBox txtShipmentCode;
        private Label lblDestination;
        private TextBox txtDestination;
        private Label lblShipmentDate;
        private DateTimePicker dtpShipmentDate;
        private Label lblShipmentWeight;
        private TextBox txtShipmentWeight;
        private Label lblShipmentStatus;
        private ComboBox cbShipmentStatus;
        private Label lblVehicleNumber;
        private TextBox txtVehicleNumber;
        private Label lblDriverName;
        private TextBox txtDriverName;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Panel panelTable;
        private Label lblTableTitle;
        private DataGridView dgvShipment;
    }
}