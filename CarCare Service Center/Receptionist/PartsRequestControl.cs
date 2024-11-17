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
        public PartsRequestControl()
        {
            InitializeComponent();
        }

        private void PartsRequestControl_MouseClick(object sender, MouseEventArgs e)
        {
            string requestID = lblPartRequestID.Text;
            string partName = lblPartName.Text;
            string partType = lblPartType.Text;

            PartsRequest openform = new PartsRequest(requestID, partName, partType);
            openform.ShowDialog();
        }
    }
}
