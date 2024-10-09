using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class AdminLoginClass : SQL
    {
        internal string username { get; set; }
        internal string password { get; set; }

        public bool Login()
        {
            string sql_data = $"SELECT * FROM Admin_Table WHERE username = '{username}' AND password = '{password}'";
            DataTable dt = ExecuteQuery(sql_data);

            if (dt.Rows.Count > 0)
            {
                AdminUserAuthonticationClass.Id = int.Parse(dt.Rows[0]["admin_id"].ToString());
                AdminUserAuthonticationClass.Username = dt.Rows[0]["username"].ToString();
                return true;
            }
            return false;
        }
    }
}
