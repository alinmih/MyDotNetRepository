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


        private void LoadCustomers()
        {
            //Materials materials = new Materials();
            comboBoxCustomers.DataSource = materials.CustomersList();
            comboBoxCustomers.DisplayMember = "Description";
            comboBoxCustomers.ValueMember = "Id";
        }

        private void LoadUnits()
        {
            //Materials materials = new Materials();
            comboBoxMeasUnits.DataSource = materials.MaterialUnitList();
            comboBoxMeasUnits.DisplayMember = "Unit";
            comboBoxMeasUnits.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            materials.InsertMaterial(Convert.ToInt32(comboBoxCustomers.SelectedValue), 
                Convert.ToInt32(comboBoxMeasUnits.SelectedValue), 
                Convert.ToInt32(textBoxMaterialNumber.Text),
                textBoxDescription.Text, 
                Convert.ToDouble(textBoxPrice.Text));

            MessageBox.Show("Inserted success.");

            LoadMaterials();
        }

        private void LoadMaterials()
        {
            dataGridView.DataSource = materials.MaterialsList();

        }
    }
}
