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
    public partial class LeaveApprovel : Form
    {
        LeaveRequestClass leaveRequest = new LeaveRequestClass();
        AdminClass admin = new AdminClass();
        LeaveTypeClass leaveType = new LeaveTypeClass();
        EmployeeClass employee = new EmployeeClass();
        EmpRequestLeaveClass Emprequest = new EmpRequestLeaveClass();
        public LeaveApprovel()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            leaveRequest.updateStatus();
        }

        private void LeaveApprovel_Load(object sender, EventArgs e)
        {
            loadDataFromDB();
            DisableDate();
            leaveRequest._loadTable = LeaApproveSqlDataView;
            Emprequest._loadTable = LeaApproveSqlDataView;
        }
        private void loadDataFromDB()
        {
            leaveRequest.loadData(LeaApproveSqlDataView);
        }

        private void LeaApproveSqlDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int RowIndeNumber = e.RowIndex;

                if (RowIndeNumber >= 0)
                {
                    // get data and store in the  variable by using selected row index
                    string adminUserName = LeaApproveSqlDataView.Rows[RowIndeNumber].Cells["AdmName"].Value.ToString();
                    string employeeName = LeaApproveSqlDataView.Rows[RowIndeNumber].Cells["EmpName"].Value.ToString();
                    string leavereqid = LeaApproveSqlDataView.Rows[RowIndeNumber].Cells["ReqId"].Value.ToString();
                    string reason = LeaApproveSqlDataView.Rows[RowIndeNumber].Cells["Reason"].Value.ToString();
                    string begindate = LeaApproveSqlDataView.Rows[RowIndeNumber].Cells["BeginDate"].Value.ToString();
                    string enddate = LeaApproveSqlDataView.Rows[RowIndeNumber].Cells["EndDate"].Value.ToString();
                    string _leaveStatus = LeaApproveSqlDataView.Rows[RowIndeNumber].Cells["LeaveStatus"].Value.ToString();
                    string _leaveType = LeaApproveSqlDataView.Rows[RowIndeNumber].Cells["LeaveType"].Value.ToString();
                    // to assign the selected data to controls
                    AdmNameTxt.Text = adminUserName;
                    EmpNameTxt.Text = employeeName;
                    LeaveReqTxt.Text = leavereqid;
                    ReasonTxt.Text = reason;
                    LeaveBegDTP.Text = begindate;
                    LeaveEndDTP.Text = enddate;
                    LeaTypTxt.Text = _leaveType;
                    leaveRequest.LeaveStatus = _leaveStatus;
                    enableStatus(_leaveStatus);
                    leaveRequest.ID = int.Parse(leavereqid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisableDate()
        {
            LeaveBegDTP.Enabled = false;
            LeaveEndDTP.Enabled = false;
        }
        private void enableStatus(string status)
        {
            if (status == "Accepted")
            {
                AccesptRB.Checked = true;
            }
            else if (status == "Pending")
            {
                AccesptRB.Checked= false;
                RejectRB.Checked = false;
            }
            else
            {
                RejectRB.Checked = true;
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
            if (SearchBoxTxt.Text != "")
            {
                leaveRequest.Search(SearchBoxTxt.Text);
            }
            else
            {
                loadDataFromDB();
            }
        }

        private void AdmNameTxt_Click(object sender, EventArgs e)
        {
            leaveRequest.AdmId = AdmNameTxt.Text;
        }

        private void EmpNameTxt_Click(object sender, EventArgs e)
        {
            try
            {
                leaveRequest.EmpId = EmpNameTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LeaveReqTxt_Click(object sender, EventArgs e)
        {
            leaveRequest.ID = int.Parse(LeaveReqTxt.Text);
        }

        private void ReasonTxt_Click(object sender, EventArgs e)
        {
            leaveRequest.Reason = ReasonTxt.Text;
        }

        private void LeaveBegDTP_ValueChanged(object sender, EventArgs e)
        {
            leaveRequest.LeaveBeg = DateTime.Parse(LeaveBegDTP.Text);
        }

        private void LeaveEndDTP_ValueChanged(object sender, EventArgs e)
        {
            leaveRequest.LeaveEnd = DateTime.Parse(LeaveEndDTP.Text);
        }

        private void LeaTypTxt_Click(object sender, EventArgs e)
        {
            leaveRequest.LeaveType = LeaTypTxt.Text;
        }
    }
}