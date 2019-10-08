namespace ProductionUI.Forms.AdminArea.Machines
{
    partial class UpdateMachineCategoryForm
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
            this.userPanel = new System.Windows.Forms.Panel();
            this.UpdateMachineCatButton = new System.Windows.Forms.Button();
            this.machineCategoryLabel = new System.Windows.Forms.Label();
            this.machineCategoryTextBox = new System.Windows.Forms.TextBox();
            this.updateCategoryLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.userPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.White;
            this.userPanel.Controls.Add(this.UpdateMachineCatButton);
            this.userPanel.Controls.Add(this.machineCategoryLabel);
            this.userPanel.Controls.Add(this.machineCategoryTextBox);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.ForeColor = System.Drawing.Color.DimGray;
            this.userPanel.Location = new System.Drawing.Point(0, 73);
            this.userPanel.Margin = new System.Windows.Forms.Padding(4);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(455, 195);
            this.userPanel.TabIndex = 1;
            // 
            // UpdateMachineCatButton
            // 
            this.UpdateMachineCatButton.BackColor = System.Drawing.Color.White;
            this.UpdateMachineCatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateMachineCatButton.ForeColor = System.Drawing.Color.DimGray;
            this.UpdateMachineCatButton.Location = new System.Drawing.Point(174, 100);
            this.UpdateMachineCatButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateMachineCatButton.Name = "UpdateMachineCatButton";
            this.UpdateMachineCatButton.Size = new System.Drawing.Size(215, 52);
            this.UpdateMachineCatButton.TabIndex = 43;
            this.UpdateMachineCatButton.Text = "Update";
            this.UpdateMachineCatButton.UseVisualStyleBackColor = false;
            // 
            // machineCategoryLabel
            // 
            this.machineCategoryLabel.AutoSize = true;
            this.machineCategoryLabel.BackColor = System.Drawing.Color.White;
            this.machineCategoryLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineCategoryLabel.ForeColor = System.Drawing.Color.DimGray;
            this.machineCategoryLabel.Location = new System.Drawing.Point(17, 28);
            this.machineCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.machineCategoryLabel.Name = "machineCategoryLabel";
            this.machineCategoryLabel.Size = new System.Drawing.Size(58, 19);
            this.machineCategoryLabel.TabIndex = 29;
            this.machineCategoryLabel.Text = "Name:";
            // 
            // machineCategoryTextBox
            // 
            this.machineCategoryTextBox.BackColor = System.Drawing.Color.White;
            this.machineCategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machineCategoryTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.machineCategoryTextBox.Location = new System.Drawing.Point(77, 25);
            this.machineCategoryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.machineCategoryTextBox.Name = "machineCategoryTextBox";
            this.machineCategoryTextBox.ReadOnly = true;
            this.machineCategoryTextBox.Size = new System.Drawing.Size(312, 20);
            this.machineCategoryTextBox.TabIndex = 27;
            // 
            // updateCategoryLabel
            // 
            this.updateCategoryLabel.AutoSize = true;
            this.updateCategoryLabel.BackColor = System.Drawing.Color.White;
            this.updateCategoryLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryLabel.ForeColor = System.Drawing.Color.DimGray;
            this.updateCategoryLabel.Location = new System.Drawing.Point(14, 20);
            this.updateCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updateCategoryLabel.Name = "updateCategoryLabel";
            this.updateCategoryLabel.Size = new System.Drawing.Size(277, 25);
            this.updateCategoryLabel.TabIndex = 3;
            this.updateCategoryLabel.Text = "Update Machine Category";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.updateCategoryLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.DimGray;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(455, 73);
            this.headerPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.userPanel);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.ForeColor = System.Drawing.Color.DimGray;
            this.mainPanel.Location = new System.Drawing.Point(10, 10);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(455, 268);
            this.mainPanel.TabIndex = 24;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.White;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.ForeColor = System.Drawing.Color.DimGray;
            this.bottomPanel.Location = new System.Drawing.Point(10, 278);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(455, 10);
            this.bottomPanel.TabIndex = 23;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.Color.DimGray;
            this.topPanel.Location = new System.Drawing.Point(10, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(455, 10);
            this.topPanel.TabIndex = 22;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.ForeColor = System.Drawing.Color.DimGray;
            this.rightPanel.Location = new System.Drawing.Point(465, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(10, 288);
            this.rightPanel.TabIndex = 21;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.ForeColor = System.Drawing.Color.DimGray;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(10, 288);
            this.leftPanel.TabIndex = 20;
            // 
            // UpdateMachineCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 288);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateMachineCategoryForm";
            this.Text = "UpdateMachineCategoryForm";
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button UpdateMachineCatButton;
        private System.Windows.Forms.Label machineCategoryLabel;
        private System.Windows.Forms.TextBox machineCategoryTextBox;
        private System.Windows.Forms.Label updateCategoryLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
    }
}