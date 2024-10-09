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
    internal class EmployeeDetailStoreClass : SQL
    {
        internal DataTable GetUserInformation()
        {
            string sql = $"select * from Employee_Table where Emp_num = {EmpUserAuthonticationClass.Id}";
            return GetDataTable(sql);
        }

        internal DataTable GetEmployeeMobile()
        {
            string sql1 = $"select * from Employee_Mob where employee_fk = {EmpUserAuthonticationClass.Id}";
            return GetDataTable(sql1);
        }

        internal DataTable GetUserLeaveTypeInformation()
        {
            string sql = $"select * from Leave_Type_Table where employee_fk = {EmpUserAuthonticationClass.Id}";
            return GetDataTable(sql);
        }

        internal DataTable GetGuardian()
        {
            string sql = $"select * from Emp_Guar_Table where employee_fk = {EmpUserAuthonticationClass.Id}";
            return GetDataTable(sql);
        }


        internal DataTable ReqLeaveCountInformation()
        {
            string sql = $"SELECT e.Emp_name, COUNT(lr.lea_req_id) AS Total_Leave_Count FROM Employee_Table e JOIN" +
            $" Leave_Type_Table lt ON e.Emp_num = lt.employee_fk JOIN Leave_req_table lr ON lt.leave_type_id =" +
            $" lr.leave_type_fk WHERE lr.Leave_Type IN ('Annual', 'Casual', 'Short') AND e.Emp_num =" +
            $" {EmpUserAuthonticationClass.Id} GROUP BY e.Emp_name";
            return GetDataTable(sql);
        }

        internal DataTable GetGuardianMobile()
        {
            string sql = $"SELECT EmpGuarMob.emp_guar_mob_id, EmpGuarMob.emp_guar_mob_num, EmpGuarMob.emp_guar_fk, EmpGuar" +
            $".employee_fk, Emp.Emp_num FROM Emp_Guar_Table EmpGuar JOIN emp_guar_mob EmpGuarMob ON EmpGuar.emp_guar_id = " +
            $"EmpGuarMob.emp_guar_fk JOIN Employee_Table Emp ON Emp.Emp_num = EmpGuar.employee_fk WHERE EmpGuar." +
            $"employee_fk = {EmpUserAuthonticationClass.Id}";
            return GetDataTable(sql);
        }
    }
}
