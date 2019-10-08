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
        //vars for menu minimize
        private int panelWidth;
        private bool isColapsed;

        public MenuItemsUserControl()
        {
            InitializeComponent();


            //side menu variables
            panelWidth = panelMenuItems.Width;
            isColapsed = false;
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

        #region Minimize menu Sidebar

        private void minimizeMenuButton_Click(object sender, EventArgs e)
        {
            timerForMinimizeBar.Start();
        }


        private void TimerForMinimizeBar_Tick(object sender, EventArgs e)
        {
            if (isColapsed)
            {
                //iconPanel.Hide();
                panelMenuItems.Width = panelMenuItems.Width + 10;
                if (panelMenuItems.Width >= panelWidth)
                {
                    timerForMinimizeBar.Stop();
                    isColapsed = false;
                    this.Refresh();

                }
            }
            else
            {
                panelMenuItems.Width = panelMenuItems.Width - 10;
                if (panelMenuItems.Width <= 67)
                {
                    timerForMinimizeBar.Stop();
                    isColapsed = true;
                    this.Refresh(); ;
                }
            }
        }


        #endregion
    }
}
