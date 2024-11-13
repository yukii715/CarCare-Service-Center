
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlSetting;
using Users;

namespace CarCare_Service_Center
{
    public partial class frmMechanicMain : Form
    {
        private Mechanic mechanic;
        public frmMechanicMain(Mechanic mec)
        {
            InitializeComponent();
            mechanic = mec;
            sessionStartTime = DateTime.Now;
            timer1.Start();
            btnBack.Click += btnBack_Click;

        }
        private DateTime sessionStartTime;



        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH:mm:ss");
            TimeSpan sessionDuration = DateTime.Now - sessionStartTime;
            lblCurrenttime.Text = sessionDuration.ToString(@"hh\:mm\:ss");


        }

        private void taskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskList.SelectedIndex >= 0)
            {
                string selectedItem = taskList.SelectedItem.ToString();
                textBox1.Text = selectedItem;

                tabMechanic.SelectedIndex = 2;
            }
            if (taskList.SelectedIndex != 1)
            {
                textBox1.Text = taskList.SelectedItem.ToString();
                tabMechanic.SelectedTab = tabPage3;
            }
        }
        public void SwitchToTab2()
        {
            tabMechanic.SelectedIndex = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabMechanic.SelectedTab = tabPage2;
            textBox1.Clear();

        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            foreach (var item in taskList.Items)
            {
                if (textBox1.Text == item.ToString())
                {
                    Progress progressform = new Progress();
                    progressform.ShowDialog();
                    return;
                }

            }
            MessageBox.Show($"Please Select a valid task from the list to start the task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            EditProfile editprofileform = new EditProfile(this);
            editprofileform.ShowDialog();
        }
        public void updateProfile(string name, string mail)
        {
            nameProfileChange.Text = name;
            mailProfileChange.Text = mail;
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Request requestform = new Request();
            requestform.ShowDialog();
        }



        private void btnShortages_Click(object sender, EventArgs e)
        {
            Shortages shortagesform = new Shortages();
            shortagesform.ShowDialog();
        }

        private void frmMechanicMain_Load(object sender, EventArgs e)
        {
            tabMechanic.DrawItem += Draw_Item.tabControlAdjustment;
        }
    }
}
