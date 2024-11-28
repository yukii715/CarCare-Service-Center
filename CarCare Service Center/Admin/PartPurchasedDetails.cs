using Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace CarCare_Service_Center
{
    public partial class PartPurchasedDetails : Form
    {
        private Parts.Purchases part_purchase;
        private List<Parts> parts;

        public PartPurchasedDetails(Parts.Purchases pp)
        {
            InitializeComponent();
            part_purchase = pp;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PartPurchasedDetails_Load(object sender, EventArgs e)
        {
            string query = "SELECT * From Parts WHERE PartID = " + $"'{part_purchase.PartID}'";
            parts = Database.FetchData<Parts>(query);


            lblPartID.Text = part_purchase.PartID.ToString().Trim();
            lblPartName.Text = parts[0].PartName.ToString().Trim();
            lblDate.Text = part_purchase.DateTime.ToString().Trim();
            lblSupplier.Text = part_purchase.Supplier.ToString().Trim();
            lblUnitPrice.Text = part_purchase.UnitPrice.ToString().Trim();
            lblQuantity.Text = part_purchase.Quantity.ToString();
            lblTotalPrice.Text = (part_purchase.Quantity * part_purchase.UnitPrice).ToString().Trim();
        }
    }
}
