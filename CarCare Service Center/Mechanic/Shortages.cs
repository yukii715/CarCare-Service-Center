

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

namespace CarCare_Service_Center
{
    public partial class Shortages : Form
    {
        private List<Parts> parts;


        public Shortages()
        {
            InitializeComponent();
            cmbShortagesPartName.Enabled = false;
            cmbShortagesPartType.SelectedIndexChanged += cmbPartType_SelectedIndexChanged;
            cmbShortagesPartName.SelectedIndexChanged += cmbPartName_SelectedIndexChanged;
        }

        private void btnShortagesBack_Click(object sender, EventArgs e)
        {
            frmMechanicMain mechanicMain = Application.OpenForms["frmMechanicMain"] as frmMechanicMain;
            if (mechanicMain != null)
            {
                mechanicMain.BackToTab3();
                this.Close();
            }
        }

        private void Shortages_Load(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT PartType FROM Parts";
            List<Parts> partTypes = Database.FetchData<Parts>(query);

            cmbShortagesPartType.Items.Clear();
            foreach (var partType in partTypes)
            {
                cmbShortagesPartType.Items.Add(partType.PartType);
            }
        }

        private void cmbPartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbShortagesPartName.Items.Clear();
            cmbShortagesPartName.SelectedIndex = -1;
            cmbShortagesPartName.Enabled = true;

            string selectedPartType = cmbShortagesPartType.SelectedItem.ToString();
            string query = $"SELECT * FROM Parts WHERE PartType = '{selectedPartType}' AND Status = 'Sufficient'";
            parts = Database.FetchData<Parts>(query);

            foreach (var part in parts)
            {
                cmbShortagesPartName.Items.Add(part.PartName);
            }
            lblShortagesPartID.Text = "";
            lblShortagesStock.Text = "";

            cmbShortagesPartName.ResetText();
            cmbShortagesPartName.Invalidate();
        }
        private void cmbPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPartName = cmbShortagesPartName.SelectedItem.ToString();

            var selectedPart = parts.FirstOrDefault(p => p.PartName == selectedPartName);

            if (selectedPart != null)
            {
                lblShortagesPartID.Text = selectedPart.PartID.ToString();  //
                lblShortagesStock.Text = selectedPart.Stock.ToString();

            }
        }

        private void btnShortagesReport_Click(object sender, EventArgs e)
        {
            string selectedPartType = cmbShortagesPartType.SelectedItem.ToString();
            string selectedPartName = cmbShortagesPartName.SelectedItem.ToString();

            Parts part = new Parts {PartID = lblShortagesPartID.Text};
            part.ChangeStatus("Shortage");
            MessageBox.Show("Part status has been updated to Shortage.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}


