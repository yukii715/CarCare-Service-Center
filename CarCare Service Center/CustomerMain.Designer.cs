using System.Drawing;
using System.Windows.Forms;

namespace CarCare_Service_Center
{
    partial class frmCustomerMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCustomer = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.TabPage();
            this.Appointment = new System.Windows.Forms.TabPage();
            this.History = new System.Windows.Forms.TabPage();
            this.Profile = new System.Windows.Forms.TabPage();
            this.tabCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCustomer
            // 
            this.tabCustomer.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabCustomer.Controls.Add(this.Home);
            this.tabCustomer.Controls.Add(this.Search);
            this.tabCustomer.Controls.Add(this.Appointment);
            this.tabCustomer.Controls.Add(this.History);
            this.tabCustomer.Controls.Add(this.Profile);
            this.tabCustomer.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabCustomer.ItemSize = new System.Drawing.Size(50, 80);
            this.tabCustomer.Location = new System.Drawing.Point(0, 0);
            this.tabCustomer.Multiline = true;
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.SelectedIndex = 0;
            this.tabCustomer.Size = new System.Drawing.Size(1182, 748);
            this.tabCustomer.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabCustomer_DrawItem);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(84, 4);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1094, 740);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(84, 4);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(1094, 740);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Appointment
            // 
            this.Appointment.Location = new System.Drawing.Point(84, 4);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(1094, 740);
            this.Appointment.TabIndex = 2;
            this.Appointment.Text = "Appointment";
            this.Appointment.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(84, 4);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(1094, 740);
            this.History.TabIndex = 3;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.Profile.Location = new System.Drawing.Point(84, 4);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(1094, 740);
            this.Profile.TabIndex = 4;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // frmCustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.tabCustomer);
            this.Name = "frmCustomerMain";
            this.Text = "CarCare Service Center";
            this.tabCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCustomer;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Search;
        private TabPage Appointment;
        private TabPage History;
        private TabPage Profile;
    }
}

