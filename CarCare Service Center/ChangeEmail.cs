
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

    public partial class frmChangeEmail : Form
    {
        private User user;


        public frmChangeEmail(User user)
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
                MessageBox.Show("Please enter a new email address.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Basic email format validation using regex
            if (Validation.IsEmailInvalid(newEmail))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User.ChangeEmail(user.UserID, newEmail);
                MessageBox.Show("Email updated successfully!");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the email: {ex.Message}");
            }
        }
    }
}
