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
using static CarCare_Service_Center.Services.ServiceOrder.ServiceEntry;
using static CarCare_Service_Center.Services.ServiceOrder;
using static CarCare_Service_Center.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Users;
using System.Diagnostics;

namespace CarCare_Service_Center
{
    public partial class frmOrderDetails : Form
    {
        private ServiceOrder serviceOrder;
        private List<Appointment> appointments;
        private List<User> users;
        private List<Services> services;
        private List<ServicePrice> servicePrice;
        private List<ServiceEntry> serviceEntries;
        private List<ServiceParts> serviceParts;
        private List<Parts> parts;
        private List<Control> controls = new List<Control>();
        public frmOrderDetails(ServiceOrder serviceOrder)
        {
            InitializeComponent();
            lblButtomMargin.Text = string.Empty;
            this.serviceOrder = serviceOrder;
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Appointments WHERE Status = 'Completed'";
            appointments = Database.FetchData<Appointment>(query);

            query = "SELECT * FROM Users";
            users = Database.FetchData<User>(query);

            lblUserID.Text = appointments.Find(a => a.AppointmentID == serviceOrder.AppointmentID).UserID;
            lblUsername.Text = users.Find(u => u.UserID == lblUserID.Text).Username;
            lblArrivalDateTime.Text = serviceOrder.ArrivalDateTime.ToString("yyyy-MM-dd hh:mm:ss tt");
            lblStartDateTime.Text = serviceOrder.StartDateTime?.ToString("yyyy-MM-dd hh:mm:ss tt");
            lblEndDateTime.Text = serviceOrder.EndDateTime?.ToString("yyyy-MM-dd hh:mm:ss tt");
            lblCollectionDateTime.Text = serviceOrder.CollectionDateTime.ToString("yyyy-MM-dd hh:mm:ss tt");
            lblVehicleNumber.Text = appointments.Find(a => a.AppointmentID == serviceOrder.AppointmentID).VehicleNumber;
            lblTotalPrice.Text = $"RM {serviceOrder.TotalPrice}";
            lblRating.Text = serviceOrder.Rating == 0 ? "No Rating yet" : serviceOrder.Rating.ToString();
            txtFeebBack.Text = serviceOrder?.Feedback ?? "No FeebBack yet";
            txtFeebBack.TabStop = false;

            LoadServicesBill();
        }

        private void LoadServicesBill()
        {
            string query = "SELECT * FROM Services WHERE IsDeleted = 0";
            services = Database.FetchData<Services>(query);

            query = "SELECT * FROM ServicePrice";
            servicePrice = Database.FetchData<Services.ServicePrice>(query);

            query = "SELECT * FROM ServiceEntry WHERE ServiceOrderID = " + $"'{serviceOrder.ServiceOrderID}'";
            serviceEntries = Database.FetchData<ServiceEntry>(query);

            query = "SELECT * FROM ServiceParts";
            serviceParts = Database.FetchData<ServiceEntry.ServiceParts>(query);

            query = "SELECT * FROM Parts";
            parts = Database.FetchData<Parts>(query);

            foreach (Control ctrl in Controls)
            {
                if (pnlServicesBill.Bottom < ctrl.Top)
                    controls.Add(ctrl);
            }

            TableLayoutPanel ServicesBill = new TableLayoutPanel
            {
                Location = new Point(0, 0),
                ColumnCount = 4,
                Width = 630,
                Height = 0,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                AutoSize = false
            };
            pnlServicesBill.Controls.Add(ServicesBill);

            ServicesBill.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18));
            ServicesBill.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            ServicesBill.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24));
            ServicesBill.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18));
            int row_height = 30;
            int total_row = -1;

            for (int i = 0; i < serviceEntries.Count; i++)
            {
                total_row++;
                List<ServiceParts> parts_used = serviceParts.FindAll(s => s.ServiceEntryID == serviceEntries[i].ServiceEntryID);
                List<ServicePrice> servicePrices = servicePrice.FindAll(s => s.ServiceID == serviceEntries[i].ServiceID);
                ServicesBill.RowStyles.Add(new RowStyle(SizeType.Absolute, row_height - 1));

                Label ServiceEntryID = new Label
                {
                    Text = serviceEntries[i].ServiceEntryID,
                    Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                ServicesBill.Controls.Add(ServiceEntryID, 0, total_row);

                Label ServiceName = new Label
                {
                    Text = services.Find(s => s.ServiceID == serviceEntries[i].ServiceID).ServiceName.Trim(),
                    Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                ServicesBill.Controls.Add(ServiceName, 1, total_row);

                Label Mode = new Label
                {
                    Text = serviceEntries[i].Mode,
                    Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                ServicesBill.Controls.Add(Mode, 2, total_row);

                Label labourFee = new Label
                {
                    Text = $"RM {servicePrices.Find(p => p.Description == serviceEntries[i].Mode).Price}",
                    Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                ServicesBill.Controls.Add(labourFee, 3, total_row);

                for (int j = 0; j < parts_used.Count; j++)
                {
                    total_row++;
                    int parts_count = serviceParts.FindAll(s => s.ServiceEntryID == serviceEntries[i].ServiceEntryID).Count;
                    ServicesBill.RowStyles.Add(new RowStyle(SizeType.Absolute, (row_height - 1) * parts_count));

                    Label PartName = new Label
                    {
                        Text = parts.Find(p => p.PartID == parts_used[j].PartID).PartName,
                        Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleLeft
                    };
                    ServicesBill.Controls.Add(PartName, 1, total_row);

                    Label Quantity = new Label
                    {
                        Text = "x" + parts_used[j].Quantity.ToString(),
                        Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    ServicesBill.Controls.Add(Quantity, 2, total_row);

                    Label TotalCost = new Label
                    {
                        Text = $"RM {parts_used[j].TotalCost}",
                        Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleLeft
                    };
                    ServicesBill.Controls.Add(TotalCost, 3, total_row);

                    ServicesBill.Height += row_height * parts_count;
                    ServicesBill.RowCount += parts_count;

                    foreach (Control ctrl in controls)
                    {
                        ctrl.Top += (row_height * (1 + parts_count));
                    }
                }
                ServicesBill.Height += row_height;
                ServicesBill.RowCount++;
            }
            ServicesBill.Height++;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
