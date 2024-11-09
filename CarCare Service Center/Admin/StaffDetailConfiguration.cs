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

namespace CarCare_Service_Center
{
    public partial class StaffDetailConfiguration : Form
    {
        public StaffDetailConfiguration()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffDetails formStaffDetails = new StaffDetails();
            formStaffDetails.Show();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtSalary.Text == null)
            {
                lblError.Visible = true;
                lblError.Text = "Please Enter a Salary Amount!";
            }
            else if (decimal.TryParse(txtSalary.Text, out decimal Salary))
            {
                MessageBox.Show("Apply Successfully", "Staff Detail Upated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                StaffDetails formStaffDetails = new StaffDetails();
                formStaffDetails.Show();
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Please enter a valid amount for Salary!";
            }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}