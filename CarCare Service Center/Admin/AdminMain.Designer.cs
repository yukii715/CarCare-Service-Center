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
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnHomeRatingDetail = new System.Windows.Forms.Button();
            this.cmbHomeYear = new System.Windows.Forms.ComboBox();
            this.cmbHomeMonth = new System.Windows.Forms.ComboBox();
            this.btnHomeGenerate = new System.Windows.Forms.Button();
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tabStaffAccount = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlpStaffAccountData = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.btnStaffDelete = new System.Windows.Forms.Button();
            this.btnStaffDetail = new System.Windows.Forms.Button();
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
            this.btnServiceDelete = new System.Windows.Forms.Button();
            this.btnServiceDetails = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tlpServiceData = new System.Windows.Forms.TableLayoutPanel();
            this.btnServiceSearch = new System.Windows.Forms.Button();
            this.txtServiceSearch = new System.Windows.Forms.TextBox();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabFeedback = new System.Windows.Forms.TabPage();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
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
            this.tabAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabStaffAccount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.tlpServiceSortButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabAdmin.Controls.Add(this.tabPage1);
            this.tabAdmin.Controls.Add(this.tabStaffAccount);
            this.tabAdmin.Controls.Add(this.tabServices);
            this.tabAdmin.Controls.Add(this.tabFeedback);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnHomeRatingDetail);
            this.tabPage1.Controls.Add(this.cmbHomeYear);
            this.tabPage1.Controls.Add(this.cmbHomeMonth);
            this.tabPage1.Controls.Add(this.btnHomeGenerate);
            this.tabPage1.Controls.Add(this.btnHomeProfitDetail);
            this.tabPage1.Controls.Add(this.lblHomeProfit);
            this.tabPage1.Controls.Add(this.lblMoneySpent);
            this.tabPage1.Controls.Add(this.lblMoneyEarn);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblWelcome);
            this.tabPage1.Controls.Add(this.btnLogout);
            this.tabPage1.Controls.Add(this.pictureBoxLogo);
            this.tabPage1.Location = new System.Drawing.Point(84, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(996, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnHomeRatingDetail
            // 
            this.btnHomeRatingDetail.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeRatingDetail.Location = new System.Drawing.Point(708, 549);
            this.btnHomeRatingDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeRatingDetail.Name = "btnHomeRatingDetail";
            this.btnHomeRatingDetail.Size = new System.Drawing.Size(176, 42);
            this.btnHomeRatingDetail.TabIndex = 41;
            this.btnHomeRatingDetail.Text = "More Detail";
            this.btnHomeRatingDetail.UseVisualStyleBackColor = true;
            // 
            // cmbHomeYear
            // 
            this.cmbHomeYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeYear.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHomeYear.FormattingEnabled = true;
            this.cmbHomeYear.Items.AddRange(new object[] {
            "2024"});
            this.cmbHomeYear.Location = new System.Drawing.Point(402, 240);
            this.cmbHomeYear.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHomeYear.Name = "cmbHomeYear";
            this.cmbHomeYear.Size = new System.Drawing.Size(138, 36);
            this.cmbHomeYear.TabIndex = 40;
            // 
            // cmbHomeMonth
            // 
            this.cmbHomeMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeMonth.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHomeMonth.FormattingEnabled = true;
            this.cmbHomeMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbHomeMonth.Location = new System.Drawing.Point(132, 240);
            this.cmbHomeMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHomeMonth.Name = "cmbHomeMonth";
            this.cmbHomeMonth.Size = new System.Drawing.Size(203, 36);
            this.cmbHomeMonth.TabIndex = 39;
            // 
            // btnHomeGenerate
            // 
            this.btnHomeGenerate.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeGenerate.Location = new System.Drawing.Point(590, 236);
            this.btnHomeGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeGenerate.Name = "btnHomeGenerate";
            this.btnHomeGenerate.Size = new System.Drawing.Size(120, 42);
            this.btnHomeGenerate.TabIndex = 38;
            this.btnHomeGenerate.Text = "Generate";
            this.btnHomeGenerate.UseVisualStyleBackColor = true;
            // 
            // btnHomeProfitDetail
            // 
            this.btnHomeProfitDetail.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeProfitDetail.Location = new System.Drawing.Point(231, 549);
            this.btnHomeProfitDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeProfitDetail.Name = "btnHomeProfitDetail";
            this.btnHomeProfitDetail.Size = new System.Drawing.Size(170, 42);
            this.btnHomeProfitDetail.TabIndex = 37;
            this.btnHomeProfitDetail.Text = "More Detail";
            this.btnHomeProfitDetail.UseVisualStyleBackColor = true;
            // 
            // lblHomeProfit
            // 
            this.lblHomeProfit.AutoSize = true;
            this.lblHomeProfit.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeProfit.Location = new System.Drawing.Point(266, 474);
            this.lblHomeProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeProfit.Name = "lblHomeProfit";
            this.lblHomeProfit.Size = new System.Drawing.Size(46, 30);
            this.lblHomeProfit.TabIndex = 36;
            this.lblHomeProfit.Text = "RM";
            // 
            // lblMoneySpent
            // 
            this.lblMoneySpent.AutoSize = true;
            this.lblMoneySpent.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneySpent.Location = new System.Drawing.Point(266, 392);
            this.lblMoneySpent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoneySpent.Name = "lblMoneySpent";
            this.lblMoneySpent.Size = new System.Drawing.Size(46, 30);
            this.lblMoneySpent.TabIndex = 35;
            this.lblMoneySpent.Text = "RM";
            // 
            // lblMoneyEarn
            // 
            this.lblMoneyEarn.AutoSize = true;
            this.lblMoneyEarn.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyEarn.Location = new System.Drawing.Point(266, 310);
            this.lblMoneyEarn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoneyEarn.Name = "lblMoneyEarn";
            this.lblMoneyEarn.Size = new System.Drawing.Size(46, 30);
            this.lblMoneyEarn.TabIndex = 34;
            this.lblMoneyEarn.Text = "RM";
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
            this.lblWelcome.Size = new System.Drawing.Size(391, 51);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome Back, Admin";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(800, 15);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 42);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(431, -3);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(172, 159);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tabStaffAccount
            // 
            this.tabStaffAccount.Controls.Add(this.panel2);
            this.tabStaffAccount.Controls.Add(this.panel1);
            this.tabStaffAccount.Controls.Add(this.btnStaffAdd);
            this.tabStaffAccount.Controls.Add(this.btnStaffDelete);
            this.tabStaffAccount.Controls.Add(this.btnStaffDetail);
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
            this.panel2.Location = new System.Drawing.Point(4, 238);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 269);
            this.panel2.TabIndex = 14;
            // 
            // tlpStaffAccountData
            // 
            this.tlpStaffAccountData.ColumnCount = 3;
            this.tlpStaffAccountData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.59679F));
            this.tlpStaffAccountData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.40321F));
            this.tlpStaffAccountData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tlpStaffAccountData.Location = new System.Drawing.Point(27, 2);
            this.tlpStaffAccountData.Margin = new System.Windows.Forms.Padding(2);
            this.tlpStaffAccountData.Name = "tlpStaffAccountData";
            this.tlpStaffAccountData.RowCount = 7;
            this.tlpStaffAccountData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57265F));
            this.tlpStaffAccountData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.42735F));
            this.tlpStaffAccountData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpStaffAccountData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpStaffAccountData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpStaffAccountData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpStaffAccountData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tlpStaffAccountData.Size = new System.Drawing.Size(824, 297);
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
            this.panel1.Size = new System.Drawing.Size(898, 43);
            this.panel1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 9);
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
            this.label9.Location = new System.Drawing.Point(300, 9);
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
            this.label10.Location = new System.Drawing.Point(670, 10);
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
            // btnStaffDelete
            // 
            this.btnStaffDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDelete.Location = new System.Drawing.Point(406, 528);
            this.btnStaffDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(125, 42);
            this.btnStaffDelete.TabIndex = 11;
            this.btnStaffDelete.Text = "Delete";
            this.btnStaffDelete.UseVisualStyleBackColor = true;
            this.btnStaffDelete.Click += new System.EventHandler(this.btnStaffDelete_Click);
            // 
            // btnStaffDetail
            // 
            this.btnStaffDetail.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDetail.Location = new System.Drawing.Point(28, 528);
            this.btnStaffDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaffDetail.Name = "btnStaffDetail";
            this.btnStaffDetail.Size = new System.Drawing.Size(125, 42);
            this.btnStaffDetail.TabIndex = 10;
            this.btnStaffDetail.Text = "Details";
            this.btnStaffDetail.UseVisualStyleBackColor = true;
            this.btnStaffDetail.Click += new System.EventHandler(this.btnStaffDetail_Click);
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
            this.tabServices.Controls.Add(this.btnServiceDelete);
            this.tabServices.Controls.Add(this.btnServiceDetails);
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
            this.tlpServiceSortButtons.ColumnCount = 3;
            this.tlpServiceSortButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75248F));
            this.tlpServiceSortButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.24753F));
            this.tlpServiceSortButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 382F));
            this.tlpServiceSortButtons.Controls.Add(this.btnServiceSortType, 2, 0);
            this.tlpServiceSortButtons.Controls.Add(this.btnServiceSortID, 0, 0);
            this.tlpServiceSortButtons.Controls.Add(this.btnServiceSortName, 1, 0);
            this.tlpServiceSortButtons.Location = new System.Drawing.Point(34, 172);
            this.tlpServiceSortButtons.Margin = new System.Windows.Forms.Padding(2);
            this.tlpServiceSortButtons.Name = "tlpServiceSortButtons";
            this.tlpServiceSortButtons.RowCount = 1;
            this.tlpServiceSortButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57265F));
            this.tlpServiceSortButtons.Size = new System.Drawing.Size(834, 48);
            this.tlpServiceSortButtons.TabIndex = 20;
            // 
            // btnServiceSortType
            // 
            this.btnServiceSortType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServiceSortType.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceSortType.Location = new System.Drawing.Point(453, 2);
            this.btnServiceSortType.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceSortType.Name = "btnServiceSortType";
            this.btnServiceSortType.Size = new System.Drawing.Size(379, 44);
            this.btnServiceSortType.TabIndex = 21;
            this.btnServiceSortType.Text = "Service Type";
            this.btnServiceSortType.UseVisualStyleBackColor = true;
            // 
            // btnServiceSortID
            // 
            this.btnServiceSortID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServiceSortID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceSortID.Location = new System.Drawing.Point(2, 2);
            this.btnServiceSortID.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceSortID.Name = "btnServiceSortID";
            this.btnServiceSortID.Size = new System.Drawing.Size(107, 44);
            this.btnServiceSortID.TabIndex = 20;
            this.btnServiceSortID.Text = "ID";
            this.btnServiceSortID.UseVisualStyleBackColor = true;
            // 
            // btnServiceSortName
            // 
            this.btnServiceSortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServiceSortName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceSortName.Location = new System.Drawing.Point(113, 2);
            this.btnServiceSortName.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceSortName.Name = "btnServiceSortName";
            this.btnServiceSortName.Size = new System.Drawing.Size(336, 44);
            this.btnServiceSortName.TabIndex = 21;
            this.btnServiceSortName.Text = "Name";
            this.btnServiceSortName.UseVisualStyleBackColor = true;
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
            // btnServiceDelete
            // 
            this.btnServiceDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceDelete.Location = new System.Drawing.Point(394, 539);
            this.btnServiceDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceDelete.Name = "btnServiceDelete";
            this.btnServiceDelete.Size = new System.Drawing.Size(125, 42);
            this.btnServiceDelete.TabIndex = 18;
            this.btnServiceDelete.Text = "Delete";
            this.btnServiceDelete.UseVisualStyleBackColor = true;
            this.btnServiceDelete.Click += new System.EventHandler(this.btnServiceDelete_Click);
            // 
            // btnServiceDetails
            // 
            this.btnServiceDetails.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceDetails.Location = new System.Drawing.Point(15, 539);
            this.btnServiceDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceDetails.Name = "btnServiceDetails";
            this.btnServiceDetails.Size = new System.Drawing.Size(125, 42);
            this.btnServiceDetails.TabIndex = 17;
            this.btnServiceDetails.Text = "Details";
            this.btnServiceDetails.UseVisualStyleBackColor = true;
            this.btnServiceDetails.Click += new System.EventHandler(this.btnServiceDetails_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.tlpServiceData);
            this.panel3.Location = new System.Drawing.Point(16, 220);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 292);
            this.panel3.TabIndex = 16;
            // 
            // tlpServiceData
            // 
            this.tlpServiceData.ColumnCount = 3;
            this.tlpServiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75248F));
            this.tlpServiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.24752F));
            this.tlpServiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 382F));
            this.tlpServiceData.Location = new System.Drawing.Point(16, 2);
            this.tlpServiceData.Margin = new System.Windows.Forms.Padding(2);
            this.tlpServiceData.Name = "tlpServiceData";
            this.tlpServiceData.RowCount = 1;
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpServiceData.Size = new System.Drawing.Size(834, 46);
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
            this.tabFeedback.Location = new System.Drawing.Point(84, 4);
            this.tabFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.tabFeedback.Name = "tabFeedback";
            this.tabFeedback.Size = new System.Drawing.Size(996, 612);
            this.tabFeedback.TabIndex = 3;
            this.tabFeedback.Text = "Feedback";
            this.tabFeedback.UseVisualStyleBackColor = true;
            // 
            // tabReport
            // 
            this.tabReport.Location = new System.Drawing.Point(84, 4);
            this.tabReport.Margin = new System.Windows.Forms.Padding(2);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(996, 612);
            this.tabReport.TabIndex = 4;
            this.tabReport.Text = "Report";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.lblAdminEmail);
            this.tabProfile.Controls.Add(this.lblAdminName);
            this.tabProfile.Controls.Add(this.lblAdminID);
            this.tabProfile.Controls.Add(this.btnChangePassword);
            this.tabProfile.Controls.Add(this.btnChangeEmail);
            this.tabProfile.Controls.Add(this.btnChangeUserName);
            this.tabProfile.Controls.Add(this.label13);
            this.tabProfile.Controls.Add(this.label14);
            this.tabProfile.Controls.Add(this.label15);
            this.tabProfile.Controls.Add(this.label16);
            this.tabProfile.Location = new System.Drawing.Point(84, 4);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(2);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(996, 612);
            this.tabProfile.TabIndex = 5;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(95, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 34);
            this.label13.TabIndex = 16;
            this.label13.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(95, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 34);
            this.label14.TabIndex = 15;
            this.label14.Text = "User Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(95, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 34);
            this.label15.TabIndex = 14;
            this.label15.Text = "UserID:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Ink Free", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(385, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 54);
            this.label16.TabIndex = 13;
            this.label16.Text = "Profile";
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tabStaffAccount.ResumeLayout(false);
            this.tabStaffAccount.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            this.tlpServiceSortButtons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabStaffAccount;
        private System.Windows.Forms.Button btnStaffSearch;
        private System.Windows.Forms.TextBox txtStaffSearch;
        private System.Windows.Forms.ComboBox cmbRoleSelection;
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
        private System.Windows.Forms.Button btnStaffDelete;
        private System.Windows.Forms.Button btnStaffDetail;
        private System.Windows.Forms.Button btnStaffAccountSortName;
        private System.Windows.Forms.Button btnStaffAccountSortID;
        private System.Windows.Forms.TableLayoutPanel tlpStaffAccountData;
        private Panel panel2;
        private Button btnServiceAdd;
        private Button btnServiceDelete;
        private Button btnServiceDetails;
        private Panel panel3;
        private TableLayoutPanel tlpServiceData;
        private Button btnServiceSearch;
        private TextBox txtServiceSearch;
        private ComboBox cmbServiceType;
        private Label label12;
        private Label label11;
        private TabPage tabProfile;
        private PictureBox pictureBoxLogo;
        private Button btnLogout;
        private Label lblWelcome;
        private Label label1;
        private Button btnHomeGenerate;
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
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}