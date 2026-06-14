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
            cbWarehouseLocation = new ComboBox();
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
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(74, 44, 30);
            lblTitle.Location = new Point(55, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(418, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manajemen Inventory";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 86, 60);
            lblSubtitle.Location = new Point(58, 88);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(466, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Kelola stok batch kakao dan lokasi penyimpanan di gudang.";

            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.BorderStyle = BorderStyle.None;
            panelForm.Controls.Add(lblBatch);
            panelForm.Controls.Add(cbBatch);
            panelForm.Controls.Add(lblStockQuantity);
            panelForm.Controls.Add(txtStockQuantity);
            panelForm.Controls.Add(lblWarehouseLocation);
            panelForm.Controls.Add(cbWarehouseLocation);
            panelForm.Controls.Add(lblInventoryStatus);
            panelForm.Controls.Add(txtInventoryStatus);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(btnUpdate);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnClear);
            panelForm.Location = new Point(55, 135);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1050, 230);
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.TabIndex = 2;
            // lblBatch
            lblBatch.AutoSize = false;
            lblBatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatch.ForeColor = Color.FromArgb(74, 44, 30);
            lblBatch.Location = new Point(45, 35);
            lblBatch.Size = new Size(150, 27);
            lblBatch.Text = "Batch";
            lblBatch.TextAlign = ContentAlignment.MiddleLeft;

            // cbBatch
            cbBatch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBatch.Font = new Font("Segoe UI", 9F);
            cbBatch.Location = new Point(220, 35);
            cbBatch.Size = new Size(310, 28);

            // lblStockQuantity
            lblStockQuantity.AutoSize = false;
            lblStockQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStockQuantity.ForeColor = Color.FromArgb(74, 44, 30);
            lblStockQuantity.Location = new Point(45, 78);
            lblStockQuantity.Size = new Size(150, 27);
            lblStockQuantity.Text = "Stock Quantity";
            lblStockQuantity.TextAlign = ContentAlignment.MiddleLeft;

            // txtStockQuantity
            txtStockQuantity.Font = new Font("Segoe UI", 9F);
            txtStockQuantity.Location = new Point(220, 78);
            txtStockQuantity.Size = new Size(310, 27);

            // lblWarehouseLocation
            lblWarehouseLocation.AutoSize = false;
            lblWarehouseLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWarehouseLocation.ForeColor = Color.FromArgb(74, 44, 30);
            lblWarehouseLocation.Location = new Point(610, 35);
            lblWarehouseLocation.Size = new Size(160, 27);
            lblWarehouseLocation.Text = "Warehouse Location";
            lblWarehouseLocation.TextAlign = ContentAlignment.MiddleLeft;

            // cbWarehouseLocation
            cbWarehouseLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWarehouseLocation.Font = new Font("Segoe UI", 9F);
            cbWarehouseLocation.Location = new Point(790, 35);
            cbWarehouseLocation.Name = "cbWarehouseLocation";
            cbWarehouseLocation.Size = new Size(260, 28);
            cbWarehouseLocation.TabIndex = 5;

            // lblInventoryStatus
            lblInventoryStatus.AutoSize = false;
            lblInventoryStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInventoryStatus.ForeColor = Color.FromArgb(74, 44, 30);
            lblInventoryStatus.Location = new Point(610, 78);
            lblInventoryStatus.Size = new Size(160, 27);
            lblInventoryStatus.Text = "Inventory Status";
            lblInventoryStatus.TextAlign = ContentAlignment.MiddleLeft;

            // txtInventoryStatus
            txtInventoryStatus.Font = new Font("Segoe UI", 9F);
            txtInventoryStatus.Location = new Point(790, 78);
            txtInventoryStatus.Size = new Size(260, 27);
            txtInventoryStatus.ReadOnly = true;

            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(92, 49, 13);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(220, 155);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 38);
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
            btnUpdate.Location = new Point(430, 155);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 38);
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
            btnDelete.Location = new Point(640, 155);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 38);
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
            btnClear.Location = new Point(850, 155);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 38);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // 
            // panelTable
            // 
            panelTable.BackColor = Color.White;
            panelTable.BorderStyle = BorderStyle.None;
            panelTable.Controls.Add(lblTableTitle);
            panelTable.Controls.Add(dgvInventory);
            panelTable.Location = new Point(55, 405);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(1050, 330);
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
            lblTableTitle.Text = "Daftar Inventory";

            // 
            // dgvInventory
            // 
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.BorderStyle = BorderStyle.None;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(25, 60);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(1000, 225);
            dgvInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;
            dgvInventory.ReadOnly = true;
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.TabIndex = 1;
            dgvInventory.CellClick += dgvInventory_CellClick;

            // 
            // InventoryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelForm);
            Controls.Add(panelTable);
            Name = "InventoryControl";
            Size = new Size(1250, 700);
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
        private ComboBox cbWarehouseLocation;
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