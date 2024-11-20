using CarCare_Service_Center;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class Mechanic : User
    {
        public Mechanic(User user)
        {
            UserID = user.UserID;
            Username = user.Username;
            Email = user.Email;
            Password = user.Password;
            Role = user.Role;
        }
        public class MechanicTasks
        {
            public string UserID { get; set; }
            public string AppointmentID { get; set; }
            public string CustomerName { get; set; }
            public DateTime DateTime {  get; set; }
            public void ADD()
            {
                string query = "INSERT INTO MechanicTasks (UserID,AppointmentID) VALUES " +
                "(@UserID, @AppointmentID)";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    connection.Open();

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
