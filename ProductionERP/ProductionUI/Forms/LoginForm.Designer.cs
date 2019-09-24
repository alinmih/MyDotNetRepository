namespace ProductionUI.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.productionIcon = new System.Windows.Forms.PictureBox();
            this.productionManagementLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.productionLoginIcon = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.addDbButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionLoginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Controls.Add(this.productionIcon);
            this.headerPanel.Controls.Add(this.productionManagementLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1184, 56);
            this.headerPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(1119, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(65, 56);
            this.closeButton.TabIndex = 10;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // productionIcon
            // 
            this.productionIcon.Image = ((System.Drawing.Image)(resources.GetObject("productionIcon.Image")));
            this.productionIcon.Location = new System.Drawing.Point(3, 3);
            this.productionIcon.Name = "productionIcon";
            this.productionIcon.Size = new System.Drawing.Size(51, 50);
            this.productionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productionIcon.TabIndex = 2;
            this.productionIcon.TabStop = false;
            // 
            // productionManagementLabel
            // 
            this.productionManagementLabel.AutoSize = true;
            this.productionManagementLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionManagementLabel.ForeColor = System.Drawing.Color.White;
            this.productionManagementLabel.Location = new System.Drawing.Point(60, 18);
            this.productionManagementLabel.Name = "productionManagementLabel";
            this.productionManagementLabel.Size = new System.Drawing.Size(361, 23);
            this.productionManagementLabel.TabIndex = 2;
            this.productionManagementLabel.Text = "Production Management Application";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.usernameLabel.Location = new System.Drawing.Point(413, 324);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(96, 19);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "User Name:";
            // 
            // productionLoginIcon
            // 
            this.productionLoginIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productionLoginIcon.Image = ((System.Drawing.Image)(resources.GetObject("productionLoginIcon.Image")));
            this.productionLoginIcon.Location = new System.Drawing.Point(534, 160);
            this.productionLoginIcon.Name = "productionLoginIcon";
            this.productionLoginIcon.Size = new System.Drawing.Size(117, 99);
            this.productionLoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productionLoginIcon.TabIndex = 2;
            this.productionLoginIcon.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginLabel.Location = new System.Drawing.Point(503, 283);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(180, 23);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Please Login First";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextbox.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.Location = new System.Drawing.Point(417, 346);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(340, 30);
            this.usernameTextbox.TabIndex = 4;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextbox.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(417, 412);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(340, 30);
            this.passwordTextbox.TabIndex = 6;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.passwordLabel.Location = new System.Drawing.Point(413, 390);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(84, 19);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(417, 501);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(340, 43);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(472, 458);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(179, 23);
            this.forgotPasswordLabel.TabIndex = 8;
            this.forgotPasswordLabel.Text = "Forgot Password?";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.copyrightLabel.Location = new System.Drawing.Point(12, 633);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(252, 16);
            this.copyrightLabel.TabIndex = 9;
            this.copyrightLabel.Text = "Copyrights 2019. All rights reserved to Me";
            // 
            // addDbButton
            // 
            this.addDbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addDbButton.BackColor = System.Drawing.Color.White;
            this.addDbButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addDbButton.BackgroundImage")));
            this.addDbButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addDbButton.FlatAppearance.BorderSize = 0;
            this.addDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDbButton.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDbButton.ForeColor = System.Drawing.Color.White;
            this.addDbButton.Location = new System.Drawing.Point(1119, 603);
            this.addDbButton.Name = "addDbButton";
            this.addDbButton.Size = new System.Drawing.Size(53, 46);
            this.addDbButton.TabIndex = 10;
            this.addDbButton.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.addDbButton);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.forgotPasswordLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.productionLoginIcon);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionLoginIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox productionIcon;
        private System.Windows.Forms.Label productionManagementLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox productionLoginIcon;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Button addDbButton;
    }
}