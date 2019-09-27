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
    public partial class UpdateMachineForm : Form
    {
        public UpdateMachineForm()
        {
            InitializeComponent();
        }

        private void CreateCategoryButton_Click(object sender, EventArgs e)
        {
            CreateMachineCategoryForm createMachineCategory = new CreateMachineCategoryForm();
            createMachineCategory.ShowDialog();
        }
    }
}
