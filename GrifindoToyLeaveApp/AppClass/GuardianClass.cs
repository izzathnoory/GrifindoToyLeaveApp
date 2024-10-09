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
    internal class GuardianClass : SQL
    {

        internal string EmpId { get; set; }
        internal int ID { get; set; }
        internal string Name { get; set; }
        internal string Email { get; set;}
        internal string Nic { get; set; }
        internal string Address { get; set; }
        internal string Relation { get; set; }

        internal DataGridView _loadTable { get; set; }

        public void Save()
        {
            string GenerateedSQL = $"INSERT INTO Emp_Guar_Table (emp_guar_name, emp_guar_email, emp_guar_nic, emp_guar_addre, " +
            $"emp_guar_relation, employee_fk) VALUES ('{Name}','{Email}','{Nic}','{Address}','{Relation}','{EmpId}')";
            if (ExecuteSaveQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Update()
        {
            string GenerateedSQL = $"Update Emp_Guar_Table set employee_fk = '{EmpId}',emp_guar_name = '{Name}',emp_guar_email = " +
            $"'{Email}', emp_guar_nic = '{Nic}', emp_guar_addre = '{Address}', emp_guar_relation = '{Relation}' where emp_guar_id = '{ID}'";
            if (ExecuteUpdateQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Delete()
        {
            string GenerateedSQL = $"delete from Emp_Guar_Table where emp_guar_id = '{ID}'";
            if (ExecuteDeleteQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void loadData(DataGridView dataGridView)
        {
            string GuardianSelectQuery = "select Emp.Emp_name as Name ,EmpGuar.emp_guar_id as GuardianId ,EmpGuar.emp_guar_name as GuarName " +
            ",EmpGuar.emp_guar_email as Email ,EmpGuar.emp_guar_nic as NIC ,EmpGuar.emp_guar_addre as Address ,EmpGuar.emp_guar_relation " +
            "as RelationOfTheEmployee from Employee_Table Emp join Emp_Guar_Table EmpGuar on EmpGuar.employee_fk = Emp.Emp_num";
            ExecuteLoadData(GuardianSelectQuery,dataGridView);
        }

        public void Search(string ID)
        {
            string GuardianSelectQuery = $"select Emp.Emp_name as EmpName ,EmpGuar.emp_guar_id as GuardianId ,EmpGuar.emp_guar_name as GuarName" +
            $" ,EmpGuar.emp_guar_email as Email ,EmpGuar.emp_guar_nic as NIC ,EmpGuar.emp_guar_addre as Address ,EmpGuar.emp_guar_relation " +
            $"as RelationOfTheEmployee from Employee_Table Emp join Emp_Guar_Table EmpGuar on EmpGuar.employee_fk = Emp.Emp_num where " +
            $"EmpGuar.emp_guar_id like '{ID}%'";
            ExecuteLoadData(GuardianSelectQuery, _loadTable);
        }

        public void LoadData()
        {
            string GuardianSelectQuery = "select Emp.Emp_name as Name ,EmpGuar.emp_guar_id as GuardianId ,EmpGuar.emp_guar_name as GuarName " +
            ",EmpGuar.emp_guar_email as Email ,EmpGuar.emp_guar_nic as NIC ,EmpGuar.emp_guar_addre as Address ,EmpGuar.emp_guar_relation as " +
            "RelationOfTheEmployee from Employee_Table Emp join Emp_Guar_Table EmpGuar on EmpGuar.employee_fk = Emp.Emp_num";
            ExecuteLoadData(GuardianSelectQuery, _loadTable);
        }


        public void loadAsFkGuardian(ComboBox GuarComboBox)
        {
            string sql1 = "select * from Emp_Guar_Table join Employee_Table on Emp_Guar_Table.employee_fk = Employee_Table.Emp_num";
            DataTable dt1 = GetDataTable(sql1);
            dt1.Rows.Add(new Object[] { 0, "All Guardian" });
            GuarComboBox.DataSource = dt1;
            GuarComboBox.DisplayMember = "emp_guar_name";
            GuarComboBox.ValueMember = "emp_guar_id";
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
