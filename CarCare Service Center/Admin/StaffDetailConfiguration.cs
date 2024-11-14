
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

        public StaffDetailConfiguration(User u = null)
        {
            InitializeComponent();
            user = u;
        }

        private void StaffDetailConfiguration_Load(object sender, EventArgs e)
        {
            lblStaffID.Text = user.UserID;
            lblName.Text = user.Username;
            lblEmail.Text = user.Email;
            lblRole.Text = user.Role;
            txtSalary.Text = user.Salary.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
