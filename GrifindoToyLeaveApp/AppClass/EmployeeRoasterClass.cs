using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GrifindoToyLeaveApp.AppClass
{
    internal class EmployeeRoasterClass : SQL
    {

        internal string EmpId { get; set; }
        internal int ID { get; set; }
        internal DateTime StartTime { get; set; }
        internal DateTime EndTime { get; set; }
        internal string OffDay { get; set; }
        internal string HalfDay { get; set;}
        internal string MorningHalfDay {  get; set; }

        internal DataGridView _loadTable { get; set; }

        public void Save()
        {
            string GenerateedSQL = $"INSERT INTO Emp_Roas_table(employee_fk, start_time, end_time, off_day, half_day, " +
            $"is_morning_half_day) VALUES('{EmpId}','{StartTime}','{EndTime}','{OffDay}','{HalfDay}','{MorningHalfDay}')";
            if(ExecuteSaveQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Update()
        {
            string GenerateedSQL = $"update Emp_Roas_table set employee_fk ='{EmpId}', start_time ='{StartTime}', end_time ='" +
            $"{EndTime}', off_day ='{OffDay}', half_day ='{HalfDay}', is_morning_half_day ='{MorningHalfDay}' where empRoas_id = '{ID}'";
            if (ExecuteUpdateQuery(GenerateedSQL))
            {
                LoadData();
            }
        }

        public void Delete()
        {
            string GenerateedSQL = $"delete from Emp_Roas_table where empRoas_id = '{ID}'";
            if (ExecuteDeleteQuery(GenerateedSQL))
            {  
                LoadData(); 
            }
        }

        public void LoadData(DataGridView dataGridView)
        {
            string EmpRoasSelectQuery = "select Emp.Emp_num as EmpId ,Emp.Emp_name Name ,EmpRoas.empRoas_id as RoasID ,EmpRoas.start_time as" +
            " StartTime ,EmpRoas.end_time as EndTime ,EmpRoas.off_day as OffDay ,EmpRoas.half_day as HalfDay ,EmpRoas.is_morning_half_day " +
            "as MorningHalfDayOrNot From Employee_Table Emp join Emp_Roas_table EmpRoas on EmpRoas.employee_fk = Emp.Emp_num;";
            ExecuteLoadData(EmpRoasSelectQuery, dataGridView);
        }

        public void Search(string ID)
        {
            string EmpRoasSelectQuery = $"select Emp.Emp_num as EmpId ,Emp.Emp_name Name ,EmpRoas.empRoas_id as RoasID ,EmpRoas.start_time as StartTime" +
            $" ,EmpRoas.end_time as EndTime ,EmpRoas.off_day as OffDay ,EmpRoas.half_day as HalfDay ,EmpRoas.is_morning_half_day as MorningHalfDayOrNot" +
            $" From Employee_Table Emp join Emp_Roas_table EmpRoas on EmpRoas.employee_fk = Emp.Emp_num where EmpRoas.empRoas_id Like '{ID}%'";
            ExecuteLoadData(EmpRoasSelectQuery, _loadTable);
        }

        public void LoadData()
        {
            string EmpRoasSelectQuery = "select Emp.Emp_num as EmpId ,Emp.Emp_name Name ,EmpRoas.empRoas_id as RoasID ,EmpRoas.start_time as StartTime ,EmpRoas.end_time as" +
            " EndTime ,EmpRoas.off_day as OffDay ,EmpRoas.half_day as HalfDay ,EmpRoas.is_morning_half_day as MorningHalfDayOrNot From Employee_Table Emp join " +
            "Emp_Roas_table EmpRoas on EmpRoas.employee_fk = Emp.Emp_num;";
            ExecuteLoadData(EmpRoasSelectQuery, _loadTable);
        }

        public (string offDay, string halfDay) GetDaysByEmployeeId(int employeeId)
        {
            string offDay = string.Empty;
            string halfDay = string.Empty;

            string query = $"SELECT off_day, half_day FROM Emp_Roas_table WHERE employee_fk = @employee_fk";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@employee_fk", employeeId);
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            offDay = reader["off_day"]?.ToString() ?? string.Empty;
                            halfDay = reader["half_day"]?.ToString() ?? string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return (offDay, halfDay);
        }


        public (TimeSpan StartTime, TimeSpan EndTime) GetWorkTimesByEmployeeId(int employeeId)
        {
            TimeSpan startTime = TimeSpan.Zero;
            TimeSpan endTime = TimeSpan.Zero;

            string query = $"SELECT start_time, end_time FROM Emp_Roas_table WHERE employee_fk = @employee_fk";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@employee_fk", employeeId);
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["start_time"] != DBNull.Value)
                            {
                                startTime = (TimeSpan)reader["start_time"];
                            }
                            if (reader["end_time"] != DBNull.Value)
                            {
                                endTime = (TimeSpan)reader["end_time"];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            // Return both the start time and end time as a tuple
            return (startTime, endTime);
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
