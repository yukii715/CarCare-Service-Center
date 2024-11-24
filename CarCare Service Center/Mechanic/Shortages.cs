


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions;
using ControlSetting;
using Users;
using System.Reflection;

namespace CarCare_Service_Center
{
    public partial class Shortages : Form
    {
        private List<Parts> parts;


        public Shortages()
        {
            InitializeComponent();
            lblShortagesPartID.Text = string.Empty;
            lblShortagesStock.Text = string.Empty;
        }

        private void Shortages_Load(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT PartType FROM Parts Where Status = 'Sufficient'";
            Database.LoadIntoComboBox(cmbPartType, query, "PartType");

            query = "SELECT * FROM Parts";
            parts = Database.FetchData<Parts>(query);
        }
        private void cmbPartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT PartName FROM Parts Where PartType = " + $"'{cmbPartType.Text}'" + "AND Status = 'Sufficient'";
            Database.LoadIntoComboBox(cmbPartName, query, "PartName");
        }

        private void cmbPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblShortagesPartID.Text = parts.Find(p => p.PartType == cmbPartType.Text && p.PartName == cmbPartName.Text).PartID;
            lblShortagesStock.Text = parts.Find(p => p.PartType == cmbPartType.Text && p.PartName == cmbPartName.Text).Stock.ToString();
        }
        private void btnShortagesReport_Click(object sender, EventArgs e)
        {
            Parts part = new Parts { PartID = lblShortagesPartID.Text };
            part.ChangeStatus("Shortage");
            MessageBox.Show($"Part {lblShortagesPartID.Text} status has been updated to Shortage.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnShortagesBack_Click(object sender, EventArgs e)
        {
            Close();
        } 
    }
}
