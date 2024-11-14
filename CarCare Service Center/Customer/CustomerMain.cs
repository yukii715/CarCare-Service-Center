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
using Users;
using ControlSetting;
using System.Runtime.ConstrainedExecution;
using System.Reflection;

namespace CarCare_Service_Center
{
    public partial class frmCustomerMain : Form
    {
        private List<Services> services;
        private List<Services> selected_services = new List<Services>();
        private Customer customer;
        public frmCustomerMain(Customer cus)
        {
            InitializeComponent();
            customer = cus;
            Place_Holder.SetPlaceHolder(txtSearch, "Search...");
            ComboBoxSetting.SetupYearMonthDayComboBoxes(cmbAptYear, cmbAptMonth, cmbAptDay);
            ComboBoxSetting.SetupHourMinuteComboBoxes(cmbAptHour, cmbAptMinute);
        }

        public void switch_tab(int tab_index)
        {
            tabCustomer.SelectedIndex = tab_index;
        }

        private void frmCustomerMain_Load(object sender, EventArgs e)
        {
            int row = 0;
            tabCustomer.DrawItem += Draw_Item.tabControlAdjustment;
            string query = "SELECT * FROM Services WHERE IsDeleted = 0";
            services = Database.FetchData<Services>(query);

            for (int i = 0; i < services.Count; i++)
            {
                show_results(ref i, ref row);
            }

            foreach (Control control in FindComboBoxes(tabCustomer))
            {
                if (control is ComboBox comboBox)
                {
                    ComboBoxSetting.Set(comboBox);
                }
            }
            AddServiceTypeIntoComboBox(cmbServiceType);
            SetupComboBoxPlaceHolder();
            SetupInitialServiceSelection();
        }
        private void AddServiceTypeIntoComboBox(ComboBox cmb)
        {
            string query = "SELECT DISTINCT ServiceType FROM Services";
            Database.LoadIntoComboBox(cmb, query, "ServiceType");
        }
        private void SetComboBoxPlaceholder(ComboBox comboBox, string placeholder)
        {
            if (comboBox.SelectedIndex == -1)
            {
                comboBox.ForeColor = Color.Gray;
                comboBox.Text = placeholder;
            }
        }
        private void SetupComboBoxPlaceHolder()
        {
            SetComboBoxPlaceholder(cmbAptYear, "Year");
            SetComboBoxPlaceholder(cmbAptMonth, "Month");
            SetComboBoxPlaceholder(cmbAptDay, "Day");
            SetComboBoxPlaceholder(cmbAptHour, "Hour");
            SetComboBoxPlaceholder(cmbAptMinute, "Minutes");
        }

        private IEnumerable<ComboBox> FindComboBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is ComboBox comboBox)
                {
                    yield return comboBox;
                }
                else if (control.HasChildren)
                {
                    foreach (ComboBox childComboBox in FindComboBoxes(control))
                    {
                        yield return childComboBox;
                    }
                }
            }
        }
        //
        //  Search
        //
        private void show_results(ref int i , ref int row )
        {
            int start_X = 3;
            int start_Y = 35;

            Label title = new Label
            {
                Text = "Results",
                Font = new Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular),
                Location = new Point(10, 5),
            };
            pnlSearchResults.Controls.Add(title);

            GroupBox groupBox = new GroupBox
            {
                Text = $"{services[i].ServiceID} {services[i].ServiceName.Trim()}",
                Font = new Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular),
                Location = new Point(start_X, start_Y + 240 * row),
                Size = new Size(630, 200)
            };
            pnlSearchResults.Controls.Add(groupBox);

            Label Briefing = new Label
            {
                Text = services[i].Briefing.Trim(),
                Location = new Point(6, 30),
                AutoSize = false,
                Size = new Size(390, 120)
            };
            groupBox.Controls.Add(Briefing);

            LinkLabel ViewMore = new LinkLabel
            {
                Text = "View More",
                Location = new Point(6, 160),
                Tag = services[i]
            };
            ViewMore.Click += ViewMore_Click;
            groupBox.Controls.Add(ViewMore);

            PictureBox ServiceImage = new PictureBox
            {
                Image = IMG.ConvertByByteArray(services[i].ImageData),
                Location = new Point(400, 36),
                Size = new Size(210, 120),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            groupBox.Controls.Add(ServiceImage);

            row++;
        }
        private void ViewMore_Click(object sender, EventArgs e)
        {
            Services service = (Services)(sender as LinkLabel).Tag;
            frmViewServiceDetails frmViewServiceDetails = new frmViewServiceDetails(this, service);
            frmViewServiceDetails.Show();
        } 

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            int row = 0;
            if (e.KeyCode == Keys.Enter)
            {
                pnlSearchResults.Controls.Clear();
                string search = txtSearch.Text.ToLower();
                bool noResults = true;
                e.SuppressKeyPress = true;

                if (string.IsNullOrEmpty(cmbServiceType.Text) || cmbServiceType.Text == "All")
                {
                    for (int i = 0; i < services.Count; i++)
                    {
                        if (services[i].ServiceName.ToLower().Contains(search))
                        {
                            show_results(ref i, ref row);
                            noResults = false;
                        }
                    }
                }

                else
                {
                    for (int i = 0; i < services.Count; i++)
                    {
                        if (services[i].ServiceName.ToLower().Contains(search) && cmbServiceType.Text == services[i].ServiceType)
                        {
                            show_results(ref i, ref row);
                            noResults = false;
                        }
                    }
                }

                if (noResults)
                {
                    Label NoResult = new Label
                    {
                        Text = "No Results",
                        Font = new Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular),
                        Location = new Point(10, 25),
                        AutoSize = true
                    };
                    pnlSearchResults.Controls.Add(NoResult);
                }
            }
        }

        private void cmbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row = 0;
            pnlSearchResults.Controls.Clear();
            for (int i = 0; i < services.Count; i++) 
            {
                if (cmbServiceType.SelectedIndex == 0)
                    show_results(ref i, ref row);
                if (cmbServiceType.Text == services[i].ServiceType)
                    show_results(ref i, ref row);
            }

        }
        //
        // Appointment
        //
        private void SetupServiceComboBox(int rowIndex)
        {
            ComboBox cmbServiceType = new ComboBox();
            cmbServiceType.Dock = DockStyle.Fill;
            tlpServices.Controls.Add(cmbServiceType, 1, rowIndex);

            ComboBox cmbServiceName = new ComboBox();
            cmbServiceName.Dock = DockStyle.Fill;
            tlpServices.Controls.Add(cmbServiceName, 2, rowIndex);

            AddServiceTypeIntoComboBox(cmbServiceType);

            PropertyInfo service_type = typeof(Services).GetProperty("ServiceType");
            PropertyInfo service_name = typeof(Services).GetProperty("ServiceName");
            ComboBoxSetting.SetUpDependentComboBox<Services>(cmbServiceType, cmbServiceName, services, service_type, service_name, selected_services);

            Label lblServiceID = new Label
            {
                Font = new Font("Comic Sans MS", 9F, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tlpServices.Controls.Add(lblServiceID, 3, rowIndex);

            cmbServiceName.SelectedIndexChanged += (s, eArgs) =>
            {
                // Retrieve the selected type and name
                string selectedType = cmbServiceType.SelectedItem.ToString();
                string selectedName = cmbServiceName.SelectedItem.ToString();

                // Find the matching service and display its ServiceID
                var service = services.Find(ser => ser.ServiceType == selectedType && ser.ServiceName == selectedName);
                lblServiceID.Text = service.ServiceID;

                selected_services.Add(service);
            };
        }

        int rowCount = 2; // Initial rows of table 
        private void SetupInitialServiceSelection()
        {
            tlpServices.Controls.Clear();

            float rowheight = 27f;
            btnAddApointment.Top -= (int)rowheight * (rowCount -2);
            btnAptClear.Top -= (int)rowheight * (rowCount - 2);
            lblBottomMargin.Top -= (int)rowheight * (rowCount - 2);

            rowCount = 2;

            // Botttom row is add button
            int rowAdd = rowCount - 1;    // Row of button Add
            int rowIndex = rowCount - 2;  // Row of other controls

            // Add new row
            tlpServices.RowCount = rowCount;
            tlpServices.RowStyles.Clear();
            tlpServices.RowStyles.Add(new RowStyle(SizeType.Absolute, rowheight));
            tlpServices.RowStyles.Add(new RowStyle(SizeType.Absolute, rowheight));
            tlpServices.Height = (int)rowheight * 2;

            // Add button
            tlpServices.Controls.Add(btnAptAdd, 0, rowAdd);

            // Add new control to new line
            SetupServiceComboBox(rowIndex);
        }

        private bool IsLastComboBoxValid()
        {
            var cmbServiceType = tlpServices.GetControlFromPosition(1, rowCount - 2) as ComboBox;
            var cmbServiceName = tlpServices.GetControlFromPosition(2, rowCount - 2) as ComboBox;

            bool isValid = cmbServiceType?.SelectedItem != null && cmbServiceName?.SelectedItem != null;

            if (!isValid)
            {
                string message = cmbServiceType?.SelectedItem == null ? "Please select a Service Type" : "Please select a Service Name";
                MessageBox.Show(message, "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isValid;
        }


        private void Add_Service(object sender, EventArgs e)
        {
            if (!IsLastComboBoxValid())
                return;

            // Adding row when button clicked
            rowCount++;

            // Botttom row is add button
            int rowAdd = rowCount - 1;    // Row of button Add
            int rowIndex = rowCount - 2;  // Row of other controls

            // Add new row
            tlpServices.RowCount = rowCount;
            float rowheight = tlpServices.GetRowHeights()[0];
            tlpServices.RowStyles.Add(new RowStyle(SizeType.Absolute, rowheight)); // New row styles
            tlpServices.Height += (int)rowheight;

            // Move the add button
            tlpServices.Controls.Remove(btnAptAdd);
            tlpServices.Controls.Add(btnAptAdd, 0, rowAdd);

            // Add new control to new line
            SetupServiceComboBox(rowIndex);

            Button btnRemove = new Button
            {
                Text = "Remove",
                Dock = DockStyle.Fill,
                Font = new Font("Comic Sans MS", 9F, FontStyle.Regular)
            };
            tlpServices.Controls.Add(btnRemove, 4, rowIndex);
            btnRemove.Click += btnRemove_Click;

            btnAddApointment.Top += (int)rowheight;
            btnAptClear.Top += (int)rowheight;
            lblBottomMargin.Top += (int)rowheight;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Cast the sender to a Button
            if (sender is Button clickedButton)
            {
                var btnSelected = tlpServices.GetPositionFromControl(clickedButton);
                int removeRow = btnSelected.Row;
                foreach (Control control in tlpServices.Controls.OfType<Control>().Where(c => tlpServices.GetRow(c) == removeRow).ToList())
                {
                    if (control is Label lbl && lbl.Text != null)
                    {
                        var service = selected_services.Find(s => s.ServiceID == lbl.Text);
                        selected_services.Remove(service);
                    }
                    tlpServices.Controls.Remove(control);
                    control.Dispose();
                }
                for (int row = removeRow + 1; row < tlpServices.RowCount; row++)
                {
                    foreach (Control control in tlpServices.Controls.OfType<Control>().Where(c => tlpServices.GetRow(c) == row).ToList())
                    {
                        tlpServices.SetRow(control, row - 1); // Move the control up by one row
                    }
                }

                btnAddApointment.Top -= tlpServices.GetRowHeights()[0];
                btnAptClear.Top -= tlpServices.GetRowHeights()[0];
                lblBottomMargin.Top -= tlpServices.GetRowHeights()[0];

                tlpServices.RowStyles.RemoveAt(removeRow);
                tlpServices.RowCount--;
                tlpServices.Height -= tlpServices.GetRowHeights()[0];
                rowCount--;
            }
        }

        private void btnAptClear_Click(object sender, EventArgs e)
        {
            txtVehicleNumber.Clear();
            SetupInitialServiceSelection();
            selected_services.Clear();
            foreach (Control ctrl in pnlNewAppointment.Controls)
            {
                if (ctrl is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                    SetupComboBoxPlaceHolder();
                }
            }
        }

        private void btnAddApointment_Click(object sender, EventArgs e)
        {
            string message;
            foreach (Control ctrl in pnlNewAppointment.Controls)
            {
                if (ctrl is ComboBox cmb && cmb.SelectedIndex == -1)
                {
                    message = "Oops! It seems like Appointment is incomplete. Check each section for any missing information.";
                    MessageBox.Show(message, "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!Appointment.IsVehicleNumberValid(txtVehicleNumber.Text))
            {
                MessageBox.Show("Please ensure that all letters are capitalized and that the input does not contain any spaces.", 
                    "Invalid Vehicle Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsLastComboBoxValid())
                return;

            MessageBox.Show("Appointment Added Successfully!");
            btnAptClear_Click(sender, e);
        }
    }
}
