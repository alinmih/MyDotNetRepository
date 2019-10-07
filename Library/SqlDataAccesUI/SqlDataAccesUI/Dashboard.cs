using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlDataAccesUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            peopleFoundListbox.DataSource = people;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people= db.GetPeople(nameText.Text);

            UpdateBinding();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertPerson(nameTextIns.Text, locationTextIns.Text, phoneTextIns.Text);
            nameTextIns.Text = "";
            locationTextIns.Text = "";
            phoneTextIns.Text = "";

        }
    }
}
