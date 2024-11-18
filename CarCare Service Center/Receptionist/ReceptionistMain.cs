
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

namespace CarCare_Service_Center
{
    public partial class frmReceptionistMain : Form
    {
        private Receptionist receptionist;
        private List<User> users;
        private List<User> mechanics;
        private List<Appointment> appointments;
        private List<Parts> parts;
        private List<Parts.Requests> partsRequests;

        public frmReceptionistMain(Receptionist rec)
        {
            InitializeComponent();
            tmClock.Start();
            lblWelcome.Text = "Welcome " + rec.Username.ToString();
            lblOverview.Text = DateTime.Now.ToString("MMMM") + " Overview";
            receptionist = rec;
            Place_Holder.SetPlaceHolder(txtSearch, "Search");
        }


        private void frmReceptionistMain_Load(object sender, EventArgs e)
        {
            tabReceptionist.DrawItem += Draw_Item.tabControlAdjustment;
            tabAppointment.DrawItem += Draw_Item.tabControlAdjustment;
            tabParts.DrawItem += Draw_Item.tabControlAdjustment;

            //loading Customer Accounts table
            LoadCustomerAccounts();

            //loading Appointment Requests table
            LoadAppointmentRequests();

            //loading Parts Inventory Table
            LoadPartsInventory();

            //loading all parts requested by mechanic
            LoadPartsRequests();
        }

        private void tmClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("d MMM yyyy HH:mm:ss");
        }

        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            lblLogout.ForeColor = SystemColors.Highlight;
            lblLogout.Font = new Font(lblLogout.Font, FontStyle.Underline);
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.ForeColor = SystemColors.ControlText;
            lblLogout.Font = new Font(lblLogout.Font, FontStyle.Regular);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            frmLogin openForm = new frmLogin();
            Hide();
            openForm.ShowDialog();
            Close();
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

        public void ClearTable(TableLayoutPanel table)
        {
            int columnCount = table.ColumnCount;
            int rowCount = table.RowCount;

            for (int i = rowCount - 1; i > 1; i--)
            {
                int j = 0;
                while (j <= columnCount)
                {
                    Control selectedCell = table.GetControlFromPosition(j, i);
                    if (selectedCell != null)
                    {
                        table.Controls.Remove(selectedCell);
                        selectedCell.Dispose();
                    }
                    j++;
                }
            }

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
            string query = "SELECT * FROM Appointments WHERE Status = 'Pending'";
            appointments = Database.FetchData<Appointment>(query);
            for (int i = 0; i < appointments.Count; i++)
            {
                Label appointmentID = new Label();
                appointmentID.Text = appointments[i].AppointmentID;
                tblAppointmentRequests.Controls.Add(appointmentID, 0, i + 1);
                appointmentID.Dock = DockStyle.Fill;
                appointmentID.TextAlign = ContentAlignment.MiddleLeft;

                Label timeRequested = new Label();
                timeRequested.Text = $"{appointments[i].AppointmentDateTime.ToString("dd-MM-yyyy")}\n" +
                    $"{appointments[i].AppointmentDateTime.ToString("HH:mm")}";
                tblAppointmentRequests.Controls.Add(timeRequested, 1, i + 1);
                timeRequested.Dock = DockStyle.Fill;
                timeRequested.TextAlign = ContentAlignment.MiddleCenter;
                timeRequested.AutoSize = true;

                Label customerName = new Label();
                customerName.Text = users.Find(c => c.UserID == appointments[i].UserID).Username;
                tblAppointmentRequests.Controls.Add(customerName, 2, i + 1);
                customerName.Dock = DockStyle.Fill;
                customerName.TextAlign = ContentAlignment.MiddleLeft;

                Label vehicleNumber = new Label();
                vehicleNumber.Text = appointments[i].VehicleNumber;
                tblAppointmentRequests.Controls.Add(vehicleNumber, 3, i + 1);
                vehicleNumber.Dock = DockStyle.Fill;
                vehicleNumber.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        public void LoadPartsInventory()
        {
            string query = "SELECT * FROM Parts";
            parts = Database.FetchData<Parts>(query);
            for (int i = 0; i < parts.Count; i++)
            {
                Label partID = new Label();
                partID.Text = parts[i].PartID;
                tblPartsInventory.Controls.Add(partID, 0, i + 1);
                partID.Dock = DockStyle.Fill;
                partID.TextAlign = ContentAlignment.MiddleLeft;

                Label partType = new Label();
                partType.Text = parts[i].PartType;
                tblPartsInventory.Controls.Add(partType, 1, i + 1);
                partType.Dock = DockStyle.Fill;
                partType.TextAlign = ContentAlignment.MiddleLeft;

                Label partName = new Label();
                partName.Text = parts[i].PartName;
                tblPartsInventory.Controls.Add(partName, 2, i + 1);
                partName.Dock = DockStyle.Fill;
                partName.TextAlign = ContentAlignment.MiddleLeft;

                Label partPrice = new Label();
                partPrice.Text = parts[i].SellPrice.ToString();
                tblPartsInventory.Controls.Add(partPrice, 3, i + 1);
                partPrice.Dock = DockStyle.Fill;
                partPrice.TextAlign = ContentAlignment.MiddleCenter;

                Label partStock = new Label();
                partStock.Text = parts[i].Stock.ToString();
                tblPartsInventory.Controls.Add(partStock, 4, i + 1);
                partStock.Dock = DockStyle.Fill;
                partStock.TextAlign = ContentAlignment.MiddleCenter;

                Label partStatus = new Label();
                partStatus.Text = parts[i].Status;
                tblPartsInventory.Controls.Add(partStatus, 5, i + 1);
                partStatus.Dock = DockStyle.Fill;
                partStatus.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
        public void LoadPartsRequests()
        {
            pnlPartsRequests.Controls.Clear();

            string query = "SELECT * FROM Users WHERE Role = 'Mechanic' AND IsDeleted = 0";
            mechanics = Database.FetchData<User>(query);

            query = "SELECT * FROM PartsRequests WHERE IsApproved IS NULL";
            partsRequests = Database.FetchData<Parts.Requests>(query);

            int offset = 0;

            for (int i = 0; i < partsRequests.Count; i++)
            {
                PartsRequestControl requestDetails = new PartsRequestControl();
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
                    else if (ctl.Name.StartsWith("lblPartName"))
                    {
                        ctl.Text = partsRequests[i].PartName;
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
                offset = offset + 222;
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PartsPurchase openform = new PartsPurchase();
            openform.ShowDialog();
        }
    }
}
