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

        public (int Annual, int Casual, int Short) GetDaysByEmployeeId(int employeeId)
        {
            int annual = 0;
            int casual = 0;
            int shortLeave = 0;

            // Query to get the leave counts
            string query = "SELECT annua_leav_count, casu_leav_count, short_leave FROM Leave_Type_Table WHERE employee_fk = @employee_fk";

            using (SqlCommand cmd = new SqlCommand(query, conn)) // Using the 'conn' from the parent SQL class
            {
                // Parameterized query to prevent SQL injection
                cmd.Parameters.AddWithValue("@employee_fk", employeeId);

                try
                {
                    // Open the connection if it's not already open
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    // Execute the query and process the result
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Read and convert values from the database, handling null values
                            annual = reader["annua_leav_count"] != DBNull.Value ? Convert.ToInt32(reader["annua_leav_count"]) : 0;
                            casual = reader["casu_leav_count"] != DBNull.Value ? Convert.ToInt32(reader["casu_leav_count"]) : 0;
                            shortLeave = reader["short_leave"] != DBNull.Value ? Convert.ToInt32(reader["short_leave"]) : 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching leave data: " + ex.Message);
                }
                finally
                {
                    // Ensure the connection is closed
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

            // Return the leave counts as a tuple
            return (annual, casual, shortLeave);
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
