using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class EmployeeClass : SQL
    {
        internal int id { get; set; }
        internal float experiance { get; set; }
        internal string name { get; set; }
        internal string email { get; set; }
        internal string password { get; set; }
        internal string address { get; set; }
        internal string nic { get; set; }
        internal string passportNumber { get; set; }

        internal DataGridView _loadTable { get; set; }
        public void Save()
        {
            string GenerateedSQL = $"INSERT INTO Employee_Table ( password,Emp_name, emp_email, emp_addre, emp_exp, emp_nic, emp_pass_no) " +
            $"VALUES ('{password}','{name}','{email}','{address}','{experiance}','{nic}','{passportNumber}')";
            if (ExecuteSaveQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Update()
        {
            string GenerateedSQL = $"update Employee_Table set password='{password}',Emp_name='{name}',emp_email='{email}'," +
            $"emp_addre='{address}',emp_exp='{experiance}',emp_nic='{nic}',emp_pass_no='{passportNumber}' where Emp_num ='{id}'";
            if (ExecuteUpdateQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Delete()
        {
            string GenerateedSQL = $"delete from Employee_Table where Emp_num = '{id}'";
            if (ExecuteDeleteQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void LoadData(DataGridView dataGridView)
        {
            string EmployeeSelectQuery = "select Emp.Emp_num as ID, Emp.Emp_name as Name ,Emp.emp_email as Email ,Emp.emp_addre as Address" +
            " ,Emp.password as Password ,Emp.emp_exp as Experiance ,Emp.emp_nic as Nic ,Emp.emp_pass_no as Passport_No From Employee_Table Emp";
            ExecuteLoadData(EmployeeSelectQuery, dataGridView);   
        }


        public void Search(string ID)
        {
            string EmployeeSelectQuery = $"select Emp.Emp_num as ID, Emp.Emp_name as Name ,Emp.emp_email as Email ,Emp.emp_addre as Address" +
            $" ,Emp.password as Password ,Emp.emp_exp as Experiance ,Emp.emp_nic as Nic ,Emp.emp_pass_no as Passport_No From Employee_Table Emp" +
            $" where Emp.Emp_num LIKE '{ID}%'";
            ExecuteLoadData(EmployeeSelectQuery, _loadTable);
        }


        public void LoadData()
        {
            string EmployeeSelectQuery = "select Emp.Emp_num as ID, Emp.Emp_name as Name ,Emp.emp_email as Email ,Emp.emp_addre as Address" +
            " ,Emp.password as Password ,Emp.emp_exp as Experiance ,Emp.emp_nic as Nic ,Emp.emp_pass_no as Passport_No From Employee_Table Emp";
            ExecuteLoadData(EmployeeSelectQuery, _loadTable);
        }

        public void LoadAsFk(ComboBox empComboBox)
        {
            string sql = "Select * From Employee_Table";
            DataTable dt = GetDataTable(sql);
            empComboBox.DataSource = dt;
            empComboBox.DisplayMember = "Emp_name";
            empComboBox.ValueMember = "Emp_num";
        }

        public void LoadAsFkWithAll(ComboBox empComboBox)
        {
            string sql = "Select * From Employee_Table";
            DataTable dt = GetDataTable(sql);
            dt.Rows.Add(new Object[] { 0, "All Employee" });
            empComboBox.DataSource = dt;
            empComboBox.DisplayMember = "Emp_name";
            empComboBox.ValueMember = "Emp_num";
        }

        public void Clear(Control parent)
        {
            try
            {
                foreach (Control control in parent.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Clear();
                    }
                    else if (control.HasChildren)
                    {
                        Clear(control);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
