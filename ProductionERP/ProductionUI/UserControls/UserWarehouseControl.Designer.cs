namespace ProductionUI.UserControls
{
    partial class UserWarehouseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWarehouseControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.manufacturingCostLabel = new System.Windows.Forms.Label();
            this.rawMaterialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridColMaterialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.addStockButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialDataGridView)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 8);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 511);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(959, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 503);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 503);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.manufacturingCostLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(949, 60);
            this.panel5.TabIndex = 5;
            // 
            // manufacturingCostLabel
            // 
            this.manufacturingCostLabel.AutoSize = true;
            this.manufacturingCostLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.manufacturingCostLabel.Location = new System.Drawing.Point(15, 17);
            this.manufacturingCostLabel.Name = "manufacturingCostLabel";
            this.manufacturingCostLabel.Size = new System.Drawing.Size(231, 25);
            this.manufacturingCostLabel.TabIndex = 3;
            this.manufacturingCostLabel.Text = "Warehouse Materials";
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
            this.rawMaterialDataGridView.Location = new System.Drawing.Point(10, 142);
            this.rawMaterialDataGridView.Name = "rawMaterialDataGridView";
            this.rawMaterialDataGridView.ReadOnly = true;
            this.rawMaterialDataGridView.RowHeadersVisible = false;
            this.rawMaterialDataGridView.Size = new System.Drawing.Size(949, 369);
            this.rawMaterialDataGridView.TabIndex = 7;
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
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerPanel.Controls.Add(this.button1);
            this.headerPanel.Controls.Add(this.searchTextBox);
            this.headerPanel.Controls.Add(this.searchByComboBox);
            this.headerPanel.Controls.Add(this.searchByLabel);
            this.headerPanel.Controls.Add(this.addStockButton);
            this.headerPanel.Controls.Add(this.searchButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(10, 68);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(949, 74);
            this.headerPanel.TabIndex = 8;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Location = new System.Drawing.Point(596, 25);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(190, 20);
            this.searchTextBox.TabIndex = 21;
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Location = new System.Drawing.Point(428, 25);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(162, 21);
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
            this.addStockButton.Text = "Add Stock";
            this.addStockButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addStockButton.UseVisualStyleBackColor = false;
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
            this.searchButton.Location = new System.Drawing.Point(808, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(141, 74);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(150, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 74);
            this.button1.TabIndex = 22;
            this.button1.Text = "Transfer Stock";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UserWarehouseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rawMaterialDataGridView);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UserWarehouseControl";
            this.Size = new System.Drawing.Size(969, 521);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialDataGridView)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label manufacturingCostLabel;
        private System.Windows.Forms.DataGridView rawMaterialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColMaterialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColValue;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.Button addStockButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button1;
    }
}
