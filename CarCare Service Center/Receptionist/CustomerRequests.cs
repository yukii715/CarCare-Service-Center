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
using Functions;
using Users;

namespace CarCare_Service_Center
{
    public partial class CustomerRequests : Form
    {
        private List<RegisteredUser> users;
        public CustomerRequests()
        {
            InitializeComponent();
        }

        private void tblCustomerRequests_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM RegisteredUsers WHERE IsRegistered IS NULL";
            users = Database.FetchData<RegisteredUser>(query);
            for (int i = 0; i < users.Count; i++)
            {
                CheckBox selectCustomer = new CheckBox();
                tblCustomerRequests.Controls.Add(selectCustomer, 0, i + 1);

                Label newCustomerID = new Label();
                newCustomerID.Text = users[i].RegisterID;
                tblCustomerRequests.Controls.Add(newCustomerID, 1, i + 1);
                newCustomerID.Dock = DockStyle.Fill;
                newCustomerID.TextAlign = ContentAlignment.MiddleLeft;

                Label newCustomerName = new Label();
                newCustomerName.Text = users[i].Username;
                tblCustomerRequests.Controls.Add(newCustomerName, 2, i + 1);
                newCustomerName.Dock = DockStyle.Fill;
                newCustomerName.TextAlign = ContentAlignment.MiddleLeft;

                Label newCustomerEmail = new Label();
                newCustomerEmail.Text = users[i].Email;
                tblCustomerRequests.Controls.Add(newCustomerEmail, 3, i + 1);
                newCustomerEmail.Dock = DockStyle.Fill;
                newCustomerEmail.TextAlign = ContentAlignment.MiddleLeft;
            }
            tblCustomerRequests.RowCount = users.Count + 1;
        }

        private void btnConfirmRequest_Click(object sender, EventArgs e)
        {
            // Iterate in reverse to safely remove rows without affecting indices
            for (int i = tblCustomerRequests.RowCount - 1; i >= 1; i--)
            {
                if (tblCustomerRequests.GetControlFromPosition(0, i) is CheckBox selectCustomer && selectCustomer.Checked)
                {
                    string role = "Customer";
                    string newUserID = ID_Generator.UserID(role);
                    User.Add(newUserID, users[i - 1].Username, users[i - 1].Email, users[i - 1].Password, role);
                    RegisteredUser.ChangeStatus(users[i - 1].RegisterID, 1);

                    // Remove row and decrement RowCount
                    foreach (Control control in tblCustomerRequests.Controls.OfType<Control>().Where(c => tblCustomerRequests.GetRow(c) == i).ToList())
                    {
                        tblCustomerRequests.Controls.Remove(control);
                        control.Dispose();
                    }
                    tblCustomerRequests.RowCount--;
                }
            }
            MessageBox.Show("Successfully Added");
        }

        private void btnDenyRequest_Click(object sender, EventArgs e)
        {
            // Iterate in reverse to safely remove rows without affecting indices
            for (int i = tblCustomerRequests.RowCount - 1; i >= 1; i--)
            {
                if (tblCustomerRequests.GetControlFromPosition(0, i) is CheckBox selectCustomer && selectCustomer.Checked)
                {
                    RegisteredUser.ChangeStatus(users[i - 1].RegisterID, 0);

                    // Remove row and decrement RowCount
                    foreach (Control control in tblCustomerRequests.Controls.OfType<Control>().Where(c => tblCustomerRequests.GetRow(c) == i).ToList())
                    {
                        tblCustomerRequests.Controls.Remove(control);
                        control.Dispose();
                    }
                    tblCustomerRequests.RowCount--;
                }
            }
            MessageBox.Show("Request Denied");
        }
    }
}