namespace Cocoalite.Views
{
    partial class FormShipment
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
            txtShipmentCode = new TextBox();
            txtDestination = new TextBox();
            txtDriverName = new TextBox();
            txtShipmentWeight = new TextBox();
            txtVehicleNumber = new TextBox();
            cbBatch = new ComboBox();
            cbCreatedBy = new ComboBox();
            cbShipmentStatus = new ComboBox();
            dtpShipmentDate = new DateTimePicker();
            btnSave = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            dgvShipment = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShipment).BeginInit();
            SuspendLayout();
            // 
            // txtShipmentCode
            // 
            txtShipmentCode.Location = new Point(335, 80);
            txtShipmentCode.Name = "txtShipmentCode";
            txtShipmentCode.Size = new Size(250, 27);
            txtShipmentCode.TabIndex = 0;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(335, 113);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(250, 27);
            txtDestination.TabIndex = 1;
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(335, 281);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(250, 27);
            txtDriverName.TabIndex = 2;
            // 
            // txtShipmentWeight
            // 
            txtShipmentWeight.Location = new Point(335, 179);
            txtShipmentWeight.Name = "txtShipmentWeight";
            txtShipmentWeight.Size = new Size(250, 27);
            txtShipmentWeight.TabIndex = 3;
            // 
            // txtVehicleNumber
            // 
            txtVehicleNumber.Location = new Point(335, 248);
            txtVehicleNumber.Name = "txtVehicleNumber";
            txtVehicleNumber.Size = new Size(250, 27);
            txtVehicleNumber.TabIndex = 4;
            // 
            // cbBatch
            // 
            cbBatch.FormattingEnabled = true;
            cbBatch.Location = new Point(335, 12);
            cbBatch.Name = "cbBatch";
            cbBatch.Size = new Size(250, 28);
            cbBatch.TabIndex = 5;
            // 
            // cbCreatedBy
            // 
            cbCreatedBy.FormattingEnabled = true;
            cbCreatedBy.Location = new Point(335, 46);
            cbCreatedBy.Name = "cbCreatedBy";
            cbCreatedBy.Size = new Size(250, 28);
            cbCreatedBy.TabIndex = 6;
            // 
            // cbShipmentStatus
            // 
            cbShipmentStatus.FormattingEnabled = true;
            cbShipmentStatus.Items.AddRange(new object[] { "Pending", "Shipped", "Delivered", "Cancelled" });
            cbShipmentStatus.Location = new Point(335, 214);
            cbShipmentStatus.Name = "cbShipmentStatus";
            cbShipmentStatus.Size = new Size(250, 28);
            cbShipmentStatus.TabIndex = 7;
            // 
            // dtpShipmentDate
            // 
            dtpShipmentDate.Location = new Point(335, 146);
            dtpShipmentDate.Name = "dtpShipmentDate";
            dtpShipmentDate.Size = new Size(250, 27);
            dtpShipmentDate.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(100, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(230, 330);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(491, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(364, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvShipment
            // 
            dgvShipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShipment.Location = new Point(100, 370);
            dgvShipment.Name = "dgvShipment";
            dgvShipment.RowHeadersWidth = 51;
            dgvShipment.Size = new Size(611, 114);
            dgvShipment.TabIndex = 13;
            dgvShipment.CellClick += dgvShipment_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 20);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 14;
            label1.Text = "Batch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 56);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 15;
            label2.Text = "Dibuat Oleh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 87);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 16;
            label3.Text = "Kode Shipment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 120);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 17;
            label4.Text = "Tujuan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 156);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 18;
            label5.Text = "Tanggal Shipment";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 189);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 19;
            label6.Text = "Berat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(144, 222);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 20;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(144, 255);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 21;
            label8.Text = "Nomor Kendaraan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(144, 288);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 22;
            label9.Text = "Nama Driver";
            // 
            // FormShipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvShipment);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dtpShipmentDate);
            Controls.Add(cbShipmentStatus);
            Controls.Add(cbCreatedBy);
            Controls.Add(cbBatch);
            Controls.Add(txtVehicleNumber);
            Controls.Add(txtShipmentWeight);
            Controls.Add(txtDriverName);
            Controls.Add(txtDestination);
            Controls.Add(txtShipmentCode);
            Name = "FormShipment";
            Text = "FormShipment";
            Load += FormShipment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShipment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtShipmentCode;
        private TextBox txtDestination;
        private TextBox txtDriverName;
        private TextBox txtShipmentWeight;
        private TextBox txtVehicleNumber;
        private ComboBox cbBatch;
        private ComboBox cbCreatedBy;
        private ComboBox cbShipmentStatus;
        private DateTimePicker dtpShipmentDate;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private DataGridView dgvShipment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}