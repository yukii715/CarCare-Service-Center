
using Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace CarCare_Service_Center
{
    public partial class ServiceEdit : Form
    {
        private ServiceDetails serviceDetail;
        private List<Services.ServicePrice> service_price;
        private Services service;
        private bool ImageUpload = false;

        // row index for the add button
        int rowIndex = 0;


        public ServiceEdit(Services s, List<Services.ServicePrice> p, ServiceDetails sd)
        {
            InitializeComponent();
            serviceDetail = sd;
            service = s;
            service_price = p;
        }

        private void ServiceEdit_Load(object sender, EventArgs e)
        {
            lblServiceID.Text = "Service ID: " + service.ServiceID;
            lblServiceType.Text = "Service Type: " + service.ServiceType;
            lblServiceName.Text = "Service Name: " + service.ServiceName;

            tlpPrice.Controls.Remove(btnAddPrice);

            for (int i = 0; i < service_price.Count; i++)
            {
                tlpPrice.RowCount++;
                rowIndex++;

                Label lblPriceCurrency = new Label
                {
                    Text = "RM",
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                };
                tlpPrice.Controls.Add(lblPriceCurrency, 0, i);


                TextBox txtPriceAmount = new TextBox
                {
                    Text = service_price[i].Price.ToString(),
                    Dock = DockStyle.Fill,
                };
                tlpPrice.Controls.Add(txtPriceAmount, 1, i);


                TextBox txtDescription = new TextBox
                {
                    Text = service_price[i].Description,
                    Dock = DockStyle.Fill,
                };
                tlpPrice.Controls.Add(txtDescription, 2, i);

                if (i == 0)
                {
                    continue;
                }

                Button btnRemovePrice = new Button
                {
                    Text = "Remove",
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                };
                tlpPrice.Controls.Add(btnRemovePrice, 3, i);
                btnRemovePrice.Click += btnRemove_Click;
            }
            tlpPrice.Controls.Add(btnAddPrice, 0, rowIndex);
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Top > tlpPrice.Top)
                {
                    ctrl.Top = ctrl.Top + tlpPrice.Height - tlpPrice.GetRowHeights()[0];
                }
            };

            txtTime.Text = service.EstimatedTime;
            txtDescription.Text = service.Description;
            txtBriefDescription.Text = service.Briefing;

            using (MemoryStream ms = new MemoryStream(service.ImageData))
            {
                Image img = Image.FromStream(ms);
                // Set the image to the PictureBox
                picService.Image = img;
            }
        }

        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            rowIndex++;
            int rowCopy = rowIndex - 1;  // Row of others control

            // Add new row
            tlpPrice.RowCount++;
            float rowheight = tlpPrice.GetRowHeights()[0];
            tlpPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, rowheight)); // New row styles


            // Move the add button
            tlpPrice.Controls.Remove(btnAddPrice);
            tlpPrice.Controls.Add(btnAddPrice, 0, rowIndex);

            // Add new control to new line
            Label lblPriceCurrency = new Label
            {
                Text = "RM",
                AutoSize = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tlpPrice.Controls.Add(lblPriceCurrency, 0, rowCopy);


            TextBox txtPriceAmount = new TextBox { Dock = DockStyle.Fill };
            tlpPrice.Controls.Add(txtPriceAmount, 1, rowCopy);

            TextBox txtPriceDescription = new TextBox { Dock = DockStyle.Fill };
            tlpPrice.Controls.Add(txtPriceDescription, 2, rowCopy);

            Button btnRemovePrice = new Button
            {
                Text = "Remove",
                Dock = DockStyle.Fill
            };
            tlpPrice.Controls.Add(btnRemovePrice, 3, rowCopy);
            btnRemovePrice.Click += btnRemove_Click;

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Top > tlpPrice.Top)
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
                    if (ctrl.Top > tlpPrice.Top)
                    {
                        ctrl.Top -= tlpPrice.GetRowHeights()[rowIndex - 1];
                    }
                }

                tlpPrice.RowStyles.RemoveAt(removeRow);
                tlpPrice.RowCount--;
                rowIndex--;
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            serviceDetail.Show();
        }
    }
}
