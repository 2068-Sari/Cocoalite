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
            cbBatch = new ComboBox();
            txtStockQuantity = new TextBox();
            txtWarehouseLocation = new TextBox();
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
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Stok Tersedia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 127);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 2;
            label3.Text = "Lokasi Gudang";
            // 
            // cbBatch
            // 
            cbBatch.FormattingEnabled = true;
            cbBatch.Location = new Point(261, 31);
            cbBatch.Name = "cbBatch";
            cbBatch.Size = new Size(162, 28);
            cbBatch.TabIndex = 5;
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Location = new Point(261, 77);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new Size(162, 27);
            this.txtStockQuantity.TabIndex = 7;
            // 
            // txtWarehouseLocation
            // 
            txtWarehouseLocation.Location = new Point(261, 120);
            txtWarehouseLocation.Name = "txtWarehouseLocation";
            txtWarehouseLocation.Size = new Size(162, 27);
            txtWarehouseLocation.TabIndex = 8;
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
            Controls.Add(txtWarehouseLocation);
            Controls.Add(this.txtStockQuantity);
            Controls.Add(cbBatch);
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
        private ComboBox cbBatch;
        private TextBox txtStockQuantity;
        private TextBox txtWarehouseLocation;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvInventory;
    }
}