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

namespace CarCare_Service_Center
{
    public partial class StaffInsertion : Form
    {
        public StaffInsertion()
        {
            InitializeComponent();
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
            string userid = ID_Generator.UserID(role);
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
                General_Operation.AddUser(userid,username,email,password,role,salary);
                MessageBox.Show($"Staff added, Password is {password}");
            }
        }
    }
}
