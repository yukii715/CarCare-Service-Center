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
using Users;

namespace CarCare_Service_Center
{
    public partial class frmMechanicAvailability : Form
    {
        private Appointment Appointment;
        private frmRequestedAppointment RequestedAppointment;
        private List<Appointment> appointments;
        private List<Appointment.Services> appointment_services;
        private List<Services> services;
        private List<Mechanic.MechanicTasks> mechanic_tasks;
        private List<User> mechanics;
        private List<User> unavailable_mechanic = new List<User>();
        private string selectedMechanicID;
        private string selectedMechanicName;
        public frmMechanicAvailability(Appointment appointment, frmRequestedAppointment frmRequestedAppointment)
        {
            InitializeComponent();
            Appointment = appointment;
            RequestedAppointment = frmRequestedAppointment;
            lblButtomMargin.Text = string.Empty;
        }

        private void frmMechanicAvailability_Load(object sender, EventArgs e)
        {
            string query_qppointments = "SELECT * FROM Appointments WHERE CAST(AppointmentDateTime AS DATE) = " + $"'{Appointment.AppointmentDateTime:yyyy-MM-dd}'";
            appointments = Database.FetchData<Appointment>(query_qppointments);

            string query_appointment_services = "SELECT * FROM AppointmentServices";
            appointment_services = Database.FetchData<Appointment.Services>(query_appointment_services);

            string query_services = "SELECT * FROM Services";
            services = Database.FetchData<Services>(query_services);

            string query_users = "SELECT * FROM Users WHERE Role = 'Mechanic'";
            mechanics = Database.FetchData<User>(query_users);

            string query_mechanic_tasks = "SELECT * FROM MechanicTasks";
            mechanic_tasks = Database.FetchData<Mechanic.MechanicTasks>(query_mechanic_tasks);

            HashSet<string> appointmentIds = new HashSet<string>(appointments.Select(a => a.AppointmentID));
            mechanic_tasks.RemoveAll(task => !appointmentIds.Contains(task.AppointmentID));


            TimeSpan range = TimeSpan.FromHours(2);
            unavailable_mechanic.AddRange(mechanics.Where(m => m.UserID == mechanic_tasks.Find(task => task.AppointmentID == appointments.Find(a => (Appointment.AppointmentDateTime - a.AppointmentDateTime).Duration() < range )?.AppointmentID)?.UserID));

            showAvailableMechanics();
        }
        private void showAvailableMechanics()
        {
            mechanics.RemoveAll(m => unavailable_mechanic.Contains(m));
            if (mechanics.Count == 0)
            {
                Label label = new Label
                {
                    Text = "No Available Mechanic",
                    Font = new Font("Comic Sans MS", 16F, FontStyle.Regular),
                    Location = new Point(60, 100),
                    AutoSize = true
                };
                Controls.Add(label);
                btnAssign.Visible = false;
                return;
            }

            TableLayoutPanel AvailableMechanics = new TableLayoutPanel
            {
                Location = new Point(30, 100),
                ColumnCount = 3,
                Width = 530,
                Height = 0,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single, 
                AutoSize = false
            };
            Controls.Add(AvailableMechanics);
            
            AvailableMechanics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));
            AvailableMechanics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            AvailableMechanics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75));

            int row_height = 30;
            int total_row = -1;

            for (int i = 0; i < mechanics.Count; i++)
            {
                total_row++;
                List<Mechanic.MechanicTasks> mechanicTasks = mechanic_tasks.FindAll(task => task.UserID == mechanics[i].UserID);
                AvailableMechanics.RowStyles.Add(new RowStyle(SizeType.Absolute, row_height - 1));

                CheckBox selectMechanic = new CheckBox 
                {
                    CheckAlign = ContentAlignment.MiddleCenter, 
                    Dock = DockStyle.Fill,
                };
                AvailableMechanics.Controls.Add(selectMechanic, 0, total_row);

                Label MechanicID = new Label
                {
                    Text = mechanics[i].UserID,
                    Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                AvailableMechanics.Controls.Add(MechanicID, 1, total_row);

                Label MechanicName = new Label
                {
                    Text = mechanics[i].Username,
                    Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                AvailableMechanics.Controls.Add(MechanicName, 2, total_row);

                for (int j = 0; j < mechanicTasks.Count; j++)
                {
                    total_row++;
                    int service_count = appointment_services.FindAll(s => s.AppointmentID == mechanicTasks[j].AppointmentID).Count;
                    AvailableMechanics.RowStyles.Add(new RowStyle(SizeType.Absolute, (row_height - 1) * service_count));

                    Label AptTime = new Label
                    {
                        Text = appointments.Find(a => a.AppointmentID == mechanic_tasks[j].AppointmentID).AppointmentDateTime.ToString("hh:ss tt"),
                        Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    AvailableMechanics.Controls.Add(AptTime, 1, total_row);

                    Label AptServices = new Label
                    {
                        Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleLeft
                    };
                    appointment_services.FindAll(apts => apts.AppointmentID == mechanicTasks[j].AppointmentID).ForEach(service => AptServices.Text += $"{services.Find(s => s.ServiceID == service.ServiceID).ServiceName.Trim()} ({services.Find(s => s.ServiceID == service.ServiceID).EstimatedTime} mins)\n");
                    AptServices.Text = AptServices.Text.Substring(0, AptServices.Text.Length - 1);
                    AvailableMechanics.Controls.Add(AptServices, 2, total_row);

                    AvailableMechanics.Height += row_height * service_count;
                    AvailableMechanics.RowCount += service_count;

                    if (AvailableMechanics.Bottom + 30 > btnAssign.Top)
                    {
                        btnAssign.Top += (row_height * (1 + service_count));
                        btnBack.Top += (row_height * (1 + service_count));
                        lblButtomMargin.Top += (row_height * (1 + service_count));
                    }
                }

                AvailableMechanics.Height += row_height;
                AvailableMechanics.RowCount++;

                selectMechanic.CheckedChanged += (sender, e) =>
                {
                    if (((CheckBox)sender).Checked)
                    {
                        selectedMechanicID = MechanicID.Text;
                        selectedMechanicName = MechanicName.Text;
                        // Loop through all the checkboxes and uncheck them except the current one
                        foreach (Control ctrl in AvailableMechanics.Controls) 
                        {
                            if (ctrl is CheckBox && ctrl != sender)
                            {
                                ((CheckBox)ctrl).Checked = false;
                            }
                        }
                    }
                    else
                    {
                        selectedMechanicID = null;
                        selectedMechanicName = null;
                    }
                }; 
            }
            AvailableMechanics.Height++;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (selectedMechanicID == null)
            {
                MessageBox.Show("Please select a mechanic", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }    
            frmAssignConfirmation frmAssignConfirmation = new frmAssignConfirmation(Appointment, this, RequestedAppointment, selectedMechanicID, selectedMechanicName);
            frmAssignConfirmation.ShowDialog();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
