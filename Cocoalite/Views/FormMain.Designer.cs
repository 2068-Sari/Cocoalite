namespace Cocoalite.Views
{
    partial class FormMain
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
            btnSupplier = new Button();
            btnReceiving = new Button();
            btnQualityControl = new Button();
            btnBatch = new Button();
            btnInventory = new Button();
            btnShipment = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnSupplier
            // 
            btnSupplier.Location = new Point(101, 77);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(121, 29);
            btnSupplier.TabIndex = 0;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = true;
            // 
            // btnReceiving
            // 
            btnReceiving.Location = new Point(101, 126);
            btnReceiving.Name = "btnReceiving";
            btnReceiving.Size = new Size(121, 29);
            btnReceiving.TabIndex = 1;
            btnReceiving.Text = "Receiving";
            btnReceiving.UseVisualStyleBackColor = true;
            // 
            // btnQualityControl
            // 
            btnQualityControl.Location = new Point(101, 173);
            btnQualityControl.Name = "btnQualityControl";
            btnQualityControl.Size = new Size(121, 29);
            btnQualityControl.TabIndex = 2;
            btnQualityControl.Text = "Quality Control";
            btnQualityControl.UseVisualStyleBackColor = true;
            // 
            // btnBatch
            // 
            btnBatch.Location = new Point(101, 219);
            btnBatch.Name = "btnBatch";
            btnBatch.Size = new Size(121, 29);
            btnBatch.TabIndex = 3;
            btnBatch.Text = "Batch";
            btnBatch.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(101, 266);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(121, 29);
            btnInventory.TabIndex = 4;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnShipment
            // 
            btnShipment.Location = new Point(101, 310);
            btnShipment.Name = "btnShipment";
            btnShipment.Size = new Size(121, 29);
            btnShipment.TabIndex = 5;
            btnShipment.Text = "Shipment";
            btnShipment.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(101, 354);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(121, 29);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnShipment);
            Controls.Add(btnInventory);
            Controls.Add(btnBatch);
            Controls.Add(btnQualityControl);
            Controls.Add(btnReceiving);
            Controls.Add(btnSupplier);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSupplier;
        private Button btnReceiving;
        private Button btnQualityControl;
        private Button btnBatch;
        private Button btnInventory;
        private Button btnShipment;
        private Button btnLogout;
    }
}