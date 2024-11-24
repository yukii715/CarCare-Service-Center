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
    public partial class frmPartDetails : Form
    {
        private Parts part;
        private frmReceptionistMain main;
        public frmPartDetails(Parts part, frmReceptionistMain frmReceptionistMain)
        {
            InitializeComponent();
            this.part = part;
            main = frmReceptionistMain;
            Text = part.PartID + " " + part.PartName;
            FormClosed += Form_Closed;
        }

        private void frmPartDetails_Load(object sender, EventArgs e)
        {
            LoadDetails(part);
        }

        public void LoadDetails(Parts part)
        {
            lblPartID.Text = part.PartID;
            lblPartType.Text = part.PartType.Trim();
            lblPartName.Text = part.PartName.Trim();
            lblStock.Text = part.Stock.ToString();
            txtPrice.Text = part.SellPrice.ToString();
            lblStatus.Text = part.Status;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Decimal price;
            if (!Decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                part.UpdatePrice(price);
                Close();
                MessageBox.Show("Succefully Edited!");
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            frmPartsPurchase frmPartsPurchase = new frmPartsPurchase(part, this);
            frmPartsPurchase.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Closed(object sender, EventArgs e)
        {
            main.LoadPartsInventory();
            main.LoadPartsPurchaseLog();
        }
    }
}
