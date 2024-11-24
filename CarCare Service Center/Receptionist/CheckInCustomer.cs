using Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;
using static CarCare_Service_Center.Parts;

namespace CarCare_Service_Center
{
    public partial class frmCheckInCustomer : Form
    {
        private Appointment Appointment;
        private frmReceptionistMain frmReceptionistMain;
        private List<User> user;
        private List<Services> services;
        private List<Appointment.Services> appointment_services;
        public frmCheckInCustomer(Appointment appointment, frmReceptionistMain frmReceptionistMain)
        {
            InitializeComponent();
            Text = appointment.AppointmentID;
            Appointment = appointment;
            this.frmReceptionistMain = frmReceptionistMain;
            FormClosed += Form_Closed;
        }
        private void frmCheckInCustomer_Load(object sender, EventArgs e)
        {
            LoadDetails();
            lblButtomMargin.Text = string.Empty;
        }
        public void LoadDetails()
        {
            string query = "SELECT * FROM Users WHERE Role = 'Customer'";
            user = Database.FetchData<User>(query);

            tlpServices.Controls.Clear();
            lblUserID.Text = Appointment.UserID;
            lblUsername.Text = user.Find(u => u.UserID == Appointment.UserID).Username;
            lblDate.Text = Appointment.AppointmentDateTime.ToString("yyyy-MM-dd dddd");
            lblTime.Text = Appointment.AppointmentDateTime.ToString("hh:mm tt");
            lblVehicleNumber.Text = Appointment.VehicleNumber;
            ShowServices();
        }
        private void ShowServices()
        {
            string query_appointment_services = "SELECT * FROM AppointmentServices WHERE AppointmentID = " + $"'{Appointment.AppointmentID}' ORDER BY CAST(RIGHT(ServiceID, 3) AS INT)";
            appointment_services = Database.FetchData<Appointment.Services>(query_appointment_services);

            string query_services = "SELECT * FROM Services";
            services = Database.FetchData<Services>(query_services);

            for (int i = 0; i < appointment_services.Count; i++)
            {
                Label Note = new Label
                {
                    Text = (i + 1).ToString() + ".",
                    Font = new Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill
                };
                tlpServices.Controls.Add(Note, 0, i);
                Label ServiceID = new Label
                {
                    Text = appointment_services[i].ServiceID,
                    Font = new Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill
                };
                tlpServices.Controls.Add(ServiceID, 1, i);
                Label ServiceName = new Label
                {
                    Text = services.Find(s => s.ServiceID == appointment_services[i].ServiceID).ServiceName.Trim(),
                    Font = new Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill
                };
                tlpServices.Controls.Add(ServiceName, 2, i);

                if (i > 2)
                {
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl.Top > tlpServices.Bottom)
                        {
                            ctrl.Top += tlpServices.GetRowHeights()[0];
                        }
                    }
                }
            }
            tlpServices.RowCount = appointment_services.Count();

        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure to check in Appointment {Appointment.AppointmentID}?\nClient Name: {lblUsername.Text}", "Check In Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Appointment.UpdateStatus("CheckedIn");

                Mechanic.MechanicTasks mechanicTasks = new Mechanic.MechanicTasks {AppointmentID = Appointment.AppointmentID};
                mechanicTasks.StartProgress();

                var serviceOrder = new Services.ServiceOrder
                {
                    AppointmentID = Appointment.AppointmentID,
                    ArrivalDateTime = DateTime.Now
                };
                serviceOrder.ServiceOrderID = serviceOrder.GenerateServiceOrderID();
                serviceOrder.Add();

                foreach (var service in appointment_services)
                {
                    var serviceEntry = new Services.ServiceOrder.ServiceEntry
                    {
                        ServiceOrderID = serviceOrder.ServiceOrderID,
                        ServiceID = service.ServiceID,
                    };
                    serviceEntry.ServiceEntryID = serviceEntry.GenerateServiceEntryID();
                    serviceEntry.Add();
                }

                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form_Closed(object sender, EventArgs e)
        {
            frmReceptionistMain.LoadUpcomingAppointments();
            frmReceptionistMain.LoadCheckedInAppointments();
        }
    }
}
