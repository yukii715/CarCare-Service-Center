

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
    public partial class StaffDetails : Form
    {
        private User user;
        public StaffDetails(User u = null)
        {
            InitializeComponent();
            user = u;
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {
            lblStaffID.Text = user.UserID.Trim();
            lblName.Text = user.Username.Trim();
            lblEmail.Text = user.Email.Trim();
            lblRole.Text = user.Role.Trim();
            lblSalary.Text = user.Salary.ToString().Trim();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            StaffDetailConfiguration formStallDetailConfiguration = new StaffDetailConfiguration(user, this);
            formStallDetailConfiguration.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StaffDeletion formStaffDeletion = new StaffDeletion();
            formStaffDeletion.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
