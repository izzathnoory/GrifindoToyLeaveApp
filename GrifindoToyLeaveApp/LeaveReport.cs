using GrifindoToyLeaveApp.AppClass;
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
    public partial class LeaveReport : Form
    {
        EmployeeClass employee = new EmployeeClass();
        LeaveReportClass leaveReport = new LeaveReportClass();
        public LeaveReport()
        {
            InitializeComponent();
        }


        private void loadDataFromDB()
        {
            leaveReport.AllTakenLeaveCount(LeaveCountGenerateGridView);
            leaveReport.AllTakenLeaveDetail(LeaveDetailGenerateGridView);
            leaveReport.SpecificTakenLeaveCount(LeaveDetailGenerateGridView);
            leaveReport.SpecificTakenLeaveDetail(LeaveDetailGenerateGridView);
        }

        

        private void LeaveReport_Load(object sender, EventArgs e)
        {
            employee.LoadAsFkWithAll(EmployeeCmb);
            loadDataFromDB();
            ReportsGenerateBtn_Click(sender, e);
        }

        private void StartDateDTP_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                leaveReport.StartDate = DateTime.Parse(StartDateDTP.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EndDateDTP_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                leaveReport.EndDate = DateTime.Parse(EndDateDTP.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReportsGenerateBtn_Click(object sender, EventArgs e)
        {
            string employeeID = EmployeeCmb.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(employeeID))
            {
                MessageBox.Show("Please select an employee.");
                return;
            }

            leaveReport.StartDate = StartDateDTP.Value;
            leaveReport.EndDate = EndDateDTP.Value;
            leaveReport.ID = employeeID;  // Add this line to set the ID property

            if (employeeID == "0")
            {
                // All employees
                leaveReport.AllTakenLeaveCount(LeaveCountGenerateGridView);
                leaveReport.AllTakenLeaveDetail(LeaveDetailGenerateGridView);
            }
            else
            {
                // Specific employee
                leaveReport.SpecificTakenLeaveCount(LeaveCountGenerateGridView);
                leaveReport.SpecificTakenLeaveDetail(LeaveDetailGenerateGridView);
            }
        }
    }
}
