using CarCare_Service_Center;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Users
{
    public class Admin : User
    {
        public Admin(User user)
        {
            UserID = user.UserID;
            Username = user.Username;
            Email = user.Email;
            Password = user.Password;
            Role = user.Role;
        }
        public void assign_staff_salary(string userid, int salary)
        {
            string query = "INSERT INTO StaffSalary (UserID, Salary) VALUES (@UserID, @Salary)";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@UserID", userid);
                command.Parameters.AddWithValue("@Salary", salary);

                connection.Open();

                // Execute the command without returning any results
                command.ExecuteNonQuery();
            }
        }
    }
}
