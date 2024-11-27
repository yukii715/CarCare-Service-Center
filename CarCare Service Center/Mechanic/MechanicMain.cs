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
using static CarCare_Service_Center.Services.ServiceOrder;
using static Users.Mechanic;

namespace CarCare_Service_Center
{
    public partial class frmMechanicMain : Form
    {
        private DateTime sessionStartTime;
        private List<Label> LabelProgressService = new List<Label>();
        private List<Label> LabelNote= new List<Label>();
        private List<Label> LabelService = new List<Label>();
        private Mechanic mechanic;
        private List<MechanicTasks> mechanic_task;
        private List<Appointment> appointments;
        private List<Appointment> checkedin_appointment;
        private List<User> users;
        private List<Appointment.Services> appointment_service;
        private List<Services> services;
        private List<MechanicTasks> ServiceProgress;
        private List<Services> ServiceInProgress = new List<Services>();
        private List<Services.ServiceOrder> service_order;
        private List<ServiceEntry> service_entries;
        private Dictionary<Control, Point> controlsBelowtlpServiceProgress= new Dictionary<Control, Point>();

        public frmMechanicMain(Mechanic mec)
        {
            InitializeComponent();
            mechanic = mec;
            sessionStartTime = DateTime.Now;
            timer1.Start();
        }
        
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


        private void frmMechanicMain_Load(object sender, EventArgs e)
        {
            string query_Users = "SELECT * FROM Users WHERE IsDeleted = 0";
            users = Database.FetchData<User>(query_Users);

            tabMechanic.DrawItem += Draw_Item.tabControlAdjustment;
            lblBottomMargin.Text = string.Empty;
            lblUserID.Text = mechanic.UserID;

            mechanic.Username = users.Find(u => u.UserID == mechanic.UserID).Username;
            mechanic.Email = users.Find(u => u.UserID == mechanic.UserID).Email;
            lblUserName.Text = mechanic.Username;
            lblEmail.Text = mechanic.Email;
            controlsBelowtlpServiceProgress.Clear();

            foreach (Control control in pnlServiceProgress.Controls)
            {
                if (control.Top > tlpServiceProgress.Bottom) // Check if the control is below the TableLayoutPanel
                {
                    controlsBelowtlpServiceProgress[control] = control.Location;
                }
            }

            LoadMechanicTasks();
            ServiceProgress_load();

            string query = "SELECT DISTINCT ServiceType FROM Services";
            Database.LoadIntoComboBox(cmbServiceType, query, "ServiceType");

            HightLightLabelEvent(lblHome);
            HightLightLabelEvent(lblReload);
            HightLightLabelEvent(lblLogout);
        }

        private void LoadMechanicTasks()
        {
            string query_Appointments = "SELECT * FROM Appointments WHERE Status = 'Accepted'";
            appointments = Database.FetchData<Appointment>(query_Appointments);
            appointments = appointments.OrderBy(a => a.AppointmentDateTime).ToList();

            string query_MechanicTasks = "SELECT * FROM MechanicTasks WHERE InProgress IS NULL AND UserID = " + $"'{mechanic.UserID}'";
            mechanic_task = Database.FetchData<MechanicTasks>(query_MechanicTasks);
            mechanic_task = mechanic_task.OrderBy(task => appointments.FindIndex(a => a.AppointmentID == task.AppointmentID)).ToList();

            string query_AppointmentServices = "SELECT * FROM AppointmentServices";
            appointment_service = Database.FetchData<Appointment.Services>(query_AppointmentServices);

            string query_Services = "SELECT * FROM Services";
            services = Database.FetchData<Services>(query_Services);

            for (int i = 0; i < mechanic_task.Count; i++)
            {
                float rowheight = 39f * appointment_service.FindAll(apts => apts.AppointmentID == mechanic_task[i].AppointmentID).Count;
                tlpServiceTask.RowStyles.Add(new RowStyle(SizeType.Absolute, rowheight));
                tlpServiceTask.Height += (int)rowheight + 2;

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
            tlpServiceTask.Height += 2;
        }

        private void ServiceProgress_load()
        {
            string query = "SELECT * FROM Appointments WHERE Status = 'CheckedIn'";
            checkedin_appointment = Database.FetchData<Appointment>(query);

            query = "SELECT * FROM MechanicTasks WHERE InProgress = 1 AND UserID = " + $"'{mechanic.UserID}'";
            ServiceProgress = Database.FetchData<MechanicTasks>(query);

            if (ServiceProgress.Count == 0)
                return;

            query = "SELECT * FROM ServiceOrder WHERE AppointmentID = " + $"'{ServiceProgress[0].AppointmentID}'";
            service_order = Database.FetchData<Services.ServiceOrder>(query);

            query = "SELECT * FROM ServiceEntry WHERE ServiceOrderID = " + $"'{service_order[0].ServiceOrderID}'";
            service_entries = Database.FetchData<ServiceEntry>(query);

            lblAppointmentId.Text = ServiceProgress[0].AppointmentID;
            lblAppointmentId.Dock = DockStyle.Fill;
            lblAppointmentId.TextAlign = ContentAlignment.MiddleLeft;

            lblClientID.Text = checkedin_appointment[0].UserID;
            lblClientID.Dock = DockStyle.Fill;
            lblClientID.TextAlign = ContentAlignment.MiddleLeft;

            lblClientName.Text = users.Find(u => u.UserID == checkedin_appointment[0].UserID).Username;
            lblClientName.Dock = DockStyle.Fill;
            lblClientName.TextAlign = ContentAlignment.MiddleLeft;

            lblProgressPlateNumber.Text = checkedin_appointment[0].VehicleNumber;
            lblProgressPlateNumber.Dock = DockStyle.Fill;
            lblProgressPlateNumber.TextAlign = ContentAlignment.MiddleLeft;

            LoadServiceInProgress();
        }
        public void LoadServiceInProgress()
        {
            LabelNote.Clear();
            LabelService.Clear();
            LabelProgressService.Clear();
            tlpServiceProgress.SuspendLayout();
            TableLayoutPanelSetting.RemoveControlsExceptFirstRow(tlpServiceProgress);

            foreach (Control control in pnlServiceProgress.Controls)
            {
                if (control.Top > tlpServiceProgress.Bottom) // Check if the control is below the TableLayoutPanel
                {
                    pnlServiceProgress.Controls.Remove(control);
                }
            }

            foreach (var ctrl in controlsBelowtlpServiceProgress)
            {
                Control control = ctrl.Key;
                control.Location = ctrl.Value; // Restore the original location
                pnlServiceProgress.Controls.Add(control); 
            }

            for (int i = 0; i < service_entries.Count; i++)
            {
                foreach (Control ctrl in pnlServiceProgress.Controls)
                {
                    if (ctrl.Top > tlpServiceProgress.Bottom)
                    {
                        ctrl.Top += 25;
                    }
                }

                Label ProgressNote = new Label();
                if (service_entries[i].IsCompleted == true)
                    ProgressNote.Text = $"{i + 1}*";
                else
                    ProgressNote.Text = (i + 1).ToString();
                tlpServiceProgress.Controls.Add(ProgressNote, 0, i + 1);
                ProgressNote.Dock = DockStyle.Fill;
                ProgressNote.TextAlign = ContentAlignment.MiddleLeft;
                LabelProgressService.Add(ProgressNote);
                LabelNote.Add(ProgressNote);

                Label ProgressServiceName = new Label();
                ProgressServiceName.Text = services.Find(s => s.ServiceID == service_entries[i].ServiceID).ServiceName.Trim();
                tlpServiceProgress.Controls.Add(ProgressServiceName, 1, i + 1);
                ProgressServiceName.Dock = DockStyle.Fill;
                ProgressServiceName.TextAlign = ContentAlignment.MiddleLeft;
                LabelProgressService.Add(ProgressServiceName);
                LabelService.Add(ProgressServiceName);
            }
            if (service_order[0].StartDateTime != null)
            {
                ServiceInProgress.Clear();
                service_entries.ForEach(entry => ServiceInProgress.Add(services.Find(s => s.ServiceID == entry.ServiceID)));

                grbAddService.Visible = true;
                lblRemark.Visible = true;
                txtRemark.Visible = true;
                btnEndTask.Visible = true;
                btnStartTask.Visible = false;

                foreach (Label Label in LabelProgressService)
                {
                    int index = LabelProgressService.IndexOf(Label);

                    void SetLabelBackColor(Color color)
                    {
                        LabelNote[index / 2].BackColor = color;
                        LabelService[index / 2].BackColor = color;
                    }
                    void HightLightLabelEvent(Label label)
                    {
                        label.MouseEnter += (s, ev) => SetLabelBackColor(Color.Ivory);
                        label.MouseLeave += (s, ev) =>
                        {
                            if (label.BackColor != Color.PapayaWhip)
                                SetLabelBackColor(Color.Transparent);
                        };
                        label.MouseDown += (s, ev) =>
                        {
                            LabelProgressService.ForEach(lbl => lbl.BackColor = Color.Transparent);
                            SetLabelBackColor(Color.PeachPuff);
                        };
                        label.MouseUp += (s, ev) =>
                        {
                            if (service_entries[index / 2].IsCompleted == true)
                            {
                                MessageBox.Show("This service already done, no further change allowed", "Service Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            SetLabelBackColor(Color.LemonChiffon);
                            frmServiceInProgress frmServiceInProgress = new frmServiceInProgress();
                            frmServiceInProgress.mechanicMain = this;
                            frmServiceInProgress.serviceEntry = service_entries[index / 2];
                            frmServiceInProgress.Text = $"{lblClientName.Text}'s Service {index / 2 + 1}: {ServiceInProgress[index / 2].ServiceName}";
                            frmServiceInProgress.ShowDialog();
                        };
                    }
                    HightLightLabelEvent(Label);
                }
            }
            tlpServiceProgress.ResumeLayout();
            tlpServiceProgress.PerformLayout();

            PropertyInfo service_type = typeof(Services).GetProperty("ServiceType");
            PropertyInfo service_name = typeof(Services).GetProperty("ServiceName");
            ComboBoxSetting.SetUpDependentComboBox<Services>(cmbServiceType, cmbService, services, service_type, service_name, ServiceInProgress);
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            if (ServiceProgress.Count == 0)
            {
                MessageBox.Show("No Service is assigned to you now", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            service_order[0].StartDateTime = DateTime.Now;
            service_order[0].Start();

            ServiceInProgress.Clear();

            grbAddService.Visible = true;
            lblRemark.Visible = true;
            txtRemark.Visible = true;
            btnEndTask.Visible = true;
            btnStartTask.Visible = false;

            foreach (Label Label in LabelProgressService)
            {
                int index = LabelProgressService.IndexOf(Label);

                void SetLabelBackColor(Color color)
                {
                    LabelNote[index / 2].BackColor = color;
                    LabelService[index / 2].BackColor = color;
                }
                void HightLightLabelEvent(Label label)
                {
                    label.MouseEnter += (s, ev) => SetLabelBackColor(Color.Ivory);
                    label.MouseLeave += (s, ev) =>
                    {
                        if (label.BackColor != Color.PapayaWhip)
                            SetLabelBackColor(Color.Transparent);
                    };
                    label.MouseDown += (s, ev) =>
                    {
                        LabelProgressService.ForEach(lbl => lbl.BackColor = Color.Transparent);
                        SetLabelBackColor(Color.PeachPuff);
                    };
                    label.MouseUp += (s, ev) =>
                    {
                        if (service_entries[index / 2].IsCompleted == true)
                        {
                            MessageBox.Show("This service already done, no further change allowed", "Service Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        SetLabelBackColor(Color.LemonChiffon);
                        frmServiceInProgress frmServiceInProgress = new frmServiceInProgress();
                        frmServiceInProgress.mechanicMain = this;
                        frmServiceInProgress.serviceEntry = service_entries[index / 2];
                        frmServiceInProgress.Text = $"{lblClientName.Text}'s Service {index/2 + 1}: {ServiceInProgress[index/2].ServiceName}";
                        frmServiceInProgress.ShowDialog();
                    };
                }
                HightLightLabelEvent(Label);
            }

            appointment_service.FindAll(apts => apts.AppointmentID == ServiceProgress[0].AppointmentID).ForEach(service => ServiceInProgress.Add(services.Find(s => s.ServiceID == service.ServiceID)));

            PropertyInfo service_type = typeof(Services).GetProperty("ServiceType");
            PropertyInfo service_name = typeof(Services).GetProperty("ServiceName");
            ComboBoxSetting.SetUpDependentComboBox<Services>(cmbServiceType, cmbService, services, service_type, service_name, ServiceInProgress);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbService.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Service！", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newServiceEntry = new ServiceEntry
            {
                ServiceOrderID = service_order[0].ServiceOrderID,
                ServiceID = services.Find(s => s.ServiceType == cmbServiceType.Text && s.ServiceName == cmbService.Text).ServiceID
            };
            newServiceEntry.ServiceEntryID = newServiceEntry.GenerateServiceEntryID();
            newServiceEntry.Add();

            service_entries.Add(newServiceEntry);
            ServiceInProgress.Add(services.Find(s => s.ServiceID == newServiceEntry.ServiceID));
            
            int count = service_entries.Count;
            
            Label ProgressNote = new Label();
            ProgressNote.Text = count.ToString();
            tlpServiceProgress.Controls.Add(ProgressNote, 0, count);
            ProgressNote.Dock = DockStyle.Fill;
            ProgressNote.TextAlign = ContentAlignment.MiddleLeft;
            LabelProgressService.Add(ProgressNote);

            Label ProgressServiceName = new Label();
            ProgressServiceName.Text = ServiceInProgress[count - 1].ServiceName.Trim();
            tlpServiceProgress.Controls.Add(ProgressServiceName, 1, count);
            ProgressServiceName.Dock = DockStyle.Fill;
            ProgressServiceName.TextAlign = ContentAlignment.MiddleLeft;
            LabelProgressService.Add(ProgressServiceName);

            void SetLabelBackColor(Color color)
            {
                ProgressNote.BackColor = color;
                ProgressServiceName.BackColor = color;
            }
            void HightLightLabelEvent(Label label)
            {
                label.MouseEnter += (s, ev) => SetLabelBackColor(Color.Ivory);
                label.MouseLeave += (s, ev) =>
                {
                    if (label.BackColor != Color.PapayaWhip)
                        SetLabelBackColor(Color.Transparent);
                };
                label.MouseDown += (s, ev) =>
                {
                    LabelProgressService.ForEach(lbl => lbl.BackColor = Color.Transparent);
                    SetLabelBackColor(Color.PeachPuff);
                };
                label.MouseUp += (s, ev) =>
                {
                    if (service_entries[count - 1].IsCompleted == true)
                    {
                        MessageBox.Show("This service already done, no further change allowed", "Service Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    SetLabelBackColor(Color.LemonChiffon);
                    frmServiceInProgress frmServiceInProgress = new frmServiceInProgress();
                    frmServiceInProgress.mechanicMain = this;
                    frmServiceInProgress.serviceEntry = service_entries[count - 1];
                    frmServiceInProgress.Text = $"{lblClientName.Text}'s Service {count}: {ServiceInProgress[count - 1].ServiceName}";
                    frmServiceInProgress.ShowDialog();
                };
            }
            HightLightLabelEvent(ProgressNote);
            HightLightLabelEvent(ProgressServiceName);
            

            //tlpServiceProgress.RowCount = count;

            foreach (Control ctrl in pnlServiceProgress.Controls)
            {
                if (ctrl.Top > tlpServiceProgress.Bottom)
                {
                    ctrl.Top += 25;
                }
            }

            cmbServiceType.SelectedIndex = -1;
        }


        private void btnEndTask_Click(object sender, EventArgs e)
        {
            foreach(var serviceEntry in service_entries)
            {
                if (serviceEntry.IsCompleted == false)
                {
                    MessageBox.Show("Haven't recorded all services yet, please record all services customer used first", "Information Missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DialogResult result = MessageBox.Show(
            "Are you sure this service oeder is completed? No further changes can be made after confirmation.",
            "End task Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                service_order[0].EndDateTime = DateTime.Now;
                service_order[0].Remark = txtRemark.Text;
                service_order[0].End();
                ServiceProgress.Find(task => task.AppointmentID == service_order[0].AppointmentID).EndTask();

                int currentTabIndex = tabMechanic.SelectedIndex;

                Controls.Clear();
                InitializeComponent();
                frmMechanicMain_Load(sender, e);
                tabMechanic.SelectedIndex = currentTabIndex;
            }
        }

        //
        // Inventory
        //
        public void BackToTab3()
        {
            tabMechanic.SelectedIndex = 3;
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

        //
        // Profile
        //
        private void btnChangeUserName_Click(object sender, EventArgs e)
        {
            frmChangeUserName frmChangeUserName = new frmChangeUserName(mechanic);
            frmChangeUserName.ShowDialog();
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            frmChangeEmail frmChangeEmail = new frmChangeEmail(mechanic);
            frmChangeEmail.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(mechanic);
            frmChangePassword.ShowDialog();
        }

        //
        // Top
        //
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
            tabMechanic.SelectedIndex = 0;
        }

        private void lblReload_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to reload the application? Unsaved changes will be lost.",
            "Reload Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                lblReload.ForeColor = SystemColors.ControlText;

                int currentTabIndex = tabMechanic.SelectedIndex;

                Controls.Clear();
                InitializeComponent();
                frmMechanicMain_Load(sender, e);
                tabMechanic.SelectedIndex = currentTabIndex;
            }
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            lblLogout.ForeColor = SystemColors.ControlText;
            frmLogoutConfirmation frmLogoutConfirmation = new frmLogoutConfirmation(this);
            frmLogoutConfirmation.ShowDialog();
        }
    }
}