using System.Drawing;
using System.Windows.Forms;
using Appearance;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabCustomer = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Search = new System.Windows.Forms.TabPage();
            this.Appointment = new System.Windows.Forms.TabPage();
            this.History = new System.Windows.Forms.TabPage();
            this.Profile = new System.Windows.Forms.TabPage();
            this.tabCustomer.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.tabCustomer.DrawItem += Draw_Item.tabControlAdjustment;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.label1);
            this.Home.Controls.Add(this.listBox1);
            this.Home.Controls.Add(this.chart1);
            this.Home.Location = new System.Drawing.Point(84, 4);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1094, 740);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to CarCare Service Center";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(638, 274);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(368, 328);
            this.listBox1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(112, 274);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(440, 324);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(675, 305);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 310);
            this.listBox1.TabIndex = 1;
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
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCustomer;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Search;
        private TabPage Appointment;
        private TabPage History;
        private TabPage Profile;
        private ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
    }
}

