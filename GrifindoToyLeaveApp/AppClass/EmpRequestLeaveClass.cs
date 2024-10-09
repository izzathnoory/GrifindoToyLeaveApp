using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class EmpRequestLeaveClass : SQL
    {
        internal string EmpId { get; set; }
        internal int ID { get; set; }
        internal string Name { get; set; }
        internal int LeaTypeId { get; set; }
        internal string Reason { get; set; }
        internal DateTime LeaveBeg { get; set; }
        internal DateTime LeaveEnd { get; set; }
        internal DateTime ShortLeaveTime { get; set; }
        internal string LeaveType { get; set; }
        internal string LeaveStatus { get; set; }
        
        internal double LeaveCount { get; set; }

        internal DataGridView _loadTable {  get; set; }
        internal List<DateTime> LeaveDates { get; set; } = new List<DateTime>();


        public void save()
        {
            string GenerateedSQL = $"insert into Leave_req_table(reason , leave_beg_date   , leave_end_date , admin_fk , leave_type_fk , leave_status , Leave_Type , Short_Leave_Time, LeavesTaken)" +
            $"values('{Reason}' , '{LeaveBeg}' , '{LeaveEnd}' , '2' , '{EmpUserAuthonticationClass .LeaveType_ID}' , '{LeaveStatus}' , '{LeaveType}' , '{ShortLeaveTime}','{LeaveCount}')";
            if (ExecuteSaveQuery(GenerateedSQL))
            {
                loadData();
            }
        }


        public void update()
        {
            string GenerateedSQL = $"update Leave_req_table set reason='{Reason}',admin_fk='2', leave_beg_date ='{LeaveBeg}', leave_status" +
            $" ='{LeaveStatus}',leave_end_date ='{LeaveEnd}',Short_Leave_Time = '{ShortLeaveTime}',LeavesTaken = '{LeaveCount}',Leave_Type ='{LeaveType}' where lea_req_id ='{ID}'";
            if (ExecuteUpdateQuery(GenerateedSQL))
            {
                loadData();
            }
        }

        public void delete()
        {
            string GenerateedSQL = $"delete from Leave_req_table where lea_req_id = '{ID}'";
            if (ExecuteDeleteQuery(GenerateedSQL))
            {
                loadData();
            }
        }

        public void loadData(DataGridView dataGridView)
        {
            string EmployeeLeaReqSelectQuery = $"select leareq.lea_req_id as ReqId, emp.emp_name as EmpName, leareq.reason as Reason, leareq.leave_beg_date as" +
            $" BeginDate, leareq.leave_end_date as EndDate, leareq.Leave_Type as LeaveType, leareq.leave_status as LeaveStatus from leave_req_table leareq " +
            $"join leave_type_table leatyp on leareq.leave_type_fk = leatyp.leave_type_id join employee_table emp on leatyp.employee_fk = emp.emp_num " +
            $"where emp.emp_num ='{EmpUserAuthonticationClass.Id}'";
            ExecuteLoadData(EmployeeLeaReqSelectQuery, dataGridView);
        }


        public void loadData()
        {
            string EmployeeLeaReqSelectQuery = $"select leareq.lea_req_id as ReqId, admin_fk as Admin, emp.emp_name as EmpName, leareq.reason as Reason," +
            $" leareq.Short_Leave_Time, leareq.leave_beg_date as BeginDate, leareq.leave_end_date as EndDate, leareq.Leave_Type as LeaveType, leareq." +
            $"leave_status as LeaveStatus from leave_req_table leareq join leave_type_table leatyp on leareq.leave_type_fk = leatyp.leave_type_id join" +
            $" employee_table emp on leatyp.employee_fk = emp.emp_num where emp.emp_num ='{EmpUserAuthonticationClass.Id}'";
            ExecuteLoadData(EmployeeLeaReqSelectQuery, _loadTable);
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
                    else if (control is DateTimePicker)
                    {
                        ((DateTimePicker)control).Value = DateTime.Now;
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
