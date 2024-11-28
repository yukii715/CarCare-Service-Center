using System;
using Users;
using CarCare_Service_Center;
using static CarCare_Service_Center.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Functions;

namespace CarCare_Service_Center
{
    public partial class FeedbackDetails : Form
    {
        private ServiceOrder serviceOrder;
        private List<ServiceOrder.ServiceEntry> serviceEntries;
        private List<Services> services;
        public FeedbackDetails(ServiceOrder so)
        {
            InitializeComponent();
            serviceOrder = so;
        }


        private void FeedbackDetails_Load(object sender, EventArgs e)
        {
            lblName.Text = serviceOrder.Username.ToString().Trim();
            lblDate.Text = serviceOrder.ArrivalDateTime.ToString("yyyy-MM-dd");
            lblServiceOrderID.Text = serviceOrder.ServiceOrderID.ToString();

            string query = "SELECT * From ServiceEntry WHERE ServiceOrderID = " + $"'{serviceOrder.ServiceOrderID}'" + "ORDER BY ServiceOrderID; ";
            serviceEntries = Database.FetchData<ServiceOrder.ServiceEntry>(query); // Return the result from query

            query = "SELECT * FROM Services;";
            services = Database.FetchData<Services>(query);
            services = services.OrderBy(s => s.ServiceID).ToList();


            for (int i = 0; i < serviceEntries.Count; i++)
            {
                string serviceName = services.Find(s => s.ServiceID == serviceEntries[i].ServiceID).ServiceName;
                lblServices.Text += $"{i + 1}. " + serviceName.Trim() + "\n";
            };

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Top > lblServices.Top)
                {
                    ctrl.Top += lblServices.Height;
                }
            }
            lblPrice.Text = serviceOrder.TotalPrice.ToString("C2").Trim();
            lblRating.Text = serviceOrder.Rating.ToString();
            lblComment.Text = serviceOrder.Feedback.ToString();

            btnBack.Location = new System.Drawing.Point(150, lblComment.Bottom + 50);  // Position below the label
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}