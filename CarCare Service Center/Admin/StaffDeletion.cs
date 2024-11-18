
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace CarCare_Service_Center
{
    public partial class StaffDeletion : Form
    {
        private User user;
        private StaffDetails staffdetailsform;
        private frmAdminMain frmAdmin;

        public StaffDeletion(User u, StaffDetails sd, frmAdminMain frmAdminMain)
        {
            InitializeComponent();
            user = u;
            staffdetailsform = sd;
            frmAdmin = frmAdminMain;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string staffID = user.UserID.ToString();

            User staff = new User
            {
                UserID = staffID
            };
            User.Delete(staffID);

            MessageBox.Show("Delete Successfully", "Staff Deleted", MessageBoxButtons.OK);

            frmAdmin.tlpStaffAccountData.Controls.Clear();
            frmAdmin.tlpStaffAccountData.RowCount = 1;
            frmAdmin.cmbRoleSelection.SelectedIndex = -1;
            frmAdmin.txtStaffSearch.Text = "Search";
            frmAdmin.LoadUser();
            Close();
            staffdetailsform.Close();
            frmAdmin.Show();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
