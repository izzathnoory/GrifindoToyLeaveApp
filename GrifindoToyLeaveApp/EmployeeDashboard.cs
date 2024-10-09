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
    public partial class EmployeeDashboard : Form
    {
        EmployeeDetailStoreClass empDetail = new EmployeeDetailStoreClass();
        EmployeeAccess employeeAccess;


        public EmployeeDashboard()
        {
            InitializeComponent();
        }


        public EmployeeDashboard(EmployeeAccess _parent)
        {
            InitializeComponent();
            employeeAccess = _parent;
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            EmployeeDetailRetrive();
            EmployeeLeavetypeRetrive();
            EmployeeMobileDetailRetrive();
            TotalLeave();
        }

        private void EmployeeDetailRetrive()
        {
            try
            {
                DataTable dt = empDetail.GetUserInformation();
                EmpIdTxt.Text = dt.Rows[0]["Emp_num"].ToString();
                EmpNameTxt.Text = dt.Rows[0]["Emp_name"].ToString();
                EmpEmailTxt.Text = dt.Rows[0]["emp_email"].ToString();
                EmpAddressTxt.Text = dt.Rows[0]["emp_addre"].ToString();
                EmpExperTxt.Text = dt.Rows[0]["emp_exp"].ToString();
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

        private void TotalLeave()
        {
            try
            {
                DataTable dt = empDetail.ReqLeaveCountInformation();
                TotalLeaveTxt.Text = dt.Rows[0]["Total_Leave_Count"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeeMobileDetailRetrive()
        {
            try
            {
                DataTable dt = empDetail.GetEmployeeMobile();
                EmpPhonetxt.Text = dt.Rows[0]["emp_mob_num"].ToString();
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

        private void EmployeeLeavetypeRetrive()
        {
            try
            {
                DataTable dt = empDetail.GetUserLeaveTypeInformation();
                AnnualLeaveCountTxt.Text = dt.Rows[0]["annua_leav_count"].ToString();
                CasualLeaveCountTxt.Text = dt.Rows[0]["casu_leav_count"].ToString();
                ShortLeaveCountTxt.Text = dt.Rows[0]["short_leave"].ToString();
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

        private void LeaveApplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                employeeAccess.trigerLeaveRequestButtonClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
