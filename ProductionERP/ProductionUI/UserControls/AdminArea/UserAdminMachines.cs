using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductionUI.Forms.AdminArea;

namespace ProductionUI.UserControls.AdminArea
{
    public partial class UserAdminMachines : UserControl
    {
        public UserAdminMachines()
        {
            InitializeComponent();
        }

        private void MachineCreateButton_Click(object sender, EventArgs e)
        {
            CreateMachineForm createMachine = new CreateMachineForm();
            createMachine.ShowDialog();
        }

        private void MachineModifyButton_Click(object sender, EventArgs e)
        {
            UpdateMachineForm updateMachine = new UpdateMachineForm();
            updateMachine.ShowDialog();
        }

        private void CatCreateButton_Click(object sender, EventArgs e)
        {
            CreateMachineCategoryForm createMachineCategory = new CreateMachineCategoryForm();
            createMachineCategory.ShowDialog();
        }

        private void CatModifyButton_Click(object sender, EventArgs e)
        {
            UpdateMachineCategoryForm updateMachineCategory = new UpdateMachineCategoryForm();
            updateMachineCategory.ShowDialog();
        }
    }
}
