namespace ProductionUI.Forms.AdminArea
{
    partial class CreateMaterialMeasureUnitForm
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
            this.createMaterialMeasUnitButton = new System.Windows.Forms.Button();
            this.materialCategoryLabel = new System.Windows.Forms.Label();
            this.materialCategoryTextBox = new System.Windows.Forms.TextBox();
            this.createMaterialUnitLabel = new System.Windows.Forms.Label();
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
            this.userPanel.Controls.Add(this.createMaterialMeasUnitButton);
            this.userPanel.Controls.Add(this.materialCategoryLabel);
            this.userPanel.Controls.Add(this.materialCategoryTextBox);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(0, 73);
            this.userPanel.Margin = new System.Windows.Forms.Padding(4);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(484, 225);
            this.userPanel.TabIndex = 1;
            // 
            // createMaterialMeasUnitButton
            // 
            this.createMaterialMeasUnitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createMaterialMeasUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMaterialMeasUnitButton.ForeColor = System.Drawing.Color.White;
            this.createMaterialMeasUnitButton.Location = new System.Drawing.Point(174, 100);
            this.createMaterialMeasUnitButton.Margin = new System.Windows.Forms.Padding(4);
            this.createMaterialMeasUnitButton.Name = "createMaterialMeasUnitButton";
            this.createMaterialMeasUnitButton.Size = new System.Drawing.Size(215, 52);
            this.createMaterialMeasUnitButton.TabIndex = 43;
            this.createMaterialMeasUnitButton.Text = "Create";
            this.createMaterialMeasUnitButton.UseVisualStyleBackColor = false;
            // 
            // materialCategoryLabel
            // 
            this.materialCategoryLabel.AutoSize = true;
            this.materialCategoryLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCategoryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialCategoryLabel.Location = new System.Drawing.Point(17, 28);
            this.materialCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialCategoryLabel.Name = "materialCategoryLabel";
            this.materialCategoryLabel.Size = new System.Drawing.Size(58, 19);
            this.materialCategoryLabel.TabIndex = 29;
            this.materialCategoryLabel.Text = "Name:";
            // 
            // materialCategoryTextBox
            // 
            this.materialCategoryTextBox.BackColor = System.Drawing.Color.White;
            this.materialCategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCategoryTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.materialCategoryTextBox.Location = new System.Drawing.Point(77, 25);
            this.materialCategoryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.materialCategoryTextBox.Name = "materialCategoryTextBox";
            this.materialCategoryTextBox.ReadOnly = true;
            this.materialCategoryTextBox.Size = new System.Drawing.Size(312, 26);
            this.materialCategoryTextBox.TabIndex = 27;
            // 
            // createMaterialUnitLabel
            // 
            this.createMaterialUnitLabel.AutoSize = true;
            this.createMaterialUnitLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMaterialUnitLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.createMaterialUnitLabel.Location = new System.Drawing.Point(14, 20);
            this.createMaterialUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createMaterialUnitLabel.Name = "createMaterialUnitLabel";
            this.createMaterialUnitLabel.Size = new System.Drawing.Size(315, 25);
            this.createMaterialUnitLabel.TabIndex = 3;
            this.createMaterialUnitLabel.Text = "Create Material Measure Unit";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.createMaterialUnitLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(484, 73);
            this.headerPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.userPanel);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(10, 10);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(484, 298);
            this.mainPanel.TabIndex = 29;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(10, 308);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(484, 10);
            this.bottomPanel.TabIndex = 28;
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(10, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(484, 10);
            this.topPanel.TabIndex = 27;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(494, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(10, 318);
            this.rightPanel.TabIndex = 26;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(10, 318);
            this.leftPanel.TabIndex = 25;
            // 
            // CreateMaterialMeasureUnitForm
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateMaterialMeasureUnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Material Measure Unit";
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button createMaterialMeasUnitButton;
        private System.Windows.Forms.Label materialCategoryLabel;
        private System.Windows.Forms.TextBox materialCategoryTextBox;
        private System.Windows.Forms.Label createMaterialUnitLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
    }
}