namespace ProductionUI.UserControls.AdminArea
{
    partial class UserAdminMachines
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
            this.centerPanel = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.machineListPanel = new System.Windows.Forms.Panel();
            this.machineListMainPanel = new System.Windows.Forms.Panel();
            this.machineListGrid = new System.Windows.Forms.DataGridView();
            this.machineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineHourRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineListHeaderPanel = new System.Windows.Forms.Panel();
            this.machineListLabel = new System.Windows.Forms.Label();
            this.machineDeleteButton = new System.Windows.Forms.Button();
            this.machineModifyButton = new System.Windows.Forms.Button();
            this.machineCreateButton = new System.Windows.Forms.Button();
            this.machineCatPanel = new System.Windows.Forms.Panel();
            this.machineCatMainPanel = new System.Windows.Forms.Panel();
            this.machineCatGrid = new System.Windows.Forms.DataGridView();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.separationPanel = new System.Windows.Forms.Panel();
            this.machineCatHeaderPanel = new System.Windows.Forms.Panel();
            this.machineCatLabel = new System.Windows.Forms.Label();
            this.catDeleteButton = new System.Windows.Forms.Button();
            this.catModifyButton = new System.Windows.Forms.Button();
            this.catCreateButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.manufacturingCostLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.centerPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.machineListPanel.SuspendLayout();
            this.machineListMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machineListGrid)).BeginInit();
            this.machineListHeaderPanel.SuspendLayout();
            this.machineCatPanel.SuspendLayout();
            this.machineCatMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machineCatGrid)).BeginInit();
            this.machineCatHeaderPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // centerPanel
            // 
            this.centerPanel.AutoScroll = true;
            this.centerPanel.BackColor = System.Drawing.Color.White;
            this.centerPanel.Controls.Add(this.userPanel);
            this.centerPanel.Controls.Add(this.bottomPanel);
            this.centerPanel.Controls.Add(this.topPanel);
            this.centerPanel.Controls.Add(this.rightPanel);
            this.centerPanel.Controls.Add(this.leftPanel);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1003, 792);
            this.centerPanel.TabIndex = 14;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.mainPanel);
            this.userPanel.Controls.Add(this.headerPanel);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(10, 10);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(983, 772);
            this.userPanel.TabIndex = 4;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.machineListPanel);
            this.mainPanel.Controls.Add(this.machineCatPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(983, 732);
            this.mainPanel.TabIndex = 1;
            // 
            // machineListPanel
            // 
            this.machineListPanel.Controls.Add(this.machineListMainPanel);
            this.machineListPanel.Controls.Add(this.machineListHeaderPanel);
            this.machineListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineListPanel.Location = new System.Drawing.Point(0, 0);
            this.machineListPanel.Name = "machineListPanel";
            this.machineListPanel.Size = new System.Drawing.Size(600, 732);
            this.machineListPanel.TabIndex = 1;
            // 
            // machineListMainPanel
            // 
            this.machineListMainPanel.Controls.Add(this.machineListGrid);
            this.machineListMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineListMainPanel.Location = new System.Drawing.Point(0, 66);
            this.machineListMainPanel.Name = "machineListMainPanel";
            this.machineListMainPanel.Size = new System.Drawing.Size(600, 666);
            this.machineListMainPanel.TabIndex = 1;
            // 
            // machineListGrid
            // 
            this.machineListGrid.AllowUserToAddRows = false;
            this.machineListGrid.AllowUserToDeleteRows = false;
            this.machineListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.machineListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machineName,
            this.machineCategoryName,
            this.machineHourRate});
            this.machineListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineListGrid.Location = new System.Drawing.Point(0, 0);
            this.machineListGrid.Name = "machineListGrid";
            this.machineListGrid.ReadOnly = true;
            this.machineListGrid.RowHeadersVisible = false;
            this.machineListGrid.Size = new System.Drawing.Size(600, 666);
            this.machineListGrid.TabIndex = 2;
            // 
            // machineName
            // 
            this.machineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.machineName.HeaderText = "Name";
            this.machineName.Name = "machineName";
            this.machineName.ReadOnly = true;
            // 
            // machineCategoryName
            // 
            this.machineCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.machineCategoryName.HeaderText = "Machine Category";
            this.machineCategoryName.Name = "machineCategoryName";
            this.machineCategoryName.ReadOnly = true;
            // 
            // machineHourRate
            // 
            this.machineHourRate.HeaderText = "Hour Rate";
            this.machineHourRate.Name = "machineHourRate";
            this.machineHourRate.ReadOnly = true;
            // 
            // machineListHeaderPanel
            // 
            this.machineListHeaderPanel.Controls.Add(this.machineListLabel);
            this.machineListHeaderPanel.Controls.Add(this.machineDeleteButton);
            this.machineListHeaderPanel.Controls.Add(this.machineModifyButton);
            this.machineListHeaderPanel.Controls.Add(this.machineCreateButton);
            this.machineListHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.machineListHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.machineListHeaderPanel.Name = "machineListHeaderPanel";
            this.machineListHeaderPanel.Size = new System.Drawing.Size(600, 66);
            this.machineListHeaderPanel.TabIndex = 0;
            // 
            // machineListLabel
            // 
            this.machineListLabel.AutoSize = true;
            this.machineListLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineListLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.machineListLabel.Location = new System.Drawing.Point(7, 3);
            this.machineListLabel.Name = "machineListLabel";
            this.machineListLabel.Size = new System.Drawing.Size(121, 19);
            this.machineListLabel.TabIndex = 24;
            this.machineListLabel.Text = "Machines List";
            // 
            // machineDeleteButton
            // 
            this.machineDeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.machineDeleteButton.FlatAppearance.BorderSize = 0;
            this.machineDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.machineDeleteButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineDeleteButton.ForeColor = System.Drawing.Color.White;
            this.machineDeleteButton.Location = new System.Drawing.Point(261, 27);
            this.machineDeleteButton.Name = "machineDeleteButton";
            this.machineDeleteButton.Size = new System.Drawing.Size(121, 31);
            this.machineDeleteButton.TabIndex = 25;
            this.machineDeleteButton.Text = "Delete";
            this.machineDeleteButton.UseVisualStyleBackColor = false;
            // 
            // machineModifyButton
            // 
            this.machineModifyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.machineModifyButton.FlatAppearance.BorderSize = 0;
            this.machineModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.machineModifyButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineModifyButton.ForeColor = System.Drawing.Color.White;
            this.machineModifyButton.Location = new System.Drawing.Point(134, 27);
            this.machineModifyButton.Name = "machineModifyButton";
            this.machineModifyButton.Size = new System.Drawing.Size(121, 31);
            this.machineModifyButton.TabIndex = 26;
            this.machineModifyButton.Text = "Modify";
            this.machineModifyButton.UseVisualStyleBackColor = false;
            this.machineModifyButton.Click += new System.EventHandler(this.MachineModifyButton_Click);
            // 
            // machineCreateButton
            // 
            this.machineCreateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.machineCreateButton.FlatAppearance.BorderSize = 0;
            this.machineCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.machineCreateButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineCreateButton.ForeColor = System.Drawing.Color.White;
            this.machineCreateButton.Location = new System.Drawing.Point(7, 27);
            this.machineCreateButton.Name = "machineCreateButton";
            this.machineCreateButton.Size = new System.Drawing.Size(121, 31);
            this.machineCreateButton.TabIndex = 27;
            this.machineCreateButton.Text = "Create";
            this.machineCreateButton.UseVisualStyleBackColor = false;
            this.machineCreateButton.Click += new System.EventHandler(this.MachineCreateButton_Click);
            // 
            // machineCatPanel
            // 
            this.machineCatPanel.Controls.Add(this.machineCatMainPanel);
            this.machineCatPanel.Controls.Add(this.separationPanel);
            this.machineCatPanel.Controls.Add(this.machineCatHeaderPanel);
            this.machineCatPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.machineCatPanel.Location = new System.Drawing.Point(600, 0);
            this.machineCatPanel.Name = "machineCatPanel";
            this.machineCatPanel.Size = new System.Drawing.Size(383, 732);
            this.machineCatPanel.TabIndex = 0;
            // 
            // machineCatMainPanel
            // 
            this.machineCatMainPanel.Controls.Add(this.machineCatGrid);
            this.machineCatMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineCatMainPanel.Location = new System.Drawing.Point(10, 66);
            this.machineCatMainPanel.Name = "machineCatMainPanel";
            this.machineCatMainPanel.Size = new System.Drawing.Size(373, 666);
            this.machineCatMainPanel.TabIndex = 2;
            // 
            // machineCatGrid
            // 
            this.machineCatGrid.AllowUserToAddRows = false;
            this.machineCatGrid.AllowUserToDeleteRows = false;
            this.machineCatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.machineCatGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryName});
            this.machineCatGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineCatGrid.Location = new System.Drawing.Point(0, 0);
            this.machineCatGrid.Name = "machineCatGrid";
            this.machineCatGrid.ReadOnly = true;
            this.machineCatGrid.RowHeadersVisible = false;
            this.machineCatGrid.Size = new System.Drawing.Size(373, 666);
            this.machineCatGrid.TabIndex = 3;
            // 
            // categoryName
            // 
            this.categoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryName.HeaderText = "Machine Category Name";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // separationPanel
            // 
            this.separationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.separationPanel.Location = new System.Drawing.Point(0, 66);
            this.separationPanel.Name = "separationPanel";
            this.separationPanel.Size = new System.Drawing.Size(10, 666);
            this.separationPanel.TabIndex = 1;
            // 
            // machineCatHeaderPanel
            // 
            this.machineCatHeaderPanel.Controls.Add(this.machineCatLabel);
            this.machineCatHeaderPanel.Controls.Add(this.catDeleteButton);
            this.machineCatHeaderPanel.Controls.Add(this.catModifyButton);
            this.machineCatHeaderPanel.Controls.Add(this.catCreateButton);
            this.machineCatHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.machineCatHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.machineCatHeaderPanel.Name = "machineCatHeaderPanel";
            this.machineCatHeaderPanel.Size = new System.Drawing.Size(383, 66);
            this.machineCatHeaderPanel.TabIndex = 0;
            // 
            // machineCatLabel
            // 
            this.machineCatLabel.AutoSize = true;
            this.machineCatLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineCatLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.machineCatLabel.Location = new System.Drawing.Point(6, 3);
            this.machineCatLabel.Name = "machineCatLabel";
            this.machineCatLabel.Size = new System.Drawing.Size(177, 19);
            this.machineCatLabel.TabIndex = 30;
            this.machineCatLabel.Text = "Machines Categories";
            // 
            // catDeleteButton
            // 
            this.catDeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.catDeleteButton.FlatAppearance.BorderSize = 0;
            this.catDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catDeleteButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catDeleteButton.ForeColor = System.Drawing.Color.White;
            this.catDeleteButton.Location = new System.Drawing.Point(248, 25);
            this.catDeleteButton.Name = "catDeleteButton";
            this.catDeleteButton.Size = new System.Drawing.Size(108, 31);
            this.catDeleteButton.TabIndex = 31;
            this.catDeleteButton.Text = "Delete";
            this.catDeleteButton.UseVisualStyleBackColor = false;
            // 
            // catModifyButton
            // 
            this.catModifyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.catModifyButton.FlatAppearance.BorderSize = 0;
            this.catModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catModifyButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catModifyButton.ForeColor = System.Drawing.Color.White;
            this.catModifyButton.Location = new System.Drawing.Point(129, 25);
            this.catModifyButton.Name = "catModifyButton";
            this.catModifyButton.Size = new System.Drawing.Size(108, 31);
            this.catModifyButton.TabIndex = 32;
            this.catModifyButton.Text = "Modify";
            this.catModifyButton.UseVisualStyleBackColor = false;
            this.catModifyButton.Click += new System.EventHandler(this.CatModifyButton_Click);
            // 
            // catCreateButton
            // 
            this.catCreateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.catCreateButton.FlatAppearance.BorderSize = 0;
            this.catCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catCreateButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catCreateButton.ForeColor = System.Drawing.Color.White;
            this.catCreateButton.Location = new System.Drawing.Point(10, 25);
            this.catCreateButton.Name = "catCreateButton";
            this.catCreateButton.Size = new System.Drawing.Size(108, 31);
            this.catCreateButton.TabIndex = 33;
            this.catCreateButton.Text = "Create";
            this.catCreateButton.UseVisualStyleBackColor = false;
            this.catCreateButton.Click += new System.EventHandler(this.CatCreateButton_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.manufacturingCostLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(983, 40);
            this.headerPanel.TabIndex = 0;
            // 
            // manufacturingCostLabel
            // 
            this.manufacturingCostLabel.AutoSize = true;
            this.manufacturingCostLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.manufacturingCostLabel.Location = new System.Drawing.Point(6, 3);
            this.manufacturingCostLabel.Name = "manufacturingCostLabel";
            this.manufacturingCostLabel.Size = new System.Drawing.Size(298, 25);
            this.manufacturingCostLabel.TabIndex = 18;
            this.manufacturingCostLabel.Text = "Machine Management Area";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(10, 782);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(983, 10);
            this.bottomPanel.TabIndex = 3;
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(10, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(983, 10);
            this.topPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(993, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(10, 792);
            this.rightPanel.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(10, 792);
            this.leftPanel.TabIndex = 0;
            // 
            // UserAdminMachines
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(824, 0);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.centerPanel);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserAdminMachines";
            this.Size = new System.Drawing.Size(1003, 792);
            this.centerPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.machineListPanel.ResumeLayout(false);
            this.machineListMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.machineListGrid)).EndInit();
            this.machineListHeaderPanel.ResumeLayout(false);
            this.machineListHeaderPanel.PerformLayout();
            this.machineCatPanel.ResumeLayout(false);
            this.machineCatMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.machineCatGrid)).EndInit();
            this.machineCatHeaderPanel.ResumeLayout(false);
            this.machineCatHeaderPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label manufacturingCostLabel;
        private System.Windows.Forms.Panel machineListPanel;
        private System.Windows.Forms.Panel machineListHeaderPanel;
        private System.Windows.Forms.Panel machineCatPanel;
        private System.Windows.Forms.Panel machineListMainPanel;
        private System.Windows.Forms.Panel machineCatMainPanel;
        private System.Windows.Forms.Panel separationPanel;
        private System.Windows.Forms.Panel machineCatHeaderPanel;
        private System.Windows.Forms.Label machineListLabel;
        private System.Windows.Forms.Button machineDeleteButton;
        private System.Windows.Forms.Button machineModifyButton;
        private System.Windows.Forms.Button machineCreateButton;
        private System.Windows.Forms.Label machineCatLabel;
        private System.Windows.Forms.Button catDeleteButton;
        private System.Windows.Forms.Button catModifyButton;
        private System.Windows.Forms.Button catCreateButton;
        private System.Windows.Forms.DataGridView machineListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineHourRate;
        private System.Windows.Forms.DataGridView machineCatGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
    }
}
