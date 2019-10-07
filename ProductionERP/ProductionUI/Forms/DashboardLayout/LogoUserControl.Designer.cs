namespace ProductionUI.Forms.DashboardLayout
{
    partial class LogoUserControl
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
            this.panelLogoContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelLogoContainer
            // 
            this.panelLogoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogoContainer.Location = new System.Drawing.Point(0, 0);
            this.panelLogoContainer.Name = "panelLogoContainer";
            this.panelLogoContainer.Size = new System.Drawing.Size(118, 111);
            this.panelLogoContainer.TabIndex = 0;
            // 
            // LogoUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panelLogoContainer);
            this.Name = "LogoUserControl";
            this.Size = new System.Drawing.Size(118, 111);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogoContainer;
    }
}
