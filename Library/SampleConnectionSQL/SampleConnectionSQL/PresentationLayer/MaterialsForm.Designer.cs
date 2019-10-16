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
            this.dataGridViewMaterials = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewMaterialsRaw = new System.Windows.Forms.DataGridView();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.dataGridViewUnits = new System.Windows.Forms.DataGridView();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonEditForm = new System.Windows.Forms.Button();
            this.buttonNewMaterial = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterialsRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMaterials
            // 
            this.dataGridViewMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterials.Location = new System.Drawing.Point(14, 13);
            this.dataGridViewMaterials.Name = "dataGridViewMaterials";
            this.dataGridViewMaterials.Size = new System.Drawing.Size(1024, 268);
            this.dataGridViewMaterials.TabIndex = 0;
            // 
            // comboBoxCustomers
            // 
            this.comboBoxCustomers.FormattingEnabled = true;
            this.comboBoxCustomers.Location = new System.Drawing.Point(1151, 136);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.Size = new System.Drawing.Size(195, 21);
            this.comboBoxCustomers.TabIndex = 1;
            // 
            // comboBoxMeasUnits
            // 
            this.comboBoxMeasUnits.FormattingEnabled = true;
            this.comboBoxMeasUnits.Location = new System.Drawing.Point(1151, 173);
            this.comboBoxMeasUnits.Name = "comboBoxMeasUnits";
            this.comboBoxMeasUnits.Size = new System.Drawing.Size(195, 21);
            this.comboBoxMeasUnits.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1094, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1075, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Measure Unit";
            // 
            // textBoxMaterialNumber
            // 
            this.textBoxMaterialNumber.Location = new System.Drawing.Point(1151, 25);
            this.textBoxMaterialNumber.Name = "textBoxMaterialNumber";
            this.textBoxMaterialNumber.Size = new System.Drawing.Size(195, 20);
            this.textBoxMaterialNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1061, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Material Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1085, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(1151, 62);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(195, 20);
            this.textBoxDescription.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1114, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(1151, 99);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(195, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1151, 228);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(195, 42);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewMaterialsRaw
            // 
            this.dataGridViewMaterialsRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterialsRaw.Location = new System.Drawing.Point(14, 320);
            this.dataGridViewMaterialsRaw.Name = "dataGridViewMaterialsRaw";
            this.dataGridViewMaterialsRaw.Size = new System.Drawing.Size(683, 484);
            this.dataGridViewMaterialsRaw.TabIndex = 7;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(711, 320);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(327, 199);
            this.dataGridViewCustomers.TabIndex = 7;
            // 
            // dataGridViewUnits
            // 
            this.dataGridViewUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnits.Location = new System.Drawing.Point(711, 535);
            this.dataGridViewUnits.Name = "dataGridViewUnits";
            this.dataGridViewUnits.Size = new System.Drawing.Size(327, 269);
            this.dataGridViewUnits.TabIndex = 7;
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(887, 287);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(151, 28);
            this.buttonEditProduct.TabIndex = 6;
            this.buttonEditProduct.Text = "Edit";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonEditForm
            // 
            this.buttonEditForm.Location = new System.Drawing.Point(12, 287);
            this.buttonEditForm.Name = "buttonEditForm";
            this.buttonEditForm.Size = new System.Drawing.Size(151, 28);
            this.buttonEditForm.TabIndex = 6;
            this.buttonEditForm.Text = "Edit from Form";
            this.buttonEditForm.UseVisualStyleBackColor = true;
            this.buttonEditForm.Click += new System.EventHandler(this.buttonEditForm_Click);
            // 
            // buttonNewMaterial
            // 
            this.buttonNewMaterial.Location = new System.Drawing.Point(169, 287);
            this.buttonNewMaterial.Name = "buttonNewMaterial";
            this.buttonNewMaterial.Size = new System.Drawing.Size(151, 28);
            this.buttonNewMaterial.TabIndex = 6;
            this.buttonNewMaterial.Text = "New";
            this.buttonNewMaterial.UseVisualStyleBackColor = true;
            this.buttonNewMaterial.Click += new System.EventHandler(this.buttonNewMaterial_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Brown;
            this.buttonDelete.Location = new System.Drawing.Point(326, 287);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(151, 28);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 816);
            this.Controls.Add(this.dataGridViewUnits);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.dataGridViewMaterialsRaw);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNewMaterial);
            this.Controls.Add(this.buttonEditForm);
            this.Controls.Add(this.buttonEditProduct);
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
            this.Controls.Add(this.dataGridViewMaterials);
            this.Name = "MaterialsForm";
            this.Text = "MaterialsForm";
            this.Load += new System.EventHandler(this.MaterialsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterialsRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMaterials;
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
        private System.Windows.Forms.DataGridView dataGridViewMaterialsRaw;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridView dataGridViewUnits;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonEditForm;
        private System.Windows.Forms.Button buttonNewMaterial;
        private System.Windows.Forms.Button buttonDelete;
    }
}