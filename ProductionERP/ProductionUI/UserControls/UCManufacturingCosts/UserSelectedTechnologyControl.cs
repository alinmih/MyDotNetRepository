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

namespace ProductionUI.UserControls.UCManufacturingCosts
{
    public partial class UserSelectedTechnologyControl : UserControl
    {
        public UserSelectedTechnologyControl()
        {
            InitializeComponent();
        }

        private void PartMoreDimButton_Click(object sender, EventArgs e)
        {
            PartMoreDimensionsForm partMoreDimensions = new PartMoreDimensionsForm();
            partMoreDimensions.Show();
        }

        private void RawSearchButton_Click(object sender, EventArgs e)
        {
            SearchRawMaterialForm searchRaw = new SearchRawMaterialForm();
            searchRaw.Show();
        }
    }
}
