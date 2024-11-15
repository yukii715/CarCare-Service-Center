

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
    public partial class Shortages : Form
    {
        public Shortages()
        {
            InitializeComponent();
        }

        private void btnUpdateBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShortagesBack_Click(object sender, EventArgs e)
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
