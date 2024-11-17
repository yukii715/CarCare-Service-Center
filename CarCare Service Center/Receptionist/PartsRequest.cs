using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions;
using Users;

namespace CarCare_Service_Center
{
    public partial class PartsRequest : Form
    {
        private string partRequestID;
        private List<Parts> partList;
        public PartsRequest(string requestID, string partName, string partType)
        {
            InitializeComponent();

            string query = "SELECT DISTINCT PartType FROM Parts";
            Database.LoadIntoComboBox(cmbPartType, query, "PartType");

            query = "SELECT * FROM Parts";
            partList = Database.FetchData<Parts>(query);

            partRequestID = requestID;
            txtPartName.Text = partName;
            cmbPartType.Text = partType;

            if (cmbPartType.SelectedIndex == -1)
            {
                cmbPartType.SelectedIndex = 0;
                txtNewPartType.Text = partType;
                txtPrefix.ReadOnly = false;
                txtNewPartType.ReadOnly = false;
            }
            else
            {
                foreach (var partID in partList)
                {
                    if (cmbPartType.Text == partID.PartType)
                    {
                        txtPartID.Text = partID.PartID;
                        txtPrefix.Text = partID.PartID.Substring(0, 3);
                    }
                }
            }
        }

        private void cmbPartType_TextChanged(object sender, EventArgs e)
        {
            if (cmbPartType.SelectedIndex != 0)
            {
                txtPrefix.ReadOnly = true;
                txtNewPartType.ReadOnly = true;
            }
            else
            {
                txtPrefix.ReadOnly = false;
                txtNewPartType.ReadOnly = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string partName = txtPartName?.Text;
            string partType = cmbPartType.Text;
            string newPartType = txtNewPartType?.Text;
            string partPrefix = txtPrefix?.Text;

            if (cmbPartType.SelectedIndex == 0)
            {
                foreach (var part in partList)
                {
                    if (partName == part.PartName)
                    {
                        MessageBox.Show("Repeated Part Name Entered");
                        return;
                    }
                    else if (newPartType == part.PartType)
                    {
                        MessageBox.Show("Part Type Already Exist");
                        return;
                    }
                    else if (partPrefix == part.PartID.Substring(0, 3))
                    {
                        MessageBox.Show("Prefix is Assigned to Another Part Type");
                        return;
                    }
                }
                if (string.IsNullOrEmpty(partName) || string.IsNullOrWhiteSpace(partName) ||
                    string.IsNullOrEmpty(newPartType) || string.IsNullOrWhiteSpace(newPartType) ||
                    string.IsNullOrEmpty(partPrefix) || string.IsNullOrWhiteSpace(partPrefix))
                {
                    MessageBox.Show("All fields must be entered");
                }
                else if (txtPartName.TextLength > 50 || txtNewPartType.TextLength > 50)
                {
                    MessageBox.Show("Part name cannot exceed 50 charcters");
                }
                else if (!Parts.IsPartTypePrefixValid(partPrefix))
                {
                    MessageBox.Show("Invalid prefix entered, must only consist of 3 capitalised letters.");                    
                }
                else
                {
                    Parts partList = new Parts
                    {
                        PartID = Parts.GeneratePartID(partType, partPrefix),
                        PartType = newPartType,
                        PartName = partName,
                    };
                    partList.Add();
                    
                    string query = "UPDATE PartsRequests SET IsApproved = 1 WHERE RequestID = @RequestID";
                    using (SqlConnection connection = new SqlConnection(Program.connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@RequestID", partRequestID);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                foreach (var part in partList)
                {
                    if (partName == part.PartName)
                    {
                        MessageBox.Show("Repeated Part Name Entered");
                        return;
                    }
                }
            }
            frmReceptionistMain menuMain = Application.OpenForms.OfType<frmReceptionistMain>().FirstOrDefault();
            menuMain.LoadPartsRequests();
            MessageBox.Show("New part type created.");
            Close();
        }
    }
}
