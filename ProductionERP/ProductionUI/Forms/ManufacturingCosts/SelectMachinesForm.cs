using ProductionUI.UserControls;
using ProductionUI.UserControls.UCManufacturingCosts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionUI.Forms.ManufacturingCosts
{
    public partial class SelectMachinesForm : Form
    {
        private readonly UserManufacturingCostControl UserManufacturing;

        List<string> availableMachines = new List<string>();
        List<string> selectedMachines = new List<string>();
        public SelectMachinesForm(UserManufacturingCostControl userManufacturing)
        {
            InitializeComponent();
            UserManufacturing = userManufacturing;
            SeedData();

            WireUpLists();

        }
        public int MyProperty { get; set; }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            UserSelectedTechnologyControl userSelectedTechnologyControl = new UserSelectedTechnologyControl();
            UserManufacturing.AddControlsToPanel(userSelectedTechnologyControl);
            this.Close();
        }

        private void SeedData()
        {
            availableMachines.Add("Unu");
            availableMachines.Add("Doi");
            availableMachines.Add("trei");
            availableMachines.Add("Patru");
            availableMachines.Add("Cinci");
            availableMachines.Add("Sase");


        }

        private void WireUpLists()
        {
            availableMachinesListbox.DataSource = null;
            availableMachinesListbox.DataSource = availableMachines;
            availableMachinesListbox.DisplayMember = "";

            selectedMachinesListbox.DataSource = null;
            selectedMachinesListbox.DataSource = selectedMachines;
            selectedMachinesListbox.DisplayMember = "";

            availableMachinesListbox.ClearSelected();
            selectedMachinesListbox.ClearSelected();

        }

        private void MoveRightButton_Click(object sender, EventArgs e)
        {
          
                if (availableMachinesListbox.SelectedItem != null)
                {
                    string selected = availableMachinesListbox.SelectedItem.ToString();
                    availableMachines.Remove(selected);
                    selectedMachines.Add(selected);
                    availableMachinesListbox.ClearSelected();

                    WireUpLists();
                } 
        }

        private void MoveLeftButton_Click(object sender, EventArgs e)
        {
            
            if (selectedMachinesListbox.SelectedItem != null)
            {
                string selected = selectedMachinesListbox.SelectedItem.ToString();
                selectedMachines.Remove(selected);
                availableMachines.Add(selected);
                selectedMachinesListbox.ClearSelected();
                WireUpLists(); 
            }
        }

        private void MoveUpButton_Click(object sender, EventArgs e)
        {

        }

        private void MoveDownButton_Click(object sender, EventArgs e)
        {

        }
    }
}
