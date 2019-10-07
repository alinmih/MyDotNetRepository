using ProductionUI.Forms.ManufacturingCosts;
using ProductionUI.UserControls;
using ProductionUI.UserControls.AdminArea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionUI.Forms
{
    public partial class DashboardForm : Form
    {
        //vars for menu minimize
        private int panelWidth;
        private bool isColapsed;

        public DashboardForm()
        {
            InitializeComponent();

            clockTimer.Start();
            

            //set the default width
            panelWidth = leftActivePanel.Width;
            isColapsed = false;

            UserControlHome userControlHome = new UserControlHome();
            AddControlsToPanel(userControlHome);
        }

        //move the sidepanel for selected button

        private void MinimizeMenuButton_Click(object sender, EventArgs e)
        {
            timerForMinimizeBar.Start();
        }

        private void TimerForMinimizeBar_Tick(object sender, EventArgs e)
        {
            if (isColapsed)
            {
                //iconPanel.Hide();
                leftActivePanel.Width = leftActivePanel.Width + 10;
                if (leftActivePanel.Width >= panelWidth)
                {
                    timerForMinimizeBar.Stop();
                    isColapsed = false;
                    iconPanel.Show();
                    this.Refresh();
                    
                }
            }
            else
            {
                leftActivePanel.Width = leftActivePanel.Width - 10;
                if (leftActivePanel.Width <= 67)
                {
                    timerForMinimizeBar.Stop();
                    isColapsed = true;
                    this.Refresh();
                    iconPanel.Hide();
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MovePanelTop(Control btn)
        {
            panelTop.Left = btn.Left;
            panelTop.Width = btn.Width;
        }

        //move panel accoding to button clicked
        private void MovePanelSide(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(c);
        }



        private void HomeButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(homeButton);

            UserControlHome userControlHome = new UserControlHome();
            AddControlsToPanel(userControlHome);
        }

        //TODO - Implement this on future
        private void ProductsButon_Click(object sender, EventArgs e)
        {
            MovePanelSide(productsButon);

            UserProductsControl userProductsControl = new UserProductsControl();
            AddControlsToPanel(userProductsControl);

        }

        private void ProductionOrdersButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(productionOrdersButton);
            UserProductsControl userProductsControl = new UserProductsControl();
            AddControlsToPanel(userProductsControl);
        }

        private void SalesOrdersButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(salesOrdersButton);
            UserSalesOrderControl userSalesOrderControl = new UserSalesOrderControl();
            AddControlsToPanel(userSalesOrderControl);

        }

        private void OffersButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(offersButton);
            UserOffersControl userOffersControl = new UserOffersControl();
            AddControlsToPanel(userOffersControl);
        }

        private void WarehouseManagementButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(warehouseManagementButton);
            UserWarehouseControl userWarehouseControl = new UserWarehouseControl();
            AddControlsToPanel(userWarehouseControl);
        }

        private void ManufacturingCostButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(manufacturingCostButton);
            //SelectMachines selectMachines = new SelectMachines();
            //selectMachines.Show();
            UserManufacturingCostControl userManufacturingCostControl = new UserManufacturingCostControl();
            AddControlsToPanel(userManufacturingCostControl);
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            clockLabel.Text = dt.ToString("HH:mm:ss");
        }

        private void MachinesButton_Click(object sender, EventArgs e)
        {
            MovePanelTop(machinesButton);
            UserAdminMachines adminMachines = new UserAdminMachines();
            AddControlsToPanel(adminMachines);
        }

        private void RawMaterialsButton_Click(object sender, EventArgs e)
        {
            MovePanelTop(rawMaterialsButton);
            UserAdminMaterials adminMaterials = new UserAdminMaterials();
            AddControlsToPanel(adminMaterials);
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            MovePanelTop(customersButton);
            UserAdminCustomers adminCustomers = new UserAdminCustomers();
            AddControlsToPanel(adminCustomers);
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            MovePanelTop(usersButton);
            UserAdminUsers adminUsers = new UserAdminUsers();
            AddControlsToPanel(adminUsers);
        }
    }
}
