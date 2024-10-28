using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCare_Service_Center
{
    public partial class frmMechanicMain : Form
    {
        public frmMechanicMain()
        {
            InitializeComponent();
            sessionStartTime = DateTime.Now;
            timer1.Start();

        }
        private DateTime sessionStartTime;
        private void tabMechanic_DrawItem(Object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabMechanic.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabMechanic.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Blue);
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }
            else
            {
                _textBrush = new SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {
         
        }
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
        }
    }
}
