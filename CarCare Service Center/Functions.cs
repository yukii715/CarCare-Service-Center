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
using System.Reflection;

namespace Functions
{
    public static class Validation
    {
        public static bool IsLengthInvalid(string value, int min, int max)
        {
            if (value.Length > max || value.Length < min)
                return true;
            else
                return false;
        }
        public static bool IsUsernameInvalid(string username)
        {
            if (string.IsNullOrEmpty(username) || IsLengthInvalid(username, 3, 20) || username.Contains(" "))
                return true;
            else 
                return false;
        }
        public static bool IsEmailInvalid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
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
    
    public static class Database
    {
        public static List<T> FetchData<T>(string query) where T : new()
        {
            List<T> resultList = new List<T>();

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Create an instance of the generic type T
                        T instance = new T();

                        // Populate the properties of T from the reader
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            // Get column name 
                            string columnName = reader.GetName(i); 
                            // Get value of each coloum in variable property
                            PropertyInfo property = typeof(T).GetProperty(columnName);

                            /* If the column name not found in the class property or the value in database is zero,
                               ignore them */
                            if (property != null && reader[columnName] != DBNull.Value)
                            {
                                // Set the property value
                                property.SetValue(instance, reader[columnName]);
                            }
                        }

                        resultList.Add(instance);
                    }
                }
            }

            return resultList;
        }
    }
}
