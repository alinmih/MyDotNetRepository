namespace ProductionUI.Forms.ManufacturingCosts
{
    partial class ManufacturingCostDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.salesOrdersOverviewLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.manufacturingCostCreateButton = new System.Windows.Forms.Button();
            this.manufacturingCostEditButton = new System.Windows.Forms.Button();
            this.manufacturingCostViewButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.closeLabel);
            this.panel1.Controls.Add(this.salesOrdersOverviewLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 42);
            this.panel1.TabIndex = 0;
            // 
            // closeLabel
            // 
            this.closeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.Color.White;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.closeLabel.Location = new System.Drawing.Point(1167, 5);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(30, 29);
            this.closeLabel.TabIndex = 18;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // salesOrdersOverviewLabel
            // 
            this.salesOrdersOverviewLabel.AutoSize = true;
            this.salesOrdersOverviewLabel.BackColor = System.Drawing.Color.White;
            this.salesOrdersOverviewLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOrdersOverviewLabel.ForeColor = System.Drawing.Color.DimGray;
            this.salesOrdersOverviewLabel.Location = new System.Drawing.Point(12, 9);
            this.salesOrdersOverviewLabel.Name = "salesOrdersOverviewLabel";
            this.salesOrdersOverviewLabel.Size = new System.Drawing.Size(331, 25);
            this.salesOrdersOverviewLabel.TabIndex = 17;
            this.salesOrdersOverviewLabel.Text = "Manufacturing Costs Overview";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.manufacturingCostCreateButton);
            this.flowLayoutPanel1.Controls.Add(this.manufacturingCostEditButton);
            this.flowLayoutPanel1.Controls.Add(this.manufacturingCostViewButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 39);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // manufacturingCostCreateButton
            // 
            this.manufacturingCostCreateButton.BackColor = System.Drawing.Color.White;
            this.manufacturingCostCreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manufacturingCostCreateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.manufacturingCostCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manufacturingCostCreateButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostCreateButton.ForeColor = System.Drawing.Color.DimGray;
            this.manufacturingCostCreateButton.Location = new System.Drawing.Point(3, 3);
            this.manufacturingCostCreateButton.Name = "manufacturingCostCreateButton";
            this.manufacturingCostCreateButton.Size = new System.Drawing.Size(121, 31);
            this.manufacturingCostCreateButton.TabIndex = 13;
            this.manufacturingCostCreateButton.Text = "Create";
            this.manufacturingCostCreateButton.UseVisualStyleBackColor = false;
            // 
            // manufacturingCostEditButton
            // 
            this.manufacturingCostEditButton.BackColor = System.Drawing.Color.White;
            this.manufacturingCostEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manufacturingCostEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manufacturingCostEditButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostEditButton.ForeColor = System.Drawing.Color.DimGray;
            this.manufacturingCostEditButton.Location = new System.Drawing.Point(130, 3);
            this.manufacturingCostEditButton.Name = "manufacturingCostEditButton";
            this.manufacturingCostEditButton.Size = new System.Drawing.Size(121, 31);
            this.manufacturingCostEditButton.TabIndex = 14;
            this.manufacturingCostEditButton.Text = "Modify";
            this.manufacturingCostEditButton.UseVisualStyleBackColor = false;
            // 
            // manufacturingCostViewButton
            // 
            this.manufacturingCostViewButton.BackColor = System.Drawing.Color.White;
            this.manufacturingCostViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manufacturingCostViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manufacturingCostViewButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostViewButton.ForeColor = System.Drawing.Color.DimGray;
            this.manufacturingCostViewButton.Location = new System.Drawing.Point(257, 3);
            this.manufacturingCostViewButton.Name = "manufacturingCostViewButton";
            this.manufacturingCostViewButton.Size = new System.Drawing.Size(121, 31);
            this.manufacturingCostViewButton.TabIndex = 15;
            this.manufacturingCostViewButton.Text = "View";
            this.manufacturingCostViewButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 577);
            this.panel2.TabIndex = 2;
            // 
            // ManufacturingCostDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManufacturingCostDashboard";
            this.Text = "Manufacturing Cost Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label salesOrdersOverviewLabel;
        private System.Windows.Forms.Button manufacturingCostCreateButton;
        private System.Windows.Forms.Button manufacturingCostEditButton;
        private System.Windows.Forms.Button manufacturingCostViewButton;
    }
}