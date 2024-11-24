using ControlSetting;
using Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarCare_Service_Center.Services.ServiceOrder;

namespace CarCare_Service_Center
{
    public partial class frmServiceInProgress : Form
    {
        public frmMechanicMain mechanicMain;
        public Services.ServiceOrder.ServiceEntry serviceEntry;
        private List<Services> services;
        private List<Parts> parts;
        private List<Parts> part_used = new List<Parts>();
        public frmServiceInProgress()
        {
            InitializeComponent();
            lblBottomMargin.Text = string.Empty;
        }

        private void frmServiceInProgress_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Services WHERE ServiceID = " + $"'{serviceEntry.ServiceID}'";
            services = Database.FetchData<Services>(query);

            lblServiceID.Text = serviceEntry.ServiceID;
            lblServiceType.Text = services[0].ServiceType;
            lblServiceName.Text = services[0].ServiceName;

            SetupPartUsedComboBox(0);
            FormClosed += Form_Closed;
        }

        private void SetupPartUsedComboBox(int rowIndex)
        {
            string query = "SELECT * FROM Parts WHERE Stock > 0";
            parts = Database.FetchData<Parts>(query);

            ComboBox cmbPartType = new ComboBox();
            cmbPartType.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular);
            cmbPartType.Dock = DockStyle.Fill;
            cmbPartType.DropDownStyle = ComboBoxStyle.DropDownList;
            tlpPartUsed.Controls.Add(cmbPartType, 1, rowIndex);

            ComboBox cmbPartName = new ComboBox();
            cmbPartName.Dock = DockStyle.Fill;
            cmbPartName.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular);
            cmbPartName.DropDownStyle = ComboBoxStyle.DropDownList;
            tlpPartUsed.Controls.Add(cmbPartName, 2, rowIndex);

            query = "SELECT DISTINCT PartType FROM Parts WHERE Stock > 0";
            Database.LoadIntoComboBox(cmbPartType, query, "PartType");

            PropertyInfo part_type = typeof(Parts).GetProperty("PartType");
            PropertyInfo part_name = typeof(Parts).GetProperty("PartName");
            ComboBoxSetting.SetUpDependentComboBox<Parts>(cmbPartType, cmbPartName, parts, part_type, part_name, part_used);

            Label lblPartID = new Label
            {
                Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tlpPartUsed.Controls.Add(lblPartID, 3, rowIndex);

            Label Stock = new Label
            {
                Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tlpPartUsed.Controls.Add(Stock, 4, rowIndex);

            cmbPartName.SelectedIndexChanged += (s, eArgs) =>
            {
                cmbPartType.Enabled = false;
                cmbPartName.Enabled = false;

                // Retrieve the selected type and name
                string selectedType = cmbPartType.SelectedItem.ToString();
                string selectedName = cmbPartName.SelectedItem.ToString();

                // Find the matching service and display its ServiceID
                var part = parts.Find(p => p.PartType == selectedType && p.PartName == selectedName);
                lblPartID.Text = part.PartID;
                Stock.Text = part.Stock.ToString();

                part_used.Add(part);
            };
        }

        int rowCount = 2; // Initial rows of table 

        private bool IsLastComboBoxValid()
        {
            var cmbPartType = tlpPartUsed.GetControlFromPosition(1, rowCount - 2) as ComboBox;
            var cmbPartName = tlpPartUsed.GetControlFromPosition(2, rowCount - 2) as ComboBox;

            bool isValid = cmbPartType?.SelectedItem != null && cmbPartName?.SelectedItem != null;

            if (!isValid)
            {
                string message = cmbPartType?.SelectedItem == null ? "Please select a Part Type" : "Please select a Part Name";
                MessageBox.Show(message, "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isValid;
        }


        private void Add_Part(object sender, EventArgs e)
        {
            if (!IsLastComboBoxValid())
                return;

            // Adding row when button clicked
            rowCount++;

            // Botttom row is add button
            int rowAdd = rowCount - 1;    // Row of button Add
            int rowIndex = rowCount - 2;  // Row of other controls

            // Add new row
            tlpPartUsed.RowCount = rowCount;
            float rowheight = tlpPartUsed.GetRowHeights()[0];
            tlpPartUsed.RowStyles.Add(new RowStyle(SizeType.Absolute, rowheight)); // New row styles
            tlpPartUsed.Height += (int)rowheight;

            // Move the add button
            tlpPartUsed.Controls.Remove(btnPartAdd);
            tlpPartUsed.Controls.Add(btnPartAdd, 0, rowAdd);

            // Add new control to new line
            SetupPartUsedComboBox(rowIndex);

            Button btnRemove = new Button
            {
                Text = "Remove",
                Dock = DockStyle.Fill,
                Font = new Font("Comic Sans MS", 10F, FontStyle.Regular)
            };
            tlpPartUsed.Controls.Add(btnRemove, 5, rowIndex);
            btnRemove.Click += btnRemove_Click;

            btnDone.Top += (int)rowheight;
            btnBack.Top += (int)rowheight;
            lblBottomMargin.Top += (int)rowheight;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Cast the sender to a Button
            if (sender is Button clickedButton)
            {
                var btnSelected = tlpPartUsed.GetPositionFromControl(clickedButton);
                int removeRow = btnSelected.Row;
                foreach (Control control in tlpPartUsed.Controls.OfType<Control>().Where(c => tlpPartUsed.GetRow(c) == removeRow).ToList())
                {
                    if (control is Label lbl && lbl.Text != null)
                    {
                        var service = part_used.Find(p => p.PartID == lbl.Text);
                        part_used.Remove(service);
                    }
                    tlpPartUsed.Controls.Remove(control);
                    control.Dispose();
                }
                for (int row = removeRow + 1; row < tlpPartUsed.RowCount; row++)
                {
                    foreach (Control control in tlpPartUsed.Controls.OfType<Control>().Where(c => tlpPartUsed.GetRow(c) == row).ToList())
                    {
                        tlpPartUsed.SetRow(control, row - 1); // Move the control up by one row
                    }
                }

                btnDone.Top -= tlpPartUsed.GetRowHeights()[0];
                btnBack.Top -= tlpPartUsed.GetRowHeights()[0];
                lblBottomMargin.Top -= tlpPartUsed.GetRowHeights()[0];

                tlpPartUsed.RowStyles.RemoveAt(removeRow);
                tlpPartUsed.RowCount--;
                tlpPartUsed.Height -= tlpPartUsed.GetRowHeights()[0];
                rowCount--;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInitialStatus.Text) || string.IsNullOrWhiteSpace(txtCompletionStatus.Text))
            {
                string message = string.IsNullOrWhiteSpace(txtInitialStatus.Text) ? "Please enter the Initial Status" : "Please enter the Completion Status";
                MessageBox.Show(message, "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
            "Are you sure this service is completed? No further changes can be made after confirmation.",
            "Confirm Completion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                serviceEntry.IsCompleted = true;
                serviceEntry.InitialStatus = txtInitialStatus.Text;
                serviceEntry.CompletionStatus = txtCompletionStatus.Text;
                serviceEntry.ServiceDone();

                foreach (var part in part_used)
                {
                    var servicePart = new Services.ServiceOrder.ServiceEntry.ServiceParts
                    {

                    };
                }

                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to back to previous page? All changes will be lost.",
            "Back to previous page", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form_Closed(object sender, EventArgs e)
        {
            mechanicMain.LoadServiceInProgress();
        }
    }
}
