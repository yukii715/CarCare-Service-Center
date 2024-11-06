
using Appearance;
namespace CarCare_Service_Center
{
    partial class frmMechanicMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 12D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 21D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 10D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMechanicMain));
            this.tabMechanic = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblCurrenttime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.taskList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnShortages = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.roleProfileChange = new System.Windows.Forms.Label();
            this.mailProfileChange = new System.Windows.Forms.Label();
            this.idProfileChange = new System.Windows.Forms.Label();
            this.nameProfileChange = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.roleProfile = new System.Windows.Forms.Label();
            this.mailProfile = new System.Windows.Forms.Label();
            this.idProfile = new System.Windows.Forms.Label();
            this.nameProfile = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabMechanic.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMechanic
            // 
            this.tabMechanic.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabMechanic.Controls.Add(this.tabPage1);
            this.tabMechanic.Controls.Add(this.tabPage2);
            this.tabMechanic.Controls.Add(this.tabPage3);
            this.tabMechanic.Controls.Add(this.tabPage4);
            this.tabMechanic.Controls.Add(this.tabPage5);
            this.tabMechanic.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabMechanic.ItemSize = new System.Drawing.Size(50, 80);
            this.tabMechanic.Location = new System.Drawing.Point(-3, -2);
            this.tabMechanic.Multiline = true;
            this.tabMechanic.Name = "tabMechanic";
            this.tabMechanic.SelectedIndex = 0;
            this.tabMechanic.Size = new System.Drawing.Size(1181, 826);
            this.tabMechanic.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMechanic.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage1.Controls.Add(this.btnLogOut);
            this.tabPage1.Controls.Add(this.lblCurrenttime);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lbltime);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(84, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 818);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(913, 763);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(133, 52);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lblCurrenttime
            // 
            this.lblCurrenttime.AutoSize = true;
            this.lblCurrenttime.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrenttime.Location = new System.Drawing.Point(280, 243);
            this.lblCurrenttime.Name = "lblCurrenttime";
            this.lblCurrenttime.Size = new System.Drawing.Size(0, 36);
            this.lblCurrenttime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current Session:";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(146, 184);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 36);
            this.lbltime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name : Liew Jun Ming";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(18, 350);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1016, 407);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(857, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome , Mechanic ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(715, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.taskList);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(84, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1093, 818);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Service Task";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(908, 760);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // taskList
            // 
            this.taskList.FormattingEnabled = true;
            this.taskList.ItemHeight = 20;
            this.taskList.Items.AddRange(new object[] {
            "· Oil Change (Engine oil replacement, oil filter change)",
            "· Fluid Checks and Top-offs (Coolant, transmission fluid, brake fluid, etc.)",
            "· Tire Rotation and Balancing",
            "· Tire Replacement and repair services",
            "· Battery Testing and Replacement",
            "· Brake Inspection and Replacement (Pads, rotors, fluid)",
            "· Air Filter Replacement (Engine and cabin air filters)",
            "· Wiper Blade Replacement",
            "· Headlight and Taillight Replacement",
            "· Engine Diagnostics (Check engine light troubleshooting)",
            "· Electrical System Diagnostics",
            "· Transmission Diagnostics",
            "· Suspension and Steering Diagnostics",
            "· Engine Repair and overhauls",
            "· Transmission Repair and replacement",
            "· Brake System Repairs (Calipers, lines, drums/discs)",
            "· Exhaust System Repairs (Muffler replacement, catalytic converter)"});
            this.taskList.Location = new System.Drawing.Point(57, 97);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(949, 624);
            this.taskList.TabIndex = 2;
            this.taskList.SelectedIndexChanged += new System.EventHandler(this.taskList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(857, 93);
            this.label5.TabIndex = 1;
            this.label5.Text = "Service Task";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage3.Controls.Add(this.btnBack);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(84, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1093, 818);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Service Progress";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(21, 753);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 47);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartTask);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 659);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task";
            // 
            // btnStartTask
            // 
            this.btnStartTask.Location = new System.Drawing.Point(733, 581);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(210, 47);
            this.btnStartTask.TabIndex = 2;
            this.btnStartTask.Text = "Start Task";
            this.btnStartTask.UseVisualStyleBackColor = true;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(924, 603);
            this.textBox1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(857, 93);
            this.label6.TabIndex = 2;
            this.label6.Text = "Service Progress";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage4.Controls.Add(this.btnShortages);
            this.tabPage4.Controls.Add(this.btnRequest);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(84, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1093, 818);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Inventory ";
            // 
            // btnShortages
            // 
            this.btnShortages.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShortages.Location = new System.Drawing.Point(363, 436);
            this.btnShortages.Name = "btnShortages";
            this.btnShortages.Size = new System.Drawing.Size(303, 146);
            this.btnShortages.TabIndex = 11;
            this.btnShortages.Text = "Shortages";
            this.btnShortages.UseVisualStyleBackColor = true;
            this.btnShortages.Click += new System.EventHandler(this.btnShortages_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(363, 206);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(303, 146);
            this.btnRequest.TabIndex = 9;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(857, 93);
            this.label8.TabIndex = 2;
            this.label8.Text = "Inventory";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage5.Controls.Add(this.pictureBox3);
            this.tabPage5.Controls.Add(this.roleProfileChange);
            this.tabPage5.Controls.Add(this.mailProfileChange);
            this.tabPage5.Controls.Add(this.idProfileChange);
            this.tabPage5.Controls.Add(this.nameProfileChange);
            this.tabPage5.Controls.Add(this.btnProfile);
            this.tabPage5.Controls.Add(this.roleProfile);
            this.tabPage5.Controls.Add(this.mailProfile);
            this.tabPage5.Controls.Add(this.idProfile);
            this.tabPage5.Controls.Add(this.nameProfile);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Location = new System.Drawing.Point(84, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1093, 818);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Profile";
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(256, 531);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 146);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // roleProfileChange
            // 
            this.roleProfileChange.AutoSize = true;
            this.roleProfileChange.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleProfileChange.Location = new System.Drawing.Point(430, 393);
            this.roleProfileChange.Name = "roleProfileChange";
            this.roleProfileChange.Size = new System.Drawing.Size(229, 60);
            this.roleProfileChange.TabIndex = 13;
            this.roleProfileChange.Text = "Mechanic";
            // 
            // mailProfileChange
            // 
            this.mailProfileChange.AutoSize = true;
            this.mailProfileChange.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailProfileChange.Location = new System.Drawing.Point(430, 305);
            this.mailProfileChange.Name = "mailProfileChange";
            this.mailProfileChange.Size = new System.Drawing.Size(372, 60);
            this.mailProfileChange.TabIndex = 12;
            this.mailProfileChange.Text = "ming@mail.com";
            // 
            // idProfileChange
            // 
            this.idProfileChange.AutoSize = true;
            this.idProfileChange.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProfileChange.Location = new System.Drawing.Point(430, 225);
            this.idProfileChange.Name = "idProfileChange";
            this.idProfileChange.Size = new System.Drawing.Size(181, 60);
            this.idProfileChange.TabIndex = 11;
            this.idProfileChange.Text = "020202";
            // 
            // nameProfileChange
            // 
            this.nameProfileChange.AutoSize = true;
            this.nameProfileChange.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProfileChange.Location = new System.Drawing.Point(430, 143);
            this.nameProfileChange.Name = "nameProfileChange";
            this.nameProfileChange.Size = new System.Drawing.Size(343, 60);
            this.nameProfileChange.TabIndex = 10;
            this.nameProfileChange.Text = "Liew Jun Ming";
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(421, 531);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(303, 146);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.Text = "Edit Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // roleProfile
            // 
            this.roleProfile.AutoSize = true;
            this.roleProfile.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleProfile.Location = new System.Drawing.Point(261, 393);
            this.roleProfile.Name = "roleProfile";
            this.roleProfile.Size = new System.Drawing.Size(163, 60);
            this.roleProfile.TabIndex = 7;
            this.roleProfile.Text = "Role : ";
            // 
            // mailProfile
            // 
            this.mailProfile.AutoSize = true;
            this.mailProfile.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailProfile.Location = new System.Drawing.Point(262, 305);
            this.mailProfile.Name = "mailProfile";
            this.mailProfile.Size = new System.Drawing.Size(162, 60);
            this.mailProfile.TabIndex = 6;
            this.mailProfile.Text = "Mail : ";
            // 
            // idProfile
            // 
            this.idProfile.AutoSize = true;
            this.idProfile.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProfile.Location = new System.Drawing.Point(301, 225);
            this.idProfile.Name = "idProfile";
            this.idProfile.Size = new System.Drawing.Size(107, 60);
            this.idProfile.TabIndex = 5;
            this.idProfile.Text = "ID :";
            // 
            // nameProfile
            // 
            this.nameProfile.AutoSize = true;
            this.nameProfile.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProfile.Location = new System.Drawing.Point(235, 143);
            this.nameProfile.Name = "nameProfile";
            this.nameProfile.Size = new System.Drawing.Size(189, 60);
            this.nameProfile.TabIndex = 4;
            this.nameProfile.Text = "Name : ";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, -4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(912, 121);
            this.label7.TabIndex = 3;
            this.label7.Text = "Profile";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMechanicMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 827);
            this.Controls.Add(this.tabMechanic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMechanicMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mechanic";
            this.Load += new System.EventHandler(this.frmMechanicMain_Load);
            this.tabMechanic.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMechanic;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCurrenttime;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ListBox taskList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label idProfileChange;
        private System.Windows.Forms.Label nameProfileChange;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label roleProfile;
        private System.Windows.Forms.Label mailProfile;
        private System.Windows.Forms.Label idProfile;
        private System.Windows.Forms.Label nameProfile;
        private System.Windows.Forms.Label roleProfileChange;
        private System.Windows.Forms.Label mailProfileChange;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShortages;
        private System.Windows.Forms.Button btnRequest;
    }
}
