using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductionUI.Forms.ManufacturingCosts;

namespace ProductionUI.UserControls
{
    public partial class UserManufacturingCostControl : UserControl
    {
        public UserManufacturingCostControl()
        {
            InitializeComponent();
        }


        public void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            centerPanel.Controls.Clear();
            centerPanel.Controls.Add(c);
            c.BringToFront();
        }

        private void ManufacturingCostCreateButton_Click(object sender, EventArgs e)
        {
            using (SelectMachines sm = new SelectMachines(this))
            {
                sm.ShowDialog();
            }
            manufacturingCostCreateButton.Hide();
            manufacturingCostEditButton.Hide();
            manufacturingCostViewButton.Hide();
        }
    }
}
