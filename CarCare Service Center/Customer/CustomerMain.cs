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
using Users;

namespace CarCare_Service_Center
{
    public partial class frmCustomerMain : Form
    {
        private Customer customer;
        public frmCustomerMain(Customer cus)
        {
            InitializeComponent();
            customer = cus;
            Place_Holder.SetPlaceHolder(txtSearch, "Search...");
        }

        private void frmCustomerMain_Load(object sender, EventArgs e)
        {
            tabCustomer.DrawItem += Draw_Item.tabControlAdjustment;
        }

    }

}
