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
    public partial class Leave_Type : Form
    {
        LeaveTypeClass LeaveType = new LeaveTypeClass();
        EmployeeClass employee = new EmployeeClass();
        public Leave_Type()
        {
            InitializeComponent();
            InitializeLeaveTypeProperties(); // Initialize properties
        }

        private void InitializeLeaveTypeProperties()
        {
            LeaveType.AnnualLeave = LeaveType.AnnualLeave ?? "0";
            LeaveType.CasualLeave = LeaveType.CasualLeave ?? "0";
            LeaveType.ShortLeave = LeaveType.ShortLeave ?? "0";
        }


        private void Insertbtn_Click(object sender, EventArgs e)
        {
            LeaveType.Save();
        }

        private void Leave_Type_Load(object sender, EventArgs e)
        {
            try
            {
                employee.LoadAsFk(EmployeeIdCmb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadDataFromDB();
            LeaveType._loadTable = LeaTypSqlDataView;

        }

        private void loadDataFromDB()
        {
            LeaveType.LoadData(LeaTypSqlDataView);
        }

        public void DeductLeave(string leaveType, double leavesTaken, int employeeId)
        {
            // Fetch current leave balances for the employee
            var (annual, casual, shortLeave) = LeaveType.GetDaysByEmployeeId(employeeId);

            switch (leaveType)
            {
                case "Annual":
                    annual -= (int)leavesTaken;
                    LeaveType.AnnualLeave = annual.ToString();
                    break;
                case "Casual":
                    casual -= (int)leavesTaken;
                    LeaveType.CasualLeave = casual.ToString();
                    break;
                case "Short":
                    shortLeave -= (int)leavesTaken;
                    LeaveType.ShortLeave = shortLeave.ToString();
                    break;
                default:
                    throw new Exception("Invalid leave type");
            }

            // Update the leave type record in the database
            LeaveType.Update();
        }

        public string GetAvailableLeave(string leaveType)
        {
            switch (leaveType)
            {
                case "Annual":
                    return LeaveType.AnnualLeave;
                case "Casual":
                    return LeaveType.CasualLeave;
                case "Short":
                    return LeaveType.ShortLeave;
                default:
                    throw new Exception("Invalid leave type");
            }
        }

        private void LeaTypSqlDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get row index from data gridview
            int RowIndeNumber = e.RowIndex;

            if (RowIndeNumber >= 0)
            {
                // get data and store in the  variable by using selected row index
                string empName = LeaTypSqlDataView.Rows[RowIndeNumber].Cells["Name"].Value.ToString();
                string leavetype = LeaTypSqlDataView.Rows[RowIndeNumber].Cells["LeaveType"].Value.ToString();
                string annualleave = LeaTypSqlDataView.Rows[RowIndeNumber].Cells["AnnualLeave"].Value.ToString();
                string casualleave = LeaTypSqlDataView.Rows[RowIndeNumber].Cells["CasualLeave"].Value.ToString();
                string shortleave = LeaTypSqlDataView.Rows[RowIndeNumber].Cells["ShortLeave"].Value.ToString();

                // to assign the selected data to controls
                EmployeeIdCmb.Text = empName;
                LeaveTypeIdTxt.Text = leavetype;
                AnnuaLeaCounTxt.Text = annualleave;
                CasuaLeaCounTxt.Text = casualleave;
                ShortLeaTxt.Text = shortleave;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            LeaveType.Update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            LeaveType.Delete();
        }

        private void EmployeeIdCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeIdCmb.SelectedValue != null)
                {
                    LeaveType.EmpId = (EmployeeIdCmb.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LeaveTypeIdTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(LeaveTypeIdTxt.Text) && int.TryParse(LeaveTypeIdTxt.Text, out int leaveTypeId))
                {
                    LeaveType.ID = leaveTypeId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AnnuaLeaCounTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(AnnuaLeaCounTxt.Text, out int annualLeaveCount))
                {
                    LeaveType.AnnualLeave = annualLeaveCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CasuaLeaCounTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(CasuaLeaCounTxt.Text, out int casualLeaveCount))
                {
                    LeaveType.CasualLeave = casualLeaveCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShortLeaTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(ShortLeaTxt.Text, out int shortLeaveCount))
                {
                    LeaveType.ShortLeave = shortLeaveCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchBoxTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchBoxTxt.Text != "")
            {
                LeaveType.Search(SearchBoxTxt.Text);
            }
            else
            {
                loadDataFromDB();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            LeaveType.Clear(this);
        }
    }
}
