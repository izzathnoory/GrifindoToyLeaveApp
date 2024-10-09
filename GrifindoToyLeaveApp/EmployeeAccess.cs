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
    public partial class EmployeeAccess : Form
    {
        public EmployeeAccess()
        {
            InitializeComponent();
            EmpLoginNameTxt.Text = EmpUserAuthonticationClass.Username;
        }

        private void Employeebtn_Click_1(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new EmpRequestLeave(), EmployeeAccessMainPanel);
        }

        private void LeaveReportBtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new EmployeeLeaveReport(), EmployeeAccessMainPanel);
        }

        private void LeaveRequestBtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            int currentEmployeeId = CurrentUser.EmployeeId;
            UserInterface.LoadPanelForm(new Leave_Request(currentEmployeeId), EmployeeAccessMainPanel);
        }

        internal void trigerLeaveRequestButtonClick()
        {
            UserInterface.LoadPanelForm(new EmpRequestLeave(), EmployeeAccessMainPanel);
        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            UserInterface.ChangeButtonColor(sender as Button);
            UserInterface.LoadPanelForm(new EmployeeDashboard(this), EmployeeAccessMainPanel);
        }

        private void EmployeeAccess_Load(object sender, EventArgs e)
        {
            Dashboardbtn_Click(Dashboardbtn, EventArgs.Empty);
        }

        private void CloseApplicationbtn_Click(object sender, EventArgs e)
        {
            UserInterface.CloseApplication();
        }

        private void MinimizeFormbtm_Click(object sender, EventArgs e)
        {
            UserInterface.MinimizeApplication(this);
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
    }
}
