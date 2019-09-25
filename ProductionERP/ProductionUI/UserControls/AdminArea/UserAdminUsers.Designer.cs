namespace ProductionUI.UserControls.AdminArea
{
    partial class UserAdminUsers
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
            this.productionOverviewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productionOverviewLabel
            // 
            this.productionOverviewLabel.AutoSize = true;
            this.productionOverviewLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionOverviewLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.productionOverviewLabel.Location = new System.Drawing.Point(377, 360);
            this.productionOverviewLabel.Name = "productionOverviewLabel";
            this.productionOverviewLabel.Size = new System.Drawing.Size(190, 25);
            this.productionOverviewLabel.TabIndex = 2;
            this.productionOverviewLabel.Text = "Work In Progress";
            // 
            // UserAdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productionOverviewLabel);
            this.Name = "UserAdminUsers";
            this.Size = new System.Drawing.Size(945, 745);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productionOverviewLabel;
    }
}
