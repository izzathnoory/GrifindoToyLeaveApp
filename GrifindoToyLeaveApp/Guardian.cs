using GrifindoToyLeaveApp.AppClass;
using GrifindoToyLeaveApp.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp
{
    public partial class Guardian : Form
    {
        GuardianClass guardian = new GuardianClass();
        EmployeeClass employee = new EmployeeClass();
        public Guardian()
        {
            InitializeComponent();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            guardian.Save();
        }

        private void Guardian_Load(object sender, EventArgs e)
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

            guardian._loadTable = GuardianSqlDataView;
        }

        private void loadDataFromDB()
        {
            guardian.loadData(GuardianSqlDataView);
        }

        private void GuardianSqlDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get row index from data gridview
            int RowIndeNumber = e.RowIndex;

            if (RowIndeNumber >= 0)
            {
                // get data and store in the  variable by using selected row index
                string empName = GuardianSqlDataView.Rows[RowIndeNumber].Cells["Name"].Value.ToString();
                string guardianId = GuardianSqlDataView.Rows[RowIndeNumber].Cells["GuardianId"].Value.ToString();
                string guardianname = GuardianSqlDataView.Rows[RowIndeNumber].Cells["GuarName"].Value.ToString();
                string email = GuardianSqlDataView.Rows[RowIndeNumber].Cells["Email"].Value.ToString();
                string nic = GuardianSqlDataView.Rows[RowIndeNumber].Cells["NIC"].Value.ToString();
                string address = GuardianSqlDataView.Rows[RowIndeNumber].Cells["Address"].Value.ToString();
                string relationoftheemployee = GuardianSqlDataView.Rows[RowIndeNumber].Cells["RelationOfTheEmployee"].Value.ToString();

                // to assign the selected data to controls
                EmployeeIdCmb.Text = empName;
                GuardianIdTxt.Text = guardianId;
                GuardianNameTxt.Text = guardianname;
                GuardianEmailTxt.Text = email;
                GuardNicTxt.Text = nic;
                GuardAddTxt.Text = address;
                GuardRelEmpTxt.Text = relationoftheemployee;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            guardian.Update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            guardian.Delete();
        }

        private void EmployeeIdCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeIdCmb.SelectedValue != null)
                {
                    guardian.EmpId = (EmployeeIdCmb.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuardianIdTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(GuardianIdTxt.Text) && int.TryParse(GuardianIdTxt.Text, out int guardianId))
                {
                    guardian.ID = guardianId;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GuardianNameTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(GuardianNameTxt.Text))
                {
                    guardian.Name = GuardianNameTxt.Text;
                }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void GuardianEmailTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(GuardianEmailTxt.Text))
                {
                    guardian.Email = GuardianEmailTxt.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuardNicTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(GuardNicTxt.Text))
                {
                    guardian.Nic = GuardNicTxt.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuardAddTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                guardian.Address = GuardAddTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuardRelEmpTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                guardian.Relation = GuardRelEmpTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchBoxTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchBoxTxt.Text != "")
            {
                guardian.Search(SearchBoxTxt.Text);
            }
            else
            {
                loadDataFromDB();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            guardian.Clear(this);
        }
    }
}
