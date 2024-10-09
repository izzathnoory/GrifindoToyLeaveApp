using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class AdminClass : SQL
    {
        internal string EmpId { get; set; }
        internal int ID { get; set; }
        internal string UserName { get; set; }
        internal string Password { get; set; }

        internal DataGridView _loadTable { get; set; }


        public void Save()
        {
            string GenerateedSQL = $"INSERT INTO Admin_Table (employee_fk, username, password) VALUES ('{EmpId}','{UserName}','{Password}')";
            if (ExecuteSaveQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Update()
        {
            string GenerateedSQL = $"update Admin_Table set employee_fk = '{EmpId}', username = '{UserName}', password = '{Password}' where admin_id = '{ID}'";
            if (ExecuteUpdateQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Delete()
        {
            string GenerateedSQL = $"delete from Admin_Table where admin_id = '{ID}'";
            if (ExecuteDeleteQuery(GenerateedSQL))
            {
                LoadData();
            }
        }


        public void LoadData(DataGridView dataGridView)
        {
            string adminSelectQuery = "select a.admin_id as ID,  e.Emp_name as Name ,a.username as Username" +
            ", a.password as Password from Admin_Table a join Employee_Table e on e.Emp_num = a.employee_fk";
            ExecuteLoadData(adminSelectQuery, dataGridView);
        }

        public void Search(string ID)
        {
            string adminSelectQuery = $"select a.admin_id as ID,  e.Emp_name as Name ,a.username as Username, a.password as " +
            $"Password from Admin_Table a join Employee_Table e on e.Emp_num = a.employee_fk where a.admin_id like '{ID}%'";
            ExecuteLoadData(adminSelectQuery, _loadTable);
        }

        public void LoadData()
        {
            string adminSelectQuery = "select a.admin_id as ID,  e.Emp_name as Name ,a.username as Username," +
            " a.password as Password from Admin_Table a join Employee_Table e on e.Emp_num = a.employee_fk";
            ExecuteLoadData(adminSelectQuery, _loadTable);
        }

        public void LoadAsFk(ComboBox adminComboBox)
        {
            string sql = "select * from Admin_Table";
            DataTable dt = GetDataTable(sql);
            adminComboBox.DisplayMember = "username";
            adminComboBox.ValueMember = "admin_id";
            adminComboBox.DataSource = dt;
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
                    else if (control is ComboBox)
                    {
                        ((ComboBox)control).SelectedIndex = -1;
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
