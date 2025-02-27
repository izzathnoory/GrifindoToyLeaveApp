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
        
        public EmpRequestLeave()
        {
            InitializeComponent();
            empRequestLeave._loadTable = EmprequestLeaveSqlDataView;
            EmpNameTxt.Text = EmpUserAuthonticationClass.Username;
            empRequestLeave.LeaveStatus = "Pending";
        }



        private void LeavReqInserbtn_Click(object sender, EventArgs e)
        {

            empRequestLeave.save();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            empRequestLeave.update();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            empRequestLeave.delete();
        }

        private void RequestLeave_Load(object sender, EventArgs e)
        {
            try
            {
                leaveType.EmployeeLoginLoadAsFk(EmpNameTxt);
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
            //try
            //{
            //    empRequestLeave.LeaTypeId = int.Parse(EmpNameTxt.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
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
