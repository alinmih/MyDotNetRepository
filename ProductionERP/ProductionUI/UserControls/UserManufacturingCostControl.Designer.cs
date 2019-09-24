namespace ProductionUI.UserControls
{
    partial class UserManufacturingCostControl
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
            this.manufacturingCostViewButton = new System.Windows.Forms.Button();
            this.manufacturingCostEditButton = new System.Windows.Forms.Button();
            this.manufacturingCostCreateButton = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // manufacturingCostViewButton
            // 
            this.manufacturingCostViewButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manufacturingCostViewButton.FlatAppearance.BorderSize = 0;
            this.manufacturingCostViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manufacturingCostViewButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostViewButton.ForeColor = System.Drawing.Color.White;
            this.manufacturingCostViewButton.Location = new System.Drawing.Point(285, 12);
            this.manufacturingCostViewButton.Name = "manufacturingCostViewButton";
            this.manufacturingCostViewButton.Size = new System.Drawing.Size(121, 31);
            this.manufacturingCostViewButton.TabIndex = 8;
            this.manufacturingCostViewButton.Text = "View";
            this.manufacturingCostViewButton.UseVisualStyleBackColor = false;
            // 
            // manufacturingCostEditButton
            // 
            this.manufacturingCostEditButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manufacturingCostEditButton.FlatAppearance.BorderSize = 0;
            this.manufacturingCostEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manufacturingCostEditButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostEditButton.ForeColor = System.Drawing.Color.White;
            this.manufacturingCostEditButton.Location = new System.Drawing.Point(158, 12);
            this.manufacturingCostEditButton.Name = "manufacturingCostEditButton";
            this.manufacturingCostEditButton.Size = new System.Drawing.Size(121, 31);
            this.manufacturingCostEditButton.TabIndex = 9;
            this.manufacturingCostEditButton.Text = "Modify";
            this.manufacturingCostEditButton.UseVisualStyleBackColor = false;
            // 
            // manufacturingCostCreateButton
            // 
            this.manufacturingCostCreateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manufacturingCostCreateButton.FlatAppearance.BorderSize = 0;
            this.manufacturingCostCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manufacturingCostCreateButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostCreateButton.ForeColor = System.Drawing.Color.White;
            this.manufacturingCostCreateButton.Location = new System.Drawing.Point(31, 12);
            this.manufacturingCostCreateButton.Name = "manufacturingCostCreateButton";
            this.manufacturingCostCreateButton.Size = new System.Drawing.Size(121, 31);
            this.manufacturingCostCreateButton.TabIndex = 10;
            this.manufacturingCostCreateButton.Text = "Create";
            this.manufacturingCostCreateButton.UseVisualStyleBackColor = false;
            this.manufacturingCostCreateButton.Click += new System.EventHandler(this.ManufacturingCostCreateButton_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.White;
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(969, 521);
            this.centerPanel.TabIndex = 11;
            // 
            // UserManufacturingCostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.manufacturingCostViewButton);
            this.Controls.Add(this.manufacturingCostEditButton);
            this.Controls.Add(this.manufacturingCostCreateButton);
            this.Controls.Add(this.centerPanel);
            this.Name = "UserManufacturingCostControl";
            this.Size = new System.Drawing.Size(969, 521);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manufacturingCostViewButton;
        private System.Windows.Forms.Button manufacturingCostEditButton;
        private System.Windows.Forms.Button manufacturingCostCreateButton;
        private System.Windows.Forms.Panel centerPanel;
    }
}
