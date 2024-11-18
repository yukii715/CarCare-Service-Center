using Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace CarCare_Service_Center
{
    public partial class frmChangeUserName: Form
    {
        private bool Invalid_NewUsername;
        private User user;
        public frmChangeUserName(User user)
        {
            InitializeComponent();
            this.user = user;
            string User_ID = user.UserID; 
            lblOldUsername.Text = user.Username; 
        }

        private void txtboxNewUserName_TextChanged(object sender, EventArgs e)
        {
            string newUsername = txtboxNewUserName.Text;

            if (string.IsNullOrEmpty(newUsername))
            {
                lblChangeUsernameValidation.ForeColor = SystemColors.ControlText;
                lblChangeUsernameValidation.Text = "*3-20 characters";
                Invalid_NewUsername = true;
            }
            else if (Validation.IsLengthInvalid(newUsername, 3, 20))
            {
                lblChangeUsernameValidation.ForeColor = Color.Red;
                lblChangeUsernameValidation.Text = "Invalid Username length!";
                Invalid_NewUsername = true;
            }
            else if (newUsername.Contains(" "))
            {
                lblChangeUsernameValidation.ForeColor = Color.Red;
                lblChangeUsernameValidation.Text = "Username cannot contain spaces.";
                Invalid_NewUsername = true;
            }
            else if (Validation.IsUsernameExists(newUsername))
            {
                lblChangeUsernameValidation.ForeColor = Color.Red;
                lblChangeUsernameValidation.Text = "Username already exists!";
                Invalid_NewUsername = true;
            }
            else
            {
                lblChangeUsernameValidation.ForeColor = Color.Green;
                lblChangeUsernameValidation.Text = "Valid Username!";
                Invalid_NewUsername = false;
            }
        }

        private void btnDone_Click_1(object sender, EventArgs e)
        {
            string newUsername = txtboxNewUserName.Text;

            if (Invalid_NewUsername)
            {
                MessageBox.Show("Please fix the errors before proceeding.");
                return;
            }

            try
            {
                User.ChangeName(user.UserID, newUsername); 
                MessageBox.Show("Username updated successfully!");

                lblOldUsername.Text = newUsername;

                txtboxNewUserName.Clear();
                lblChangeUsernameValidation.Text = "*3-20 characters";
                lblChangeUsernameValidation.ForeColor = SystemColors.ControlText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the username: {ex.Message}");
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

