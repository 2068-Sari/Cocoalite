namespace Cocoalite.Views
{
    partial class InventoryControl : UserControl
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
            lblStockQuantity = new Label();
            txtStockQuantity = new TextBox();
            lblWarehouseLocation = new Label();
            txtWarehouseLocation = new TextBox();
            lblInventoryStatus = new Label();
            txtInventoryStatus = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            panelTable = new Panel();
            lblTableTitle = new Label();
            dgvInventory = new DataGridView();
            panelForm.SuspendLayout();
            panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(35, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(365, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manajemen Inventory";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(40, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(520, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Kelola stok batch kakao dan lokasi penyimpanan di gudang.";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(lblBatch);
            panelForm.Controls.Add(cbBatch);
            panelForm.Controls.Add(lblStockQuantity);
            panelForm.Controls.Add(txtStockQuantity);
            panelForm.Controls.Add(lblWarehouseLocation);
            panelForm.Controls.Add(txtWarehouseLocation);
            panelForm.Controls.Add(lblInventoryStatus);
            panelForm.Controls.Add(txtInventoryStatus);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnUpdate);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnClear);
            panelForm.Location = new Point(40, 120);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(780, 190);
            panelForm.TabIndex = 2;
            // 
            // lblBatch
            // 
            lblBatch.AutoSize = true;
            lblBatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatch.ForeColor = Color.FromArgb(74, 44, 30);
            lblBatch.Location = new Point(25, 22);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new Size(47, 20);
            lblBatch.TabIndex = 0;
            lblBatch.Text = "Batch";
            // 
            // cbBatch
            // 
            cbBatch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBatch.FormattingEnabled = true;
            cbBatch.Location = new Point(180, 19);
            cbBatch.Name = "cbBatch";
            cbBatch.Size = new Size(220, 28);
            cbBatch.TabIndex = 1;
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStockQuantity.ForeColor = Color.FromArgb(74, 44, 30);
            lblStockQuantity.Location = new Point(25, 62);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(114, 20);
            lblStockQuantity.TabIndex = 2;
            lblStockQuantity.Text = "Stock Quantity";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Location = new Point(180, 59);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(220, 27);
            txtStockQuantity.TabIndex = 3;
            // 
            // lblWarehouseLocation
            // 
            lblWarehouseLocation.AutoSize = true;
            lblWarehouseLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWarehouseLocation.ForeColor = Color.FromArgb(74, 44, 30);
            lblWarehouseLocation.Location = new Point(430, 22);
            lblWarehouseLocation.Name = "lblWarehouseLocation";
            lblWarehouseLocation.Size = new Size(148, 20);
            lblWarehouseLocation.TabIndex = 4;
            lblWarehouseLocation.Text = "Warehouse Location";
            // 
            // txtWarehouseLocation
            // 
            txtWarehouseLocation.Location = new Point(585, 19);
            txtWarehouseLocation.Name = "txtWarehouseLocation";
            txtWarehouseLocation.Size = new Size(160, 27);
            txtWarehouseLocation.TabIndex = 5;
            // 
            // lblInventoryStatus
            // 
            lblInventoryStatus.AutoSize = true;
            lblInventoryStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInventoryStatus.ForeColor = Color.FromArgb(74, 44, 30);
            lblInventoryStatus.Location = new Point(430, 62);
            lblInventoryStatus.Name = "lblInventoryStatus";
            lblInventoryStatus.Size = new Size(125, 20);
            lblInventoryStatus.TabIndex = 6;
            lblInventoryStatus.Text = "Inventory Status";
            // 
            // txtInventoryStatus
            // 
            txtInventoryStatus.Location = new Point(585, 59);
            txtInventoryStatus.Name = "txtInventoryStatus";
            txtInventoryStatus.ReadOnly = true;
            txtInventoryStatus.Size = new Size(160, 27);
            txtInventoryStatus.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(92, 49, 13);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(180, 120);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 35);
            btnSave.TabIndex = 8;
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
            btnUpdate.Location = new Point(320, 120);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 35);
            btnUpdate.TabIndex = 9;
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
            btnDelete.Location = new Point(460, 120);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 10;
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
            btnClear.Location = new Point(600, 120);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 35);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panelTable
            // 
            panelTable.BackColor = Color.White;
            panelTable.BorderStyle = BorderStyle.FixedSingle;
            panelTable.Controls.Add(lblTableTitle);
            panelTable.Controls.Add(dgvInventory);
            panelTable.Location = new Point(40, 335);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(780, 160);
            panelTable.TabIndex = 3;
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTableTitle.Location = new Point(20, 12);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(135, 23);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Daftar Inventory";
            // 
            // dgvInventory
            // 
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.BorderStyle = BorderStyle.None;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(20, 42);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(735, 100);
            dgvInventory.TabIndex = 1;
            dgvInventory.CellClick += dgvInventory_CellClick;
            // 
            // FormInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            ClientSize = new Size(860, 520);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelForm);
            Controls.Add(panelTable);
            Name = "FormInventory";
            Text = "FormInventory";
            Load += InventoryControl_Load;
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelTable.ResumeLayout(false);
            panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelForm;
        private Label lblBatch;
        private ComboBox cbBatch;
        private Label lblStockQuantity;
        private TextBox txtStockQuantity;
        private Label lblWarehouseLocation;
        private TextBox txtWarehouseLocation;
        private Label lblInventoryStatus;
        private TextBox txtInventoryStatus;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Panel panelTable;
        private Label lblTableTitle;
        private DataGridView dgvInventory;
    }
}