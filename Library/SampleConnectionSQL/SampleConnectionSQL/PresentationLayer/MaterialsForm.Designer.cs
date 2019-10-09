namespace SampleConnectionSQL.PresentationLayer
{
    partial class MaterialsForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxCustomers = new System.Windows.Forms.ComboBox();
            this.comboBoxMeasUnits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaterialNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(541, 605);
            this.dataGridView.TabIndex = 0;
            // 
            // comboBoxCustomers
            // 
            this.comboBoxCustomers.FormattingEnabled = true;
            this.comboBoxCustomers.Location = new System.Drawing.Point(651, 147);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.Size = new System.Drawing.Size(195, 21);
            this.comboBoxCustomers.TabIndex = 1;
            // 
            // comboBoxMeasUnits
            // 
            this.comboBoxMeasUnits.FormattingEnabled = true;
            this.comboBoxMeasUnits.Location = new System.Drawing.Point(651, 184);
            this.comboBoxMeasUnits.Name = "comboBoxMeasUnits";
            this.comboBoxMeasUnits.Size = new System.Drawing.Size(195, 21);
            this.comboBoxMeasUnits.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Measure Unit";
            // 
            // textBoxMaterialNumber
            // 
            this.textBoxMaterialNumber.Location = new System.Drawing.Point(651, 36);
            this.textBoxMaterialNumber.Name = "textBoxMaterialNumber";
            this.textBoxMaterialNumber.Size = new System.Drawing.Size(195, 20);
            this.textBoxMaterialNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Material Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(651, 73);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(195, 20);
            this.textBoxDescription.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(651, 110);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(195, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(651, 239);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(195, 42);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 630);
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
            this.Controls.Add(this.dataGridView);
            this.Name = "MaterialsForm";
            this.Text = "MaterialsForm";
            this.Load += new System.EventHandler(this.MaterialsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBoxCustomers;
        private System.Windows.Forms.ComboBox comboBoxMeasUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaterialNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonSave;
    }
}