namespace ProductionUI.Forms.AdminArea
{
    partial class CreateMaterialForm
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.rawMaterialUnitComboBox = new System.Windows.Forms.ComboBox();
            this.rawMaterialTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createTypeButton = new System.Windows.Forms.Button();
            this.createUnitButton = new System.Windows.Forms.Button();
            this.rawUnitLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.rawPriceLabel = new System.Windows.Forms.Label();
            this.rawPriceTextBox = new System.Windows.Forms.TextBox();
            this.rawLenghtLabel = new System.Windows.Forms.Label();
            this.rawWidthLabel = new System.Windows.Forms.Label();
            this.rawMaterialTypeLabel = new System.Windows.Forms.Label();
            this.rawMaterialNameLabel = new System.Windows.Forms.Label();
            this.rawThickLabel = new System.Windows.Forms.Label();
            this.rawLengthTextBox = new System.Windows.Forms.TextBox();
            this.rawThickTextBox = new System.Windows.Forms.TextBox();
            this.rawWidthTextBox = new System.Windows.Forms.TextBox();
            this.rawMaterialNameTextBox = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.createMaterialLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(10, 435);
            this.leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(493, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(10, 435);
            this.rightPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(10, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(483, 10);
            this.topPanel.TabIndex = 2;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(10, 425);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(483, 10);
            this.bottomPanel.TabIndex = 3;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.userPanel);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(10, 10);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(483, 415);
            this.mainPanel.TabIndex = 4;
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.White;
            this.userPanel.Controls.Add(this.rawMaterialUnitComboBox);
            this.userPanel.Controls.Add(this.rawMaterialTypeComboBox);
            this.userPanel.Controls.Add(this.createTypeButton);
            this.userPanel.Controls.Add(this.createUnitButton);
            this.userPanel.Controls.Add(this.rawUnitLabel);
            this.userPanel.Controls.Add(this.saveButton);
            this.userPanel.Controls.Add(this.rawPriceLabel);
            this.userPanel.Controls.Add(this.rawPriceTextBox);
            this.userPanel.Controls.Add(this.rawLenghtLabel);
            this.userPanel.Controls.Add(this.rawWidthLabel);
            this.userPanel.Controls.Add(this.rawMaterialTypeLabel);
            this.userPanel.Controls.Add(this.rawMaterialNameLabel);
            this.userPanel.Controls.Add(this.rawThickLabel);
            this.userPanel.Controls.Add(this.rawLengthTextBox);
            this.userPanel.Controls.Add(this.rawThickTextBox);
            this.userPanel.Controls.Add(this.rawWidthTextBox);
            this.userPanel.Controls.Add(this.rawMaterialNameTextBox);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(0, 50);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(483, 365);
            this.userPanel.TabIndex = 1;
            // 
            // rawMaterialUnitComboBox
            // 
            this.rawMaterialUnitComboBox.FormattingEnabled = true;
            this.rawMaterialUnitComboBox.Location = new System.Drawing.Point(247, 214);
            this.rawMaterialUnitComboBox.Name = "rawMaterialUnitComboBox";
            this.rawMaterialUnitComboBox.Size = new System.Drawing.Size(67, 27);
            this.rawMaterialUnitComboBox.TabIndex = 44;
            // 
            // rawMaterialTypeComboBox
            // 
            this.rawMaterialTypeComboBox.FormattingEnabled = true;
            this.rawMaterialTypeComboBox.Location = new System.Drawing.Point(104, 125);
            this.rawMaterialTypeComboBox.Name = "rawMaterialTypeComboBox";
            this.rawMaterialTypeComboBox.Size = new System.Drawing.Size(348, 27);
            this.rawMaterialTypeComboBox.TabIndex = 44;
            // 
            // createTypeButton
            // 
            this.createTypeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTypeButton.ForeColor = System.Drawing.Color.White;
            this.createTypeButton.Location = new System.Drawing.Point(18, 23);
            this.createTypeButton.Name = "createTypeButton";
            this.createTypeButton.Size = new System.Drawing.Size(112, 27);
            this.createTypeButton.TabIndex = 43;
            this.createTypeButton.Text = "Create Type";
            this.createTypeButton.UseVisualStyleBackColor = false;
            this.createTypeButton.Click += new System.EventHandler(this.CreateTypeButton_Click);
            // 
            // createUnitButton
            // 
            this.createUnitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUnitButton.ForeColor = System.Drawing.Color.White;
            this.createUnitButton.Location = new System.Drawing.Point(158, 23);
            this.createUnitButton.Name = "createUnitButton";
            this.createUnitButton.Size = new System.Drawing.Size(112, 27);
            this.createUnitButton.TabIndex = 43;
            this.createUnitButton.Text = "Create Unit";
            this.createUnitButton.UseVisualStyleBackColor = false;
            this.createUnitButton.Click += new System.EventHandler(this.CreateUnitButton_Click);
            // 
            // rawUnitLabel
            // 
            this.rawUnitLabel.AutoSize = true;
            this.rawUnitLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawUnitLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rawUnitLabel.Location = new System.Drawing.Point(195, 220);
            this.rawUnitLabel.Name = "rawUnitLabel";
            this.rawUnitLabel.Size = new System.Drawing.Size(43, 19);
            this.rawUnitLabel.TabIndex = 30;
            this.rawUnitLabel.Text = "Unit:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(308, 283);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(144, 46);
            this.saveButton.TabIndex = 43;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // rawPriceLabel
            // 
            this.rawPriceLabel.AutoSize = true;
            this.rawPriceLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawPriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rawPriceLabel.Location = new System.Drawing.Point(47, 217);
            this.rawPriceLabel.Name = "rawPriceLabel";
            this.rawPriceLabel.Size = new System.Drawing.Size(51, 19);
            this.rawPriceLabel.TabIndex = 31;
            this.rawPriceLabel.Text = "Price:";
            // 
            // rawPriceTextBox
            // 
            this.rawPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rawPriceTextBox.Location = new System.Drawing.Point(104, 215);
            this.rawPriceTextBox.Name = "rawPriceTextBox";
            this.rawPriceTextBox.Size = new System.Drawing.Size(67, 26);
            this.rawPriceTextBox.TabIndex = 33;
            // 
            // rawLenghtLabel
            // 
            this.rawLenghtLabel.AutoSize = true;
            this.rawLenghtLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawLenghtLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rawLenghtLabel.Location = new System.Drawing.Point(34, 173);
            this.rawLenghtLabel.Name = "rawLenghtLabel";
            this.rawLenghtLabel.Size = new System.Drawing.Size(64, 19);
            this.rawLenghtLabel.TabIndex = 20;
            this.rawLenghtLabel.Text = "Lenght:";
            // 
            // rawWidthLabel
            // 
            this.rawWidthLabel.AutoSize = true;
            this.rawWidthLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawWidthLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rawWidthLabel.Location = new System.Drawing.Point(180, 175);
            this.rawWidthLabel.Name = "rawWidthLabel";
            this.rawWidthLabel.Size = new System.Drawing.Size(58, 19);
            this.rawWidthLabel.TabIndex = 21;
            this.rawWidthLabel.Text = "Width:";
            // 
            // rawMaterialTypeLabel
            // 
            this.rawMaterialTypeLabel.AutoSize = true;
            this.rawMaterialTypeLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawMaterialTypeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rawMaterialTypeLabel.Location = new System.Drawing.Point(47, 128);
            this.rawMaterialTypeLabel.Name = "rawMaterialTypeLabel";
            this.rawMaterialTypeLabel.Size = new System.Drawing.Size(51, 19);
            this.rawMaterialTypeLabel.TabIndex = 28;
            this.rawMaterialTypeLabel.Text = "Type:";
            // 
            // rawMaterialNameLabel
            // 
            this.rawMaterialNameLabel.AutoSize = true;
            this.rawMaterialNameLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawMaterialNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rawMaterialNameLabel.Location = new System.Drawing.Point(40, 83);
            this.rawMaterialNameLabel.Name = "rawMaterialNameLabel";
            this.rawMaterialNameLabel.Size = new System.Drawing.Size(58, 19);
            this.rawMaterialNameLabel.TabIndex = 29;
            this.rawMaterialNameLabel.Text = "Name:";
            // 
            // rawThickLabel
            // 
            this.rawThickLabel.AutoSize = true;
            this.rawThickLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawThickLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rawThickLabel.Location = new System.Drawing.Point(323, 178);
            this.rawThickLabel.Name = "rawThickLabel";
            this.rawThickLabel.Size = new System.Drawing.Size(53, 19);
            this.rawThickLabel.TabIndex = 22;
            this.rawThickLabel.Text = "Thick:";
            // 
            // rawLengthTextBox
            // 
            this.rawLengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rawLengthTextBox.Location = new System.Drawing.Point(104, 171);
            this.rawLengthTextBox.Name = "rawLengthTextBox";
            this.rawLengthTextBox.Size = new System.Drawing.Size(67, 26);
            this.rawLengthTextBox.TabIndex = 23;
            // 
            // rawThickTextBox
            // 
            this.rawThickTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rawThickTextBox.Location = new System.Drawing.Point(385, 173);
            this.rawThickTextBox.Name = "rawThickTextBox";
            this.rawThickTextBox.Size = new System.Drawing.Size(67, 26);
            this.rawThickTextBox.TabIndex = 24;
            // 
            // rawWidthTextBox
            // 
            this.rawWidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rawWidthTextBox.Location = new System.Drawing.Point(247, 173);
            this.rawWidthTextBox.Name = "rawWidthTextBox";
            this.rawWidthTextBox.Size = new System.Drawing.Size(67, 26);
            this.rawWidthTextBox.TabIndex = 25;
            // 
            // rawMaterialNameTextBox
            // 
            this.rawMaterialNameTextBox.BackColor = System.Drawing.Color.White;
            this.rawMaterialNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rawMaterialNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rawMaterialNameTextBox.Location = new System.Drawing.Point(104, 81);
            this.rawMaterialNameTextBox.Name = "rawMaterialNameTextBox";
            this.rawMaterialNameTextBox.ReadOnly = true;
            this.rawMaterialNameTextBox.Size = new System.Drawing.Size(348, 26);
            this.rawMaterialNameTextBox.TabIndex = 27;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.createMaterialLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(483, 50);
            this.headerPanel.TabIndex = 0;
            // 
            // createMaterialLabel
            // 
            this.createMaterialLabel.AutoSize = true;
            this.createMaterialLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMaterialLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.createMaterialLabel.Location = new System.Drawing.Point(9, 14);
            this.createMaterialLabel.Name = "createMaterialLabel";
            this.createMaterialLabel.Size = new System.Drawing.Size(173, 25);
            this.createMaterialLabel.TabIndex = 3;
            this.createMaterialLabel.Text = "Create Material";
            // 
            // CreateMaterialForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 435);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Material";
            this.mainPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Label rawPriceLabel;
        private System.Windows.Forms.TextBox rawPriceTextBox;
        private System.Windows.Forms.Label rawLenghtLabel;
        private System.Windows.Forms.Label rawMaterialTypeLabel;
        private System.Windows.Forms.Label rawMaterialNameLabel;
        private System.Windows.Forms.Label rawThickLabel;
        private System.Windows.Forms.TextBox rawLengthTextBox;
        private System.Windows.Forms.TextBox rawThickTextBox;
        private System.Windows.Forms.TextBox rawWidthTextBox;
        private System.Windows.Forms.TextBox rawMaterialNameTextBox;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label createMaterialLabel;
        private System.Windows.Forms.ComboBox rawMaterialTypeComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox rawMaterialUnitComboBox;
        private System.Windows.Forms.Button createTypeButton;
        private System.Windows.Forms.Button createUnitButton;
        private System.Windows.Forms.Label rawUnitLabel;
        private System.Windows.Forms.Label rawWidthLabel;
    }
}