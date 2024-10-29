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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabCustomer = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstAppointment = new System.Windows.Forms.ListBox();
            this.crtServiceUsed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Search = new System.Windows.Forms.TabPage();
            this.Appointment = new System.Windows.Forms.TabPage();
            this.History = new System.Windows.Forms.TabPage();
            this.Profile = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.tabCustomer.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtServiceUsed)).BeginInit();
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
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.Controls.Add(this.cmbYear);
            this.Home.Controls.Add(this.label3);
            this.Home.Controls.Add(this.label2);
            this.Home.Controls.Add(this.label1);
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Controls.Add(this.lstAppointment);
            this.Home.Controls.Add(this.crtServiceUsed);
            this.Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home.Location = new System.Drawing.Point(84, 4);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1094, 740);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to CarCare Service Center";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lstAppointment
            // 
            this.lstAppointment.FormattingEnabled = true;
            this.lstAppointment.ItemHeight = 18;
            this.lstAppointment.Location = new System.Drawing.Point(656, 327);
            this.lstAppointment.Name = "lstAppointment";
            this.lstAppointment.ScrollAlwaysVisible = true;
            this.lstAppointment.Size = new System.Drawing.Size(338, 328);
            this.lstAppointment.TabIndex = 1;
            // 
            // crtServiceUsed
            // 
            chartArea3.Name = "ChartArea1";
            this.crtServiceUsed.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.crtServiceUsed.Legends.Add(legend3);
            this.crtServiceUsed.Location = new System.Drawing.Point(100, 327);
            this.crtServiceUsed.Name = "crtServiceUsed";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.crtServiceUsed.Series.Add(series3);
            this.crtServiceUsed.Size = new System.Drawing.Size(440, 324);
            this.crtServiceUsed.TabIndex = 0;
            this.crtServiceUsed.Text = "chart1";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Service Used";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Appointment";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(240, 289);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(108, 26);
            this.cmbYear.TabIndex = 6;
            // 
            // frmCustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.tabCustomer);
            this.Name = "frmCustomerMain";
            this.Text = "CarCare Service Center";
            this.Load += new System.EventHandler(this.frmCustomerMain_Load);
            this.tabCustomer.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtServiceUsed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCustomer;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Search;
        private TabPage Appointment;
        private TabPage History;
        private TabPage Profile;
        private ListBox lstAppointment;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtServiceUsed;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private ComboBox cmbYear;
        private Label label3;
    }
}

