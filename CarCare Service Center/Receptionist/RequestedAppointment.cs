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
using static CarCare_Service_Center.Appointment;
using Users;

namespace CarCare_Service_Center
{
    public partial class frmRequestedAppointment : Form
    {
        private Appointment Appointment;
        private frmReceptionistMain frmReceptionistMain;
        private List<User> user;
        private List<Services> services;
        private List<Appointment.Services> appointment_services;
        public frmRequestedAppointment(Appointment appointment, frmReceptionistMain frmReceptionistMain)
        {
            InitializeComponent();
            Text = appointment.AppointmentID;
            Appointment = appointment;
            this.frmReceptionistMain = frmReceptionistMain;
            FormClosed += Form_Closed;
        }
        private void RequestedAppointment_Load(object sender, EventArgs e)
        {
            LoadDetails(Appointment);
            lblButtomMargin.Text = string.Empty;
        }
        public void LoadDetails(Appointment appointment)
        {
            string query = "SELECT * FROM Users WHERE Role = 'Customer'";
            user = Database.FetchData<User>(query);

            tlpServices.Controls.Clear();
            lblUserID.Text = appointment.UserID;
            lblUsername.Text = user.Find(u => u.UserID == appointment.UserID).Username;
            lblDate.Text = appointment.AppointmentDateTime.ToString("yyyy-MM-dd dddd");
            lblTime.Text = appointment.AppointmentDateTime.ToString("hh:mm tt");
            lblVehicleNumber.Text = appointment.VehicleNumber;
            ShowServices();

            if (appointment.Status == "Rejected" || appointment.Status == "Accepted")
            {
                btnAssignToMechanic.Visible = false;
                btnReject.Visible = false;
            }
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
        private void btnAssignToMechanic_Click(object sender, EventArgs e)
        {
            frmMechanicAvailability frmMechanicAvailability = new frmMechanicAvailability(Appointment, this);
            frmMechanicAvailability.ShowDialog();
        }
        private void btnReject_Click(object sender, EventArgs e)
        {
            frmRejectConfirmation rejectConfirmation = new frmRejectConfirmation(Appointment, this);
            rejectConfirmation.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            Form_Closed(sender, e);
        }
        private void Form_Closed(object sender, EventArgs e)
        {
            var controlsToRemove = new List<Control>();

            foreach (Control ctrl in frmReceptionistMain.tblAppointmentRequests.Controls)
            {
                if (ctrl.Name != "lblAptID" && ctrl.Name != "lblAptTime" && ctrl.Name != "lblAptUsername" && ctrl.Name != "lblAptVehicleNum")
                {
                    controlsToRemove.Add(ctrl);
                }
            }

            // Now remove controls from pnlMyAppointment
            foreach (var ctrl in controlsToRemove)
            {
                frmReceptionistMain.tblAppointmentRequests.Controls.Remove(ctrl);
            }
            frmReceptionistMain.LoadAppointmentRequests();
        }
    }
}
