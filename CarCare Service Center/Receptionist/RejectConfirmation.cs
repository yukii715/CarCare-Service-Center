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
    public partial class frmRejectConfirmation : Form
    {
        private Appointment Appointment;
        private frmRequestedAppointment RequestedAppointment;
        public frmRejectConfirmation(Appointment appointment, frmRequestedAppointment requestedAppointment)
        {
            InitializeComponent();
            Appointment = appointment;
            RequestedAppointment = requestedAppointment;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Appointment.Status = "Rejected";
            Appointment.UpdateStatus("Rejected");
            RequestedAppointment.LoadDetails(Appointment);
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
