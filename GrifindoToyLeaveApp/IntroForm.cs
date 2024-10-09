using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            LoginForm AdminLogin = new LoginForm();
            AdminLogin.Show();
            this.Hide();
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeLogin employeeLogin = new EmployeeLogin();
            employeeLogin.Show();
            this.Hide();
        }

        private void CloseApplicationBtn_Click(object sender, EventArgs e)
        {
            UserInterface.CloseApplication();
        }

        private void MinimizeFormBtn_Click(object sender, EventArgs e)
        {
            UserInterface.MinimizeApplication(this);
        }
    }
}
