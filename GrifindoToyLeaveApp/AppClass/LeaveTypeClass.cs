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
    internal class LeaveTypeClass : SQL
    {
        internal string EmpId { get; set; }
        internal int ID { get; set; }
        internal string AnnualLeave { get; set; }
        internal string CasualLeave { get; set; }
        internal string ShortLeave { get; set; }
        internal int GetAnnualLeaveCount { get; set; }
        internal DataGridView _loadTable {  get; set; }

        public void Save() 
        {
            string GenerateedSQL = $"INSERT INTO Leave_Type_Table(annua_leav_count, casu_leav_count, short_leave," +
            $" employee_fk) VALUES('{AnnualLeave}','{CasualLeave}','{ShortLeave}','{EmpId}')";
            if(ExecuteSaveQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Update()
        {
            string GenerateedSQL = $"update Leave_Type_Table set annua_leav_count ='{AnnualLeave}', casu_leav_count ='{CasualLeave}', " +
            $"short_leave ='{ShortLeave}', employee_fk ='{EmpId}' where leave_type_id ='{ID}'";
            if (ExecuteUpdateQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Delete()
        {
            string GenerateedSQL = $"delete from leave_type_table where leave_type_id = '{ID}'";
            if (ExecuteDeleteQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void LoadData(DataGridView dataGridView)
        {
            string EmpLeaveTypeSelectQuery = "select Emp.Emp_num as EmpId ,Emp.Emp_name Name ,LeaTyp.leave_type_id as LeaveType ," +
            "LeaTyp.annua_leav_count as AnnualLeave ,LeaTyp.casu_leav_count as CasualLeave ,LeaTyp.short_leave as ShortLeave " +
            "from Employee_Table Emp join Leave_Type_Table LeaTyp on LeaTyp.employee_fk = Emp.Emp_num";
            ExecuteLoadData(EmpLeaveTypeSelectQuery,dataGridView);
        }

        public void Search(string ID)
        {
            string EmpLeaveTypeSelectQuery = $"select Emp.Emp_num as EmpId ,Emp.Emp_name Name ,LeaTyp.leave_type_id as LeaveType ,LeaTyp." +
            $"annua_leav_count as AnnualLeave ,LeaTyp.casu_leav_count as CasualLeave ,LeaTyp.short_leave as ShortLeave from Employee_Table" +
            $" Emp join Leave_Type_Table LeaTyp on LeaTyp.employee_fk = Emp.Emp_num where LeaTyp.leave_type_id like '{ID}%'";
            ExecuteLoadData(EmpLeaveTypeSelectQuery, _loadTable);
        }

        public void LoadData()
        {
            string EmpLeaveTypeSelectQuery = "select Emp.Emp_num as EmpId ,Emp.Emp_name Name ,LeaTyp.leave_type_id as LeaveType ,LeaTyp.annua_leav_count" +
            " as AnnualLeave ,LeaTyp.casu_leav_count as CasualLeave ,LeaTyp.short_leave as ShortLeave from Employee_Table Emp join Leave_Type_Table" +
            " LeaTyp on LeaTyp.employee_fk = Emp.Emp_num";
            ExecuteLoadData(EmpLeaveTypeSelectQuery, _loadTable);
        }


        public void LoadAsFk(ComboBox leaveTypeComboBox)
        {
            string sql1 = "select * from Leave_Type_Table join employee_table on Leave_Type_Table.employee_fk = employee_table.Emp_num";
            DataTable dt1 = GetDataTable(sql1);
            leaveTypeComboBox.DisplayMember = "Emp_name";
            leaveTypeComboBox.ValueMember = "leave_type_id";
            leaveTypeComboBox.DataSource = dt1;
        }

        public void EmployeeLoginLoadAsFk(Label label)
        {
            string sql1 = $"select * from Leave_Type_Table join employee_table on Leave_Type_Table.employee_fk = employee_table.Emp_num where employee_fk={EmpUserAuthonticationClass.Id}";
            DataTable dt1 = GetDataTable(sql1);
            if (dt1.Rows.Count > 0)
            {
                string employeeName = dt1.Rows[0]["Emp_name"].ToString();
                label.Text = $"{employeeName}";
            }
        }

        //public void DeductLeave(string leaveType, double leavesTaken, int employeeId)
        //{
        //    // Fetch current leave balances for the employee
        //    var (annual, casual, shortLeave) = GetDaysByEmployeeId(employeeId);

        //    // Debugging: Display current leave balances
        //    MessageBox.Show($"Before Deduction - Annual: {annual}, Casual: {casual}, Short: {shortLeave}", "Debug Info");

        //    switch (leaveType)
        //    {
        //        case "Annual":
        //            annual -= (int)leavesTaken;
        //            break;
        //        case "Casual":
        //            casual -= (int)leavesTaken;
        //            break;
        //        case "Short":
        //            shortLeave -= (int)leavesTaken;
        //            break;
        //        default:
        //            throw new Exception("Invalid leave type");
        //    }

        //    // Debugging: Display updated leave balances
        //    MessageBox.Show($"After Deduction - Annual: {annual}, Casual: {casual}, Short: {shortLeave}", "Debug Info");

        //    // Update the leave type record in the database
        //    string query = $"UPDATE Leave_Type_Table SET annua_leav_count = {annual}, casu_leav_count = {casual}, short_leave = {shortLeave} WHERE employee_fk = {employeeId}";
        //    ExecuteUpdateQuery(query);
        //}

        public (int Annual, int Casual, int Short) GetDaysByEmployeeId(int employeeId)
        {
            int annual = 0;
            int casual = 0;
            int shortLeave = 0;

            string query = "SELECT annua_leav_count, casu_leav_count, short_leave FROM Leave_Type_Table WHERE employee_fk = @employee_fk";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@employee_fk", employeeId);

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            annual = reader["annua_leav_count"] != DBNull.Value ? Convert.ToInt32(reader["annua_leav_count"]) : 0;
                            casual = reader["casu_leav_count"] != DBNull.Value ? Convert.ToInt32(reader["casu_leav_count"]) : 0;
                            shortLeave = reader["short_leave"] != DBNull.Value ? Convert.ToInt32(reader["short_leave"]) : 0;
                        }
                        else
                        {
                            MessageBox.Show("No leave data found for the employee.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching leave data: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

            return (annual, casual, shortLeave);

        }

        public string GetAvailableLeave(string leaveType, int employeeId)
        {
            var (annual, casual, shortLeave) = GetDaysByEmployeeId(employeeId);

            switch (leaveType)
            {
                case "Annual":
                    return annual.ToString();
                case "Casual":
                    return casual.ToString();
                case "Short":
                    return shortLeave.ToString();
                default:
                    throw new Exception("Invalid leave type");
            }
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
