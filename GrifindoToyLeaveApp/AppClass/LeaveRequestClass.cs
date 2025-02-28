using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class LeaveRequestClass : SQL
    {

        internal string AdmId { get; set; }
        internal string EmpId { get; set; }
        internal int ID { get; set; }
        internal string LeaType { get; set;}
        internal string Reason { get; set;}
        internal DateTime LeaveBeg { get; set;}
        internal DateTime LeaveEnd { get; set;}
        internal string LeaveStatus { get; set;}
        internal string LeaveType { get; set;}
        internal DateTime ShortLeaveTime { get; set;}
        internal int OffDayCount { get; set; }
        internal double HalfDayCount { get; set; }
        internal double LeavesTaken { get; set; }


        internal DataGridView _loadTable {  get; set; }

        private EmployeeRoasterClass empRoas = new EmployeeRoasterClass();

        EmployeeDetailStoreClass employeeDetailStore = new EmployeeDetailStoreClass();

        public void save()
        {
            string GenerateedSQL = $"INSERT INTO Leave_req_table (reason, leave_beg_date, leave_end_date, Short_Leave_Time, admin_fk, leave_type_fk, leave_status, Leave_Type,LeavesTaken)" +
            $" VALUES ('{Reason}','{LeaveBeg}','{LeaveEnd}','{ShortLeaveTime}','{AdmId}','{LeaType}','{LeaveStatus}','{LeaveType}','{LeavesTaken}')";

            if (ExecuteSaveQuery(GenerateedSQL))
            {
                loadData();
            }
        }

        public void update()
        {
            string GenerateedSQL = $"update Leave_req_table set reason='{Reason}', leave_beg_date ='{LeaveBeg}', leave_end_date ='{LeaveEnd}', admin_fk ='{AdmId}', Short_Leave_Time" +
            $" ='{ShortLeaveTime}', leave_type_fk ='{LeaType}',Leave_Type ='{LeaveType}',LeavesTaken='{LeavesTaken}', leave_status = '{LeaveStatus}' where lea_req_id ='{ID}'";
            if (ExecuteUpdateQuery(GenerateedSQL))
            {
                loadData();
            }
        }

        public void updateStatus()
        {
            string GenerateedSQL = $"update Leave_req_table set leave_status = '{LeaveStatus}' where lea_req_id ='{ID}'";
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
            string EmployeeLeaReqSelectQuery = "select Adm.username as AdmName, Emp.Emp_name as EmpName, LeaReq.lea_req_id as ReqId, LeaReq.Short_Leave_Time as ShortLeaveTime," +
            "LeaReq.reason as Reason, LeaReq.Leave_Type as LeaveType, LeaReq.leave_beg_date as BeginDate, LeaReq.leave_end_date as EndDate, LeaReq.leave_status as LeaveStatus" +
            " from Admin_Table Adm join Leave_req_table LeaReq on Adm.admin_id = LeaReq.admin_fk join Leave_Type_Table LeaTyp on LeaReq.leave_type_fk = LeaTyp.leave_type_id" +
            " join Employee_Table Emp on LeaTyp.employee_fk = Emp.Emp_num";
            ExecuteLoadData(EmployeeLeaReqSelectQuery,dataGridView);
        }

        public void Search(string ID)
        {
            string EmployeeLeaReqSelectQuery = $"select Adm.username AS AdmName, LeaReq.lea_req_id AS ReqId, LeaReq.reason AS Reason, LeaReq.Short_Leave_Time as ShortLeaveTime, LeaReq.Leave_Type" +
            $" AS LeaveType, LeaReq.leave_beg_date AS BeginDate, LeaReq.leave_end_date AS EndDate, LeaReq.leave_status AS LeaveStatus FROM Admin_Table Adm JOIN Leave_req_table LeaReq ON Adm" +
            $".admin_id = LeaReq.admin_fk JOIN Leave_Type_Table LeaTyp ON LeaReq.leave_type_fk = LeaTyp.leave_type_id WHERE LeaReq.lea_req_id LIKE '{ID}%'";
            ExecuteLoadData(EmployeeLeaReqSelectQuery, _loadTable);
        }

        public void loadData()
        {
            string EmployeeLeaReqSelectQuery = "select Adm.username as AdmName, Emp.Emp_name as EmpName, LeaReq.lea_req_id as ReqId, LeaReq.reason as Reason ," +
            "LeaReq.Short_Leave_Time as ShortLeaveTime, LeaReq.Leave_Type as LeaveType, LeaReq.leave_beg_date as BeginDate, LeaReq.leave_end_date as EndDate, " +
            "LeaReq.leave_status as LeaveStatus from Admin_Table Adm join Leave_req_table LeaReq on Adm.admin_id = LeaReq.admin_fk join Leave_Type_Table LeaTyp " +
            "on LeaReq.leave_type_fk = LeaTyp.leave_type_id join Employee_Table Emp on LeaTyp.employee_fk = Emp.Emp_num";
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
