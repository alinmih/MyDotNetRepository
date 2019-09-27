namespace ProductionUI.Forms.AdminArea
{
    partial class CreateMachineForm
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
            this.createMachineLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.machineCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.createCategoryButton = new System.Windows.Forms.Button();
            this.saveMachineButton = new System.Windows.Forms.Button();
            this.machineHourRateLabel = new System.Windows.Forms.Label();
            this.machineHourRateTextBox = new System.Windows.Forms.TextBox();
            this.machineCategoryLabel = new System.Windows.Forms.Label();
            this.machineNameLabel = new System.Windows.Forms.Label();
            this.machineNameTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createMachineLabel
            // 
            this.createMachineLabel.AutoSize = true;
            this.createMachineLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMachineLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.createMachineLabel.Location = new System.Drawing.Point(14, 20);
            this.createMachineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createMachineLabel.Name = "createMachineLabel";
            this.createMachineLabel.Size = new System.Drawing.Size(176, 25);
            this.createMachineLabel.TabIndex = 3;
            this.createMachineLabel.Text = "Create Machine";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.createMachineLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(474, 73);
            this.headerPanel.TabIndex = 0;
            // 
            // machineCategoryComboBox
            // 
            this.machineCategoryComboBox.FormattingEnabled = true;
            this.machineCategoryComboBox.Location = new System.Drawing.Point(113, 183);
            this.machineCategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.machineCategoryComboBox.Name = "machineCategoryComboBox";
            this.machineCategoryComboBox.Size = new System.Drawing.Size(311, 27);
            this.machineCategoryComboBox.TabIndex = 44;
            // 
            // createCategoryButton
            // 
            this.createCategoryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCategoryButton.ForeColor = System.Drawing.Color.White;
            this.createCategoryButton.Location = new System.Drawing.Point(27, 34);
            this.createCategoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.createCategoryButton.Name = "createCategoryButton";
            this.createCategoryButton.Size = new System.Drawing.Size(168, 39);
            this.createCategoryButton.TabIndex = 43;
            this.createCategoryButton.Text = "Create Category";
            this.createCategoryButton.UseVisualStyleBackColor = false;
            this.createCategoryButton.Click += new System.EventHandler(this.CreateCategoryButton_Click);
            // 
            // saveMachineButton
            // 
            this.saveMachineButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveMachineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMachineButton.ForeColor = System.Drawing.Color.White;
            this.saveMachineButton.Location = new System.Drawing.Point(209, 314);
            this.saveMachineButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveMachineButton.Name = "saveMachineButton";
            this.saveMachineButton.Size = new System.Drawing.Size(215, 48);
            this.saveMachineButton.TabIndex = 43;
            this.saveMachineButton.Text = "Save";
            this.saveMachineButton.UseVisualStyleBackColor = false;
            // 
            // machineHourRateLabel
            // 
            this.machineHourRateLabel.AutoSize = true;
            this.machineHourRateLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineHourRateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.machineHourRateLabel.Location = new System.Drawing.Point(24, 246);
            this.machineHourRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.machineHourRateLabel.Name = "machineHourRateLabel";
            this.machineHourRateLabel.Size = new System.Drawing.Size(87, 19);
            this.machineHourRateLabel.TabIndex = 31;
            this.machineHourRateLabel.Text = "Hour Rate:";
            // 
            // machineHourRateTextBox
            // 
            this.machineHourRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machineHourRateTextBox.Location = new System.Drawing.Point(112, 244);
            this.machineHourRateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.machineHourRateTextBox.Name = "machineHourRateTextBox";
            this.machineHourRateTextBox.Size = new System.Drawing.Size(130, 26);
            this.machineHourRateTextBox.TabIndex = 33;
            // 
            // machineCategoryLabel
            // 
            this.machineCategoryLabel.AutoSize = true;
            this.machineCategoryLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineCategoryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.machineCategoryLabel.Location = new System.Drawing.Point(27, 187);
            this.machineCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.machineCategoryLabel.Name = "machineCategoryLabel";
            this.machineCategoryLabel.Size = new System.Drawing.Size(84, 19);
            this.machineCategoryLabel.TabIndex = 28;
            this.machineCategoryLabel.Text = "Category:";
            // 
            // machineNameLabel
            // 
            this.machineNameLabel.AutoSize = true;
            this.machineNameLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.machineNameLabel.Location = new System.Drawing.Point(53, 121);
            this.machineNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.machineNameLabel.Name = "machineNameLabel";
            this.machineNameLabel.Size = new System.Drawing.Size(58, 19);
            this.machineNameLabel.TabIndex = 29;
            this.machineNameLabel.Text = "Name:";
            // 
            // machineNameTextBox
            // 
            this.machineNameTextBox.BackColor = System.Drawing.Color.White;
            this.machineNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machineNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.machineNameTextBox.Location = new System.Drawing.Point(113, 118);
            this.machineNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.machineNameTextBox.Name = "machineNameTextBox";
            this.machineNameTextBox.ReadOnly = true;
            this.machineNameTextBox.Size = new System.Drawing.Size(312, 26);
            this.machineNameTextBox.TabIndex = 27;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.userPanel);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(15, 15);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(474, 502);
            this.mainPanel.TabIndex = 9;
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.White;
            this.userPanel.Controls.Add(this.machineCategoryComboBox);
            this.userPanel.Controls.Add(this.createCategoryButton);
            this.userPanel.Controls.Add(this.saveMachineButton);
            this.userPanel.Controls.Add(this.machineHourRateLabel);
            this.userPanel.Controls.Add(this.machineHourRateTextBox);
            this.userPanel.Controls.Add(this.machineCategoryLabel);
            this.userPanel.Controls.Add(this.machineNameLabel);
            this.userPanel.Controls.Add(this.machineNameTextBox);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(0, 73);
            this.userPanel.Margin = new System.Windows.Forms.Padding(4);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(474, 429);
            this.userPanel.TabIndex = 1;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(15, 517);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(474, 15);
            this.bottomPanel.TabIndex = 8;
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(15, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(474, 15);
            this.topPanel.TabIndex = 7;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(489, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(15, 532);
            this.rightPanel.TabIndex = 6;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(15, 532);
            this.leftPanel.TabIndex = 5;
            // 
            // CreateMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 532);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Machine Form";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label createMachineLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.ComboBox machineCategoryComboBox;
        private System.Windows.Forms.Button createCategoryButton;
        private System.Windows.Forms.Button saveMachineButton;
        private System.Windows.Forms.Label machineHourRateLabel;
        private System.Windows.Forms.TextBox machineHourRateTextBox;
        private System.Windows.Forms.Label machineCategoryLabel;
        private System.Windows.Forms.Label machineNameLabel;
        private System.Windows.Forms.TextBox machineNameTextBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
    }
}