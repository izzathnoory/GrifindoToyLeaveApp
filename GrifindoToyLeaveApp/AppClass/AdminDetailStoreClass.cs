using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class AdminDetailStoreClass : SQL
    {
        internal DataTable GetEmployeeCount()
        {
            string sql = $"select count(*) as Employee_Count from employee_table;";
            return GetDataTable(sql);
        }

        internal DataTable GetPendingLeaveCount()
        {
            string sql = "select count(*) as TotalPending From Leave_req_table where leave_status ='Pending'";
            return GetDataTable(sql);
        }

        internal DataTable GetTodayLeave()
        {
            string sql = "select count(*) as TodayLeave from Leave_req_table where CAST(GETDATE()" +
            " as date) BETWEEN CAST(leave_beg_date as date) AND CAST(leave_end_date as date)";
            return GetDataTable(sql);
        }

        internal DataTable GetTodayAnnualLeave()
        {
            string sql = "SELECT COUNT(*) AS TodayAnnual FROM Leave_req_table WHERE CAST(GETDATE() AS DATE)" +
            " BETWEEN CAST(leave_beg_date AS DATE) AND CAST(leave_end_date AS DATE) AND Leave_Type = 'Annual'";
            return GetDataTable(sql);
        }

        internal DataTable GetTodayCasuallLeave()
        {
            string sql = "SELECT COUNT(*) AS TodayCasual FROM Leave_req_table WHERE CAST(GETDATE() AS DATE)" +
            " BETWEEN CAST(leave_beg_date AS DATE) AND CAST(leave_end_date AS DATE) AND Leave_Type = 'Casual'";
            return GetDataTable(sql);
        }

        internal DataTable GetTodayShortLeave()
        {
            string sql = "SELECT COUNT(*) AS TodayShort FROM Leave_req_table WHERE CAST(GETDATE() AS DATE)" +
            " BETWEEN CAST(leave_beg_date AS DATE) AND CAST(leave_end_date AS DATE) AND Leave_Type = 'Short'";
            return GetDataTable(sql);
        }

        internal DataTable GetAllAdminDetails()
        {
            string sql = $"select Admin_Table.admin_id as AdminId, Admin_Table.username as AdmName, Employee_Mob" +
            $".emp_mob_num as AdmMobile, Employee_Table.emp_email as AdminEmail, Employee_Table.emp_nic as AdminNic" +
            $" from Admin_Table join Employee_Table on Admin_Table.employee_fk = Employee_Table.Emp_num join" +
            $" Employee_Mob on Employee_Table.Emp_num = Employee_Mob.employee_fk where Admin_Table.admin_id ={AdminUserAuthonticationClass.Id}";
            return GetDataTable(sql);
        }
    }
}
