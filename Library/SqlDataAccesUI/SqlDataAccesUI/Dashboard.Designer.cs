namespace SqlDataAccesUI
{
    partial class Dashboard
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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameTextIns = new System.Windows.Forms.TextBox();
            this.nameLabelIns = new System.Windows.Forms.Label();
            this.locationTextIns = new System.Windows.Forms.TextBox();
            this.locationLabelIns = new System.Windows.Forms.Label();
            this.phoneTextIns = new System.Windows.Forms.TextBox();
            this.phoneLabelIns = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 25;
            this.peopleFoundListbox.Location = new System.Drawing.Point(12, 125);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(380, 354);
            this.peopleFoundListbox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(108, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(184, 38);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(208, 31);
            this.nameText.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(133, 87);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 32);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nameTextIns
            // 
            this.nameTextIns.Location = new System.Drawing.Point(113, 517);
            this.nameTextIns.Name = "nameTextIns";
            this.nameTextIns.Size = new System.Drawing.Size(208, 31);
            this.nameTextIns.TabIndex = 5;
            // 
            // nameLabelIns
            // 
            this.nameLabelIns.AutoSize = true;
            this.nameLabelIns.Location = new System.Drawing.Point(15, 520);
            this.nameLabelIns.Name = "nameLabelIns";
            this.nameLabelIns.Size = new System.Drawing.Size(68, 25);
            this.nameLabelIns.TabIndex = 4;
            this.nameLabelIns.Text = "Name";
            // 
            // locationTextIns
            // 
            this.locationTextIns.Location = new System.Drawing.Point(113, 554);
            this.locationTextIns.Name = "locationTextIns";
            this.locationTextIns.Size = new System.Drawing.Size(208, 31);
            this.locationTextIns.TabIndex = 7;
            // 
            // locationLabelIns
            // 
            this.locationLabelIns.AutoSize = true;
            this.locationLabelIns.Location = new System.Drawing.Point(15, 557);
            this.locationLabelIns.Name = "locationLabelIns";
            this.locationLabelIns.Size = new System.Drawing.Size(94, 25);
            this.locationLabelIns.TabIndex = 6;
            this.locationLabelIns.Text = "Location";
            // 
            // phoneTextIns
            // 
            this.phoneTextIns.Location = new System.Drawing.Point(113, 591);
            this.phoneTextIns.Name = "phoneTextIns";
            this.phoneTextIns.Size = new System.Drawing.Size(208, 31);
            this.phoneTextIns.TabIndex = 9;
            // 
            // phoneLabelIns
            // 
            this.phoneLabelIns.AutoSize = true;
            this.phoneLabelIns.Location = new System.Drawing.Point(15, 594);
            this.phoneLabelIns.Name = "phoneLabelIns";
            this.phoneLabelIns.Size = new System.Drawing.Size(74, 25);
            this.phoneLabelIns.TabIndex = 8;
            this.phoneLabelIns.Text = "Phone";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(133, 640);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(100, 32);
            this.insertButton.TabIndex = 10;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 862);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.phoneTextIns);
            this.Controls.Add(this.phoneLabelIns);
            this.Controls.Add(this.locationTextIns);
            this.Controls.Add(this.locationLabelIns);
            this.Controls.Add(this.nameTextIns);
            this.Controls.Add(this.nameLabelIns);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.peopleFoundListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Acces Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox nameTextIns;
        private System.Windows.Forms.Label nameLabelIns;
        private System.Windows.Forms.TextBox locationTextIns;
        private System.Windows.Forms.Label locationLabelIns;
        private System.Windows.Forms.TextBox phoneTextIns;
        private System.Windows.Forms.Label phoneLabelIns;
        private System.Windows.Forms.Button insertButton;
    }
}

