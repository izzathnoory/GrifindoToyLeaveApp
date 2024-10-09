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
    public partial class Employee_Mobile : Form
    {
        EmployeeMobileClass employeeMobile = new EmployeeMobileClass();
        EmployeeClass employee = new EmployeeClass();
        public Employee_Mobile()
        {
            InitializeComponent();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            employeeMobile.Save(); 
        }

        private void Employee_Mobile_Load(object sender, EventArgs e)
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
            employeeMobile._loadTable = EmpMobSqlDataView;
        }

        private void loadDataFromDB() 
        {
            employeeMobile.LoadData(EmpMobSqlDataView);
        }

        private void EmpMobSqlDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get row index from data gridview
            int RowIndeNumber = e.RowIndex;

            if (RowIndeNumber >= 0)
            {
                // get data and store in the  variable by using selected row index
                string empName = EmpMobSqlDataView.Rows[RowIndeNumber].Cells["EmpName"].Value.ToString();
                string mobileId = EmpMobSqlDataView.Rows[RowIndeNumber].Cells["MobId"].Value.ToString();
                string mob_num = EmpMobSqlDataView.Rows[RowIndeNumber].Cells["MobNum"].Value.ToString();

                // to assign the selected data to controls
                EmployeeIdCmb.Text = empName;
                MobileIDTxt.Text = mobileId;
                MobileNumberTxt.Text = mob_num;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            employeeMobile.Update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            employeeMobile.Delete();
        }

        private void EmployeeIdCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeIdCmb.SelectedValue != null)
                {
                    employeeMobile.EmpId = (EmployeeIdCmb.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MobileIDTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(MobileIDTxt.Text))
                {
                    employeeMobile.ID = int.Parse(MobileIDTxt.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MobileNumberTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employeeMobile.MobileNumber = MobileNumberTxt.Text;
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
                employeeMobile.Search(SearchBoxTxt.Text);
            }
            else
            {
                loadDataFromDB();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            employeeMobile.Clear(this);
        }
    }
}
