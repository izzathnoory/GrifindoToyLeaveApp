using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class GuardianMobileClass :SQL
    {

        internal string EmpId { get; set; }
        internal string GuarId { get; set; }
        internal int ID { get; set; }
        internal string MobileNumber { get; set; }

        internal DataGridView _loadTable { get; set; }

        public void Save()
        {
            string GenerateedSQL = $"INSERT INTO emp_guar_mob (emp_guar_mob_num, emp_guar_fk) VALUES('{MobileNumber}','{GuarId}')";
            if(ExecuteSaveQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Update()
        {
            string GenerateedSQL = $"Update emp_guar_mob set emp_guar_fk = '{GuarId}',emp_guar_mob_num = '{MobileNumber}' where emp_guar_mob_id ='{ID}'";
            if (ExecuteUpdateQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Delete()
        {
            string GenerateedSQL = $"delete from emp_guar_mob where emp_guar_mob_id = '{ID}'";
            if(ExecuteDeleteQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void LoadData(DataGridView dataGridView)
        {
            string GuardianMobSelectQuery = "select Emp.Emp_name as EmpName ,EmpGuard.emp_guar_id as GuardId ,EmpGuard.emp_guar_name as GuarName" +
            " ,EmpGuarMob.emp_guar_mob_id as GuarMobId ,EmpGuarMob.emp_guar_mob_num AS GuarMobNum FROM Employee_Table Emp JOIN Emp_Guar_Table" +
            " EmpGuard ON EmpGuard.employee_fk = Emp.Emp_num JOIN emp_guar_mob EmpGuarMob ON EmpGuarMob.emp_guar_fk = EmpGuard.emp_guar_id";
            ExecuteLoadData(GuardianMobSelectQuery,dataGridView);
        }

        public void Search(string ID)
        {
            string GuardianMobSelectQuery = $"select Emp.Emp_name as EmpName ,EmpGuard.emp_guar_id as GuardId ,EmpGuard.emp_guar_name as GuarName " +
            $",EmpGuarMob.emp_guar_mob_id as GuarMobId ,EmpGuarMob.emp_guar_mob_num AS GuarMobNum FROM Employee_Table Emp JOIN Emp_Guar_Table " +
            $"EmpGuard ON EmpGuard.employee_fk = Emp.Emp_num JOIN emp_guar_mob EmpGuarMob ON EmpGuarMob.emp_guar_fk = EmpGuard.emp_guar_id where" +
            $" EmpGuarMob.emp_guar_mob_id Like '{ID}%'";
            ExecuteLoadData(GuardianMobSelectQuery, _loadTable);
        }

        public void LoadData()
        {
            string GuardianMobSelectQuery = "select Emp.Emp_name as EmpName ,EmpGuard.emp_guar_id as GuardId ,EmpGuard.emp_guar_name as GuarName " +
            ",EmpGuarMob.emp_guar_mob_id as GuarMobId ,EmpGuarMob.emp_guar_mob_num AS GuarMobNum FROM Employee_Table Emp JOIN Emp_Guar_Table " +
            "EmpGuard ON EmpGuard.employee_fk = Emp.Emp_num JOIN emp_guar_mob EmpGuarMob ON EmpGuarMob.emp_guar_fk = EmpGuard.emp_guar_id";
            ExecuteLoadData(GuardianMobSelectQuery, _loadTable);
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
