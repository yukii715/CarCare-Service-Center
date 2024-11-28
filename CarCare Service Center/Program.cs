using Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCare_Service_Center
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Vincent\\Source\\Repos\\CarCare-Service-Center\\CarCare Service Center\\Database1.mdf\";Integrated Security=True";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UpdateAppointmentStatuses();

            Application.Run(new frmLogin());
        }

        static void UpdateAppointmentStatuses()
        {
            DateTime today = DateTime.Today;

            // Fetch all appointments
            string query = "SELECT * FROM Appointments";
            var appointments = Database.FetchData<Appointment>(query);

            foreach (var appointment in appointments)
            {
                if (appointment.AppointmentDateTime < today && appointment.Status != "Completed")
                {
                    appointment.UpdateStatus("Late");
                }
            }
        }
    }
}
