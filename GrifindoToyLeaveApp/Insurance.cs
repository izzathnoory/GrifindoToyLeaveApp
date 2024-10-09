using GrifindoToyLeaveApp.AppClass;
using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp
{
    public partial class Insurance : Form
    {
        InsuranceClass insurance = new InsuranceClass();
        EmployeeClass employee = new EmployeeClass();
        public Insurance()
        {
            InitializeComponent();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            insurance.Save();
        }

        private void Insurance_Load(object sender, EventArgs e)
        {
            try
            {
                employee.LoadAsFk(EmployeeIdCmb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadDataFromDB();
            insurance._loadTable = InsuranceSqlDataView;

        }

        private void loadDataFromDB()
        {
            insurance.LoadData(InsuranceSqlDataView);
        }

        private void InsuranceSqlDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get row index from data gridview
            int RowIndeNumber = e.RowIndex;

            if (RowIndeNumber >= 0)
            {
                // get data and store in the  variable by using selected row index
                string empName = InsuranceSqlDataView.Rows[RowIndeNumber].Cells["Name"].Value.ToString();
                string insid = InsuranceSqlDataView.Rows[RowIndeNumber].Cells["InsId"].Value.ToString();
                string instype = InsuranceSqlDataView.Rows[RowIndeNumber].Cells["InsType"].Value.ToString();
                string insamount = InsuranceSqlDataView.Rows[RowIndeNumber].Cells["InsAmount"].Value.ToString();

                // to assign the selected data to controls
                EmployeeIdCmb.Text = empName;
                InsuranceIdTxt.Text = insid;
                InsuranceTypeTxt.Text = instype;
                InsuranceAmountTxt.Text = insamount;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            insurance.Update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            insurance.Delete();
        }

        private void EmployeeIdCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeIdCmb.SelectedValue != null)
                {
                    insurance.EmpId = (EmployeeIdCmb.SelectedValue.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsuranceIdTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(InsuranceIdTxt.Text) && int.TryParse(InsuranceIdTxt.Text, out int insId))
                {
                    insurance.ID = insId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsuranceTypeTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                insurance.InsType = InsuranceTypeTxt.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsuranceAmountTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(InsuranceAmountTxt.Text) && decimal.TryParse(InsuranceAmountTxt.Text, out decimal insAmount))
                {
                    insurance.InsAmount = new SqlMoney(insAmount);
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchBoxTxt_TextChanged_1(object sender, EventArgs e)
        {
            if (SearchBoxTxt.Text != "")
            {
                insurance.Search(SearchBoxTxt.Text);
            }
            else
            {
                loadDataFromDB();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            insurance.Clear(this);
        }
    }
}
