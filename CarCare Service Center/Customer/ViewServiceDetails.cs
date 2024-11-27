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

namespace CarCare_Service_Center
{
    public partial class frmViewServiceDetails : Form
    {
        private Services service;
        private List<Services.ServicePrice> servicePrices;
        private frmCustomerMain frmCustomerMain;
        public frmViewServiceDetails(frmCustomerMain frmCustomerMain, Services service)
        {
            InitializeComponent();
            this.service = service;
            this.frmCustomerMain = frmCustomerMain;
            lblServiceID.Text = service.ServiceID;
            lblServiceType.Text = service.ServiceType.Trim();
            lblServiceName.Text = service.ServiceName.Trim();
            lblEstimatedTime.Text = service.EstimatedTime.Trim() + " mins";
            lblDescription.Text = service.Description.Trim();
        }

        private void frmViewServiceDetails_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ServicePrice WHERE ServiceID = " + $"'{service.ServiceID}'";
            servicePrices = Database.FetchData<Services.ServicePrice>(query);
            for (int i = 0; i < servicePrices.Count; i++)
            {
                if (i > 0)
                {
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl.Top > tlpPrice.Bottom)
                        {
                            ctrl.Top += tlpPrice.GetRowHeights()[0];
                        }
                    }
                }

                Label lblPrice = new Label
                {
                    Text = $"RM {servicePrices[i].Price.ToString()}",
                    Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                tlpPrice.Controls.Add(lblPrice, 0, i);

                Label lblPriceDescription = new Label
                {
                    Text = $"({servicePrices[i].Description.Trim()})",
                    Font = new Font("Comic Sans MS", 10F, FontStyle.Regular),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                tlpPrice.Controls.Add(lblPriceDescription, 1, i);
            }

            if (lblDescription.Bottom > btnMakeApppointment.Top + 10)
            {
                btnMakeApppointment.Location = new Point(btnMakeApppointment.Location.X, lblDescription.Bottom + 30);
                Label Bottom = new Label
                {
                    Location = new Point(0, lblDescription.Bottom + 50),
                };
                Controls.Add(Bottom);
            }
        }

        private void btnMakeApppointment_Click(object sender, EventArgs e)
        {
            this.frmCustomerMain.switch_tab(2);
            Close();
        }
    }
}
