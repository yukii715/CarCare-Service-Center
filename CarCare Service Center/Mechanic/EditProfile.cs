
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
    public partial class EditProfile : Form
    {
        private frmMechanicMain frmMechanicMain_;
        public EditProfile(frmMechanicMain frmMechanicMain)
        {
            InitializeComponent();
            frmMechanicMain_ = frmMechanicMain;
        }

        private void btnEditProfile_Click_1(object sender, EventArgs e)
        {
            frmMechanicMain_.updateProfile(txtNewName.Text, txtNewMail.Text);
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
