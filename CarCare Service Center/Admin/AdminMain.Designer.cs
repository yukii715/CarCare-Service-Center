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
            this.tabStaffAccount = new System.Windows.Forms.TabPage();
            this.panelStaffData = new System.Windows.Forms.Panel();
            this.tlpStaffData = new System.Windows.Forms.TableLayoutPanel();
            this.panelStaffAttribute = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.btnStaffDelete = new System.Windows.Forms.Button();
            this.btnStaffDetail = new System.Windows.Forms.Button();
            this.btnSortStaffName = new System.Windows.Forms.Button();
            this.btnSortStaffID = new System.Windows.Forms.Button();
            this.btnStaffSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbRoleSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.btnServiceDelete = new System.Windows.Forms.Button();
            this.btnServiceDetails = new System.Windows.Forms.Button();
            this.panelServiceData = new System.Windows.Forms.Panel();
            this.tlpServiceData = new System.Windows.Forms.TableLayoutPanel();
            this.panelServiceAttribute = new System.Windows.Forms.Panel();
            this.btnServiceSortServiceType = new System.Windows.Forms.Button();
            this.btnServiceSortName = new System.Windows.Forms.Button();
            this.btnServiceSortID = new System.Windows.Forms.Button();
            this.btnServiceSearch = new System.Windows.Forms.Button();
            this.txtServiceSearch = new System.Windows.Forms.TextBox();
            this.cmbServiceTypeSelection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabFeedback = new System.Windows.Forms.TabPage();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabAdmin.SuspendLayout();
            this.tabStaffAccount.SuspendLayout();
            this.panelStaffData.SuspendLayout();
            this.panelStaffAttribute.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.panelServiceData.SuspendLayout();
            this.panelServiceAttribute.SuspendLayout();
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
            this.tabAdmin.Location = new System.Drawing.Point(1, 2);
            this.tabAdmin.Multiline = true;
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1445, 861);
            this.tabAdmin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabAdmin.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(84, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1357, 853);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabStaffAccount
            // 
            this.tabStaffAccount.Controls.Add(this.panelStaffData);
            this.tabStaffAccount.Controls.Add(this.panelStaffAttribute);
            this.tabStaffAccount.Controls.Add(this.btnStaffAdd);
            this.tabStaffAccount.Controls.Add(this.btnStaffDelete);
            this.tabStaffAccount.Controls.Add(this.btnStaffDetail);
            this.tabStaffAccount.Controls.Add(this.btnSortStaffName);
            this.tabStaffAccount.Controls.Add(this.btnSortStaffID);
            this.tabStaffAccount.Controls.Add(this.btnStaffSearch);
            this.tabStaffAccount.Controls.Add(this.txtSearch);
            this.tabStaffAccount.Controls.Add(this.cmbRoleSelection);
            this.tabStaffAccount.Controls.Add(this.label2);
            this.tabStaffAccount.Controls.Add(this.label1);
            this.tabStaffAccount.Location = new System.Drawing.Point(84, 4);
            this.tabStaffAccount.Name = "tabStaffAccount";
            this.tabStaffAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaffAccount.Size = new System.Drawing.Size(1357, 853);
            this.tabStaffAccount.TabIndex = 1;
            this.tabStaffAccount.Text = "Staff Account";
            this.tabStaffAccount.UseVisualStyleBackColor = true;
            // 
            // panelStaffData
            // 
            this.panelStaffData.AutoScroll = true;
            this.panelStaffData.Controls.Add(this.tlpStaffData);
            this.panelStaffData.Location = new System.Drawing.Point(6, 331);
            this.panelStaffData.Name = "panelStaffData";
            this.panelStaffData.Size = new System.Drawing.Size(1228, 373);
            this.panelStaffData.TabIndex = 14;
            // 
            // tlpStaffData
            // 
            this.tlpStaffData.ColumnCount = 3;
            this.tlpStaffData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.59679F));
            this.tlpStaffData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.40321F));
            this.tlpStaffData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpStaffData.Location = new System.Drawing.Point(36, 3);
            this.tlpStaffData.Name = "tlpStaffData";
            this.tlpStaffData.RowCount = 7;
            this.tlpStaffData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57265F));
            this.tlpStaffData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.42735F));
            this.tlpStaffData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlpStaffData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpStaffData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpStaffData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpStaffData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStaffData.Size = new System.Drawing.Size(1098, 412);
            this.tlpStaffData.TabIndex = 14;
            // 
            // panelStaffAttribute
            // 
            this.panelStaffAttribute.AutoScroll = true;
            this.panelStaffAttribute.BackColor = System.Drawing.Color.Gainsboro;
            this.panelStaffAttribute.Controls.Add(this.label3);
            this.panelStaffAttribute.Controls.Add(this.label4);
            this.panelStaffAttribute.Controls.Add(this.label5);
            this.panelStaffAttribute.Location = new System.Drawing.Point(37, 276);
            this.panelStaffAttribute.Name = "panelStaffAttribute";
            this.panelStaffAttribute.Size = new System.Drawing.Size(1197, 60);
            this.panelStaffAttribute.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(893, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Role";
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffAdd.Location = new System.Drawing.Point(1047, 734);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(167, 58);
            this.btnStaffAdd.TabIndex = 12;
            this.btnStaffAdd.Text = "Add";
            this.btnStaffAdd.UseVisualStyleBackColor = true;
            this.btnStaffAdd.Click += new System.EventHandler(this.btnStaffAdd_Click);
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDelete.Location = new System.Drawing.Point(542, 734);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(167, 58);
            this.btnStaffDelete.TabIndex = 11;
            this.btnStaffDelete.Text = "Delete";
            this.btnStaffDelete.UseVisualStyleBackColor = true;
            this.btnStaffDelete.Click += new System.EventHandler(this.btnStaffDelete_Click);
            // 
            // btnStaffDetail
            // 
            this.btnStaffDetail.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDetail.Location = new System.Drawing.Point(37, 734);
            this.btnStaffDetail.Name = "btnStaffDetail";
            this.btnStaffDetail.Size = new System.Drawing.Size(167, 58);
            this.btnStaffDetail.TabIndex = 10;
            this.btnStaffDetail.Text = "Details";
            this.btnStaffDetail.UseVisualStyleBackColor = true;
            this.btnStaffDetail.Click += new System.EventHandler(this.btnStaffDetail_Click);
            // 
            // btnSortStaffName
            // 
            this.btnSortStaffName.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortStaffName.Location = new System.Drawing.Point(562, 178);
            this.btnSortStaffName.Name = "btnSortStaffName";
            this.btnSortStaffName.Size = new System.Drawing.Size(167, 58);
            this.btnSortStaffName.TabIndex = 9;
            this.btnSortStaffName.Text = "Name";
            this.btnSortStaffName.UseVisualStyleBackColor = true;
            this.btnSortStaffName.Click += new System.EventHandler(this.btnSortStaffName_Click);
            // 
            // btnSortStaffID
            // 
            this.btnSortStaffID.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortStaffID.Location = new System.Drawing.Point(249, 178);
            this.btnSortStaffID.Name = "btnSortStaffID";
            this.btnSortStaffID.Size = new System.Drawing.Size(167, 58);
            this.btnSortStaffID.TabIndex = 8;
            this.btnSortStaffID.Text = "ID";
            this.btnSortStaffID.UseVisualStyleBackColor = true;
            this.btnSortStaffID.Click += new System.EventHandler(this.btnSortStaffID_Click);
            // 
            // btnStaffSearch
            // 
            this.btnStaffSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffSearch.Location = new System.Drawing.Point(569, 98);
            this.btnStaffSearch.Name = "btnStaffSearch";
            this.btnStaffSearch.Size = new System.Drawing.Size(160, 58);
            this.btnStaffSearch.TabIndex = 7;
            this.btnStaffSearch.Text = "Search";
            this.btnStaffSearch.UseVisualStyleBackColor = true;
            this.btnStaffSearch.Click += new System.EventHandler(this.btnStaffSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(37, 105);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(476, 45);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "Search";
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
            this.cmbRoleSelection.Location = new System.Drawing.Point(163, 26);
            this.cmbRoleSelection.Name = "cmbRoleSelection";
            this.cmbRoleSelection.Size = new System.Drawing.Size(350, 46);
            this.cmbRoleSelection.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sort by:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role: ";
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.btnServiceAdd);
            this.tabServices.Controls.Add(this.btnServiceDelete);
            this.tabServices.Controls.Add(this.btnServiceDetails);
            this.tabServices.Controls.Add(this.panelServiceData);
            this.tabServices.Controls.Add(this.panelServiceAttribute);
            this.tabServices.Controls.Add(this.btnServiceSearch);
            this.tabServices.Controls.Add(this.txtServiceSearch);
            this.tabServices.Controls.Add(this.cmbServiceTypeSelection);
            this.tabServices.Controls.Add(this.label7);
            this.tabServices.Controls.Add(this.label6);
            this.tabServices.Location = new System.Drawing.Point(84, 4);
            this.tabServices.Name = "tabServices";
            this.tabServices.Size = new System.Drawing.Size(1357, 853);
            this.tabServices.TabIndex = 2;
            this.tabServices.Text = "Services";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceAdd.Location = new System.Drawing.Point(1047, 734);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(167, 58);
            this.btnServiceAdd.TabIndex = 19;
            this.btnServiceAdd.Text = "Add";
            this.btnServiceAdd.UseVisualStyleBackColor = true;
            // 
            // btnServiceDelete
            // 
            this.btnServiceDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceDelete.Location = new System.Drawing.Point(542, 734);
            this.btnServiceDelete.Name = "btnServiceDelete";
            this.btnServiceDelete.Size = new System.Drawing.Size(167, 58);
            this.btnServiceDelete.TabIndex = 18;
            this.btnServiceDelete.Text = "Delete";
            this.btnServiceDelete.UseVisualStyleBackColor = true;
            // 
            // btnServiceDetails
            // 
            this.btnServiceDetails.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceDetails.Location = new System.Drawing.Point(37, 734);
            this.btnServiceDetails.Name = "btnServiceDetails";
            this.btnServiceDetails.Size = new System.Drawing.Size(167, 58);
            this.btnServiceDetails.TabIndex = 17;
            this.btnServiceDetails.Text = "Details";
            this.btnServiceDetails.UseVisualStyleBackColor = true;
            this.btnServiceDetails.Click += new System.EventHandler(this.btnServiceDetails_Click);
            // 
            // panelServiceData
            // 
            this.panelServiceData.AutoScroll = true;
            this.panelServiceData.Controls.Add(this.tlpServiceData);
            this.panelServiceData.Location = new System.Drawing.Point(37, 288);
            this.panelServiceData.Name = "panelServiceData";
            this.panelServiceData.Size = new System.Drawing.Size(1197, 406);
            this.panelServiceData.TabIndex = 16;
            // 
            // tlpServiceData
            // 
            this.tlpServiceData.ColumnCount = 3;
            this.tlpServiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75248F));
            this.tlpServiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.24753F));
            this.tlpServiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 506F));
            this.tlpServiceData.Location = new System.Drawing.Point(22, 3);
            this.tlpServiceData.Name = "tlpServiceData";
            this.tlpServiceData.RowCount = 7;
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57265F));
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.42735F));
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpServiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpServiceData.Size = new System.Drawing.Size(1112, 412);
            this.tlpServiceData.TabIndex = 14;
            // 
            // panelServiceAttribute
            // 
            this.panelServiceAttribute.AutoScroll = true;
            this.panelServiceAttribute.BackColor = System.Drawing.Color.Gainsboro;
            this.panelServiceAttribute.Controls.Add(this.btnServiceSortServiceType);
            this.panelServiceAttribute.Controls.Add(this.btnServiceSortName);
            this.panelServiceAttribute.Controls.Add(this.btnServiceSortID);
            this.panelServiceAttribute.Location = new System.Drawing.Point(37, 233);
            this.panelServiceAttribute.Name = "panelServiceAttribute";
            this.panelServiceAttribute.Size = new System.Drawing.Size(1197, 60);
            this.panelServiceAttribute.TabIndex = 15;
            // 
            // btnServiceSortServiceType
            // 
            this.btnServiceSortServiceType.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceSortServiceType.Location = new System.Drawing.Point(740, 8);
            this.btnServiceSortServiceType.Name = "btnServiceSortServiceType";
            this.btnServiceSortServiceType.Size = new System.Drawing.Size(239, 44);
            this.btnServiceSortServiceType.TabIndex = 21;
            this.btnServiceSortServiceType.Text = "Service Type";
            this.btnServiceSortServiceType.UseVisualStyleBackColor = true;
            this.btnServiceSortServiceType.Click += new System.EventHandler(this.btnServiceSortServiceType_Click);
            // 
            // btnServiceSortName
            // 
            this.btnServiceSortName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceSortName.Location = new System.Drawing.Point(270, 8);
            this.btnServiceSortName.Name = "btnServiceSortName";
            this.btnServiceSortName.Size = new System.Drawing.Size(167, 44);
            this.btnServiceSortName.TabIndex = 21;
            this.btnServiceSortName.Text = "Name";
            this.btnServiceSortName.UseVisualStyleBackColor = true;
            this.btnServiceSortName.Click += new System.EventHandler(this.btnServiceSortName_Click);
            // 
            // btnServiceSortID
            // 
            this.btnServiceSortID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceSortID.Location = new System.Drawing.Point(32, 8);
            this.btnServiceSortID.Name = "btnServiceSortID";
            this.btnServiceSortID.Size = new System.Drawing.Size(120, 44);
            this.btnServiceSortID.TabIndex = 20;
            this.btnServiceSortID.Text = "ID";
            this.btnServiceSortID.UseVisualStyleBackColor = true;
            this.btnServiceSortID.Click += new System.EventHandler(this.btnServiceSortID_Click);
            // 
            // btnServiceSearch
            // 
            this.btnServiceSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceSearch.Location = new System.Drawing.Point(815, 97);
            this.btnServiceSearch.Name = "btnServiceSearch";
            this.btnServiceSearch.Size = new System.Drawing.Size(160, 58);
            this.btnServiceSearch.TabIndex = 8;
            this.btnServiceSearch.Text = "Search";
            this.btnServiceSearch.UseVisualStyleBackColor = true;
            this.btnServiceSearch.Click += new System.EventHandler(this.btnServiceSearch_Click);
            // 
            // txtServiceSearch
            // 
            this.txtServiceSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceSearch.Location = new System.Drawing.Point(259, 26);
            this.txtServiceSearch.Name = "txtServiceSearch";
            this.txtServiceSearch.Size = new System.Drawing.Size(476, 45);
            this.txtServiceSearch.TabIndex = 7;
            this.txtServiceSearch.Text = "Search";
            // 
            // cmbServiceTypeSelection
            // 
            this.cmbServiceTypeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceTypeSelection.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiceTypeSelection.FormattingEnabled = true;
            this.cmbServiceTypeSelection.Items.AddRange(new object[] {
            "All",
            "Basic Maintenance Services",
            "Vehicle Diagnostics",
            "Advanced Repair Services",
            "Tire Services",
            "Car Detailing Services",
            "AC and Heating Services",
            "Performance Enhancements",
            "Safety Checks",
            "Fleet Services",
            "Specialized Services"});
            this.cmbServiceTypeSelection.Location = new System.Drawing.Point(259, 107);
            this.cmbServiceTypeSelection.Name = "cmbServiceTypeSelection";
            this.cmbServiceTypeSelection.Size = new System.Drawing.Size(476, 46);
            this.cmbServiceTypeSelection.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 38);
            this.label7.TabIndex = 2;
            this.label7.Text = "Service Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 38);
            this.label6.TabIndex = 1;
            this.label6.Text = "Service:";
            // 
            // tabFeedback
            // 
            this.tabFeedback.Location = new System.Drawing.Point(84, 4);
            this.tabFeedback.Name = "tabFeedback";
            this.tabFeedback.Size = new System.Drawing.Size(1357, 853);
            this.tabFeedback.TabIndex = 3;
            this.tabFeedback.Text = "Feedback";
            this.tabFeedback.UseVisualStyleBackColor = true;
            // 
            // tabReport
            // 
            this.tabReport.Location = new System.Drawing.Point(84, 4);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(1357, 853);
            this.tabReport.TabIndex = 4;
            this.tabReport.Text = "Report";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // tabProfile
            // 
            this.tabProfile.Location = new System.Drawing.Point(84, 4);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(1357, 853);
            this.tabProfile.TabIndex = 5;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // frmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 861);
            this.Controls.Add(this.tabAdmin);
            this.Name = "frmAdminMain";
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.frmAdminMain_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabStaffAccount.ResumeLayout(false);
            this.tabStaffAccount.PerformLayout();
            this.panelStaffData.ResumeLayout(false);
            this.panelStaffAttribute.ResumeLayout(false);
            this.panelStaffAttribute.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            this.panelServiceData.ResumeLayout(false);
            this.panelServiceAttribute.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabStaffAccount;
        private System.Windows.Forms.Button btnStaffSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbRoleSelection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.TabPage tabFeedback;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.Panel panelStaffAttribute;
        private System.Windows.Forms.Button btnStaffAdd;
        private System.Windows.Forms.Button btnStaffDelete;
        private System.Windows.Forms.Button btnStaffDetail;
        private System.Windows.Forms.Button btnSortStaffName;
        private System.Windows.Forms.Button btnSortStaffID;
        private System.Windows.Forms.TableLayoutPanel tlpStaffData;
        private Panel panelStaffData;
        private Button btnServiceAdd;
        private Button btnServiceDelete;
        private Button btnServiceDetails;
        private Panel panelServiceData;
        private TableLayoutPanel tlpServiceData;
        private Panel panelServiceAttribute;
        private Button btnServiceSearch;
        private TextBox txtServiceSearch;
        private ComboBox cmbServiceTypeSelection;
        private Label label7;
        private Label label6;
        private Button btnServiceSortServiceType;
        private Button btnServiceSortName;
        private Button btnServiceSortID;
        private TabPage tabProfile;
    }
}