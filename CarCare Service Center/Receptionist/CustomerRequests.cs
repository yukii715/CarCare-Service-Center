using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCare_Service_Center
{
    public partial class CustomerRequests : Form
    {
        public CustomerRequests()
        {
            InitializeComponent();
        }

        private void tblCustomerRequests_Load(object sender, EventArgs e)
        {
            string[,] customerArray = { { "00000001", "Dart", "dart@gmail.com" }, { "00000002", "Daryl", "daryl@gmail.com" }, { "00000003", "Yabbo", "yabbo@gmail.com" } };
            for (int i = 0; i < customerArray.GetLength(0); i++)
            {
                CheckBox selectCustomer = new CheckBox();
                tblCustomerRequests.Controls.Add(selectCustomer, 0, i + 1);

                Label newCustomerID = new Label();
                newCustomerID.Text = customerArray[i, 0];
                tblCustomerRequests.Controls.Add(newCustomerID, 1, i + 1);
                newCustomerID.Dock = DockStyle.Fill;
                newCustomerID.TextAlign = ContentAlignment.MiddleLeft;

                Label newCustomerName = new Label();
                newCustomerName.Text = customerArray[i, 1];
                tblCustomerRequests.Controls.Add(newCustomerName, 2, i + 1);
                newCustomerName.Dock = DockStyle.Fill;
                newCustomerName.TextAlign = ContentAlignment.MiddleLeft;

                Label newCustomerEmail = new Label();
                newCustomerEmail.Text = customerArray[i, 2];
                tblCustomerRequests.Controls.Add(newCustomerEmail, 3, i + 1);
                newCustomerEmail.Dock = DockStyle.Fill;
                newCustomerEmail.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnConfirmRequest_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < tblCustomerRequests.RowCount; i++)
            {
                CheckBox selectCustomer = tblCustomerRequests.GetControlFromPosition(0, i) as CheckBox;
                if (selectCustomer != null && selectCustomer.Checked)
                {
                    tblCustomerRequests.RowStyles.RemoveAt(i);
                    tblCustomerRequests.RowCount--;
                }
            }
            MessageBox.Show("Successfully Removed");

        }
    }
}