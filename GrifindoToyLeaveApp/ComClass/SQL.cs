using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp.ComClass
{
    internal class SQL
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=NOORY;Initial Catalog=GrinfindoToys;Integrated Security=True;Encrypt=False");


        protected void ExecuteLoadData(string selectSQLQuery, DataGridView gridView)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(selectSQLQuery, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            gridView.DataSource = dataTable;
        }

        protected DataTable GetDataTable(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        protected bool ExecuteSaveQuery(string GenerateedSQL)
        {
            bool MyRet = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(GenerateedSQL, conn);
                int AffectedRows = cmd.ExecuteNonQuery();
                if (AffectedRows > 0)
                {
                    MessageBox.Show("Data Inserted Successfully", "Data Insert Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MyRet = true;
                }
                else
                {
                    MessageBox.Show("Data Insert Unsuccessful", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return MyRet;
        }

        public DataTable ExecuteQuery(string Query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(Query, conn);
                Adapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }


        public bool ExecuteUpdateQuery(string GenerateedSQL)
        {
            bool MyRet = false;
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(GenerateedSQL, conn);
                int AffectedRows = cmd.ExecuteNonQuery();
                if (AffectedRows > 0)
                {
                    MessageBox.Show("Data Update Successfully", "Update Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MyRet = true;
                }
                else
                {
                    MessageBox.Show("Data Update Unsuccessful", "Update Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return MyRet;
        }



        public bool ExecuteEmpUpdateQuery(string GenerateedSQL)
        {
            bool MyRet = false;
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(GenerateedSQL, conn);
                int AffectedRows = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return MyRet;
        }


        public bool ExecuteDeleteQuery(string GenerateedSQL)
        {
            bool MyRet = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(GenerateedSQL, conn);
                int AffectedRows = cmd.ExecuteNonQuery();
                if (AffectedRows > 0)
                {
                    MessageBox.Show("Data Deleted Successfully", "Delete Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MyRet = true;
                }
                else
                {
                    MessageBox.Show("Data Delete Unsuccessful", "Delete Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return MyRet;
        }
    }
}
