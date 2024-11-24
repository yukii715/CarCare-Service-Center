
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
using CarCare_Service_Center;
using Functions;
using Users;
using static CarCare_Service_Center.frmReceptionistMain;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Reflection;
using static Users.Mechanic;

namespace CarCare_Service_Center
{
    public partial class frmReceptionistMain : Form
    {
        private Receptionist receptionist;
        private List<User> users;
        private List<User> mechanics;
        private List<Appointment> appointment_requests;
        private List<Appointment> upcoming_appointment;
        private List<Appointment> checkedin_appointment;
        private List<Appointment> appointment_log;
        private List<Services.ServiceOrder> service_order;
        private List<Services.ServiceOrder.ServiceEntry> service_entry;
        private List<Parts> parts;
        private List<Parts.Requests> partsRequests;
        private List<Parts.Purchases> partsPurchase;
        private List<Label> LabelAppointmentRequests = new List<Label>();
        private List<Label> LabelUpcomingAppointment = new List<Label>();
        private List<Label> LabelCheckedInAppointment = new List<Label>();
        private List<Label> LabelAppointmentLog = new List<Label>();
        private List<Label> LabelPartsInventory = new List<Label>();

        public frmReceptionistMain(Receptionist rec)
        {
            InitializeComponent();
            tmClock.Start();
            receptionist = rec;
        }


        private void frmReceptionistMain_Load(object sender, EventArgs e)
        {
            tabReceptionist.DrawItem += Draw_Item.tabControlAdjustment;
            Place_Holder.SetPlaceHolder(txtSearchCustomer, "Search");
            Place_Holder.SetPlaceHolder(txtSearchAppointmentRequests, "Search");
            Place_Holder.SetPlaceHolder(txtSearchUpcomingAppointments, "Search");
            lblWelcome.Text = "Welcome " + receptionist.Username.ToString();
            lblOverview.Text = DateTime.Now.ToString("MMMM") + " Overview";

            // Loading each table
            LoadCustomerAccounts();
            LoadAppointmentRequests();
            LoadUpcomingAppointments();
            LoadCheckedInAppointments();
            LoadPartsInventory();
            LoadPartsRequests();
            LoadPartsPurchaseLog();
            HightLightLabelEvent(lblHome);
            HightLightLabelEvent(lblReload);
            HightLightLabelEvent(lblLogout);
        }

        private void tmClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("d MMM yyyy HH:mm:ss");
        }

        private void btnAccRequests_Click(object sender, EventArgs e)
        {
            CustomerRequests openForm = new CustomerRequests();
            openForm.Show();
        }

        private void btnAccEdit_Click(object sender, EventArgs e)
        {
            CustomerDetails openForm = new CustomerDetails();
            openForm.Show();
        }

        public void LoadCustomerAccounts()
        {
            string query = "SELECT * FROM Users WHERE Role = 'Customer' AND IsDeleted = 0";
            users = Database.FetchData<User>(query);
            for (int i = 0; i < users.Count; i++)
            {
                Label customerID = new Label();
                customerID.Text = users[i].UserID;
                tblCustomerAccounts.Controls.Add(customerID, 0, i + 1);
                customerID.Dock = DockStyle.Fill;
                customerID.TextAlign = ContentAlignment.MiddleLeft;

                Label customerName = new Label();
                customerName.Text = users[i].Username;
                tblCustomerAccounts.Controls.Add(customerName, 1, i + 1);
                customerName.Dock = DockStyle.Fill;
                customerName.TextAlign = ContentAlignment.MiddleLeft;

                Label customerEmail = new Label();
                customerEmail.Text = users[i].Email;
                tblCustomerAccounts.Controls.Add(customerEmail, 2, i + 1);
                customerEmail.Dock = DockStyle.Fill;
                customerEmail.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void LoadAppointmentRequests()
        {
            tlpAppointmentRequests.SuspendLayout();
            TableLayoutPanelSetting.RemoveControlsExceptFirstRow(tlpAppointmentRequests);

            string query = "SELECT * FROM Appointments WHERE Status = 'Pending' ORDER BY CAST(RIGHT(AppointmentID, 8) AS INT)";
            appointment_requests = Database.FetchData<Appointment>(query);
            for (int i = 0; i < appointment_requests.Count; i++)
            {
                int index = i;

                Label appointmentID = new Label();
                appointmentID.Text = appointment_requests[i].AppointmentID;
                appointmentID.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpAppointmentRequests.Controls.Add(appointmentID, 0, i + 1);
                appointmentID.Dock = DockStyle.Fill;
                appointmentID.TextAlign = ContentAlignment.MiddleCenter;
                LabelAppointmentRequests.Add(appointmentID);

                Label timeRequested = new Label();
                timeRequested.Text = $"{appointment_requests[i].AppointmentDateTime.ToString("dd-MM-yyyy")}\n" +
                    $"{appointment_requests[i].AppointmentDateTime.ToString("hh:mm tt")}";
                timeRequested.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpAppointmentRequests.Controls.Add(timeRequested, 1, i + 1);
                timeRequested.Dock = DockStyle.Fill;
                timeRequested.TextAlign = ContentAlignment.MiddleCenter;
                timeRequested.AutoSize = true;
                LabelAppointmentRequests.Add(timeRequested);

                Label customerName = new Label();
                customerName.Text = users.Find(c => c.UserID == appointment_requests[i].UserID).Username;
                customerName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpAppointmentRequests.Controls.Add(customerName, 2, i + 1);
                customerName.Dock = DockStyle.Fill;
                customerName.TextAlign = ContentAlignment.MiddleLeft;
                LabelAppointmentRequests.Add(customerName);

                Label vehicleNumber = new Label();
                vehicleNumber.Text = appointment_requests[i].VehicleNumber;
                vehicleNumber.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpAppointmentRequests.Controls.Add(vehicleNumber, 3, i + 1);
                vehicleNumber.Dock = DockStyle.Fill;
                vehicleNumber.TextAlign = ContentAlignment.MiddleCenter;
                LabelAppointmentRequests.Add(vehicleNumber);

                void SetLabelBackColor(Color color)
                {
                    appointmentID.BackColor = color;
                    timeRequested.BackColor = color;
                    customerName.BackColor = color;
                    vehicleNumber.BackColor = color;
                }

                void HightLightLabelEvent(Label label)
                {
                    label.MouseEnter += (s, ev) => SetLabelBackColor(Color.PapayaWhip);
                    label.MouseLeave += (s, ev) =>
                    {
                        if (label.BackColor != Color.LemonChiffon)
                            SetLabelBackColor(Color.Transparent);
                    };
                    label.MouseDown += (s, ev) =>
                    {
                        LabelAppointmentRequests.ForEach(lbl => lbl.BackColor = Color.Transparent);
                        SetLabelBackColor(Color.PeachPuff);
                    };
                    label.MouseUp += (s, ev) => 
                    {
                        SetLabelBackColor(Color.LemonChiffon);
                        frmRequestedAppointment requestedAppointment = new frmRequestedAppointment(appointment_requests[index], this);
                        requestedAppointment.ShowDialog();
                    };
                }
                HightLightLabelEvent(appointmentID);
                HightLightLabelEvent(timeRequested);
                HightLightLabelEvent(customerName);
                HightLightLabelEvent(vehicleNumber);
            }
            tlpAppointmentRequests.ResumeLayout();
            tlpAppointmentRequests.PerformLayout();
        }
        public void LoadUpcomingAppointments()
        {
            tlpUpcomingAppointments.SuspendLayout();
            TableLayoutPanelSetting.RemoveControlsExceptFirstRow(tlpUpcomingAppointments);

            string query = "SELECT * FROM Appointments WHERE Status = 'Accepted' ORDER BY CAST(RIGHT(AppointmentID, 8) AS INT)";
            upcoming_appointment = Database.FetchData<Appointment>(query);
            for (int i = 0; i < upcoming_appointment.Count; i++)
            {
                int index = i;

                Label appointmentID = new Label();
                appointmentID.Text = upcoming_appointment[i].AppointmentID;
                appointmentID.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpUpcomingAppointments.Controls.Add(appointmentID, 0, i + 1);
                appointmentID.Dock = DockStyle.Fill;
                appointmentID.TextAlign = ContentAlignment.MiddleCenter;
                LabelUpcomingAppointment.Add(appointmentID);

                Label DateTime = new Label();
                DateTime.Text = $"{upcoming_appointment[i].AppointmentDateTime.ToString("dd-MM-yyyy")}\n" +
                    $"{upcoming_appointment[i].AppointmentDateTime.ToString("hh:mm tt")}";
                DateTime.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpUpcomingAppointments.Controls.Add(DateTime, 1, i + 1);
                DateTime.Dock = DockStyle.Fill;
                DateTime.TextAlign = ContentAlignment.MiddleCenter;
                DateTime.AutoSize = true;
                LabelUpcomingAppointment.Add(DateTime);

                Label customerName = new Label();
                customerName.Text = users.Find(c => c.UserID == upcoming_appointment[i].UserID).Username;
                customerName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpUpcomingAppointments.Controls.Add(customerName, 2, i + 1);
                customerName.Dock = DockStyle.Fill;
                customerName.TextAlign = ContentAlignment.MiddleLeft;
                LabelUpcomingAppointment.Add(customerName);

                Label vehicleNumber = new Label();
                vehicleNumber.Text = upcoming_appointment[i].VehicleNumber;
                vehicleNumber.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpUpcomingAppointments.Controls.Add(vehicleNumber, 3, i + 1);
                vehicleNumber.Dock = DockStyle.Fill;
                vehicleNumber.TextAlign = ContentAlignment.MiddleCenter;
                LabelUpcomingAppointment.Add(vehicleNumber);

                void SetLabelBackColor(Color color)
                {
                    appointmentID.BackColor = color;
                    DateTime.BackColor = color;
                    customerName.BackColor = color;
                    vehicleNumber.BackColor = color;
                }
                void HightLightLabelEvent(Label label)
                {
                    label.MouseEnter += (s, ev) => SetLabelBackColor(Color.PapayaWhip);
                    label.MouseLeave += (s, ev) =>
                    {
                        if (label.BackColor != Color.LemonChiffon)
                            SetLabelBackColor(Color.Transparent);
                    };
                    label.MouseDown += (s, ev) =>
                    {
                        LabelUpcomingAppointment.ForEach(lbl => lbl.BackColor = Color.Transparent);
                        SetLabelBackColor(Color.PeachPuff);
                    };
                    label.MouseUp += (s, ev) =>
                    {
                        SetLabelBackColor(Color.LemonChiffon);
                        frmCheckInCustomer frmCheckInCustomer = new frmCheckInCustomer(upcoming_appointment[index], this);
                        frmCheckInCustomer.ShowDialog();
                    };
                }
                HightLightLabelEvent(appointmentID);
                HightLightLabelEvent(DateTime);
                HightLightLabelEvent(customerName);
                HightLightLabelEvent(vehicleNumber);
            }
            tlpUpcomingAppointments.ResumeLayout();
            tlpUpcomingAppointments.PerformLayout();
        }
        public void LoadCheckedInAppointments()
        {
            tlpAppointmentCheckouts.SuspendLayout();
            TableLayoutPanelSetting.RemoveControlsExceptFirstRow(tlpAppointmentCheckouts);

            string query = "SELECT * FROM Appointments WHERE Status = 'CheckedIn' ORDER BY AppointmentDateTime";
            checkedin_appointment = Database.FetchData<Appointment>(query);

            query = "SELECT * FROM ServiceOrder";
            service_order = Database.FetchData<Services.ServiceOrder>(query);

            HashSet<string> appointmentIds = new HashSet<string>(checkedin_appointment.Select(a => a.AppointmentID));
            service_order.RemoveAll(order => !appointmentIds.Contains(order.AppointmentID));

            for (int i = 0; i < checkedin_appointment.Count; i++)
            { 
                int index = i;

                Label appointmentID = new Label();
                appointmentID.Text = checkedin_appointment[i].AppointmentID;
                appointmentID.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpAppointmentCheckouts.Controls.Add(appointmentID, 0, i + 1);
                appointmentID.Dock = DockStyle.Fill;
                appointmentID.TextAlign = ContentAlignment.MiddleCenter;
                LabelCheckedInAppointment.Add(appointmentID);

                Label DateTime = new Label();
                DateTime check_in = service_order.Find(o => o.AppointmentID == checkedin_appointment[i].AppointmentID).ArrivalDateTime;
                DateTime.Text = $"{check_in.ToString("dd-MM-yyyy")}\n{check_in.ToString("hh:mm tt")}";
                DateTime.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpAppointmentCheckouts.Controls.Add(DateTime, 1, i + 1);
                DateTime.Dock = DockStyle.Fill;
                DateTime.TextAlign = ContentAlignment.MiddleCenter;
                DateTime.AutoSize = true;
                LabelCheckedInAppointment.Add(DateTime);

                Label customerName = new Label();
                customerName.Text = users.Find(c => c.UserID == checkedin_appointment[i].UserID).Username;
                customerName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpAppointmentCheckouts.Controls.Add(customerName, 2, i + 1);
                customerName.Dock = DockStyle.Fill;
                customerName.TextAlign = ContentAlignment.MiddleLeft;
                LabelCheckedInAppointment.Add(customerName);

                Label vehicleNumber = new Label();
                vehicleNumber.Text = checkedin_appointment[i].VehicleNumber;
                vehicleNumber.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpAppointmentCheckouts.Controls.Add(vehicleNumber, 3, i + 1);
                vehicleNumber.Dock = DockStyle.Fill;
                vehicleNumber.TextAlign = ContentAlignment.MiddleCenter;
                LabelCheckedInAppointment.Add(vehicleNumber);

                void SetLabelBackColor(Color color)
                {
                    appointmentID.BackColor = color;
                    DateTime.BackColor = color;
                    customerName.BackColor = color;
                    vehicleNumber.BackColor = color;
                }
                void HightLightLabelEvent(Label label)
                {
                    label.MouseEnter += (s, ev) => SetLabelBackColor(Color.PapayaWhip);
                    label.MouseLeave += (s, ev) =>
                    {
                        if (label.BackColor != Color.LemonChiffon)
                            SetLabelBackColor(Color.Transparent);
                    };
                    label.MouseDown += (s, ev) =>
                    {
                        LabelCheckedInAppointment.ForEach(lbl => lbl.BackColor = Color.Transparent);
                        SetLabelBackColor(Color.PeachPuff);
                    };
                    label.MouseUp += (s, ev) =>
                    {
                        SetLabelBackColor(Color.LemonChiffon);
                        
                    };
                }
                HightLightLabelEvent(appointmentID);
                HightLightLabelEvent(DateTime);
                HightLightLabelEvent(customerName);
                HightLightLabelEvent(vehicleNumber);
            }
            tlpAppointmentCheckouts.ResumeLayout();
            tlpAppointmentCheckouts.PerformLayout();
        }

        public void LoadPartsInventory()
        {
            tlpPartsInventory.SuspendLayout();
            TableLayoutPanelSetting.RemoveControlsExceptFirstRow(tlpPartsInventory);

            string query = "SELECT * FROM Parts";
            parts = Database.FetchData<Parts>(query);
            for (int i = 0; i < parts.Count; i++)
            {
                int index = i;

                Label partID = new Label();
                partID.Text = parts[i].PartID.Trim();
                partID.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpPartsInventory.Controls.Add(partID, 0, i + 1);
                partID.Dock = DockStyle.Fill;
                partID.TextAlign = ContentAlignment.MiddleCenter;
                LabelPartsInventory.Add(partID);

                Label partType = new Label();
                partType.Text = parts[i].PartType.Trim();
                partType.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpPartsInventory.Controls.Add(partType, 1, i + 1);
                partType.Dock = DockStyle.Fill;
                partType.TextAlign = ContentAlignment.MiddleLeft;
                partType.AutoEllipsis = true;
                LabelPartsInventory.Add(partType);

                Label partName = new Label();
                partName.Text = parts[i].PartName.Trim();
                partName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpPartsInventory.Controls.Add(partName, 2, i + 1);
                partName.Dock = DockStyle.Fill;
                partName.TextAlign = ContentAlignment.MiddleLeft;
                partName.AutoEllipsis = true;
                LabelPartsInventory.Add(partName);

                Label partPrice = new Label();
                partPrice.Text = parts[i].SellPrice.ToString().Trim();
                partPrice.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpPartsInventory.Controls.Add(partPrice, 3, i + 1);
                partPrice.Dock = DockStyle.Fill;
                partPrice.TextAlign = ContentAlignment.MiddleCenter;
                LabelPartsInventory.Add(partPrice);

                Label partStock = new Label();
                partStock.Text = parts[i].Stock.ToString().Trim();
                partStock.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpPartsInventory.Controls.Add(partStock, 4, i + 1);
                partStock.Dock = DockStyle.Fill;
                partStock.TextAlign = ContentAlignment.MiddleCenter;
                LabelPartsInventory.Add(partStock);

                Label partStatus = new Label();
                partStatus.Text = parts[i].Status.Trim();
                partStatus.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpPartsInventory.Controls.Add(partStatus, 5, i + 1);
                partStatus.Dock = DockStyle.Fill;
                partStatus.TextAlign = ContentAlignment.MiddleCenter;
                LabelPartsInventory.Add(partStatus);

                void SetLabelBackColor(Color color)
                {
                    partID.BackColor = color;
                    partType.BackColor = color;
                    partName.BackColor = color;
                    partPrice.BackColor = color;
                    partStock.BackColor = color;
                    partStatus.BackColor = color;
                }

                void HightLightLabelEvent(Label label)
                {
                    label.MouseEnter += (s, ev) => SetLabelBackColor(Color.PapayaWhip);
                    label.MouseLeave += (s, ev) =>
                    {
                        if (label.BackColor != Color.LemonChiffon)
                            SetLabelBackColor(Color.Transparent);
                    };
                    label.MouseDown += (s, ev) =>
                    {
                        LabelPartsInventory.ForEach(lbl => lbl.BackColor = Color.Transparent);
                        SetLabelBackColor(Color.PeachPuff);
                    };
                    label.MouseUp += (s, ev) =>
                    {
                        SetLabelBackColor(Color.LemonChiffon);
                        frmPartDetails frmPartDetails = new frmPartDetails(parts[index], this);
                        frmPartDetails.ShowDialog();
                    };
                }
                HightLightLabelEvent(partID);
                HightLightLabelEvent(partType);
                HightLightLabelEvent(partName);
                HightLightLabelEvent(partPrice);
                HightLightLabelEvent(partStock);
                HightLightLabelEvent(partStatus);
            }
            tlpPartsInventory.ResumeLayout();
            tlpPartsInventory.PerformLayout();
        }
        public void LoadPartsRequests()
        {
            pnlPartsRequests.Controls.Clear();

            string query = "SELECT * FROM Users WHERE Role = 'Mechanic' AND IsDeleted = 0";
            mechanics = Database.FetchData<User>(query);

            query = "SELECT * FROM PartsRequests WHERE IsApproved IS NULL";
            partsRequests = Database.FetchData<Parts.Requests>(query);

            if (partsRequests.Count == 0)
            {
                Label message = new Label
                {
                    Text = "No Request",
                    Font = new Font("Comic Sans MS", 16F, FontStyle.Regular),
                    Location = new Point(0,0),
                    AutoSize = true
                };
                pnlPartsRequests.Controls.Add(message);
            }

            int offset = 0;

            for (int i = 0; i < partsRequests.Count; i++)
            {
                PartsRequestControl requestDetails = new PartsRequestControl(partsRequests[i], this);
                pnlPartsRequests.Controls.Add(requestDetails);
                requestDetails.Location = new Point(0, 0 + offset);
                foreach (Control ctl in requestDetails.Controls)
                {
                    if (ctl.Name.StartsWith("lblPartRequestID"))
                    {
                        ctl.Text = partsRequests[i].RequestID;
                        ctl.Enabled = false;
                    }
                    else if (ctl.Name.StartsWith("lblUserData"))
                    {
                        ctl.Text = $"{mechanics.Find(c => c.UserID == partsRequests[i].UserID).Username}" +
                            $"\n\n{partsRequests[i].UserID}";
                        ctl.Enabled = false;
                    }
                    else if (ctl.Name.StartsWith("lblRequestDateTime"))
                    {
                        ctl.Text = $"{partsRequests[i].DateTime.ToString("yyyy-MM-dd")}" +
                            $"\n\n{partsRequests[i].DateTime.ToString("hh:mm tt")}";
                        ctl.Enabled = false;
                    }
                    else if (ctl.Name.StartsWith("lblPartName"))
                    {
                        ctl.Text = partsRequests[i].PartName.Trim();
                        ctl.Enabled = false;
                    }
                    else if (ctl.Name.StartsWith("lblPartType"))
                    {
                        ctl.Text = partsRequests[i].PartType;
                        ctl.Enabled = false;
                    }
                    else if (ctl.Name.StartsWith("txtDescription"))
                    {
                        ctl.Text = partsRequests[i].Description;
                        ctl.Enabled = false;
                    }
                }
                offset = offset + requestDetails.Height - 1;
            }
        }

        public void LoadPartsPurchaseLog()
        {
            tlpPartsPurchase.SuspendLayout();
            TableLayoutPanelSetting.RemoveControlsExceptFirstRow(tlpPartsPurchase);

            string query = "SELECT * FROM PartsPurchase";
            partsPurchase = Database.FetchData<Parts.Purchases>(query);
            partsPurchase = partsPurchase.OrderBy(p => p.DateTime).ToList();

            for (int i = 0; i < partsPurchase.Count; i++)
            {
                tlpPartsPurchase.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));

                Label partID = new Label();
                partID.Text = partsPurchase[i].PartID.Trim();
                partID.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpPartsPurchase.Controls.Add(partID, 0, i + 1);
                partID.Dock = DockStyle.Fill;
                partID.TextAlign = ContentAlignment.MiddleCenter;

                Label partName = new Label();
                partName.Text = parts.Find(p => p.PartID == partsPurchase[i].PartID).PartName.Trim();
                partName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpPartsPurchase.Controls.Add(partName, 1, i + 1);
                partName.Dock = DockStyle.Fill;
                partName.TextAlign = ContentAlignment.MiddleLeft;
                partName.AutoEllipsis = true;

                Label DateTime = new Label();
                DateTime.Text = partsPurchase[i].DateTime.ToString("yyyy-MM-dd\nhh:mm tt");
                DateTime.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpPartsPurchase.Controls.Add(DateTime, 2, i + 1);
                DateTime.Dock = DockStyle.Fill;
                DateTime.TextAlign = ContentAlignment.MiddleCenter;

                Label UnitPrice = new Label();
                UnitPrice.Text = partsPurchase[i].UnitPrice.ToString();
                UnitPrice.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpPartsPurchase.Controls.Add(UnitPrice, 3, i + 1);
                UnitPrice.Dock = DockStyle.Fill;
                UnitPrice.TextAlign = ContentAlignment.MiddleCenter;

                Label Quantity = new Label();
                Quantity.Text = partsPurchase[i].Quantity.ToString();
                Quantity.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpPartsPurchase.Controls.Add(Quantity, 4, i + 1);
                Quantity.Dock = DockStyle.Fill;
                Quantity.TextAlign = ContentAlignment.MiddleCenter;

                Label Supplier = new Label();
                Supplier.Text = partsPurchase[i].Supplier.Trim();
                Supplier.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular);
                tlpPartsPurchase.Controls.Add(Supplier, 5, i + 1);
                Supplier.Dock = DockStyle.Fill;
                Supplier.TextAlign = ContentAlignment.MiddleLeft;
                Supplier.AutoEllipsis = true;
            }
            tlpPartsPurchase.ResumeLayout();
            tlpPartsPurchase.PerformLayout();
        }

        //
        // Profile
        //

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
            tabReceptionist.SelectedIndex = 0;
        }

        private void lblReload_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to reload the application? Unsaved changes will be lost.",
            "Reload Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                lblReload.ForeColor = SystemColors.ControlText;

                int currentTabIndex = tabReceptionist.SelectedIndex;

                Controls.Clear();
                InitializeComponent();
                frmReceptionistMain_Load(sender, e);
                tabReceptionist.SelectedIndex = currentTabIndex;
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
