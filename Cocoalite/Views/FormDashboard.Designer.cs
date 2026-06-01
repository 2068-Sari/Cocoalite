namespace Cocoalite.Views
{
    partial class FormDashboard
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
            lblTotalSupplier = new Label();
            lblTotalReceiving = new Label();
            lblTotalQc = new Label();
            lblTotalBatch = new Label();
            lblTotalStok = new Label();
            lblTotalShipment = new Label();
            SuspendLayout();
            // 
            // lblTotalSupplier
            // 
            lblTotalSupplier.AutoSize = true;
            lblTotalSupplier.Location = new Point(129, 40);
            lblTotalSupplier.Name = "lblTotalSupplier";
            lblTotalSupplier.Size = new Size(50, 20);
            lblTotalSupplier.TabIndex = 0;
            lblTotalSupplier.Text = "label1";
            // 
            // lblTotalReceiving
            // 
            lblTotalReceiving.AutoSize = true;
            lblTotalReceiving.Location = new Point(132, 86);
            lblTotalReceiving.Name = "lblTotalReceiving";
            lblTotalReceiving.Size = new Size(50, 20);
            lblTotalReceiving.TabIndex = 1;
            lblTotalReceiving.Text = "label2";
            // 
            // lblTotalQc
            // 
            lblTotalQc.AutoSize = true;
            lblTotalQc.Location = new Point(136, 126);
            lblTotalQc.Name = "lblTotalQc";
            lblTotalQc.Size = new Size(50, 20);
            lblTotalQc.TabIndex = 2;
            lblTotalQc.Text = "label3";
            // 
            // lblTotalBatch
            // 
            lblTotalBatch.AutoSize = true;
            lblTotalBatch.Location = new Point(147, 169);
            lblTotalBatch.Name = "lblTotalBatch";
            lblTotalBatch.Size = new Size(50, 20);
            lblTotalBatch.TabIndex = 3;
            lblTotalBatch.Text = "label4";
            // 
            // lblTotalStok
            // 
            lblTotalStok.AutoSize = true;
            lblTotalStok.Location = new Point(155, 218);
            lblTotalStok.Name = "lblTotalStok";
            lblTotalStok.Size = new Size(50, 20);
            lblTotalStok.TabIndex = 4;
            lblTotalStok.Text = "label5";
            // 
            // lblTotalShipment
            // 
            lblTotalShipment.AutoSize = true;
            lblTotalShipment.Location = new Point(162, 255);
            lblTotalShipment.Name = "lblTotalShipment";
            lblTotalShipment.Size = new Size(109, 20);
            lblTotalShipment.TabIndex = 5;
            lblTotalShipment.Text = "Total Shipment";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalShipment);
            Controls.Add(lblTotalStok);
            Controls.Add(lblTotalBatch);
            Controls.Add(lblTotalQc);
            Controls.Add(lblTotalReceiving);
            Controls.Add(lblTotalSupplier);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalSupplier;
        private Label lblTotalReceiving;
        private Label lblTotalQc;
        private Label lblTotalBatch;
        private Label lblTotalStok;
        private Label lblTotalShipment;
    }
}