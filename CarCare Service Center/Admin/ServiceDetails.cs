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
    public partial class ServiceDetails : Form
    {
        public ServiceDetails()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ServiceDetailConfiguration serviceDetailConfiguration = new ServiceDetailConfiguration();
            serviceDetailConfiguration.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ServiceDeletion serviceDeletion = new ServiceDeletion();
            serviceDeletion.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}