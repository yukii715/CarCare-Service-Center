using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarCare_Service_Center.Services;

namespace CarCare_Service_Center
{
    public partial class frmRating : Form
    {
        private ServiceOrder serviceOrder;
        private frmHistoryDetails frmHistoryDetails;
        private List<Label> Rates = new List<Label>();
        private int rate;
        public frmRating(ServiceOrder serviceOrder, frmHistoryDetails frmHistoryDetails)
        {
            InitializeComponent();
            this.serviceOrder = serviceOrder;
            this.frmHistoryDetails = frmHistoryDetails;
        }

        private void frmRating_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i ++)
            {
                foreach (Control ctrl in Controls)
                {
                    if (ctrl is Label lbl && lbl.Name == "Rate_" + i)
                    {
                        Rates.Add(lbl);
                    }
                }
            }
            foreach (Label lbl in Rates)
            {
                lbl.Click += (s, eV) =>
                {
                    Rates.ForEach(rate => rate.Text = "☆");
                    int rateIndex = int.Parse(lbl.Name.Split('_')[1]);
                    rate = rateIndex;

                    for (int i = 0; i < rateIndex; i++)
                    {
                        Rates[i].Text = "★";
                    }
                };
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rate == 0)
            {
                MessageBox.Show("Raating cannot be empty", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
            "Are you sure you want to submit this rating and feedback? Changes will not be allowed after submission.",
            "Submit Rating and Feedback", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                serviceOrder.Rating = rate;
                serviceOrder.Feedback = txtFeebBack.Text;
                serviceOrder.Rate();
                frmHistoryDetails.LoadRatingAndFeedBack();
                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
