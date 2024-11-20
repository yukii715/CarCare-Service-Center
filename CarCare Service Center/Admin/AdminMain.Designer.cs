using System.Windows.Forms;

namespace CarCare_Service_Center
{
    partial class frmAdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.crtHomeRating = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHomeRatingDetail = new System.Windows.Forms.Button();
            this.cmbHomeYear = new System.Windows.Forms.ComboBox();
            this.cmbHomeMonth = new System.Windows.Forms.ComboBox();
            this.btnHomeSearch = new System.Windows.Forms.Button();
            this.btnHomeProfitDetail = new System.Windows.Forms.Button();
            this.lblHomeProfit = new System.Windows.Forms.Label();
            this.lblMoneySpent = new System.Windows.Forms.Label();
            this.lblMoneyEarn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tabStaffAccount = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlpStaffAccountData = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.btnStaffAccountSortName = new System.Windows.Forms.Button();
            this.btnStaffAccountSortID = new System.Windows.Forms.Button();
            this.btnStaffSearch = new System.Windows.Forms.Button();
            this.txtStaffSearch = new System.Windows.Forms.TextBox();
            this.cmbRoleSelection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.tlpServiceSortButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnServiceSortType = new System.Windows.Forms.Button();
            this.btnServiceSortID = new System.Windows.Forms.Button();
            this.btnServiceSortName = new System.Windows.Forms.Button();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tlpServiceData = new System.Windows.Forms.TableLayoutPanel();
            this.btnServiceSearch = new System.Windows.Forms.Button();
            this.txtServiceSearch = new System.Windows.Forms.TextBox();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabFeedback = new System.Windows.Forms.TabPage();
            this.tlpFeedbackSortButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnFeedbackSortComment = new System.Windows.Forms.Button();
            this.btnFeedbackSortRating = new System.Windows.Forms.Button();
            this.btnFeedbackSortDate = new System.Windows.Forms.Button();
            this.btnFeedbackSortID = new System.Windows.Forms.Button();
            this.btnFeedbackSortName = new System.Windows.Forms.Button();
            this.pnlFeedbackData = new System.Windows.Forms.Panel();
            this.tlpFeedbackData = new System.Windows.Forms.TableLayoutPanel();
            this.cmbFeedbackYear = new System.Windows.Forms.ComboBox();
            this.cmbFeedbackMonth = new System.Windows.Forms.ComboBox();
            this.btnFeedbackSearch = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFeedbackTotal = new System.Windows.Forms.Label();
            this.crtFeedbackRating = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabSalariesRecord = new System.Windows.Forms.TabPage();
            this.cmbSalaryYear = new System.Windows.Forms.ComboBox();
            this.cmbSalaryMonth = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tlpSalaryBtnSort = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalarySortBaseSalary = new System.Windows.Forms.Button();
            this.btnSalarySortRole = new System.Windows.Forms.Button();
            this.btnSalarySortID = new System.Windows.Forms.Button();
            this.btnSalarySortName = new System.Windows.Forms.Button();
            this.pnlSalary = new System.Windows.Forms.Panel();
            this.tlpSalaryData = new System.Windows.Forms.TableLayoutPanel();
            this.txtSalarySearch = new System.Windows.Forms.TextBox();
            this.cmbSalaryRole = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.cmbReportYear = new System.Windows.Forms.ComboBox();
            this.cmbReportMonth = new System.Windows.Forms.ComboBox();
            this.btnReportSearch = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tabReportSelection = new System.Windows.Forms.TabControl();
            this.tabMonthlyReport = new System.Windows.Forms.TabPage();
            this.lblReportFinalProfit = new System.Windows.Forms.Label();
            this.lblReportStaffSalaryCost = new System.Windows.Forms.Label();
            this.lblReportCostAndExpenses = new System.Windows.Forms.Label();
            this.lblReportServiceRevenue = new System.Windows.Forms.Label();
            this.lblReportProfit = new System.Windows.Forms.Label();
            this.lblReportCost = new System.Windows.Forms.Label();
            this.lblReportRevenue = new System.Windows.Forms.Label();
            this.lblReportNumOfService = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMonthlyReportTitle = new System.Windows.Forms.Label();
            this.tabServiceReport = new System.Windows.Forms.TabPage();
            this.tlpServiceReportSortButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnServiceReportSortPrice = new System.Windows.Forms.Button();
            this.btnServiceReportSortSOID = new System.Windows.Forms.Button();
            this.btnServiceReportSortDate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tlpServiceReportData = new System.Windows.Forms.TableLayoutPanel();
            this.lblMonthlyServiceReport = new System.Windows.Forms.Label();
            this.tabCostAndExpenses = new System.Windows.Forms.TabPage();
            this.tlpCostAndExpensesSortButton = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tlpCostAndExpensesData = new System.Windows.Forms.TableLayoutPanel();
            this.lblCostAndExpensesReport = new System.Windows.Forms.Label();
            this.tabStaffSalaryReport = new System.Windows.Forms.TabPage();
            this.lblStaffSalaryTotal = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tlpStaffSalaryReportSortButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnSSRPrice = new System.Windows.Forms.Button();
            this.btnSSRID = new System.Windows.Forms.Button();
            this.btnSSRName = new System.Windows.Forms.Button();
            this.pnlStaffSalaryReport = new System.Windows.Forms.Panel();
            this.tlpStaffSalaryReportData = new System.Windows.Forms.TableLayoutPanel();
            this.lblStaffSalaryReport = new System.Windows.Forms.Label();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.btnChangeUserName = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.tabAdmin.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtHomeRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabStaffAccount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.tlpServiceSortButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabFeedback.SuspendLayout();
            this.tlpFeedbackSortButton.SuspendLayout();
            this.pnlFeedbackData.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtFeedbackRating)).BeginInit();
            this.tabSalariesRecord.SuspendLayout();
            this.tlpSalaryBtnSort.SuspendLayout();
            this.pnlSalary.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.tabReportSelection.SuspendLayout();
            this.tabMonthlyReport.SuspendLayout();
            this.tabServiceReport.SuspendLayout();
            this.tlpServiceReportSortButton.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabCostAndExpenses.SuspendLayout();
            this.tlpCostAndExpensesSortButton.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabStaffSalaryReport.SuspendLayout();
            this.tlpStaffSalaryReportSortButton.SuspendLayout();
            this.pnlStaffSalaryReport.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabAdmin.Controls.Add(this.tabHome);
            this.tabAdmin.Controls.Add(this.tabStaffAccount);
            this.tabAdmin.Controls.Add(this.tabServices);
            this.tabAdmin.Controls.Add(this.tabFeedback);
            this.tabAdmin.Controls.Add(this.tabSalariesRecord);
            this.tabAdmin.Controls.Add(this.tabReport);
            this.tabAdmin.Controls.Add(this.tabProfile);
            this.tabAdmin.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabAdmin.ItemSize = new System.Drawing.Size(50, 80);
            this.tabAdmin.Location = new System.Drawing.Point(1, 1);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tabAdmin.Multiline = true;
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1084, 620);
            this.tabAdmin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabAdmin.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.crtHomeRating);
            this.tabHome.Controls.Add(this.btnHomeRatingDetail);
            this.tabHome.Controls.Add(this.cmbHomeYear);
            this.tabHome.Controls.Add(this.cmbHomeMonth);
            this.tabHome.Controls.Add(this.btnHomeSearch);
            this.tabHome.Controls.Add(this.btnHomeProfitDetail);
            this.tabHome.Controls.Add(this.lblHomeProfit);
            this.tabHome.Controls.Add(this.lblMoneySpent);
            this.tabHome.Controls.Add(this.lblMoneyEarn);
            this.tabHome.Controls.Add(this.label5);
            this.tabHome.Controls.Add(this.label4);
            this.tabHome.Controls.Add(this.label3);
            this.tabHome.Controls.Add(this.label2);
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Controls.Add(this.lblWelcome);
            this.tabHome.Controls.Add(this.pictureBoxLogo);
            this.tabHome.Location = new System.Drawing.Point(84, 4);
            this.tabHome.Margin = new System.Windows.Forms.Padding(2);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(2);
            this.tabHome.Size = new System.Drawing.Size(996, 612);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // crtHomeRating
            // 
            chartArea1.Name = "ChartArea1";
            this.crtHomeRating.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.crtHomeRating.Legends.Add(legend1);
            this.crtHomeRating.Location = new System.Drawing.Point(507, 328);
            this.crtHomeRating.Margin = new System.Windows.Forms.Padding(2);
            this.crtHomeRating.Name = "crtHomeRating";
            this.crtHomeRating.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Chart";
            series1.Name = "SeriesRating";
            this.crtHomeRating.Series.Add(series1);
            this.crtHomeRating.Size = new System.Drawing.Size(392, 216);
            this.crtHomeRating.TabIndex = 42;
            this.crtHomeRating.Text = "chartRating";
            // 
            // btnHomeRatingDetail
            // 
            this.btnHomeRatingDetail.Enabled = false;
            this.btnHomeRatingDetail.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeRatingDetail.Location = new System.Drawing.Point(708, 549);
            this.btnHomeRatingDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeRatingDetail.Name = "btnHomeRatingDetail";
            this.btnHomeRatingDetail.Size = new System.Drawing.Size(176, 42);
            this.btnHomeRatingDetail.TabIndex = 41;
            this.btnHomeRatingDetail.Text = "More Detail";
            this.btnHomeRatingDetail.UseVisualStyleBackColor = true;
            this.btnHomeRatingDetail.Click += new System.EventHandler(this.btnHomeRatingDetail_Click);
            // 
            // cmbHomeYear
            // 
            this.cmbHomeYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeYear.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHomeYear.FormattingEnabled = true;
            this.cmbHomeYear.Location = new System.Drawing.Point(132, 240);
            this.cmbHomeYear.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHomeYear.Name = "cmbHomeYear";
            this.cmbHomeYear.Size = new System.Drawing.Size(138, 36);
            this.cmbHomeYear.TabIndex = 40;
            this.cmbHomeYear.SelectedIndexChanged += new System.EventHandler(this.HomeresetPreview);
            // 
            // cmbHomeMonth
            // 
            this.cmbHomeMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeMonth.Enabled = false;
            this.cmbHomeMonth.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHomeMonth.FormattingEnabled = true;
            this.cmbHomeMonth.Location = new System.Drawing.Point(326, 241);
            this.cmbHomeMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHomeMonth.Name = "cmbHomeMonth";
            this.cmbHomeMonth.Size = new System.Drawing.Size(203, 36);
            this.cmbHomeMonth.TabIndex = 39;
            this.cmbHomeMonth.SelectedIndexChanged += new System.EventHandler(this.HomeresetPreview);
            // 
            // btnHomeSearch
            // 
            this.btnHomeSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeSearch.Location = new System.Drawing.Point(590, 236);
            this.btnHomeSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeSearch.Name = "btnHomeSearch";
            this.btnHomeSearch.Size = new System.Drawing.Size(120, 42);
            this.btnHomeSearch.TabIndex = 38;
            this.btnHomeSearch.Text = "Search";
            this.btnHomeSearch.UseVisualStyleBackColor = true;
            this.btnHomeSearch.Click += new System.EventHandler(this.btnHomeSearch_Click);
            // 
            // btnHomeProfitDetail
            // 
            this.btnHomeProfitDetail.Enabled = false;
            this.btnHomeProfitDetail.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeProfitDetail.Location = new System.Drawing.Point(231, 549);
            this.btnHomeProfitDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeProfitDetail.Name = "btnHomeProfitDetail";
            this.btnHomeProfitDetail.Size = new System.Drawing.Size(170, 42);
            this.btnHomeProfitDetail.TabIndex = 37;
            this.btnHomeProfitDetail.Text = "More Detail";
            this.btnHomeProfitDetail.UseVisualStyleBackColor = true;
            this.btnHomeProfitDetail.Click += new System.EventHandler(this.btnHomeProfitDetail_Click);
            // 
            // lblHomeProfit
            // 
            this.lblHomeProfit.AutoSize = true;
            this.lblHomeProfit.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeProfit.Location = new System.Drawing.Point(266, 474);
            this.lblHomeProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeProfit.Name = "lblHomeProfit";
            this.lblHomeProfit.Size = new System.Drawing.Size(62, 30);
            this.lblHomeProfit.TabIndex = 36;
            this.lblHomeProfit.Text = "RM -";
            // 
            // lblMoneySpent
            // 
            this.lblMoneySpent.AutoSize = true;
            this.lblMoneySpent.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneySpent.Location = new System.Drawing.Point(266, 392);
            this.lblMoneySpent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoneySpent.Name = "lblMoneySpent";
            this.lblMoneySpent.Size = new System.Drawing.Size(62, 30);
            this.lblMoneySpent.TabIndex = 35;
            this.lblMoneySpent.Text = "RM -";
            // 
            // lblMoneyEarn
            // 
            this.lblMoneyEarn.AutoSize = true;
            this.lblMoneyEarn.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyEarn.Location = new System.Drawing.Point(266, 310);
            this.lblMoneyEarn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoneyEarn.Name = "lblMoneyEarn";
            this.lblMoneyEarn.Size = new System.Drawing.Size(62, 30);
            this.lblMoneyEarn.TabIndex = 34;
            this.lblMoneyEarn.Text = "RM -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(716, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 30);
            this.label5.TabIndex = 33;
            this.label5.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 474);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "Profit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 31;
            this.label3.Text = "Money Spent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Money Earn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Date:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(2, 161);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(369, 51);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome Back, User";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(364, 4);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(219, 181);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tabStaffAccount
            // 
            this.tabStaffAccount.Controls.Add(this.panel2);
            this.tabStaffAccount.Controls.Add(this.panel1);
            this.tabStaffAccount.Controls.Add(this.btnStaffAdd);
            this.tabStaffAccount.Controls.Add(this.btnStaffAccountSortName);
            this.tabStaffAccount.Controls.Add(this.btnStaffAccountSortID);
            this.tabStaffAccount.Controls.Add(this.btnStaffSearch);
            this.tabStaffAccount.Controls.Add(this.txtStaffSearch);
            this.tabStaffAccount.Controls.Add(this.cmbRoleSelection);
            this.tabStaffAccount.Controls.Add(this.label7);
            this.tabStaffAccount.Controls.Add(this.label6);
            this.tabStaffAccount.Location = new System.Drawing.Point(84, 4);
            this.tabStaffAccount.Margin = new System.Windows.Forms.Padding(2);
            this.tabStaffAccount.Name = "tabStaffAccount";
            this.tabStaffAccount.Padding = new System.Windows.Forms.Padding(2);
            this.tabStaffAccount.Size = new System.Drawing.Size(996, 612);
            this.tabStaffAccount.TabIndex = 1;
            this.tabStaffAccount.Text = "Staff Account";
            this.tabStaffAccount.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tlpStaffAccountData);
            this.panel2.Location = new System.Drawing.Point(13, 238);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 269);
            this.panel2.TabIndex = 14;
            // 
            // tlpStaffAccountData
            // 
            this.tlpStaffAccountData.AutoSize = true;
            this.tlpStaffAccountData.ColumnCount = 4;
            this.tlpStaffAccountData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.03226F));
            this.tlpStaffAccountData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.96774F));
            this.tlpStaffAccountData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tlpStaffAccountData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tlpStaffAccountData.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpStaffAccountData.Location = new System.Drawing.Point(15, 2);
            this.tlpStaffAccountData.Margin = new System.Windows.Forms.Padding(2);
            this.tlpStaffAccountData.Name = "tlpStaffAccountData";
            this.tlpStaffAccountData.RowCount = 1;
            this.tlpStaffAccountData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStaffAccountData.Size = new System.Drawing.Size(869, 48);
            this.tlpStaffAccountData.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(28, 199);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 43);
            this.panel1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(562, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "Role";
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffAdd.Location = new System.Drawing.Point(785, 528);
            this.btnStaffAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(125, 42);
            this.btnStaffAdd.TabIndex = 12;
            this.btnStaffAdd.Text = "Add";
            this.btnStaffAdd.UseVisualStyleBackColor = true;
            this.btnStaffAdd.Click += new System.EventHandler(this.btnStaffAdd_Click);
            // 
            // btnStaffAccountSortName
            // 
            this.btnStaffAccountSortName.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffAccountSortName.Location = new System.Drawing.Point(422, 128);
            this.btnStaffAccountSortName.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaffAccountSortName.Name = "btnStaffAccountSortName";
            this.btnStaffAccountSortName.Size = new System.Drawing.Size(125, 42);
            this.btnStaffAccountSortName.TabIndex = 9;
            this.btnStaffAccountSortName.Text = "Name";
            this.btnStaffAccountSortName.UseVisualStyleBackColor = true;
            this.btnStaffAccountSortName.Click += new System.EventHandler(this.btnSortStaffName_Click);
            // 
            // btnStaffAccountSortID
            // 
            this.btnStaffAccountSortID.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffAccountSortID.Location = new System.Drawing.Point(187, 128);
            this.btnStaffAccountSortID.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaffAccountSortID.Name = "btnStaffAccountSortID";
            this.btnStaffAccountSortID.Size = new System.Drawing.Size(125, 42);
            this.btnStaffAccountSortID.TabIndex = 8;
            this.btnStaffAccountSortID.Text = "ID";
            this.btnStaffAccountSortID.UseVisualStyleBackColor = true;
            this.btnStaffAccountSortID.Click += new System.EventHandler(this.btnSortStaffID_Click);
            // 
            // btnStaffSearch
            // 
            this.btnStaffSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffSearch.Location = new System.Drawing.Point(427, 71);
            this.btnStaffSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaffSearch.Name = "btnStaffSearch";
            this.btnStaffSearch.Size = new System.Drawing.Size(120, 42);
            this.btnStaffSearch.TabIndex = 7;
            this.btnStaffSearch.Text = "Search";
            this.btnStaffSearch.UseVisualStyleBackColor = true;
            this.btnStaffSearch.Click += new System.EventHandler(this.btnStaffSearch_Click);
            // 
            // txtStaffSearch
            // 
            this.txtStaffSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffSearch.Location = new System.Drawing.Point(28, 76);
            this.txtStaffSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffSearch.Name = "txtStaffSearch";
            this.txtStaffSearch.Size = new System.Drawing.Size(358, 36);
            this.txtStaffSearch.TabIndex = 6;
            this.txtStaffSearch.Text = "Search";
            // 
            // cmbRoleSelection
            // 
            this.cmbRoleSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoleSelection.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoleSelection.FormattingEnabled = true;
            this.cmbRoleSelection.Items.AddRange(new object[] {
            "All",
            "Mechanic",
            "Receptionist"});
            this.cmbRoleSelection.Location = new System.Drawing.Point(122, 19);
            this.cmbRoleSelection.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoleSelection.Name = "cmbRoleSelection";
            this.cmbRoleSelection.Size = new System.Drawing.Size(264, 36);
            this.cmbRoleSelection.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sort by:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Role: ";
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.tlpServiceSortButtons);
            this.tabServices.Controls.Add(this.btnServiceAdd);
            this.tabServices.Controls.Add(this.panel3);
            this.tabServices.Controls.Add(this.btnServiceSearch);
            this.tabServices.Controls.Add(this.txtServiceSearch);
            this.tabServices.Controls.Add(this.cmbServiceType);
            this.tabServices.Controls.Add(this.label12);
            this.tabServices.Controls.Add(this.label11);
            this.tabServices.Location = new System.Drawing.Point(84, 4);
            this.tabServices.Margin = new System.Windows.Forms.Padding(2);
            this.tabServices.Name = "tabServices";
            this.tabServices.Size = new System.Drawing.Size(996, 612);
            this.tabServices.TabIndex = 2;
            this.tabServices.Text = "Services";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // tlpServiceSortButtons
            // 
            this.tlpServiceSortButtons.BackColor = System.Drawing.Color.Gainsboro;
            this.tlpServiceSortButtons.ColumnCount = 4;
            this.tlpServiceSortButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.9434F));
            this.tlpServiceSortButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.0566F));
            this.tlpServiceSortButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tlpServiceSortButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tlpServiceSortButtons.Controls.Add(this.btnServiceSortType, 2, 0);
            this.tlpServiceSortButtons.Controls.Add(this.btnServiceSortID, 0, 0);
            this.tlpServiceSortButtons.Controls.Add(this.btnServiceSortName, 1, 0);
            this.tlpServiceSortButtons.Location = new System.Drawing.Point(34, 172);
            this.tlpServiceSortButtons.Margin = new System.Windows.Forms.Padding(2);
            this.tlpServiceSortButtons.Name = "tlpServiceSortButtons";
            this.tlpServiceSortButtons.RowCount = 1;
            this.tlpServiceSortButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57265F));
            this.tlpServiceSortButtons.Size = new System.Drawing.Size(862, 48);
            this.tlpServiceSortButtons.TabIndex = 20;
            // 
            // btnServiceSortType
            // 
            this.btnServiceSortType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServiceSortType.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceSortType.Location = new System.Drawing.Point(407, 2);
            this.btnServiceSortType.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceSortType.Name = "btnServiceSortType";
            this.btnServiceSortType.Size = new System.Drawing.Size(294, 44);
            this.btnServiceSortType.TabIndex = 21;
            this.btnServiceSortType.Text = "Service Type";
            this.btnServiceSortType.UseVisualStyleBackColor = true;
            this.btnServiceSortType.Click += new System.EventHandler(this.btnServiceSortType_Click);
            // 
            // btnServiceSortID
            // 
            this.btnServiceSortID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServiceSortID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceSortID.Location = new System.Drawing.Point(2, 2);
            this.btnServiceSortID.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceSortID.Name = "btnServiceSortID";
            this.btnServiceSortID.Size = new System.Drawing.Size(121, 44);
            this.btnServiceSortID.TabIndex = 20;
            this.btnServiceSortID.Text = "ID";
            this.btnServiceSortID.UseVisualStyleBackColor = true;
            this.btnServiceSortID.Click += new System.EventHandler(this.btnServiceSortID_Click);
            // 
            // btnServiceSortName
            // 
            this.btnServiceSortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServiceSortName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceSortName.Location = new System.Drawing.Point(127, 2);
            this.btnServiceSortName.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceSortName.Name = "btnServiceSortName";
            this.btnServiceSortName.Size = new System.Drawing.Size(276, 44);
            this.btnServiceSortName.TabIndex = 21;
            this.btnServiceSortName.Text = "Name";
            this.btnServiceSortName.UseVisualStyleBackColor = true;
            this.btnServiceSortName.Click += new System.EventHandler(this.btnServiceSortName_Click);
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceAdd.Location = new System.Drawing.Point(774, 539);
            this.btnServiceAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(125, 42);
            this.btnServiceAdd.TabIndex = 19;
            this.btnServiceAdd.Text = "Add";
            this.btnServiceAdd.UseVisualStyleBackColor = true;
            this.btnServiceAdd.Click += new System.EventHandler(this.btnServiceAdd_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.tlpServiceData);
            this.panel3.Location = new System.Drawing.Point(16, 220);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 292);
            this.panel3.TabIndex = 16;
            // 
            // tlpServiceData
            // 
            this.tlpServiceData.AutoSize = true;
            this.tlpServiceData.ColumnCount = 4;
            this.tlpServiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.67384F));
            this.tlpServiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.32616F));
            this.tlpServiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tlpServiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tlpServiceData.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpServiceData.Location = new System.Drawing.Point(20, 2);
            this.tlpServiceData.Margin = new System.Windows.Forms.Padding(2);
            this.tlpServiceData.Name = "tlpServiceData";
            this.tlpServiceData.RowCount = 1;
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpServiceData.Size = new System.Drawing.Size(860, 45);
            this.tlpServiceData.TabIndex = 14;
            // 
            // btnServiceSearch
            // 
            this.btnServiceSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceSearch.Location = new System.Drawing.Point(611, 70);
            this.btnServiceSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceSearch.Name = "btnServiceSearch";
            this.btnServiceSearch.Size = new System.Drawing.Size(120, 42);
            this.btnServiceSearch.TabIndex = 8;
            this.btnServiceSearch.Text = "Search";
            this.btnServiceSearch.UseVisualStyleBackColor = true;
            this.btnServiceSearch.Click += new System.EventHandler(this.btnServiceSearch_Click);
            // 
            // txtServiceSearch
            // 
            this.txtServiceSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceSearch.Location = new System.Drawing.Point(194, 19);
            this.txtServiceSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceSearch.Name = "txtServiceSearch";
            this.txtServiceSearch.Size = new System.Drawing.Size(358, 36);
            this.txtServiceSearch.TabIndex = 7;
            this.txtServiceSearch.Text = "Search";
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceType.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Items.AddRange(new object[] {
            "All"});
            this.cmbServiceType.Location = new System.Drawing.Point(194, 77);
            this.cmbServiceType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(358, 36);
            this.cmbServiceType.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 77);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 29);
            this.label12.TabIndex = 2;
            this.label12.Text = "Service Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "Service:";
            // 
            // tabFeedback
            // 
            this.tabFeedback.Controls.Add(this.tlpFeedbackSortButton);
            this.tabFeedback.Controls.Add(this.pnlFeedbackData);
            this.tabFeedback.Controls.Add(this.cmbFeedbackYear);
            this.tabFeedback.Controls.Add(this.cmbFeedbackMonth);
            this.tabFeedback.Controls.Add(this.btnFeedbackSearch);
            this.tabFeedback.Controls.Add(this.label13);
            this.tabFeedback.Controls.Add(this.panel4);
            this.tabFeedback.Location = new System.Drawing.Point(84, 4);
            this.tabFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.tabFeedback.Name = "tabFeedback";
            this.tabFeedback.Size = new System.Drawing.Size(996, 612);
            this.tabFeedback.TabIndex = 3;
            this.tabFeedback.Text = "Feedback";
            this.tabFeedback.UseVisualStyleBackColor = true;
            // 
            // tlpFeedbackSortButton
            // 
            this.tlpFeedbackSortButton.ColumnCount = 5;
            this.tlpFeedbackSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.64169F));
            this.tlpFeedbackSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.35831F));
            this.tlpFeedbackSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tlpFeedbackSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tlpFeedbackSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpFeedbackSortButton.Controls.Add(this.btnFeedbackSortComment, 4, 0);
            this.tlpFeedbackSortButton.Controls.Add(this.btnFeedbackSortRating, 3, 0);
            this.tlpFeedbackSortButton.Controls.Add(this.btnFeedbackSortDate, 2, 0);
            this.tlpFeedbackSortButton.Controls.Add(this.btnFeedbackSortID, 0, 0);
            this.tlpFeedbackSortButton.Controls.Add(this.btnFeedbackSortName, 1, 0);
            this.tlpFeedbackSortButton.Location = new System.Drawing.Point(9, 324);
            this.tlpFeedbackSortButton.Margin = new System.Windows.Forms.Padding(2);
            this.tlpFeedbackSortButton.Name = "tlpFeedbackSortButton";
            this.tlpFeedbackSortButton.RowCount = 1;
            this.tlpFeedbackSortButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57265F));
            this.tlpFeedbackSortButton.Size = new System.Drawing.Size(732, 48);
            this.tlpFeedbackSortButton.TabIndex = 50;
            this.tlpFeedbackSortButton.Visible = false;
            // 
            // btnFeedbackSortComment
            // 
            this.btnFeedbackSortComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeedbackSortComment.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackSortComment.Location = new System.Drawing.Point(603, 2);
            this.btnFeedbackSortComment.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedbackSortComment.Name = "btnFeedbackSortComment";
            this.btnFeedbackSortComment.Size = new System.Drawing.Size(127, 44);
            this.btnFeedbackSortComment.TabIndex = 23;
            this.btnFeedbackSortComment.Text = "Comment";
            this.btnFeedbackSortComment.UseVisualStyleBackColor = true;
            this.btnFeedbackSortComment.Click += new System.EventHandler(this.btnFeedbackSortComment_Click);
            // 
            // btnFeedbackSortRating
            // 
            this.btnFeedbackSortRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeedbackSortRating.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackSortRating.Location = new System.Drawing.Point(498, 2);
            this.btnFeedbackSortRating.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedbackSortRating.Name = "btnFeedbackSortRating";
            this.btnFeedbackSortRating.Size = new System.Drawing.Size(101, 44);
            this.btnFeedbackSortRating.TabIndex = 22;
            this.btnFeedbackSortRating.Text = "Rating";
            this.btnFeedbackSortRating.UseVisualStyleBackColor = true;
            this.btnFeedbackSortRating.Click += new System.EventHandler(this.btnFeedbackSortRating_Click);
            // 
            // btnFeedbackSortDate
            // 
            this.btnFeedbackSortDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeedbackSortDate.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackSortDate.Location = new System.Drawing.Point(320, 2);
            this.btnFeedbackSortDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedbackSortDate.Name = "btnFeedbackSortDate";
            this.btnFeedbackSortDate.Size = new System.Drawing.Size(174, 44);
            this.btnFeedbackSortDate.TabIndex = 21;
            this.btnFeedbackSortDate.Text = "Date";
            this.btnFeedbackSortDate.UseVisualStyleBackColor = true;
            this.btnFeedbackSortDate.Click += new System.EventHandler(this.btnFeedbackSortDate_Click);
            // 
            // btnFeedbackSortID
            // 
            this.btnFeedbackSortID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeedbackSortID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackSortID.Location = new System.Drawing.Point(2, 2);
            this.btnFeedbackSortID.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedbackSortID.Name = "btnFeedbackSortID";
            this.btnFeedbackSortID.Size = new System.Drawing.Size(119, 44);
            this.btnFeedbackSortID.TabIndex = 20;
            this.btnFeedbackSortID.Text = "SOID";
            this.btnFeedbackSortID.UseVisualStyleBackColor = true;
            this.btnFeedbackSortID.Click += new System.EventHandler(this.btnFeedbackSortID_Click);
            // 
            // btnFeedbackSortName
            // 
            this.btnFeedbackSortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeedbackSortName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackSortName.Location = new System.Drawing.Point(125, 2);
            this.btnFeedbackSortName.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedbackSortName.Name = "btnFeedbackSortName";
            this.btnFeedbackSortName.Size = new System.Drawing.Size(191, 44);
            this.btnFeedbackSortName.TabIndex = 21;
            this.btnFeedbackSortName.Text = "Name";
            this.btnFeedbackSortName.UseVisualStyleBackColor = true;
            this.btnFeedbackSortName.Click += new System.EventHandler(this.btnFeedbackSortName_Click);
            // 
            // pnlFeedbackData
            // 
            this.pnlFeedbackData.AutoScroll = true;
            this.pnlFeedbackData.BackColor = System.Drawing.Color.White;
            this.pnlFeedbackData.Controls.Add(this.tlpFeedbackData);
            this.pnlFeedbackData.Location = new System.Drawing.Point(9, 372);
            this.pnlFeedbackData.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFeedbackData.Name = "pnlFeedbackData";
            this.pnlFeedbackData.Size = new System.Drawing.Size(929, 222);
            this.pnlFeedbackData.TabIndex = 49;
            this.pnlFeedbackData.Visible = false;
            // 
            // tlpFeedbackData
            // 
            this.tlpFeedbackData.AutoScroll = true;
            this.tlpFeedbackData.AutoSize = true;
            this.tlpFeedbackData.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpFeedbackData.ColumnCount = 6;
            this.tlpFeedbackData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.95454F));
            this.tlpFeedbackData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.04546F));
            this.tlpFeedbackData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tlpFeedbackData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tlpFeedbackData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tlpFeedbackData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tlpFeedbackData.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpFeedbackData.Location = new System.Drawing.Point(0, 2);
            this.tlpFeedbackData.Margin = new System.Windows.Forms.Padding(2);
            this.tlpFeedbackData.Name = "tlpFeedbackData";
            this.tlpFeedbackData.RowCount = 1;
            this.tlpFeedbackData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFeedbackData.Size = new System.Drawing.Size(852, 58);
            this.tlpFeedbackData.TabIndex = 14;
            // 
            // cmbFeedbackYear
            // 
            this.cmbFeedbackYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeedbackYear.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFeedbackYear.FormattingEnabled = true;
            this.cmbFeedbackYear.Location = new System.Drawing.Point(111, 259);
            this.cmbFeedbackYear.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFeedbackYear.Name = "cmbFeedbackYear";
            this.cmbFeedbackYear.Size = new System.Drawing.Size(138, 36);
            this.cmbFeedbackYear.TabIndex = 48;
            this.cmbFeedbackYear.SelectedIndexChanged += new System.EventHandler(this.cmbFeedbackYear_SelectedIndexChanged);
            // 
            // cmbFeedbackMonth
            // 
            this.cmbFeedbackMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeedbackMonth.Enabled = false;
            this.cmbFeedbackMonth.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFeedbackMonth.FormattingEnabled = true;
            this.cmbFeedbackMonth.Location = new System.Drawing.Point(325, 259);
            this.cmbFeedbackMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFeedbackMonth.Name = "cmbFeedbackMonth";
            this.cmbFeedbackMonth.Size = new System.Drawing.Size(203, 36);
            this.cmbFeedbackMonth.TabIndex = 47;
            this.cmbFeedbackMonth.SelectedIndexChanged += new System.EventHandler(this.cmbFeedbackMonth_SelectedIndexChanged);
            // 
            // btnFeedbackSearch
            // 
            this.btnFeedbackSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackSearch.Location = new System.Drawing.Point(599, 256);
            this.btnFeedbackSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedbackSearch.Name = "btnFeedbackSearch";
            this.btnFeedbackSearch.Size = new System.Drawing.Size(120, 42);
            this.btnFeedbackSearch.TabIndex = 46;
            this.btnFeedbackSearch.Text = "Search";
            this.btnFeedbackSearch.UseVisualStyleBackColor = true;
            this.btnFeedbackSearch.Click += new System.EventHandler(this.btnFeedbackSearch_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 263);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 30);
            this.label13.TabIndex = 45;
            this.label13.Text = "Date:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblFeedbackTotal);
            this.panel4.Controls.Add(this.crtFeedbackRating);
            this.panel4.Location = new System.Drawing.Point(20, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 223);
            this.panel4.TabIndex = 44;
            // 
            // lblFeedbackTotal
            // 
            this.lblFeedbackTotal.AutoSize = true;
            this.lblFeedbackTotal.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackTotal.Location = new System.Drawing.Point(555, 180);
            this.lblFeedbackTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeedbackTotal.Name = "lblFeedbackTotal";
            this.lblFeedbackTotal.Size = new System.Drawing.Size(81, 30);
            this.lblFeedbackTotal.TabIndex = 52;
            this.lblFeedbackTotal.Text = "Total: ";
            // 
            // crtFeedbackRating
            // 
            this.crtFeedbackRating.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.crtFeedbackRating.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.crtFeedbackRating.Legends.Add(legend2);
            this.crtFeedbackRating.Location = new System.Drawing.Point(2, 2);
            this.crtFeedbackRating.Margin = new System.Windows.Forms.Padding(2);
            this.crtFeedbackRating.Name = "crtFeedbackRating";
            this.crtFeedbackRating.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.LegendText = "Chart";
            series2.Name = "SeriesRating";
            this.crtFeedbackRating.Series.Add(series2);
            this.crtFeedbackRating.Size = new System.Drawing.Size(471, 216);
            this.crtFeedbackRating.TabIndex = 43;
            // 
            // tabSalariesRecord
            // 
            this.tabSalariesRecord.Controls.Add(this.cmbSalaryYear);
            this.tabSalariesRecord.Controls.Add(this.cmbSalaryMonth);
            this.tabSalariesRecord.Controls.Add(this.label25);
            this.tabSalariesRecord.Controls.Add(this.label24);
            this.tabSalariesRecord.Controls.Add(this.tlpSalaryBtnSort);
            this.tabSalariesRecord.Controls.Add(this.pnlSalary);
            this.tabSalariesRecord.Controls.Add(this.txtSalarySearch);
            this.tabSalariesRecord.Controls.Add(this.cmbSalaryRole);
            this.tabSalariesRecord.Controls.Add(this.label26);
            this.tabSalariesRecord.Location = new System.Drawing.Point(84, 4);
            this.tabSalariesRecord.Margin = new System.Windows.Forms.Padding(2);
            this.tabSalariesRecord.Name = "tabSalariesRecord";
            this.tabSalariesRecord.Size = new System.Drawing.Size(996, 612);
            this.tabSalariesRecord.TabIndex = 7;
            this.tabSalariesRecord.Text = "Salaries Record";
            this.tabSalariesRecord.UseVisualStyleBackColor = true;
            // 
            // cmbSalaryYear
            // 
            this.cmbSalaryYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalaryYear.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalaryYear.FormattingEnabled = true;
            this.cmbSalaryYear.Location = new System.Drawing.Point(129, 20);
            this.cmbSalaryYear.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSalaryYear.Name = "cmbSalaryYear";
            this.cmbSalaryYear.Size = new System.Drawing.Size(138, 36);
            this.cmbSalaryYear.TabIndex = 62;
            this.cmbSalaryYear.SelectedIndexChanged += new System.EventHandler(this.cmbSalaryYear_SelectedIndexChanged);
            // 
            // cmbSalaryMonth
            // 
            this.cmbSalaryMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalaryMonth.Enabled = false;
            this.cmbSalaryMonth.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalaryMonth.FormattingEnabled = true;
            this.cmbSalaryMonth.Location = new System.Drawing.Point(377, 20);
            this.cmbSalaryMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSalaryMonth.Name = "cmbSalaryMonth";
            this.cmbSalaryMonth.Size = new System.Drawing.Size(203, 36);
            this.cmbSalaryMonth.TabIndex = 61;
            this.cmbSalaryMonth.SelectedIndexChanged += new System.EventHandler(this.cmbSalaryMonth_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(16, 21);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 30);
            this.label25.TabIndex = 59;
            this.label25.Text = "Date:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(22, 193);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(348, 29);
            this.label24.TabIndex = 58;
            this.label24.Text = "Records that haven\'t been added: ";
            // 
            // tlpSalaryBtnSort
            // 
            this.tlpSalaryBtnSort.ColumnCount = 5;
            this.tlpSalaryBtnSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.12099F));
            this.tlpSalaryBtnSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.87901F));
            this.tlpSalaryBtnSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tlpSalaryBtnSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tlpSalaryBtnSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpSalaryBtnSort.Controls.Add(this.btnSalarySortBaseSalary, 3, 0);
            this.tlpSalaryBtnSort.Controls.Add(this.btnSalarySortRole, 2, 0);
            this.tlpSalaryBtnSort.Controls.Add(this.btnSalarySortID, 0, 0);
            this.tlpSalaryBtnSort.Controls.Add(this.btnSalarySortName, 1, 0);
            this.tlpSalaryBtnSort.Location = new System.Drawing.Point(25, 230);
            this.tlpSalaryBtnSort.Margin = new System.Windows.Forms.Padding(2);
            this.tlpSalaryBtnSort.Name = "tlpSalaryBtnSort";
            this.tlpSalaryBtnSort.RowCount = 1;
            this.tlpSalaryBtnSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57265F));
            this.tlpSalaryBtnSort.Size = new System.Drawing.Size(870, 48);
            this.tlpSalaryBtnSort.TabIndex = 57;
            // 
            // btnSalarySortBaseSalary
            // 
            this.btnSalarySortBaseSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalarySortBaseSalary.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalarySortBaseSalary.Location = new System.Drawing.Point(586, 2);
            this.btnSalarySortBaseSalary.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalarySortBaseSalary.Name = "btnSalarySortBaseSalary";
            this.btnSalarySortBaseSalary.Size = new System.Drawing.Size(151, 44);
            this.btnSalarySortBaseSalary.TabIndex = 22;
            this.btnSalarySortBaseSalary.Text = "Base Salary";
            this.btnSalarySortBaseSalary.UseVisualStyleBackColor = true;
            this.btnSalarySortBaseSalary.Click += new System.EventHandler(this.btnSalarySortBaseSalary_Click);
            // 
            // btnSalarySortRole
            // 
            this.btnSalarySortRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalarySortRole.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalarySortRole.Location = new System.Drawing.Point(417, 2);
            this.btnSalarySortRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalarySortRole.Name = "btnSalarySortRole";
            this.btnSalarySortRole.Size = new System.Drawing.Size(165, 44);
            this.btnSalarySortRole.TabIndex = 21;
            this.btnSalarySortRole.Text = "Role";
            this.btnSalarySortRole.UseVisualStyleBackColor = true;
            this.btnSalarySortRole.Click += new System.EventHandler(this.btnSalarySortRole_Click);
            // 
            // btnSalarySortID
            // 
            this.btnSalarySortID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalarySortID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalarySortID.Location = new System.Drawing.Point(2, 2);
            this.btnSalarySortID.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalarySortID.Name = "btnSalarySortID";
            this.btnSalarySortID.Size = new System.Drawing.Size(146, 44);
            this.btnSalarySortID.TabIndex = 20;
            this.btnSalarySortID.Text = "ID";
            this.btnSalarySortID.UseVisualStyleBackColor = true;
            this.btnSalarySortID.Click += new System.EventHandler(this.btnSalarySortID_Click);
            // 
            // btnSalarySortName
            // 
            this.btnSalarySortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalarySortName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalarySortName.Location = new System.Drawing.Point(152, 2);
            this.btnSalarySortName.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalarySortName.Name = "btnSalarySortName";
            this.btnSalarySortName.Size = new System.Drawing.Size(261, 44);
            this.btnSalarySortName.TabIndex = 21;
            this.btnSalarySortName.Text = "Name";
            this.btnSalarySortName.UseVisualStyleBackColor = true;
            this.btnSalarySortName.Click += new System.EventHandler(this.btnSalarySortName_Click);
            // 
            // pnlSalary
            // 
            this.pnlSalary.AutoScroll = true;
            this.pnlSalary.Controls.Add(this.tlpSalaryData);
            this.pnlSalary.Location = new System.Drawing.Point(10, 280);
            this.pnlSalary.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSalary.Name = "pnlSalary";
            this.pnlSalary.Size = new System.Drawing.Size(930, 312);
            this.pnlSalary.TabIndex = 56;
            // 
            // tlpSalaryData
            // 
            this.tlpSalaryData.AutoSize = true;
            this.tlpSalaryData.ColumnCount = 5;
            this.tlpSalaryData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.31485F));
            this.tlpSalaryData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.68515F));
            this.tlpSalaryData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpSalaryData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tlpSalaryData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpSalaryData.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpSalaryData.Location = new System.Drawing.Point(15, 2);
            this.tlpSalaryData.Margin = new System.Windows.Forms.Padding(2);
            this.tlpSalaryData.Name = "tlpSalaryData";
            this.tlpSalaryData.RowCount = 1;
            this.tlpSalaryData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpSalaryData.Size = new System.Drawing.Size(869, 48);
            this.tlpSalaryData.TabIndex = 14;
            // 
            // txtSalarySearch
            // 
            this.txtSalarySearch.Enabled = false;
            this.txtSalarySearch.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarySearch.Location = new System.Drawing.Point(25, 147);
            this.txtSalarySearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalarySearch.Name = "txtSalarySearch";
            this.txtSalarySearch.Size = new System.Drawing.Size(358, 36);
            this.txtSalarySearch.TabIndex = 52;
            this.txtSalarySearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalarySearch_KeyDown);
            // 
            // cmbSalaryRole
            // 
            this.cmbSalaryRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalaryRole.Enabled = false;
            this.cmbSalaryRole.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalaryRole.FormattingEnabled = true;
            this.cmbSalaryRole.Items.AddRange(new object[] {
            "All",
            "Mechanic",
            "Receptionist"});
            this.cmbSalaryRole.Location = new System.Drawing.Point(129, 84);
            this.cmbSalaryRole.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSalaryRole.Name = "cmbSalaryRole";
            this.cmbSalaryRole.Size = new System.Drawing.Size(264, 36);
            this.cmbSalaryRole.TabIndex = 51;
            this.cmbSalaryRole.SelectedIndexChanged += new System.EventHandler(this.cmbSalaryRole_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(20, 86);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 29);
            this.label26.TabIndex = 49;
            this.label26.Text = "Role: ";
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.cmbReportYear);
            this.tabReport.Controls.Add(this.cmbReportMonth);
            this.tabReport.Controls.Add(this.btnReportSearch);
            this.tabReport.Controls.Add(this.label14);
            this.tabReport.Controls.Add(this.tabReportSelection);
            this.tabReport.Location = new System.Drawing.Point(84, 4);
            this.tabReport.Margin = new System.Windows.Forms.Padding(2);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(996, 612);
            this.tabReport.TabIndex = 4;
            this.tabReport.Text = "Report";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // cmbReportYear
            // 
            this.cmbReportYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportYear.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportYear.FormattingEnabled = true;
            this.cmbReportYear.Location = new System.Drawing.Point(148, 32);
            this.cmbReportYear.Margin = new System.Windows.Forms.Padding(2);
            this.cmbReportYear.Name = "cmbReportYear";
            this.cmbReportYear.Size = new System.Drawing.Size(138, 36);
            this.cmbReportYear.TabIndex = 44;
            this.cmbReportYear.SelectedIndexChanged += new System.EventHandler(this.cmbReportYear_SelectedIndexChanged);
            // 
            // cmbReportMonth
            // 
            this.cmbReportMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportMonth.Enabled = false;
            this.cmbReportMonth.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportMonth.FormattingEnabled = true;
            this.cmbReportMonth.Location = new System.Drawing.Point(344, 32);
            this.cmbReportMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbReportMonth.Name = "cmbReportMonth";
            this.cmbReportMonth.Size = new System.Drawing.Size(203, 36);
            this.cmbReportMonth.TabIndex = 43;
            // 
            // btnReportSearch
            // 
            this.btnReportSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportSearch.Location = new System.Drawing.Point(607, 28);
            this.btnReportSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportSearch.Name = "btnReportSearch";
            this.btnReportSearch.Size = new System.Drawing.Size(120, 42);
            this.btnReportSearch.TabIndex = 42;
            this.btnReportSearch.Text = "Search";
            this.btnReportSearch.UseVisualStyleBackColor = true;
            this.btnReportSearch.Click += new System.EventHandler(this.btnReportSearch_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 35);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 30);
            this.label14.TabIndex = 41;
            this.label14.Text = "Date:";
            // 
            // tabReportSelection
            // 
            this.tabReportSelection.Controls.Add(this.tabMonthlyReport);
            this.tabReportSelection.Controls.Add(this.tabServiceReport);
            this.tabReportSelection.Controls.Add(this.tabCostAndExpenses);
            this.tabReportSelection.Controls.Add(this.tabStaffSalaryReport);
            this.tabReportSelection.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReportSelection.Location = new System.Drawing.Point(16, 94);
            this.tabReportSelection.Margin = new System.Windows.Forms.Padding(2);
            this.tabReportSelection.Name = "tabReportSelection";
            this.tabReportSelection.SelectedIndex = 0;
            this.tabReportSelection.Size = new System.Drawing.Size(901, 513);
            this.tabReportSelection.TabIndex = 0;
            // 
            // tabMonthlyReport
            // 
            this.tabMonthlyReport.Controls.Add(this.lblReportFinalProfit);
            this.tabMonthlyReport.Controls.Add(this.lblReportStaffSalaryCost);
            this.tabMonthlyReport.Controls.Add(this.lblReportCostAndExpenses);
            this.tabMonthlyReport.Controls.Add(this.lblReportServiceRevenue);
            this.tabMonthlyReport.Controls.Add(this.lblReportProfit);
            this.tabMonthlyReport.Controls.Add(this.lblReportCost);
            this.tabMonthlyReport.Controls.Add(this.lblReportRevenue);
            this.tabMonthlyReport.Controls.Add(this.lblReportNumOfService);
            this.tabMonthlyReport.Controls.Add(this.label23);
            this.tabMonthlyReport.Controls.Add(this.label22);
            this.tabMonthlyReport.Controls.Add(this.label21);
            this.tabMonthlyReport.Controls.Add(this.label20);
            this.tabMonthlyReport.Controls.Add(this.label19);
            this.tabMonthlyReport.Controls.Add(this.label18);
            this.tabMonthlyReport.Controls.Add(this.label17);
            this.tabMonthlyReport.Controls.Add(this.label16);
            this.tabMonthlyReport.Controls.Add(this.label15);
            this.tabMonthlyReport.Controls.Add(this.lblMonthlyReportTitle);
            this.tabMonthlyReport.Location = new System.Drawing.Point(4, 37);
            this.tabMonthlyReport.Margin = new System.Windows.Forms.Padding(2);
            this.tabMonthlyReport.Name = "tabMonthlyReport";
            this.tabMonthlyReport.Padding = new System.Windows.Forms.Padding(2);
            this.tabMonthlyReport.Size = new System.Drawing.Size(893, 472);
            this.tabMonthlyReport.TabIndex = 0;
            this.tabMonthlyReport.Text = "Monthly Report";
            this.tabMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // lblReportFinalProfit
            // 
            this.lblReportFinalProfit.AutoSize = true;
            this.lblReportFinalProfit.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportFinalProfit.Location = new System.Drawing.Point(464, 430);
            this.lblReportFinalProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportFinalProfit.Name = "lblReportFinalProfit";
            this.lblReportFinalProfit.Size = new System.Drawing.Size(55, 30);
            this.lblReportFinalProfit.TabIndex = 62;
            this.lblReportFinalProfit.Text = "RM-";
            // 
            // lblReportStaffSalaryCost
            // 
            this.lblReportStaffSalaryCost.AutoSize = true;
            this.lblReportStaffSalaryCost.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportStaffSalaryCost.Location = new System.Drawing.Point(464, 381);
            this.lblReportStaffSalaryCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportStaffSalaryCost.Name = "lblReportStaffSalaryCost";
            this.lblReportStaffSalaryCost.Size = new System.Drawing.Size(55, 30);
            this.lblReportStaffSalaryCost.TabIndex = 61;
            this.lblReportStaffSalaryCost.Text = "RM-";
            // 
            // lblReportCostAndExpenses
            // 
            this.lblReportCostAndExpenses.AutoSize = true;
            this.lblReportCostAndExpenses.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportCostAndExpenses.Location = new System.Drawing.Point(464, 332);
            this.lblReportCostAndExpenses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportCostAndExpenses.Name = "lblReportCostAndExpenses";
            this.lblReportCostAndExpenses.Size = new System.Drawing.Size(55, 30);
            this.lblReportCostAndExpenses.TabIndex = 60;
            this.lblReportCostAndExpenses.Text = "RM-";
            // 
            // lblReportServiceRevenue
            // 
            this.lblReportServiceRevenue.AutoSize = true;
            this.lblReportServiceRevenue.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportServiceRevenue.Location = new System.Drawing.Point(464, 283);
            this.lblReportServiceRevenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportServiceRevenue.Name = "lblReportServiceRevenue";
            this.lblReportServiceRevenue.Size = new System.Drawing.Size(55, 30);
            this.lblReportServiceRevenue.TabIndex = 58;
            this.lblReportServiceRevenue.Text = "RM-";
            // 
            // lblReportProfit
            // 
            this.lblReportProfit.AutoSize = true;
            this.lblReportProfit.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportProfit.Location = new System.Drawing.Point(464, 185);
            this.lblReportProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportProfit.Name = "lblReportProfit";
            this.lblReportProfit.Size = new System.Drawing.Size(55, 30);
            this.lblReportProfit.TabIndex = 57;
            this.lblReportProfit.Text = "RM-";
            // 
            // lblReportCost
            // 
            this.lblReportCost.AutoSize = true;
            this.lblReportCost.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportCost.Location = new System.Drawing.Point(464, 136);
            this.lblReportCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportCost.Name = "lblReportCost";
            this.lblReportCost.Size = new System.Drawing.Size(55, 30);
            this.lblReportCost.TabIndex = 56;
            this.lblReportCost.Text = "RM-";
            // 
            // lblReportRevenue
            // 
            this.lblReportRevenue.AutoSize = true;
            this.lblReportRevenue.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportRevenue.Location = new System.Drawing.Point(464, 87);
            this.lblReportRevenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportRevenue.Name = "lblReportRevenue";
            this.lblReportRevenue.Size = new System.Drawing.Size(55, 30);
            this.lblReportRevenue.TabIndex = 55;
            this.lblReportRevenue.Text = "RM-";
            // 
            // lblReportNumOfService
            // 
            this.lblReportNumOfService.AutoSize = true;
            this.lblReportNumOfService.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportNumOfService.Location = new System.Drawing.Point(464, 38);
            this.lblReportNumOfService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportNumOfService.Name = "lblReportNumOfService";
            this.lblReportNumOfService.Size = new System.Drawing.Size(22, 30);
            this.lblReportNumOfService.TabIndex = 54;
            this.lblReportNumOfService.Text = "-";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(8, 430);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(141, 30);
            this.label23.TabIndex = 53;
            this.label23.Text = "Total Profit:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(8, 381);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(191, 30);
            this.label22.TabIndex = 52;
            this.label22.Text = "Staff Slary Cost:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 332);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(220, 30);
            this.label21.TabIndex = 51;
            this.label21.Text = "Cost and Expenses: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 283);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(236, 30);
            this.label20.TabIndex = 50;
            this.label20.Text = "Car Service Revenue: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(216, 234);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 30);
            this.label19.TabIndex = 49;
            this.label19.Text = "Description";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 185);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 30);
            this.label18.TabIndex = 48;
            this.label18.Text = "Profit:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 136);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 30);
            this.label17.TabIndex = 47;
            this.label17.Text = "Cost:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 87);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 30);
            this.label16.TabIndex = 46;
            this.label16.Text = "Revenue:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 38);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 30);
            this.label15.TabIndex = 45;
            this.label15.Text = "Number of Services:";
            // 
            // lblMonthlyReportTitle
            // 
            this.lblMonthlyReportTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMonthlyReportTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyReportTitle.Location = new System.Drawing.Point(2, 2);
            this.lblMonthlyReportTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonthlyReportTitle.Name = "lblMonthlyReportTitle";
            this.lblMonthlyReportTitle.Size = new System.Drawing.Size(884, 29);
            this.lblMonthlyReportTitle.TabIndex = 45;
            this.lblMonthlyReportTitle.Text = "CarCare Service Centre Monthly Report";
            // 
            // tabServiceReport
            // 
            this.tabServiceReport.Controls.Add(this.tlpServiceReportSortButton);
            this.tabServiceReport.Controls.Add(this.panel5);
            this.tabServiceReport.Controls.Add(this.lblMonthlyServiceReport);
            this.tabServiceReport.Location = new System.Drawing.Point(4, 37);
            this.tabServiceReport.Margin = new System.Windows.Forms.Padding(2);
            this.tabServiceReport.Name = "tabServiceReport";
            this.tabServiceReport.Padding = new System.Windows.Forms.Padding(2);
            this.tabServiceReport.Size = new System.Drawing.Size(893, 472);
            this.tabServiceReport.TabIndex = 1;
            this.tabServiceReport.Text = "Service Report";
            this.tabServiceReport.UseVisualStyleBackColor = true;
            // 
            // tlpServiceReportSortButton
            // 
            this.tlpServiceReportSortButton.BackColor = System.Drawing.Color.Gainsboro;
            this.tlpServiceReportSortButton.ColumnCount = 4;
            this.tlpServiceReportSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.73786F));
            this.tlpServiceReportSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.26214F));
            this.tlpServiceReportSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.tlpServiceReportSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tlpServiceReportSortButton.Controls.Add(this.btnServiceReportSortPrice, 2, 0);
            this.tlpServiceReportSortButton.Controls.Add(this.btnServiceReportSortSOID, 0, 0);
            this.tlpServiceReportSortButton.Controls.Add(this.btnServiceReportSortDate, 1, 0);
            this.tlpServiceReportSortButton.Location = new System.Drawing.Point(14, 52);
            this.tlpServiceReportSortButton.Margin = new System.Windows.Forms.Padding(2);
            this.tlpServiceReportSortButton.Name = "tlpServiceReportSortButton";
            this.tlpServiceReportSortButton.RowCount = 1;
            this.tlpServiceReportSortButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57265F));
            this.tlpServiceReportSortButton.Size = new System.Drawing.Size(811, 48);
            this.tlpServiceReportSortButton.TabIndex = 48;
            this.tlpServiceReportSortButton.Visible = false;
            // 
            // btnServiceReportSortPrice
            // 
            this.btnServiceReportSortPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServiceReportSortPrice.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceReportSortPrice.Location = new System.Drawing.Point(356, 2);
            this.btnServiceReportSortPrice.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceReportSortPrice.Name = "btnServiceReportSortPrice";
            this.btnServiceReportSortPrice.Size = new System.Drawing.Size(291, 44);
            this.btnServiceReportSortPrice.TabIndex = 21;
            this.btnServiceReportSortPrice.Text = "Price";
            this.btnServiceReportSortPrice.UseVisualStyleBackColor = true;
            // 
            // btnServiceReportSortSOID
            // 
            this.btnServiceReportSortSOID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServiceReportSortSOID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceReportSortSOID.Location = new System.Drawing.Point(2, 2);
            this.btnServiceReportSortSOID.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceReportSortSOID.Name = "btnServiceReportSortSOID";
            this.btnServiceReportSortSOID.Size = new System.Drawing.Size(98, 44);
            this.btnServiceReportSortSOID.TabIndex = 20;
            this.btnServiceReportSortSOID.Text = "SOID";
            this.btnServiceReportSortSOID.UseVisualStyleBackColor = true;
            // 
            // btnServiceReportSortDate
            // 
            this.btnServiceReportSortDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServiceReportSortDate.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceReportSortDate.Location = new System.Drawing.Point(104, 2);
            this.btnServiceReportSortDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceReportSortDate.Name = "btnServiceReportSortDate";
            this.btnServiceReportSortDate.Size = new System.Drawing.Size(248, 44);
            this.btnServiceReportSortDate.TabIndex = 21;
            this.btnServiceReportSortDate.Text = "Date";
            this.btnServiceReportSortDate.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.tlpServiceReportData);
            this.panel5.Location = new System.Drawing.Point(2, 100);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(882, 357);
            this.panel5.TabIndex = 47;
            this.panel5.Visible = false;
            // 
            // tlpServiceReportData
            // 
            this.tlpServiceReportData.AutoSize = true;
            this.tlpServiceReportData.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpServiceReportData.ColumnCount = 4;
            this.tlpServiceReportData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71486F));
            this.tlpServiceReportData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.28514F));
            this.tlpServiceReportData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.tlpServiceReportData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tlpServiceReportData.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpServiceReportData.Location = new System.Drawing.Point(11, 2);
            this.tlpServiceReportData.Margin = new System.Windows.Forms.Padding(2);
            this.tlpServiceReportData.Name = "tlpServiceReportData";
            this.tlpServiceReportData.RowCount = 1;
            this.tlpServiceReportData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpServiceReportData.Size = new System.Drawing.Size(811, 58);
            this.tlpServiceReportData.TabIndex = 14;
            // 
            // lblMonthlyServiceReport
            // 
            this.lblMonthlyServiceReport.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMonthlyServiceReport.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyServiceReport.Location = new System.Drawing.Point(2, 2);
            this.lblMonthlyServiceReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonthlyServiceReport.Name = "lblMonthlyServiceReport";
            this.lblMonthlyServiceReport.Size = new System.Drawing.Size(884, 29);
            this.lblMonthlyServiceReport.TabIndex = 46;
            this.lblMonthlyServiceReport.Text = "CarCare Service Centre Monthly Service Report";
            // 
            // tabCostAndExpenses
            // 
            this.tabCostAndExpenses.Controls.Add(this.tlpCostAndExpensesSortButton);
            this.tabCostAndExpenses.Controls.Add(this.panel6);
            this.tabCostAndExpenses.Controls.Add(this.lblCostAndExpensesReport);
            this.tabCostAndExpenses.Location = new System.Drawing.Point(4, 37);
            this.tabCostAndExpenses.Margin = new System.Windows.Forms.Padding(2);
            this.tabCostAndExpenses.Name = "tabCostAndExpenses";
            this.tabCostAndExpenses.Size = new System.Drawing.Size(893, 472);
            this.tabCostAndExpenses.TabIndex = 2;
            this.tabCostAndExpenses.Text = "Cost and Expenses";
            this.tabCostAndExpenses.UseVisualStyleBackColor = true;
            // 
            // tlpCostAndExpensesSortButton
            // 
            this.tlpCostAndExpensesSortButton.BackColor = System.Drawing.Color.Gainsboro;
            this.tlpCostAndExpensesSortButton.ColumnCount = 4;
            this.tlpCostAndExpensesSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.73786F));
            this.tlpCostAndExpensesSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.26214F));
            this.tlpCostAndExpensesSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tlpCostAndExpensesSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tlpCostAndExpensesSortButton.Controls.Add(this.button5, 2, 0);
            this.tlpCostAndExpensesSortButton.Controls.Add(this.button6, 0, 0);
            this.tlpCostAndExpensesSortButton.Controls.Add(this.button7, 1, 0);
            this.tlpCostAndExpensesSortButton.Location = new System.Drawing.Point(14, 57);
            this.tlpCostAndExpensesSortButton.Margin = new System.Windows.Forms.Padding(2);
            this.tlpCostAndExpensesSortButton.Name = "tlpCostAndExpensesSortButton";
            this.tlpCostAndExpensesSortButton.RowCount = 1;
            this.tlpCostAndExpensesSortButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57265F));
            this.tlpCostAndExpensesSortButton.Size = new System.Drawing.Size(811, 48);
            this.tlpCostAndExpensesSortButton.TabIndex = 51;
            this.tlpCostAndExpensesSortButton.Visible = false;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(467, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 44);
            this.button5.TabIndex = 21;
            this.button5.Text = "btnCaEPrice";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(2, 2);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 44);
            this.button6.TabIndex = 20;
            this.button6.Text = "btnCaEID";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(135, 2);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(328, 44);
            this.button7.TabIndex = 21;
            this.button7.Text = "btnCaEDate";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.tlpCostAndExpensesData);
            this.panel6.Location = new System.Drawing.Point(2, 105);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(882, 357);
            this.panel6.TabIndex = 50;
            this.panel6.Visible = false;
            // 
            // tlpCostAndExpensesData
            // 
            this.tlpCostAndExpensesData.AutoSize = true;
            this.tlpCostAndExpensesData.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpCostAndExpensesData.ColumnCount = 4;
            this.tlpCostAndExpensesData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71486F));
            this.tlpCostAndExpensesData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.28514F));
            this.tlpCostAndExpensesData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tlpCostAndExpensesData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tlpCostAndExpensesData.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpCostAndExpensesData.Location = new System.Drawing.Point(11, 2);
            this.tlpCostAndExpensesData.Margin = new System.Windows.Forms.Padding(2);
            this.tlpCostAndExpensesData.Name = "tlpCostAndExpensesData";
            this.tlpCostAndExpensesData.RowCount = 1;
            this.tlpCostAndExpensesData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCostAndExpensesData.Size = new System.Drawing.Size(811, 58);
            this.tlpCostAndExpensesData.TabIndex = 14;
            // 
            // lblCostAndExpensesReport
            // 
            this.lblCostAndExpensesReport.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCostAndExpensesReport.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostAndExpensesReport.Location = new System.Drawing.Point(2, 7);
            this.lblCostAndExpensesReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostAndExpensesReport.Name = "lblCostAndExpensesReport";
            this.lblCostAndExpensesReport.Size = new System.Drawing.Size(884, 29);
            this.lblCostAndExpensesReport.TabIndex = 49;
            this.lblCostAndExpensesReport.Text = "CarCare Service Centre Monthly Cost and Expenses Report";
            // 
            // tabStaffSalaryReport
            // 
            this.tabStaffSalaryReport.Controls.Add(this.lblStaffSalaryTotal);
            this.tabStaffSalaryReport.Controls.Add(this.label27);
            this.tabStaffSalaryReport.Controls.Add(this.tlpStaffSalaryReportSortButton);
            this.tabStaffSalaryReport.Controls.Add(this.pnlStaffSalaryReport);
            this.tabStaffSalaryReport.Controls.Add(this.lblStaffSalaryReport);
            this.tabStaffSalaryReport.Location = new System.Drawing.Point(4, 37);
            this.tabStaffSalaryReport.Margin = new System.Windows.Forms.Padding(2);
            this.tabStaffSalaryReport.Name = "tabStaffSalaryReport";
            this.tabStaffSalaryReport.Size = new System.Drawing.Size(893, 472);
            this.tabStaffSalaryReport.TabIndex = 3;
            this.tabStaffSalaryReport.Text = "Staff Salary report";
            this.tabStaffSalaryReport.UseVisualStyleBackColor = true;
            // 
            // lblStaffSalaryTotal
            // 
            this.lblStaffSalaryTotal.AutoSize = true;
            this.lblStaffSalaryTotal.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffSalaryTotal.Location = new System.Drawing.Point(727, 426);
            this.lblStaffSalaryTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffSalaryTotal.Name = "lblStaffSalaryTotal";
            this.lblStaffSalaryTotal.Size = new System.Drawing.Size(0, 30);
            this.lblStaffSalaryTotal.TabIndex = 52;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(616, 426);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 30);
            this.label27.TabIndex = 45;
            this.label27.Text = "Total:";
            // 
            // tlpStaffSalaryReportSortButton
            // 
            this.tlpStaffSalaryReportSortButton.BackColor = System.Drawing.Color.Gainsboro;
            this.tlpStaffSalaryReportSortButton.ColumnCount = 4;
            this.tlpStaffSalaryReportSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.73786F));
            this.tlpStaffSalaryReportSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.26214F));
            this.tlpStaffSalaryReportSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tlpStaffSalaryReportSortButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tlpStaffSalaryReportSortButton.Controls.Add(this.btnSSRPrice, 2, 0);
            this.tlpStaffSalaryReportSortButton.Controls.Add(this.btnSSRID, 0, 0);
            this.tlpStaffSalaryReportSortButton.Controls.Add(this.btnSSRName, 1, 0);
            this.tlpStaffSalaryReportSortButton.Location = new System.Drawing.Point(14, 57);
            this.tlpStaffSalaryReportSortButton.Margin = new System.Windows.Forms.Padding(2);
            this.tlpStaffSalaryReportSortButton.Name = "tlpStaffSalaryReportSortButton";
            this.tlpStaffSalaryReportSortButton.RowCount = 1;
            this.tlpStaffSalaryReportSortButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57265F));
            this.tlpStaffSalaryReportSortButton.Size = new System.Drawing.Size(811, 48);
            this.tlpStaffSalaryReportSortButton.TabIndex = 51;
            this.tlpStaffSalaryReportSortButton.Visible = false;
            // 
            // btnSSRPrice
            // 
            this.btnSSRPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSSRPrice.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSRPrice.Location = new System.Drawing.Point(484, 2);
            this.btnSSRPrice.Margin = new System.Windows.Forms.Padding(2);
            this.btnSSRPrice.Name = "btnSSRPrice";
            this.btnSSRPrice.Size = new System.Drawing.Size(148, 44);
            this.btnSSRPrice.TabIndex = 21;
            this.btnSSRPrice.Text = "Salary Amount";
            this.btnSSRPrice.UseVisualStyleBackColor = true;
            this.btnSSRPrice.Click += new System.EventHandler(this.btnSSRPrice_Click);
            // 
            // btnSSRID
            // 
            this.btnSSRID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSSRID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSRID.Location = new System.Drawing.Point(2, 2);
            this.btnSSRID.Margin = new System.Windows.Forms.Padding(2);
            this.btnSSRID.Name = "btnSSRID";
            this.btnSSRID.Size = new System.Drawing.Size(134, 44);
            this.btnSSRID.TabIndex = 20;
            this.btnSSRID.Text = "ID";
            this.btnSSRID.UseVisualStyleBackColor = true;
            this.btnSSRID.Click += new System.EventHandler(this.btnSSRID_Click);
            // 
            // btnSSRName
            // 
            this.btnSSRName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSSRName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSRName.Location = new System.Drawing.Point(140, 2);
            this.btnSSRName.Margin = new System.Windows.Forms.Padding(2);
            this.btnSSRName.Name = "btnSSRName";
            this.btnSSRName.Size = new System.Drawing.Size(340, 44);
            this.btnSSRName.TabIndex = 21;
            this.btnSSRName.Text = "Name";
            this.btnSSRName.UseVisualStyleBackColor = true;
            this.btnSSRName.Click += new System.EventHandler(this.btnSSRName_Click);
            // 
            // pnlStaffSalaryReport
            // 
            this.pnlStaffSalaryReport.AutoScroll = true;
            this.pnlStaffSalaryReport.Controls.Add(this.tlpStaffSalaryReportData);
            this.pnlStaffSalaryReport.Location = new System.Drawing.Point(2, 105);
            this.pnlStaffSalaryReport.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStaffSalaryReport.Name = "pnlStaffSalaryReport";
            this.pnlStaffSalaryReport.Size = new System.Drawing.Size(882, 300);
            this.pnlStaffSalaryReport.TabIndex = 50;
            this.pnlStaffSalaryReport.Visible = false;
            // 
            // tlpStaffSalaryReportData
            // 
            this.tlpStaffSalaryReportData.AutoSize = true;
            this.tlpStaffSalaryReportData.ColumnCount = 4;
            this.tlpStaffSalaryReportData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71486F));
            this.tlpStaffSalaryReportData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.28514F));
            this.tlpStaffSalaryReportData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tlpStaffSalaryReportData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tlpStaffSalaryReportData.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpStaffSalaryReportData.Location = new System.Drawing.Point(14, 2);
            this.tlpStaffSalaryReportData.Margin = new System.Windows.Forms.Padding(2);
            this.tlpStaffSalaryReportData.Name = "tlpStaffSalaryReportData";
            this.tlpStaffSalaryReportData.RowCount = 1;
            this.tlpStaffSalaryReportData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStaffSalaryReportData.Size = new System.Drawing.Size(811, 45);
            this.tlpStaffSalaryReportData.TabIndex = 14;
            // 
            // lblStaffSalaryReport
            // 
            this.lblStaffSalaryReport.BackColor = System.Drawing.Color.Gainsboro;
            this.lblStaffSalaryReport.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffSalaryReport.Location = new System.Drawing.Point(2, 7);
            this.lblStaffSalaryReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffSalaryReport.Name = "lblStaffSalaryReport";
            this.lblStaffSalaryReport.Size = new System.Drawing.Size(884, 29);
            this.lblStaffSalaryReport.TabIndex = 49;
            this.lblStaffSalaryReport.Text = "CarCare Service Centre Monthly Staff Salary Report";
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.btnLogout);
            this.tabProfile.Controls.Add(this.lblAdminEmail);
            this.tabProfile.Controls.Add(this.lblAdminName);
            this.tabProfile.Controls.Add(this.lblAdminID);
            this.tabProfile.Controls.Add(this.btnChangePassword);
            this.tabProfile.Controls.Add(this.btnChangeEmail);
            this.tabProfile.Controls.Add(this.btnChangeUserName);
            this.tabProfile.Controls.Add(this.label50);
            this.tabProfile.Controls.Add(this.label44);
            this.tabProfile.Controls.Add(this.label55);
            this.tabProfile.Controls.Add(this.label66);
            this.tabProfile.Location = new System.Drawing.Point(84, 4);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(2);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(996, 612);
            this.tabProfile.TabIndex = 5;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(810, 18);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 51);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminEmail.Location = new System.Drawing.Point(306, 323);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(0, 34);
            this.lblAdminEmail.TabIndex = 22;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(306, 249);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(0, 34);
            this.lblAdminName.TabIndex = 21;
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminID.Location = new System.Drawing.Point(306, 175);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(0, 34);
            this.lblAdminID.TabIndex = 20;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(657, 531);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(208, 52);
            this.btnChangePassword.TabIndex = 19;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEmail.Location = new System.Drawing.Point(344, 531);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(208, 52);
            this.btnChangeEmail.TabIndex = 18;
            this.btnChangeEmail.Text = "Change Email";
            this.btnChangeEmail.UseVisualStyleBackColor = true;
            // 
            // btnChangeUserName
            // 
            this.btnChangeUserName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeUserName.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUserName.Location = new System.Drawing.Point(31, 531);
            this.btnChangeUserName.Name = "btnChangeUserName";
            this.btnChangeUserName.Size = new System.Drawing.Size(208, 52);
            this.btnChangeUserName.TabIndex = 17;
            this.btnChangeUserName.Text = "Change User Name";
            this.btnChangeUserName.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(95, 323);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(96, 34);
            this.label50.TabIndex = 16;
            this.label50.Text = "Email:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(95, 249);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(171, 34);
            this.label44.TabIndex = 15;
            this.label44.Text = "User Name:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(95, 175);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(113, 34);
            this.label55.TabIndex = 14;
            this.label55.Text = "UserID:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Ink Free", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(385, 36);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(148, 54);
            this.label66.TabIndex = 13;
            this.label66.Text = "Profile";
            // 
            // frmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 620);
            this.Controls.Add(this.tabAdmin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdminMain";
            this.Text = "CarCare Service Centre - Admin";
            this.Load += new System.EventHandler(this.frmAdminMain_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtHomeRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tabStaffAccount.ResumeLayout(false);
            this.tabStaffAccount.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            this.tlpServiceSortButtons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabFeedback.ResumeLayout(false);
            this.tabFeedback.PerformLayout();
            this.tlpFeedbackSortButton.ResumeLayout(false);
            this.pnlFeedbackData.ResumeLayout(false);
            this.pnlFeedbackData.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtFeedbackRating)).EndInit();
            this.tabSalariesRecord.ResumeLayout(false);
            this.tabSalariesRecord.PerformLayout();
            this.tlpSalaryBtnSort.ResumeLayout(false);
            this.pnlSalary.ResumeLayout(false);
            this.pnlSalary.PerformLayout();
            this.tabReport.ResumeLayout(false);
            this.tabReport.PerformLayout();
            this.tabReportSelection.ResumeLayout(false);
            this.tabMonthlyReport.ResumeLayout(false);
            this.tabMonthlyReport.PerformLayout();
            this.tabServiceReport.ResumeLayout(false);
            this.tlpServiceReportSortButton.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabCostAndExpenses.ResumeLayout(false);
            this.tlpCostAndExpensesSortButton.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabStaffSalaryReport.ResumeLayout(false);
            this.tabStaffSalaryReport.PerformLayout();
            this.tlpStaffSalaryReportSortButton.ResumeLayout(false);
            this.pnlStaffSalaryReport.ResumeLayout(false);
            this.pnlStaffSalaryReport.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabStaffAccount;
        private System.Windows.Forms.Button btnStaffSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.TabPage tabFeedback;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStaffAdd;
        private System.Windows.Forms.Button btnStaffAccountSortName;
        private System.Windows.Forms.Button btnStaffAccountSortID;
        private Panel panel2;
        private Button btnServiceAdd;
        private Panel panel3;
        private Button btnServiceSearch;
        private Label label12;
        private Label label11;
        private TabPage tabProfile;
        private PictureBox pictureBoxLogo;
        private Label lblWelcome;
        private Label label1;
        private Button btnHomeSearch;
        private Button btnHomeProfitDetail;
        private Label lblHomeProfit;
        private Label lblMoneySpent;
        private Label lblMoneyEarn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnHomeRatingDetail;
        private ComboBox cmbHomeYear;
        private ComboBox cmbHomeMonth;
        private TableLayoutPanel tlpServiceSortButtons;
        private Button btnServiceSortType;
        private Button btnServiceSortID;
        private Button btnServiceSortName;
        private Label lblAdminEmail;
        private Label lblAdminName;
        private Label lblAdminID;
        private Button btnChangePassword;
        private Button btnChangeEmail;
        private Button btnChangeUserName;
        private Label label50;
        private Label label44;
        private Label label55;
        private Label label66;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtHomeRating;
        private Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtFeedbackRating;
        private ComboBox cmbFeedbackYear;
        private ComboBox cmbFeedbackMonth;
        private Button btnFeedbackSearch;
        private Label label13;
        private TableLayoutPanel tlpFeedbackSortButton;
        private Button btnFeedbackSortDate;
        private Button btnFeedbackSortID;
        private Button btnFeedbackSortName;
        private Panel pnlFeedbackData;
        private Button btnFeedbackSortComment;
        private Button btnFeedbackSortRating;
        private Label lblFeedbackTotal;
        private TabControl tabReportSelection;
        private TabPage tabMonthlyReport;
        private TabPage tabServiceReport;
        private TabPage tabCostAndExpenses;
        private TabPage tabStaffSalaryReport;
        private ComboBox cmbReportYear;
        private ComboBox cmbReportMonth;
        private Button btnReportSearch;
        private Label label14;
        private Label lblReportFinalProfit;
        private Label lblReportStaffSalaryCost;
        private Label lblReportCostAndExpenses;
        private Label lblReportServiceRevenue;
        private Label lblReportProfit;
        private Label lblReportCost;
        private Label lblReportRevenue;
        private Label lblReportNumOfService;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label lblMonthlyReportTitle;
        private Label lblMonthlyServiceReport;
        private TableLayoutPanel tlpServiceReportSortButton;
        private Button btnServiceReportSortPrice;
        private Button btnServiceReportSortSOID;
        private Button btnServiceReportSortDate;
        private Panel panel5;
        private TableLayoutPanel tlpServiceReportData;
        private TableLayoutPanel tlpCostAndExpensesSortButton;
        private Button button5;
        private Button button6;
        private Button button7;
        private Panel panel6;
        private TableLayoutPanel tlpCostAndExpensesData;
        private Label lblCostAndExpensesReport;
        private TableLayoutPanel tlpStaffSalaryReportSortButton;
        private Button btnSSRPrice;
        private Button btnSSRID;
        private Button btnSSRName;
        private Panel pnlStaffSalaryReport;
        private TableLayoutPanel tlpStaffSalaryReportData;
        private Label lblStaffSalaryReport;
        private TabPage tabSalariesRecord;
        private Panel pnlSalary;
        private ComboBox cmbSalaryRole;
        private Label label26;
        private TableLayoutPanel tlpSalaryBtnSort;
        private Button btnSalarySortBaseSalary;
        private Button btnSalarySortRole;
        private Button btnSalarySortID;
        private Button btnSalarySortName;
        private Label label24;
        private ComboBox cmbSalaryYear;
        private ComboBox cmbSalaryMonth;
        private Label label25;
        private TextBox txtSalarySearch;
        public TableLayoutPanel tlpServiceData;
        public TableLayoutPanel tlpStaffAccountData;
        public TableLayoutPanel tlpFeedbackData;
        public TableLayoutPanel tlpSalaryData;
        public TextBox txtStaffSearch;
        public ComboBox cmbRoleSelection;
        public TextBox txtServiceSearch;
        public ComboBox cmbServiceType;
        private Label lblStaffSalaryTotal;
        private Label label27;
        private Button btnLogout;
    }
}