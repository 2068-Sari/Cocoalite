namespace Cocoalite.Views
{
    partial class FormReceiving
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
            lblReceivingCode = new Label();
            lblSupplier = new Label();
            lblReceivingDate = new Label();
            lblCocoaWeight = new Label();
            lblVehicle = new Label();
            txtReceivingCode = new TextBox();
            txtCocoaWeight = new TextBox();
            cbSupplier = new ComboBox();
            dtpReceivingDate = new DateTimePicker();
            txtVehicleNumber = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvReceiving = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReceiving).BeginInit();
            SuspendLayout();
            // 
            // lblReceivingCode
            // 
            lblReceivingCode.AutoSize = true;
            lblReceivingCode.Location = new Point(99, 31);
            lblReceivingCode.Name = "lblReceivingCode";
            lblReceivingCode.Size = new Size(112, 20);
            lblReceivingCode.TabIndex = 0;
            lblReceivingCode.Text = "Receiving Code";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(99, 75);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(64, 20);
            lblSupplier.TabIndex = 1;
            lblSupplier.Text = "Supplier";
            // 
            // lblReceivingDate
            // 
            lblReceivingDate.AutoSize = true;
            lblReceivingDate.Location = new Point(99, 118);
            lblReceivingDate.Name = "lblReceivingDate";
            lblReceivingDate.Size = new Size(109, 20);
            lblReceivingDate.TabIndex = 2;
            lblReceivingDate.Text = "Receiving Date";
            // 
            // lblCocoaWeight
            // 
            lblCocoaWeight.AutoSize = true;
            lblCocoaWeight.Location = new Point(99, 163);
            lblCocoaWeight.Name = "lblCocoaWeight";
            lblCocoaWeight.Size = new Size(102, 20);
            lblCocoaWeight.TabIndex = 3;
            lblCocoaWeight.Text = "Cocoa Weight";
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Location = new Point(99, 208);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(114, 20);
            lblVehicle.TabIndex = 4;
            lblVehicle.Text = "Vehicle Number";
            // 
            // txtReceivingCode
            // 
            txtReceivingCode.Location = new Point(296, 24);
            txtReceivingCode.Name = "txtReceivingCode";
            txtReceivingCode.Size = new Size(250, 27);
            txtReceivingCode.TabIndex = 5;
            // 
            // txtCocoaWeight
            // 
            txtCocoaWeight.Location = new Point(296, 156);
            txtCocoaWeight.Name = "txtCocoaWeight";
            txtCocoaWeight.Size = new Size(250, 27);
            txtCocoaWeight.TabIndex = 6;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(296, 67);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(250, 28);
            cbSupplier.TabIndex = 7;
            // 
            // dtpReceivingDate
            // 
            dtpReceivingDate.Location = new Point(296, 111);
            dtpReceivingDate.Name = "dtpReceivingDate";
            dtpReceivingDate.Size = new Size(250, 27);
            dtpReceivingDate.TabIndex = 8;
            // 
            // txtVehicleNumber
            // 
            txtVehicleNumber.Location = new Point(296, 201);
            txtVehicleNumber.Name = "txtVehicleNumber";
            txtVehicleNumber.Size = new Size(250, 27);
            txtVehicleNumber.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(99, 259);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(229, 259);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(370, 259);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(517, 259);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvReceiving
            // 
            dgvReceiving.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceiving.Location = new Point(99, 294);
            dgvReceiving.Name = "dgvReceiving";
            dgvReceiving.RowHeadersWidth = 51;
            dgvReceiving.Size = new Size(640, 154);
            dgvReceiving.TabIndex = 14;
            dgvReceiving.CellClick += dgvReceiving_CellClick;
            // 
            // FormReceiving
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 460);
            Controls.Add(dgvReceiving);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtVehicleNumber);
            Controls.Add(dtpReceivingDate);
            Controls.Add(cbSupplier);
            Controls.Add(txtCocoaWeight);
            Controls.Add(txtReceivingCode);
            Controls.Add(lblVehicle);
            Controls.Add(lblCocoaWeight);
            Controls.Add(lblReceivingDate);
            Controls.Add(lblSupplier);
            Controls.Add(lblReceivingCode);
            Name = "FormReceiving";
            Text = "FormReceiving";
            Load += FormReceiving_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReceiving).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReceivingCode;
        private Label lblSupplier;
        private Label lblReceivingDate;
        private Label lblCocoaWeight;
        private Label lblVehicle;
        private TextBox txtReceivingCode;
        private TextBox txtCocoaWeight;
        private ComboBox cbSupplier;
        private DateTimePicker dtpReceivingDate;
        private TextBox txtVehicleNumber;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvReceiving;
    }
}