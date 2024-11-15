

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlSetting;
using Functions;
using Users;
using static CarCare_Service_Center.Appointment;

namespace CarCare_Service_Center
{
    public partial class frmMechanicMain : Form
    {
        private Mechanic mechanic;
        private List<Mechanic.MechanicTasks> mechanic_task = new List<Mechanic.MechanicTasks>();
        private List<Appointment> appointments = new List<Appointment>();
        private List<User> users = new List<User>();
        private List<Appointment.Services> appointment_service = new List<Appointment.Services>();
        private List<Services> services = new List<Services>();

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



        private void btnProfile_Click(object sender, EventArgs e)
        {
            EditProfile editprofileform = new EditProfile(this);
            editprofileform.ShowDialog();
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
            tblCustomerRequests_Load(sender, e);
            cmbService.Enabled = false;
        }
        private void tblCustomerRequests_Load(object sender, EventArgs e)
        {
            mechanic_task.Add(new Mechanic.MechanicTasks { UserID = "1", AppointmentID = "1" });
            mechanic_task.Add(new Mechanic.MechanicTasks { UserID = "1", AppointmentID = "2" });

            string format = "yyyy-MM-dd HH:mm:ss";
            appointments.Add(new Appointment { UserID = "C1", AppointmentID = "1", AppointmentDateTime = DateTime.ParseExact("2024-11-15 15:30:00", format, System.Globalization.CultureInfo.InvariantCulture) });
            appointments.Add(new Appointment { UserID = "C2", AppointmentID = "2", AppointmentDateTime = DateTime.ParseExact("2024-11-17 10:00:00", format, System.Globalization.CultureInfo.InvariantCulture) });

            users.Add(new User { UserID = "C1", Username = "Venti" });
            users.Add(new User { UserID = "C2", Username = "Kinich" });

            appointment_service.Add(new Appointment.Services { AppointmentID = "1", ServiceID = "1" });
            appointment_service.Add(new Appointment.Services { AppointmentID = "1", ServiceID = "2" });
            appointment_service.Add(new Appointment.Services { AppointmentID = "2", ServiceID = "1" });

            services.Add(new Services { ServiceID = "1", ServiceName = "Service1" });
            services.Add(new Services { ServiceID = "2", ServiceName = "Service2" });

            tblCustomerRequests.RowCount = mechanic_task.Count + 1;  // Add a row for headers

            // Loop through mechanic tasks and populate the TableLayoutPanel
            for (int i = 0; i < mechanic_task.Count; i++)
            {
                var task = mechanic_task[i];
                var appointment = appointments.Find(a => a.AppointmentID == task.AppointmentID);
                var customer = users.Find(u => u.UserID == appointment?.UserID);

                if (appointment != null && customer != null)
                {
                    task.DateTime = appointment.AppointmentDateTime;
                    task.CustomerName = customer.Username;
                }
                else
                {
                    task.CustomerName = "Unknown";
                    task.DateTime = DateTime.MinValue; // Assign a default date if missing
                }

                // Populate table layout with task information
                Label noteLabel = new Label { Text = (i + 1).ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
                tblCustomerRequests.Controls.Add(noteLabel, 0, i + 1);

                Label nameLabel = new Label { Text = task.CustomerName, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
                tblCustomerRequests.Controls.Add(nameLabel, 1, i + 1);

                // Build the Service Name string
                string serviceName = string.Join(", ", appointment_service
                    .Where(s => s.AppointmentID == task.AppointmentID)
                    .Select(s => services.Find(serv => serv.ServiceID == s.ServiceID)?.ServiceName)
                    .Where(name => name != null));

                Label serviceLabel = new Label { Text = serviceName, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
                tblCustomerRequests.Controls.Add(serviceLabel, 2, i + 1);

                Label dateLabel = new Label { Text = task.DateTime.ToString("yyyy-MM-dd"), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
                tblCustomerRequests.Controls.Add(dateLabel, 3, i + 1);

                Label timeLabel = new Label { Text = task.DateTime.ToString("HH:mm"), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
                tblCustomerRequests.Controls.Add(timeLabel, 4, i + 1);
            }
        }
        private Dictionary<string, List<string>> serviceTypeOptions = new Dictionary<string, List<string>>()
{
        { "a", new List<string> { "1", "2", "3" } },
        { "b", new List<string> { "4", "5", "6" } },
        { "c", new List<string> { "7", "8", "9" } }
};

        private void btnStartTask_Click_1(object sender, EventArgs e)
        {
            grbAddService.Visible = true;
            lblRemark.Visible = true;
            txtRemark.Visible = true;
            btnEndTask.Visible = true;
            btnStartTask.Visible = false;
        }

        int rowCount = 1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbServiceType.SelectedItem != null && cmbService.SelectedItem != null)
            {

                string selectedService = cmbService.SelectedItem.ToString();
                string selectedType = cmbServiceType.SelectedItem.ToString();
                cmbService.Items.Remove(selectedService);
                serviceTypeOptions[selectedType].Remove(selectedService);
                cmbService.SelectedItem = null;
                rowCount++;
                int rowIndex = rowCount - 1;
                float rowheight = 50;

                tableLayoutPanel1.RowCount = rowCount;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, rowheight));

                Label lblNote = new Label
                {
                    Text = rowIndex.ToString(),
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };

                Label lblService = new Label
                {
                    Text = selectedService,
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    BackColor = Color.LightGoldenrodYellow
                };

                lblService.MouseEnter += (s, ev) => lblService.BackColor = Color.Ivory;
                lblService.MouseLeave += (s, ev) => lblService.BackColor = Color.LightGoldenrodYellow;
                lblService.MouseDown += (s, ev) => lblService.BackColor = Color.PeachPuff;


                lblService.Click += (s, _) => OpenProgressForm(selectedService);

                tableLayoutPanel1.Controls.Add(lblNote, 0, rowIndex);
                tableLayoutPanel1.Controls.Add(lblService, 1, rowIndex);
                for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
                {
                    tableLayoutPanel1.RowStyles[i] = new RowStyle(SizeType.Absolute, rowheight);
                }

                foreach (Control ctrl in panel1.Controls)
                {
                    if (ctrl.Top > tableLayoutPanel1.Bottom)
                    {
                        ctrl.Top += (int)rowheight;
                    }
                }
                if (cmbService.Items.Count == 0)
                {
                    cmbService.Enabled = false;
                }
            }

            else
            {
                MessageBox.Show("Please Select Service Type and Service！");
            }
        }
        private void OpenProgressForm(string selectedService)
        {
            Progress progressfrm = new Progress();
            progressfrm.ShowDialog();
        }

        private void cmbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbService.Items.Clear();
            string selectedType = cmbServiceType.SelectedItem.ToString();
            if (serviceTypeOptions.ContainsKey(selectedType))
            {
                foreach (var service in serviceTypeOptions[selectedType])
                {
                    cmbService.Items.Add(service);
                }
            }
            if (cmbServiceType.SelectedIndex != -1)
            {
                cmbService.Enabled = true;
            }
            else
            {
                cmbService.Enabled = false;
            }
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServiceType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Service Type first!");
                cmbService.SelectedIndex = -1;
            }
        }

        private void btnEndTask_Click(object sender, EventArgs e)
        {

        }

        public void BackToTab3()
        {
            tabMechanic.SelectedIndex = 3;
        }

    }
}

