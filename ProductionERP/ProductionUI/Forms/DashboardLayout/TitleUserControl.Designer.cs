namespace ProductionUI.Forms.DashboardLayout
{
    partial class TitleUserControl
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
            this.panelHeaderContainer = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.logedInLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.panelHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeaderContainer
            // 
            this.panelHeaderContainer.Controls.Add(this.userLabel);
            this.panelHeaderContainer.Controls.Add(this.logedInLabel);
            this.panelHeaderContainer.Controls.Add(this.companyLabel);
            this.panelHeaderContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderContainer.Name = "panelHeaderContainer";
            this.panelHeaderContainer.Size = new System.Drawing.Size(564, 25);
            this.panelHeaderContainer.TabIndex = 0;
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.userLabel.Location = new System.Drawing.Point(479, 3);
            this.userLabel.Name = "userLabel";
            this.userLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userLabel.Size = new System.Drawing.Size(82, 19);
            this.userLabel.TabIndex = 7;
            this.userLabel.Text = "<admin>";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logedInLabel
            // 
            this.logedInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logedInLabel.AutoSize = true;
            this.logedInLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logedInLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.logedInLabel.Location = new System.Drawing.Point(359, 3);
            this.logedInLabel.Name = "logedInLabel";
            this.logedInLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logedInLabel.Size = new System.Drawing.Size(116, 19);
            this.logedInLabel.TabIndex = 8;
            this.logedInLabel.Text = "Logged In As:";
            this.logedInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.companyLabel.Location = new System.Drawing.Point(3, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.companyLabel.Size = new System.Drawing.Size(258, 23);
            this.companyLabel.TabIndex = 9;
            this.companyLabel.Text = "<Company> Management";
            this.companyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TitleUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelHeaderContainer);
            this.Name = "TitleUserControl";
            this.Size = new System.Drawing.Size(564, 25);
            this.panelHeaderContainer.ResumeLayout(false);
            this.panelHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderContainer;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label logedInLabel;
        private System.Windows.Forms.Label companyLabel;
    }
}
