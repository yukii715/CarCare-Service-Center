using Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace CarCare_Service_Center
{
    public partial class frmRegister : Form
    {
        public bool Invalid_Username = true;
        public bool Invalid_Password = true;
        public frmRegister()
        {
            InitializeComponent();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Invalid_Username)
                MessageBox.Show("Invalid Username, please enter a username within minimum 3 characters and maximum 20 characters.");
            else if (Validation.IsEmailInvalid(txtEmail.Text))
                MessageBox.Show("Invalid Email");
            else if (Invalid_Password)
                MessageBox.Show("Invalid Password, please enter a password within minimum 8 characters and maximum 20 characters.");
            else if (txtPassword.Text != txtConfirmPw.Text)
                MessageBox.Show("The confirmation password does not match. Please try again.");
            else
            {
                string registerID = RegisteredUser.GenerateRegisterID();
                RegisteredUser.Add(registerID, txtUsername.Text, txtEmail.Text, txtPassword.Text);
                MessageBox.Show("Register Successfully!");
                txtUsername.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                txtConfirmPw.Clear();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lblUsernameValidation.ForeColor = SystemColors.ControlText;
                lblUsernameValidation.Text = "*3-20 characters";
                Invalid_Username = true;
            }
            else if (Validation.IsLengthInvalid(txtUsername.Text, 3, 20))
            {
                lblUsernameValidation.ForeColor = Color.Red;
                lblUsernameValidation.Text = "Invalid UserName";
                Invalid_Username = true;
            }
            else if (txtUsername.Text.Contains(" "))
            {
                lblUsernameValidation.ForeColor = Color.Red;
                lblUsernameValidation.Text = "Username cannot contain spaces";
                Invalid_Username = true;
            }
            else if (Validation.IsUsernameExists(txtUsername.Text))
            {
                lblUsernameValidation.ForeColor = Color.Red;
                lblUsernameValidation.Text = "Username already existed";
                Invalid_Username = true;
            }
            else
            {
                lblUsernameValidation.ForeColor = Color.Green;
                lblUsernameValidation.Text = "Valid Username";
                Invalid_Username = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblPwValidation.ForeColor = SystemColors.ControlText;
                lblPwValidation.Text = "*8-20 characters,  must contain at least one uppercase letter, one lowercase letter, one number, one symbol";
                Invalid_Password = true;
            }
            else if (txtPassword.Text.Contains(" "))
            {
                lblPwValidation.ForeColor = Color.Red;
                lblPwValidation.Text = "Password cannot contain spaces";
                Invalid_Password = true;
            }
            else if (Validation.IsPasswordValid(txtPassword.Text))
            {
                lblPwValidation.ForeColor = Color.Green;
                lblPwValidation.Text = "Valid Password";
                Invalid_Password = false;
            }
            else
            {
                lblPwValidation.ForeColor = Color.Red;
                lblPwValidation.Text = "Invalid password";
                Invalid_Password = true;
            }
        }

        private void txtConfirmPw_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPw.Text))
            {
                lblConfirmPwValidation.ForeColor = SystemColors.ControlText;
                lblConfirmPwValidation.Text = "";
            }
            else if (txtConfirmPw.Text == txtPassword.Text)
            {
                lblConfirmPwValidation.ForeColor = Color.Green;
                lblConfirmPwValidation.Text = "Password match";
            }
            else
            {
                lblConfirmPwValidation.ForeColor = Color.Red;
                lblConfirmPwValidation.Text = "Password doesn't match";
            }
        }
    }
}
