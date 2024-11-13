using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CarCare_Service_Center;

namespace Users
{
    public class User
    {
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }
        public static void Add(string ID, string username, string email, string password, string role)
        {

            // Define the SQL query to insert a new user
            string query = "INSERT INTO Users (UserID, Username, Email, Password, Role, IsDeleted) VALUES (@UserID, @Username, @Email, @Password, @Role, 0)";

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@UserID", ID);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);

                connection.Open();

                // Execute the command
                command.ExecuteNonQuery();
            }
        }
        public void GetUserInfo(string userid)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();
                string query = "SELECT Username, Email, Password, Role FROM Users WHERE UserID = @userid AND IsDeleted = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userid", userid);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Username = reader["Username"].ToString();
                            Email = reader["Email"].ToString();
                            Password = reader["Password"].ToString();
                            Role = reader["Role"].ToString();
                        }
                    }
                }
            }
        }
        public class StaffSalary
        {
            public string UserID { get; set; }
            public int Salary { get; set; }
        }
    }
    public class RegisteredUser
    {
        public string RegisterID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public static void Add(string ID, string username, string email, string password)
        {
            string query = "INSERT INTO RegisteredUsers (RegisterID, Username, Email, Password) VALUES (@RegisterID, @Username, @Email, @Password)";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@RegisterID", ID);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();

                // Execute the command without returning any results
                command.ExecuteNonQuery();
            }
        }
        public static void ChangeStatus(string RegisterID, int status)
        {
            string query = "UPDATE RegisteredUsers SET IsRegistered = @Status WHERE RegisterID = @RegisterID";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RegisterID", RegisterID);
                command.Parameters.AddWithValue("@Status", status);

                connection.Open();

                command.ExecuteNonQuery ();
            }
        }
    }
}
