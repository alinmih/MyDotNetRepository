using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionUI.Forms.AdminArea
{
    public partial class CreateMaterialForm : Form
    {
        public CreateMaterialForm()
        {
            InitializeComponent();
        }

        private void CreateTypeButton_Click(object sender, EventArgs e)
        {
            CreateMaterialCategoryForm createMaterialCategory = new CreateMaterialCategoryForm();
            createMaterialCategory.ShowDialog();
        }

        private void CreateUnitButton_Click(object sender, EventArgs e)
        {
            CreateMaterialMeasureUnitForm createMaterialMeasure = new CreateMaterialMeasureUnitForm();
            createMaterialMeasure.ShowDialog();
        }
    }
}
