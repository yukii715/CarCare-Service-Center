using Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace CarCare_Service_Center
{
    public partial class ServiceDetails : Form
    {
        Services service = new Services();
        List<Services.ServicePrice> service_price = new List<Services.ServicePrice>();

        public ServiceDetails(Services s = null)
        {
            InitializeComponent();
            service = s;
        }


        private void ServiceDetails_Load(object sender, EventArgs e)
        {
            string query = "Select * FROM ServicePrice;";
            service_price = Database.FetchData<Services.ServicePrice>(query);


            lblServiceID.Text = "Service ID: " + service.ServiceID;
            lblServiceType.Text = "Service Type: " + service.ServiceType;
            lblServiceName.Text = "Service Name: " + service.ServiceName.Trim();
            var servicePrice = from Price in service_price
                               where Price.ServiceID == service.ServiceID
                               select Price;

            service_price = servicePrice.ToList();

            for (int i = 0; i < service_price.Count; i++)
            {
                Label priceCurrency = new Label
                {
                    Text = "RM",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = true,
                };
                tlpPrice.Controls.Add(priceCurrency, 0, i);

                Label priceAmount = new Label
                {
                    Text = service_price[i].Price.ToString(),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = true,
                };
                tlpPrice.Controls.Add(priceAmount, 1, i);

                Label description = new Label
                {
                    Text = "(" + service_price[i].Description + ")",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
                };
                tlpPrice.Controls.Add(description, 2, i);

                foreach (Control ctrl in panel1.Controls)
                {
                    if (ctrl.Top > tlpPrice.Bottom)
                    {
                        ctrl.Top += tlpPrice.GetRowHeights()[0];
                    }
                }
                tlpPrice.RowCount++;
            }

            lblTime.Text = "Estimated Time: " + service.EstimatedTime.ToString() + " Mins";
            lblDescription.Text = service.Description;

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Top > lblDescription.Top)
                {
                    ctrl.Top += lblDescription.Size.Height;
                }
            }

            lblTitle.Text = service.ServiceID + " " + service.ServiceName;
            lblBriefDescription.Text = service.Briefing;

            using (MemoryStream ms = new MemoryStream(service.ImageData))
            {
                Image img = Image.FromStream(ms);
                // Set the image to the PictureBox
                picService.Image = img;
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            ServiceEdit serviceDetailConfiguration = new ServiceEdit(service, service_price, this);
            serviceDetailConfiguration.Show();
            Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ServiceDeletion serviceDeletion = new ServiceDeletion();
            serviceDeletion.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}