using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    }
}
