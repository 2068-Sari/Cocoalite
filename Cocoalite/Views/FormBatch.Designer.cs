namespace Cocoalite.Views
{
    partial class FormBatch
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbQc = new ComboBox();
            cbBatchStatus = new ComboBox();
            txtBatchCode = new TextBox();
            txtBatchWeight = new TextBox();
            dtpBatchDate = new DateTimePicker();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvBatch = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBatch).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 32);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "QC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 75);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Batch Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 117);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Batch Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 160);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Batch Weight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 206);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "Batch Status";
            // 
            // cbQc
            // 
            cbQc.FormattingEnabled = true;
            cbQc.Location = new Point(260, 24);
            cbQc.Name = "cbQc";
            cbQc.Size = new Size(246, 28);
            cbQc.TabIndex = 5;
            // 
            // cbBatchStatus
            // 
            cbBatchStatus.FormattingEnabled = true;
            cbBatchStatus.Items.AddRange(new object[] { "Available", "Partially Distributed", "Distributed" });
            cbBatchStatus.Location = new Point(260, 198);
            cbBatchStatus.Name = "cbBatchStatus";
            cbBatchStatus.Size = new Size(246, 28);
            cbBatchStatus.TabIndex = 6;
            // 
            // txtBatchCode
            // 
            txtBatchCode.Location = new Point(260, 68);
            txtBatchCode.Name = "txtBatchCode";
            txtBatchCode.Size = new Size(246, 27);
            txtBatchCode.TabIndex = 7;
            // 
            // txtBatchWeight
            // 
            txtBatchWeight.Location = new Point(260, 153);
            txtBatchWeight.Name = "txtBatchWeight";
            txtBatchWeight.Size = new Size(246, 27);
            txtBatchWeight.TabIndex = 8;
            // 
            // dtpBatchDate
            // 
            dtpBatchDate.Location = new Point(260, 110);
            dtpBatchDate.Name = "dtpBatchDate";
            dtpBatchDate.Size = new Size(246, 27);
            dtpBatchDate.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(43, 271);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(179, 271);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(317, 271);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(444, 271);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dgvBatch
            // 
            dgvBatch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatch.Location = new Point(574, 231);
            dgvBatch.Name = "dgvBatch";
            dgvBatch.RowHeadersWidth = 51;
            dgvBatch.Size = new Size(300, 188);
            dgvBatch.TabIndex = 14;
            // 
            // FormBatch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBatch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dtpBatchDate);
            Controls.Add(txtBatchWeight);
            Controls.Add(txtBatchCode);
            Controls.Add(cbBatchStatus);
            Controls.Add(cbQc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBatch";
            Text = "FormBatch";
            Load += FormBatch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBatch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbQc;
        private ComboBox cbBatchStatus;
        private TextBox txtBatchCode;
        private TextBox txtBatchWeight;
        private DateTimePicker dtpBatchDate;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvBatch;
    }
}