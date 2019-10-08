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
    public partial class AdminItemsUserControl : UserControl
    {
        public AdminItemsUserControl()
        {
            InitializeComponent();
        }

        private void MovePanelTop(Control btn)
        {
            panelTop.Left = btn.Left;
            panelTop.Width = btn.Width;
        }

        private void buttonRawMaterials_Click(object sender, EventArgs e)
        {
            MovePanelTop(buttonRawMaterials);
        }

        private void buttonMachines_Click(object sender, EventArgs e)
        {
            MovePanelTop(buttonMachines);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            MovePanelTop(buttonUsers);
        }
    }
}
