namespace SampleConnectionSQL.PresentationLayer
{
    partial class MentenanceMaterialForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaterialNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMeasUnits = new System.Windows.Forms.ComboBox();
            this.comboBoxCustomers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(111, 221);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(195, 42);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(111, 92);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(195, 20);
            this.textBoxPrice.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(111, 55);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(195, 20);
            this.textBoxDescription.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description";
            // 
            // textBoxMaterialNumber
            // 
            this.textBoxMaterialNumber.Location = new System.Drawing.Point(111, 18);
            this.textBoxMaterialNumber.Name = "textBoxMaterialNumber";
            this.textBoxMaterialNumber.Size = new System.Drawing.Size(195, 20);
            this.textBoxMaterialNumber.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Material Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Measure Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer";
            // 
            // comboBoxMeasUnits
            // 
            this.comboBoxMeasUnits.FormattingEnabled = true;
            this.comboBoxMeasUnits.Location = new System.Drawing.Point(111, 166);
            this.comboBoxMeasUnits.Name = "comboBoxMeasUnits";
            this.comboBoxMeasUnits.Size = new System.Drawing.Size(195, 21);
            this.comboBoxMeasUnits.TabIndex = 8;
            // 
            // comboBoxCustomers
            // 
            this.comboBoxCustomers.FormattingEnabled = true;
            this.comboBoxCustomers.Location = new System.Drawing.Point(111, 129);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.Size = new System.Drawing.Size(195, 21);
            this.comboBoxCustomers.TabIndex = 7;
            // 
            // MentenanceMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 336);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMaterialNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMeasUnits);
            this.Controls.Add(this.comboBoxCustomers);
            this.Name = "MentenanceMaterialForm";
            this.Text = "MentenanceMaterialForm";
            this.Load += new System.EventHandler(this.MentenanceMaterialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxPrice;
        public System.Windows.Forms.TextBox textBoxDescription;
        public System.Windows.Forms.TextBox textBoxMaterialNumber;
        public System.Windows.Forms.ComboBox comboBoxMeasUnits;
        public System.Windows.Forms.ComboBox comboBoxCustomers;
    }
}