namespace ProductionUI.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.topWhitePanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.logedInLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.topActivePanel = new System.Windows.Forms.Panel();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.adminAreaLabel = new System.Windows.Forms.Label();
            this.machinesButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.usersButton = new System.Windows.Forms.Button();
            this.rawMaterialsButton = new System.Windows.Forms.Button();
            this.clockLabel = new System.Windows.Forms.Label();
            this.timerForMinimizeBar = new System.Windows.Forms.Timer(this.components);
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topLeftActivePanel = new System.Windows.Forms.Panel();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.productionIcon = new System.Windows.Forms.PictureBox();
            this.iconApplicationLabel = new System.Windows.Forms.Label();
            this.iconManagementLabel = new System.Windows.Forms.Label();
            this.iconProductionLabel = new System.Windows.Forms.Label();
            this.minimizeMenuButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.manufacturingCostButton = new System.Windows.Forms.Button();
            this.productionOrdersButton = new System.Windows.Forms.Button();
            this.salesOrdersButton = new System.Windows.Forms.Button();
            this.offersButton = new System.Windows.Forms.Button();
            this.warehouseManagementButton = new System.Windows.Forms.Button();
            this.productsButon = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.leftActivePanel = new System.Windows.Forms.Panel();
            this.topWhitePanel.SuspendLayout();
            this.topActivePanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.topLeftActivePanel.SuspendLayout();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionIcon)).BeginInit();
            this.leftActivePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topWhitePanel
            // 
            this.topWhitePanel.Controls.Add(this.closeButton);
            this.topWhitePanel.Controls.Add(this.userLabel);
            this.topWhitePanel.Controls.Add(this.logedInLabel);
            this.topWhitePanel.Controls.Add(this.companyLabel);
            this.topWhitePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topWhitePanel.Location = new System.Drawing.Point(233, 0);
            this.topWhitePanel.Name = "topWhitePanel";
            this.topWhitePanel.Size = new System.Drawing.Size(951, 45);
            this.topWhitePanel.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(904, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(47, 45);
            this.closeButton.TabIndex = 3;
            this.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.userLabel.Location = new System.Drawing.Point(819, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userLabel.Size = new System.Drawing.Size(82, 19);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "<admin>";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logedInLabel
            // 
            this.logedInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logedInLabel.AutoSize = true;
            this.logedInLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logedInLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.logedInLabel.Location = new System.Drawing.Point(699, 13);
            this.logedInLabel.Name = "logedInLabel";
            this.logedInLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logedInLabel.Size = new System.Drawing.Size(116, 19);
            this.logedInLabel.TabIndex = 3;
            this.logedInLabel.Text = "Logged In As:";
            this.logedInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.companyLabel.Location = new System.Drawing.Point(99, 10);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.companyLabel.Size = new System.Drawing.Size(258, 23);
            this.companyLabel.TabIndex = 3;
            this.companyLabel.Text = "<Company> Management";
            this.companyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topActivePanel
            // 
            this.topActivePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topActivePanel.Controls.Add(this.adminPanel);
            this.topActivePanel.Controls.Add(this.clockLabel);
            this.topActivePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topActivePanel.Location = new System.Drawing.Point(233, 45);
            this.topActivePanel.Name = "topActivePanel";
            this.topActivePanel.Size = new System.Drawing.Size(951, 95);
            this.topActivePanel.TabIndex = 2;
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.adminAreaLabel);
            this.adminPanel.Controls.Add(this.machinesButton);
            this.adminPanel.Controls.Add(this.customersButton);
            this.adminPanel.Controls.Add(this.panelTop);
            this.adminPanel.Controls.Add(this.usersButton);
            this.adminPanel.Controls.Add(this.rawMaterialsButton);
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminPanel.Location = new System.Drawing.Point(0, 0);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(716, 95);
            this.adminPanel.TabIndex = 4;
            // 
            // adminAreaLabel
            // 
            this.adminAreaLabel.AutoSize = true;
            this.adminAreaLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAreaLabel.ForeColor = System.Drawing.Color.White;
            this.adminAreaLabel.Location = new System.Drawing.Point(35, 2);
            this.adminAreaLabel.Name = "adminAreaLabel";
            this.adminAreaLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminAreaLabel.Size = new System.Drawing.Size(102, 19);
            this.adminAreaLabel.TabIndex = 5;
            this.adminAreaLabel.Text = "Admin Area";
            this.adminAreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // machinesButton
            // 
            this.machinesButton.FlatAppearance.BorderSize = 0;
            this.machinesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.machinesButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machinesButton.ForeColor = System.Drawing.Color.White;
            this.machinesButton.Image = ((System.Drawing.Image)(resources.GetObject("machinesButton.Image")));
            this.machinesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.machinesButton.Location = new System.Drawing.Point(39, 24);
            this.machinesButton.Name = "machinesButton";
            this.machinesButton.Size = new System.Drawing.Size(166, 60);
            this.machinesButton.TabIndex = 4;
            this.machinesButton.Text = "    Machines";
            this.machinesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.machinesButton.UseVisualStyleBackColor = true;
            this.machinesButton.Click += new System.EventHandler(this.MachinesButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.FlatAppearance.BorderSize = 0;
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersButton.ForeColor = System.Drawing.Color.White;
            this.customersButton.Image = ((System.Drawing.Image)(resources.GetObject("customersButton.Image")));
            this.customersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersButton.Location = new System.Drawing.Point(413, 24);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(151, 60);
            this.customersButton.TabIndex = 4;
            this.customersButton.Text = "   Customers";
            this.customersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(39, 84);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(166, 7);
            this.panelTop.TabIndex = 4;
            // 
            // usersButton
            // 
            this.usersButton.FlatAppearance.BorderSize = 0;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.White;
            this.usersButton.Image = ((System.Drawing.Image)(resources.GetObject("usersButton.Image")));
            this.usersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersButton.Location = new System.Drawing.Point(568, 24);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(115, 60);
            this.usersButton.TabIndex = 4;
            this.usersButton.Text = "   Users";
            this.usersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // rawMaterialsButton
            // 
            this.rawMaterialsButton.FlatAppearance.BorderSize = 0;
            this.rawMaterialsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rawMaterialsButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawMaterialsButton.ForeColor = System.Drawing.Color.White;
            this.rawMaterialsButton.Image = ((System.Drawing.Image)(resources.GetObject("rawMaterialsButton.Image")));
            this.rawMaterialsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rawMaterialsButton.Location = new System.Drawing.Point(209, 24);
            this.rawMaterialsButton.Name = "rawMaterialsButton";
            this.rawMaterialsButton.Size = new System.Drawing.Size(200, 60);
            this.rawMaterialsButton.TabIndex = 4;
            this.rawMaterialsButton.Text = "  Raw Materials";
            this.rawMaterialsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rawMaterialsButton.UseVisualStyleBackColor = true;
            this.rawMaterialsButton.Click += new System.EventHandler(this.RawMaterialsButton_Click);
            // 
            // clockLabel
            // 
            this.clockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.ForeColor = System.Drawing.Color.White;
            this.clockLabel.Location = new System.Drawing.Point(858, 35);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clockLabel.Size = new System.Drawing.Size(89, 19);
            this.clockLabel.TabIndex = 3;
            this.clockLabel.Text = "hh:mm:ss";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerForMinimizeBar
            // 
            this.timerForMinimizeBar.Tick += new System.EventHandler(this.TimerForMinimizeBar_Tick);
            // 
            // clockTimer
            // 
            this.clockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(233, 140);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(951, 521);
            this.mainPanel.TabIndex = 3;
            // 
            // topLeftActivePanel
            // 
            this.topLeftActivePanel.Controls.Add(this.iconPanel);
            this.topLeftActivePanel.Controls.Add(this.minimizeMenuButton);
            this.topLeftActivePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLeftActivePanel.Location = new System.Drawing.Point(0, 0);
            this.topLeftActivePanel.Name = "topLeftActivePanel";
            this.topLeftActivePanel.Size = new System.Drawing.Size(233, 140);
            this.topLeftActivePanel.TabIndex = 1;
            // 
            // iconPanel
            // 
            this.iconPanel.Controls.Add(this.productionIcon);
            this.iconPanel.Controls.Add(this.iconApplicationLabel);
            this.iconPanel.Controls.Add(this.iconManagementLabel);
            this.iconPanel.Controls.Add(this.iconProductionLabel);
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPanel.Location = new System.Drawing.Point(0, 0);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(173, 140);
            this.iconPanel.TabIndex = 0;
            // 
            // productionIcon
            // 
            this.productionIcon.Image = ((System.Drawing.Image)(resources.GetObject("productionIcon.Image")));
            this.productionIcon.Location = new System.Drawing.Point(43, 0);
            this.productionIcon.Name = "productionIcon";
            this.productionIcon.Size = new System.Drawing.Size(117, 69);
            this.productionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productionIcon.TabIndex = 3;
            this.productionIcon.TabStop = false;
            // 
            // iconApplicationLabel
            // 
            this.iconApplicationLabel.AutoSize = true;
            this.iconApplicationLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconApplicationLabel.ForeColor = System.Drawing.Color.White;
            this.iconApplicationLabel.Location = new System.Drawing.Point(54, 109);
            this.iconApplicationLabel.Name = "iconApplicationLabel";
            this.iconApplicationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconApplicationLabel.Size = new System.Drawing.Size(101, 19);
            this.iconApplicationLabel.TabIndex = 4;
            this.iconApplicationLabel.Text = "Application";
            this.iconApplicationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconManagementLabel
            // 
            this.iconManagementLabel.AutoSize = true;
            this.iconManagementLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconManagementLabel.ForeColor = System.Drawing.Color.White;
            this.iconManagementLabel.Location = new System.Drawing.Point(54, 90);
            this.iconManagementLabel.Name = "iconManagementLabel";
            this.iconManagementLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconManagementLabel.Size = new System.Drawing.Size(114, 19);
            this.iconManagementLabel.TabIndex = 4;
            this.iconManagementLabel.Text = "Management";
            this.iconManagementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconProductionLabel
            // 
            this.iconProductionLabel.AutoSize = true;
            this.iconProductionLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconProductionLabel.ForeColor = System.Drawing.Color.White;
            this.iconProductionLabel.Location = new System.Drawing.Point(54, 72);
            this.iconProductionLabel.Name = "iconProductionLabel";
            this.iconProductionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconProductionLabel.Size = new System.Drawing.Size(96, 19);
            this.iconProductionLabel.TabIndex = 3;
            this.iconProductionLabel.Text = "Production";
            this.iconProductionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minimizeMenuButton
            // 
            this.minimizeMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeMenuButton.FlatAppearance.BorderSize = 0;
            this.minimizeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeMenuButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeMenuButton.ForeColor = System.Drawing.Color.White;
            this.minimizeMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeMenuButton.Image")));
            this.minimizeMenuButton.Location = new System.Drawing.Point(196, 0);
            this.minimizeMenuButton.Name = "minimizeMenuButton";
            this.minimizeMenuButton.Size = new System.Drawing.Size(32, 42);
            this.minimizeMenuButton.TabIndex = 3;
            this.minimizeMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.minimizeMenuButton.UseVisualStyleBackColor = true;
            this.minimizeMenuButton.Click += new System.EventHandler(this.MinimizeMenuButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(12, 146);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(203, 60);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "  Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // manufacturingCostButton
            // 
            this.manufacturingCostButton.FlatAppearance.BorderSize = 0;
            this.manufacturingCostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manufacturingCostButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingCostButton.ForeColor = System.Drawing.Color.White;
            this.manufacturingCostButton.Image = ((System.Drawing.Image)(resources.GetObject("manufacturingCostButton.Image")));
            this.manufacturingCostButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manufacturingCostButton.Location = new System.Drawing.Point(11, 529);
            this.manufacturingCostButton.Name = "manufacturingCostButton";
            this.manufacturingCostButton.Size = new System.Drawing.Size(203, 60);
            this.manufacturingCostButton.TabIndex = 3;
            this.manufacturingCostButton.Text = "  Manufacturing Cost";
            this.manufacturingCostButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manufacturingCostButton.UseVisualStyleBackColor = true;
            this.manufacturingCostButton.Click += new System.EventHandler(this.ManufacturingCostButton_Click);
            // 
            // productionOrdersButton
            // 
            this.productionOrdersButton.FlatAppearance.BorderSize = 0;
            this.productionOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productionOrdersButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionOrdersButton.ForeColor = System.Drawing.Color.White;
            this.productionOrdersButton.Image = ((System.Drawing.Image)(resources.GetObject("productionOrdersButton.Image")));
            this.productionOrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productionOrdersButton.Location = new System.Drawing.Point(12, 278);
            this.productionOrdersButton.Name = "productionOrdersButton";
            this.productionOrdersButton.Size = new System.Drawing.Size(203, 60);
            this.productionOrdersButton.TabIndex = 3;
            this.productionOrdersButton.Text = "  Production Orders";
            this.productionOrdersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productionOrdersButton.UseVisualStyleBackColor = true;
            this.productionOrdersButton.Click += new System.EventHandler(this.ProductionOrdersButton_Click);
            // 
            // salesOrdersButton
            // 
            this.salesOrdersButton.FlatAppearance.BorderSize = 0;
            this.salesOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesOrdersButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOrdersButton.ForeColor = System.Drawing.Color.White;
            this.salesOrdersButton.Image = ((System.Drawing.Image)(resources.GetObject("salesOrdersButton.Image")));
            this.salesOrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesOrdersButton.Location = new System.Drawing.Point(12, 344);
            this.salesOrdersButton.Name = "salesOrdersButton";
            this.salesOrdersButton.Size = new System.Drawing.Size(203, 60);
            this.salesOrdersButton.TabIndex = 3;
            this.salesOrdersButton.Text = "  Sales Orders";
            this.salesOrdersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salesOrdersButton.UseVisualStyleBackColor = true;
            this.salesOrdersButton.Click += new System.EventHandler(this.SalesOrdersButton_Click);
            // 
            // offersButton
            // 
            this.offersButton.FlatAppearance.BorderSize = 0;
            this.offersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offersButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offersButton.ForeColor = System.Drawing.Color.White;
            this.offersButton.Image = ((System.Drawing.Image)(resources.GetObject("offersButton.Image")));
            this.offersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.offersButton.Location = new System.Drawing.Point(12, 410);
            this.offersButton.Name = "offersButton";
            this.offersButton.Size = new System.Drawing.Size(203, 60);
            this.offersButton.TabIndex = 3;
            this.offersButton.Text = "  Offers";
            this.offersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.offersButton.UseVisualStyleBackColor = true;
            this.offersButton.Click += new System.EventHandler(this.OffersButton_Click);
            // 
            // warehouseManagementButton
            // 
            this.warehouseManagementButton.FlatAppearance.BorderSize = 0;
            this.warehouseManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warehouseManagementButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseManagementButton.ForeColor = System.Drawing.Color.White;
            this.warehouseManagementButton.Image = ((System.Drawing.Image)(resources.GetObject("warehouseManagementButton.Image")));
            this.warehouseManagementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warehouseManagementButton.Location = new System.Drawing.Point(9, 463);
            this.warehouseManagementButton.Name = "warehouseManagementButton";
            this.warehouseManagementButton.Size = new System.Drawing.Size(203, 60);
            this.warehouseManagementButton.TabIndex = 3;
            this.warehouseManagementButton.Text = "  Warehouse         Management";
            this.warehouseManagementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.warehouseManagementButton.UseVisualStyleBackColor = true;
            this.warehouseManagementButton.Click += new System.EventHandler(this.WarehouseManagementButton_Click);
            // 
            // productsButon
            // 
            this.productsButon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.productsButon.FlatAppearance.BorderSize = 0;
            this.productsButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButon.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButon.ForeColor = System.Drawing.Color.White;
            this.productsButon.Image = ((System.Drawing.Image)(resources.GetObject("productsButon.Image")));
            this.productsButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsButon.Location = new System.Drawing.Point(12, 212);
            this.productsButon.Name = "productsButon";
            this.productsButon.Size = new System.Drawing.Size(203, 60);
            this.productsButon.TabIndex = 3;
            this.productsButon.Text = "  Products";
            this.productsButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productsButon.UseVisualStyleBackColor = true;
            this.productsButon.Click += new System.EventHandler(this.ProductsButon_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(1, 146);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 60);
            this.panelSide.TabIndex = 3;
            // 
            // leftActivePanel
            // 
            this.leftActivePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leftActivePanel.Controls.Add(this.panelSide);
            this.leftActivePanel.Controls.Add(this.productsButon);
            this.leftActivePanel.Controls.Add(this.warehouseManagementButton);
            this.leftActivePanel.Controls.Add(this.offersButton);
            this.leftActivePanel.Controls.Add(this.salesOrdersButton);
            this.leftActivePanel.Controls.Add(this.productionOrdersButton);
            this.leftActivePanel.Controls.Add(this.manufacturingCostButton);
            this.leftActivePanel.Controls.Add(this.homeButton);
            this.leftActivePanel.Controls.Add(this.topLeftActivePanel);
            this.leftActivePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftActivePanel.Location = new System.Drawing.Point(0, 0);
            this.leftActivePanel.Name = "leftActivePanel";
            this.leftActivePanel.Size = new System.Drawing.Size(233, 661);
            this.leftActivePanel.TabIndex = 0;
            // 
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topActivePanel);
            this.Controls.Add(this.topWhitePanel);
            this.Controls.Add(this.leftActivePanel);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(910, 700);
            this.Name = "DashboardForm";
            this.Text = "Application Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topWhitePanel.ResumeLayout(false);
            this.topWhitePanel.PerformLayout();
            this.topActivePanel.ResumeLayout(false);
            this.topActivePanel.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.topLeftActivePanel.ResumeLayout(false);
            this.iconPanel.ResumeLayout(false);
            this.iconPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionIcon)).EndInit();
            this.leftActivePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topWhitePanel;
        private System.Windows.Forms.Panel topActivePanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label logedInLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Timer timerForMinimizeBar;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label clockLabel;
        public System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button rawMaterialsButton;
        private System.Windows.Forms.Button machinesButton;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label adminAreaLabel;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Panel topLeftActivePanel;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.PictureBox productionIcon;
        private System.Windows.Forms.Label iconApplicationLabel;
        private System.Windows.Forms.Label iconManagementLabel;
        private System.Windows.Forms.Label iconProductionLabel;
        private System.Windows.Forms.Button minimizeMenuButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button manufacturingCostButton;
        private System.Windows.Forms.Button productionOrdersButton;
        private System.Windows.Forms.Button salesOrdersButton;
        private System.Windows.Forms.Button offersButton;
        private System.Windows.Forms.Button warehouseManagementButton;
        private System.Windows.Forms.Button productsButon;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel leftActivePanel;
    }
}