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
    public partial class ServiceDeletion : Form
    {
        private Services service = new Services();
        private frmAdminMain frmAdmin;
        private ServiceDetails serviceDetailForm;
        public ServiceDeletion(Services s, ServiceDetails sdf, frmAdminMain frmAdminMain)
        {
            InitializeComponent();
            service = s;
            serviceDetailForm = sdf;
            frmAdmin = frmAdminMain;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Services staff = new Services
            {
                ServiceID = service.ServiceID,
            };
            Services.Delete(service.ServiceID);

            MessageBox.Show("Deleted Successfully", "Staff Deleted", MessageBoxButtons.OK);
            frmAdmin.tlpServiceData.Controls.Clear();
            frmAdmin.tlpServiceData.RowCount = 1;
            frmAdmin.LoadServices();
            frmAdmin.cmbServiceType.SelectedIndex = -1;
            frmAdmin.txtServiceSearch.Text = "Search";
            Close();
            serviceDetailForm.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}