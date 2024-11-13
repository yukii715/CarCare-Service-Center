using System.Drawing;
using System.Windows.Forms;
using ControlSetting;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabCustomer = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstAppointment = new System.Windows.Forms.ListBox();
            this.crtServiceUsed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Search = new System.Windows.Forms.TabPage();
            this.pnlSearchResults = new System.Windows.Forms.Panel();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Appointment = new System.Windows.Forms.TabPage();
            this.tabAppointment = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlNewAppointment = new System.Windows.Forms.Panel();
            this.btnAddApointment = new System.Windows.Forms.Button();
            this.tlpServices = new System.Windows.Forms.TableLayoutPanel();
            this.btnAptAdd = new System.Windows.Forms.Button();
            this.cmbAptServiceType = new System.Windows.Forms.ComboBox();
            this.cmbAptServiceName = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtVehicleNumber = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbAptMinute = new System.Windows.Forms.ComboBox();
            this.cmbAptHour = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbAptDay = new System.Windows.Forms.ComboBox();
            this.cmbAptMonth = new System.Windows.Forms.ComboBox();
            this.cmbAptYear = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.History = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Profile = new System.Windows.Forms.TabPage();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.btnChangeUserName = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.lblBottomMargin = new System.Windows.Forms.Label();
            this.tabCustomer.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtServiceUsed)).BeginInit();
            this.Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Appointment.SuspendLayout();
            this.tabAppointment.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlNewAppointment.SuspendLayout();
            this.tlpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.History.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Profile.SuspendLayout();
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
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(240, 289);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(90, 26);
            this.cmbYear.TabIndex = 6;
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
            this.crtServiceUsed.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea14.Name = "ChartArea1";
            this.crtServiceUsed.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.crtServiceUsed.Legends.Add(legend14);
            this.crtServiceUsed.Location = new System.Drawing.Point(100, 327);
            this.crtServiceUsed.Name = "crtServiceUsed";
            this.crtServiceUsed.Size = new System.Drawing.Size(440, 324);
            this.crtServiceUsed.TabIndex = 0;
            this.crtServiceUsed.Text = "chart1";
            // 
            // Search
            // 
            this.Search.Controls.Add(this.pnlSearchResults);
            this.Search.Controls.Add(this.cmbServiceType);
            this.Search.Controls.Add(this.label5);
            this.Search.Controls.Add(this.label4);
            this.Search.Controls.Add(this.txtSearch);
            this.Search.Controls.Add(this.pictureBox2);
            this.Search.Location = new System.Drawing.Point(84, 4);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(1094, 740);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // pnlSearchResults
            // 
            this.pnlSearchResults.AutoScroll = true;
            this.pnlSearchResults.Location = new System.Drawing.Point(50, 165);
            this.pnlSearchResults.Name = "pnlSearchResults";
            this.pnlSearchResults.Size = new System.Drawing.Size(988, 569);
            this.pnlSearchResults.TabIndex = 8;
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceType.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Items.AddRange(new object[] {
            "All"});
            this.cmbServiceType.Location = new System.Drawing.Point(397, 94);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(341, 30);
            this.cmbServiceType.TabIndex = 7;
            this.cmbServiceType.SelectedIndexChanged += new System.EventHandler(this.cmbServiceType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Service Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSearch.Location = new System.Drawing.Point(68, 96);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 26);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(829, -22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Appointment
            // 
            this.Appointment.Controls.Add(this.tabAppointment);
            this.Appointment.Location = new System.Drawing.Point(84, 4);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(1094, 740);
            this.Appointment.TabIndex = 2;
            this.Appointment.Text = "Appointment";
            this.Appointment.UseVisualStyleBackColor = true;
            // 
            // tabAppointment
            // 
            this.tabAppointment.Controls.Add(this.tabPage1);
            this.tabAppointment.Controls.Add(this.tabPage2);
            this.tabAppointment.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAppointment.Location = new System.Drawing.Point(3, 0);
            this.tabAppointment.Name = "tabAppointment";
            this.tabAppointment.SelectedIndex = 0;
            this.tabAppointment.Size = new System.Drawing.Size(1088, 744);
            this.tabAppointment.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlNewAppointment);
            this.tabPage1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 707);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Appointment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlNewAppointment
            // 
            this.pnlNewAppointment.AutoScroll = true;
            this.pnlNewAppointment.Controls.Add(this.lblBottomMargin);
            this.pnlNewAppointment.Controls.Add(this.btnAddApointment);
            this.pnlNewAppointment.Controls.Add(this.tlpServices);
            this.pnlNewAppointment.Controls.Add(this.label19);
            this.pnlNewAppointment.Controls.Add(this.txtVehicleNumber);
            this.pnlNewAppointment.Controls.Add(this.label18);
            this.pnlNewAppointment.Controls.Add(this.label17);
            this.pnlNewAppointment.Controls.Add(this.cmbAptMinute);
            this.pnlNewAppointment.Controls.Add(this.cmbAptHour);
            this.pnlNewAppointment.Controls.Add(this.label12);
            this.pnlNewAppointment.Controls.Add(this.label11);
            this.pnlNewAppointment.Controls.Add(this.cmbAptDay);
            this.pnlNewAppointment.Controls.Add(this.cmbAptMonth);
            this.pnlNewAppointment.Controls.Add(this.cmbAptYear);
            this.pnlNewAppointment.Controls.Add(this.label10);
            this.pnlNewAppointment.Controls.Add(this.label6);
            this.pnlNewAppointment.Controls.Add(this.label7);
            this.pnlNewAppointment.Controls.Add(this.pictureBox3);
            this.pnlNewAppointment.Location = new System.Drawing.Point(6, 6);
            this.pnlNewAppointment.Name = "pnlNewAppointment";
            this.pnlNewAppointment.Size = new System.Drawing.Size(1074, 695);
            this.pnlNewAppointment.TabIndex = 6;
            // 
            // btnAddApointment
            // 
            this.btnAddApointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddApointment.Location = new System.Drawing.Point(412, 596);
            this.btnAddApointment.Name = "btnAddApointment";
            this.btnAddApointment.Size = new System.Drawing.Size(215, 39);
            this.btnAddApointment.TabIndex = 20;
            this.btnAddApointment.Text = "Add Appointment";
            this.btnAddApointment.UseVisualStyleBackColor = true;
            // 
            // tlpServices
            // 
            this.tlpServices.AutoSize = true;
            this.tlpServices.ColumnCount = 5;
            this.tlpServices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.47472F));
            this.tlpServices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.7917F));
            this.tlpServices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.7917F));
            this.tlpServices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.47174F));
            this.tlpServices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.47014F));
            this.tlpServices.Controls.Add(this.lblServiceID, 3, 0);
            this.tlpServices.Controls.Add(this.btnAptAdd, 0, 1);
            this.tlpServices.Controls.Add(this.cmbAptServiceType, 1, 0);
            this.tlpServices.Controls.Add(this.cmbAptServiceName, 2, 0);
            this.tlpServices.Location = new System.Drawing.Point(128, 364);
            this.tlpServices.Name = "tlpServices";
            this.tlpServices.RowCount = 2;
            this.tlpServices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpServices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpServices.Size = new System.Drawing.Size(839, 80);
            this.tlpServices.TabIndex = 19;
            // 
            // btnAptAdd
            // 
            this.btnAptAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAptAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAptAdd.Location = new System.Drawing.Point(3, 43);
            this.btnAptAdd.Name = "btnAptAdd";
            this.btnAptAdd.Size = new System.Drawing.Size(107, 34);
            this.btnAptAdd.TabIndex = 0;
            this.btnAptAdd.Text = "Add";
            this.btnAptAdd.UseVisualStyleBackColor = true;
            this.btnAptAdd.Click += new System.EventHandler(this.Add_Service);
            // 
            // cmbAptServiceType
            // 
            this.cmbAptServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbAptServiceType.FormattingEnabled = true;
            this.cmbAptServiceType.Location = new System.Drawing.Point(116, 3);
            this.cmbAptServiceType.Name = "cmbAptServiceType";
            this.cmbAptServiceType.Size = new System.Drawing.Size(243, 32);
            this.cmbAptServiceType.TabIndex = 1;
            // 
            // cmbAptServiceName
            // 
            this.cmbAptServiceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbAptServiceName.FormattingEnabled = true;
            this.cmbAptServiceName.Location = new System.Drawing.Point(365, 3);
            this.cmbAptServiceName.Name = "cmbAptServiceName";
            this.cmbAptServiceName.Size = new System.Drawing.Size(243, 32);
            this.cmbAptServiceName.TabIndex = 2;
            this.cmbAptServiceName.SelectedIndexChanged += new System.EventHandler(this.cmbAptServiceName_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(35, 364);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 24);
            this.label19.TabIndex = 18;
            this.label19.Text = "Services:";
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.Location = new System.Drawing.Point(204, 300);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.Size = new System.Drawing.Size(297, 33);
            this.txtVehicleNumber.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 303);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 24);
            this.label18.TabIndex = 16;
            this.label18.Text = "Vehicle Number:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(232, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 24);
            this.label17.TabIndex = 15;
            this.label17.Text = ":";
            // 
            // cmbAptMinute
            // 
            this.cmbAptMinute.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAptMinute.ForeColor = System.Drawing.Color.Gray;
            this.cmbAptMinute.FormattingEnabled = true;
            this.cmbAptMinute.Location = new System.Drawing.Point(264, 239);
            this.cmbAptMinute.Name = "cmbAptMinute";
            this.cmbAptMinute.Size = new System.Drawing.Size(93, 28);
            this.cmbAptMinute.TabIndex = 14;
            this.cmbAptMinute.Text = "Minutes";
            // 
            // cmbAptHour
            // 
            this.cmbAptHour.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAptHour.ForeColor = System.Drawing.Color.Gray;
            this.cmbAptHour.FormattingEnabled = true;
            this.cmbAptHour.Location = new System.Drawing.Point(122, 239);
            this.cmbAptHour.Name = "cmbAptHour";
            this.cmbAptHour.Size = new System.Drawing.Size(93, 28);
            this.cmbAptHour.TabIndex = 13;
            this.cmbAptHour.Text = "Hour";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "/";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "/";
            // 
            // cmbAptDay
            // 
            this.cmbAptDay.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAptDay.ForeColor = System.Drawing.Color.Gray;
            this.cmbAptDay.FormattingEnabled = true;
            this.cmbAptDay.Location = new System.Drawing.Point(408, 179);
            this.cmbAptDay.Name = "cmbAptDay";
            this.cmbAptDay.Size = new System.Drawing.Size(93, 28);
            this.cmbAptDay.TabIndex = 10;
            this.cmbAptDay.Text = "Day";
            // 
            // cmbAptMonth
            // 
            this.cmbAptMonth.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAptMonth.ForeColor = System.Drawing.Color.Gray;
            this.cmbAptMonth.FormattingEnabled = true;
            this.cmbAptMonth.Location = new System.Drawing.Point(265, 179);
            this.cmbAptMonth.Name = "cmbAptMonth";
            this.cmbAptMonth.Size = new System.Drawing.Size(93, 28);
            this.cmbAptMonth.TabIndex = 9;
            this.cmbAptMonth.Text = "Month";
            // 
            // cmbAptYear
            // 
            this.cmbAptYear.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAptYear.ForeColor = System.Drawing.Color.Gray;
            this.cmbAptYear.FormattingEnabled = true;
            this.cmbAptYear.Location = new System.Drawing.Point(122, 179);
            this.cmbAptYear.Name = "cmbAptYear";
            this.cmbAptYear.Size = new System.Drawing.Size(93, 28);
            this.cmbAptYear.TabIndex = 8;
            this.cmbAptYear.Text = "Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(406, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 34);
            this.label7.TabIndex = 5;
            this.label7.Text = "New Appointment";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(808, -24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(223, 210);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 707);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Appointment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Location = new System.Drawing.Point(5, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1071, 706);
            this.panel4.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(405, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 34);
            this.label9.TabIndex = 5;
            this.label9.Text = "My Appointment";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(808, -24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(223, 210);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // History
            // 
            this.History.Controls.Add(this.panel3);
            this.History.Location = new System.Drawing.Point(84, 4);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(1094, 740);
            this.History.TabIndex = 3;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1049, 729);
            this.panel3.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(427, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 34);
            this.label8.TabIndex = 5;
            this.label8.Text = "History";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(808, -24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(223, 210);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.lblAdminEmail);
            this.Profile.Controls.Add(this.lblAdminName);
            this.Profile.Controls.Add(this.lblAdminID);
            this.Profile.Controls.Add(this.btnChangePassword);
            this.Profile.Controls.Add(this.btnChangeEmail);
            this.Profile.Controls.Add(this.btnChangeUserName);
            this.Profile.Controls.Add(this.label13);
            this.Profile.Controls.Add(this.label14);
            this.Profile.Controls.Add(this.label15);
            this.Profile.Controls.Add(this.label16);
            this.Profile.Location = new System.Drawing.Point(84, 4);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(1094, 740);
            this.Profile.TabIndex = 4;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminEmail.Location = new System.Drawing.Point(372, 351);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(0, 34);
            this.lblAdminEmail.TabIndex = 32;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(372, 277);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(0, 34);
            this.lblAdminName.TabIndex = 31;
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminID.Location = new System.Drawing.Point(372, 203);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(0, 34);
            this.lblAdminID.TabIndex = 30;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(723, 559);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(208, 52);
            this.btnChangePassword.TabIndex = 29;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEmail.Location = new System.Drawing.Point(410, 559);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(208, 52);
            this.btnChangeEmail.TabIndex = 28;
            this.btnChangeEmail.Text = "Change Email";
            this.btnChangeEmail.UseVisualStyleBackColor = true;
            // 
            // btnChangeUserName
            // 
            this.btnChangeUserName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeUserName.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUserName.Location = new System.Drawing.Point(97, 559);
            this.btnChangeUserName.Name = "btnChangeUserName";
            this.btnChangeUserName.Size = new System.Drawing.Size(208, 52);
            this.btnChangeUserName.TabIndex = 27;
            this.btnChangeUserName.Text = "Change User Name";
            this.btnChangeUserName.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(161, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 34);
            this.label13.TabIndex = 26;
            this.label13.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(161, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 34);
            this.label14.TabIndex = 25;
            this.label14.Text = "User Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(161, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 34);
            this.label15.TabIndex = 24;
            this.label15.Text = "UserID:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Ink Free", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(451, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 54);
            this.label16.TabIndex = 23;
            this.label16.Text = "Profile";
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServiceID.Location = new System.Drawing.Point(614, 0);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(107, 40);
            this.lblServiceID.TabIndex = 21;
            this.lblServiceID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBottomMargin
            // 
            this.lblBottomMargin.AutoSize = true;
            this.lblBottomMargin.Location = new System.Drawing.Point(470, 640);
            this.lblBottomMargin.Name = "lblBottomMargin";
            this.lblBottomMargin.Size = new System.Drawing.Size(0, 24);
            this.lblBottomMargin.TabIndex = 21;
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
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Appointment.ResumeLayout(false);
            this.tabAppointment.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlNewAppointment.ResumeLayout(false);
            this.pnlNewAppointment.PerformLayout();
            this.tlpServices.ResumeLayout(false);
            this.tlpServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.History.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
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
        private TextBox txtSearch;
        private PictureBox pictureBox2;
        private Label label4;
        private ComboBox cmbServiceType;
        private Label label5;
        private Panel pnlSearchResults;
        private PictureBox pictureBox3;
        private Panel pnlNewAppointment;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private PictureBox pictureBox4;
        private Label lblAdminEmail;
        private Label lblAdminName;
        private Label lblAdminID;
        private Button btnChangePassword;
        private Button btnChangeEmail;
        private Button btnChangeUserName;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TabControl tabAppointment;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel4;
        private Label label9;
        private PictureBox pictureBox5;
        private ComboBox cmbAptYear;
        private Label label10;
        private Label label6;
        private ComboBox cmbAptDay;
        private ComboBox cmbAptMonth;
        private Label label11;
        private Label label17;
        private ComboBox cmbAptMinute;
        private ComboBox cmbAptHour;
        private Label label12;
        private Label label19;
        private TextBox txtVehicleNumber;
        private Label label18;
        private TableLayoutPanel tlpServices;
        private Button btnAptAdd;
        private ComboBox cmbAptServiceType;
        private Button btnAddApointment;
        private ComboBox cmbAptServiceName;
        private Label lblServiceID;
        private Label lblBottomMargin;
    }
}

