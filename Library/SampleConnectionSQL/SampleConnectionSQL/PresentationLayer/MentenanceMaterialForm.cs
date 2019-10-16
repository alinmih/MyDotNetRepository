using SampleConnectionSQL.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleConnectionSQL.PresentationLayer
{
    public partial class MentenanceMaterialForm : Form
    {
        Materials materials = new Materials();

        public string Operation = "";
        public string Id;

        public MentenanceMaterialForm()
        {
            InitializeComponent();
        }

        private void MentenanceMaterialForm_Load(object sender, EventArgs e)
        {
            //LoadCustomers();
            //LoadUnits();
        }

        public void LoadCustomers()
        {
            //Materials materials = new Materials();
            comboBoxCustomers.SelectedIndex = -1;
            comboBoxCustomers.DataSource = materials.CustomersList();
            comboBoxCustomers.DisplayMember = "Description";
            comboBoxCustomers.ValueMember = "Id";
        }

        public void LoadUnits()
        {
            //Materials materials = new Materials();
            comboBoxMeasUnits.DataSource = materials.MaterialUnitList();
            comboBoxMeasUnits.DisplayMember = "Unit";
            comboBoxMeasUnits.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Operation == "Insert")
            {
                materials.CustomerId = Convert.ToInt32(comboBoxCustomers.SelectedValue);
                materials.UnitID = Convert.ToInt32(comboBoxMeasUnits.SelectedValue);
                materials.MaterialNumber = Convert.ToInt32(textBoxMaterialNumber.Text);
                materials.Description = textBoxDescription.Text;
                materials.Price = Convert.ToDouble(textBoxPrice.Text);

                materials.InsertMaterial();

                MessageBox.Show("Inserted success.");
                this.Close();
            }
            else if (Operation == "Edit")
            {
                materials.Id = Convert.ToInt32(Id);
                materials.CustomerId = Convert.ToInt32(comboBoxCustomers.SelectedValue);
                materials.UnitID = Convert.ToInt32(comboBoxMeasUnits.SelectedValue);
                materials.MaterialNumber = Convert.ToInt32(textBoxMaterialNumber.Text);
                materials.Description = textBoxDescription.Text;
                materials.Price = Convert.ToDouble(textBoxPrice.Text);

                materials.EditMaterial();

                MessageBox.Show("Edit success.");

                this.Close();
            }
        }
    }
}
