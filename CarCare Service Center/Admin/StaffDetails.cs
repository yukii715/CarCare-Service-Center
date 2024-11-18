


using Functions;
using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Users.User;

namespace CarCare_Service_Center
{
    public partial class StaffDetails : Form
    {
        private User user;
        private List<User.StaffSalary> staffSalaryList;
        private int Salary;
        private frmAdminMain frmAdmin;

        public StaffDetails(User u, frmAdminMain frmAdminMain)
        {
            InitializeComponent();
            user = u;
            frmAdmin = frmAdminMain;
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {
            lblStaffID.Text = user.UserID.Trim();
            lblName.Text = user.Username.Trim();
            lblEmail.Text = user.Email.Trim();
            lblRole.Text = user.Role.Trim();


            string query = "SELECT Salary From StaffSalary WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", user.UserID);

                connection.Open(); //Open the connection to database

                Salary = (int)command.ExecuteScalar(); // Return te result from query

            }

            user.Salary = Salary;
            lblSalary.Text = Salary.ToString().Trim();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            StaffDetailConfiguration formStallDetailConfiguration = new StaffDetailConfiguration(user, this, frmAdmin);
            formStallDetailConfiguration.Show();
            Hide();

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            StaffDeletion formStaffDeletion = new StaffDeletion(user, this, frmAdmin);
            formStaffDeletion.ShowDialog();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
