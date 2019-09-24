using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionUI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (DashboardForm dashboard = new DashboardForm())
            {
                dashboard.ShowDialog();
            }
        }
    }
}
