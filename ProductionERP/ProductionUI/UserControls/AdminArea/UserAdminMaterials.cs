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
    public partial class UserAdminMaterials : UserControl
    {
        public UserAdminMaterials()
        {
            InitializeComponent();
        }

        private void MaterialCreateButton_Click(object sender, EventArgs e)
        {
            CreateMaterialForm createMaterial = new CreateMaterialForm();
            createMaterial.ShowDialog();
        }

        private void MaterialModifyButton_Click(object sender, EventArgs e)
        {
            UpdateMaterialForm updateMaterial = new UpdateMaterialForm();
            updateMaterial.ShowDialog();
        }

        private void MaterialCatCreateButton_Click(object sender, EventArgs e)
        {
            CreateMaterialCategoryForm createMaterialCategory = new CreateMaterialCategoryForm();
            createMaterialCategory.ShowDialog();
        }

        private void MaterialCatModifyButton_Click(object sender, EventArgs e)
        {
            UpdateMachineCategoryForm updateMachineCategory = new UpdateMachineCategoryForm();
            updateMachineCategory.ShowDialog();
        }

        private void CreateWarehouseButton_Click(object sender, EventArgs e)
        {
            CreateWarehouseForm createWarehouse = new CreateWarehouseForm();
            createWarehouse.ShowDialog();
        }

        private void ModifyWarehouseButton_Click(object sender, EventArgs e)
        {
            UpdateWarehouseForm updateWarehouse = new UpdateWarehouseForm();
            updateWarehouse.ShowDialog();
        }
    }
}
