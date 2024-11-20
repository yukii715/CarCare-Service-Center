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

namespace CarCare_Service_Center
{
    public partial class frmAssignConfirmation : Form
    {
        private Appointment appointment;
        private frmMechanicAvailability frmMechanicAvailability;
        private frmRequestedAppointment frmRequestedAppointment;
        private string mechanicID;
        public frmAssignConfirmation(Appointment appointment, frmMechanicAvailability frmMechanicAvailability, frmRequestedAppointment frmRequestedAppointment, string mechanicID, string mechanicName)
        {
            InitializeComponent();
            this.appointment = appointment;
            this.frmMechanicAvailability = frmMechanicAvailability;
            this.frmRequestedAppointment = frmRequestedAppointment;
            this.mechanicID = mechanicID;
            lblMessage.Text = $"Are you sure to assign this appointment to {mechanicName}?" ;
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            Mechanic.MechanicTasks mechanicTasks = new Mechanic.MechanicTasks
            {
                UserID = mechanicID,
                AppointmentID = appointment.AppointmentID
            };
            mechanicTasks.ADD();
            appointment.Status = "Accepted";
            appointment.UpdateStatus("Accepted");
            MessageBox.Show("Assign Successfully!");
            frmRequestedAppointment.LoadDetails(appointment);
            frmMechanicAvailability.Close();
            Close();
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
