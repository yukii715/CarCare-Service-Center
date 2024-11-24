
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlSetting;
using Functions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static CarCare_Service_Center.Appointment;

namespace CarCare_Service_Center
{
    public partial class frmPartsPurchase : Form
    {
        private Parts Part;
        private frmPartDetails frmPartDetails;
        public frmPartsPurchase(Parts part, frmPartDetails frmPartDetails)
        {
            InitializeComponent();
            Part = part;
            this.frmPartDetails = frmPartDetails;
            Text = $"Purchase {Part.PartName}";
            lblTotalPrice.Text = string.Empty ;
            FormClosed += Form_Closed;
        }
        private void frmPartsPurchase_Load(object sender, EventArgs e)
        {
            lblPartID.Text = Part.PartID;
            lblPartType.Text = Part.PartType;
            lblPartName.Text = Part.PartName;
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity) && Decimal.TryParse(txtUnitPrice.Text, out Decimal unit_price))
            {
                lblTotalPrice.Text = (quantity * unit_price).ToString();
            }
            else
                lblTotalPrice.Text = string.Empty;
        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (Validation.IsLengthInvalid(txtSupplier.Text, 1, 50))
            {
                MessageBox.Show("Please enter a Supplier Name within 50 characters", "Invalid Supplier Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid value", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Decimal.TryParse(txtUnitPrice.Text, out Decimal unit_price))
            {
                MessageBox.Show("Please enter a valid value", "Invalid UnitPrice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Parts.Purchases newPurchase = new Parts.Purchases
            {
                PartID = Part.PartID,
                UnitPrice = unit_price,
                Quantity = quantity,
                Supplier = txtSupplier.Text,
                DateTime = DateTime.Now
            };

            newPurchase.Add();
            Part.Stock += quantity;
            Part.UpdateStock();
            Part.ChangeStatus("Sufficient");

            Close();
            MessageBox.Show("Successfully Purchase!");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Closed(object sender, EventArgs e)
        {
            frmPartDetails.LoadDetails(Part);
        }
    }
}
