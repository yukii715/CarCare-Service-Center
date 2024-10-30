using Appearance;
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
    public partial class frmCustomerMain : Form
    {
        public frmCustomerMain()
        {
            InitializeComponent();
            Place_Holder.SetPlaceHolder(txtSearch, "Search...");
        }

        private void frmCustomerMain_Load(object sender, EventArgs e)
        {
            tabCustomer.DrawItem += Draw_Item.tabControlAdjustment;
        }

    }

}
