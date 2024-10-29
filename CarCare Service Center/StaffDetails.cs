using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCare_Service_Center
{
    public partial class StaffDetails : Form
    {
        public StaffDetails()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StaffDetailConfiguration formStallDetailConfiguration = new StaffDetailConfiguration();
            formStallDetailConfiguration.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StaffDeletion formStaffDeletion = new StaffDeletion();
            formStaffDeletion.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
