using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class Receptionist : User
    {
        public Receptionist(User user)
        {
            UserID = user.UserID;
            Username = user.Username;
            Email = user.Email;
            Password = user.Password;
            Role = user.Role;
        }
        User receptionistTest = new User
        {
            UserID = "000000001",
            Username = "Daryl",
            Email = "testUsername",
            Password = "012345",
            Role = "Receptionist"
        };
    }
}
