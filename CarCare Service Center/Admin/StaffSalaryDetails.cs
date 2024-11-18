
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Users;

namespace CarCare_Service_Center
{
    public partial class StaffSalaryDetails : Form
    {
        private User.StaffSalary.Payroll payroll;
        public StaffSalaryDetails(User.StaffSalary.Payroll pr = null)
        {
            InitializeComponent();
            payroll = pr;
        }

        private void StaffSalaryDetails_Load(object sender, EventArgs e)
        {
            lblPayrollID.Text = payroll.PayrollID.ToString().Trim();
            lblStaffID.Text = payroll.UserID.ToString().Trim();
            lblName.Text = payroll.Username.ToString().Trim();
            lblRole.Text = payroll.Role.ToString().Trim();
            lblSalary.Text = payroll.Amount.ToString("C2").Trim();
            lblMonth.Text = DateTime.ParseExact(payroll.Month, "MM", CultureInfo.InvariantCulture).ToString("MMMM");
            lblYear.Text = payroll.Year.ToString().Trim();
            lblPaymentDate.Text = payroll.PaymentDate.ToString("yyyy-MM-dd");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
