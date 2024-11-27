using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static CarCare_Service_Center.Appointment;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO.Ports;
using Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace CarCare_Service_Center
{
    public class Services
    {
        public string ServiceID { get; set; }
        public string ServiceType { get; set; }
        public string ServiceName { get; set; }
        public string EstimatedTime { get; set; }
        public string Description { get; set; }
        public string Briefing {  get; set; }
        public byte[] ImageData {  get; set; }
        public static bool IsServiceTypePrefixValid(string serviceTypePrefix)
        {
            string pattern = @"^[A-Z]{3}$";
            return Regex.IsMatch(serviceTypePrefix, pattern);
        }
        public static string GenerateServiceID(string serviceType, string newPrefix)
        {
            string ServiceID;
            string query = "SELECT TOP 1 ServiceID FROM Services WHERE ServiceType = @ServiceType ORDER BY ServiceID DESC";

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ServiceType", serviceType);
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    // Existing service type found
                    string lastServiceID = result.ToString();
                    string existingPrefix = new string(lastServiceID.TakeWhile(char.IsLetter).ToArray());
                    int lastNumber = int.Parse(new string(lastServiceID.SkipWhile(char.IsLetter).ToArray()));

                    ServiceID = existingPrefix + (lastNumber + 1).ToString("D3");
                }
                else
                {
                    // New service type, use provided newPrefix and start with 001
                    ServiceID = newPrefix + "001";
                }
            }
            return ServiceID;
        }

        public void Add()
        {
            string query = "INSERT INTO Services (ServiceID, ServiceType, ServiceName, EstimatedTime, Description, Briefing, ImageData, IsDeleted) " +
                           "VALUES (@ServiceID, @ServiceType, @ServiceName, @EstimatedTime, @Description, @Briefing, @ImageData, 0)";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@ServiceID", ServiceID);
                command.Parameters.AddWithValue("@ServiceType", ServiceType);
                command.Parameters.AddWithValue("@ServiceName", ServiceName);
                command.Parameters.AddWithValue("@EstimatedTime", EstimatedTime);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@Briefing", Briefing);
                command.Parameters.Add("@ImageData", SqlDbType.VarBinary).Value = ImageData;

                connection.Open();

                // Execute the command
                command.ExecuteNonQuery();
            }
        }
        public void Edit()
        {
            string query = "UPDATE Services SET EstimatedTime = @EstimatedTime, Description = @Description, Briefing = @Briefing, ImageData = @ImageData WHERE ServiceID = @ServiceID; ";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                // Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@ServiceID", ServiceID);
                command.Parameters.AddWithValue("@EstimatedTime", EstimatedTime);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@Briefing", Briefing);
                command.Parameters.Add("@ImageData", SqlDbType.VarBinary).Value = ImageData;
                connection.Open();
                // Execute the command
                command.ExecuteNonQuery();
            }
        }
        public void EditWithoutNewImage()
        {
            string query = "UPDATE Services SET EstimatedTime = @EstimatedTime, Description = @Description, Briefing = @Briefing WHERE ServiceID = @ServiceID; ";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                // Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@ServiceID", ServiceID);
                command.Parameters.AddWithValue("@EstimatedTime", EstimatedTime);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@Briefing", Briefing);
                connection.Open();
                // Execute the command
                command.ExecuteNonQuery();
            }
        }
        public static void Delete(string serviceID)
        {
            string query = "UPDATE Services SET IsDeleted = 1 WHERE ServiceID = @ServiceID";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                // Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@ServiceID", serviceID);
                connection.Open();
                // Execute the command without returning any results
                command.ExecuteNonQuery();
            }
        }
        public class ServicePrice
        {
            public string ServiceID { get; set; }
            public Decimal Price { get; set; }
            public string Description { get; set; }
            public void Add()
            {
                string query = "INSERT INTO ServicePrice (ServiceID, Price, Description) VALUES (@ServiceID, @Price, @Description)";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlParameter price = new SqlParameter("@Price", SqlDbType.Decimal)
                    {
                        Precision = 10,  // Total number of digits
                        Scale = 2,       // Number of decimal places
                        Value = Price
                    };

                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@ServiceID", ServiceID);
                    command.Parameters.Add(price);
                    command.Parameters.AddWithValue("@Description", Description);

                    connection.Open();

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
            public void Delete()
            {
                string query = "DELETE FROM ServicePrice WHERE ServiceID = @ServiceID;";

                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@ServiceID", ServiceID);

                    connection.Open();

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }
            public class ServiceOrder
        {
            public string ServiceOrderID { get; set; }
            public string Username { get; set; }
            public string AppointmentID { get; set; }
            public DateTime ArrivalDateTime { get; set; }
            public DateTime? StartDateTime {  get; set; }
            public DateTime? EndDateTime { get; set; }
            public DateTime CollectionDateTime { get; set; }
            public string Remark { get; set; }
            public Decimal TotalPrice { get; set; }
            public string Feedback { get; set; }
            public int Rating { get; set; }
            public string GenerateServiceOrderID()
            {
                string query = "SELECT COUNT(*) FROM ServiceOrder";
                string ServiceOrderID;
                string DateTime = ArrivalDateTime.ToString("HHmmssddMMyy");

                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    ServiceOrderID = string.Concat(DateTime.Reverse()) + (count + 1).ToString("D8"); // Zero-padded to 7 digits
                }
                return ServiceOrderID;
            }
            public void Add()
            {
                string query = "INSERT INTO ServiceOrder (ServiceOrderID, AppointmentID, ArrivalDateTime) VALUES (@ServiceOrderID, @AppointmentID, @ArrivalDateTime)";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@ServiceOrderID", ServiceOrderID);
                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    command.Parameters.AddWithValue("@ArrivalDateTime", ArrivalDateTime);

                    connection.Open();

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
            public void Start()
            {
                string query = "UPDATE ServiceOrder SET StartDateTime = @StartDateTime WHERE ServiceOrderID = @ServiceOrderID";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StartDateTime", StartDateTime);
                    command.Parameters.AddWithValue("@ServiceOrderID", ServiceOrderID);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            public void End()
            {
                string query = "UPDATE ServiceOrder SET EndDateTime = @EndDateTime, Remark = @Remark WHERE ServiceOrderID = @ServiceOrderID";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EndDateTime", EndDateTime);
                    command.Parameters.AddWithValue("@Remark", Remark);
                    command.Parameters.AddWithValue("@ServiceOrderID", ServiceOrderID);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            public void CheackOut()
            {
                string query = "UPDATE ServiceOrder SET CollectionDateTime = @CollectionDateTime, TotalPrice = @TotalPrice WHERE ServiceOrderID = @ServiceOrderID";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CollectionDateTime", CollectionDateTime);
                    command.Parameters.AddWithValue("@TotalPrice", TotalPrice);
                    command.Parameters.AddWithValue("@ServiceOrderID", ServiceOrderID);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }

            public void Rate()
            {
                string query = "UPDATE ServiceOrder SET Rating = @Rating, Feedback = @Feedback WHERE ServiceOrderID = @ServiceOrderID";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Rating", Rating);
                    command.Parameters.AddWithValue("@Feedback", Feedback);
                    command.Parameters.AddWithValue("@ServiceOrderID", ServiceOrderID);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            public class ServiceEntry
            {
                public string ServiceEntryID { get; set; }
                public string ServiceOrderID { get; set; }
                public string ServiceID { get; set; }
                public string Mode { get; set; }
                public string InitialStatus { get; set; }
                public string CompletionStatus { get; set; }
                public bool IsCompleted { get; set; }
                public string GenerateServiceEntryID()
                {
                    string query = "SELECT COUNT(*) FROM ServiceEntry WHERE ServiceOrderID = @ServiceOrderID";
                    string ServiceEntryID;
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);

                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ServiceOrderID", ServiceOrderID);

                        connection.Open();

                        int count = (int)command.ExecuteScalar();
                        ServiceEntryID = string.Concat(ServiceOrderID.Substring(ServiceOrderID.Length - 8).Reverse()) + (count + 1).ToString("D2"); // Zero-padded to 2 digits
                    }
                    return ServiceEntryID;
                }
                public void Add()
                {
                    string query = "INSERT INTO ServiceEntry (ServiceEntryID, ServiceOrderID, ServiceID, IsCompleted) " +
                        "VALUES (@ServiceEntryID, @ServiceOrderID, @ServiceID, 0)";
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);

                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ServiceEntryID", ServiceEntryID);
                        command.Parameters.AddWithValue("@ServiceOrderID", ServiceOrderID);
                        command.Parameters.AddWithValue("@ServiceID", ServiceID);

                        connection.Open();

                        // Execute the command
                        command.ExecuteNonQuery();
                    }
                }
                public void ServiceDone()
                {
                    string query = "UPDATE ServiceEntry SET InitialStatus = @InitialStatus, CompletionStatus = @CompletionStatus, IsCompleted = 1 " +
                        "WHERE ServiceEntryID = @ServiceEntryID";
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@InitialStatus", InitialStatus);
                        command.Parameters.AddWithValue("@CompletionStatus", CompletionStatus);
                        command.Parameters.AddWithValue("@ServiceEntryID", ServiceEntryID);

                        connection.Open();

                        command.ExecuteNonQuery();
                    }
                }
                public void SetMode()
                {
                    string query = "UPDATE ServiceEntry SET Mode = @Mode WHERE ServiceEntryID = @ServiceEntryID";
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Mode", Mode);
                        command.Parameters.AddWithValue("@ServiceEntryID", ServiceEntryID);

                        connection.Open();

                        command.ExecuteNonQuery();
                    }
                }
                public class ServiceParts
                {
                    public string ServiceEntryID { get; set; }
                    public string PartID { get; set; }
                    public int Quantity { get; set; }
                    public Decimal TotalCost { get; set; }
                    public void Add()
                    {
                        string query = "INSERT INTO ServiceParts (ServiceEntryID, PartID, Quantity, TotalCost) " +
                            "VALUES (@ServiceEntryID, @PartID, @Quantity, @TotalCost)";
                        using (SqlConnection connection = new SqlConnection(Program.connectionString))
                        {
                            SqlCommand command = new SqlCommand(query, connection);

                            // Add parameters to avoid SQL injection
                            command.Parameters.AddWithValue("@ServiceEntryID", ServiceEntryID);
                            command.Parameters.AddWithValue("@PartID", PartID);
                            command.Parameters.AddWithValue("@Quantity", Quantity);
                            command.Parameters.AddWithValue("@TotalCost", TotalCost);

                            connection.Open();

                            // Execute the command
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }

    public class Appointment
    {
        public string AppointmentID { get; set; }
        public string UserID { get; set; }
        public DateTime MakingDateTime { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string VehicleNumber { get ; set; }
        public string Status { get; set; }
        public static string GenerateAppointmentID()
        {
            string query = "SELECT COUNT(*) FROM Appointments";
            string AppointmentID;
            DateTime now = DateTime.Now;
            string preciseTime = now.ToString("HHmmssfffddMMyy");

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                AppointmentID = string.Concat(preciseTime.Reverse()) + (count + 1).ToString("D8"); // Zero-padded to 7 digits
            }
            return AppointmentID;
        }
        public void Add()
        {
            string query = "INSERT INTO Appointments (AppointmentID, UserID, MakingDateTime, AppointmentDateTime, VehicleNumber, Status) " +
                           "VALUES (@AppointmentID, @UserID, @MakingDateTime, @AppointmentDateTime, @VehicleNumber, 'Pending')";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@MakingDateTime", MakingDateTime);
                command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
                command.Parameters.AddWithValue("@VehicleNumber", VehicleNumber);

                connection.Open();

                // Execute the command
                command.ExecuteNonQuery();
            }
        }
        public void UpdateStatus(string status)
        {
            string query = "UPDATE Appointments SET Status = @Status WHERE AppointmentID = @AppointmentID";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                command.Parameters.AddWithValue("@Status", status);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public void Modify()
        {
            string query = "UPDATE Appointments " +
                "SET AppointmentDateTime = @AppointmentDateTime, " +
                "VehicleNumber = @VehicleNumber " +
                "WHERE AppointmentID = @AppointmentID";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
                command.Parameters.AddWithValue("@VehicleNumber", VehicleNumber);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public static bool IsVehicleNumberValid(string vehicle_number)
        {
            // Must start with capital letter, and can only contains capital letter and number within 2 - 15 characters and both must exist
            string pattern = @"^[A-Z](?=.*\d)[A-Z\d]{1,14}$";
            return Regex.IsMatch(vehicle_number, pattern);
        }
        public class Services
        {
            public string AppointmentID { get; set; }
            public string ServiceID { get; set; }
            public void Add()
            {
                string query = "INSERT INTO AppointmentServices (AppointmentID, ServiceID) " +
                               "VALUES (@AppointmentID, @ServiceID)";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    command.Parameters.AddWithValue("@ServiceID", ServiceID);

                    connection.Open();

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }
    }
    public class Parts
    {
        public string PartID { get; set; }
        public string PartType { get; set; }
        public string PartName { get; set; }
        public int Stock {  get; set; }
        public Decimal SellPrice { get; set; }
        public string Status {  get; set; }
        public static bool IsPartTypePrefixValid(string partTypePrefix)
        {
            string pattern = @"^[A-Z]{3}$";
            return Regex.IsMatch(partTypePrefix, pattern);
        }
        public static string GeneratePartID(string PartType, string newPrefix)
        {
            string PartID;
            string query = "SELECT TOP 1 PartID FROM Parts WHERE PartType = @PartType ORDER BY PartID DESC";

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PartType", PartType);
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    // Existing service type found
                    string lastServiceID = result.ToString();
                    string existingPrefix = new string(lastServiceID.TakeWhile(char.IsLetter).ToArray());
                    int lastNumber = int.Parse(new string(lastServiceID.SkipWhile(char.IsLetter).ToArray()));

                    PartID = existingPrefix + (lastNumber + 1).ToString("D3");
                }
                else
                {
                    // New service type, use provided newPrefix and start with 001
                    PartID = newPrefix + "001";
                }
            }
            return PartID;
        }
        public void Add()
        {
            string query = "INSERT INTO Parts (PartID, PartType, PartName, Stock, SellPrice, Status) VALUES " +
                "(@PartID, @PartType, @PartName, 0, 0, 'New')";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@PartID", PartID);
                command.Parameters.AddWithValue("@PartType", PartType);
                command.Parameters.AddWithValue("@PartName", PartName);

                connection.Open();

                // Execute the command
                command.ExecuteNonQuery();
            }
        }
        public void UpdateStock()
        {
            string query = "UPDATE Parts SET Stock = @Stock WHERE PartID = @PartID";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PartID", PartID);
                command.Parameters.AddWithValue("@Stock", Stock);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public void UpdatePrice(Decimal price)
        {
            string query = "UPDATE Parts SET SellPrice = @SellPrice WHERE PartID = @PartID";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PartID", PartID);
                command.Parameters.AddWithValue("@SellPrice", price);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public void ChangeStatus(string status)
        {
            string query = "UPDATE Parts SET Status = @Status WHERE PartID = @PartID";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PartID", PartID);
                command.Parameters.AddWithValue("@Status", status);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public class Purchases
        {
            public string PartID { get; set; }
            public DateTime DateTime { get; set; }
            public Decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
            public string Supplier {  get; set; }
            public void Add()
            {
                string query = "INSERT INTO PartsPurchase (PartID, DateTime, UnitPrice, Quantity, Supplier) VALUES " +
                    "(@PartID, @DateTime, @UnitPrice, @Quantity, @Supplier)";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlParameter unitprice = new SqlParameter("@UnitPrice", SqlDbType.Decimal)
                    {
                        Precision = 10,  // Total number of digits
                        Scale = 2,       // Number of decimal places
                        Value = UnitPrice
                    };

                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@PartID", PartID);
                    command.Parameters.AddWithValue("@DateTime", DateTime);
                    command.Parameters.AddWithValue("@Quantity", Quantity);
                    command.Parameters.AddWithValue("@Supplier", Supplier);
                    command.Parameters.Add(unitprice);

                    connection.Open();

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }
        public class Requests
        {
            public string RequestID { get; set; }
            public string UserID { get; set; }
            public string UserName { get; set; }
            public DateTime DateTime { get; set; }
            public string PartType { get; set; }
            public string PartName { get; set; }
            public string Description { get; set; }
            public static string GenerateRequestID()
            {
                string query = "SELECT COUNT(*) FROM PartsRequests";
                string requestID;

                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    requestID = $"Q{(count + 1):D7}"; // Zero-padded to 7 digits
                }
                return requestID;
            }
            public void Add()
            {
                string query = "INSERT INTO PartsRequests (RequestID, UserID, DateTime, PartType, PartName, Description) VALUES " +
                    "(@RequestID, @UserID, @DateTime, @PartType, @PartName, @Description)";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@RequestID", RequestID);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@DateTime", DateTime);
                    command.Parameters.AddWithValue("@PartType", PartType);
                    command.Parameters.AddWithValue("@PartName", PartName);
                    command.Parameters.AddWithValue("@Description", Description);

                    connection.Open();

                    // Execute the command without returning any results
                    command.ExecuteNonQuery();
                }
            }
            public void Approve()
            {
                string query = "UPDATE PartsRequests SET IsApproved = 1 WHERE RequestID = @RequestID";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RequestID", RequestID);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            public void Reject()
            {
                string query = "UPDATE PartsRequests SET IsApproved = 0 WHERE RequestID = @RequestID";
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RequestID", RequestID);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
