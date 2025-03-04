using GrifindoToyLeaveApp.AppClass;
using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp
{
    public partial class Leave_Request : Form
    {
        LeaveRequestClass leaveRequest = new LeaveRequestClass();
        AdminClass admin = new AdminClass();
        LeaveTypeClass leaveType = new LeaveTypeClass();
        Leave_Type leavetype = new Leave_Type();
        EmployeeClass employee = new EmployeeClass();
        EmpRequestLeaveClass employeeLeave = new EmpRequestLeaveClass();
        EmployeeRoasterClass employeeRoaster = new EmployeeRoasterClass();
        Employee_Roaster EmpRoas = new Employee_Roaster();
        DateTime dateValue = new DateTime();


        string selectedEmployeeOffDay = null;
        string selectedEmployeeHalfDay = null;

        private string employeeOffDay;
        private string employeeHalfDay;
        private int _currentEmployeeId;
        public Leave_Request(int currentEmployeeId)
        {
            InitializeComponent();
            _currentEmployeeId = currentEmployeeId;
            employeeLeave._loadTable = LeaReqSqlDataView;
            LeaveBegDaDTP.ValueChanged += DatePickers_ValueChanged;
            LeaveEndDaDTP.ValueChanged += DatePickers_ValueChanged;
            LeaveTypeCmb.SelectedIndexChanged += LeaveTypeCmb_SelectedIndexChanged;
            leaveRequest.LeaveStatus = "Pending";
        }

        private void DatePickers_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = LeaveBegDaDTP.Value.Date;
                DateTime endDate = LeaveEndDaDTP.Value.Date;

                if (startDate <= endDate)
                {
                    List<string> dayNamesBetween = GetDayNamesBetween(startDate, endDate);

                    List<string> offDays = new List<string>();
                    List<string> halfDays = new List<string>();

                    // Use class-level variables for employeeOffDay and employeeHalfDay
                    foreach (var dayName in dayNamesBetween)
                    {
                        if (dayName.Equals(employeeOffDay, StringComparison.OrdinalIgnoreCase))
                        {
                            offDays.Add(dayName);
                        }
                        if (dayName.Equals(employeeHalfDay, StringComparison.OrdinalIgnoreCase))
                        {
                            halfDays.Add(dayName);
                        }
                    }

                    string message = $"Off Days: {string.Join(", ", offDays)}\nHalf Days: {string.Join(", ", halfDays)}";
                    MessageBox.Show(message, "Days Status");
                }
                else
                {
                    MessageBox.Show("The start date must be before or equal to the end date.", "Date Selection Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private List<string> GetDayNamesBetween(DateTime start, DateTime end)
        {
            List<string> dayNamesList = new List<string>();

            // Loop through each date between the start and end date, inclusive
            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                string dayName = date.ToString("dddd"); // Get the day of the week
                dayNamesList.Add(dayName); // Add the day name to the list
            }

            return dayNamesList; // Return the list of day names
        }

        private void DisplayAvailableLeave(int employeeId)
        {
            try
            {
                string leaveTypeStr = leaveRequest.LeaveType; // Store the leave type string
                LeaveTypeClass leaveTypeClass = new LeaveTypeClass(); // Initialize the LeaveTypeClass object

                // Validate leave type before calling GetAvailableLeave
                if (leaveTypeStr == "Annual" || leaveTypeStr == "Casual" || leaveTypeStr == "Short")
                {
                    string availableLeaveStr = leaveTypeClass.GetAvailableLeave(leaveTypeStr, employeeId); // Correct method call
                    int availableLeave = int.Parse(availableLeaveStr);
                    MessageBox.Show($"Available Leave for Employee {employeeId}: {availableLeave}", "Available Leave");
                }
                else
                {
                    MessageBox.Show("Invalid leave type selected. Please choose a valid leave type.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching available leave: " + ex.Message);
            }
        }

        private void LeavReqInserbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(leaveRequest.LeaveType))
                {
                    MessageBox.Show("Leave type cannot be empty.", "Validation Error");
                    return;
                }
                if (string.IsNullOrEmpty(leaveRequest.Reason))
                {
                    MessageBox.Show("Reason cannot be empty.", "Validation Error");
                    return;
                }

                DateTime startDate = LeaveBegDaDTP.Value.Date;
                DateTime endDate = LeaveEndDaDTP.Value.Date;
                DateTime currentDate = DateTime.Now.Date;

                var (employeeStartTime, employeeEndTime) = employeeRoaster.GetWorkTimesByEmployeeId(_currentEmployeeId);
                TimeSpan currentTime = DateTime.Now.TimeOfDay;

                if ((leaveRequest.LeaveType == "Casual" || leaveRequest.LeaveType == "Short") &&
                currentTime > employeeStartTime && currentTime < employeeEndTime)
                {
                    MessageBox.Show($"You must request leave before your work starts.", "Invalid Leave Request");
                    return;
                }

                if (string.IsNullOrEmpty(employeeOffDay))
                {
                    MessageBox.Show("Employee's off day is not set. Please select a valid leave type.");
                    return;
                }
                if (string.IsNullOrEmpty(employeeHalfDay))
                {
                    MessageBox.Show("Employee's half day is not set. Please select a valid leave type.");
                    return;
                }

                List<string> dayNamesBetween = GetDayNamesBetween(startDate, endDate);

                int offDayCount = dayNamesBetween.Count(day => day.Equals(selectedEmployeeOffDay, StringComparison.OrdinalIgnoreCase));
                double halfDayCount = dayNamesBetween.Count(day => day.Equals(selectedEmployeeHalfDay, StringComparison.OrdinalIgnoreCase)) * 0.5;
                double totalLeaveDays = (endDate - startDate).Days + 1;

                leaveRequest.OffDayCount = offDayCount;
                leaveRequest.HalfDayCount = halfDayCount;
                leaveRequest.LeavesTaken = totalLeaveDays - (offDayCount + halfDayCount);

                string availableLeaveStr = leaveType.GetAvailableLeave(leaveRequest.LeaveType, _currentEmployeeId);
                if (string.IsNullOrEmpty(availableLeaveStr) || availableLeaveStr == "0")
                {
                    MessageBox.Show("Available leave is 0 or not set. Please check the leave type.");
                    return;
                }

                int availableLeave = int.Parse(availableLeaveStr);
                if (leaveRequest.LeavesTaken > availableLeave)
                {
                    MessageBox.Show("Your leave request exceeds the allowed leave count. Please adjust your leave days.");
                    return;
                }

                leaveRequest.save();
                leavetype.DeductLeave(leaveRequest.LeaveType, leaveRequest.LeavesTaken);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsAnnualLeaveValid(DateTime startDate, DateTime currentDate)
        {
            TimeSpan difference = startDate - currentDate;
            return difference.TotalDays >= 7;
        }



        private void Leave_Request_Load(object sender, EventArgs e)
        {
            try
            {
                admin.LoadAsFk(LeaveReqAdmiCmb);

                leaveType.LoadAsFk(LeaveTypeCmb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadDataFromDB();
            leaveRequest._loadTable = LeaReqSqlDataView;
            ShortLeaveRB_CheckedChanged(null, EventArgs.Empty);
            DisableRB();
        }

        private void DisableRB()
        {
            PendingRB.Enabled = false;
            AccesptRB.Enabled = false;
            RejectRB.Enabled = false;
            PendingRB.Enabled =true;
        }

        private void loadDataFromDB()
        {
            leaveRequest.loadData(LeaReqSqlDataView);
        }

        private void LeaReqSqlDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                // get row index from data gridview
                int RowIndeNumber = e.RowIndex;

                if (RowIndeNumber >= 0)
                {
                    // get data and store in the  variable by using selected row index
                    string adminUserName = LeaReqSqlDataView.Rows[RowIndeNumber].Cells["AdmName"].Value.ToString();
                    //string employeeName = LeaReqSqlDataView.Rows[RowIndeNumber].Cells["EmpName"].Value.ToString();
                    string leavetypeid = LeaReqSqlDataView.Rows[RowIndeNumber].Cells["EmpName"].Value.ToString();
                    string leavereqid = LeaReqSqlDataView.Rows[RowIndeNumber].Cells["ReqId"].Value.ToString();
                    string reason = LeaReqSqlDataView.Rows[RowIndeNumber].Cells["Reason"].Value.ToString();
                    string begindate = LeaReqSqlDataView.Rows[RowIndeNumber].Cells["BeginDate"].Value.ToString();
                    string enddate = LeaReqSqlDataView.Rows[RowIndeNumber].Cells["EndDate"].Value.ToString();
                    string _leaveStatus = LeaReqSqlDataView.Rows[RowIndeNumber].Cells["LeaveStatus"].Value.ToString();
                    string _leaveType = LeaReqSqlDataView.Rows[RowIndeNumber].Cells["LeaveType"].Value.ToString();
                    string shortLeaveTime = LeaReqSqlDataView.Rows[RowIndeNumber].Cells["ShortLeaveTime"].Value.ToString();

                    // to assign the selected data to controls
                    LeaveReqAdmiCmb.Text = adminUserName;
                    LeaveTypeCmb.Text = leavetypeid;
                    LeaveReqIdTxt.Text = leavereqid;
                    Reasontxt.Text = reason;
                    LeaveBegDaDTP.Value = DateTime.Parse(begindate);
                    LeaveEndDaDTP.Value = DateTime.Parse(enddate);
                    ShortLeaveDTP.Text = shortLeaveTime;

                    leaveRequest.LeaveStatus = _leaveStatus;
                    enableStatus(_leaveStatus);
                    leaveRequest.LeaveType = _leaveType;
                    ; SelectLeaveType(_leaveType);
                    //employeeLeave.loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void enableStatus(string status)
        {
            if (status == "Accepted")
            {
                AccesptRB.Checked = true;
            }
            else if (status == "Rejected")
            {
                RejectRB.Checked = true;
            }
            else
            {
                PendingRB.Checked = true;
            }

        }

        private void SelectLeaveType(string type)
        {
            if (type == "Annual")
            {
                AnnualLeaveRB.Checked = true;
            }
            else if (type == "Casual")
            {
                CasualLeaveRb.Checked = true;
            }
            else
            {
                ShortLeaveRB.Checked = true;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(leaveRequest.LeaveType))
                {
                    MessageBox.Show("Leave type cannot be empty.", "Validation Error");
                    return;
                }
                if (string.IsNullOrEmpty(leaveRequest.Reason))
                {
                    MessageBox.Show("Reason cannot be empty.", "Validation Error");
                    return;
                }

                DateTime startDate = LeaveBegDaDTP.Value.Date;
                DateTime endDate = LeaveEndDaDTP.Value.Date;
                DateTime currentDate = DateTime.Now.Date;

                var (employeeStartTime, employeeEndTime) = employeeRoaster.GetWorkTimesByEmployeeId(_currentEmployeeId);
                TimeSpan currentTime = DateTime.Now.TimeOfDay;

                if ((leaveRequest.LeaveType == "Casual" || leaveRequest.LeaveType == "Short") &&
                currentTime > employeeStartTime && currentTime < employeeEndTime)
                {
                    MessageBox.Show($"You must request leave before your work starts.", "Invalid Leave Request");
                    return;
                }

                if (string.IsNullOrEmpty(employeeOffDay))
                {
                    MessageBox.Show("Employee's off day is not set. Please select a valid leave type.");
                    return;
                }
                if (string.IsNullOrEmpty(employeeHalfDay))
                {
                    MessageBox.Show("Employee's half day is not set. Please select a valid leave type.");
                    return;
                }

                List<string> dayNamesBetween = GetDayNamesBetween(startDate, endDate);

                int offDayCount = dayNamesBetween.Count(day => day.Equals(selectedEmployeeOffDay, StringComparison.OrdinalIgnoreCase));
                double halfDayCount = dayNamesBetween.Count(day => day.Equals(selectedEmployeeHalfDay, StringComparison.OrdinalIgnoreCase)) * 0.5;
                double totalLeaveDays = (endDate - startDate).Days + 1;

                leaveRequest.OffDayCount = offDayCount;
                leaveRequest.HalfDayCount = halfDayCount;
                leaveRequest.LeavesTaken = totalLeaveDays - (offDayCount + halfDayCount);

                LeaveTypeClass leaveTypeClass = new LeaveTypeClass();
                string availableLeaveStr = leaveTypeClass.GetAvailableLeave(leaveRequest.LeaveType, _currentEmployeeId);
                if (string.IsNullOrEmpty(availableLeaveStr) || availableLeaveStr == "0")
                {
                    MessageBox.Show("Available leave is 0 or not set. Please check the leave type.");
                    return;
                }

                int availableLeave = int.Parse(availableLeaveStr);
                if (leaveRequest.LeavesTaken > availableLeave)
                {
                    MessageBox.Show("Your leave request exceeds the allowed leave count. Please adjust your leave days.");
                    return;
                }

                leaveRequest.save();
                leavetype.DeductLeave(leaveRequest.LeaveType, leaveRequest.LeavesTaken);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            leaveRequest.delete();
        }

        private void LeaveReqAdmiCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LeaveReqAdmiCmb.SelectedValue != null)
                {
                    leaveRequest.AdmId = (LeaveReqAdmiCmb.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LeaveTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (LeaveTypeCmb.SelectedValue != null)
            //    {
            //        // Ensure the selected value is parsed correctly
            //        int employeeId;
            //        if (int.TryParse(leaveRequest.LeaType = LeaveTypeCmb.SelectedValue.ToString(), out employeeId))
            //        {
            //            // Fetch off day and half day from the Employee Roaster
            //            (employeeOffDay, employeeHalfDay) = EmpRoas.CalculationDay(employeeId);
            //            var (startTime, employeeEndTime) = employeeRoaster.GetWorkTimesByEmployeeId(employeeId);

            //            // Show the start time in a message box
            //            MessageBox.Show($"Employee's Start Time: {startTime}", "Employee Start Time");

            //            if (!string.IsNullOrEmpty(employeeOffDay) && !string.IsNullOrEmpty(employeeHalfDay))
            //            {
            //                selectedEmployeeOffDay = employeeOffDay;
            //                selectedEmployeeHalfDay = employeeHalfDay;

            //                // Display both off day and half day in a single message box
            //                MessageBox.Show($"Off Day: {employeeOffDay}\nHalf Day: {employeeHalfDay}", "Employee Schedule");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Could not retrieve employee's off day or half day. Please try again.");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Invalid employee selected. Please choose a valid employee.");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Show the exception message if something goes wrong
            //    MessageBox.Show(ex.Message, "Error");
            //}
            try
            {
                if (LeaveTypeCmb.SelectedValue != null)
                {
                    int employeeId;
                    if (int.TryParse(leaveRequest.LeaType = LeaveTypeCmb.SelectedValue.ToString(), out employeeId))
                    {
                        // Fetch off day and half day from the Employee Roaster
                        (employeeOffDay, employeeHalfDay) = EmpRoas.CalculationDay(employeeId);
                        var (startTime, employeeEndTime) = employeeRoaster.GetWorkTimesByEmployeeId(employeeId);

                        // Show the start time in a message box
                        MessageBox.Show($"Employee's Start Time: {startTime}", "Employee Start Time");

                        if (!string.IsNullOrEmpty(employeeOffDay) && !string.IsNullOrEmpty(employeeHalfDay))
                        {
                            selectedEmployeeOffDay = employeeOffDay;
                            selectedEmployeeHalfDay = employeeHalfDay;

                            // Display both off day and half day in a single message box
                            MessageBox.Show($"Off Day: {employeeOffDay}\nHalf Day: {employeeHalfDay}", "Employee Schedule");

                            // Display available leave for the selected employee
                            DisplayAvailableLeave(employeeId);
                        }
                        else
                        {
                            MessageBox.Show("Could not retrieve employee's off day or half day. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid employee selected. Please choose a valid employee.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Show the exception message if something goes wrong
                MessageBox.Show(ex.Message, "Error");
            }
        }


        private void LeaveReqIdTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(LeaveReqIdTxt.Text) && int.TryParse(LeaveReqIdTxt.Text, out int reqId))
                {
                    leaveRequest.ID = reqId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                    
        private void Reasontxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                leaveRequest.Reason = Reasontxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LeaveBegDaDTP_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.TryParse(LeaveBegDaDTP.Text, out DateTime beginDate))
                {
                    leaveRequest.LeaveBeg = beginDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LeaveEndDaDTP_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.TryParse(LeaveEndDaDTP.Text, out DateTime endDate))
                {
                    leaveRequest.LeaveEnd = endDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RejectRB_CheckedChanged(object sender, EventArgs e)
        {

            leaveRequest.LeaveStatus = "Rejected";
        }

        private void AccesptRB_CheckedChanged(object sender, EventArgs e)
        {
            leaveRequest.LeaveStatus = "Accepted";
        }


        private void SearchBoxTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SearchBoxTxt.Text != "")
                {
                    leaveRequest.Search(SearchBoxTxt.Text);
                }
                else
                {
                    loadDataFromDB();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PendingRB_CheckedChanged_1(object sender, EventArgs e)
        {
            leaveRequest.LeaveStatus = "Pending";
        }

        private void AnnualLeaveRB_CheckedChanged(object sender, EventArgs e)
        {
            leaveRequest.LeaveType = "Annual";
        }

        private void CasualLeaveRb_CheckedChanged(object sender, EventArgs e)
        {
            leaveRequest.LeaveType = "Casual";
        }

        private void ShortLeaveRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ShortLeaveRB.Checked)
            {
                LeaveBegDaDTP.Enabled = false;
                LeaveEndDaDTP.Enabled = false;
                ShortLeaveDTP.Enabled = true;
            }
            else
            {
                LeaveBegDaDTP.Enabled = true;
                LeaveEndDaDTP.Enabled = true;
                ShortLeaveDTP.Enabled = false;
            }

            leaveRequest.LeaveType = "Short";
        }

        private void ShortLeaveDTP_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                leaveRequest.ShortLeaveTime = DateTime.Parse(ShortLeaveDTP.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            leaveRequest.Clear(this);
        }
    }
}
