using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
        public string Image {  get; set; }
        public static bool IsServiceTypePrefixValid(string serviceTypePrefix)
        {
            string pattern = @"^[A-Z]{3}$";
            return Regex.IsMatch(serviceTypePrefix, pattern);
        }
        public class ServicePrice
        {
            public string ServiceID { get; set; }
            public float Price { get; set; }
            public string Description { get; set; }
        }
            public class ServiceOrder
        {
            public string ServiceOrderID { get; set; }
            public string UserID { get; set; }
            public string VehicleNumber { get; set; }
            public string CompletionStatus { get; set; }
            public string ArrivalDate { get; set; }
            public string ArrivalTime { get; set; }
            public string CollectionDate { get; set; }
            public string CollectionTime { get; set; }
            public float TotalPrice { get; set; }
            public string PaymentMethod { get; set; }
            public string Feedback { get; set; }
            public int Rating { get; set; }
            public class ServiceEntry
            {
                public string ServiceEntryID { get; set; }
                public string ServiceOrderID { get; set; }
                public string ServiceID { get; set; }
                public string StartDate{ get; set; }
                public string StartTime { get; set; }
                public string EndDate{ get; set; }
                public string EndTime { get; set; }
                public string Price { get; set; }
                public class ServiceParts
                {
                    public string ServiceEntryID { get; set; }
                    public string PartID { get; set; }
                    public int Quantity { get; set; }
                    public float TotalCost { get; set; }
                }
            }
        }
    }

    public class Appointment
    {
        public string AppointmentID { get; set; }
        public string UserID { get; set; }
        public string MakingDate { get; set; }
        public string MakingTime { get; set; }
        public string AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public string VehicleNumber { get ; set; }
        public string ServiceID { get; set; }
        public string Status { get; set; }
    }
    public class Parts
    {
        public string PartID { get; set; }
        public string PartType { get; set; }
        public string PartName { get; set; }
        public int Stock {  get; set; }
        public float SellPrice { get; set; }
        public string Status {  get; set; }
        public class Purchases
        {
            public string PartID { get; set; }
            public float UnitPrice { get; set; }
            public int Quantity { get; set; }
            public string Supplier {  get; set; }

        }
    }
}
