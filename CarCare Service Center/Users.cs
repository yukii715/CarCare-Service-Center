using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CarCare_Service_Center;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        public static string GenerateUserID(string role)
        {
            string query_Customer = "SELECT COUNT(*) FROM Users WHERE Role = 'Customer'";
            string query_Receptionist = "SELECT COUNT(*) FROM Users WHERE Role = 'Receptionist'";
            string query_Mechanic = "SELECT COUNT(*) FROM Users WHERE Role = 'Mechanic'";
            string UserID = null;
            switch (role)
            {
                case "Customer":
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlCommand command = new SqlCommand(query_Customer, connection);
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        UserID = $"0{(count + 1):D7}"; // Zero-padded to 7 digits
                    }
                    break;
                case "Receptionist":
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlCommand command = new SqlCommand(query_Receptionist, connection);
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        UserID = $"2{(count + 1):D7}"; // Zero-padded to 7 digits
                    }
                    break;
                case "Mechanic":
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlCommand command = new SqlCommand(query_Mechanic, connection);
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        UserID = $"3{(count + 1):D7}"; // Zero-padded to 7 digits
                    }
                    break;
            }
            return UserID;
        }
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
        public static void Delete(string ID)
        {
            string query = "UPDATE Users SET IsDeleted = 1 WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                // Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@UserID", ID);
                connection.Open();
                // Execute the command without returning any results
                command.ExecuteNonQuery();
            }
        }
        public static void ChangeName(String UserID, string UserName)
        {
            string query = "UPDATE Users SET Username = @UserName WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@UserName", UserName);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void ChangePassword(string UserID, string Password)
        {
            string query = "UPDATE Users SET Password = @Password WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@Password", Password);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void ChangeEmail(string UserID, string Email)
        {
            string query = "UPDATE Users SET Email = @Email WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@Email", Email);
                connection.Open();
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
            public DateTime JoinDateTime { get; set; }
            public class Payroll
            {
                public string PayrollID { get; set; }
                public string UserID { get; set; }
                public string Username { get; set; }
                public string Role { get; set; }
                public int Amount { get; set; }
                public string Month { get; set; }
                public string Year { get; set; }
                public DateTime PaymentDate { get; set; }
                public string GeneratePayrollID()
                {
                    return Year + Month + UserID;
                }
                public void Add()
                {
                    string query = "INSERT INTO Payroll (PayrollID, UserID, Amount, Month, Year, PaymentDate) VALUES " +
                        "(@PayrollID, @UserID, @Amount, @Month, @Year, @PaymentDate)";
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);

                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@PayrollID", PayrollID);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@Month", Month);
                        command.Parameters.AddWithValue("@Year", Year);
                        command.Parameters.AddWithValue("@PaymentDate", PaymentDate);

                        connection.Open();

                        // Execute the command without returning any results
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
    public class RegisteredUser
    {
        public string RegisterID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public static string GenerateRegisterID()
        {
            string query = "SELECT COUNT(*) FROM RegisteredUsers";
            string registerID;

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                registerID = $"R{(count + 1):D7}"; // Zero-padded to 7 digits
            }
            return registerID;
        }
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
