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
            this.panelMenuItems = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.productsButon = new System.Windows.Forms.Button();
            this.warehouseManagementButton = new System.Windows.Forms.Button();
            this.offersButton = new System.Windows.Forms.Button();
            this.salesOrdersButton = new System.Windows.Forms.Button();
            this.productionOrdersButton = new System.Windows.Forms.Button();
            this.manufacturingCostButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.panelMenuMinimize = new System.Windows.Forms.Panel();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.adminItemsUserControl = new ProductionUI.Forms.DashboardLayout.AdminItemsUserControl();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.titleUserControl = new ProductionUI.Forms.DashboardLayout.TitleUserControl();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.maximizeButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.normalViewButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.timerForMinimizeBar = new System.Windows.Forms.Timer(this.components);
            this.panelContainer.SuspendLayout();
            this.panelMenuItems.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelMenuMinimize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            this.panelAdmin.SuspendLayout();
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
            this.panelContainer.Controls.Add(this.panelMenuItems);
            this.panelContainer.Controls.Add(this.panelAdmin);
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
            this.panelMain.Location = new System.Drawing.Point(200, 107);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(998, 591);
            this.panelMain.TabIndex = 6;
            // 
            // panelMenuItems
            // 
            this.panelMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuItems.Controls.Add(this.panelMenu);
            this.panelMenuItems.Controls.Add(this.panelMenuMinimize);
            this.panelMenuItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuItems.Location = new System.Drawing.Point(0, 107);
            this.panelMenuItems.Name = "panelMenuItems";
            this.panelMenuItems.Size = new System.Drawing.Size(200, 591);
            this.panelMenuItems.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelSide);
            this.panelMenu.Controls.Add(this.productsButon);
            this.panelMenu.Controls.Add(this.warehouseManagementButton);
            this.panelMenu.Controls.Add(this.offersButton);
            this.panelMenu.Controls.Add(this.salesOrdersButton);
            this.panelMenu.Controls.Add(this.productionOrdersButton);
            this.panelMenu.Controls.Add(this.manufacturingCostButton);
            this.panelMenu.Controls.Add(this.homeButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 33);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(198, 556);
            this.panelMenu.TabIndex = 1;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.DimGray;
            this.panelSide.Location = new System.Drawing.Point(2, 3);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(6, 60);
            this.panelSide.TabIndex = 12;
            // 
            // productsButon
            // 
            this.productsButon.BackColor = System.Drawing.Color.White;
            this.productsButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsButon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.productsButon.FlatAppearance.BorderSize = 0;
            this.productsButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButon.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButon.ForeColor = System.Drawing.Color.DimGray;
            this.productsButon.Image = ((System.Drawing.Image)(resources.GetObject("productsButon.Image")));
            this.productsButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsButon.Location = new System.Drawing.Point(10, 63);
            this.productsButon.Name = "productsButon";
            this.productsButon.Size = new System.Drawing.Size(185, 60);
            this.productsButon.TabIndex = 13;
            this.productsButon.Text = "  Products";
            this.productsButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productsButon.UseVisualStyleBackColor = false;
            this.productsButon.Click += new System.EventHandler(this.productsButon_Click);
            // 
            // warehouseManagementButton
            // 
            this.warehouseManagementButton.BackColor = System.Drawing.Color.White;
            this.warehouseManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.warehouseManagementButton.FlatAppearance.BorderSize = 0;
            this.warehouseManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warehouseManagementButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseManagementButton.ForeColor = System.Drawing.Color.DimGray;
            this.warehouseManagementButton.Image = ((System.Drawing.Image)(resources.GetObject("warehouseManagementButton.Image")));
            this.warehouseManagementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warehouseManagementButton.Location = new System.Drawing.Point(10, 303);
            this.warehouseManagementButton.Name = "warehouseManagementButton";
            this.warehouseManagementButton.Size = new System.Drawing.Size(185, 60);
            this.warehouseManagementButton.TabIndex = 14;
            this.warehouseManagementButton.Text = "  Warehouse         Management";
            this.warehouseManagementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.warehouseManagementButton.UseVisualStyleBackColor = false;
            this.warehouseManagementButton.Click += new System.EventHandler(this.warehouseManagementButton_Click);
            // 
            // offersButton
            // 
            this.offersButton.BackColor = System.Drawing.Color.White;
            this.offersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offersButton.FlatAppearance.BorderSize = 0;
            this.offersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offersButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offersButton.ForeColor = System.Drawing.Color.DimGray;
            this.offersButton.Image = ((System.Drawing.Image)(resources.GetObject("offersButton.Image")));
            this.offersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.offersButton.Location = new System.Drawing.Point(10, 243);
            this.offersButton.Name = "offersButton";
            this.offersButton.Size = new System.Drawing.Size(185, 60);
            this.offersButton.TabIndex = 15;
            this.offersButton.Text = "  Offers";
            this.offersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.offersButton.UseVisualStyleBackColor = false;
            this.offersButton.Click += new System.EventHandler(this.offersButton_Click);
            // 
            // salesOrdersButton
            // 
            this.salesOrdersButton.BackColor = System.Drawing.Color.White;
            this.salesOrdersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesOrdersButton.FlatAppearance.BorderSize = 0;
            this.salesOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesOrdersButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOrdersButton.ForeColor = System.Drawing.Color.DimGray;
            this.salesOrdersButton.Image = ((System.Drawing.Image)(resources.GetObject("salesOrdersButton.Image")));
            this.salesOrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesOrdersButton.Location = new System.Drawing.Point(10, 183);
            this.salesOrdersButton.Name = "salesOrdersButton";
            this.salesOrdersButton.Size = new System.Drawing.Size(185, 60);
            this.salesOrdersButton.TabIndex = 16;
            this.salesOrdersButton.Text = "  Sales Orders";
            this.salesOrdersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salesOrdersButton.UseVisualStyleBackColor = false;
            this.salesOrdersButton.Click += new System.EventHandler(this.salesOrdersButton_Click);
            // 
            // productionOrdersButton
            // 
            this.productionOrdersButton.BackColor = System.Drawing.Color.White;
            this.productionOrdersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productionOrdersButton.FlatAppearance.BorderSize = 0;
            this.productionOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productionOrdersButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionOrdersButton.ForeColor = System.Drawing.Color.DimGray;
            this.productionOrdersButton.Image = ((System.Drawing.Image)(resources.GetObject("productionOrdersButton.Image")));
            this.productionOrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productionOrdersButton.Location = new System.Drawing.Point(10, 123);
            this.productionOrdersButton.Name = "productionOrdersButton";
            this.productionOrdersButton.Size = new System.Drawing.Size(185, 60);
            this.productionOrdersButton.TabIndex = 17;
            this.productionOrdersButton.Text = "  Production Orders";
            this.productionOrdersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productionOrdersButton.UseVisualStyleBackColor = false;
            this.productionOrdersButton.Click += new System.EventHandler(this.productionOrdersButton_Click);
            // 
            // manufacturingCostButton
            // 
            this.manufacturingCostButton.BackColor = System.Drawing.Color.White;
            this.manufacturingCostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manufacturingCostButton.FlatAppearance.BorderSize = 0;
            this.manufacturingCostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manufacturingCostButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostButton.ForeColor = System.Drawing.Color.DimGray;
            this.manufacturingCostButton.Image = ((System.Drawing.Image)(resources.GetObject("manufacturingCostButton.Image")));
            this.manufacturingCostButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manufacturingCostButton.Location = new System.Drawing.Point(10, 363);
            this.manufacturingCostButton.Name = "manufacturingCostButton";
            this.manufacturingCostButton.Size = new System.Drawing.Size(185, 60);
            this.manufacturingCostButton.TabIndex = 18;
            this.manufacturingCostButton.Text = "  Manufacturing Cost";
            this.manufacturingCostButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manufacturingCostButton.UseVisualStyleBackColor = false;
            this.manufacturingCostButton.Click += new System.EventHandler(this.manufacturingCostButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.White;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.DimGray;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(10, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(185, 60);
            this.homeButton.TabIndex = 19;
            this.homeButton.Text = "  Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panelMenuMinimize
            // 
            this.panelMenuMinimize.Controls.Add(this.pictureBoxMinimize);
            this.panelMenuMinimize.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuMinimize.Location = new System.Drawing.Point(0, 0);
            this.panelMenuMinimize.Name = "panelMenuMinimize";
            this.panelMenuMinimize.Size = new System.Drawing.Size(198, 33);
            this.panelMenuMinimize.TabIndex = 0;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimize.BackgroundImage")));
            this.pictureBoxMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMinimize.InitialImage = null;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(149, 0);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(49, 33);
            this.pictureBoxMinimize.TabIndex = 0;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.adminItemsUserControl);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmin.Location = new System.Drawing.Point(0, 49);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1198, 58);
            this.panelAdmin.TabIndex = 4;
            // 
            // adminItemsUserControl
            // 
            this.adminItemsUserControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminItemsUserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminItemsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminItemsUserControl.Location = new System.Drawing.Point(0, 0);
            this.adminItemsUserControl.Name = "adminItemsUserControl";
            this.adminItemsUserControl.Size = new System.Drawing.Size(1198, 58);
            this.adminItemsUserControl.TabIndex = 0;
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
            this.panelHeader2.Location = new System.Drawing.Point(66, 0);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(1130, 21);
            this.panelHeader2.TabIndex = 1;
            // 
            // titleUserControl
            // 
            this.titleUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleUserControl.Location = new System.Drawing.Point(0, 0);
            this.titleUserControl.Name = "titleUserControl";
            this.titleUserControl.Size = new System.Drawing.Size(1130, 21);
            this.titleUserControl.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(66, 21);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelMenuItems.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuMinimize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader2.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalViewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelHeader2;
        private System.Windows.Forms.Panel panelAdmin;
        private DashboardLayout.AdminItemsUserControl adminItemsUserControl;
        private System.Windows.Forms.PictureBox maximizeButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox normalViewButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Timer timerForMinimizeBar;
        private DashboardLayout.TitleUserControl titleUserControl;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenuItems;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMenuMinimize;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button productsButon;
        private System.Windows.Forms.Button warehouseManagementButton;
        private System.Windows.Forms.Button offersButton;
        private System.Windows.Forms.Button salesOrdersButton;
        private System.Windows.Forms.Button productionOrdersButton;
        private System.Windows.Forms.Button manufacturingCostButton;
        private System.Windows.Forms.Button homeButton;
    }
}