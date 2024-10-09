using GrifindoToyLeaveApp.AppClass;
using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp
{
    public partial class Admin : Form
    {
        AdminClass admin = new AdminClass();
        EmployeeClass employee = new EmployeeClass();
        public Admin()
        {
            InitializeComponent();
        }

        private void AdminInsertbtn_Click(object sender, EventArgs e)
        {
            admin.Save();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            try
            {
                employee.LoadAsFk(EmpIdCmb);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadDataFromDB();
            admin._loadTable = AdminSqlDataView;
        }


        private void loadDataFromDB()
        {
            admin.LoadData(AdminSqlDataView);
        }

        private void AdminSqlDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get row index from data gridview
            int RowIndeNumber = e.RowIndex;

            if(RowIndeNumber >= 0) {
                // get data and store in the  variable by using selected row index
                string id = AdminSqlDataView.Rows[RowIndeNumber].Cells["ID"].Value.ToString();
                string employee = AdminSqlDataView.Rows[RowIndeNumber].Cells["Name"].Value.ToString();
                string username = AdminSqlDataView.Rows[RowIndeNumber].Cells["Username"].Value.ToString();
                string password = AdminSqlDataView.Rows[RowIndeNumber].Cells["Password"].Value.ToString();

                // to assign the selected data to controls
                AdminIdTxt.Text = id;
                EmpIdCmb.Text = employee;
                AdminUserNameTxt.Text = username;
                AdminPassTxt.Text = password;
            }
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            admin.Update();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            admin.Delete();
        }

        private void AdminIdTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(AdminIdTxt.Text) && int.TryParse(AdminIdTxt.Text, out int adminId))
                {
                    admin.ID = adminId;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpIdCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (EmpIdCmb.SelectedValue != null)
                {
                    admin.EmpId = EmpIdCmb.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminUserNameTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                admin.UserName = AdminUserNameTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminPassTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                admin.Password = AdminPassTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                admin.Search(SearchBox.Text);
            }
            else
            {
                loadDataFromDB();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            admin.Clear(this);
        }
    }
}
