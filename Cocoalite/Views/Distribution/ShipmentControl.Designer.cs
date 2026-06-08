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

            lblVehicleNumber = new Label();
            txtVehicleNumber = new TextBox();

            lblShipmentDate = new Label();
            dtpShipmentDate = new DateTimePicker();

            lblShipmentWeight = new Label();
            txtShipmentWeight = new TextBox();

            lblShipmentStatus = new Label();
            cbShipmentStatus = new ComboBox();

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
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(55, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manajemen Shipment";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(58, 88);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(512, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Kelola data pengiriman kakao dari batch menuju tujuan distribusi.";

            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.BorderStyle = BorderStyle.None;
            panelForm.Controls.Add(lblBatch);
            panelForm.Controls.Add(cbBatch);
            panelForm.Controls.Add(lblShipmentCode);
            panelForm.Controls.Add(txtShipmentCode);
            panelForm.Controls.Add(lblDestination);
            panelForm.Controls.Add(txtDestination);
            panelForm.Controls.Add(lblVehicleNumber);
            panelForm.Controls.Add(txtVehicleNumber);
            panelForm.Controls.Add(lblShipmentDate);
            panelForm.Controls.Add(dtpShipmentDate);
            panelForm.Controls.Add(lblShipmentWeight);
            panelForm.Controls.Add(txtShipmentWeight);
            panelForm.Controls.Add(lblShipmentStatus);
            panelForm.Controls.Add(cbShipmentStatus);
            panelForm.Controls.Add(lblDriverName);
            panelForm.Controls.Add(txtDriverName);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnUpdate);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnClear);
            panelForm.Location = new Point(55, 135);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1050, 285);
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.TabIndex = 2;

            // 
            // lblBatch
            // 
            lblBatch.AutoSize = false;
            lblBatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatch.ForeColor = Color.FromArgb(74, 44, 30);
            lblBatch.Location = new Point(45, 32);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new Size(150, 27);
            lblBatch.TabIndex = 0;
            lblBatch.Text = "Batch";
            lblBatch.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // cbBatch
            // 
            cbBatch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBatch.Font = new Font("Segoe UI", 9F);
            cbBatch.FormattingEnabled = true;
            cbBatch.Location = new Point(220, 32);
            cbBatch.Name = "cbBatch";
            cbBatch.Size = new Size(310, 28);
            cbBatch.TabIndex = 1;

            // 
            // lblShipmentCode
            // 
            lblShipmentCode.AutoSize = false;
            lblShipmentCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShipmentCode.ForeColor = Color.FromArgb(74, 44, 30);
            lblShipmentCode.Location = new Point(45, 75);
            lblShipmentCode.Name = "lblShipmentCode";
            lblShipmentCode.Size = new Size(150, 27);
            lblShipmentCode.TabIndex = 2;
            lblShipmentCode.Text = "Shipment Code";
            lblShipmentCode.TextAlign = ContentAlignment.MiddleLeft;


            lblShipmentCode.Visible = false;
            txtShipmentCode.Visible = false;
            // 
            // txtShipmentCode
            // 
            txtShipmentCode.Font = new Font("Segoe UI", 9F);
            txtShipmentCode.Location = new Point(220, 75);
            txtShipmentCode.Name = "txtShipmentCode";
            txtShipmentCode.Size = new Size(310, 27);
            txtShipmentCode.TabIndex = 3;

            // 
            // lblDestination
            // 
            lblDestination.AutoSize = false;
            lblDestination.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDestination.ForeColor = Color.FromArgb(74, 44, 30);
            lblDestination.Location = new Point(45, 78);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(150, 27);
            lblDestination.TabIndex = 4;
            lblDestination.Text = "Destination";
            lblDestination.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // txtDestination
            // 
            txtDestination.Font = new Font("Segoe UI", 9F);
            txtDestination.Location = new Point(220, 78);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(310, 27);
            txtDestination.TabIndex = 5;

            // 
            // lblVehicleNumber
            // 
            lblVehicleNumber.AutoSize = false;
            lblVehicleNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVehicleNumber.ForeColor = Color.FromArgb(74, 44, 30);
            lblVehicleNumber.Location = new Point(45, 121);
            lblVehicleNumber.Name = "lblVehicleNumber";
            lblVehicleNumber.Size = new Size(150, 27);
            lblVehicleNumber.TabIndex = 6;
            lblVehicleNumber.Text = "Vehicle Number";
            lblVehicleNumber.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // txtVehicleNumber
            // 
            txtVehicleNumber.Font = new Font("Segoe UI", 9F);
            txtVehicleNumber.Location = new Point(220, 121);
            txtVehicleNumber.Name = "txtVehicleNumber";
            txtVehicleNumber.Size = new Size(310, 27);
            txtVehicleNumber.TabIndex = 7;

            // 
            // lblShipmentDate
            // 
            lblShipmentDate.AutoSize = false;
            lblShipmentDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShipmentDate.ForeColor = Color.FromArgb(74, 44, 30);
            lblShipmentDate.Location = new Point(610, 32);
            lblShipmentDate.Name = "lblShipmentDate";
            lblShipmentDate.Size = new Size(150, 27);
            lblShipmentDate.TabIndex = 8;
            lblShipmentDate.Text = "Shipment Date";
            lblShipmentDate.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // dtpShipmentDate
            // 
            dtpShipmentDate.Font = new Font("Segoe UI", 9F);
            dtpShipmentDate.Format = DateTimePickerFormat.Short;
            dtpShipmentDate.Location = new Point(790, 32);
            dtpShipmentDate.Name = "dtpShipmentDate";
            dtpShipmentDate.Size = new Size(260, 27);
            dtpShipmentDate.TabIndex = 9;

            // 
            // lblShipmentWeight
            // 
            lblShipmentWeight.AutoSize = false;
            lblShipmentWeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShipmentWeight.ForeColor = Color.FromArgb(74, 44, 30);
            lblShipmentWeight.Location = new Point(610, 75);
            lblShipmentWeight.Name = "lblShipmentWeight";
            lblShipmentWeight.Size = new Size(160, 27);
            lblShipmentWeight.TabIndex = 10;
            lblShipmentWeight.Text = "Shipment Weight";
            lblShipmentWeight.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // txtShipmentWeight
            // 
            txtShipmentWeight.Font = new Font("Segoe UI", 9F);
            txtShipmentWeight.Location = new Point(790, 75);
            txtShipmentWeight.Name = "txtShipmentWeight";
            txtShipmentWeight.Size = new Size(260, 27);
            txtShipmentWeight.TabIndex = 11;

            // 
            // lblShipmentStatus
            // 
            lblShipmentStatus.AutoSize = false;
            lblShipmentStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShipmentStatus.ForeColor = Color.FromArgb(74, 44, 30);
            lblShipmentStatus.Location = new Point(610, 118);
            lblShipmentStatus.Name = "lblShipmentStatus";
            lblShipmentStatus.Size = new Size(160, 27);
            lblShipmentStatus.TabIndex = 12;
            lblShipmentStatus.Text = "Shipment Status";
            lblShipmentStatus.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // cbShipmentStatus
            // 
            cbShipmentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbShipmentStatus.Font = new Font("Segoe UI", 9F);
            cbShipmentStatus.FormattingEnabled = true;
            cbShipmentStatus.Location = new Point(790, 118);
            cbShipmentStatus.Name = "cbShipmentStatus";
            cbShipmentStatus.Size = new Size(260, 28);
            cbShipmentStatus.TabIndex = 13;

            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = false;
            lblDriverName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDriverName.ForeColor = Color.FromArgb(74, 44, 30);
            lblDriverName.Location = new Point(610, 161);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Size = new Size(150, 27);
            lblDriverName.TabIndex = 14;
            lblDriverName.Text = "Driver Name";
            lblDriverName.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // txtDriverName
            // 
            txtDriverName.Font = new Font("Segoe UI", 9F);
            txtDriverName.Location = new Point(790, 161);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(260, 27);
            txtDriverName.TabIndex = 15;

            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(92, 49, 13);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(220, 220);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 40);
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
            btnUpdate.Location = new Point(430, 220);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 40);
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
            btnDelete.Location = new Point(640, 220);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 40);
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
            btnClear.Location = new Point(850, 220);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 40);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // 
            // panelTable
            // 
            panelTable.BackColor = Color.White;
            panelTable.BorderStyle = BorderStyle.None;
            panelTable.Controls.Add(lblTableTitle);
            panelTable.Controls.Add(dgvShipment);
            panelTable.Location = new Point(55, 465);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(1050, 250);
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
            lblTableTitle.Size = new Size(160, 25);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Daftar Shipment";

            // 
            // dgvShipment
            // 
            dgvShipment.BackgroundColor = Color.White;
            dgvShipment.BorderStyle = BorderStyle.None;
            dgvShipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShipment.Location = new Point(25, 60);
            dgvShipment.Name = "dgvShipment";
            dgvShipment.RowHeadersVisible = false;
            dgvShipment.RowHeadersWidth = 51;
            dgvShipment.Size = new Size(1000, 165);
            dgvShipment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvShipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvShipment.ScrollBars = ScrollBars.Both;
            dgvShipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShipment.MultiSelect = false;
            dgvShipment.ReadOnly = true;
            dgvShipment.AllowUserToAddRows = false;
            dgvShipment.AllowUserToDeleteRows = false;
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
            Size = new Size(1250, 740);
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
        private Label lblVehicleNumber;
        private TextBox txtVehicleNumber;
        private Label lblShipmentDate;
        private DateTimePicker dtpShipmentDate;
        private Label lblShipmentWeight;
        private TextBox txtShipmentWeight;
        private Label lblShipmentStatus;
        private ComboBox cbShipmentStatus;
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