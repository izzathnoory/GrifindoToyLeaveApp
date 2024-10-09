using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GrifindoToyLeaveApp.ComClass
{
    internal class CommonDataBaseCodes
    {
        private SqlConnection conn;
        public CommonDataBaseCodes (string sqlConnection) 
        {
            conn = new SqlConnection (sqlConnection);
        }

        public bool execute(string sql) 
        {
            bool status = false;

            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                int effectedRows = cmd.ExecuteNonQuery();
                if (effectedRows > 0)
                {
                    status = true;
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


            return status;
        }

        public DataTable getQueryData(string sql)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dataTable);
            return dataTable;
        }

        public void executeInsertQuery(string sql, string message = "Data Inserted Successfully")
        {
            if (execute(sql))
            {
                MessageBox.Show(message);
            }
        }


        public void executeUpdateQuery(string sql, string message = "Data Updated Successfully")
        {
            if (execute(sql))
            {
                MessageBox.Show(message);
            }
        }

        public void executeDeleteQuery(string sql, string message = "Data Deleted Successfully")
        {
            if (execute(sql))
            {
                MessageBox.Show(message);
            }
        }

        public void loadDataInGridView(string sql, DataGridView dataGridView)
        {
            DataTable dataTable = getQueryData(sql);
            dataGridView.DataSource = dataTable;
        }

        public void loadFkDataInComboBox(string sql, ComboBox comboBox, string idColumn, string nameColumn)
        {
            DataTable dataTable = getQueryData(sql);
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = nameColumn;
            comboBox.ValueMember = idColumn;
        }

        
    }
}
