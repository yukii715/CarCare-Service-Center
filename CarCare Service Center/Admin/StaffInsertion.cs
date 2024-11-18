
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions;
using Users;

namespace CarCare_Service_Center
{
    public partial class StaffInsertion : Form
    {
        private Admin admin;
        private frmAdminMain frmAdmin;
        public StaffInsertion(Admin ad, frmAdminMain frmAdminMain)
        {
            InitializeComponent();
            admin = ad;
            frmAdmin = frmAdminMain;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyMMdd");
            string username = txtStaffName.Text;
            string password = username + date;
            string email = txtStaffEmail.Text;
            string role = cmbRoleSelection.Text;
            string userid = User.GenerateUserID(role);
            if (Validation.IsUsernameInvalid(username))
                MessageBox.Show("Invalid Username");
            else if (Validation.IsUsernameExists(txtStaffName.Text))
                MessageBox.Show("Username existed, please try another username");
            else if (Validation.IsEmailInvalid(txtStaffEmail.Text))
                MessageBox.Show("Invalid Email");
            else if (!int.TryParse(txtSalary.Text, out int salary))
                MessageBox.Show("Invalid Salary");
            else
            {
                User.Add(userid, username, email, password, role);
                Admin.assign_staff_salary(userid, salary, DateTime.Now);
                MessageBox.Show($"Staff added, Password is {password}");
                frmAdmin.tlpStaffAccountData.Controls.Clear();
                frmAdmin.tlpStaffAccountData.RowCount = 1;
                frmAdmin.cmbRoleSelection.SelectedIndex = -1;
                frmAdmin.txtStaffSearch.Text = "Search";
                frmAdmin.LoadUser();
                Close();
                frmAdmin.Show();
            }
        }
    }
}
