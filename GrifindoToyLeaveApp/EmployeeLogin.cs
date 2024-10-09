using GrifindoToyLeaveApp.AppClass;
using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp
{
    public partial class EmployeeLogin : Form
    {
        EmployeeLoginClass employeeLogin = new EmployeeLoginClass();
        private bool isPasswordEmpty = true;
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void EmployeeLoginbtn_Click(object sender, EventArgs e)
        {
            employeeLogin.username = EmployeeUserNameTxt.Text;
            employeeLogin.password = EmployeePasswordTxt.Text;

            if (employeeLogin.Login())
            {
                WelcomeForm welcomeForm = new WelcomeForm(employeeLogin.username, "employee");
                welcomeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserId or Password, Correct And Retry", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /* string username = EmployeeUserNameTxt.Text;
             string password = EmployeeUserNameTxt.Text;

             string sql = "select *from Leave_Type_Table type join Employee_Table emp on emp.Emp_num = type.employee_fk where emp.Emp_num = '"+username+"' and emp.password =  '"+password+"'";
             SqlDataAdapter adapter = new SqlDataAdapter(sql , SQL.conn);
             DataTable dt = new DataTable();
             adapter.Fill(dt);

             if(dt.Rows.Count > 0)
             {
                 MessageBox.Show("Login Successful");

                 EmpUserAuthonticationClass.Id = int.Parse(dt.Rows[0]["Emp_num"].ToString());
                 EmpUserAuthonticationClass.Username = dt.Rows[0]["Emp_name"].ToString();
                 EmpUserAuthonticationClass.Password = dt.Rows[0]["password"].ToString();
                 EmpUserAuthonticationClass.LeaveType_ID = int.Parse(dt.Rows[0]["leave_type_id"].ToString());

                 EmployeeLogin em = new EmployeeLogin();
                 em.Show();
                 this.Hide();

             }
             else
             {
                 MessageBox.Show("Checked the username and password");
             }*/

        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {
            EmployeePasswordTxt.UseSystemPasswordChar = false;
            EmployeePasswordTxt.Text = "Type your Password...";
            isPasswordEmpty = true;
        }

        private void ShowPasswordChk_CheckedChanged(object sender, EventArgs e)
        {
            if (!isPasswordEmpty)
            {
                EmployeePasswordTxt.UseSystemPasswordChar = !ShowPasswordChk.Checked;
            }
        }

        private void EmployeeUserNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EmployeeUserNameTxt.Text == "Type Your Username...")
            {
                EmployeeUserNameTxt.Text = "";
            }
        }

        private void EmployeePasswordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EmployeePasswordTxt.Text == "Type your Password...")
            {

                EmployeePasswordTxt.Text = "";

                EmployeePasswordTxt.UseSystemPasswordChar = true;
            }
        }

        private void EmployeePasswordTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmployeePasswordTxt.Text))
            {
                EmployeePasswordTxt.UseSystemPasswordChar = false;
                EmployeePasswordTxt.Text = "Type Your Password...";
                isPasswordEmpty = true;
            }
            else
            {
                isPasswordEmpty = false;
            }
        }

        private void AdminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            EmployeeUserNameTxt.Clear();
            EmployeePasswordTxt.Clear();
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
