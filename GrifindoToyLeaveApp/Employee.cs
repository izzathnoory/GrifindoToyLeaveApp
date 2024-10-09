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
    public partial class Employee : Form
    {
        EmployeeClass employee = new EmployeeClass();


        public Employee()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            employee.Save();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            loadDataFromDB();
            employee._loadTable = EmpSqlDataView;
        }

        private void loadDataFromDB()
        {
            employee.LoadData(EmpSqlDataView);
        }


        private void EmpSqlDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get row index from data gridview
            int RowIndeNumber = e.RowIndex;

            if (RowIndeNumber >= 0)
            {
                // get data and store in the  variable by using selected row index
                string id = EmpSqlDataView.Rows[RowIndeNumber].Cells["ID"].Value.ToString();
                string name = EmpSqlDataView.Rows[RowIndeNumber].Cells["Name"].Value.ToString();
                string email = EmpSqlDataView.Rows[RowIndeNumber].Cells["Email"].Value.ToString();
                string address = EmpSqlDataView.Rows[RowIndeNumber].Cells["Address"].Value.ToString();
                string password = EmpSqlDataView.Rows[RowIndeNumber].Cells["Password"].Value.ToString();
                string experiance = EmpSqlDataView.Rows[RowIndeNumber].Cells["Experiance"].Value.ToString();
                string nic = EmpSqlDataView.Rows[RowIndeNumber].Cells["Nic"].Value.ToString();
                string employeepassport = EmpSqlDataView.Rows[RowIndeNumber].Cells["Passport_No"].Value.ToString();

                // to assign the selected data to controls
                empIDtxt.Text = id;
                EmpPasswordTxt.Text = password;
                empNametxt.Text = name;
                empEmailtxt.Text = email;
                empAddtxt.Text = address;
                empExpertxt.Text = experiance;
                empNictxt.Text = nic;
                empPasstxt.Text = employeepassport;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            employee.Update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            employee.Delete();
        }

        private void empIDtxt_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(empIDtxt.Text) && int.TryParse(empIDtxt.Text, out int employeeId))
                {
                    employee.id = employeeId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.password = EmpPasswordTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void empNametxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.name = empNametxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void empEmailtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.email = empEmailtxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void empAddtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.address = empAddtxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void empExpertxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(empExpertxt.Text) && float.TryParse(empExpertxt.Text, out float experience))
            {
                employee.experiance = experience;
            }
        }

        private void empNictxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.nic = empNictxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void empPasstxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.passportNumber = empPasstxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if( SearchBox.Text != "")
            {
                employee.Search(SearchBox.Text);
            }
            else
            {
                loadDataFromDB();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            employee.Clear(this);
        }
    }
}
