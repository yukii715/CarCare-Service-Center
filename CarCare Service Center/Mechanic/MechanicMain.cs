using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ControlSetting;
using Functions;
using Users;
using static CarCare_Service_Center.Appointment;
using static Users.Mechanic;

namespace CarCare_Service_Center
{
    public partial class frmMechanicMain : Form
    {
        private List<Label> progressNotes = new List<Label>();
        private List<Label> progressServiceNames = new List<Label>();
        private Mechanic mechanic;
        private List<MechanicTasks> mechanic_task;
        private List<Appointment> appointments;
        private List<User> users;
        private List<Appointment.Services> appointment_service;
        private List<Services> services;
        private List<MechanicTasks> ServiceProgress;
        private List<Services> ServiceInProgress = new List<Services>();
        private List<Appointment.Services> CustomerService;
        public frmMechanicMain(Mechanic mec)
        {
            InitializeComponent();
            mechanic = mec;
            sessionStartTime = DateTime.Now;
            timer1.Start();
        }
        private DateTime sessionStartTime;


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH:mm:ss");
            TimeSpan sessionDuration = DateTime.Now - sessionStartTime;
            lblCurrenttime.Text = sessionDuration.ToString(@"hh\:mm\:ss");
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            tabMechanic.SelectedTab = tabPage2;
        }


        public void updateProfile(string name, string mail)
        {
            nameProfileChange.Text = name;
            mailProfileChange.Text = mail;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Request requestform = new Request(mechanic);
            requestform.ShowDialog();
        }

        private void btnShortages_Click(object sender, EventArgs e)
        {
            Shortages shortagesform = new Shortages();
            shortagesform.ShowDialog();
        }

        private void frmMechanicMain_Load(object sender, EventArgs e)
        {
            tabMechanic.DrawItem += Draw_Item.tabControlAdjustment;

            string query_MechanicTasks = "SELECT * FROM MechanicTasks WHERE InProgress IS NULL AND UserID = " + $"'{mechanic.UserID}'";
            mechanic_task = Database.FetchData<MechanicTasks>(query_MechanicTasks);

            string query_Appointments = "SELECT * FROM Appointments WHERE Status = 'Accepted'";
            appointments = Database.FetchData<Appointment>(query_Appointments);

            string query_Users = "SELECT * FROM Users WHERE IsDeleted = 0";
            users = Database.FetchData<User>(query_Users);

            string query_AppointmentServices = "SELECT * FROM AppointmentServices";
            appointment_service = Database.FetchData<Appointment.Services>(query_AppointmentServices);

            string query_Services = "SELECT * FROM Services";
            services = Database.FetchData<Services>(query_Services);
            LoadMechanicTasks();

            string query_ServiceProgress = "SELECT * FROM MechanicTasks WHERE InProgress = 1 AND UserID = " + $"'{mechanic.UserID}'";
            ServiceProgress = Database.FetchData<MechanicTasks>(query_ServiceProgress);
            ServiceProgress_load();

            string query = "SELECT DISTINCT ServiceType FROM Services";
            Database.LoadIntoComboBox(cmbServiceType, query, "ServiceType");
        }

        private void LoadMechanicTasks()
        {
            for (int i = 0; i < mechanic_task.Count; i++)
            {
                int rowheight = 29 * appointment_service.FindAll(apts => apts.AppointmentID == mechanic_task[i].AppointmentID).Count;
                tlpServiceTask.RowStyles.Add(new RowStyle(SizeType.Absolute, rowheight));
                tlpServiceTask.Height += rowheight + 5;

                Label NOTE = new Label();
                NOTE.Text = (i + 1).ToString();
                tlpServiceTask.Controls.Add(NOTE, 0, i + 1);
                NOTE.Dock = DockStyle.Fill;
                NOTE.TextAlign = ContentAlignment.MiddleLeft;

                Label CustomerName = new Label();
                CustomerName.Text = users.Find(u => u.UserID == appointments.Find(a => a.AppointmentID == mechanic_task[i].AppointmentID).UserID).Username;
                tlpServiceTask.Controls.Add(CustomerName, 1, i + 1);
                CustomerName.Dock = DockStyle.Fill;
                CustomerName.TextAlign = ContentAlignment.MiddleLeft;

                Label ServiceName = new Label();
                appointment_service.FindAll(apts => apts.AppointmentID == mechanic_task[i].AppointmentID).ForEach(service => ServiceName.Text += services.Find(s => s.ServiceID == service.ServiceID).ServiceName.Trim() + "\n");
                ServiceName.Text = ServiceName.Text.Substring(0, ServiceName.Text.Length - 1);
                tlpServiceTask.Controls.Add(ServiceName, 2, i + 1);
                ServiceName.Dock = DockStyle.Fill;
                ServiceName.TextAlign = ContentAlignment.MiddleLeft;

                Label ServiceDate = new Label();
                ServiceDate.Text = appointments.Find(a => a.AppointmentID == mechanic_task[i].AppointmentID).AppointmentDateTime.ToString("yyyy-MM-dd");
                tlpServiceTask.Controls.Add(ServiceDate, 3, i + 1);
                ServiceDate.Dock = DockStyle.Fill;
                ServiceDate.TextAlign = ContentAlignment.MiddleLeft;

                Label ServiceTime = new Label();
                ServiceTime.Text = appointments.Find(a => a.AppointmentID == mechanic_task[i].AppointmentID).AppointmentDateTime.ToString("HH:mm");
                tlpServiceTask.Controls.Add(ServiceTime, 4, i + 1);
                ServiceTime.Dock = DockStyle.Fill;
                ServiceTime.TextAlign = ContentAlignment.MiddleLeft;
            }
            tlpServiceTask.RowCount = mechanic_task.Count + 1;
        }

        private void ServiceProgress_load()
        {
            if (ServiceProgress.Count == 0)
                return;
            lblAppointmentId.Text = ServiceProgress[0].AppointmentID;
            lblAppointmentId.Dock = DockStyle.Fill;
            lblAppointmentId.TextAlign = ContentAlignment.MiddleLeft;

            lblUserId.Text = appointments.Find(a => a.AppointmentID == ServiceProgress[0].AppointmentID).UserID;
            lblUserId.Dock = DockStyle.Fill;
            lblUserId.TextAlign = ContentAlignment.MiddleLeft;

            lblProgressName.Text = users.Find(u => u.UserID == appointments.Find(a => a.AppointmentID == ServiceProgress[0].AppointmentID).UserID).Username;
            lblProgressName.Dock = DockStyle.Fill;
            lblProgressName.TextAlign = ContentAlignment.MiddleLeft;

            lblProgressPlateNumber.Text = appointments.Find(a => a.AppointmentID == ServiceProgress[0].AppointmentID).VehicleNumber;
            lblProgressPlateNumber.Dock = DockStyle.Fill;
            lblProgressPlateNumber.TextAlign = ContentAlignment.MiddleLeft;

            string query_CustomerService = "SELECT * FROM AppointmentServices WHERE AppointmentID = " + $"'{lblAppointmentId.Text}'";
            CustomerService = Database.FetchData<Appointment.Services>(query_CustomerService);

            for (int i = 0; i < CustomerService.Count; i++)

            {
                Label ProgressNote = new Label();
                ProgressNote.Text = (i + 1).ToString();
                tlpServiceProgress.Controls.Add(ProgressNote, 0, i + 1);
                ProgressNote.Dock = DockStyle.Fill;
                ProgressNote.TextAlign = ContentAlignment.MiddleLeft;

                Label ProgressServiceName = new Label();
                ProgressServiceName.Text = services.Find(s => s.ServiceID == CustomerService[i].ServiceID).ServiceName;
                tlpServiceProgress.Controls.Add(ProgressServiceName, 1, i + 1);
                ProgressServiceName.Dock = DockStyle.Fill;
                ProgressServiceName.TextAlign = ContentAlignment.MiddleLeft;

                progressNotes.Add(ProgressNote);
                progressServiceNames.Add(ProgressServiceName);


                ProgressNote.MouseEnter += (s, ev) =>
                {
                    ProgressNote.BackColor = Color.Ivory;
                    ProgressServiceName.BackColor = Color.Ivory;
                };
                ProgressNote.MouseLeave += (s, ev) =>
                {

                    if (ProgressNote.BackColor != Color.PapayaWhip)
                    {
                        ProgressNote.BackColor = Color.Transparent;
                        ProgressServiceName.BackColor = Color.Transparent;
                    }
                };
                ProgressNote.MouseDown += (s, ev) =>
                {
                    ProgressNote.BackColor = Color.PeachPuff;
                    ProgressServiceName.BackColor = Color.PeachPuff;
                };

                ProgressNote.MouseUp += (s, ev) =>
                {
                    ProgressNote.BackColor = Color.Transparent;
                    ProgressServiceName.BackColor = Color.Transparent;
                };


                ProgressServiceName.MouseEnter += (s, ev) =>
                {

                    ProgressNote.BackColor = Color.Ivory;
                    ProgressServiceName.BackColor = Color.Ivory;

                };

                ProgressServiceName.MouseLeave += (s, ev) =>
                {
                    if (ProgressServiceName.BackColor != Color.PapayaWhip)
                    {
                        ProgressNote.BackColor = Color.Transparent;
                        ProgressServiceName.BackColor = Color.Transparent;
                    }

                };
                ProgressServiceName.MouseDown += (s, ev) =>
                {
                    ProgressNote.BackColor = Color.PeachPuff;
                    ProgressServiceName.BackColor = Color.PeachPuff;
                };

                ProgressServiceName.MouseUp += (s, ev) =>
                {
                    ProgressNote.BackColor = Color.Transparent;
                    ProgressServiceName.BackColor = Color.Transparent;
                };
            }
            tlpServiceProgress.RowCount = CustomerService.Count;
        }
        private void btnStartTask_Click_1(object sender, EventArgs e)
        {
            if (ServiceProgress.Count == 0)
            {
                MessageBox.Show("No Service is assigned to you now", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            grbAddService.Visible = true;
            lblRemark.Visible = true;
            txtRemark.Visible = true;
            btnEndTask.Visible = true;
            btnStartTask.Visible = false;

            foreach (var progressNote in progressNotes)
            {
                progressNote.Click += (s, _) => OpenProgressForm(progressNote.Text);
            }

            foreach (var progressServiceName in progressServiceNames)
            {
                progressServiceName.Click += (s, _) => OpenProgressForm(progressServiceName.Text);
            }

            appointment_service.FindAll(apts => apts.AppointmentID == ServiceProgress[0].AppointmentID).ForEach(service => ServiceInProgress.Add(services.Find(s => s.ServiceID == service.ServiceID)));

            PropertyInfo service_type = typeof(Services).GetProperty("ServiceType");
            PropertyInfo service_name = typeof(Services).GetProperty("ServiceName");
            ComboBoxSetting.SetUpDependentComboBox<Services>(cmbServiceType, cmbService, services, service_type, service_name, ServiceInProgress);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var service = new Appointment.Services
            {
                AppointmentID = lblAppointmentId.Text,
                ServiceID = services.Find(s => s.ServiceName == cmbService.Text).ServiceID,
            };

            CustomerService.Add(service);

            int count = CustomerService.Count;

            Label ProgressNote = new Label();
            ProgressNote.Text = count.ToString();
            tlpServiceProgress.Controls.Add(ProgressNote, 0, count);
            ProgressNote.Dock = DockStyle.Fill;
            ProgressNote.TextAlign = ContentAlignment.MiddleLeft;

            Label ProgressServiceName = new Label();
            ProgressServiceName.Text = services.Find(s => s.ServiceID == CustomerService[count - 1].ServiceID).ServiceName;
            tlpServiceProgress.Controls.Add(ProgressServiceName, 1, count);
            ProgressServiceName.Dock = DockStyle.Fill;
            ProgressServiceName.TextAlign = ContentAlignment.MiddleLeft;

            ProgressNote.MouseEnter += (s, ev) =>
            {

                ProgressNote.BackColor = Color.Ivory;
                ProgressServiceName.BackColor = Color.Ivory;
            };


            ProgressNote.MouseLeave += (s, ev) =>
            {
                if (ProgressNote.BackColor != Color.PapayaWhip)
                {
                    ProgressNote.BackColor = Color.Transparent;
                    ProgressServiceName.BackColor = Color.Transparent;
                }
            };
            ProgressNote.MouseDown += (s, ev) =>
            {
                ProgressNote.BackColor = Color.PeachPuff;
                ProgressServiceName.BackColor = Color.PeachPuff;
            };


            ProgressNote.MouseUp += (s, ev) =>
            {
                ProgressNote.BackColor = Color.Transparent;
                ProgressServiceName.BackColor = Color.Transparent;
            };


            ProgressServiceName.MouseEnter += (s, ev) =>
            {
                ProgressNote.BackColor = Color.Ivory;
                ProgressServiceName.BackColor = Color.Ivory;
            };

            ProgressServiceName.MouseLeave += (s, ev) =>
            {
                if (ProgressServiceName.BackColor != Color.PapayaWhip)
                {
                    ProgressNote.BackColor = Color.Transparent;
                    ProgressServiceName.BackColor = Color.Transparent;
                }
            };
            ProgressServiceName.MouseDown += (s, ev) =>
            {
                ProgressNote.BackColor = Color.PeachPuff;
                ProgressServiceName.BackColor = Color.PeachPuff;
            };


            ProgressServiceName.MouseUp += (s, ev) =>
            {
                ProgressNote.BackColor = Color.Transparent;
                ProgressServiceName.BackColor = Color.Transparent;
            };


            ProgressNote.Click += (s, _) => OpenProgressForm(ProgressNote.Text);
            ProgressServiceName.Click += (s, _) => OpenProgressForm(ProgressServiceName.Text);


            tlpServiceProgress.RowCount = count;

            foreach (Control ctrl in panelServiceProgress.Controls)
            {
                if (ctrl.Top > tlpServiceProgress.Bottom)
                {
                    ctrl.Top += tlpServiceProgress.GetRowHeights()[0];
                }
            }
            if (cmbService.Items.Count == 0)
            {
                cmbService.Enabled = false;
            }


            else
            {
                MessageBox.Show("Please Select Service Type and Service！");
            }
        }
        private void OpenProgressForm(string selectedService)
        {
            Progress progressfrm = new Progress();
            progressfrm.AppointmentId = lblAppointmentId.Text;
            progressfrm.UserId = lblUserId.Text;
            progressfrm.UserName = lblProgressName.Text;
            progressfrm.PlateNumber = lblProgressPlateNumber.Text;
            progressfrm.ShowDialog();
        }


        private void btnEndTask_Click(object sender, EventArgs e)
        {

        }

        public void BackToTab3()
        {
            tabMechanic.SelectedIndex = 3;
        }
        //
        // Profile
        //
        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogoutConfirmation frmLogoutConfirmation = new frmLogoutConfirmation(this);
            frmLogoutConfirmation.ShowDialog();
        }
    }
}