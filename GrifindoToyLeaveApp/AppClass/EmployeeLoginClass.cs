using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class EmployeeLoginClass : SQL
    {
        internal string username { get; set; }
        internal string password { get; set; }

        public bool Login()
        {

            string sql_data = $"select *from Leave_Type_Table type join Employee_Table emp on emp.Emp_num = type.employee_fk where emp.Emp_num = '"+username+"' and emp.password =  '"+password+"'";
            DataTable dt = ExecuteQuery(sql_data);

            if (dt.Rows.Count > 0)
            {
                EmpUserAuthonticationClass.Id = int.Parse(dt.Rows[0]["Emp_num"].ToString());
                EmpUserAuthonticationClass.Username = dt.Rows[0]["Emp_name"].ToString();
                EmpUserAuthonticationClass.LeaveType_ID = int.Parse(dt.Rows[0]["leave_type_id"].ToString());
                return true;
            }
            return false;
        }

    }
}
