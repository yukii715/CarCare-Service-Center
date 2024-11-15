

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Appearance;
using Users;
using Functions;
using CarCare_Service_Center;
using static CarCare_Service_Center.Services;
using static CarCare_Service_Center.Appointment;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ControlSetting;


namespace CarCare_Service_Center
{

    public partial class frmAdminMain : Form
    {
        // to initialize object
        private Admin admin;
        private List<User> users = new List<User>();
        private List<User.StaffSalary> staffsalary = new List<User.StaffSalary>();
        private List<Services> service = new List<Services>();
        private List<ServiceOrder> serviceOrders = new List<ServiceOrder>();
        private List<Appointment> appointments = new List<Appointment>();


        public frmAdminMain(Admin ad)
        {
            // Profile details
            InitializeComponent();
            admin = ad;
            lblAdminID.Text = admin.UserID;
            lblAdminName.Text = admin.Username;
            lblAdminEmail.Text = admin.Email;
            lblWelcome.Text = "Welcome Back, " + admin.Username;
        }

        // to adjust controls into the tlp with the correct properties
        private void ctrlPropertiesinTlp(Object sender)
        {
            Control control = sender as Control;
            control.AutoSize = true;
            control.Dock = DockStyle.Fill;

            // Handle Label-specific properties
            if (control is Label label)
            {
                label.TextAlign = ContentAlignment.MiddleCenter;
            }

            // Handle Button-specific properties
            else if (control is System.Windows.Forms.Button button)
            {
                button.Text = "Detail";
                button.TextAlign = ContentAlignment.MiddleCenter;
            }
        }


        // to show the Staff data in tlpStaffAccountData
        private void show_controlinTlpStaffAccount(User user, ref int rowinsert)
        {
            // Increment row index for adding controls
            rowinsert++;

            // Create and add the UserID label
            Label staffID = new Label
            {
                Text = user.UserID.Trim()
            };
            ctrlPropertiesinTlp(staffID);
            tlpStaffAccountData.Controls.Add(staffID, 0, rowinsert);

            // Create and add the Username label
            Label staffName = new Label
            {
                Text = user.Username.Trim()
            };
            ctrlPropertiesinTlp(staffName);
            tlpStaffAccountData.Controls.Add(staffName, 1, rowinsert);

            // Create and add the Role label
            Label staffRole = new Label
            {
                Text = user.Role.Trim(),
            };
            ctrlPropertiesinTlp(staffRole);
            tlpStaffAccountData.Controls.Add(staffRole, 2, rowinsert);

            // Create and add the Staff Detail button
            System.Windows.Forms.Button btnStaffDetail = new System.Windows.Forms.Button();
            ctrlPropertiesinTlp(btnStaffDetail);
            btnStaffDetail.Tag = user;
            btnStaffDetail.Click += btnStaffDetail_Click;
            tlpStaffAccountData.Controls.Add(btnStaffDetail, 3, rowinsert);

            // Increment the row count for the TableLayoutPanel
            tlpStaffAccountData.RowCount++;
        }


        // to show the Service data in tlpServiceData
        private void show_controlinTlpService(Services service, ref int rowinsert)
        {
            // Increment row index for adding controls
            rowinsert++;

            Label serviceID = new Label
            {
                Text = service.ServiceID.Trim()
            };
            ctrlPropertiesinTlp(serviceID);
            tlpServiceData.Controls.Add(serviceID, 0, rowinsert);


            Label serviceName = new Label
            {
                Text = service.ServiceName.Trim(),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            ctrlPropertiesinTlp(serviceName);
            tlpServiceData.Controls.Add(serviceName, 1, rowinsert);


            Label serviceType = new Label
            {
                Text = service.ServiceType.Trim()
            };
            ctrlPropertiesinTlp(serviceType);
            tlpServiceData.Controls.Add(serviceType, 2, rowinsert);


            System.Windows.Forms.Button btnServiceDetail = new System.Windows.Forms.Button();
            ctrlPropertiesinTlp(btnServiceDetail);
            btnServiceDetail.Tag = service;
            btnServiceDetail.Click += btnServiceDetails_Click;
            tlpServiceData.Controls.Add(btnServiceDetail, 3, rowinsert);

            tlpServiceData.RowCount++;
        }


        // to show the Feedback data in tlpFeedbackData
        private void show_controlinTlpFeedback(ServiceOrder serviceOrder, ref int rowinsert)
        {
            rowinsert++;

            Label serviceOrderID = new Label
            {
                Text = serviceOrder.ServiceOrderID.Trim()
            };
            ctrlPropertiesinTlp(serviceOrderID);
            tlpFeedbackData.Controls.Add(serviceOrderID, 0, rowinsert);


            // Find the corresponding User based on AppointmentID
            var appointmentItem = appointments.Find(a => a.AppointmentID == serviceOrder.ApointmentID);
            var user = users.Find(u => u.UserID == appointmentItem.UserID);

            Label userName = new Label
            {
                Text = user.Username.Trim()
            };
            ctrlPropertiesinTlp(userName);
            tlpFeedbackData.Controls.Add(userName, 1, rowinsert);


            Label date = new Label
            {
                Text = serviceOrder.Date.ToString().Trim()
            };
            ctrlPropertiesinTlp(date);
            tlpFeedbackData.Controls.Add(date, 2, rowinsert);


            Label rating = new Label
            {
                Text = serviceOrder.Rating.ToString().Trim()
            };
            ctrlPropertiesinTlp(rating);
            tlpFeedbackData.Controls.Add(rating, 3, rowinsert);


            Label comment = new Label();
            ctrlPropertiesinTlp(comment);
            if (serviceOrder.Feedback == null || serviceOrder.Feedback == "")
            {
                comment.Text = "No";
            }
            else
            {
                comment.Text = "Yes";
            }
            tlpFeedbackData.Controls.Add(comment, 4, rowinsert);


            System.Windows.Forms.Button btnStaffDetail = new System.Windows.Forms.Button();
            ctrlPropertiesinTlp(btnStaffDetail);
            btnStaffDetail.Click += btnFeedbackDetail_Click;
            tlpFeedbackData.Controls.Add(btnStaffDetail, 5, rowinsert);

            tlpFeedbackData.RowCount++;
        }


        // to enter the data from server when the form load
        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            tabAdmin.DrawItem += Draw_Item.tabControlAdjustment;

            Place_Holder.SetPlaceHolder(txtServiceSearch, "Search");
            Place_Holder.SetPlaceHolder(txtStaffSearch, "Search");

            string query = "SELECT * FROM Users WHERE Role IN ('Receptionist', 'Mechanic');";
            users = Database.FetchData<User>(query);
            users = users.OrderBy(u => u.UserID).ToList();

            query = "SELECT * FROM Services;";
            service = Database.FetchData<Services>(query);
            service = service.OrderBy(u => u.ServiceID).ToList();


            query = "SELECT * FROM Appointments;";
            appointments = Database.FetchData<Appointment>(query);
            appointments = appointments.OrderBy(a => a.AppointmentID).ToList();


            query = "SELECT * FROM ServiceOrder;";
            serviceOrders = Database.FetchData<ServiceOrder>(query);
            serviceOrders = serviceOrders.OrderBy(s => s.ServiceOrderID).ToList();

            query = "SELECT * From StaffSalary;";
            staffsalary = Database.FetchData<User.StaffSalary>(query);
            staffsalary = staffsalary.OrderBy(s => s.UserID).ToList();

            for (int i = 0; i < staffsalary.Count; i++)
            {
                var user = users.Find(u => u.UserID == staffsalary[i].UserID);
                users[i].Salary = staffsalary[i].Salary;
            }


            int rowinsert = -1;
            for (int i = 0; i < users.Count; i++)
            {
                show_controlinTlpStaffAccount(users[i], ref rowinsert);
            }

            rowinsert = -1;
            for (int i = 0; i < service.Count; i++)
            {
                show_controlinTlpService(service[i], ref rowinsert);
            }

            rowinsert = -1;
            for (int i = 0; i < serviceOrders.Count; i++)
            {
                show_controlinTlpFeedback(serviceOrders[i], ref rowinsert);
            }


            //int earliestYear = GetEarliestRecordYear();
            //int currentYear = DateTime.Now.Year;

            //// Populate Year ComboBox from earliest year to current year
            //cmbFeedbackYear.Items.Clear();
            //cmbHomeYear.Items.Clear();
            //cmbReportYear.Items.Clear();


            //for (int year = earliestYear; year <= currentYear; year++)
            //{
            //    cmbHomeYear.Items.Add(year);
            //    cmbReportYear.Items.Add(year);
            //    cmbFeedbackYear.Items.Add(year);
            //}

            //// Populate Month ComboBox based on the selected year
            //UpdateMonthComboBox(currentYear);
        }
        // Tab Home
        // Tab Home
        // Tab Home
        // Tab Home
        // Tab Home
        private void HomeresetPreview(object sender, EventArgs e)
        {
            Series series = crtHomeRating.Series[0];

            btnHomeProfitDetail.Enabled = false;
            btnHomeRatingDetail.Enabled = false;
            btnHomeSearch.Enabled = true;
            lblMoneyEarn.Text = "RM -";
            lblMoneySpent.Text = "RM -";
            lblHomeProfit.Text = "RM -";
            series.Points.Clear();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeSearch_Click(object sender, EventArgs e)
        {
            // Check if items are selected in both cmbHomeMonth and cmHomeYear
            if (cmbHomeMonth.SelectedItem == null && cmbHomeYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a month and a year before Generating", "Generating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbHomeMonth.SelectedItem == null)
            {
                MessageBox.Show("Please select a month before Generating", "Generating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbHomeYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a year before Generating", "Generating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; ;
            }

            Series series = crtHomeRating.Series[0];

            decimal moneyEarn = 5000.00m;
            decimal moneySpent = 5000.00m;
            decimal profit = 70.45m;
            int ratingNumber = 5;

            lblMoneyEarn.Text = "RM" + moneyEarn.ToString().Trim();
            lblMoneySpent.Text = "RM" + moneySpent.ToString().Trim();
            lblHomeProfit.Text = "RM" + profit.ToString().Trim();
            btnHomeProfitDetail.Enabled = true;
            btnHomeRatingDetail.Enabled = true;

            for (int i = 0; i < 5; i++)
            {
                int ratingStar = 10;
                series.Points.AddY(ratingStar);
                series.Points[i].LegendText = ratingNumber.ToString().Trim() + " Star";
                series.Points[i].IsValueShownAsLabel = true;
                ratingNumber--;
            }

            btnHomeSearch.Enabled = false;
        }

        private void btnHomeProfitDetail_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 4;
            cmbReportMonth.SelectedIndex = cmbHomeMonth.SelectedIndex;
            cmbReportYear.SelectedIndex = cmbHomeYear.SelectedIndex;
        }

        private void btnHomeRatingDetail_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 3;
            cmbFeedbackMonth.SelectedItem = cmbHomeMonth.SelectedItem;
            cmbFeedbackYear.SelectedItem = cmbHomeYear.SelectedItem;
            btnFeedbackGenerate_Click(sender, e);
        }

        // Tab Staff
        // Tab Staff
        // Tab Staff
        // Tab Staff
        // Tab Staff
        // Tab Staff
        private void btnStaffSearch_Click(object sender, EventArgs e)
        {
            string role = null;
            if (cmbRoleSelection.SelectedItem != null)
            {
                role = cmbRoleSelection.SelectedItem.ToString().Trim();
            }

            string StaffSearch = null;

            if (txtStaffSearch.Text != "Search")
            {
                StaffSearch = txtStaffSearch.Text.ToLower().Trim();
            }

            int rowinsert = -1;
            tlpStaffAccountData.Controls.Clear();
            tlpStaffAccountData.RowCount = 1;

            if (StaffSearch == null && (role == "All" || role == null))
            {
                for (int i = 0; i < users.Count; i++)
                {
                    // Call show_control with the user and rowinsert
                    show_controlinTlpStaffAccount(users[i], ref rowinsert);
                }
            }
            else if (StaffSearch == null && role != "All")
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Role == role)
                    {
                        // Call show_control with the user and rowinsert
                        show_controlinTlpStaffAccount(users[i], ref rowinsert);
                    }
                }
            }
            else if (StaffSearch != null && role == "All")
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].UserID.ToLower().Contains(StaffSearch) ||
                        users[i].Username.ToLower().Contains(StaffSearch))
                    {
                        show_controlinTlpStaffAccount(users[i], ref rowinsert);
                    }
                }
            }
            else if (StaffSearch != null && role != "All")
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Role == role &&
                       (users[i].UserID.ToLower().Contains(StaffSearch) ||
                        users[i].Username.ToLower().Contains(StaffSearch)))
                    {
                        show_controlinTlpStaffAccount(users[i], ref rowinsert);
                    }
                }
            }
        }


        // Button click event to sort by UserID
        private void btnSortStaffID_Click(object sender, EventArgs e)
        {
            // Sort users by UserID
            users = users.OrderBy(u => u.UserID).ToList();
            btnStaffSearch_Click(sender, e);
        }


        // Button click event to sort by Username
        private void btnSortStaffName_Click(object sender, EventArgs e)
        {
            // Sort users by Username
            users = users.OrderBy(u => u.Username).ToList();
            btnStaffSearch_Click(sender, e);
        }


        private void btnStaffDetail_Click(object sender, EventArgs e)
        {
            User user = (User)(sender as Button).Tag;
            StaffDetails formStaffDetails = new StaffDetails(user);
            formStaffDetails.ShowDialog();
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            StaffInsertion formStaffInsertion = new StaffInsertion(admin);
            formStaffInsertion.Show();
        }

        // Tab Service
        // Tab Service
        // Tab Service
        // Tab Service
        // Tab Service
        // Tab Service
        // Tab Service
        // Tab Service

        // To filter the Result based on Search
        private void btnServiceSearch_Click(object sender, EventArgs e)
        {
            string service_type = null;
            if (cmbServiceType.SelectedItem != null)
            {
                service_type = cmbServiceType.SelectedItem.ToString().Trim();
            }


            string serviceName = null;
            if (txtServiceSearch.Text != "Search")
            {
                serviceName = txtServiceSearch.Text.ToLower().Trim();
            }

            int rowinsert = -1;
            tlpServiceData.Controls.Clear();
            tlpServiceData.RowCount = 1;

            if ((service_type == "All" || service_type == null) && serviceName == null)
            {
                for (int i = 0; i < service.Count; i++)
                {
                    show_controlinTlpService(service[i], ref rowinsert);
                }
            }
            else if (service_type != "All" && serviceName == null)
            {
                for (int i = 0; i < service.Count; i++)
                {
                    if (service[i].ServiceType == service_type)
                    {
                        show_controlinTlpService(service[i], ref rowinsert);
                    }
                }
            }
            else if (service_type == "All" && serviceName != null)
            {
                for (int i = 0; i < service.Count; i++)
                {
                    if (service[i].ServiceID.ToLower().Contains(serviceName) ||
                        service[i].ServiceName.ToLower().Contains(serviceName))
                    {
                        show_controlinTlpService(service[i], ref rowinsert);
                    }
                }
            }
            else if (service_type != "All" && serviceName != null)
            {
                for (int i = 0; i < service.Count; i++)
                {
                    if (service[i].ServiceType == service_type &&
                        (service[i].ServiceID.ToLower().Contains(serviceName) ||
                        service[i].ServiceName.ToLower().Contains(serviceName)))
                    {
                        show_controlinTlpService(service[i], ref rowinsert);
                    }
                }
            }
        }


        private void btnServiceSortID_Click(object sender, EventArgs e)
        {
            // Sort service by Service ID
            service = service.OrderBy(o => o.ServiceID).ToList();
            btnServiceSearch_Click(sender, e);
        }

        private void btnServiceSortName_Click(object sender, EventArgs e)
        {
            // Sort service by ServiceName
            service = service.OrderBy(o => o.ServiceName).ToList();
            btnServiceSearch_Click(sender, e);
        }

        private void btnServiceSortType_Click(object sender, EventArgs e)
        {
            // Sort service by Service Type
            service = service.OrderBy(o => o.ServiceID).ToList();
            service = service.OrderBy(o => o.ServiceType).ToList();
            btnServiceSearch_Click(sender, e);
        }


        private void btnServiceDetails_Click(object sender, EventArgs e)
        {
            Services services = (Services)(sender as Button).Tag;
            ServiceDetails formServiceDetails = new ServiceDetails(services);
            formServiceDetails.Show();
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            ServiceInsertion formServiceInsertion = new ServiceInsertion();
            formServiceInsertion.Show();
        }




        // Tab Feedback
        // Tab Feedback
        // Tab Feedback
        // Tab Feedback
        // Tab Feedback
        // Tab Feedback

        private void cmbFeedbackMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFeedbackGenerate.Enabled = true;
        }

        private void cmbFeedbackYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFeedbackGenerate.Enabled = true;
        }
        private void btnFeedbackGenerate_Click(object sender, EventArgs e)
        {
            // Check if items are selected in both cmbHomeMonth and cmHomeYear
            if (cmbFeedbackMonth.SelectedItem == null && cmbFeedbackYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a month and a year before Generating", "Generating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbFeedbackMonth.SelectedItem == null)
            {
                MessageBox.Show("Please select a month before Generating", "Generating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbFeedbackYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a year before Generating", "Generating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Series feedbackSeries = crtFeedbackRating.Series[0];
            feedbackSeries.Points.Clear();

            int ratingNumber = 5;
            int totalRatingCount = 0;

            for (int i = 0; i < 5; i++)
            {
                int ratingStar = 10;
                feedbackSeries.Points.AddY(ratingStar);
                feedbackSeries.Points[i].LegendText = ratingNumber.ToString().Trim() + " Star:  " + ratingStar.ToString().Trim();
                feedbackSeries.Points[i].IsValueShownAsLabel = true;
                totalRatingCount += ratingStar;
                ratingNumber--;
            }

            lblFeedbackTotal.Text = "Total: " + totalRatingCount.ToString().Trim();
            pnlFeedbackData.Visible = true;
            tableLayoutPanel1.Visible = true;
            btnFeedbackGenerate.Enabled = false;

        }

        private void btnFeedbackDetail_Click(object sender, EventArgs e)
        {
            FeedbackDetails formFeedbackDetails = new FeedbackDetails();
            formFeedbackDetails.Show();
        }

    }
}
