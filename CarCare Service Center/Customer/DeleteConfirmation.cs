using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCare_Service_Center
{
    public partial class frmDeleteConfirmation : Form
    {
        private Appointment appointment;
        private frmAppointmentDetails frmAppointmentDetails;
        public frmDeleteConfirmation(Appointment appointment, frmAppointmentDetails frmAppointmentDetails)
        {
            InitializeComponent();
            this.appointment = appointment;
            Text = this.appointment.AppointmentID;
            this.frmAppointmentDetails = frmAppointmentDetails;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            appointment.Status = "Cancelled";
            appointment.UpdateStatus("Cancelled");
            frmAppointmentDetails.LoadDetails(appointment);
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
