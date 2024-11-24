
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 12D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 21D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 10D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMechanicMain));
            this.tabMechanic = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCurrenttime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tlpServiceTask = new System.Windows.Forms.TableLayoutPanel();
            this.lblServicetaskNote = new System.Windows.Forms.Label();
            this.lblServicetaskCusName = new System.Windows.Forms.Label();
            this.lblServicetaskService = new System.Windows.Forms.Label();
            this.lblServicetaskDate = new System.Windows.Forms.Label();
            this.lblServiceTaskTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlServiceProgress = new System.Windows.Forms.Panel();
            this.lblBottomMargin = new System.Windows.Forms.Label();
            this.btnEndTask = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.grbAddService = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.tlpServiceProgress = new System.Windows.Forms.TableLayoutPanel();
            this.lblProgressNote = new System.Windows.Forms.Label();
            this.lblProgressService = new System.Windows.Forms.Label();
            this.tlpProgress = new System.Windows.Forms.TableLayoutPanel();
            this.lblProgressPlateNumber = new System.Windows.Forms.Label();
            this.lblProgressUserID = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblProgressApointmentId = new System.Windows.Forms.Label();
            this.lblAppointmentId = new System.Windows.Forms.Label();
            this.lblProgressNoPlate = new System.Windows.Forms.Label();
            this.lblProgressCusName = new System.Windows.Forms.Label();
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
            this.lblHome = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblReload = new System.Windows.Forms.Label();
            this.tabMechanic.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tlpServiceTask.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlServiceProgress.SuspendLayout();
            this.grbAddService.SuspendLayout();
            this.tlpServiceProgress.SuspendLayout();
            this.tlpProgress.SuspendLayout();
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
            this.tabMechanic.Location = new System.Drawing.Point(-3, 37);
            this.tabMechanic.Multiline = true;
            this.tabMechanic.Name = "tabMechanic";
            this.tabMechanic.SelectedIndex = 0;
            this.tabMechanic.Size = new System.Drawing.Size(1180, 729);
            this.tabMechanic.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMechanic.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PapayaWhip;
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
            this.tabPage1.Size = new System.Drawing.Size(1092, 696);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // lblCurrenttime
            // 
            this.lblCurrenttime.AutoSize = true;
            this.lblCurrenttime.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrenttime.Location = new System.Drawing.Point(280, 219);
            this.lblCurrenttime.Name = "lblCurrenttime";
            this.lblCurrenttime.Size = new System.Drawing.Size(0, 36);
            this.lblCurrenttime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current Session:";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(146, 166);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 36);
            this.lbltime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 106);
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
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(6, 314);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            series9.Points.Add(dataPoint25);
            series9.Points.Add(dataPoint26);
            series9.Points.Add(dataPoint27);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(1016, 367);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(856, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome , Mechanic ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(755, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage2.Controls.Add(this.tlpServiceTask);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(84, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 696);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Service Task";
            // 
            // tlpServiceTask
            // 
            this.tlpServiceTask.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpServiceTask.ColumnCount = 5;
            this.tlpServiceTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpServiceTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpServiceTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tlpServiceTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpServiceTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpServiceTask.Controls.Add(this.lblServicetaskNote, 0, 0);
            this.tlpServiceTask.Controls.Add(this.lblServicetaskCusName, 1, 0);
            this.tlpServiceTask.Controls.Add(this.lblServicetaskService, 2, 0);
            this.tlpServiceTask.Controls.Add(this.lblServicetaskDate, 3, 0);
            this.tlpServiceTask.Controls.Add(this.lblServiceTaskTime, 4, 0);
            this.tlpServiceTask.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpServiceTask.Location = new System.Drawing.Point(30, 93);
            this.tlpServiceTask.Name = "tlpServiceTask";
            this.tlpServiceTask.RowCount = 1;
            this.tlpServiceTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpServiceTask.Size = new System.Drawing.Size(1012, 100);
            this.tlpServiceTask.TabIndex = 10;
            // 
            // lblServicetaskNote
            // 
            this.lblServicetaskNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServicetaskNote.Location = new System.Drawing.Point(6, 3);
            this.lblServicetaskNote.Name = "lblServicetaskNote";
            this.lblServicetaskNote.Size = new System.Drawing.Size(63, 94);
            this.lblServicetaskNote.TabIndex = 0;
            this.lblServicetaskNote.Text = "NO";
            this.lblServicetaskNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServicetaskCusName
            // 
            this.lblServicetaskCusName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServicetaskCusName.Location = new System.Drawing.Point(78, 3);
            this.lblServicetaskCusName.Name = "lblServicetaskCusName";
            this.lblServicetaskCusName.Size = new System.Drawing.Size(192, 94);
            this.lblServicetaskCusName.TabIndex = 1;
            this.lblServicetaskCusName.Text = "NAME";
            this.lblServicetaskCusName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServicetaskService
            // 
            this.lblServicetaskService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServicetaskService.Location = new System.Drawing.Point(279, 3);
            this.lblServicetaskService.Name = "lblServicetaskService";
            this.lblServicetaskService.Size = new System.Drawing.Size(451, 94);
            this.lblServicetaskService.TabIndex = 2;
            this.lblServicetaskService.Text = "SERVICE";
            this.lblServicetaskService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServicetaskDate
            // 
            this.lblServicetaskDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServicetaskDate.Location = new System.Drawing.Point(739, 3);
            this.lblServicetaskDate.Name = "lblServicetaskDate";
            this.lblServicetaskDate.Size = new System.Drawing.Size(172, 94);
            this.lblServicetaskDate.TabIndex = 3;
            this.lblServicetaskDate.Text = "DATE";
            this.lblServicetaskDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServiceTaskTime
            // 
            this.lblServiceTaskTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServiceTaskTime.Location = new System.Drawing.Point(920, 3);
            this.lblServiceTaskTime.Name = "lblServiceTaskTime";
            this.lblServiceTaskTime.Size = new System.Drawing.Size(86, 94);
            this.lblServiceTaskTime.TabIndex = 4;
            this.lblServiceTaskTime.Text = "TIME";
            this.lblServiceTaskTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(856, 83);
            this.label5.TabIndex = 1;
            this.label5.Text = "Service Task";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage3.Controls.Add(this.pnlServiceProgress);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(84, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1092, 721);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Service Progress";
            // 
            // pnlServiceProgress
            // 
            this.pnlServiceProgress.AutoScroll = true;
            this.pnlServiceProgress.Controls.Add(this.lblBottomMargin);
            this.pnlServiceProgress.Controls.Add(this.btnEndTask);
            this.pnlServiceProgress.Controls.Add(this.txtRemark);
            this.pnlServiceProgress.Controls.Add(this.lblRemark);
            this.pnlServiceProgress.Controls.Add(this.grbAddService);
            this.pnlServiceProgress.Controls.Add(this.btnStartTask);
            this.pnlServiceProgress.Controls.Add(this.tlpServiceProgress);
            this.pnlServiceProgress.Controls.Add(this.tlpProgress);
            this.pnlServiceProgress.Location = new System.Drawing.Point(12, 86);
            this.pnlServiceProgress.Name = "pnlServiceProgress";
            this.pnlServiceProgress.Size = new System.Drawing.Size(1077, 637);
            this.pnlServiceProgress.TabIndex = 12;
            // 
            // lblBottomMargin
            // 
            this.lblBottomMargin.AutoSize = true;
            this.lblBottomMargin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomMargin.Location = new System.Drawing.Point(428, 919);
            this.lblBottomMargin.Name = "lblBottomMargin";
            this.lblBottomMargin.Size = new System.Drawing.Size(203, 33);
            this.lblBottomMargin.TabIndex = 13;
            this.lblBottomMargin.Text = "[Bottom Margin]";
            // 
            // btnEndTask
            // 
            this.btnEndTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEndTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndTask.Location = new System.Drawing.Point(398, 862);
            this.btnEndTask.Name = "btnEndTask";
            this.btnEndTask.Size = new System.Drawing.Size(264, 54);
            this.btnEndTask.TabIndex = 19;
            this.btnEndTask.Text = "End Task";
            this.btnEndTask.UseVisualStyleBackColor = true;
            this.btnEndTask.Visible = false;
            this.btnEndTask.Click += new System.EventHandler(this.btnEndTask_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(28, 592);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemark.Size = new System.Drawing.Size(1002, 252);
            this.txtRemark.TabIndex = 18;
            this.txtRemark.Visible = false;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.Location = new System.Drawing.Point(32, 557);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(149, 36);
            this.lblRemark.TabIndex = 17;
            this.lblRemark.Text = "REMARK";
            this.lblRemark.Visible = false;
            // 
            // grbAddService
            // 
            this.grbAddService.Controls.Add(this.label10);
            this.grbAddService.Controls.Add(this.label9);
            this.grbAddService.Controls.Add(this.btnAdd);
            this.grbAddService.Controls.Add(this.cmbService);
            this.grbAddService.Controls.Add(this.cmbServiceType);
            this.grbAddService.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddService.Location = new System.Drawing.Point(28, 358);
            this.grbAddService.Name = "grbAddService";
            this.grbAddService.Size = new System.Drawing.Size(1002, 188);
            this.grbAddService.TabIndex = 16;
            this.grbAddService.TabStop = false;
            this.grbAddService.Text = "Add Service";
            this.grbAddService.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(108, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 33);
            this.label10.TabIndex = 12;
            this.label10.Text = "Service :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 33);
            this.label9.TabIndex = 11;
            this.label9.Text = "Service Type :";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(793, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(193, 63);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbService
            // 
            this.cmbService.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(264, 109);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(483, 41);
            this.cmbService.TabIndex = 8;
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Location = new System.Drawing.Point(264, 52);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(483, 41);
            this.cmbServiceType.TabIndex = 9;
            // 
            // btnStartTask
            // 
            this.btnStartTask.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnStartTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTask.Location = new System.Drawing.Point(433, 318);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(264, 54);
            this.btnStartTask.TabIndex = 12;
            this.btnStartTask.Text = "Start Task";
            this.btnStartTask.UseVisualStyleBackColor = false;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // tlpServiceProgress
            // 
            this.tlpServiceProgress.AutoSize = true;
            this.tlpServiceProgress.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpServiceProgress.ColumnCount = 2;
            this.tlpServiceProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.4F));
            this.tlpServiceProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.6F));
            this.tlpServiceProgress.Controls.Add(this.lblProgressNote, 0, 0);
            this.tlpServiceProgress.Controls.Add(this.lblProgressService, 1, 0);
            this.tlpServiceProgress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpServiceProgress.Location = new System.Drawing.Point(17, 180);
            this.tlpServiceProgress.MaximumSize = new System.Drawing.Size(1002, 0);
            this.tlpServiceProgress.Name = "tlpServiceProgress";
            this.tlpServiceProgress.RowCount = 1;
            this.tlpServiceProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpServiceProgress.Size = new System.Drawing.Size(1002, 64);
            this.tlpServiceProgress.TabIndex = 15;
            // 
            // lblProgressNote
            // 
            this.lblProgressNote.AutoSize = true;
            this.lblProgressNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgressNote.Location = new System.Drawing.Point(5, 2);
            this.lblProgressNote.Name = "lblProgressNote";
            this.lblProgressNote.Size = new System.Drawing.Size(77, 60);
            this.lblProgressNote.TabIndex = 6;
            this.lblProgressNote.Text = "NO";
            this.lblProgressNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProgressService
            // 
            this.lblProgressService.AutoSize = true;
            this.lblProgressService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgressService.Location = new System.Drawing.Point(90, 2);
            this.lblProgressService.Name = "lblProgressService";
            this.lblProgressService.Size = new System.Drawing.Size(907, 60);
            this.lblProgressService.TabIndex = 5;
            this.lblProgressService.Text = "SERVICE";
            this.lblProgressService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpProgress
            // 
            this.tlpProgress.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpProgress.ColumnCount = 4;
            this.tlpProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpProgress.Controls.Add(this.lblProgressPlateNumber, 3, 1);
            this.tlpProgress.Controls.Add(this.lblProgressUserID, 2, 0);
            this.tlpProgress.Controls.Add(this.lblClientName, 1, 1);
            this.tlpProgress.Controls.Add(this.lblClientID, 3, 0);
            this.tlpProgress.Controls.Add(this.lblProgressApointmentId, 0, 0);
            this.tlpProgress.Controls.Add(this.lblAppointmentId, 1, 0);
            this.tlpProgress.Controls.Add(this.lblProgressNoPlate, 2, 1);
            this.tlpProgress.Controls.Add(this.lblProgressCusName, 0, 1);
            this.tlpProgress.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpProgress.Location = new System.Drawing.Point(17, 14);
            this.tlpProgress.Name = "tlpProgress";
            this.tlpProgress.RowCount = 2;
            this.tlpProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProgress.Size = new System.Drawing.Size(1002, 143);
            this.tlpProgress.TabIndex = 14;
            // 
            // lblProgressPlateNumber
            // 
            this.lblProgressPlateNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgressPlateNumber.Location = new System.Drawing.Point(704, 72);
            this.lblProgressPlateNumber.Name = "lblProgressPlateNumber";
            this.lblProgressPlateNumber.Size = new System.Drawing.Size(293, 69);
            this.lblProgressPlateNumber.TabIndex = 13;
            // 
            // lblProgressUserID
            // 
            this.lblProgressUserID.Location = new System.Drawing.Point(504, 2);
            this.lblProgressUserID.Name = "lblProgressUserID";
            this.lblProgressUserID.Size = new System.Drawing.Size(192, 68);
            this.lblProgressUserID.TabIndex = 12;
            this.lblProgressUserID.Text = "USER ID";
            this.lblProgressUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientName
            // 
            this.lblClientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClientName.Location = new System.Drawing.Point(205, 72);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(291, 69);
            this.lblClientName.TabIndex = 11;
            // 
            // lblClientID
            // 
            this.lblClientID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClientID.Location = new System.Drawing.Point(704, 2);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(293, 68);
            this.lblClientID.TabIndex = 10;
            // 
            // lblProgressApointmentId
            // 
            this.lblProgressApointmentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgressApointmentId.Location = new System.Drawing.Point(5, 2);
            this.lblProgressApointmentId.Name = "lblProgressApointmentId";
            this.lblProgressApointmentId.Size = new System.Drawing.Size(192, 68);
            this.lblProgressApointmentId.TabIndex = 8;
            this.lblProgressApointmentId.Text = "APPOINTMENT ID";
            this.lblProgressApointmentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppointmentId
            // 
            this.lblAppointmentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppointmentId.Location = new System.Drawing.Point(205, 2);
            this.lblAppointmentId.Name = "lblAppointmentId";
            this.lblAppointmentId.Size = new System.Drawing.Size(291, 68);
            this.lblAppointmentId.TabIndex = 9;
            // 
            // lblProgressNoPlate
            // 
            this.lblProgressNoPlate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgressNoPlate.Location = new System.Drawing.Point(504, 72);
            this.lblProgressNoPlate.Name = "lblProgressNoPlate";
            this.lblProgressNoPlate.Size = new System.Drawing.Size(192, 69);
            this.lblProgressNoPlate.TabIndex = 6;
            this.lblProgressNoPlate.Text = "PLATE NUMBER";
            this.lblProgressNoPlate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProgressCusName
            // 
            this.lblProgressCusName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgressCusName.Location = new System.Drawing.Point(5, 72);
            this.lblProgressCusName.Name = "lblProgressCusName";
            this.lblProgressCusName.Size = new System.Drawing.Size(192, 69);
            this.lblProgressCusName.TabIndex = 4;
            this.lblProgressCusName.Text = "NAME";
            this.lblProgressCusName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(856, 83);
            this.label6.TabIndex = 13;
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
            this.tabPage4.Size = new System.Drawing.Size(1092, 732);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Inventory ";
            // 
            // btnShortages
            // 
            this.btnShortages.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShortages.Location = new System.Drawing.Point(363, 392);
            this.btnShortages.Name = "btnShortages";
            this.btnShortages.Size = new System.Drawing.Size(303, 131);
            this.btnShortages.TabIndex = 11;
            this.btnShortages.Text = "Shortages";
            this.btnShortages.UseVisualStyleBackColor = true;
            this.btnShortages.Click += new System.EventHandler(this.btnShortages_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(363, 185);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(303, 131);
            this.btnRequest.TabIndex = 9;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(856, 83);
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
            this.tabPage5.Size = new System.Drawing.Size(1092, 696);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Profile";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(256, 478);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 131);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // roleProfileChange
            // 
            this.roleProfileChange.AutoSize = true;
            this.roleProfileChange.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleProfileChange.Location = new System.Drawing.Point(430, 353);
            this.roleProfileChange.Name = "roleProfileChange";
            this.roleProfileChange.Size = new System.Drawing.Size(229, 60);
            this.roleProfileChange.TabIndex = 13;
            this.roleProfileChange.Text = "Mechanic";
            // 
            // mailProfileChange
            // 
            this.mailProfileChange.AutoSize = true;
            this.mailProfileChange.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailProfileChange.Location = new System.Drawing.Point(430, 274);
            this.mailProfileChange.Name = "mailProfileChange";
            this.mailProfileChange.Size = new System.Drawing.Size(372, 60);
            this.mailProfileChange.TabIndex = 12;
            this.mailProfileChange.Text = "ming@mail.com";
            // 
            // idProfileChange
            // 
            this.idProfileChange.AutoSize = true;
            this.idProfileChange.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProfileChange.Location = new System.Drawing.Point(430, 202);
            this.idProfileChange.Name = "idProfileChange";
            this.idProfileChange.Size = new System.Drawing.Size(181, 60);
            this.idProfileChange.TabIndex = 11;
            this.idProfileChange.Text = "020202";
            // 
            // nameProfileChange
            // 
            this.nameProfileChange.AutoSize = true;
            this.nameProfileChange.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProfileChange.Location = new System.Drawing.Point(430, 129);
            this.nameProfileChange.Name = "nameProfileChange";
            this.nameProfileChange.Size = new System.Drawing.Size(343, 60);
            this.nameProfileChange.TabIndex = 10;
            this.nameProfileChange.Text = "Liew Jun Ming";
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(422, 478);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(303, 131);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.Text = "Edit Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // roleProfile
            // 
            this.roleProfile.AutoSize = true;
            this.roleProfile.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleProfile.Location = new System.Drawing.Point(261, 353);
            this.roleProfile.Name = "roleProfile";
            this.roleProfile.Size = new System.Drawing.Size(163, 60);
            this.roleProfile.TabIndex = 7;
            this.roleProfile.Text = "Role : ";
            // 
            // mailProfile
            // 
            this.mailProfile.AutoSize = true;
            this.mailProfile.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailProfile.Location = new System.Drawing.Point(262, 274);
            this.mailProfile.Name = "mailProfile";
            this.mailProfile.Size = new System.Drawing.Size(162, 60);
            this.mailProfile.TabIndex = 6;
            this.mailProfile.Text = "Mail : ";
            // 
            // idProfile
            // 
            this.idProfile.AutoSize = true;
            this.idProfile.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProfile.Location = new System.Drawing.Point(302, 202);
            this.idProfile.Name = "idProfile";
            this.idProfile.Size = new System.Drawing.Size(107, 60);
            this.idProfile.TabIndex = 5;
            this.idProfile.Text = "ID :";
            // 
            // nameProfile
            // 
            this.nameProfile.AutoSize = true;
            this.nameProfile.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProfile.Location = new System.Drawing.Point(236, 129);
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
            this.label7.Size = new System.Drawing.Size(912, 110);
            this.label7.TabIndex = 3;
            this.label7.Text = "Profile";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(975, 6);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(35, 24);
            this.lblHome.TabIndex = 12;
            this.lblHome.Text = "🏠";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(1109, 7);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(58, 23);
            this.lblLogout.TabIndex = 11;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblReload
            // 
            this.lblReload.AutoSize = true;
            this.lblReload.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReload.Location = new System.Drawing.Point(1047, 1);
            this.lblReload.Name = "lblReload";
            this.lblReload.Size = new System.Drawing.Size(35, 33);
            this.lblReload.TabIndex = 10;
            this.lblReload.Text = "↻";
            this.lblReload.Click += new System.EventHandler(this.lblReload_Click);
            // 
            // frmMechanicMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 766);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblReload);
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
            this.tlpServiceTask.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlServiceProgress.ResumeLayout(false);
            this.pnlServiceProgress.PerformLayout();
            this.grbAddService.ResumeLayout(false);
            this.grbAddService.PerformLayout();
            this.tlpServiceProgress.ResumeLayout(false);
            this.tlpServiceProgress.PerformLayout();
            this.tlpProgress.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.TableLayoutPanel tlpServiceTask;
        private System.Windows.Forms.Label lblServicetaskDate;
        private System.Windows.Forms.Label lblServicetaskService;
        private System.Windows.Forms.Label lblServicetaskCusName;
        private System.Windows.Forms.Label lblServicetaskNote;
        private System.Windows.Forms.Label lblServiceTaskTime;
        private System.Windows.Forms.Panel pnlServiceProgress;
        private System.Windows.Forms.GroupBox grbAddService;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.TableLayoutPanel tlpServiceProgress;
        private System.Windows.Forms.Label lblProgressNote;
        private System.Windows.Forms.Label lblProgressService;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.TableLayoutPanel tlpProgress;
        private System.Windows.Forms.Label lblProgressApointmentId;
        private System.Windows.Forms.Label lblProgressNoPlate;
        private System.Windows.Forms.Label lblProgressCusName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Button btnEndTask;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblAppointmentId;
        private System.Windows.Forms.Label lblProgressUserID;
        private System.Windows.Forms.Label lblProgressPlateNumber;
        private System.Windows.Forms.Label lblBottomMargin;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblReload;
    }
}