
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
    public partial class frmChangePassword : Form
    {
        private User user_;
        private bool Invalid_Password = false;
        public frmChangePassword(User user)
        {
            InitializeComponent();
            this.user_ = user;
        }


        private void txtboxNewPassword_TextChanged(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtboxNewPassword.Text))
            {
                lblPwValidation.ForeColor = SystemColors.ControlText;
                lblPwValidation.Text = "*8-20 characters, must contain at least one uppercase letter, one lowercase letter, one number, one symbol";
                Invalid_Password = true;
            }
            else if (txtboxNewPassword.Text.Contains(" "))
            {
                lblPwValidation.ForeColor = Color.Red;
                lblPwValidation.Text = "Password cannot contain spaces.";
                Invalid_Password = true;
            }
            else if (Validation.IsPasswordValid(txtboxNewPassword.Text))
            {
                lblPwValidation.ForeColor = Color.Green;
                lblPwValidation.Text = "Valid Password.";
                Invalid_Password = false;
            }
            else
            {
                lblPwValidation.ForeColor = Color.Red;
                lblPwValidation.Text = "Invalid password.";
                Invalid_Password = true;
            }
        }
        private void txtConfirmPw_TextChanged(object sender, EventArgs e)
        {
            string confirmPassword = txtboxComfirmNewPassword.Text;

            if (string.IsNullOrEmpty(confirmPassword))
            {
                lblConfirmPwValidation.ForeColor = SystemColors.ControlText;
                lblConfirmPwValidation.Text = "";
            }
            else if (confirmPassword == txtboxNewPassword.Text)
            {
                lblConfirmPwValidation.ForeColor = Color.Green;
                lblConfirmPwValidation.Text = "Passwords match.";
            }
            else
            {
                lblConfirmPwValidation.ForeColor = Color.Red;
                lblConfirmPwValidation.Text = "Passwords do not match.";
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            {
                if (Invalid_Password || txtboxNewPassword.Text != txtboxComfirmNewPassword.Text)
                {
                    MessageBox.Show("Please fix the errors before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string newPassword = txtboxNewPassword.Text;

                try
                {
                    Users.User.ChangePassword(user_.UserID, newPassword);
                    MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
