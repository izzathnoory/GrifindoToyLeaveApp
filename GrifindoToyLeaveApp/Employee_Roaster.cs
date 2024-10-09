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
    public partial class Employee_Roaster : Form
    {
        EmployeeRoasterClass employeeRoaster = new EmployeeRoasterClass();
        EmployeeClass employe = new EmployeeClass();
        LeaveRequestClass leaveRequest = new LeaveRequestClass();
        private string isMorningHalfDay = "No";
        public Employee_Roaster()
        {
            InitializeComponent();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            employeeRoaster.Save();
        }

        
        private void Employee_Roaster_Load(object sender, EventArgs e)
        {
            try
            {
                employe.LoadAsFk(EmployeeIdCmb);

                // Populate OffDayCmb and HalfDayCmb with days of the week
                string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

                OffDayCmb.Items.AddRange(daysOfWeek);
                HalfDayCmb.Items.AddRange(daysOfWeek);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadDataFromDB();
            employeeRoaster._loadTable = EmpRoasSqlDataView;  
        }

        public (string offDay, string halfDay) CalculationDay(int employeeId)
        {
            var days = employeeRoaster.GetDaysByEmployeeId(employeeId);
            return (days.offDay, days.halfDay);
        }

        private void loadDataFromDB()
        {
            employeeRoaster.LoadData(EmpRoasSqlDataView);
        }

        private void EmpRoasSqlDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get row index from data gridview
            int RowIndeNumber = e.RowIndex;

            if (RowIndeNumber >= 0)
            {

                // get data and store in the  variable by using selected row index
                string empName = EmpRoasSqlDataView.Rows[RowIndeNumber].Cells["Name"].Value.ToString();
                string roasId = EmpRoasSqlDataView.Rows[RowIndeNumber].Cells["RoasId"].Value.ToString();
                int employeeId = int.Parse(EmpRoasSqlDataView.Rows[RowIndeNumber].Cells["EmpId"].Value.ToString());
                string starttime = EmpRoasSqlDataView.Rows[RowIndeNumber].Cells["StartTime"].Value.ToString();
                string endtime = EmpRoasSqlDataView.Rows[RowIndeNumber].Cells["EndTime"].Value.ToString();
                string offday = EmpRoasSqlDataView.Rows[RowIndeNumber].Cells["OffDay"].Value.ToString();
                string halfday = EmpRoasSqlDataView.Rows[RowIndeNumber].Cells["HalfDay"].Value.ToString();
                string morninghalfdayornot = EmpRoasSqlDataView.Rows[RowIndeNumber].Cells["MorningHalfDayOrNot"].Value.ToString();

                // to assign the selected data to controls
                EmployeeIdCmb.Text = empName;
                EmployeeRoasIdTxt.Text = roasId;
                StartTimeTimePicker.Text = starttime;
                EndTimeTimePicker.Text = endtime;
                var days = CalculationDay(employeeId);
                OffDayCmb.Text = days.offDay;
                HalfDayCmb.Text = days.halfDay;


                employeeRoaster.MorningHalfDay = morninghalfdayornot;
                enablehalfday(morninghalfdayornot);
            }
        }

        private void enablehalfday(string MorHalfday)
        {
            if (MorHalfday == "Yes")
            {
                HalfDayYesRB.Checked = true;
            }
            else
            {
                HalfDayNoRB.Checked = true;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            employeeRoaster.Update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            employeeRoaster.Delete();
        }

        private void EmployeeIdCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmployeeIdCmb.SelectedValue != null)
            {
                employeeRoaster.EmpId = EmployeeIdCmb.SelectedValue.ToString();
            }

        }

        private void EmployeeRoasIdTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(EmployeeRoasIdTxt.Text) && int.TryParse(EmployeeRoasIdTxt.Text, out int result))
                {
                    employeeRoaster.ID = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StartTimeTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.TryParse(StartTimeTimePicker.Text, out DateTime startTime))
                {
                    employeeRoaster.StartTime = startTime;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EndTimeTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.TryParse(EndTimeTimePicker.Text, out DateTime endTime))
                {
                    employeeRoaster.EndTime = endTime;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void HalfDayYesRB_CheckedChanged(object sender, EventArgs e)
        {
            employeeRoaster.MorningHalfDay = "Yes";
        }

        private void HalfDayNoRB_CheckedChanged(object sender, EventArgs e)
        {
            employeeRoaster.MorningHalfDay = "No";
        }

        private void SearchBoxTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchBoxTxt.Text != "")
            {
                employeeRoaster.Search(SearchBoxTxt.Text);
            }
            else
            {
                loadDataFromDB();
            }
        }

        private void OffDayCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(OffDayCmb.Text))
                {
                    employeeRoaster.OffDay = OffDayCmb.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HalfDayCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(HalfDayCmb.Text))
                {
                    employeeRoaster.HalfDay = HalfDayCmb.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            employeeRoaster.Clear(this);
        }
    }
}
