

using Functions;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarCare_Service_Center
{
    public partial class StaffDetailConfiguration : Form
    {
        private User user;
        private StaffDetails StaffDetails;
        private frmAdminMain frmAdmin;

        public StaffDetailConfiguration(User u, StaffDetails sd, frmAdminMain frmAdminMain)
        {
            InitializeComponent();
            user = u;
            StaffDetails = sd;
            frmAdmin = frmAdminMain;
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
            string staffID = user.UserID.ToString().Trim();

            if (txtSalary.Text == null)
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
                Admin.edit_staff_salary(staffID, Salary);

                MessageBox.Show("Apply Successfully", "Staff Detail Upated", MessageBoxButtons.OK);

                frmAdmin.tlpStaffAccountData.Controls.Clear();
                frmAdmin.tlpStaffAccountData.RowCount = 1;
                frmAdmin.cmbRoleSelection.SelectedIndex = -1;
                frmAdmin.txtStaffSearch.Text = "Search";
                frmAdmin.LoadUser();
                Close();
                StaffDetails.Close();
                StaffDetails staffDetails = new StaffDetails(user, frmAdmin);
                staffDetails.Show();
            }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
