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
    public partial class Guardian_mobile : Form
    {
        GuardianMobileClass guardianMobile = new GuardianMobileClass();
        EmployeeClass employee = new EmployeeClass();
        GuardianClass guardian = new GuardianClass();
        public Guardian_mobile()
        {
            InitializeComponent();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            guardianMobile.Save();
        }

        private void Guardian_mobile_Load(object sender, EventArgs e)
        {
            try
            {
                employee.LoadAsFk(EmployeeIdCmb);

                guardian.loadAsFkGuardian(GuardianIdCmb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            loadDataFromDB();
            guardianMobile._loadTable = EmpGuarMobSqlDataView;
        }

        private void loadDataFromDB()
        {
            guardianMobile.LoadData(EmpGuarMobSqlDataView);
        }

        private void EmpGuarMobSqlDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get row index from data gridview
            int RowIndeNumber = e.RowIndex;

            if (RowIndeNumber >= 0)
            {
                // get data and store in the  variable by using selected row index
                string empName = EmpGuarMobSqlDataView.Rows[RowIndeNumber].Cells["EmpName"].Value.ToString();
                string guardianname = EmpGuarMobSqlDataView.Rows[RowIndeNumber].Cells["GuarName"].Value.ToString();
                string guardianmobid = EmpGuarMobSqlDataView.Rows[RowIndeNumber].Cells["GuarMobId"].Value.ToString();
                string mobilenumber = EmpGuarMobSqlDataView.Rows[RowIndeNumber].Cells["GuarMobNum"].Value.ToString();

                // to assign the selected data to controls
                EmployeeIdCmb.Text = empName;
                GuardianIdCmb.Text = guardianname;
                GuardianMobileIdTxt.Text = guardianmobid;
                MobileNumTxt.Text = mobilenumber;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            guardianMobile.Update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            guardianMobile.Delete();
        }

        private void EmployeeIdCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeIdCmb.SelectedValue != null)
                {
                    guardianMobile.EmpId = (EmployeeIdCmb.SelectedValue.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuardianIdCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (GuardianIdCmb.SelectedValue != null)
                {
                    guardianMobile.GuarId = (GuardianIdCmb.SelectedValue.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuardianMobileId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(GuardianMobileIdTxt.Text) && int.TryParse(GuardianMobileIdTxt.Text, out int guardianMobileId))
                {
                    guardianMobile.ID = guardianMobileId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MobileNumTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                guardianMobile.MobileNumber = MobileNumTxt.Text;
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
                guardianMobile.Search(SearchBoxTxt.Text);
            }
            else
            {
                loadDataFromDB();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            guardianMobile.Clear(this);
        }
    }
}
