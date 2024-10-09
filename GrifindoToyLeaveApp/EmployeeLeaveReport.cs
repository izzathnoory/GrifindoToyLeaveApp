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
    public partial class EmployeeLeaveReport : Form
    {
        EmployeeLeaveReportClass LeaveReport = new EmployeeLeaveReportClass();
        public EmployeeLeaveReport()
        {
            InitializeComponent();
            EmployeeNameTxt.Text = EmpUserAuthonticationClass.Username;
        }

        private void EmployeeLeaveReport_Load(object sender, EventArgs e)
        {
            LeaveReport.SpecificTakenLeaveCount(LeaveDetailGenerateGridView);
            LeaveReport.SpecificTakenLeaveDetail(LeaveDetailGenerateGridView);
        }

        private void StartDateDTP_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LeaveReport.StartDate = DateTime.Parse(StartDateDTP.Text);
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
                LeaveReport.EndDate = DateTime.Parse(EndDateDTP.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReportsGenerateBtn_Click(object sender, EventArgs e)
        {
            LeaveReport.StartDate = StartDateDTP.Value;
            LeaveReport.EndDate = EndDateDTP.Value;
            LeaveReport.SpecificTakenLeaveCount(LeaveCountGenerateGridView);
            LeaveReport.SpecificTakenLeaveDetail(LeaveDetailGenerateGridView);
        }
    }
}
