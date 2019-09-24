namespace ProductionUI.UserControls
{
    partial class UserSalesOrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.salesPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // salesPanel
            // 
            this.salesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesPanel.Location = new System.Drawing.Point(0, 0);
            this.salesPanel.Name = "salesPanel";
            this.salesPanel.Size = new System.Drawing.Size(969, 521);
            this.salesPanel.TabIndex = 8;
            // 
            // UserSalesOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.salesPanel);
            this.Name = "UserSalesOrderControl";
            this.Size = new System.Drawing.Size(969, 521);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel salesPanel;
    }
}
