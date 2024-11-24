
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
    public partial class PartsRequestControl : UserControl
    {
        private Parts.Requests Requests;
        private frmReceptionistMain frmReceptionistMain;
        public PartsRequestControl(Parts.Requests requests, frmReceptionistMain frmReceptionistMain)
        {
            InitializeComponent();
            Requests = requests;
            this.frmReceptionistMain = frmReceptionistMain;
        }

        private void PartsRequestControl_MouseClick(object sender, MouseEventArgs e)
        {
            PartsRequest openform = new PartsRequest(Requests, frmReceptionistMain);
            openform.ShowDialog();
        }
        
    }
}
