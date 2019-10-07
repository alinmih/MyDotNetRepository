namespace ProductionUI.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelVersion = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.panelMenuItems = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.minimizeMenuButton = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.maximizeButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.normalViewButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.timerForMinimizeBar = new System.Windows.Forms.Timer(this.components);
            this.adminItemsUserControl1 = new ProductionUI.Forms.DashboardLayout.AdminItemsUserControl();
            this.menuItemsUserControl1 = new ProductionUI.Forms.DashboardLayout.MenuItemsUserControl();
            this.titleUserControl = new ProductionUI.Forms.DashboardLayout.TitleUserControl();
            this.companyLabel = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelVersion.SuspendLayout();
            this.panelMenuItems.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelHeader2.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalViewButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.panelMain);
            this.panelContainer.Controls.Add(this.panelAdmin);
            this.panelContainer.Controls.Add(this.panelMenu);
            this.panelContainer.Controls.Add(this.panelHeader);
            this.panelContainer.Controls.Add(this.panelTopBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1200, 700);
            this.panelContainer.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(194, 107);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1004, 591);
            this.panelMain.TabIndex = 5;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.adminItemsUserControl1);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmin.Location = new System.Drawing.Point(194, 49);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1004, 58);
            this.panelAdmin.TabIndex = 4;
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.panelVersion);
            this.panelMenu.Controls.Add(this.panelMenuItems);
            this.panelMenu.Controls.Add(this.panelButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 49);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(194, 649);
            this.panelMenu.TabIndex = 3;
            // 
            // panelVersion
            // 
            this.panelVersion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelVersion.Controls.Add(this.versionLabel);
            this.panelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVersion.Location = new System.Drawing.Point(0, 616);
            this.panelVersion.Name = "panelVersion";
            this.panelVersion.Size = new System.Drawing.Size(192, 31);
            this.panelVersion.TabIndex = 2;
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.White;
            this.versionLabel.Location = new System.Drawing.Point(3, 4);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.versionLabel.Size = new System.Drawing.Size(52, 19);
            this.versionLabel.TabIndex = 4;
            this.versionLabel.Text = "V 1.0 ";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMenuItems
            // 
            this.panelMenuItems.Controls.Add(this.menuItemsUserControl1);
            this.panelMenuItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuItems.Location = new System.Drawing.Point(0, 58);
            this.panelMenuItems.Name = "panelMenuItems";
            this.panelMenuItems.Size = new System.Drawing.Size(192, 558);
            this.panelMenuItems.TabIndex = 1;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelButton.Controls.Add(this.minimizeMenuButton);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(192, 58);
            this.panelButton.TabIndex = 0;
            // 
            // minimizeMenuButton
            // 
            this.minimizeMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeMenuButton.FlatAppearance.BorderSize = 0;
            this.minimizeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeMenuButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeMenuButton.ForeColor = System.Drawing.Color.White;
            this.minimizeMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeMenuButton.Image")));
            this.minimizeMenuButton.Location = new System.Drawing.Point(154, 6);
            this.minimizeMenuButton.Name = "minimizeMenuButton";
            this.minimizeMenuButton.Size = new System.Drawing.Size(32, 42);
            this.minimizeMenuButton.TabIndex = 4;
            this.minimizeMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.minimizeMenuButton.UseVisualStyleBackColor = true;
            this.minimizeMenuButton.Click += new System.EventHandler(this.MinimizeMenuButton_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.panelHeader2);
            this.panelHeader.Controls.Add(this.panelLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 26);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1198, 23);
            this.panelHeader.TabIndex = 1;
            // 
            // panelHeader2
            // 
            this.panelHeader2.Controls.Add(this.titleUserControl);
            this.panelHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader2.Location = new System.Drawing.Point(26, 0);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(1170, 21);
            this.panelHeader2.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(26, 21);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopBar.Controls.Add(this.companyLabel);
            this.panelTopBar.Controls.Add(this.maximizeButton);
            this.panelTopBar.Controls.Add(this.minimizeButton);
            this.panelTopBar.Controls.Add(this.normalViewButton);
            this.panelTopBar.Controls.Add(this.exitButton);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1198, 26);
            this.panelTopBar.TabIndex = 0;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.Location = new System.Drawing.Point(1145, 1);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(21, 24);
            this.maximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeButton.TabIndex = 8;
            this.maximizeButton.TabStop = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(1118, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(21, 24);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // normalViewButton
            // 
            this.normalViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.normalViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.normalViewButton.Image = ((System.Drawing.Image)(resources.GetObject("normalViewButton.Image")));
            this.normalViewButton.Location = new System.Drawing.Point(1145, 1);
            this.normalViewButton.Name = "normalViewButton";
            this.normalViewButton.Size = new System.Drawing.Size(21, 24);
            this.normalViewButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.normalViewButton.TabIndex = 6;
            this.normalViewButton.TabStop = false;
            this.normalViewButton.Visible = false;
            this.normalViewButton.Click += new System.EventHandler(this.normalViewButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(1172, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(21, 24);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 7;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // timerForMinimizeBar
            // 
            this.timerForMinimizeBar.Tick += new System.EventHandler(this.TimerForMinimizeBar_Tick);
            // 
            // adminItemsUserControl1
            // 
            this.adminItemsUserControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminItemsUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminItemsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminItemsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.adminItemsUserControl1.Name = "adminItemsUserControl1";
            this.adminItemsUserControl1.Size = new System.Drawing.Size(1004, 58);
            this.adminItemsUserControl1.TabIndex = 0;
            // 
            // menuItemsUserControl1
            // 
            this.menuItemsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuItemsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.menuItemsUserControl1.Name = "menuItemsUserControl1";
            this.menuItemsUserControl1.Size = new System.Drawing.Size(192, 558);
            this.menuItemsUserControl1.TabIndex = 0;
            // 
            // titleUserControl
            // 
            this.titleUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleUserControl.Location = new System.Drawing.Point(0, 0);
            this.titleUserControl.Name = "titleUserControl";
            this.titleUserControl.Size = new System.Drawing.Size(1170, 21);
            this.titleUserControl.TabIndex = 0;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.companyLabel.Location = new System.Drawing.Point(470, 2);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.companyLabel.Size = new System.Drawing.Size(258, 23);
            this.companyLabel.TabIndex = 10;
            this.companyLabel.Text = "<Company> Management";
            this.companyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(910, 700);
            this.Name = "MainForm";
            this.Text = "Dashboard";
            this.panelContainer.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelVersion.ResumeLayout(false);
            this.panelVersion.PerformLayout();
            this.panelMenuItems.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader2.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalViewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelVersion;
        private System.Windows.Forms.Panel panelMenuItems;
        private System.Windows.Forms.Panel panelButton;
        private DashboardLayout.MenuItemsUserControl menuItemsUserControl1;
        private System.Windows.Forms.Panel panelHeader2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelAdmin;
        private DashboardLayout.AdminItemsUserControl adminItemsUserControl1;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button minimizeMenuButton;
        private System.Windows.Forms.PictureBox maximizeButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox normalViewButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Timer timerForMinimizeBar;
        private DashboardLayout.TitleUserControl titleUserControl;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label companyLabel;
    }
}