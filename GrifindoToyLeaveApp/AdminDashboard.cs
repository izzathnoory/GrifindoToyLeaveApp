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
    public partial class AdminDashboard : Form
    {

        AdminDetailStoreClass adminDetail = new AdminDetailStoreClass();
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            EmployeeCount();
            PendingCount();
            TodayLeave();
            TodayAnnualLeave();
            TodayCasualLeave();
            TodayShortLeave();
            AdminDetails();
        }

        private void EmployeeCount()
        {
            try
            {
                DataTable dt = adminDetail.GetEmployeeCount();
                EmpCountTxt.Text = dt.Rows[0]["Employee_Count"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PendingCount()
        {
            try
            {
                DataTable dt = adminDetail.GetPendingLeaveCount();
                PendingLeaveTxt.Text = dt.Rows[0]["TotalPending"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TodayLeave()
        {
            try
            {
                DataTable dt = adminDetail.GetTodayLeave();
                TodayLeavesTxt.Text = dt.Rows[0]["TodayLeave"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TodayAnnualLeave()
        {
            try
            {
                DataTable dt = adminDetail.GetTodayAnnualLeave();
                TodayAnnualLeaveTxt.Text = dt.Rows[0]["TodayAnnual"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TodayCasualLeave()
        {
            try
            {
                DataTable dt = adminDetail.GetTodayCasuallLeave();
                TodayCasualLeaveTxt.Text = dt.Rows[0]["TodayCasual"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TodayShortLeave()
        {
            try
            {
                DataTable dt = adminDetail.GetTodayShortLeave();
                TodayShortLeaveTxt.Text = dt.Rows[0]["TodayShort"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminDetails()
        {
            try
            {
                DataTable dt = adminDetail.GetAllAdminDetails();
                AdminIdTxt.Text = dt.Rows[0]["AdminId"].ToString();
                AdminNameTxt.Text = dt.Rows[0]["AdmName"].ToString();
                AdminPhoneTxt.Text = dt.Rows[0]["AdmMobile"].ToString();
                AdminEmailTxt.Text = dt.Rows[0]["AdminEmail"].ToString();

                AdminNicTxt.Text = dt.Rows[0]["AdminNic"].ToString();
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
    }
}
