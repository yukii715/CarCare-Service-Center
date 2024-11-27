
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 12D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 21D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 10D);
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHome = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblReload = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.btnChangeUserName = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
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
            this.tabPage1.Size = new System.Drawing.Size(1092, 721);
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
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(6, 314);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.Points.Add(dataPoint10);
            series4.Points.Add(dataPoint11);
            series4.Points.Add(dataPoint12);
            this.chart1.Series.Add(series4);
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
            this.tabPage2.Size = new System.Drawing.Size(1092, 721);
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
            this.tlpServiceTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tlpServiceTask.Size = new System.Drawing.Size(1012, 117);
            this.tlpServiceTask.TabIndex = 10;
            // 
            // lblServicetaskNote
            // 
            this.lblServicetaskNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServicetaskNote.Location = new System.Drawing.Point(6, 3);
            this.lblServicetaskNote.Name = "lblServicetaskNote";
            this.lblServicetaskNote.Size = new System.Drawing.Size(63, 114);
            this.lblServicetaskNote.TabIndex = 0;
            this.lblServicetaskNote.Text = "NO";
            this.lblServicetaskNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServicetaskCusName
            // 
            this.lblServicetaskCusName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServicetaskCusName.Location = new System.Drawing.Point(78, 3);
            this.lblServicetaskCusName.Name = "lblServicetaskCusName";
            this.lblServicetaskCusName.Size = new System.Drawing.Size(192, 114);
            this.lblServicetaskCusName.TabIndex = 1;
            this.lblServicetaskCusName.Text = "NAME";
            this.lblServicetaskCusName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServicetaskService
            // 
            this.lblServicetaskService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServicetaskService.Location = new System.Drawing.Point(279, 3);
            this.lblServicetaskService.Name = "lblServicetaskService";
            this.lblServicetaskService.Size = new System.Drawing.Size(451, 114);
            this.lblServicetaskService.TabIndex = 2;
            this.lblServicetaskService.Text = "SERVICE";
            this.lblServicetaskService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServicetaskDate
            // 
            this.lblServicetaskDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServicetaskDate.Location = new System.Drawing.Point(739, 3);
            this.lblServicetaskDate.Name = "lblServicetaskDate";
            this.lblServicetaskDate.Size = new System.Drawing.Size(172, 114);
            this.lblServicetaskDate.TabIndex = 3;
            this.lblServicetaskDate.Text = "DATE";
            this.lblServicetaskDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServiceTaskTime
            // 
            this.lblServiceTaskTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServiceTaskTime.Location = new System.Drawing.Point(920, 3);
            this.lblServiceTaskTime.Name = "lblServiceTaskTime";
            this.lblServiceTaskTime.Size = new System.Drawing.Size(86, 114);
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
            this.tlpServiceProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpServiceProgress.Size = new System.Drawing.Size(1002, 68);
            this.tlpServiceProgress.TabIndex = 15;
            // 
            // lblProgressNote
            // 
            this.lblProgressNote.AutoSize = true;
            this.lblProgressNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgressNote.Location = new System.Drawing.Point(5, 2);
            this.lblProgressNote.Name = "lblProgressNote";
            this.lblProgressNote.Size = new System.Drawing.Size(77, 64);
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
            this.lblProgressService.Size = new System.Drawing.Size(907, 64);
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
            this.tabPage4.Size = new System.Drawing.Size(1092, 721);
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
            this.tabPage5.Controls.Add(this.lblEmail);
            this.tabPage5.Controls.Add(this.lblUserName);
            this.tabPage5.Controls.Add(this.lblUserID);
            this.tabPage5.Controls.Add(this.btnChangePassword);
            this.tabPage5.Controls.Add(this.btnChangeEmail);
            this.tabPage5.Controls.Add(this.btnChangeUserName);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Location = new System.Drawing.Point(84, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1092, 721);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Profile";
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
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(386, 312);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 34);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = "[Email]";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(386, 238);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(167, 34);
            this.lblUserName.TabIndex = 41;
            this.lblUserName.Text = "[Username]";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(386, 164);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(122, 34);
            this.lblUserID.TabIndex = 40;
            this.lblUserID.Text = "[UserID]";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(737, 520);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(208, 52);
            this.btnChangePassword.TabIndex = 39;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEmail.Location = new System.Drawing.Point(424, 520);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(208, 52);
            this.btnChangeEmail.TabIndex = 38;
            this.btnChangeEmail.Text = "Change Email";
            this.btnChangeEmail.UseVisualStyleBackColor = true;
            this.btnChangeEmail.Click += new System.EventHandler(this.btnChangeEmail_Click);
            // 
            // btnChangeUserName
            // 
            this.btnChangeUserName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeUserName.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUserName.Location = new System.Drawing.Point(111, 520);
            this.btnChangeUserName.Name = "btnChangeUserName";
            this.btnChangeUserName.Size = new System.Drawing.Size(208, 52);
            this.btnChangeUserName.TabIndex = 37;
            this.btnChangeUserName.Text = "Change User Name";
            this.btnChangeUserName.UseVisualStyleBackColor = true;
            this.btnChangeUserName.Click += new System.EventHandler(this.btnChangeUserName_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(175, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 34);
            this.label13.TabIndex = 36;
            this.label13.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(175, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 34);
            this.label14.TabIndex = 35;
            this.label14.Text = "User Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(175, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 34);
            this.label15.TabIndex = 34;
            this.label15.Text = "UserID:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Ink Free", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(465, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 54);
            this.label16.TabIndex = 33;
            this.label16.Text = "Profile";
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
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeEmail;
        private System.Windows.Forms.Button btnChangeUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}