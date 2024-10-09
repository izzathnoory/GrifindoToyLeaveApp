using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class EmployeeMobileClass : SQL
    {
        internal string EmpId { get; set; }
        internal int ID { get; set; }
        internal string MobileNumber { get; set; }

        internal DataGridView _loadTable { get; set; }

        public void Save()
        {
            
            string GenerateedSQL = $"INSERT INTO Employee_Mob (emp_mob_num, employee_fk) VALUES ('{MobileNumber}','{EmpId}')";
            if(ExecuteSaveQuery (GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Update()
        {
            string GenerateedSQL = $"Update Employee_Mob set employee_fk ='{EmpId}', emp_mob_num ='{MobileNumber}' where emp_mob_id = '{ID}'";
            if (ExecuteUpdateQuery (GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Delete()
        {
            string GenerateedSQL = $"delete from Employee_Mob where emp_mob_id = '{ID}'";
            if (ExecuteDeleteQuery (GenerateedSQL))
            {
                LoadData();
            }
        }

        public void LoadData(DataGridView dataGridView)
        {
            string EmpMobSelectQuery = "select Emp.Emp_name as EmpName ,EmpMob.emp_mob_id as MobId ,EmpMob." +
            "emp_mob_num as MobNum from Employee_Table Emp join Employee_Mob EmpMob on EmpMob.employee_fk = Emp.Emp_num";
            ExecuteLoadData(EmpMobSelectQuery, dataGridView);
        }

        public void Search(string ID)
        {
            string EmpMobSelectQuery = $"select Emp.Emp_name as EmpName ,EmpMob.emp_mob_id as MobId ,EmpMob.emp_mob_num as MobNum " +
            $"from Employee_Table Emp join Employee_Mob EmpMob on EmpMob.employee_fk = Emp.Emp_num where EmpMob.emp_mob_id Like '{ID}%'";
            ExecuteLoadData(EmpMobSelectQuery,_loadTable);
        }

        public void LoadData()
        {
            string EmpMobSelectQuery = "select Emp.Emp_name as EmpName ,EmpMob.emp_mob_id as MobId ,EmpMob." +
            "emp_mob_num as MobNum from Employee_Table Emp join Employee_Mob EmpMob on EmpMob.employee_fk = Emp.Emp_num";
            ExecuteLoadData(EmpMobSelectQuery, _loadTable);
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
