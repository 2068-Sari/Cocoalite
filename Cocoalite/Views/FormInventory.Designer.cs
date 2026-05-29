namespace Cocoalite.Views
{
    partial class FormInventory
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
            cbBatch = new ComboBox();
            cbInventoryStatus = new ComboBox();
            txtStockIn = new TextBox();
            txtStockOut = new TextBox();
            txtCurrentStock = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvInventory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 39);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Batch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 84);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Stok Masuk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 127);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "Stok Keluar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 168);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Stok Tersedia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 211);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 4;
            label5.Text = "Status Inventory";
            // 
            // cbBatch
            // 
            cbBatch.FormattingEnabled = true;
            cbBatch.Location = new Point(261, 31);
            cbBatch.Name = "cbBatch";
            cbBatch.Size = new Size(162, 28);
            cbBatch.TabIndex = 5;
            // 
            // cbInventoryStatus
            // 
            cbInventoryStatus.FormattingEnabled = true;
            cbInventoryStatus.Items.AddRange(new object[] { "Available", "Low Stock", "Empty" });
            cbInventoryStatus.Location = new Point(261, 203);
            cbInventoryStatus.Name = "cbInventoryStatus";
            cbInventoryStatus.Size = new Size(162, 28);
            cbInventoryStatus.TabIndex = 6;
            // 
            // txtStockIn
            // 
            txtStockIn.Location = new Point(261, 77);
            txtStockIn.Name = "txtStockIn";
            txtStockIn.Size = new Size(162, 27);
            txtStockIn.TabIndex = 7;
            // 
            // txtStockOut
            // 
            txtStockOut.Location = new Point(261, 120);
            txtStockOut.Name = "txtStockOut";
            txtStockOut.Size = new Size(162, 27);
            txtStockOut.TabIndex = 8;
            // 
            // txtCurrentStock
            // 
            txtCurrentStock.Location = new Point(261, 161);
            txtCurrentStock.Name = "txtCurrentStock";
            txtCurrentStock.Size = new Size(162, 27);
            txtCurrentStock.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(80, 248);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(206, 248);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(329, 248);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(455, 248);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(80, 300);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(574, 138);
            dgvInventory.TabIndex = 14;
            dgvInventory.CellClick += dgvInventory_CellClick;
            // 
            // FormInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvInventory);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtCurrentStock);
            Controls.Add(txtStockOut);
            Controls.Add(txtStockIn);
            Controls.Add(cbInventoryStatus);
            Controls.Add(cbBatch);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormInventory";
            Text = "FormInventory";
            Load += FormInventory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbBatch;
        private ComboBox cbInventoryStatus;
        private TextBox txtStockIn;
        private TextBox txtStockOut;
        private TextBox txtCurrentStock;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvInventory;
    }
}