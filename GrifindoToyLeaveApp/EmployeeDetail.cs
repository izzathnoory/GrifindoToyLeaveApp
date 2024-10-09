using GrifindoToyLeaveApp.AppClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyLeaveApp
{
    public partial class EmployeeDetail : Form
    {
        EmpDetailUpdateClass employee = new EmpDetailUpdateClass();
        EmployeeDetailStoreClass employeeDetail = new EmployeeDetailStoreClass();
        public EmployeeDetail()
        {
            InitializeComponent();
        }

        private void EmployeeDetail_Load(object sender, EventArgs e)
        {
            EmployeeDetailsRetrive();
            Disable();
            GuardianMobRetrive();
            EmpMobileRetrive();
            GuardianDetailretrive();
        }

        private void EmployeeDetailsRetrive()
        {
            try
            {
                DataTable dt = employeeDetail.GetUserInformation();
                EmpIdTxt.Text = dt.Rows[0]["Emp_num"].ToString();
                EmpPasswordTxt.Text = dt.Rows[0]["password"].ToString();
                EmpNameTxt.Text = dt.Rows[0]["Emp_name"].ToString();
                EmpEmailTxt.Text = dt.Rows[0]["emp_email"].ToString();
                EmpAddTxt.Text = dt.Rows[0]["emp_addre"].ToString();
                EmpExperTxt.Text = dt.Rows[0]["emp_exp"].ToString();
                EmpNicTxt.Text = dt.Rows[0]["emp_nic"].ToString();
                EmpPassTxt.Text = dt.Rows[0]["emp_pass_no"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuardianMobRetrive()
        {
            try
            {
                DataTable dt = employeeDetail.GetGuardianMobile();
                EmpGuarMobTxt.Text = dt.Rows[0]["emp_guar_mob_num"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpMobileRetrive()
        {
            try
            {
                DataTable dt = employeeDetail.GetEmployeeMobile();
                EmpMobTxt.Text = dt.Rows[0]["emp_mob_num"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuardianDetailretrive()
        {
            try
            {
                DataTable dt = employeeDetail.GetGuardian();
                EmpGuarNameTxt.Text = dt.Rows[0]["emp_guar_name"].ToString();
                EmpGuarEmailTxt.Text = dt.Rows[0]["emp_guar_email"].ToString();
                EmpGuarNICTxt.Text = dt.Rows[0]["emp_guar_nic"].ToString();
                EmpGuarAddresTxt.Text = dt.Rows[0]["emp_guar_addre"].ToString();
                EmpGuarRelation.Text = dt.Rows[0]["emp_guar_relation"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Disable()
        {
            EmpIdTxt.Enabled = false;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            employee.updateFromEmployee();
        }

        private void EmpIdTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.id = int.Parse(EmpIdTxt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.password = EmpPasswordTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpNameTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.name = EmpNameTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpEmailTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.email = EmpEmailTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpAddTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.address = EmpAddTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpExperTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.experiance = float.Parse(EmpExperTxt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpNicTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.nic = EmpNicTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpPassTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.passportNumber = EmpPassTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpMobTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.EmpMobile = EmpMobTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpGuarMobTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.EmpGuarMobile = EmpGuarMobTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpGuarNameTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.EmpGuarName = EmpGuarNameTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpGuarEmailTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.EmpGuarEmail = EmpGuarEmailTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpGuarNICTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.EmpGuarNIC = EmpGuarNICTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpGuarAddresTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.EmpGuarAddress = EmpGuarAddresTxt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpGuarRelation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employee.EmpGuarRelation = EmpGuarRelation.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
