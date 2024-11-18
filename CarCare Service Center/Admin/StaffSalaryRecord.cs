
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
using System.Globalization;
using Users;

namespace CarCare_Service_Center
{
    public partial class StaffSalaryRecord : Form
    {
        private User staff;
        private string month;
        private string year;
        private frmAdminMain frmAdmin;

        public StaffSalaryRecord(User u, string m, string y, frmAdminMain frmAdminMain)
        {
            InitializeComponent();
            staff = u;
            month = m;
            year = y;
            frmAdmin = frmAdminMain;
        }


        private void StaffSalaryRecord_Load(object sender, EventArgs e)
        {
            lblStaffID.Text = staff.UserID.ToString().Trim();
            lblName.Text = staff.Username.ToString().Trim();
            lblRole.Text = staff.Role.ToString().Trim();
            lblSalary.Text = staff.Salary.ToString().Trim();
            txtSalary.Text = staff.Salary.ToString().Trim();
            lblMonth.Text = month.ToString().Trim();
            lblYear.Text = year.ToString().Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string staffID = lblStaffID.Text.ToString().Trim();

            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                lblError.Visible = true;
                lblError.Text = "Please Enter a Salary Amount!";
            }
            else if (!int.TryParse(txtSalary.Text, out int Salary))
            {
                lblError.Visible = true;
                lblError.Text = "Please enter a valid amount for Salary!";
            }
            else
            {
                string format = "MMMM";
                DateTime m = DateTime.ParseExact(lblMonth.Text, format, CultureInfo.InvariantCulture);
                string month = m.ToString("MM");
                User.StaffSalary.Payroll payrollRecord = new User.StaffSalary.Payroll
                {
                    UserID = staffID,
                    Amount = Salary,
                    Month = month,
                    Year = lblYear.Text.Trim(),
                    PaymentDate = DateTime.Now,
                };
                payrollRecord.PayrollID = payrollRecord.GeneratePayrollID();
                payrollRecord.Add();

                MessageBox.Show("Successfully Add", "Staff Record Upated", MessageBoxButtons.OK);
                frmAdmin.tlpSalaryData.Controls.Clear();
                frmAdmin.tlpSalaryData.RowCount = 1;
                frmAdmin.LoadPayroll();
                frmAdmin.filter_datainTlpSalaryData();
                Close();
            }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
