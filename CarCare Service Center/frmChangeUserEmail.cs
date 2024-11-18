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

    public partial class frmChangeUserEmail : Form
    {
        private User user;

        
        public frmChangeUserEmail(User user)
        {
            InitializeComponent();
            this.user = user;
            lblEmail.Text = user.Email;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string newEmail = txtboxNewEmail.Text;

            if (string.IsNullOrEmpty(newEmail))
            {
                MessageBox.Show("Please enter a new email address.");
                return;
            }

            // Basic email format validation using regex
            if (!Validation.IsEmailInvalid(newEmail))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Check if the new email already exists in the system
            if (Validation.IsEmailInvalid(newEmail))
            {
                MessageBox.Show("This email address is already in use.");
                return;
            }

            try
            {
                User.ChangeEmail(user.UserID, newEmail);
                MessageBox.Show("Email updated successfully!");

                lblShowUserEmail.Text = newEmail;

                txtboxNewEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the email: {ex.Message}");
            }
        }

        private void frmChangeUserEmail_Load(object sender, EventArgs e)
        {

        }
    }
}
