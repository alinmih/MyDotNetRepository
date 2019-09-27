namespace ProductionUI.Forms.AdminArea
{
    partial class CreateMachineCategoryForm
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
            this.saveMachineCatButton = new System.Windows.Forms.Button();
            this.createCategoryLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.machineCategoryTextBox = new System.Windows.Forms.TextBox();
            this.machineCategoryLabel = new System.Windows.Forms.Label();
            this.userPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.White;
            this.userPanel.Controls.Add(this.saveMachineCatButton);
            this.userPanel.Controls.Add(this.machineCategoryLabel);
            this.userPanel.Controls.Add(this.machineCategoryTextBox);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(0, 73);
            this.userPanel.Margin = new System.Windows.Forms.Padding(4);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(474, 215);
            this.userPanel.TabIndex = 1;
            // 
            // saveMachineCatButton
            // 
            this.saveMachineCatButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveMachineCatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMachineCatButton.ForeColor = System.Drawing.Color.White;
            this.saveMachineCatButton.Location = new System.Drawing.Point(174, 100);
            this.saveMachineCatButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveMachineCatButton.Name = "saveMachineCatButton";
            this.saveMachineCatButton.Size = new System.Drawing.Size(215, 52);
            this.saveMachineCatButton.TabIndex = 43;
            this.saveMachineCatButton.Text = "Save";
            this.saveMachineCatButton.UseVisualStyleBackColor = false;
            // 
            // createCategoryLabel
            // 
            this.createCategoryLabel.AutoSize = true;
            this.createCategoryLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCategoryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.createCategoryLabel.Location = new System.Drawing.Point(14, 20);
            this.createCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createCategoryLabel.Name = "createCategoryLabel";
            this.createCategoryLabel.Size = new System.Drawing.Size(274, 25);
            this.createCategoryLabel.TabIndex = 3;
            this.createCategoryLabel.Text = "Create Machine Category";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.createCategoryLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(474, 73);
            this.headerPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.userPanel);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(15, 15);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(474, 288);
            this.mainPanel.TabIndex = 14;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(15, 303);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(474, 15);
            this.bottomPanel.TabIndex = 13;
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(15, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(474, 15);
            this.topPanel.TabIndex = 12;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(489, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(15, 318);
            this.rightPanel.TabIndex = 11;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(15, 318);
            this.leftPanel.TabIndex = 10;
            // 
            // machineCategoryTextBox
            // 
            this.machineCategoryTextBox.BackColor = System.Drawing.Color.White;
            this.machineCategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machineCategoryTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.machineCategoryTextBox.Location = new System.Drawing.Point(77, 25);
            this.machineCategoryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.machineCategoryTextBox.Name = "machineCategoryTextBox";
            this.machineCategoryTextBox.ReadOnly = true;
            this.machineCategoryTextBox.Size = new System.Drawing.Size(312, 26);
            this.machineCategoryTextBox.TabIndex = 27;
            // 
            // machineCategoryLabel
            // 
            this.machineCategoryLabel.AutoSize = true;
            this.machineCategoryLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineCategoryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.machineCategoryLabel.Location = new System.Drawing.Point(17, 28);
            this.machineCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.machineCategoryLabel.Name = "machineCategoryLabel";
            this.machineCategoryLabel.Size = new System.Drawing.Size(58, 19);
            this.machineCategoryLabel.TabIndex = 29;
            this.machineCategoryLabel.Text = "Name:";
            // 
            // CreateMachineCategoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 318);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateMachineCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Machine Category";
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button saveMachineCatButton;
        private System.Windows.Forms.Label machineCategoryLabel;
        private System.Windows.Forms.TextBox machineCategoryTextBox;
        private System.Windows.Forms.Label createCategoryLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
    }
}