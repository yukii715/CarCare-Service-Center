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
using Users;
using Functions;
using CarCare_Service_Center;
using static CarCare_Service_Center.Services;
using static CarCare_Service_Center.Appointment;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ControlSetting;
using System.Globalization;
using System.Collections;


namespace CarCare_Service_Center
{

    public partial class frmAdminMain : Form
    {
        // to initialize object
        private Admin admin;
        private List<User> users;
        private List<User> customers;
        private List<User.StaffSalary> staffsalary;
        private List<Services> service;
        private List<ServiceOrder> serviceOrders;
        private List<Appointment> appointments;
        private List<User.StaffSalary.Payroll> payroll;
        private List<Parts.Purchases> part_purchase;


        public frmAdminMain(Admin ad)
        {
            InitializeComponent();
            admin = ad;
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


        public void LoadUser()
        {
            string query = "SELECT * FROM Users WHERE Role IN ('Receptionist', 'Mechanic') AND IsDeleted = 0;";
            users = Database.FetchData<User>(query);
            users = users.OrderBy(u => u.UserID).ToList();

            LoadStaffSalary();

            for (int i = 0; i < users.Count; i++)
            {
                users[i].Salary = staffsalary.Find(s => s.UserID == users[i].UserID).Salary;
            }


            int rowinsert = -1;
            for (int i = 0; i < users.Count; i++)
            {
                show_controlinTlpStaffAccount(users[i], ref rowinsert);
            }
        }


        public void LoadStaffSalary()
        {
            string query = "SELECT * From StaffSalary;";
            staffsalary = Database.FetchData<User.StaffSalary>(query);
            staffsalary = staffsalary.OrderBy(s => s.UserID).ToList();
        }


        public void LoadServices()
        {
            string query = "SELECT * FROM Services WHERE IsDeleted = 0;";
            service = Database.FetchData<Services>(query);
            service = service.OrderBy(u => u.ServiceID).ToList();

            cmbServiceType.Items.Clear();
            cmbServiceType.Items.Add("All");

            query = "SELECT DISTINCT ServiceType FROM Services WHERE IsDeleted = 0;";
            Database.LoadIntoComboBox(cmbServiceType, query, "ServiceType");

            int rowinsert = -1;
            for (int i = 0; i < service.Count; i++)
            {
                show_controlinTlpService(service[i], ref rowinsert);
            }
        }


        public void LoadPartPurchased()
        {
            string query = "SELECT * FROM PartsPurchase;";
            part_purchase = Database.FetchData<Parts.Purchases>(query);
            part_purchase = part_purchase.OrderBy(u => u.PartID).ToList();
        }


        public void LoadPayroll()
        {

            string query = "SELECT * FROM Users WHERE Role IN ('Receptionist', 'Mechanic');";
            List<User> useritem = Database.FetchData<User>(query);
            useritem = useritem.OrderBy(u => u.UserID).ToList();


            query = "SELECT * FROM Payroll;";
            payroll = Database.FetchData<User.StaffSalary.Payroll>(query);
            payroll = payroll.OrderBy(s => s.PayrollID).ToList();

            if (payroll.Count >= 1)
            {
                for (int i = 0; i < payroll.Count; i++)
                {
                    var user = useritem.Find(u => u.UserID == payroll[i].UserID);
                    payroll[i].Username = user.Username;
                    payroll[i].Role = user.Role;
                }
            }
        }


        private void LoadServiceOrder()
        {
            LoadAppointment();
            string query = "SELECT * FROM ServiceOrder Where CollectionDateTime IS NOT NULL";
            serviceOrders = Database.FetchData<ServiceOrder>(query);
            serviceOrders = serviceOrders.OrderBy(s => s.ServiceOrderID).ToList();

            query = "SELECT * FROM Users;";
            customers = Database.FetchData<User>(query);

            int rowinsert = -1;
            for (int i = 0; i < serviceOrders.Count; i++)
            {
                // Find the corresponding User based on AppointmentID
                var appointmentItem = appointments.Find(a => a.AppointmentID == serviceOrders[i].AppointmentID);
                serviceOrders[i].Username = customers.Find(u => u.UserID == appointmentItem.UserID).Username;
                show_controlinTlpFeedback(serviceOrders[i], ref rowinsert);
            }
        }


        private void LoadAppointment()
        {
            string query = "SELECT * FROM Appointments;";
            appointments = Database.FetchData<Appointment>(query);
            appointments = appointments.OrderBy(a => a.AppointmentID).ToList();
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

            Label userName = new Label
            {
                Text = serviceOrder.Username.Trim()
            };
            ctrlPropertiesinTlp(userName);
            tlpFeedbackData.Controls.Add(userName, 1, rowinsert);


            Label date = new Label
            {
                Text = serviceOrder.ArrivalDateTime.ToString("d").Trim()
            };
            ctrlPropertiesinTlp(date);
            tlpFeedbackData.Controls.Add(date, 2, rowinsert);


            Label rating = new Label();
            if (serviceOrder.Rating.ToString() != null)
            {
                rating.Text = serviceOrder.Rating.ToString().Trim();
            }
            else
            {
                rating.Text = "-";
            }

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


            System.Windows.Forms.Button btnFeedbackDetail = new System.Windows.Forms.Button();
            ctrlPropertiesinTlp(btnFeedbackDetail);
            btnFeedbackDetail.Tag = serviceOrder;
            btnFeedbackDetail.Click += btnFeedbackDetail_Click;
            tlpFeedbackData.Controls.Add(btnFeedbackDetail, 5, rowinsert);

            tlpFeedbackData.RowCount++;
        }



        // to show the Staff Salary data that hasnt been paid in tlpSalaryData
        public void show_controlinTlpSalaryData(User user, ref int rowinsert)
        {
            // Increment row index for adding controls
            rowinsert++;

            // Create and add the UserID label
            Label staffID = new Label
            {
                Text = user.UserID.Trim()
            };
            ctrlPropertiesinTlp(staffID);
            tlpSalaryData.Controls.Add(staffID, 0, rowinsert);


            // Create and add the Username label
            Label staffName = new Label
            {
                Text = user.Username.Trim()
            };
            ctrlPropertiesinTlp(staffName);
            tlpSalaryData.Controls.Add(staffName, 1, rowinsert);


            // Create and add the Role label
            Label staffRole = new Label
            {
                Text = user.Role.Trim(),
            };
            ctrlPropertiesinTlp(staffRole);
            tlpSalaryData.Controls.Add(staffRole, 2, rowinsert);


            Label BaseSalary = new Label
            {
                Text = user.Salary.ToString().Trim(),
            };
            ctrlPropertiesinTlp(BaseSalary);
            tlpSalaryData.Controls.Add(BaseSalary, 3, rowinsert);


            // Create and add the Staff Salary Detail button
            System.Windows.Forms.Button btnStaffSalaryAdd = new System.Windows.Forms.Button();
            ctrlPropertiesinTlp(btnStaffSalaryAdd);
            btnStaffSalaryAdd.Text = "Add";
            btnStaffSalaryAdd.Tag = user;
            btnStaffSalaryAdd.Click += btnStaffSalaryAdd_Click;
            tlpSalaryData.Controls.Add(btnStaffSalaryAdd, 4, rowinsert);

            // Increment the row count for the TableLayoutPanel
            tlpSalaryData.RowCount++;
        }



        // to show the Service Report data in tlpServiceReportData
        public void show_controlinTlpServiceReportData(Services.ServiceOrder service_order, ref int rowinsert)
        {
            rowinsert++;
            Label SOID = new Label
            {
                Text = service_order.ServiceOrderID.Trim()
            };
            ctrlPropertiesinTlp(SOID);
            tlpServiceReportData.Controls.Add(SOID, 0, rowinsert);



            Label Date = new Label
            {
                Text = service_order.ArrivalDateTime.ToString("yyyy-MM-dd").Trim()
            };
            ctrlPropertiesinTlp(Date);
            tlpServiceReportData.Controls.Add(Date, 1, rowinsert);


            Label ServicePrice = new Label
            {
                Text = service_order.TotalPrice.ToString().Trim()
            };
            ctrlPropertiesinTlp(ServicePrice);
            tlpServiceReportData.Controls.Add(ServicePrice, 2, rowinsert);


            System.Windows.Forms.Button btnServiceOrderDetail = new System.Windows.Forms.Button();
            ctrlPropertiesinTlp(btnServiceOrderDetail);
            btnServiceOrderDetail.Tag = service_order;
            btnServiceOrderDetail.Click += btnServiceReportDetail_Click;
            tlpServiceReportData.Controls.Add(btnServiceOrderDetail, 3, rowinsert);

            tlpServiceReportData.RowCount++;
        }


        // to show the Staff Salary Report data in tlpStaffSalaryReportData
        private void show_controlinTlpStaffSalaryReport(User.StaffSalary.Payroll payroll, ref int rowinsert)
        {
            rowinsert++;
            Label UserID = new Label
            {
                Text = payroll.UserID.Trim()
            };
            ctrlPropertiesinTlp(UserID);
            tlpStaffSalaryReportData.Controls.Add(UserID, 0, rowinsert);


            // Find the corresponding User name based on payrollID
            var user = users.Find(u => u.UserID == payroll.UserID);

            Label UserName = new Label
            {
                Text = payroll.Username.Trim()
            };
            ctrlPropertiesinTlp(UserName);
            tlpStaffSalaryReportData.Controls.Add(UserName, 1, rowinsert);


            Label SalaryAmount = new Label
            {
                Text = payroll.Amount.ToString().Trim()
            };
            ctrlPropertiesinTlp(SalaryAmount);
            tlpStaffSalaryReportData.Controls.Add(SalaryAmount, 2, rowinsert);


            System.Windows.Forms.Button btnStaffSalaryDetail = new System.Windows.Forms.Button();
            ctrlPropertiesinTlp(btnStaffSalaryDetail);
            btnStaffSalaryDetail.Tag = payroll;
            btnStaffSalaryDetail.Click += btnStaffSalaryDetail_Click;
            tlpStaffSalaryReportData.Controls.Add(btnStaffSalaryDetail, 3, rowinsert);

            tlpStaffSalaryReportData.RowCount++;
        }


        // to show the Cost and Expenses Report data in tlpCostAndExpensesData
        private void show_controlinTlpCaEData(Parts.Purchases part_purchase, ref int rowinsert)
        {
            rowinsert++;
            Label CaEID = new Label
            {
                Text = part_purchase.PartID.Trim()
            };
            ctrlPropertiesinTlp(CaEID);
            tlpCaEData.Controls.Add(CaEID, 0, rowinsert);


            Label Date = new Label
            {
                Text = part_purchase.DateTime.ToString("yyyy-MM-dd").Trim()
            };
            ctrlPropertiesinTlp(Date);
            tlpCaEData.Controls.Add(Date, 1, rowinsert);


            Label Price = new Label
            {
                Text = (part_purchase.UnitPrice * part_purchase.Quantity).ToString().Trim()
            };
            ctrlPropertiesinTlp(Price);
            tlpCaEData.Controls.Add(Price, 2, rowinsert);


            System.Windows.Forms.Button btnCaEDetail = new System.Windows.Forms.Button();
            ctrlPropertiesinTlp(btnCaEDetail);
            btnCaEDetail.Tag = part_purchase;
            btnCaEDetail.Click += btnCaEDetail_Click;
            tlpCaEData.Controls.Add(btnCaEDetail, 3, rowinsert);

            tlpCaEData.RowCount++;
        }


        // To provide month and Year selection for comboBox dealing with date
        private void SetupYearMonthComboBox(ComboBox cmbYear, ComboBox cmbMonth)
        {
            DateTime today = DateTime.Today;

            // Populate the year and month ComboBox within a 90 days range from today

            for (int year = 2024; year <= today.Year; year++)
            {
                cmbYear.Items.Add(year);
            }

            // Attach event handlers to year and month ComboBoxes 
            cmbYear.SelectedIndexChanged += (s, e) => UpdateMonthComboBox();


            void UpdateMonthComboBox()
            {
                cmbMonth.Items.Clear();
                cmbMonth.Enabled = true;

                if (cmbYear.SelectedItem != null)
                {
                    int selectedYear = (int)cmbYear.SelectedItem;
                    int Month = today.Month;

                    for (int month = 1; month <= Month; month++)
                    {
                        cmbMonth.Items.Add(CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(month));
                    }
                }
            }
        }



        // to enter the data from server when the form load
        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            tabAdmin.DrawItem += Draw_Item.tabControlAdjustment;

            Place_Holder.SetPlaceHolder(txtStaffSearch, "Search");
            Place_Holder.SetPlaceHolder(txtServiceSearch, "Search");
            Place_Holder.SetPlaceHolder(txtSalarySearch, "Search");

            lblAdminID.Text = admin.UserID;

            string query = "SELECT * FROM Users WHERE IsDeleted = 0";
            users = Database.FetchData<User>(query);

            admin.Username = users.Find(u => u.UserID == admin.UserID).Username;
            admin.Email = users.Find(u => u.UserID == admin.UserID).Email;
            lblAdminName.Text = admin.Username;
            lblAdminEmail.Text = admin.Email;
            lblWelcome.Text = "Welcome Back, " + admin.Username;


            LoadAppointment();
            LoadServices();
            LoadUser();
            LoadStaffSalary();
            LoadPayroll();
            LoadServiceOrder();
            LoadPartPurchased();

            SetupYearMonthComboBox(cmbHomeYear, cmbHomeMonth);
            SetupYearMonthComboBox(cmbSalaryYear, cmbSalaryMonth);
            SetupYearMonthComboBox(cmbFeedbackYear, cmbFeedbackMonth);
            SetupYearMonthComboBox(cmbReportYear, cmbReportMonth);

            HightLightLabelEvent(lblHome);
            HightLightLabelEvent(lblReload);
            HightLightLabelEvent(lblLogout);
        }

        // Top
        // TOp
        // Top
        // Top
        // Top

        private void HightLightLabelEvent(Label label)
        {
            label.MouseEnter += (s, ev) => label.ForeColor = Color.Violet;
            label.MouseLeave += (s, ev) =>
            {
                if (label.ForeColor != Color.Blue)
                    label.ForeColor = SystemColors.ControlText;
            };
            label.MouseDown += (s, ev) => label.ForeColor = Color.Blue;
        }


        private void lblHome_Click(object sender, EventArgs e)
        {
            lblHome.ForeColor = SystemColors.ControlText;
            tabAdmin.SelectedIndex = 0;
        }


        private void lblReload_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to reload the application? Unsaved changes will be lost.",
            "Reload Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                lblReload.ForeColor = SystemColors.ControlText;

                int currentTabIndex = tabAdmin.SelectedIndex;

                Controls.Clear();
                InitializeComponent();
                frmAdminMain_Load(sender, e);
                tabAdmin.SelectedIndex = currentTabIndex;
            }
        }


        private void lblLogout_Click(object sender, EventArgs e)
        {
            lblLogout.ForeColor = SystemColors.ControlText;
            frmLogoutConfirmation frmLogoutConfirmation = new frmLogoutConfirmation(this);
            frmLogoutConfirmation.ShowDialog();
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


        private void btnHomeSearch_Click(object sender, EventArgs e)
        {
            // Check if items are selected in both cmbHomeMonth and cmHomeYear
            if (cmbHomeMonth.SelectedItem == null && cmbHomeYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a year and a month before Searching", "Generating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbHomeMonth.SelectedItem == null)
            {
                MessageBox.Show("Please select a month before Searching", "Generating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string year = cmbHomeYear.SelectedItem.ToString().Trim();
            DateTime m = DateTime.ParseExact(cmbHomeMonth.SelectedItem.ToString().Trim(), "MMMM", CultureInfo.InvariantCulture);
            string month = m.ToString("MM");

            Dictionary<int, int> ratings = new Dictionary<int, int>
            {
                { 5, 0 },
                { 4, 0 },
                { 3, 0 },
                { 2, 0 },
                { 1, 0 },
            };


            for (int i = 0; i < serviceOrders.Count; i++)
            {
                if (serviceOrders[i].ArrivalDateTime.Year.ToString() == year &&
                    serviceOrders[i].ArrivalDateTime.Month.ToString() == month
                    && ratings.ContainsKey(serviceOrders[i].Rating))
                {
                    ratings[serviceOrders[i].Rating]++;
                }
                continue;
            }

            Series feedbackSeries = crtHomeRating.Series[0];
            feedbackSeries.Points.Clear();

            int ratingNumber = 5;
            int totalRatingCount = 0;

            for (int i = 0; i < 5; i++)
            {
                int ratingStarCount = ratings[ratingNumber];
                feedbackSeries.Points.AddY(ratingStarCount);
                feedbackSeries.Points[i].LegendText = ratingNumber.ToString().Trim() + " Star";
                //feedbackSeries.Points[i].IsValueShownAsLabel = true;
                totalRatingCount += ratingStarCount;
                ratingNumber--;
            }


            decimal moneyEarn =  filter_moneyEarn(month, year);
            decimal moneySpent = filter_moneySpent(month, year);
            decimal profit = moneyEarn - moneySpent;


            lblMoneyEarn.Text = moneyEarn.ToString("C2").Trim();
            lblMoneySpent.Text = moneySpent.ToString("C2").Trim();
            lblHomeProfit.Text = profit.ToString("C2").Trim();


            btnHomeProfitDetail.Enabled = true;
            btnHomeRatingDetail.Enabled = true;
            btnHomeSearch.Enabled = false;
        }


        private void btnHomeProfitDetail_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 5;
            cmbReportYear.SelectedIndex = cmbHomeYear.SelectedIndex;
            cmbReportMonth.SelectedIndex = cmbHomeMonth.SelectedIndex;
            btnReportSearch_Click(sender, e);
        }


        private void btnHomeRatingDetail_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 3;
            cmbFeedbackYear.SelectedItem = cmbHomeYear.SelectedItem;
            cmbFeedbackMonth.SelectedItem = cmbHomeMonth.SelectedItem;
            btnFeedbackSearch_Click(sender, e);
        }


        private decimal filter_moneyEarn(string month, string year)
        {
            decimal RevenuePerMonth = 0;

            for (int i = 0; i < serviceOrders.Count; i++)
            {
                if (serviceOrders[i].ArrivalDateTime.ToString("yyyy") == year && serviceOrders[i].ArrivalDateTime.ToString("MM") == month)
                {
                    RevenuePerMonth += serviceOrders[i].TotalPrice;
                }
            }
            return RevenuePerMonth;
        }


        private decimal filter_moneySpent(string month, string year)
        {
            decimal moneySpentPerMonth = 0;

            for (int i = 0; i < payroll.Count; i++)
            {
                if (payroll[i].Year == year && payroll[i].Month == month)
                {
                    moneySpentPerMonth += payroll[i].Amount;
                }
            }

            for (int i = 0; i < part_purchase.Count; i++)
            {
                if (part_purchase[i].DateTime.ToString("yyyy") == year && part_purchase[i].DateTime.ToString("MM") == month)
                {
                    moneySpentPerMonth += (part_purchase[i].UnitPrice * (decimal) part_purchase[i].Quantity);
                }
            }
            return moneySpentPerMonth;
        }


        // Tab Staff
        // Tab Staff
        // Tab Staff
        // Tab Staff
        // Tab Staff
        // Tab Staff

        private void cmbRoleSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStaffSearch_Click(sender, e);
        }


        private void txtStaffSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnStaffSearch_Click(sender, e);
            }
        }


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
            else if (StaffSearch != null && role == "All" || role == null)
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


        private void btnSortStaffID_Click(object sender, EventArgs e)
        {
            // Sort users by UserID
            users = users.OrderBy(u => u.UserID).ToList();
            btnStaffSearch_Click(sender, e);
        }


        private void btnSortStaffName_Click(object sender, EventArgs e)
        {
            // Sort users by Username
            users = users.OrderBy(u => u.Username).ToList();
            btnStaffSearch_Click(sender, e);
        }


        private void btnStaffDetail_Click(object sender, EventArgs e)
        {
            User user = (User)(sender as Button).Tag;
            StaffDetails formStaffDetails = new StaffDetails(user, this);
            formStaffDetails.Show();
        }


        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            StaffInsertion formStaffInsertion = new StaffInsertion(admin, this);
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


        private void txtServiceSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnServiceSearch_Click(sender, e);
            }
        }


        private void cmbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnServiceSearch_Click(sender, e);
        }


        // To filter the Result based on Search
        private void btnServiceSearch_Click(object sender, EventArgs e)
        {
            string service_type = null;
            if (cmbServiceType.SelectedItem != null && cmbServiceType.SelectedItem != "All")
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
            else if ((service_type == "All" || service_type == null) && serviceName != null)
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
            ServiceDetails formServiceDetails = new ServiceDetails(this, services);
            formServiceDetails.Show();
        }


        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            ServiceInsertion formServiceInsertion = new ServiceInsertion(this);
            formServiceInsertion.ShowDialog();
        }


        // Tab Feedback
        // Tab Feedback
        // Tab Feedback
        // Tab Feedback
        // Tab Feedback
        // Tab Feedback


        private void btnFeedbackSearch_Click(object sender, EventArgs e)
        {
            // Check if items are selected in both cmbHomeMonth and cmHomeYear
            if (cmbFeedbackMonth.SelectedItem == null && cmbFeedbackYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a year and a month before Searching", "Generating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbFeedbackMonth.SelectedItem == null)
            {
                MessageBox.Show("Please select a month before Generating", "Generating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check all inputs
            DateTime m = DateTime.ParseExact(cmbFeedbackMonth.Text, "MMMM", CultureInfo.InvariantCulture);
            string month = m.ToString("MM");
            string year = cmbFeedbackYear.SelectedItem.ToString();

            filter_datainFeedback(month, year);
        }


        private void btnFeedbackSortID_Click(object sender, EventArgs e)
        {
            // Sort feedback by ServiceOrderID
            serviceOrders = serviceOrders.OrderBy(o => o.ServiceOrderID).ToList();
            btnServiceSearch_Click(sender, e);
        }


        private void btnFeedbackSortName_Click(object sender, EventArgs e)
        {
            // Sort feedback by Username
            serviceOrders = serviceOrders.OrderBy(o => o.ServiceOrderID).ToList();
            serviceOrders = serviceOrders.OrderBy(o => o.Username).ToList();
            btnServiceSearch_Click(sender, e);
        }


        private void btnFeedbackSortDate_Click(object sender, EventArgs e)
        {
            // Sort feedback by Date
            serviceOrders = serviceOrders.OrderBy(o => o.ServiceOrderID).ToList();
            serviceOrders = serviceOrders.OrderBy(o => o.Username).ToList();
            btnServiceSearch_Click(sender, e);
        }


        private void btnFeedbackSortRating_Click(object sender, EventArgs e)
        {
            // Sort feedback by ServiceOrderID
            serviceOrders = serviceOrders.OrderBy(o => o.ServiceOrderID).ToList();
            serviceOrders = serviceOrders.OrderBy(o => o.Rating).ToList();
            btnServiceSearch_Click(sender, e);
        }


        private void btnFeedbackSortComment_Click(object sender, EventArgs e)
        {
            // Sort feedback by ServiceOrderID
            serviceOrders = serviceOrders
                .OrderByDescending(o => string.IsNullOrWhiteSpace(o.Feedback)) // Sort orders with feedback first
                .ThenBy(o => o.ServiceOrderID)  // Then sort by ServiceOrderID
                .ToList();
            btnServiceSearch_Click(sender, e);
        }


        private void btnFeedbackDetail_Click(object sender, EventArgs e)
        {
            ServiceOrder selectedServiceOrder = (ServiceOrder)(sender as Button).Tag;
            FeedbackDetails formFeedbackDetails = new FeedbackDetails(selectedServiceOrder);
            formFeedbackDetails.ShowDialog();
        }


        private void filter_datainFeedback(string month, string year)
        {
            Dictionary<int, int> ratings = new Dictionary<int, int>
            {
                { 5, 0 },
                { 4, 0 },
                { 3, 0 },
                { 2, 0 },
                { 1, 0 },
            };


            // Staff Salary Report
            // clear the data from tlpSalaryData
            tlpFeedbackData.Controls.Clear();
            tlpFeedbackData.RowCount = 1;

            int rowInsert = -1;
            for (int i = 0; i < serviceOrders.Count; i++)
            {
                if (serviceOrders[i].ArrivalDateTime.Year.ToString() == year &&
                    serviceOrders[i].ArrivalDateTime.Month.ToString() == month)
                {
                    if (ratings.ContainsKey(serviceOrders[i].Rating))
                    {
                        ratings[serviceOrders[i].Rating]++;
                    }
                    show_controlinTlpFeedback(serviceOrders[i], ref rowInsert);
                }
                continue;
            }

            Series feedbackSeries = crtFeedbackRating.Series[0];
            feedbackSeries.Points.Clear();

            int ratingNumber = 5;
            int totalRatingCount = 0;

            for (int i = 0; i < 5; i++)
            {
                int ratingStarCount = ratings[ratingNumber];
                feedbackSeries.Points.AddY(ratingStarCount);
                feedbackSeries.Points[i].LegendText = ratingNumber.ToString().Trim() + " Star:  " + ratingStarCount.ToString().Trim();
                //feedbackSeries.Points[i].IsValueShownAsLabel = true;
                totalRatingCount += ratingStarCount;
                ratingNumber--;
            }

            lblFeedbackTotal.Text = "Total: " + totalRatingCount.ToString().Trim();
            pnlFeedbackData.Visible = true;
            tlpFeedbackSortButton.Visible = true;
        }


        // Tab Salaries Record
        // Tab Salaries Record
        // Tab Salaries Record
        // Tab Salaries Record
        // Tab Salaries Record

        private void cmbSalaryMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSalaryRole.Enabled = true;
            txtSalarySearch.Enabled = true;
            users = users.OrderBy(o => o.UserID).ToList();
            filter_datainTlpSalaryData();
        }


        private void cmbSalaryRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            users = users.OrderBy(o => o.UserID).ToList();
            filter_datainTlpSalaryData();
        }


        private void txtSalarySearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filter_datainTlpSalaryData();
            }
        }


        private void btnSalarySortID_Click(object sender, EventArgs e)
        {
            users = users.OrderBy(o => o.UserID).ToList();
            filter_datainTlpSalaryData();
        }


        private void btnSalarySortName_Click(object sender, EventArgs e)
        {
            users = users.OrderBy(o => o.Username).ToList();
            filter_datainTlpSalaryData();
        }


        private void btnSalarySortRole_Click(object sender, EventArgs e)
        {
            users = users.OrderBy(o => o.UserID).ToList();
            users = users.OrderBy(o => o.Role).ToList();
            filter_datainTlpSalaryData();
        }


        private void btnSalarySortBaseSalary_Click(object sender, EventArgs e)
        {
            users = users.OrderBy(o => o.UserID).ToList();
            users = users.OrderByDescending(o => o.Salary).ToList();
            filter_datainTlpSalaryData();
        }


        private void btnStaffSalaryAdd_Click(object sender, EventArgs e)
        {
            User user = (User)(sender as Button).Tag;
            string month = cmbSalaryMonth.Text;
            string year = cmbSalaryYear.Text;
            StaffSalaryRecord record = new StaffSalaryRecord(user, month, year, this);
            record.ShowDialog();

        }


        public void filter_datainTlpSalaryData()
        {
            // check all inputs
            DateTime m = DateTime.ParseExact(cmbSalaryMonth.Text, "MMMM", CultureInfo.InvariantCulture);
            string month = m.ToString("MM");
            string year = cmbSalaryYear.SelectedItem.ToString();

            string role = null;
            if (cmbSalaryRole.SelectedItem != null && cmbSalaryRole.SelectedItem.ToString() != "All")
            {
                role = cmbSalaryRole.SelectedItem.ToString().Trim();
            }

            string search = null;
            if (txtSalarySearch.Text != "Search" && txtSalarySearch.Text != null)
            {
                search = txtSalarySearch.Text.ToString().ToLower().Trim();
            }

            // clear the data from tlpSalaryData
            tlpSalaryData.Controls.Clear();
            tlpSalaryData.RowCount = 1;


            int rowInsert = -1;
            for (int i = 0; i < users.Count; i++)
            {
                var payrollitem = payroll.Find(p => p.UserID == users[i].UserID && p.Month == month && p.Year == year);

                if (payrollitem != null)
                {
                    // Handle the scenario where matching payroll record is found
                    continue;
                };

                DateTime joinedDateTime = staffsalary.Find(ss => ss.UserID == users[i].UserID).JoinDateTime;

                if (joinedDateTime.Year > int.Parse(year))
                    continue;

                if (joinedDateTime.Month > DateTime.ParseExact(month, "MM", CultureInfo.InvariantCulture).Month)
                    continue;


                if (role != null && search != null)
                {
                    if (users[i].Role == role &&
                        (users[i].UserID.ToLower().Contains(search) ||
                         users[i].Username.ToLower().Contains(search)))
                    {
                        show_controlinTlpSalaryData(users[i], ref rowInsert);
                    }
                }
                else if (role != null && search == null)
                {
                    if (users[i].Role == role)
                    {
                        // Call show_control with the user and rowinsert
                        show_controlinTlpSalaryData(users[i], ref rowInsert);
                    }
                }
                else if (role == null && search != null)
                {
                    if (users[i].UserID.ToLower().Contains(search) ||
                            users[i].Username.ToLower().Contains(search))
                    {
                        show_controlinTlpSalaryData(users[i], ref rowInsert);
                    }
                }
                else if (search == null && role == null)
                {
                    // Call show_control with the user and rowinsert
                    show_controlinTlpSalaryData(users[i], ref rowInsert);
                }
            }
        }


        // Tab Reports
        // Tab Reports
        // Tab Reports
        // Tab Reports
        // Tab Reports

        private void btnReportSearch_Click(object sender, EventArgs e)
        {
            // Check if items are selected in both cmbReportMonth and cmReportYear
            if (cmbReportMonth.SelectedItem == null && cmbReportYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a year and a month before Searching", "Generating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbReportMonth.SelectedItem == null)
            {
                MessageBox.Show("Please select a month before Generating", "Generating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check all inputs
            DateTime m = DateTime.ParseExact(cmbReportMonth.Text, "MMMM", CultureInfo.InvariantCulture);
            string month = m.ToString("MM");
            string year = cmbReportYear.SelectedItem.ToString();


            decimal Revenue = filter_datainServiceReport(month, year);
            decimal Salary_cost = filter_datainStaffSalaryReport(month, year);
            decimal CaE_cost = filter_datainCaEReport(month, year);
            decimal Total_cost = Salary_cost + CaE_cost;
            decimal Final_profit = Revenue - Total_cost;


            lblReportCost.Text = Total_cost.ToString("C2");
            lblReportProfit.Text = Final_profit.ToString("C2");
            lblReportFinalProfit.Text = Final_profit.ToString("C2");
        }


        private decimal filter_datainServiceReport(string month, string year)
        {
            decimal RevenuePerMonth = 0;
            int no_of_service = 0;


            // Service Report
            // clear the data from tlpServiceReportData
            tlpServiceReportData.Controls.Clear();
            tlpServiceReportData.RowCount = 1;

            int rowInsert = -1;
            for (int i = 0; i < serviceOrders.Count; i++)
            {
                if (serviceOrders[i].ArrivalDateTime.ToString("yyyy") == year && serviceOrders[i].ArrivalDateTime.ToString("MM") == month)
                {
                    RevenuePerMonth += serviceOrders[i].TotalPrice;
                    no_of_service++;
                    show_controlinTlpServiceReportData(serviceOrders[i], ref rowInsert);
                }
            }

            tlpServiceReportSortButton.Visible = true;
            pnlServiceReport.Visible = true;

            lblReportNumOfService.Text = no_of_service.ToString();
            lblReportRevenue.Text = RevenuePerMonth.ToString("C2");
            lblReportServiceRevenue.Text = RevenuePerMonth.ToString("C2");
            lblServiceRevenueTotal.Text = RevenuePerMonth.ToString("C2");

            return RevenuePerMonth;
        }


        private decimal filter_datainCaEReport(string month, string year)
        {
            decimal PartCostPerMonth = 0;


            // Service Report
            // clear the data from tlpServiceReportData
            tlpCaEData.Controls.Clear();
            tlpCaEData.RowCount = 1;

            int rowInsert = -1;
            for (int i = 0; i < part_purchase.Count; i++)
            {
                if (part_purchase[i].DateTime.ToString("yyyy") == year && part_purchase[i].DateTime.ToString("MM") == month)
                {
                    PartCostPerMonth += (part_purchase[i].UnitPrice * part_purchase[i].Quantity);
                    show_controlinTlpCaEData(part_purchase[i], ref rowInsert);
                }
            }


            lblReportCostAndExpenses.Text = PartCostPerMonth.ToString("C2");
            lblCaETotal.Text = PartCostPerMonth.ToString("C2");

            tlpCostAndExpensesSortButton.Visible = true;
            tlpCaEData.Visible = true;
            pnlCaE.Visible = true;

            return PartCostPerMonth;
        }


        private decimal filter_datainStaffSalaryReport(string month, string year)
        {
            int SalaryPerMonth = 0;


            // Staff Salary Report
            // clear the data from tlpSalaryData
            tlpStaffSalaryReportData.Controls.Clear();
            tlpStaffSalaryReportData.RowCount = 1;

            int rowInsert = -1;
            for (int i = 0; i < payroll.Count; i++)
            {
                if (payroll[i].Year == year && payroll[i].Month == month)
                {
                    SalaryPerMonth += payroll[i].Amount;
                    show_controlinTlpStaffSalaryReport(payroll[i], ref rowInsert);
                    continue;
                }
            }
            lblStaffSalaryTotal.Text = SalaryPerMonth.ToString("C2");
            lblReportStaffSalaryCost.Text = SalaryPerMonth.ToString("C2");
            tlpStaffSalaryReportSortButton.Visible = true;
            pnlStaffSalaryReport.Visible = true;
            return SalaryPerMonth;
        }


        private void btnServiceReportSortSOID_Click(object sender, EventArgs e)
        {
            serviceOrders = serviceOrders.OrderBy(s => s.ServiceOrderID).ToList();
            btnReportSearch_Click(sender, e);
        }


        private void btnServiceReportSortDate_Click(object sender, EventArgs e)
        {
            serviceOrders = serviceOrders.OrderByDescending(s => s.ArrivalDateTime).ToList();
            btnReportSearch_Click(sender, e);
        }


        private void btnServiceReportSortPrice_Click(object sender, EventArgs e)
        {
            serviceOrders = serviceOrders.OrderBy(s => s.TotalPrice).ToList();
            btnReportSearch_Click(sender, e);
        }


        private void btnCaEID_Click(object sender, EventArgs e)
        {
            part_purchase = part_purchase.OrderBy(pp => pp.PartID).ToList();
            btnReportSearch_Click(sender, e);
        }


        private void btnCaEDate_Click(object sender, EventArgs e)
        {
            part_purchase = part_purchase.OrderBy(pp => pp.DateTime).ToList();
            btnReportSearch_Click(sender, e);
        }


        private void btnCaEPrice_Click(object sender, EventArgs e)
        {
            part_purchase = part_purchase.OrderByDescending(pp => (pp.UnitPrice * pp.Quantity)).ToList();
            btnReportSearch_Click(sender, e);
        }


        private void btnSSRID_Click(object sender, EventArgs e)
        {
            payroll = payroll.OrderBy(x => x.UserID).ToList();
            btnReportSearch_Click(sender, e);
        }


        private void btnSSRName_Click(object sender, EventArgs e)
        {
            payroll = payroll.OrderBy(x => x.Username).ToList();
            btnReportSearch_Click(sender, e);
        }


        private void btnSSRPrice_Click(object sender, EventArgs e)
        {
            payroll = payroll.OrderByDescending(x => x.Amount).ToList();
            btnReportSearch_Click(sender, e);
        }


        private void btnServiceReportDetail_Click(object sender, EventArgs e)
        {
            ServiceOrder serviceOrder = (ServiceOrder)(sender as Button).Tag;
            frmOrderDetails frmOrderDetails = new frmOrderDetails(serviceOrder);
            frmOrderDetails.Show();
        }

        private void btnCaEDetail_Click(object sender, EventArgs e)
        {
            Parts.Purchases purchases = (Parts.Purchases)(sender as Button).Tag;
            PartPurchasedDetails partPuchaseDetail = new PartPurchasedDetails(purchases);
            partPuchaseDetail.Show();
        }



        private void btnStaffSalaryDetail_Click(Object sender, EventArgs e)
        {
            User.StaffSalary.Payroll payroll = (User.StaffSalary.Payroll)(sender as Button).Tag;
            StaffSalaryDetails details = new StaffSalaryDetails(payroll);
            details.Show();
        }









        // Profile
        // Profile
        // Profile
        // Profile
        // Profile


        private void btnChangeUserName_Click(object sender, EventArgs e)
        {
            frmChangeUserName frmChangeUserName = new frmChangeUserName(admin);
            frmChangeUserName.ShowDialog();
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            frmChangeEmail frmChangeEmail = new frmChangeEmail(admin);
            frmChangeEmail.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(admin);
            frmChangePassword.ShowDialog();
        }
    }

}