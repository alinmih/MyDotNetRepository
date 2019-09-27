namespace ProductionUI.Forms.AdminArea
{
    partial class CreateWarehouseForm
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
            this.createWarehouseLabel = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.saveWarehouseButton = new System.Windows.Forms.Button();
            this.warehouseNameLabel = new System.Windows.Forms.Label();
            this.warehouseNameTextBox = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.warehouseNumberTextBox = new System.Windows.Forms.TextBox();
            this.warehouseNumberLabel = new System.Windows.Forms.Label();
            this.userPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createWarehouseLabel
            // 
            this.createWarehouseLabel.AutoSize = true;
            this.createWarehouseLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createWarehouseLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.createWarehouseLabel.Location = new System.Drawing.Point(14, 20);
            this.createWarehouseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createWarehouseLabel.Name = "createWarehouseLabel";
            this.createWarehouseLabel.Size = new System.Drawing.Size(200, 25);
            this.createWarehouseLabel.TabIndex = 3;
            this.createWarehouseLabel.Text = "Create Warehouse";
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.White;
            this.userPanel.Controls.Add(this.saveWarehouseButton);
            this.userPanel.Controls.Add(this.warehouseNumberLabel);
            this.userPanel.Controls.Add(this.warehouseNameLabel);
            this.userPanel.Controls.Add(this.warehouseNumberTextBox);
            this.userPanel.Controls.Add(this.warehouseNameTextBox);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(0, 73);
            this.userPanel.Margin = new System.Windows.Forms.Padding(4);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(484, 225);
            this.userPanel.TabIndex = 1;
            // 
            // saveWarehouseButton
            // 
            this.saveWarehouseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveWarehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveWarehouseButton.ForeColor = System.Drawing.Color.White;
            this.saveWarehouseButton.Location = new System.Drawing.Point(174, 100);
            this.saveWarehouseButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveWarehouseButton.Name = "saveWarehouseButton";
            this.saveWarehouseButton.Size = new System.Drawing.Size(215, 52);
            this.saveWarehouseButton.TabIndex = 43;
            this.saveWarehouseButton.Text = "Save";
            this.saveWarehouseButton.UseVisualStyleBackColor = false;
            // 
            // warehouseNameLabel
            // 
            this.warehouseNameLabel.AutoSize = true;
            this.warehouseNameLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.warehouseNameLabel.Location = new System.Drawing.Point(34, 56);
            this.warehouseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warehouseNameLabel.Name = "warehouseNameLabel";
            this.warehouseNameLabel.Size = new System.Drawing.Size(58, 19);
            this.warehouseNameLabel.TabIndex = 29;
            this.warehouseNameLabel.Text = "Name:";
            // 
            // warehouseNameTextBox
            // 
            this.warehouseNameTextBox.BackColor = System.Drawing.Color.White;
            this.warehouseNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.warehouseNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.warehouseNameTextBox.Location = new System.Drawing.Point(100, 53);
            this.warehouseNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseNameTextBox.Name = "warehouseNameTextBox";
            this.warehouseNameTextBox.ReadOnly = true;
            this.warehouseNameTextBox.Size = new System.Drawing.Size(289, 26);
            this.warehouseNameTextBox.TabIndex = 27;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.createWarehouseLabel);
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
            this.mainPanel.TabIndex = 24;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(10, 308);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(484, 10);
            this.bottomPanel.TabIndex = 23;
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(10, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(484, 10);
            this.topPanel.TabIndex = 22;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(494, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(10, 318);
            this.rightPanel.TabIndex = 21;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(10, 318);
            this.leftPanel.TabIndex = 20;
            // 
            // warehouseNumberTextBox
            // 
            this.warehouseNumberTextBox.BackColor = System.Drawing.Color.White;
            this.warehouseNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.warehouseNumberTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.warehouseNumberTextBox.Location = new System.Drawing.Point(100, 19);
            this.warehouseNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseNumberTextBox.Name = "warehouseNumberTextBox";
            this.warehouseNumberTextBox.ReadOnly = true;
            this.warehouseNumberTextBox.Size = new System.Drawing.Size(114, 26);
            this.warehouseNumberTextBox.TabIndex = 27;
            // 
            // warehouseNumberLabel
            // 
            this.warehouseNumberLabel.AutoSize = true;
            this.warehouseNumberLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.warehouseNumberLabel.Location = new System.Drawing.Point(17, 22);
            this.warehouseNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warehouseNumberLabel.Name = "warehouseNumberLabel";
            this.warehouseNumberLabel.Size = new System.Drawing.Size(75, 19);
            this.warehouseNumberLabel.TabIndex = 29;
            this.warehouseNumberLabel.Text = "Number:";
            // 
            // CreateWarehouseForm
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
            this.Name = "CreateWarehouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Warehouse";
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label createWarehouseLabel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button saveWarehouseButton;
        private System.Windows.Forms.Label warehouseNameLabel;
        private System.Windows.Forms.TextBox warehouseNameTextBox;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label warehouseNumberLabel;
        private System.Windows.Forms.TextBox warehouseNumberTextBox;
    }
}