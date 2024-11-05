using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class Mechanic : User
    {
        public Mechanic(User user)
        {
            UserID = user.UserID;
            Username = user.Username;
            Email = user.Email;
            Password = user.Password;
            Role = user.Role;
        }
        public class MechanicTasks
        {
            public string UserID { get; set; }
            public string AppointmentID { get; set; }
        }
    }
}
