
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
using Users;

namespace CarCare_Service_Center
{
    public partial class StaffDetailConfiguration : Form
    {
        private User user;
        private StaffDetails StaffDetails;

        public StaffDetailConfiguration(User u = null, StaffDetails sd = null)
        {
            InitializeComponent();
            user = u;
            StaffDetails = sd;
        }

        private void StaffDetailConfiguration_Load(object sender, EventArgs e)
        {
            lblStaffID.Text = user.UserID.Trim();
            lblName.Text = user.Username.Trim();
            lblEmail.Text = user.Email.Trim();
            lblRole.Text = user.Role.Trim();
            txtSalary.Text = user.Salary.ToString().Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            StaffDetails.Show();
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
                MessageBox.Show("Apply Successfully", "Staff Detail Upated", MessageBoxButtons.OK);
                Close();
                StaffDetails.Close();
                StaffDetails staffDetails = new StaffDetails(user);
                staffDetails.Show();
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
