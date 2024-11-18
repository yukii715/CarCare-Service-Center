
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
    public partial class ServiceInsertion : Form
    {
        private Label lblNewType;
        private TextBox txtNewType;
        private TextBox txtTypePrefix;
        private bool ImageUpload = false;
        private frmAdminMain frmAdmin;


        public ServiceInsertion(frmAdminMain frmAdminMain)
        {
            InitializeComponent();
            frmAdmin = frmAdminMain;
        }

        private void btnNewType_Click(object sender, EventArgs e)
        {
            lblNewType = new Label
            {
                Text = "Name and Prefix:",
                Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(lblServiceType.Location.X, lblServiceType.Location.X + 40)
            };
            txtNewType = new TextBox
            {
                Location = new Point(cmbServiceType.Location.X, cmbServiceType.Location.Y + 40),
                Size = new Size(cmbServiceType.Width, cmbServiceType.Height)
            };
            txtTypePrefix = new TextBox
            {
                Location = new Point(btnNewType.Location.X, btnNewType.Location.Y + 40),
                Size = new Size(btnNewType.Width, btnNewType.Height)
            };
            panel1.Controls.Add(lblNewType);
            panel1.Controls.Add(txtNewType);
            panel1.Controls.Add(txtTypePrefix);

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Top > txtNewType.Top)
                {
                    ctrl.Top += 40;
                }
            }

            btnNewType.Visible = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string service_type;
            string selectedServiceType = cmbServiceType.Text;
            string newServiceType = txtNewType?.Text;
            string typePrefix = txtTypePrefix?.Text;

            if (string.IsNullOrEmpty(selectedServiceType) &&
                (string.IsNullOrWhiteSpace(newServiceType) || !Services.IsServiceTypePrefixValid(typePrefix)))
            {
                MessageBox.Show(
                    string.IsNullOrEmpty(newServiceType) ? "Please select a service type" : "Invalid Service Type",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }

            service_type = string.IsNullOrEmpty(selectedServiceType) ? newServiceType : selectedServiceType;

            if (string.IsNullOrWhiteSpace(txtServiceName.Text))
            {
                MessageBox.Show("Please enter the service name", "Service Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtServiceName.TextLength > 50)
            {
                MessageBox.Show("Invalid Service Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var prices = new List<Services.ServicePrice>();

            for (int row = 0; row < rowCount - 1; row++) // Last row is add button
            {
                if (tlpPrice.GetControlFromPosition(1, row) is TextBox txtPrice &&
                    float.TryParse(txtPrice.Text, out float price) && price > 0 &&
                    tlpPrice.GetControlFromPosition(2, row) is TextBox txtPriceDescription &&
                    !Validation.IsLengthInvalid(txtPriceDescription.Text, 1, 20))
                {
                    prices.Add(new Services.ServicePrice { Price = Decimal.Parse(price.ToString("0.00")), Description = txtPriceDescription.Text });
                }
                else
                {
                    MessageBox.Show("Invalid Price or Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!int.TryParse(txtTime.Text, out int estimated_time) || estimated_time < 1 || estimated_time > 999)
            {
                MessageBox.Show("Invalid Estimated Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter the Description!", "Description Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBriefing.Text))
            {
                MessageBox.Show("Please enter the Briefing!", "Briefing Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!ImageUpload)
            {
                MessageBox.Show("Please upload the service image", "Service Image Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Services service = new Services
            {
                ServiceID = Services.GenerateServiceID(service_type, typePrefix),
                ServiceType = service_type,
                ServiceName = txtServiceName.Text,
                EstimatedTime = estimated_time.ToString(),
                Description = txtDescription.Text,
                Briefing = txtBriefing.Text,
                ImageData = IMG.ToByteArray(picService.Image)
            };

            // Save service into database
            service.Add();

            foreach (var price in prices)
            {
                Services.ServicePrice servicePrice = new Services.ServicePrice
                {
                    ServiceID = service.ServiceID,
                    Price = price.Price,
                    Description = price.Description
                };

                // Save each price record
                servicePrice.Add();
            }
            MessageBox.Show("Successfully created!");
            frmAdmin.tlpServiceData.Controls.Clear();
            frmAdmin.tlpServiceData.RowCount = 1;
            frmAdmin.LoadServices();
            frmAdmin.cmbServiceType.SelectedIndex = -1;
            frmAdmin.txtServiceSearch.Text = "Search";
            Close();
        }

        int rowCount = 2; // Initial number of rows in tlpPrice
        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            // Adding row when button clicked
            rowCount++;
            // Botttom row is add button
            int rowIndex = rowCount - 1; // Start with 1
            int rowCopy = rowCount - 2;  // Row of others control

            // Add new row
            tlpPrice.RowCount = rowCount;
            float rowheight = tlpPrice.GetRowHeights()[0];
            tlpPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, rowheight)); // New row styles


            // Move the add button
            tlpPrice.Controls.Remove(btnAddPrice);
            tlpPrice.Controls.Add(btnAddPrice, 0, rowIndex);

            // Add new control to new line
            Label lblPriceCurrency = new Label { Text = "RM", AutoSize = true };
            tlpPrice.Controls.Add(lblPriceCurrency, 0, rowCopy);
            lblPriceCurrency.Dock = DockStyle.Fill;
            lblPriceCurrency.TextAlign = ContentAlignment.MiddleLeft;

            TextBox txtPriceAmount = new TextBox();
            tlpPrice.Controls.Add(txtPriceAmount, 1, rowCopy);
            txtPriceAmount.Dock = DockStyle.Fill;

            TextBox txtPriceDescription = new TextBox();
            tlpPrice.Controls.Add(txtPriceDescription, 2, rowCopy);
            txtPriceDescription.Dock = DockStyle.Fill;

            Button btnRemovePrice = new Button { Text = "Remove", Dock = DockStyle.Fill };
            tlpPrice.Controls.Add(btnRemovePrice, 3, rowCopy);
            btnRemovePrice.Click += btnRemove_Click;

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Top > tlpPrice.Bottom)
                {
                    ctrl.Top += tlpPrice.GetRowHeights()[rowIndex];
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Cast the sender to a Button
            if (sender is Button clickedButton)
            {
                var btnSelected = tlpPrice.GetPositionFromControl(clickedButton);
                int removeRow = btnSelected.Row;
                foreach (Control control in tlpPrice.Controls.OfType<Control>().Where(c => tlpPrice.GetRow(c) == removeRow).ToList())
                {
                    tlpPrice.Controls.Remove(control);
                    control.Dispose();
                }
                for (int row = removeRow + 1; row < tlpPrice.RowCount; row++)
                {
                    foreach (Control control in tlpPrice.Controls.OfType<Control>().Where(c => tlpPrice.GetRow(c) == row).ToList())
                    {
                        tlpPrice.SetRow(control, row - 1); // Move the control up by one row
                    }
                }

                foreach (Control ctrl in panel1.Controls)
                {
                    if (ctrl.Top > tlpPrice.Bottom)
                    {
                        ctrl.Top -= tlpPrice.GetRowHeights()[rowCount - 1];
                    }
                }

                tlpPrice.RowStyles.RemoveAt(removeRow);
                tlpPrice.RowCount--;
                rowCount--;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            // Show the dialog and check if the user selected a file
            if (fileImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the PictureBox
                    picService.Image = System.Drawing.Image.FromFile(fileImage.FileName);
                    ImageUpload = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void ServiceInsertion_Load(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT ServiceType FROM Services";
            Database.LoadIntoComboBox(cmbServiceType, query, "ServiceType");
        }
    }
}
