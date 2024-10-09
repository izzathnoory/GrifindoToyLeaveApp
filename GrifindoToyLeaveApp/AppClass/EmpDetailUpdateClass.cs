using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class EmpDetailUpdateClass : SQL
    {
        internal int id { get; set; }
        internal float experiance { get; set; }
        internal string name { get; set; }
        internal string email { get; set; }
        internal string password { get; set; }
        internal string address { get; set; }
        internal string nic { get; set; }
        internal string passportNumber { get; set; }
        internal string EmpMobile { get; set; }
        internal string EmpGuarMobile { get; set; }
        internal string EmpGuarName { get; set; }
        internal string EmpGuarEmail { get; set; }
        internal string EmpGuarNIC { get; set; }
        internal string EmpGuarAddress { get; set; }
        internal string EmpGuarRelation { get; set; }


        public void updateFromEmployee()
        {
            string GenerateedSQL = $"update Employee_Table set password='{password}',Emp_name='{name}',emp_email='{email}'" +
            $",emp_addre='{address}',emp_exp='{experiance}',emp_nic='{nic}',emp_pass_no='{passportNumber}' where Emp_num ='{id}'";
            string GenerateedSQL1 = $"update Employee_Mob set emp_mob_num ='{EmpMobile}' where employee_fk ='{id}'";
            string GenerateedSQL2 = $"UPDATE emp_guar_mob SET emp_guar_mob.emp_guar_mob_num = '{EmpGuarMobile}' FROM emp_guar_mob " +
            $"JOIN Emp_Guar_Table ON Emp_Guar_Table.emp_guar_id = emp_guar_mob.emp_guar_fk JOIN Employee_Table ON Employee_Table" +
            $".Emp_num = Emp_Guar_Table.employee_fk WHERE Emp_Guar_Table.employee_fk = '{id}'";
            string GenerateedSQL3 = $"Update Emp_Guar_Table set emp_guar_name = '{EmpGuarName}',emp_guar_email = '{EmpGuarEmail}'," +
            $" emp_guar_nic = '{EmpGuarNIC}', emp_guar_addre = '{EmpGuarAddress}', emp_guar_relation = '{EmpGuarRelation}' where employee_fk= '{id}'";
            ExecuteUpdateQuery(GenerateedSQL);
            ExecuteEmpUpdateQuery(GenerateedSQL1);
            ExecuteEmpUpdateQuery(GenerateedSQL2);
            ExecuteEmpUpdateQuery(GenerateedSQL3);
        }
    }
}
