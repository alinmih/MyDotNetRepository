using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        //reference to interface
        private ITeamRequester callingForm;

        //list that contain the persons 
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
            //CreateSampleData();

            //call method inside constructor
            WireUpLists();
        }

        //method for populatin the lists
        

        //seed the lists with data
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Correy" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Lisa", LastName = "Sue" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jones", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "John", LastName = "Joe" });

        }

        private void WireUpLists()
        {
            // TODO - Find better way to refresh lists
            //initialize the datasource 
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            //initialize the datasource 
            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                //add newly create person to listbox
                selectedTeamMembers.Add(p);
                WireUpLists();

                //clear form
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("YOu need to fill all of the fields.");
            }
        }

        private bool ValidateForm()
        {

            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        //move member from dropdown to listbox
        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            //get the selected item object
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            //check if p is null not move the items
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        //move from listbox to dropdown
        private void RemoveSelectedMemberButton_Click(object sender, EventArgs e)
        {

            //get the selected item object
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            //check if p is null not move the items
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);

            //call the method from interface
            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
