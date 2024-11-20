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
    public partial class frmLogoutConfirmation : Form
    {
        Form Form;
        public frmLogoutConfirmation(Form form)
        {
            InitializeComponent();
            Form = form;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin LoginForm = new frmLogin();
            Hide();
            Form.Hide();
            LoginForm.ShowDialog();
            Close();
            Form.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
