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
using Users;
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
        private string GetID(string username_or_email)
        {
            string UserID;
            string query = "SELECT UserID FROM Users WHERE (Username = @Identifier OR Email = @Identifier) AND IsDeleted = 0";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identifier", username_or_email);

                connection.Open(); // Open the connection to the database

                // Execute the query and retrieve the role
                object result = command.ExecuteScalar(); // Return the result from the query
                UserID = result.ToString(); // Convert the result to string 
            }
            return UserID;
        }
        private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("Please enter your username and password","Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (string.IsNullOrEmpty(txtUsername.Text))
                MessageBox.Show("Please enter your username", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (string.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("Please enter your password", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                if (IsUsernameOrEmailExisted(txtUsername.Text))
                if (IsPasswordCorrect(txtUsername.Text, txtPassword.Text))
                {
                    User user = new User()
                    {
                        UserID = GetID(txtUsername.Text)
                    };
                    user.GetUserInfo(user.UserID);
                    switch (user.Role)
                    { 
                        case "Admin":
                            Admin admin = new Admin(user);
                            frmAdminMain frmAdminMain = new frmAdminMain(admin);
                            Hide();
                            frmAdminMain.ShowDialog();
                            Close();
                            break;
                        case "Receptionist":
                            Receptionist receptionist = new Receptionist(user);
                            frmReceptionistMain frmReceptionistMain = new frmReceptionistMain(receptionist);
                            Hide();
                            frmReceptionistMain.ShowDialog();
                            Close();
                            break;
                        case "Mechanic":
                            Mechanic mechanic = new Mechanic(user);
                            frmMechanicMain frmMechanicMain = new frmMechanicMain(mechanic);
                            Hide();
                            frmMechanicMain.ShowDialog();
                            Close();
                            break;
                        case "Customer":
                            Customer customer = new Customer(user);
                            frmCustomerMain frmCustomerMain = new frmCustomerMain(customer);
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
