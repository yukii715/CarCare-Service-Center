using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appearance;
using Users;

namespace CarCare_Service_Center
{
    public partial class frmAdminMain : Form
    {
        private Admin admin;
        public frmAdminMain(Admin ad)
        {
            InitializeComponent();
            admin = ad;
            lblAdminID.Text = admin.UserID;
            lblAdminName.Text = admin.Username;
            lblAdminEmail.Text = admin.Email;
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            tabAdmin.DrawItem += Draw_Item.tabControlAdjustment;
        }

        private void btnStaffSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSortStaffID_Click(object sender, EventArgs e)
        {

        }

        private void btnSortStaffName_Click(object sender, EventArgs e)
        {

        }

        private void btnStaffDetail_Click(object sender, EventArgs e)
        {
            StaffDetails formStaffDetails = new StaffDetails();
            formStaffDetails.Show();

        }

        private void btnStaffDelete_Click(object sender, EventArgs e)
        {
            StaffDeletion formStallDeletion = new StaffDeletion();
            formStallDeletion.Show();
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            StaffInsertion formStaffInsertion = new StaffInsertion();
            formStaffInsertion.Show();
        }

        private void btnServiceSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceSortID_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceSortName_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceSortServiceType_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceDetails_Click(object sender, EventArgs e)
        {
            ServiceDetails formServiceDetails = new ServiceDetails();
            formServiceDetails.Show();
        }

        private void btnServiceDelete_Click(object sender, EventArgs e)
        {
            ServiceDeletion formServiceDeletion = new ServiceDeletion();
            formServiceDeletion.Show();
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            ServiceInsertion formServiceInsertion = new ServiceInsertion();
            formServiceInsertion.Show();
        }
    }
}