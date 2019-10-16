using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleConnectionSQL.DataLayer;

namespace SampleConnectionSQL.PresentationLayer
{
    public partial class MaterialsForm : Form
    {
        Materials materials = new Materials();

        string Operation = "Insert";
        string Id;

        public MaterialsForm()
        {
            InitializeComponent();
        }
        
        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadUnits();
            LoadMaterials();
        }

        private void ClearForm()
        {
            textBoxMaterialNumber.Clear();
            textBoxDescription.Clear();
            textBoxPrice.Clear();
        }

        private void LoadCustomers()
        {
            
            //Materials materials = new Materials();
            comboBoxCustomers.DataSource = materials.CustomersList();
            comboBoxCustomers.DisplayMember = "Description";
            comboBoxCustomers.ValueMember = "Id";
            comboBoxCustomers.SelectedIndex = -1;
        }

        private void LoadUnits()
        {
            //Materials materials = new Materials();
            comboBoxMeasUnits.DataSource = materials.MaterialUnitList();
            comboBoxMeasUnits.DisplayMember = "Unit";
            comboBoxMeasUnits.ValueMember = "Id";
            comboBoxMeasUnits.SelectedIndex = -1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Operation == "Insert")
            {
                materials.CustomerId = Convert.ToInt32(comboBoxCustomers.SelectedValue);
                materials.UnitID = Convert.ToInt32(comboBoxMeasUnits.SelectedValue);
                materials.MaterialNumber = Convert.ToInt32(textBoxMaterialNumber.Text);
                materials.Description = textBoxDescription.Text;
                materials.Price=  Convert.ToDouble(textBoxPrice.Text);

                materials.InsertMaterial();

                MessageBox.Show("Inserted success."); 
            }
            else if(Operation == "Edit")
            {
                materials.Id = Convert.ToInt32(Id);
                materials.CustomerId = Convert.ToInt32(comboBoxCustomers.SelectedValue);
                materials.UnitID = Convert.ToInt32(comboBoxMeasUnits.SelectedValue);
                materials.MaterialNumber = Convert.ToInt32(textBoxMaterialNumber.Text);
                materials.Description = textBoxDescription.Text;
                materials.Price = Convert.ToDouble(textBoxPrice.Text);

                materials.EditMaterial();

                Operation = "Insert";

                MessageBox.Show("Edit success.");
            }

            LoadMaterials();
            ClearForm();
        }

        private void LoadMaterials()
        {
            dataGridViewMaterials.DataSource = materials.MaterialsList();
            dataGridViewCustomers.DataSource = materials.CustomersList();
            dataGridViewUnits.DataSource = materials.MaterialUnitList();
            dataGridViewMaterialsRaw.DataSource = materials.MaterialsListRaw();

        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaterials.SelectedRows.Count >0)
            {
                Operation = "Edit";
                textBoxMaterialNumber.Text = dataGridViewMaterials.CurrentRow.Cells["MaterialNumber"].Value.ToString();
                textBoxDescription.Text = dataGridViewMaterials.CurrentRow.Cells["Description"].Value.ToString();
                textBoxPrice.Text = dataGridViewMaterials.CurrentRow.Cells["Price"].Value.ToString();
                comboBoxMeasUnits.Text = dataGridViewMaterials.CurrentRow.Cells["Unit"].Value.ToString();
                comboBoxCustomers.Text = dataGridViewMaterials.CurrentRow.Cells["Description1"].Value.ToString();
                Id = dataGridViewMaterials.CurrentRow.Cells["Id"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Select one row!");
            }
        }

        private void buttonEditForm_Click(object sender, EventArgs e)
        {

            if (dataGridViewMaterials.SelectedRows.Count > 0)
            {

                MentenanceMaterialForm mentenanceMaterial = new MentenanceMaterialForm();
                mentenanceMaterial.Operation = "Edit";
                mentenanceMaterial.LoadCustomers();
                mentenanceMaterial.LoadUnits();


                mentenanceMaterial.Id = dataGridViewMaterials.CurrentRow.Cells["Id"].Value.ToString();
                mentenanceMaterial.textBoxMaterialNumber.Text = dataGridViewMaterials.CurrentRow.Cells["MaterialNumber"].Value.ToString();
                mentenanceMaterial.textBoxDescription.Text = dataGridViewMaterials.CurrentRow.Cells["Description"].Value.ToString();
                mentenanceMaterial.textBoxPrice.Text = dataGridViewMaterials.CurrentRow.Cells["Price"].Value.ToString();
                mentenanceMaterial.comboBoxMeasUnits.Text = dataGridViewMaterials.CurrentRow.Cells["Unit"].Value.ToString();
                mentenanceMaterial.comboBoxCustomers.Text = dataGridViewMaterials.CurrentRow.Cells["Description1"].Value.ToString();

                mentenanceMaterial.ShowDialog();

                LoadMaterials();
            }
            else
            {
                MessageBox.Show("Select one row!");
            }
        }

        private void buttonNewMaterial_Click(object sender, EventArgs e)
        {
            MentenanceMaterialForm mentenanceMaterial = new MentenanceMaterialForm();
            mentenanceMaterial.Operation = "Insert";
            mentenanceMaterial.LoadCustomers();
            mentenanceMaterial.LoadUnits();
            mentenanceMaterial.ShowDialog();

            LoadMaterials();

               
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaterials.SelectedRows.Count >0)
            {
                materials.Id = Convert.ToInt32(dataGridViewMaterials.CurrentRow.Cells["Id"].Value.ToString());
                materials.DeleteProduct();
                MessageBox.Show($"Material: {dataGridViewMaterials.CurrentRow.Cells["MaterialNumber"].Value.ToString()} has been deleted.");
                LoadMaterials();
            }
            else
            {
                MessageBox.Show("Select one row");
            }

        }
    }
}
