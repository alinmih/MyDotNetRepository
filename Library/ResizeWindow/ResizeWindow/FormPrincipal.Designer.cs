namespace ResizeWindow
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.principalPanel = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.menuMinButton = new System.Windows.Forms.PictureBox();
            this.maximizeButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.normalViewButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.labelAbout = new System.Windows.Forms.Label();
            this.etcButton = new System.Windows.Forms.Button();
            this.purchasingButton = new System.Windows.Forms.Button();
            this.shippingButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.principalPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuMinButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalViewButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // principalPanel
            // 
            this.principalPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.principalPanel.Controls.Add(this.panelContent);
            this.principalPanel.Controls.Add(this.titlePanel);
            this.principalPanel.Controls.Add(this.menuVertical);
            this.principalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.principalPanel.Location = new System.Drawing.Point(0, 0);
            this.principalPanel.Name = "principalPanel";
            this.principalPanel.Size = new System.Drawing.Size(1100, 600);
            this.principalPanel.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Honeydew;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(850, 550);
            this.panelContent.TabIndex = 2;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.Orchid;
            this.titlePanel.Controls.Add(this.menuMinButton);
            this.titlePanel.Controls.Add(this.maximizeButton);
            this.titlePanel.Controls.Add(this.minimizeButton);
            this.titlePanel.Controls.Add(this.normalViewButton);
            this.titlePanel.Controls.Add(this.exitButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(250, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(850, 50);
            this.titlePanel.TabIndex = 1;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            // 
            // menuMinButton
            // 
            this.menuMinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuMinButton.Image = ((System.Drawing.Image)(resources.GetObject("menuMinButton.Image")));
            this.menuMinButton.Location = new System.Drawing.Point(6, 11);
            this.menuMinButton.Name = "menuMinButton";
            this.menuMinButton.Size = new System.Drawing.Size(30, 29);
            this.menuMinButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuMinButton.TabIndex = 5;
            this.menuMinButton.TabStop = false;
            this.menuMinButton.Click += new System.EventHandler(this.menuMinButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.Location = new System.Drawing.Point(700, 12);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(30, 29);
            this.maximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeButton.TabIndex = 4;
            this.maximizeButton.TabStop = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(736, 11);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(30, 29);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // normalViewButton
            // 
            this.normalViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.normalViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.normalViewButton.Image = ((System.Drawing.Image)(resources.GetObject("normalViewButton.Image")));
            this.normalViewButton.Location = new System.Drawing.Point(772, 12);
            this.normalViewButton.Name = "normalViewButton";
            this.normalViewButton.Size = new System.Drawing.Size(30, 29);
            this.normalViewButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.normalViewButton.TabIndex = 2;
            this.normalViewButton.TabStop = false;
            this.normalViewButton.Visible = false;
            this.normalViewButton.Click += new System.EventHandler(this.normalViewButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(808, 11);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 29);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 3;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.Turquoise;
            this.menuVertical.Controls.Add(this.labelAbout);
            this.menuVertical.Controls.Add(this.etcButton);
            this.menuVertical.Controls.Add(this.purchasingButton);
            this.menuVertical.Controls.Add(this.shippingButton);
            this.menuVertical.Controls.Add(this.customersButton);
            this.menuVertical.Controls.Add(this.salesButton);
            this.menuVertical.Controls.Add(this.dashboardButton);
            this.menuVertical.Controls.Add(this.productsButton);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 600);
            this.menuVertical.TabIndex = 0;
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbout.Location = new System.Drawing.Point(8, 567);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(20, 24);
            this.labelAbout.TabIndex = 6;
            this.labelAbout.Text = "?";
            this.labelAbout.Click += new System.EventHandler(this.aboutBox_Click);
            // 
            // etcButton
            // 
            this.etcButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.etcButton.FlatAppearance.BorderSize = 0;
            this.etcButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.etcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.etcButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etcButton.Image = ((System.Drawing.Image)(resources.GetObject("etcButton.Image")));
            this.etcButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.etcButton.Location = new System.Drawing.Point(0, 313);
            this.etcButton.Name = "etcButton";
            this.etcButton.Size = new System.Drawing.Size(250, 30);
            this.etcButton.TabIndex = 3;
            this.etcButton.Text = "       Etc";
            this.etcButton.UseVisualStyleBackColor = true;
            // 
            // purchasingButton
            // 
            this.purchasingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchasingButton.FlatAppearance.BorderSize = 0;
            this.purchasingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.purchasingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchasingButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasingButton.Image = ((System.Drawing.Image)(resources.GetObject("purchasingButton.Image")));
            this.purchasingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchasingButton.Location = new System.Drawing.Point(0, 277);
            this.purchasingButton.Name = "purchasingButton";
            this.purchasingButton.Size = new System.Drawing.Size(250, 30);
            this.purchasingButton.TabIndex = 4;
            this.purchasingButton.Text = "       Purchasing";
            this.purchasingButton.UseVisualStyleBackColor = true;
            // 
            // shippingButton
            // 
            this.shippingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shippingButton.FlatAppearance.BorderSize = 0;
            this.shippingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.shippingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shippingButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingButton.Image = ((System.Drawing.Image)(resources.GetObject("shippingButton.Image")));
            this.shippingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shippingButton.Location = new System.Drawing.Point(0, 241);
            this.shippingButton.Name = "shippingButton";
            this.shippingButton.Size = new System.Drawing.Size(250, 30);
            this.shippingButton.TabIndex = 5;
            this.shippingButton.Text = "       Shipping";
            this.shippingButton.UseVisualStyleBackColor = true;
            // 
            // customersButton
            // 
            this.customersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customersButton.FlatAppearance.BorderSize = 0;
            this.customersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersButton.Image = ((System.Drawing.Image)(resources.GetObject("customersButton.Image")));
            this.customersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersButton.Location = new System.Drawing.Point(0, 205);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(250, 30);
            this.customersButton.TabIndex = 6;
            this.customersButton.Text = "       Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            // 
            // salesButton
            // 
            this.salesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesButton.FlatAppearance.BorderSize = 0;
            this.salesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.Image = ((System.Drawing.Image)(resources.GetObject("salesButton.Image")));
            this.salesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.Location = new System.Drawing.Point(0, 169);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(250, 30);
            this.salesButton.TabIndex = 7;
            this.salesButton.Text = "       Sales";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.MediumBlue;
            this.dashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardButton.Image")));
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(0, 97);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(250, 30);
            this.dashboardButton.TabIndex = 8;
            this.dashboardButton.Text = "       Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButton.Image = ((System.Drawing.Image)(resources.GetObject("productsButton.Image")));
            this.productsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsButton.Location = new System.Drawing.Point(0, 133);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(250, 30);
            this.productsButton.TabIndex = 8;
            this.productsButton.Text = "       Products";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.principalPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.principalPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuMinButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalViewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel principalPanel;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox menuMinButton;
        private System.Windows.Forms.PictureBox maximizeButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox normalViewButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Button etcButton;
        private System.Windows.Forms.Button purchasingButton;
        private System.Windows.Forms.Button shippingButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Label labelAbout;
    }
}

