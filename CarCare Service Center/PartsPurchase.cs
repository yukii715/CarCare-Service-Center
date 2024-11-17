using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class PartsPurchase : Form
    {
        private List<Parts> parts;
        private string partID;
        private int quantity;
        private decimal price;
        private string supplier;
        public PartsPurchase()
        {
            InitializeComponent();

            string query = "SELECT DISTINCT PartType FROM Parts";
            Database.LoadIntoComboBox(cmbPartType, query, "PartType");

            query = "SELECT * FROM Parts";
            parts = Database.FetchData<Parts>(query);

            PropertyInfo partType = typeof(Parts).GetProperty("PartType");
            PropertyInfo partName = typeof(Parts).GetProperty("PartName");
            ComboBoxSetting.SetUpDependentComboBox<Parts>(cmbPartType, cmbPartName, parts, partType, partName);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            foreach (var part in parts)
            {
                if (cmbPartName.Text == part.PartName)
                {
                    partID = part.PartID;
                    break;
                }
            }
            Parts.Purchases purchases = new Parts.Purchases
            {
                PartID = partID,
                UnitPrice = price,
                Quantity = quantity,
                Supplier = supplier,
                DateTime = DateTime.Now
            };
            purchases.Add();
            MessageBox.Show("Purchase Successful");
            Close();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            string selectedPart = cmbPartName.Text;
            string selectedPartType = cmbPartType.Text;
            supplier = txtSupplier.Text;
            if (string.IsNullOrEmpty(selectedPart) || string.IsNullOrWhiteSpace(selectedPart) ||
                string.IsNullOrEmpty(selectedPartType) || string.IsNullOrWhiteSpace(selectedPartType) ||
                string.IsNullOrEmpty(supplier) || string.IsNullOrWhiteSpace(supplier) ||
                string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrEmpty(txtUnitPrice.Text) || string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                btnPurchase.Enabled = false;
                lblWarning.Visible = true;
                lblWarning.Text = "Fields cannot be empty";
            }
            else
            {
                if (int.TryParse(txtQuantity.Text, out quantity) &&
                decimal.TryParse(txtUnitPrice.Text, out price))
                {
                    lblPrice.Text = (quantity * price).ToString();
                    btnPurchase.Enabled = true;
                    lblWarning.Visible = false;
                }
                else
                {
                    lblWarning.Visible = true;
                    lblWarning.Text = "Invalid format for quantity";
                    btnPurchase.Enabled = false;
                    lblPrice.Text = "";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
