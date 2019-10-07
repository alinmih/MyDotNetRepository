using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionUI.Forms.DashboardLayout
{
    public partial class MenuItemsUserControl : UserControl
    {
        public MenuItemsUserControl()
        {
            InitializeComponent();
        }


        private void MovePanelSide(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(homeButton);
        }

        private void productsButon_Click(object sender, EventArgs e)
        {
            MovePanelSide(productsButon);
        }

        private void productionOrdersButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(productionOrdersButton);
        }

        private void salesOrdersButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(salesOrdersButton);
        }

        private void offersButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(offersButton);
        }

        private void warehouseManagementButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(warehouseManagementButton);
        }

        private void manufacturingCostButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(manufacturingCostButton);
        }
    }
}
