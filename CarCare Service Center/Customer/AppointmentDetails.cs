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
using System.Globalization;
using Users;
using ControlSetting;

namespace CarCare_Service_Center
{
    public partial class frmAppointmentDetails : Form
    {
        private Appointment Appointment;
        private List<Appointment.Services> appointment_services;
        private List<Services> services;
        private frmCustomerMain customerMain;
        public frmAppointmentDetails(Appointment appointment, frmCustomerMain frmCustomerMain)
        {
            InitializeComponent();
            Appointment = appointment;
            Text = Appointment.AppointmentID;
            customerMain = frmCustomerMain;
            FormClosed += Form_Closed;
        }
        private void frmAppointmentDetails_Load(object sender, EventArgs e)
        {
            LoadDetails(Appointment);
        }
        public void LoadDetails(Appointment appointment)
        {
            tlpServices.Controls.Clear();
            lblAptID.Text = appointment.AppointmentID;
            lblMkDate.Text = appointment.MakingDateTime.ToString("yyyy-MM-dd");
            lblMkTime.Text = appointment.MakingDateTime.ToString("hh:mm tt");
            lblAptDate.Text = appointment.AppointmentDateTime.ToString("yyyy-MM-dd dddd");
            lblAptTime.Text = appointment.AppointmentDateTime.ToString("hh:mm tt");
            lblVehicleNum.Text = appointment.VehicleNumber;
            ShowServices();

            if (appointment.Status != "Pending")
                btnModify.Visible = false;
            if (appointment.Status != "Pending" && appointment.Status != "Accepted")
                btnDelete.Visible = false;
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
                    Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill
                };
                tlpServices.Controls.Add(Note, 0, i);
                Label ServiceID = new Label
                {
                    Text = appointment_services[i].ServiceID,
                    Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill
                };
                tlpServices.Controls.Add (ServiceID, 1, i);
                Label ServiceName = new Label 
                {
                    Text = services.Find(s => s.ServiceID == appointment_services[i].ServiceID).ServiceName.Trim(),
                    Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill
                };
                tlpServices.Controls.Add (ServiceName, 2, i);

                if (i > 2)
                {
                    foreach (Control ctrl in pnlAppointmentDetails.Controls)
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Form_Closed(sender, e);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var NewControls = new List <Control>();
            lblAptDate.Visible = false;
            lblAptTime.Visible = false;
            lblVehicleNum.Visible = false;
            btnModify.Visible = false;
            btnDelete.Visible = false;
            btnClose.Visible = false;

            string date_format = "yyyy-MM-dd dddd";
            string time_format = "hh:ss tt";

            DateTime AptDate = DateTime.ParseExact(lblAptDate.Text, date_format, CultureInfo.InvariantCulture);
            DateTime AptTime = DateTime.ParseExact(lblAptTime.Text, time_format, CultureInfo.InvariantCulture);

            ComboBox cmbYear = new ComboBox 
            {
                Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                Location = lblAptDate.Location,
                Size = new Size(60, Height)
            };
            pnlAppointmentDetails.Controls.Add(cmbYear);
            NewControls.Add(cmbYear);

            Label Slash1 = new Label
            {
                Text = @"\",
                Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                Location = new Point(cmbYear.Location.X + cmbYear.Width + 5, lblAptDate.Location.Y),
                AutoSize = true
            };
            pnlAppointmentDetails.Controls.Add(Slash1);
            NewControls.Add(Slash1);

            ComboBox cmbMonth = new ComboBox
            {
                Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                Location = new Point(Slash1.Location.X + Slash1.Width + 5, lblAptDate.Location.Y),
                Size = new Size(60, Height)
            };
            pnlAppointmentDetails.Controls.Add(cmbMonth);
            NewControls.Add(cmbMonth);

            Label Slash2 = new Label
            {
                Text = @"\",
                Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                Location = new Point(cmbMonth.Location.X + cmbMonth.Width + 5, lblAptDate.Location.Y),
                AutoSize = true
            };
            pnlAppointmentDetails.Controls.Add(Slash2);
            NewControls.Add(Slash2);

            ComboBox cmbDay = new ComboBox 
            {
                Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                Location = new Point(Slash2.Location.X + Slash2.Width + 5, lblAptDate.Location.Y),
                Size = new Size(60, Height)
            };
            pnlAppointmentDetails.Controls.Add(cmbDay);
            NewControls.Add(cmbDay);

            ComboBoxSetting.SetupYearMonthDayComboBoxes(cmbYear, cmbMonth, cmbDay);
            ComboBoxSetting.Set(cmbMonth);
            ComboBoxSetting.Set(cmbDay);

            cmbYear.SelectedItem = int.Parse(AptDate.ToString("yyyy"));
            cmbMonth.SelectedItem = int.Parse(AptDate.ToString("MM"));
            cmbDay.SelectedItem = int.Parse(AptDate.ToString("dd"));

            ComboBox cmbHour = new ComboBox 
            {
                Text = AptTime.ToString("HH"),
                Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                Location = lblAptTime.Location,
                Size = new Size(60, Height)
            };
            pnlAppointmentDetails.Controls.Add(cmbHour);
            NewControls.Add(cmbHour);

            Label Colon = new Label
            {
                Text = ":",
                Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                Location = new Point(cmbHour.Location.X + cmbHour.Width + 5, lblAptTime.Location.Y),
                AutoSize = true
            };
            pnlAppointmentDetails.Controls.Add(Colon);
            NewControls.Add(Colon);

            ComboBox cmbMinute = new ComboBox
            {
                Text = AptTime.ToString("ss"),
                Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                Location = new Point(Colon.Location.X + Colon.Width + 5, lblAptTime.Location.Y),
                Size = new Size(60, Height)
            };
            pnlAppointmentDetails.Controls.Add(cmbMinute);
            NewControls.Add(cmbMinute);

            ComboBoxSetting.SetupHourMinuteComboBoxes(cmbHour, cmbMinute);
            cmbHour.SelectedItem = int.Parse(cmbHour.Text);
            cmbMinute.SelectedItem = cmbMinute.Text;

            TextBox txtVehicleNumber = new TextBox
            {
                Text = lblVehicleNum.Text,
                Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                Size = new Size( 250, Height ),
                Location = lblVehicleNum.Location
            };
            pnlAppointmentDetails.Controls.Add( txtVehicleNumber );
            NewControls.Add(txtVehicleNumber);

            Button btnUpdate = new Button
            {
                Text = "Update",
                Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                Size = btnModify.Size,
                Location = btnModify.Location,
                FlatStyle = FlatStyle.Popup
            };
            pnlAppointmentDetails.Controls.Add (btnUpdate);
            NewControls.Add(btnUpdate);

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Font = new Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular),
                Size = btnClose.Size,
                Location = btnClose.Location,
                FlatStyle = FlatStyle.Popup
            };
            pnlAppointmentDetails.Controls.Add(btnCancel);
            NewControls.Add (btnCancel);

            btnUpdate.Click += (sd, ev) =>
            {
                string message;
                foreach (Control ctrl in pnlAppointmentDetails.Controls)
                {
                    if (ctrl is ComboBox cmb && cmb.SelectedIndex == -1)
                    {
                        message = "Oops! It seems like Appointment is incomplete. Check each section for any missing information.";
                        MessageBox.Show(message, "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (!Appointment.IsVehicleNumberValid(txtVehicleNumber.Text))
                {
                    MessageBox.Show("Please ensure that all letters are capitalized and that the input does not contain any spaces.",
                        "Invalid Vehicle Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string format = "yyyy-MM-dd HH:mm";
                int mounth = int.Parse(cmbMonth.Text);
                int day = int.Parse(cmbDay.Text);
                int hour = int.Parse(cmbHour.Text);
                DateTime appointment_datetime = DateTime.ParseExact($"{cmbYear.Text}-{mounth:D2}-{day:D2} " +
                    $"{hour:D2}:{cmbMinute.Text}", format, CultureInfo.InvariantCulture);

                Appointment appointment = new Appointment
                {
                    AppointmentID = Appointment.AppointmentID,
                    MakingDateTime = Appointment.MakingDateTime,
                    AppointmentDateTime = appointment_datetime,
                    Status = Appointment.Status,
                    VehicleNumber = txtVehicleNumber.Text
                };
                appointment.Modify();
                MessageBox.Show("Appointment Updated Successfully!");
                NewControls.ForEach(ctrl => pnlAppointmentDetails.Controls.Remove(ctrl));
                lblAptDate.Visible = true;
                lblAptTime.Visible = true;
                lblVehicleNum.Visible = true;
                btnModify.Visible = true;
                btnDelete.Visible = true;
                btnClose.Visible = true;
                LoadDetails(appointment);
            };

            btnCancel.Click += (sD, eV) =>
            {
                NewControls.ForEach(ctrl => pnlAppointmentDetails.Controls.Remove(ctrl));
                lblAptDate.Visible = true;
                lblAptTime.Visible = true;
                lblVehicleNum.Visible = true;
                btnModify.Visible = true;
                btnDelete.Visible = true;
                btnClose.Visible = true;
                LoadDetails(Appointment);
            };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var frmDeleteConfirmation = new frmDeleteConfirmation(Appointment, this);
            frmDeleteConfirmation.Show();
        }
        private void Form_Closed(object sender, EventArgs e)
        {
            var controlsToRemove = new List<Control>();

            foreach (Control ctrl in customerMain.pnlMyAppointment.Controls)
            {
                if (ctrl.Name != "lblTitle" && ctrl.Name != "picLogo")
                {
                    controlsToRemove.Add(ctrl);
                }
            }

            // Now remove controls from pnlMyAppointment
            foreach (var ctrl in controlsToRemove)
            {
                customerMain.pnlMyAppointment.Controls.Remove(ctrl);
            }
            customerMain.LoadAppointment();
        }
    }
}
