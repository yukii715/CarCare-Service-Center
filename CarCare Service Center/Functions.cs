using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections;
using CarCare_Service_Center;

namespace Functions
{
    public static class Validation
    {
        public static bool IsItBlank(string value)
        {
            return string.IsNullOrWhiteSpace(value); // Check if it is null, empty or contains only white space
        }
        public static bool IsLengthInvalid(string value, int min, int max)
        {
            if (value.Length > max || value.Length < min)
                return true;
            else
                return false;
        }
        public static bool IsEmailInvalid(string email)
        {
            if (IsItBlank(email))
                return true;
            else if (email.Length > 50)
                return true;
            try
            {
                var mailAddress = new MailAddress(email);
                return false; // Valid email format
            }
            catch (FormatException)
            {
                return true; // Invalid email format
            }
        }
        public static bool IsUsernameExists(string username)
        {
            bool exists = false;

            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND IsDeleted = 0"; // Count the row if username is existed

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open(); //Open the connection to database

                int count = (int)command.ExecuteScalar(); // Return te result from query
                exists = (count > 0); //If count > 0 exists is true else is false
            }

            return exists;
        }
        public static bool IsPasswordValid(string password)
        {
            // Regular expression for validating password
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,20}$";
            //Should include at least one uppercase and lowercase alphabet, number and symbol, and need 8-20 characters
            return Regex.IsMatch(password, pattern);
        }
    }
    public static class ID_Generator
    {

        public static string RegisterID()
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
        public static string UserID(string role)
        {
            string query_Customer = "SELECT COUNT(*) FROM Users WHERE Role = 'Customer'";
            string query_Receptionist= "SELECT COUNT(*) FROM Users WHERE Role = 'Receptionist'";
            string query_Mechanic= "SELECT COUNT(*) FROM Users WHERE Role = 'Mechanic'";
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

    }
    public static class General_Operation
    {
        public static void AddUser(string ID, string username, string email, string password, string role = null, string salary = null)
        {

            // Define the SQL query to insert a new user
            string query1 = "INSERT INTO RegisteredUsers (RegisterID, Username, Email, Password) VALUES (@RegisterID, @Username, @Email, @Password)";
            string query2 = "INSERT INTO Users (UserID, Username, Email, Password, Role, IsDeleted, Salary) VALUES (@UserID, @Username, @Email, @Password, @Role, 0, @Salary)";

            if (role == null)
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query1, connection);

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
            else
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query2, connection);

                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@UserID", ID);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@Salary",salary);

                    connection.Open();

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
