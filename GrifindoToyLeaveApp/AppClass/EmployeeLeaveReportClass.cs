using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class EmployeeLeaveReportClass : SQL
    {
        internal string ID { get; set; }
        internal string Name { get; set; }
        internal DateTime StartDate { get; set; }
        internal DateTime EndDate { get; set; }

        public void SpecificTakenLeaveCount(DataGridView dataGridView)
        {
            string SpecificEmployeeDetail = $"select Emp.Emp_num as EmpId, Emp.Emp_name as EmpName, LeaTyp.leave_type_id as LeaveTypeId, LeaTyp.annua_leav_count as Allowed_Annual_Leave, (LeaTyp.annua_leav_count" +
            $" - (SELECT SUM(DATEDIFF(day, leave_beg_date, leave_end_date) + 1) AS total_casual_leave_days FROM Leave_req_table WHERE Leave_Type = 'Annual' and leave_type_fk = LeaTyp.leave_type_id)) as " +
            $"AnnualLeaveBalance, LeaTyp.casu_leav_count as Allowed_Casual_Leave, (LeaTyp.casu_leav_count - (SELECT SUM(DATEDIFF(day, leave_beg_date, leave_end_date) + 1) AS total_casual_leave_days FROM " +
            $"Leave_req_table WHERE Leave_Type = 'Casual' and leave_type_fk = LeaTyp.leave_type_id)) as CasualLeaveBalance, LeaTyp.short_leave as Allowed_Short_Leave, (LeaTyp.short_leave - (SELECT SUM(DATEDIFF" +
            $"(day, leave_beg_date, leave_end_date) + 1) AS total_casual_leave_days FROM Leave_req_table WHERE Leave_Type = 'Short' and leave_type_fk = LeaTyp.leave_type_id)) as ShortLeaveBalance from Admin_Table" +
            $" adm join Leave_req_table LeaReq on adm.admin_id = LeaReq.admin_fk join Leave_Type_Table LeaTyp on LeaReq.leave_type_fk = LeaTyp.leave_type_id join Employee_Table Emp on LeaTyp.employee_fk = Emp.Emp_num " +
            $"where LeaReq.leave_beg_date >= '{StartDate}' and LeaReq.leave_end_date <= '{EndDate}' and Emp.Emp_num = '{EmpUserAuthonticationClass.Id}' group by Emp.Emp_num, Emp.Emp_name, LeaTyp.leave_type_id, " +
            $"LeaTyp.annua_leav_count,LeaTyp.casu_leav_count, LeaTyp.short_leave";
            ExecuteLoadData(SpecificEmployeeDetail, dataGridView);
        }

        public void SpecificTakenLeaveDetail(DataGridView dataGridView)
        {
            string SpecificEmployeeDetail = $"select Emp.Emp_num as EmpId, Emp.Emp_name as EmpName, LeaTyp.leave_type_id as LeaveTypeId, LeaReq.lea_req_id as ReqId, LeaReq.reason as Reason, LeaReq.leave_beg_date as BeginDate," +
            $" LeaReq.leave_end_date as EndDate, LeaReq.leave_status as LeaveStatus, LeaReq.Leave_Type as LeaveType from Admin_Table adm join Leave_req_table LeaReq on adm.admin_id = LeaReq.admin_fk join Leave_Type_Table" +
            $" LeaTyp on LeaReq.leave_type_fk = LeaTyp.leave_type_id join Employee_Table Emp on LeaTyp.employee_fk = Emp.Emp_num where LeaReq.leave_beg_date >= '{StartDate}' and LeaReq.leave_end_date <= '{EndDate}' and " +
            $"Emp.Emp_num = '{EmpUserAuthonticationClass.Id}'";
            ExecuteLoadData(SpecificEmployeeDetail, dataGridView);
        }
    }
}
