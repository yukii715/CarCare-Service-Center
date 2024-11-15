

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarCare_Service_Center
{
    public partial class FeedbackDetails : Form
    {
        public FeedbackDetails()
        {
            InitializeComponent();
            btnBack.Location = new System.Drawing.Point(150, lblComment.Bottom + 50);  // Position below the label
        }


        private void FeedbackDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
