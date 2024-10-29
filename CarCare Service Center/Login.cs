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
using Functions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarCare_Service_Center
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool IsUsernameOrEmailExisted(string username_or_email)
        {
            // Combined query to check both username and email
            string query = "SELECT COUNT(*) FROM Users WHERE (Username = @Identifier OR Email = @Identifier) AND IsDeleted = 0";

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identifier", username_or_email);

                connection.Open(); // Open the connection to the database
                int count = (int)command.ExecuteScalar(); // Return the result from the query

                return count == 1; // Returns true if a user or email exists
            }
        }

        private bool IsPasswordCorrect(string username_or_email, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE (Username = @Identifier OR Email = @Identifier) AND Password = @Password AND IsDeleted = 0";

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identifier", username_or_email);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open(); // Open the connection to the database
                int count = (int)command.ExecuteScalar(); // Return the result from the query

                return count == 1; // Returns true if the password is correct for the user or email
            }
        }

        private string GetRole(string username_or_email)
        {
            string role;
            string query = "SELECT Role FROM Users WHERE (Username = @Identifier OR Email = @Identifier) AND IsDeleted = 0";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identifier", username_or_email); 

                connection.Open(); // Open the connection to the database

                // Execute the query and retrieve the role
                object result = command.ExecuteScalar(); // Return the result from the query
                role = result.ToString(); // Convert the result to string 
            }
            return role;
        }
        private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validation.IsItBlank(txtUsername.Text) && Validation.IsItBlank(txtPassword.Text))
                MessageBox.Show("Please enter your username and password");
            else if (Validation.IsItBlank(txtUsername.Text))
                MessageBox.Show("Please enter your username");
            else if (Validation.IsItBlank(txtPassword.Text))
                MessageBox.Show("Please enter your password");
            else
                if (IsUsernameOrEmailExisted(txtUsername.Text))
                if (IsPasswordCorrect(txtUsername.Text, txtPassword.Text))
                {
                    switch (GetRole(txtUsername.Text))
                    {
                        case "Admin":
                            frmAdminMain frmAdminMain = new frmAdminMain();
                            Hide();
                            frmAdminMain.ShowDialog();
                            Close();
                            break;
                        case "Receptionist":

                            Close();
                            break;
                        case "Mechanic":
                            frmMechanicMain frmMechanicMain = new frmMechanicMain();
                            Hide();
                            frmMechanicMain.ShowDialog();
                            Close();
                            break;
                        case "Customer":
                            frmCustomerMain frmCustomerMain = new frmCustomerMain();
                            Close();
                            frmCustomerMain.ShowDialog();
                            Close();
                            break;
                    }
                }
                else
                    MessageBox.Show("Incorrect password, please try again");
            else
                MessageBox.Show("Username doesn't exist");
        }
    }
}
