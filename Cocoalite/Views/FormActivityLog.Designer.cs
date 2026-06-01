namespace Cocoalite.Views
{
    partial class FormActivityLog
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
            dgvActivityLog = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvActivityLog).BeginInit();
            SuspendLayout();
            // 
            // dgvActivityLog
            // 
            dgvActivityLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivityLog.Location = new Point(242, 207);
            dgvActivityLog.Name = "dgvActivityLog";
            dgvActivityLog.RowHeadersWidth = 51;
            dgvActivityLog.Size = new Size(300, 188);
            dgvActivityLog.TabIndex = 0;
            // 
            // FormActivityLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvActivityLog);
            Name = "FormActivityLog";
            Text = "FormActivityLog";
            Load += FormActivityLog_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActivityLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvActivityLog;
    }
}