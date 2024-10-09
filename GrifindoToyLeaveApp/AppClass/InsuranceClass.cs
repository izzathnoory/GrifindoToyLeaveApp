using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class InsuranceClass :SQL
    {

        internal string EmpId { get; set; }
        internal int ID { get; set; }
        internal string InsType { get; set; }
        internal SqlMoney InsAmount { get; set; }

        internal DataGridView _loadTable { get; set; }

        public void Save() 
        {
            string GenerateedSQL = $"INSERT INTO Insurance_Table (ins_type, ins_amount, employee_fk) VALUES('{InsType}','{InsAmount}','{EmpId}')";
            if(ExecuteSaveQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Update()
        {
            string GenerateedSQL = $"Update Insurance_Table set employee_fk = '{EmpId}',ins_type = '{InsType}', ins_amount = '{InsAmount}' where emp_ins_id ='{ID}'";
            if (ExecuteUpdateQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Delete()
        {
            string GenerateedSQL = $"delete from Insurance_Table where emp_ins_id = '{ID}'";
            if (ExecuteDeleteQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void LoadData(DataGridView dataGridView)
        {
            string InsuranceSelectQuery = "select Emp.Emp_num as EmpId ,Emp.Emp_name as Name ,Ins.emp_ins_id as InsId ,Ins.ins_type as InsType ,Ins.ins_amount " +
            "as InsAmount from Employee_Table Emp join Insurance_Table INS on INS.employee_fk = Emp.Emp_num";
            ExecuteLoadData(InsuranceSelectQuery,dataGridView);
        }

        public void Search(string ID)
        {
            string InsuranceSelectQuery = $"select Emp.Emp_num as EmpId ,Emp.Emp_name as Name ,Ins.emp_ins_id as InsId ,Ins.ins_type as InsType" +
            $" ,Ins.ins_amount as InsAmount from Employee_Table Emp join Insurance_Table INS on INS.employee_fk = Emp.Emp_num where INS.emp_ins_id like '{ID}%'";
            ExecuteLoadData(InsuranceSelectQuery, _loadTable);
        }

        public void LoadData()
        {
            string InsuranceSelectQuery = "select Emp.Emp_num as EmpId ,Emp.Emp_name as Name ,Ins.emp_ins_id as InsId ,Ins.ins_type as InsType ,Ins.ins_amount as" +
            " InsAmount from Employee_Table Emp join Insurance_Table INS on INS.employee_fk = Emp.Emp_num";
            ExecuteLoadData(InsuranceSelectQuery, _loadTable);
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
