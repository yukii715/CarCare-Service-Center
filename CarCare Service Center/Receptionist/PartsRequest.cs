
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions;
using Users;
using ControlSetting;

namespace CarCare_Service_Center
{
    public partial class PartsRequest : Form
    {
        private Parts.Requests Requests;
        private frmReceptionistMain frmReceptionistMain;
        private List<Parts> partList;
        public PartsRequest(Parts.Requests requests, frmReceptionistMain frmReceptionistMain)
        {
            InitializeComponent();
            Requests = requests;
            this.frmReceptionistMain = frmReceptionistMain;
            Text = requests.RequestID + " " + requests.PartType;
            txtPartName.Text = requests.PartName;
            FormClosed += Form_Closed;
        }
        private void PartsRequest_Load(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT PartType FROM Parts";
            Database.LoadIntoComboBox(cmbPartType, query, "PartType");

            query = "SELECT * FROM Parts";
            partList = Database.FetchData<Parts>(query);
            
            cmbPartType.SelectedItem = Requests.PartType;
            if (cmbPartType.SelectedIndex == 0)
            {
                txtPrefix.ReadOnly = false;
                txtNewPartType.ReadOnly = false;
            }
            else
                txtPrefix.Text = Parts.GeneratePartID(Requests.PartType, txtPrefix.Text).Substring(0, 3);
        }
        private void cmbPartType_TextChanged(object sender, EventArgs e)
        {
            if (cmbPartType.SelectedIndex != 0)
            {
                txtPrefix.ReadOnly = true;
                txtNewPartType.ReadOnly = true;
                txtPrefix.Text = Parts.GeneratePartID(cmbPartType.Text, txtPrefix.Text).Substring(0, 3);
            }
            else
            {
                txtPrefix.ReadOnly = false;
                txtNewPartType.ReadOnly = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string partName = txtPartName.Text;
            string partType = cmbPartType.SelectedIndex == 0 ? txtNewPartType.Text : cmbPartType.Text;
            string partPrefix = txtPrefix.Text;

            foreach (var part in partList)
            {
                if (partName.ToLower().Trim() == part.PartName.ToLower().Trim())
                {
                    MessageBox.Show("Part Name already existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (partPrefix == part.PartID.Substring(0,3) && txtPrefix.ReadOnly == false)
                {
                    MessageBox.Show("Part Prefix already existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(partName) || string.IsNullOrWhiteSpace(partType) || string.IsNullOrWhiteSpace(partPrefix))
            {
                MessageBox.Show("All fields must be entered", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPartName.TextLength > 50 || txtNewPartType.TextLength > 50)
            {
                MessageBox.Show("Part Name and Part Type cannot exceed 50 charcters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Parts.IsPartTypePrefixValid(partPrefix))
            {
                MessageBox.Show("Invalid prefix entered, must only consist of 3 capitalised letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Requests.Approve();

            Parts newPart = new Parts
            {
                PartID = Parts.GeneratePartID(partType, partPrefix),
                PartType = partType,
                PartName = partName,
            };
            newPart.Add();

            MessageBox.Show($"Part {newPart.PartName} added, the PartID is {newPart.PartID}", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to reject this request?", "Reject Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Requests.Reject();
                Close();
            }
        }
        private void Form_Closed(object sender, EventArgs e)
        {
            frmReceptionistMain.LoadPartsInventory();
            frmReceptionistMain.LoadPartsRequests();
        }
    }
}
