using GrifindoToyLeaveApp.AppClass;
using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp
{
    public partial class LoginForm : Form
    {
        AdminLoginClass admin = new AdminLoginClass();
        private bool isPasswordEmpty = true;
        public LoginForm()
        {
            InitializeComponent();
        }

            private void AdminLoginbtn_Click(object sender, EventArgs e)
            {
                admin.username = AdminUserNametxt.Text;
                admin.password = AdminPasswordtxt.Text;

                if (admin.Login())
                {
                    WelcomeForm welcomeForm = new WelcomeForm(admin.username, "admin");
                    welcomeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password, Correct And Retry", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void AdminUserNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AdminUserNametxt.Text == "Type your Username...")
            {

                AdminUserNametxt.Text = "";
            }
        }

        private void AdminPasswordtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AdminPasswordtxt.Text == "Type your password...")
            {

                AdminPasswordtxt.Text = "";

                AdminPasswordtxt.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
             AdminPasswordtxt.UseSystemPasswordChar = false;
             AdminPasswordtxt.Text = "Type your password...";
             isPasswordEmpty = true;

        }

        private void ShowPasswordChk_CheckedChanged(object sender, EventArgs e)
        {
            if (!isPasswordEmpty)
            {
                AdminPasswordtxt.UseSystemPasswordChar = !ShowPasswordChk.Checked;
            }
        }

        private void AdminPasswordtxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdminPasswordtxt.Text))
            {
                AdminPasswordtxt.UseSystemPasswordChar = false;
                AdminPasswordtxt.Text = "Type your password...";
                isPasswordEmpty = true;
            }
            else
            {
                isPasswordEmpty = false;
            }
        }

        private void EmployeeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeLogin employeeLogin = new EmployeeLogin();
            employeeLogin.Show();
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AdminUserNametxt.Clear();
            AdminPasswordtxt.Clear();
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
