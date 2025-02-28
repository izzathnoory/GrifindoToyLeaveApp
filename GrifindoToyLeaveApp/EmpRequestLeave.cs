using GrifindoToyLeaveApp.AppClass;
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
    public partial class EmpRequestLeave : Form
    {
        EmpRequestLeaveClass empRequestLeave = new EmpRequestLeaveClass();
        LeaveTypeClass leaveType = new LeaveTypeClass();
        EmployeeDetailStoreClass empDetailStore = new EmployeeDetailStoreClass();
        //LeaveRequestClass leaveRequest = new LeaveRequestClass();
        AdminClass admin = new AdminClass();
        EmployeeClass employee = new EmployeeClass();
        EmployeeRoasterClass employeeRoaster = new EmployeeRoasterClass();
        Employee_Roaster EmpRoas = new Employee_Roaster();
        //EmpUserAuthonticationClass EmpUsr = new EmpUserAuthonticationClass();
        DateTime dateValue = new DateTime();


        string selectedEmployeeoffDay = null;
        string selectedEmployeehalfDay = null;

        private string employeeoffDay;
        private string employeehalfDay;
        private int _currentEmployeeId;
        public EmpRequestLeave(int currentEmployeeId)
        {
            InitializeComponent();
            empRequestLeave._loadTable = EmprequestLeaveSqlDataView;
            EmpNameTxt.Text = EmpUserAuthonticationClass.Username;
            empRequestLeave.LeaveStatus = "Pending";
            _currentEmployeeId = currentEmployeeId;
            empRequestLeave._loadTable = EmprequestLeaveSqlDataView;
            LeaveBegDaDTP.ValueChanged += DatePickers_ValueChanged;
            LeaveEndDaDTP.ValueChanged += DatePickers_ValueChanged;
            //EmpNameTxt.SelectedIndexChanged += LeaveTypeCmb_SelectedIndexChanged;
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
                        if (dayName.Equals(employeeoffDay, StringComparison.OrdinalIgnoreCase))
                        {
                            offDays.Add(dayName);
                        }
                        if (dayName.Equals(employeehalfDay, StringComparison.OrdinalIgnoreCase))
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

        private void LeavReqInserbtn_Click(object sender, EventArgs e)
        {

            //empRequestLeave.save();
            try
            {
                // Get the start and end dates from the DateTimePickers
                DateTime startDate = LeaveBegDaDTP.Value.Date;
                DateTime endDate = LeaveEndDaDTP.Value.Date;
                DateTime currentDate = DateTime.Now.Date;

                // Fetch the employee's work start time using their employee ID
                var (employeeStartTime, employeeEndTime) = employeeRoaster.GetWorkTimesByEmployeeId(_currentEmployeeId);
                TimeSpan currentTime = DateTime.Now.TimeOfDay;

                // Check if the leave type is "Casual" or "Short" and block leave if it's during working hours
                if ((empRequestLeave.LeaveType == "Casual" || empRequestLeave.LeaveType == "Short") &&
                currentTime > employeeStartTime && currentTime < employeeEndTime)
                {
                    MessageBox.Show($"You must request leave before your work starts.", "Invalid Leave Request");
                    return; // Block the leave request
                }

                // Ensure that the employee's off day and half day have been set
                if (string.IsNullOrEmpty(employeeoffDay) || string.IsNullOrEmpty(employeehalfDay))
                {
                    MessageBox.Show("Employee's off day or half day is not set. Please select a valid leave type.");
                    return;
                }

                // Get the day names between the selected start and end dates
                List<string> dayNamesBetween = GetDayNamesBetween(startDate, endDate);

                // Count the number of off days in the selected leave period
                int offDayCount = dayNamesBetween.Count(day => day.Equals(selectedEmployeeoffDay, StringComparison.OrdinalIgnoreCase));
                double halfDayCount = dayNamesBetween.Count(day => day.Equals(selectedEmployeehalfDay, StringComparison.OrdinalIgnoreCase)) * 0.5;

                double totalLeaveDays = (endDate - startDate).Days + 1;

                empRequestLeave.OffDayCount = offDayCount;
                empRequestLeave.HalfDayCount = halfDayCount;
                empRequestLeave.LeavesTaken = totalLeaveDays - (offDayCount + halfDayCount);

                // Store the count of off days in a variable and display in a message box
                MessageBox.Show($"Off Day Count: {offDayCount}", "Off Day Count");

                // If the start and end dates are the same, check if it falls on the employee's off day
                if (startDate == endDate && dayNamesBetween.Contains(selectedEmployeeoffDay))
                {
                    MessageBox.Show("Your allocated leave is exhausted. You can take a leave next year.");
                    return; // Block the leave request for a single off day
                }

                // Check if there are multiple off days in the leave period and allow the leave
                if (offDayCount > 0)
                {
                    MessageBox.Show("Off days detected, leave request allowed with off days counted.");
                }

                // Check if the leave type is "Annual" and validate the date
                if (empRequestLeave.LeaveType == "Annual" && !IsAnnualLeaveValid(startDate, currentDate))
                {
                    MessageBox.Show("Your allocated leave is exhausted. You can take a leave next year.");
                    return; // Exit if annual leave does not meet the 7-day condition
                }

                // No conflicts, proceed to save the leave request
                empRequestLeave.save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //empRequestLeave.update();
            try
            {
                // Get the start and end dates from the DateTimePickers
                DateTime startDate = LeaveBegDaDTP.Value.Date;
                DateTime endDate = LeaveEndDaDTP.Value.Date;
                DateTime currentDate = DateTime.Now.Date;

                // Fetch the employee's work start time using their employee ID
                var (employeeStartTime, employeeEndTime) = employeeRoaster.GetWorkTimesByEmployeeId(_currentEmployeeId);
                TimeSpan currentTime = DateTime.Now.TimeOfDay;


                // Check if the leave type is "Casual" or "Short" and block leave if it's during working hours
                if ((empRequestLeave.LeaveType == "Casual" || empRequestLeave.LeaveType == "Short") &&
                currentTime > employeeStartTime && currentTime < employeeEndTime)
                {
                    MessageBox.Show($"You must request leave before your work starts.", "Invalid Leave Request");
                    return; // Block the leave request
                }

                // Ensure that the employee's off day and half day have been set
                if (string.IsNullOrEmpty(employeeoffDay) || string.IsNullOrEmpty(employeehalfDay))
                {
                    MessageBox.Show("Employee's off day or half day is not set. Please select a valid leave type.");
                    return;
                }

                // Get the day names between the selected start and end dates
                List<string> dayNamesBetween = GetDayNamesBetween(startDate, endDate);

                // Count the number of off days in the selected leave period
                int offDayCount = dayNamesBetween.Count(day => day.Equals(selectedEmployeeoffDay, StringComparison.OrdinalIgnoreCase));

                double halfDayCount = dayNamesBetween.Count(day => day.Equals(selectedEmployeehalfDay, StringComparison.OrdinalIgnoreCase)) * 0.5;

                double totalLeaveDays = (endDate - startDate).Days + 1;

                empRequestLeave.OffDayCount = offDayCount;
                empRequestLeave.HalfDayCount = halfDayCount;
                empRequestLeave.LeavesTaken = totalLeaveDays - (offDayCount + halfDayCount);

                // Store the count of off days in a variable and display in a message box
                MessageBox.Show($"Off Day Count: {offDayCount}", "Off Day Count");

                // Check if there is only one off day in the leave period, block if true
                if (offDayCount == 1)
                {
                    MessageBox.Show("Sorry, you cannot request leave on your off day. There is only one off day in the selected period.");
                    return; // Exit the method if there's a conflict
                }
                // If there are multiple off days, allow the leave request to proceed
                else if (offDayCount > 1)
                {
                    MessageBox.Show("Multiple off days detected, leave request allowed.");
                }

                // Check if the leave type is "Annual" and validate the date
                if (empRequestLeave.LeaveType == "Annual" && !IsAnnualLeaveValid(startDate, currentDate))
                {
                    MessageBox.Show("Annual leave must be requested at least 7 days in advance.");
                    return; // Exit if annual leave does not meet the 7-day condition
                }

                // No conflicts, proceed to save the leave request
                empRequestLeave.update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            empRequestLeave.delete();
        }

        private bool IsAnnualLeaveValid(DateTime startDate, DateTime currentDate)
        {
            TimeSpan difference = startDate - currentDate;
            return difference.TotalDays >= 7;
        }

        private void RequestLeave_Load(object sender, EventArgs e)
        {
            try
            {
                leaveType.EmployeeLoginLoadAsFk(EmpNameTxt);
                var (offDay, halfDay) = EmpRoas.CalculationDay(EmpUserAuthonticationClass.Id);
                employeeoffDay = offDay;
                employeehalfDay = halfDay;
                MessageBox.Show($"Off Day: {employeeoffDay}\nHalf Day: {employeehalfDay}", "Employee Schedule");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            empRequestLeave.loadData();
            loadDataFromDB();
            DisableRB();
            EmpDetailRetrive();

        }

        private void loadDataFromDB()
        {
             empRequestLeave.loadData();
             //empDetailStore.getUserLeaveRequestInformation(EmprequestLeaveSqlDataView);
             string employeeName = EmpUserAuthonticationClass.Username;
             
        }

        private void EmprequestLeaveSqlDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int RowIndeNumber = e.RowIndex;

                if (RowIndeNumber >= 0)
                {
                    //DataTable dt = empDetailStore.getUserInformation();
                    // get data and store in the  variable by using selected row index
                    //string adminUserName = EmprequestLeaveSqlDataView.Rows[RowIndeNumber].Cells["AdmName"].Value.ToString();
                    string employeeName = EmpUserAuthonticationClass.Username;
                    //string leavetypeid = EmprequestLeaveSqlDataView.Rows[RowIndeNumber].Cells["leave_type_fk"].Value.ToString();
                    string leavereqid = EmprequestLeaveSqlDataView.Rows[RowIndeNumber].Cells["ReqId"].Value.ToString();
                    string reason = EmprequestLeaveSqlDataView.Rows[RowIndeNumber].Cells["Reason"].Value.ToString();
                    string begindate = EmprequestLeaveSqlDataView.Rows[RowIndeNumber].Cells["BeginDate"].Value.ToString();
                    string enddate = EmprequestLeaveSqlDataView.Rows[RowIndeNumber].Cells["EndDate"].Value.ToString();
                    string _leaveType = EmprequestLeaveSqlDataView.Rows[RowIndeNumber].Cells["LeaveType"].Value.ToString();
                    string _leaveStatus = EmprequestLeaveSqlDataView.Rows[RowIndeNumber].Cells["LeaveStatus"].Value.ToString();

                    // to assign the selected data to controls
                    EmpNameTxt.Text = employeeName;
                    LeaveReqIdTxt.Text = leavereqid;
                    Reasontxt.Text = reason;
                    LeaveBegDaDTP.Text = begindate;
                    LeaveEndDaDTP.Text = enddate;
                    empRequestLeave.LeaveStatus = _leaveStatus;
                    enableStatus(_leaveStatus);


                    empRequestLeave.LeaveType = _leaveType;
                    SelectLeaveType(_leaveType);
                    empRequestLeave.loadData();
                }
            }
            catch(Exception ex) 
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


        private void DisableRB()
        {
            PendingRB.Enabled= false;
            AccesptRB.Enabled= false;
            RejectRB.Enabled= false;
        }


        private void EmpDetailRetrive()
        {
            try
            {
                DataTable dt = empDetailStore.GetUserInformation();
                EmpNameTxt.Text = dt.Rows[0]["Emp_name"].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AnnualLeaveRB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                empRequestLeave.LeaveType = "Annual";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CasualLeaveRb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                empRequestLeave.LeaveType = "Casual";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            empRequestLeave.LeaveType = "Short";
        }

        private void RejectRB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                empRequestLeave.LeaveStatus = "Rejected";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AccesptRB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                empRequestLeave.LeaveStatus = "Accepted";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PendingRB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                empRequestLeave.LeaveStatus = "Pending";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpNameTxt_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming EmployeeUserAuthentication is a class holding authenticated employee information
                // Get the employee ID from the EmployeeUserAuthentication class
                int employeeId = EmpUserAuthonticationClass.Id; // Replace with actual way to access employee ID

                // Ensure that the employee ID is valid and not zero or negative
                if (employeeId > 0)
                {
                    // Fetch off day and half day from the Employee Roaster based on employee ID
                    (employeeoffDay, employeehalfDay) = EmpRoas.CalculationDay(employeeId);

                    // Check if either off day or half day is not set
                    if (string.IsNullOrEmpty(employeeoffDay) || string.IsNullOrEmpty(employeehalfDay))
                    {
                        MessageBox.Show("Employee's off day or half day is not set. Please verify the employee details.", "Error");
                        return; // Exit early if data is missing
                    }

                    // Fetch employee's start time and end time from the Employee Roaster
                    var (startTime, employeeEndTime) = employeeRoaster.GetWorkTimesByEmployeeId(employeeId);

                    // Show the start time in a message box
                    MessageBox.Show($"Employee's Start Time: {startTime}", "Employee Start Time");

                    // Assign the off day and half day values to the selected variables
                    selectedEmployeeoffDay = employeeoffDay;
                    selectedEmployeehalfDay = employeehalfDay;

                    // Display both off day and half day in a single message box
                    MessageBox.Show($"Off Day: {employeeoffDay}\nHalf Day: {employeehalfDay}", "Employee Schedule");
                }
                else
                {
                    // If employee ID is invalid (e.g., not set or zero)
                    MessageBox.Show("Employee ID is invalid. Please check the authentication details.");
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
                if (!string.IsNullOrEmpty(LeaveReqIdTxt.Text) && int.TryParse(LeaveReqIdTxt.Text, out int result))
                {
                    empRequestLeave.ID = result;
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
                empRequestLeave.Reason = Reasontxt.Text;
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
                    empRequestLeave.LeaveBeg = beginDate;
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
                    empRequestLeave.LeaveEnd = endDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            empRequestLeave.Clear(this);
        }

        private void ShortLeaveDTP_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                empRequestLeave.ShortLeaveTime = DateTime.Parse(ShortLeaveDTP.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
