
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
using CarCare_Service_Center;
using static CarCare_Service_Center.Services;
using static CarCare_Service_Center.Appointment;
using System.Drawing.Text;

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
                Text = user.UserID
            };
            ctrlPropertiesinTlp(staffID);
            tlpStaffAccountData.Controls.Add(staffID, 0, rowinsert);

            // Create and add the Username label
            Label staffName = new Label
            {
                Text = user.Username
            };
            ctrlPropertiesinTlp(staffName);
            tlpStaffAccountData.Controls.Add(staffName, 1, rowinsert);

            // Create and add the Role label
            Label staffRole = new Label
            {
                Text = user.Role,
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
            Label serviceID = new Label
            {
                Text = service.ServiceID
            };
            ctrlPropertiesinTlp(serviceID);
            tlpServiceData.Controls.Add(serviceID, 0, rowinsert);


            Label serviceName = new Label
            {
                Text = service.ServiceName
            };
            ctrlPropertiesinTlp(serviceName);
            tlpServiceData.Controls.Add(serviceName, 1, rowinsert);


            Label serviceType = new Label
            {
                Text = service.ServiceType
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
            Label serviceOrderID = new Label
            {
                Text = serviceOrder.ServiceOrderID
            };
            ctrlPropertiesinTlp(serviceOrderID);
            tlpFeedbackData.Controls.Add(serviceOrderID, 0, rowinsert);


            // Find the corresponding User based on AppointmentID
            var appointmentItem = appointments.Find(a => a.AppointmentID == serviceOrder.ApointmentID);
            var user = users.Find(u => u.UserID == appointmentItem.UserID);

            Label userName = new Label
            {
                Text = user.Username
            };
            ctrlPropertiesinTlp(userName);
            tlpFeedbackData.Controls.Add(userName, 1, rowinsert);


            Label date = new Label
            {
                Text = serviceOrder.Date.ToString()
            };
            ctrlPropertiesinTlp(date);
            tlpFeedbackData.Controls.Add(date, 2, rowinsert);


            Label rating = new Label
            {
                Text = serviceOrder.Rating.ToString()
            };
            ctrlPropertiesinTlp(rating);
            tlpFeedbackData.Controls.Add(rating, 3, rowinsert);


            Label comment = new Label();
            ctrlPropertiesinTlp(comment);
            if (serviceOrder.Feedback == null)
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

            users.Add(new User { UserID = "20000001", Username = "Win", Role = "Receptionist" });
            users.Add(new User { UserID = "30000001", Username = "Win", Role = "Mechanic" });
            users.Add(new User { UserID = "30000002", Username = "Ali", Role = "Mechanic" });

            service.Add(new Services { ServiceID = "BMS001", ServiceName = "huh?", ServiceType = "Repair Service" });
            service.Add(new Services { ServiceID = "BMS001", ServiceName = "huh?", ServiceType = "Repair Service" });
            service.Add(new Services { ServiceID = "BMS001", ServiceName = "huh?", ServiceType = "Repair Service" });

            appointments.Add(new Appointment { AppointmentID = "ID00", UserID = "20000001" });
            appointments.Add(new Appointment { AppointmentID = "ID01", UserID = "30000001" });


            serviceOrders.Add(new ServiceOrder { ServiceOrderID = "1001", ApointmentID = "ID00", Rating = 5, Feedback = "Very good", Date = DateTime.Now });
            serviceOrders.Add(new ServiceOrder { ServiceOrderID = "2002", ApointmentID = "ID01", Rating = 1, Feedback = "Very bad", Date = DateTime.Now });


            staffsalary.Add(new User.StaffSalary { UserID = "20000001", Salary = 5000 });
            staffsalary.Add(new User.StaffSalary { UserID = "30000001", Salary = 10000 });
            staffsalary.Add(new User.StaffSalary { UserID = "30000002", Salary = 20000 });
            int rowinsert = -1;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Role == "Mechanic" || users[i].Role == "Receptionist")
                {
                    show_controlinTlpStaffAccount(users[i], ref rowinsert);
                }
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
            btnHomeGenerate.Enabled = true;
            lblMoneyEarn.Text = "RM -";
            lblMoneySpent.Text = "RM -";
            lblHomeProfit.Text = "RM -";
            series.Points.Clear();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeGenerate_Click(object sender, EventArgs e)
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

            lblMoneyEarn.Text = "RM" + moneyEarn.ToString();
            lblMoneySpent.Text = "RM" + moneySpent.ToString();
            lblHomeProfit.Text = "RM" + profit.ToString();
            btnHomeProfitDetail.Enabled = true;
            btnHomeRatingDetail.Enabled = true;

            for (int i = 0; i < 5; i++)
            {
                int ratingStar = 10;
                series.Points.AddY(ratingStar);
                series.Points[i].LegendText = ratingNumber.ToString() + " Star";
                series.Points[i].IsValueShownAsLabel = true;
                ratingNumber--;
            }

            btnHomeGenerate.Enabled = false;
        }

        private void btnHomeProfitDetail_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 4;
            cmbReportMonth.SelectedIndex = cmbHomeMonth.SelectedIndex;
            cmbReportYear.SelectedIndex = cmbHomeYear.SelectedIndex;
            btnReportGenerate_Click(sender, e);
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
        private void cmbRoleSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStaffSearch.Enabled = true;
        }

        private void btnStaffSearch_Click(object sender, EventArgs e)
        {
            btnStaffAccountSortID.Enabled = true;
            btnStaffAccountSortName.Enabled = true;

            string role = cmbRoleSelection.SelectedItem.ToString();
            string StaffSearch = null;

            if (txtStaffSearch.Text != "Search")
            {
                StaffSearch = txtStaffSearch.Text.ToLower();
            }

            int rowinsert = -1;
            tlpStaffAccountData.Controls.Clear();
            tlpStaffAccountData.RowCount = 1;

            if (StaffSearch == null && role == "All")
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Role == "Mechanic" || users[i].Role == "Receptionist")
                    {
                        show_controlinTlpStaffAccount(users[i], ref rowinsert);  // Call show_control with the user and rowinsert
                    }
                }
            }
            else if (StaffSearch == null && role != "All")
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Role == role)
                    {
                        show_controlinTlpStaffAccount(users[i], ref rowinsert);  // Call show_control with the user and rowinsert
                    }
                }
            }
            else if (StaffSearch != null && role == "All")
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if ((users[i].Role == "Mechanic" || users[i].Role == "Receptionist") && (users[i].UserID.ToLower().Contains(StaffSearch) || users[i].Username.ToLower().Contains(StaffSearch)))
                    {
                        show_controlinTlpStaffAccount(users[i], ref rowinsert);
                    }
                }
            }
            else if (StaffSearch != null && role != "All")
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Role == role && (users[i].UserID.ToLower().Contains(StaffSearch) || users[i].Username.ToLower().Contains(StaffSearch)))
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
            formStaffDetails.Show();
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            StaffInsertion formStaffInsertion = new StaffInsertion(admin);
            formStaffInsertion.Show();
        }

        private void btnServiceSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceSortID_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceSortName_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceSortServiceType_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceDetails_Click(object sender, EventArgs e)
        {
            ServiceDetails formServiceDetails = new ServiceDetails();
            formServiceDetails.Show();
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            ServiceInsertion formServiceInsertion = new ServiceInsertion();
            formServiceInsertion.Show();
        }

        private void cmbFeedbackMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlFeedbackData.Visible = false;
            tableLayoutPanel1.Visible = false;
            Series series = crtFeedbackRating.Series[0];
            series.Points.Clear();
            btnFeedbackGenerate.Enabled = true;
        }

        private void cmbFeedbackYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlFeedbackData.Visible = false;
            tableLayoutPanel1.Visible = false;
            Series series = crtFeedbackRating.Series[0];
            series.Points.Clear();
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

            int ratingNumber = 5;

            for (int i = 0; i < 5; i++)
            {
                int ratingStar = 10;
                feedbackSeries.Points.AddY(ratingStar);
                feedbackSeries.Points[i].LegendText = ratingNumber.ToString() + " Star:  " + ratingStar.ToString();
                feedbackSeries.Points[i].IsValueShownAsLabel = true;
                ratingNumber--;
            }

            pnlFeedbackData.Visible = true;
            tableLayoutPanel1.Visible = true;
            btnFeedbackGenerate.Enabled = false;

        }

        private void btnFeedbackDetail_Click(object sender, EventArgs e)
        {
            FeedbackDetails formFeedbackDetails = new FeedbackDetails();
            formFeedbackDetails.Show();
        }

        private void cmbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnServiceSearch.Enabled = true;
        }

        private void btnReportGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}
