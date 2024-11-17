

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;
using Functions;

namespace CarCare_Service_Center
{
    public partial class Request : Form
    {
        private Mechanic mechanic;

        public Request(Mechanic mechanic)
        {
            InitializeComponent();
            txtboxPartName.Enabled = false;
            cmbPartType.SelectedIndexChanged += cmbPartType_SelectedIndexChanged;
            this.mechanic = mechanic;
        }



        private void btnRequestRequest_Click(object sender, EventArgs e)
        {

            if (IsLengthInvalid(txtboxPartName.Text, 1, 50))
            {
                MessageBox.Show("Part Name must be between 1 and 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Description cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Parts.Requests newRequest = new Parts.Requests
            {
                RequestID = Parts.Requests.GenerateRequestID(),
                UserID = mechanic.UserID,     
                UserName = mechanic.Username,
                DateTime = DateTime.Now,          
                PartType = cmbPartType.Text, 
                PartName = txtboxPartName.Text, 
                Description = txtDescription.Text 
            };

            newRequest.Add();
            MessageBox.Show("Request added successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cmbPartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbPartType.Text))
            {
                txtboxPartName.Enabled = true;
            }
            else
            {
                txtboxPartName.Enabled = false;
            }
        }
        private static bool IsLengthInvalid(string value, int min, int max)
        {
            if (value.Length > max || value.Length < min)
                return true;
            else
                return false;
        }


        private void btnRequestBack_Click(object sender, EventArgs e)
        {
            frmMechanicMain mechanicMain = Application.OpenForms["frmMechanicMain"] as frmMechanicMain;
            if (mechanicMain != null)
            {
                mechanicMain.BackToTab3();
                this.Close();
            }
        }

        
    }
}
