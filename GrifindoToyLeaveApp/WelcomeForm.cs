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
    public partial class WelcomeForm : Form
    {
        LoginForm loginForm = new LoginForm();
        EmployeeLogin employeeLogin = new EmployeeLogin();

        private string username = "Loading...";
        private string type = "";
        public WelcomeForm()
        {
            InitializeComponent();
        }


        public WelcomeForm(string username, string type)
        {
            InitializeComponent();
            this.username = username;
            this.type = type;
        }



        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            UsernameTxt.Text = username;

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(type == "admin")
            {
                timer1.Stop();
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                timer1.Stop();
                EmployeeAccess employeeAccess = new EmployeeAccess();
                employeeAccess.Show();
                this.Hide();
            }
            
        }

        private bool IsAdmin(string username)
        {
            return username.Equals("admin", StringComparison.OrdinalIgnoreCase);
        }

        private void UsernameTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
