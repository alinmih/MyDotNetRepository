namespace ProductionUI.Forms.ManufacturingCosts
{
    partial class SelectMachines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectMachines));
            this.selectMachinesBottomPanel = new System.Windows.Forms.Panel();
            this.selectMachinesRigthPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.selectMachinesTopPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.selectMachinesLeftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.availableMachinesLabel = new System.Windows.Forms.Label();
            this.availableMachinesListbox = new System.Windows.Forms.ListBox();
            this.selectedMachinesListbox = new System.Windows.Forms.ListBox();
            this.selectedMachinesLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.removeSelectedButtton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.selectMachinesLabel = new System.Windows.Forms.Label();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectMachinesBottomPanel
            // 
            this.selectMachinesBottomPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectMachinesBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectMachinesBottomPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectMachinesBottomPanel.Location = new System.Drawing.Point(0, 596);
            this.selectMachinesBottomPanel.Name = "selectMachinesBottomPanel";
            this.selectMachinesBottomPanel.Size = new System.Drawing.Size(596, 10);
            this.selectMachinesBottomPanel.TabIndex = 0;
            // 
            // selectMachinesRigthPanel
            // 
            this.selectMachinesRigthPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectMachinesRigthPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectMachinesRigthPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectMachinesRigthPanel.Location = new System.Drawing.Point(586, 10);
            this.selectMachinesRigthPanel.Name = "selectMachinesRigthPanel";
            this.selectMachinesRigthPanel.Size = new System.Drawing.Size(10, 586);
            this.selectMachinesRigthPanel.TabIndex = 1;
            // 
            // selectMachinesTopPanel
            // 
            this.selectMachinesTopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectMachinesTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectMachinesTopPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectMachinesTopPanel.Location = new System.Drawing.Point(10, 0);
            this.selectMachinesTopPanel.Name = "selectMachinesTopPanel";
            this.selectMachinesTopPanel.Size = new System.Drawing.Size(586, 10);
            this.selectMachinesTopPanel.TabIndex = 1;
            // 
            // selectMachinesLeftPanel
            // 
            this.selectMachinesLeftPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectMachinesLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectMachinesLeftPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectMachinesLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.selectMachinesLeftPanel.Name = "selectMachinesLeftPanel";
            this.selectMachinesLeftPanel.Size = new System.Drawing.Size(10, 596);
            this.selectMachinesLeftPanel.TabIndex = 1;
            // 
            // availableMachinesLabel
            // 
            this.availableMachinesLabel.AutoSize = true;
            this.availableMachinesLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableMachinesLabel.Location = new System.Drawing.Point(40, 76);
            this.availableMachinesLabel.Name = "availableMachinesLabel";
            this.availableMachinesLabel.Size = new System.Drawing.Size(166, 19);
            this.availableMachinesLabel.TabIndex = 2;
            this.availableMachinesLabel.Text = "Available Machines";
            // 
            // availableMachinesListbox
            // 
            this.availableMachinesListbox.DisplayMember = "a,b,n";
            this.availableMachinesListbox.FormattingEnabled = true;
            this.availableMachinesListbox.ItemHeight = 19;
            this.availableMachinesListbox.Location = new System.Drawing.Point(44, 98);
            this.availableMachinesListbox.Name = "availableMachinesListbox";
            this.availableMachinesListbox.Size = new System.Drawing.Size(219, 365);
            this.availableMachinesListbox.TabIndex = 3;
            // 
            // selectedMachinesListbox
            // 
            this.selectedMachinesListbox.DisplayMember = "a,b,n";
            this.selectedMachinesListbox.FormattingEnabled = true;
            this.selectedMachinesListbox.ItemHeight = 19;
            this.selectedMachinesListbox.Location = new System.Drawing.Point(312, 98);
            this.selectedMachinesListbox.Name = "selectedMachinesListbox";
            this.selectedMachinesListbox.Size = new System.Drawing.Size(219, 365);
            this.selectedMachinesListbox.TabIndex = 3;
            // 
            // selectedMachinesLabel
            // 
            this.selectedMachinesLabel.AutoSize = true;
            this.selectedMachinesLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedMachinesLabel.Location = new System.Drawing.Point(308, 76);
            this.selectedMachinesLabel.Name = "selectedMachinesLabel";
            this.selectedMachinesLabel.Size = new System.Drawing.Size(158, 19);
            this.selectedMachinesLabel.TabIndex = 2;
            this.selectedMachinesLabel.Text = "Selected Machines";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(199, 525);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(199, 53);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // removeSelectedButtton
            // 
            this.removeSelectedButtton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.removeSelectedButtton.FlatAppearance.BorderSize = 0;
            this.removeSelectedButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedButtton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedButtton.ForeColor = System.Drawing.Color.White;
            this.removeSelectedButtton.Image = ((System.Drawing.Image)(resources.GetObject("removeSelectedButtton.Image")));
            this.removeSelectedButtton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeSelectedButtton.Location = new System.Drawing.Point(350, 469);
            this.removeSelectedButtton.Name = "removeSelectedButtton";
            this.removeSelectedButtton.Size = new System.Drawing.Size(181, 36);
            this.removeSelectedButtton.TabIndex = 4;
            this.removeSelectedButtton.Text = "Remove Selected";
            this.removeSelectedButtton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeSelectedButtton.UseVisualStyleBackColor = false;
            this.removeSelectedButtton.Click += new System.EventHandler(this.RemoveSelectedButtton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.moveUpButton.FlatAppearance.BorderSize = 0;
            this.moveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveUpButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUpButton.ForeColor = System.Drawing.Color.White;
            this.moveUpButton.Image = ((System.Drawing.Image)(resources.GetObject("moveUpButton.Image")));
            this.moveUpButton.Location = new System.Drawing.Point(537, 246);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(37, 32);
            this.moveUpButton.TabIndex = 4;
            this.moveUpButton.UseVisualStyleBackColor = false;
            this.moveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // moveDownButton
            // 
            this.moveDownButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.moveDownButton.FlatAppearance.BorderSize = 0;
            this.moveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveDownButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveDownButton.ForeColor = System.Drawing.Color.White;
            this.moveDownButton.Image = ((System.Drawing.Image)(resources.GetObject("moveDownButton.Image")));
            this.moveDownButton.Location = new System.Drawing.Point(537, 284);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(37, 32);
            this.moveDownButton.TabIndex = 4;
            this.moveDownButton.UseVisualStyleBackColor = false;
            this.moveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // selectMachinesLabel
            // 
            this.selectMachinesLabel.AutoSize = true;
            this.selectMachinesLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMachinesLabel.Location = new System.Drawing.Point(22, 33);
            this.selectMachinesLabel.Name = "selectMachinesLabel";
            this.selectMachinesLabel.Size = new System.Drawing.Size(272, 23);
            this.selectMachinesLabel.TabIndex = 2;
            this.selectMachinesLabel.Text = "Select Machine Technology";
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.moveLeftButton.FlatAppearance.BorderSize = 0;
            this.moveLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveLeftButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveLeftButton.ForeColor = System.Drawing.Color.White;
            this.moveLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("moveLeftButton.Image")));
            this.moveLeftButton.Location = new System.Drawing.Point(269, 284);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(37, 32);
            this.moveLeftButton.TabIndex = 4;
            this.moveLeftButton.UseVisualStyleBackColor = false;
            this.moveLeftButton.Click += new System.EventHandler(this.MoveLeftButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.moveRightButton.FlatAppearance.BorderSize = 0;
            this.moveRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveRightButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveRightButton.ForeColor = System.Drawing.Color.White;
            this.moveRightButton.Image = ((System.Drawing.Image)(resources.GetObject("moveRightButton.Image")));
            this.moveRightButton.Location = new System.Drawing.Point(269, 246);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(37, 32);
            this.moveRightButton.TabIndex = 4;
            this.moveRightButton.UseVisualStyleBackColor = false;
            this.moveRightButton.Click += new System.EventHandler(this.MoveRightButton_Click);
            // 
            // SelectMachines
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(596, 606);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveRightButton);
            this.Controls.Add(this.moveLeftButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.removeSelectedButtton);
            this.Controls.Add(this.selectedMachinesListbox);
            this.Controls.Add(this.availableMachinesListbox);
            this.Controls.Add(this.selectedMachinesLabel);
            this.Controls.Add(this.selectMachinesLabel);
            this.Controls.Add(this.availableMachinesLabel);
            this.Controls.Add(this.selectMachinesRigthPanel);
            this.Controls.Add(this.selectMachinesTopPanel);
            this.Controls.Add(this.selectMachinesLeftPanel);
            this.Controls.Add(this.selectMachinesBottomPanel);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectMachines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Machines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel selectMachinesBottomPanel;
        private System.Windows.Forms.FlowLayoutPanel selectMachinesRigthPanel;
        private System.Windows.Forms.FlowLayoutPanel selectMachinesTopPanel;
        private System.Windows.Forms.FlowLayoutPanel selectMachinesLeftPanel;
        private System.Windows.Forms.Label availableMachinesLabel;
        private System.Windows.Forms.ListBox availableMachinesListbox;
        private System.Windows.Forms.ListBox selectedMachinesListbox;
        private System.Windows.Forms.Label selectedMachinesLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button removeSelectedButtton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Label selectMachinesLabel;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveRightButton;
    }
}