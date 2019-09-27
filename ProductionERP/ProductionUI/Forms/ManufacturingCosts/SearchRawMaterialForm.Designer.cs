namespace ProductionUI.Forms.ManufacturingCosts
{
    partial class SearchRawMaterialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchRawMaterialForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rawMaterialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridColMaterialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addStockButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(953, 10);
            this.topPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 628);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(953, 10);
            this.bottomPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(943, 10);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(10, 618);
            this.rightPanel.TabIndex = 3;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 10);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(10, 618);
            this.leftPanel.TabIndex = 4;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerPanel.Controls.Add(this.searchTextBox);
            this.headerPanel.Controls.Add(this.searchByComboBox);
            this.headerPanel.Controls.Add(this.searchByLabel);
            this.headerPanel.Controls.Add(this.addStockButton);
            this.headerPanel.Controls.Add(this.searchButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(10, 10);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(933, 74);
            this.headerPanel.TabIndex = 6;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Location = new System.Drawing.Point(596, 25);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(190, 26);
            this.searchTextBox.TabIndex = 21;
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Location = new System.Drawing.Point(428, 25);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(162, 27);
            this.searchByComboBox.TabIndex = 20;
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByLabel.ForeColor = System.Drawing.Color.White;
            this.searchByLabel.Location = new System.Drawing.Point(336, 28);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(87, 19);
            this.searchByLabel.TabIndex = 19;
            this.searchByLabel.Text = "Search By:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(792, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(141, 74);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.rawMaterialDataGridView);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(10, 84);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(933, 544);
            this.mainPanel.TabIndex = 7;
            // 
            // rawMaterialDataGridView
            // 
            this.rawMaterialDataGridView.AllowUserToAddRows = false;
            this.rawMaterialDataGridView.AllowUserToDeleteRows = false;
            this.rawMaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rawMaterialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridColMaterialNumber,
            this.dataGridColMaterialName,
            this.dataGridColLoc,
            this.dataGridColStock,
            this.dataGridColValue});
            this.rawMaterialDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawMaterialDataGridView.Location = new System.Drawing.Point(0, 0);
            this.rawMaterialDataGridView.Name = "rawMaterialDataGridView";
            this.rawMaterialDataGridView.ReadOnly = true;
            this.rawMaterialDataGridView.RowHeadersVisible = false;
            this.rawMaterialDataGridView.Size = new System.Drawing.Size(933, 544);
            this.rawMaterialDataGridView.TabIndex = 0;
            // 
            // dataGridColMaterialNumber
            // 
            this.dataGridColMaterialNumber.HeaderText = "Material No.";
            this.dataGridColMaterialNumber.Name = "dataGridColMaterialNumber";
            this.dataGridColMaterialNumber.ReadOnly = true;
            // 
            // dataGridColMaterialName
            // 
            this.dataGridColMaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridColMaterialName.HeaderText = "Name";
            this.dataGridColMaterialName.Name = "dataGridColMaterialName";
            this.dataGridColMaterialName.ReadOnly = true;
            // 
            // dataGridColLoc
            // 
            this.dataGridColLoc.HeaderText = "Location";
            this.dataGridColLoc.Name = "dataGridColLoc";
            this.dataGridColLoc.ReadOnly = true;
            // 
            // dataGridColStock
            // 
            this.dataGridColStock.HeaderText = "Stock";
            this.dataGridColStock.Name = "dataGridColStock";
            this.dataGridColStock.ReadOnly = true;
            // 
            // dataGridColValue
            // 
            this.dataGridColValue.HeaderText = "Value";
            this.dataGridColValue.Name = "dataGridColValue";
            this.dataGridColValue.ReadOnly = true;
            this.dataGridColValue.Width = 200;
            // 
            // addStockButton
            // 
            this.addStockButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addStockButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addStockButton.FlatAppearance.BorderSize = 0;
            this.addStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStockButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockButton.ForeColor = System.Drawing.Color.White;
            this.addStockButton.Image = ((System.Drawing.Image)(resources.GetObject("addStockButton.Image")));
            this.addStockButton.Location = new System.Drawing.Point(0, 0);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(150, 74);
            this.addStockButton.TabIndex = 18;
            this.addStockButton.Text = "Add";
            this.addStockButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addStockButton.UseVisualStyleBackColor = false;
            // 
            // SearchRawMaterial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 638);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchRawMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Raw Material";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView rawMaterialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColMaterialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColValue;
        private System.Windows.Forms.Button addStockButton;
    }
}