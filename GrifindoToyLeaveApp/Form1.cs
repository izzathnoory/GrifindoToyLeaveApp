using GrifindoToyLeaveApp.AppClass;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AdminLoginNameTxt.Text = AdminUserAuthonticationClass.Username;
        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new AdminDashboard(), form_1main_panel);
        }

        private void Employeebtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new Employee(), form_1main_panel);
        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new Admin(), form_1main_panel);
        }

        private void LeaveReqbtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            int currentEmployeeId = CurrentUser.EmployeeId;
            UserInterface.LoadPanelForm(new Leave_Request(currentEmployeeId), form_1main_panel);
        }

        private void LeaveTypbtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new Leave_Type(), form_1main_panel);
        }

        private void EmpRoastbtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new Employee_Roaster(), form_1main_panel);
        }

        private void Guardianbtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new Guardian(), form_1main_panel);
        }

        private void EmpMonbtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new Employee_Mobile(), form_1main_panel);
        }

        private void GuardMobbtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new Guardian_mobile(), form_1main_panel);
        }

        private void Insurancebtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new Insurance(), form_1main_panel);
        }

        private void CloseApplicationbtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.CloseApplication();
        }

        private void MinimizeFormbtm_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.MinimizeApplication(this);
        }

        private void LeaveApprovelBtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new LeaveApprovel(), form_1main_panel);
        }

        private void LeaveReportBtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new LeaveReport(),form_1main_panel);
        }

        private void AdminUserTxt_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dashboardbtn.PerformClick();
            UserInterface.LoadPanelForm(new AdminDashboard(), form_1main_panel);
        }
    }
}
