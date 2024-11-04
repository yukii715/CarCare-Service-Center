namespace CarCare_Service_Center
{
    partial class frmReceptionistMain
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
            this.tabReceptionist = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.ManageAccounts = new System.Windows.Forms.TabPage();
            this.tblCustomerAccounts = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Appointments = new System.Windows.Forms.TabPage();
            this.PartsInventory = new System.Windows.Forms.TabPage();
            this.Profile = new System.Windows.Forms.TabPage();
            this.tabReceptionist.SuspendLayout();
            this.Home.SuspendLayout();
            this.ManageAccounts.SuspendLayout();
            this.tblCustomerAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabReceptionist
            // 
            this.tabReceptionist.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabReceptionist.Controls.Add(this.Home);
            this.tabReceptionist.Controls.Add(this.ManageAccounts);
            this.tabReceptionist.Controls.Add(this.Appointments);
            this.tabReceptionist.Controls.Add(this.PartsInventory);
            this.tabReceptionist.Controls.Add(this.Profile);
            this.tabReceptionist.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabReceptionist.ItemSize = new System.Drawing.Size(50, 80);
            this.tabReceptionist.Location = new System.Drawing.Point(0, 0);
            this.tabReceptionist.Multiline = true;
            this.tabReceptionist.Name = "tabReceptionist";
            this.tabReceptionist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabReceptionist.SelectedIndex = 0;
            this.tabReceptionist.Size = new System.Drawing.Size(1051, 665);
            this.tabReceptionist.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabReceptionist.TabIndex = 0;
            this.tabReceptionist.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabReceptionist_DrawItem);
            // 
            // Home
            // 
            this.Home.Controls.Add(this.lblDate);
            this.Home.Controls.Add(this.label6);
            this.Home.Controls.Add(this.lblWelcome);
            this.Home.Location = new System.Drawing.Point(84, 4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(963, 657);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(63, 138);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "____";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(861, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "_________________________________________________________________________________" +
    "_________________________________________\r\n";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(963, 147);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome,";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageAccounts
            // 
            this.ManageAccounts.Controls.Add(this.tblCustomerAccounts);
            this.ManageAccounts.Controls.Add(this.comboBox1);
            this.ManageAccounts.Controls.Add(this.label2);
            this.ManageAccounts.Controls.Add(this.txtSearch);
            this.ManageAccounts.Controls.Add(this.btnEdit);
            this.ManageAccounts.Controls.Add(this.btnRequests);
            this.ManageAccounts.Controls.Add(this.label1);
            this.ManageAccounts.Location = new System.Drawing.Point(84, 4);
            this.ManageAccounts.Name = "ManageAccounts";
            this.ManageAccounts.Size = new System.Drawing.Size(963, 657);
            this.ManageAccounts.TabIndex = 1;
            this.ManageAccounts.Text = "Manage Accounts";
            this.ManageAccounts.UseVisualStyleBackColor = true;
            // 
            // tblCustomerAccounts
            // 
            this.tblCustomerAccounts.AutoSize = true;
            this.tblCustomerAccounts.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblCustomerAccounts.ColumnCount = 3;
            this.tblCustomerAccounts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblCustomerAccounts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCustomerAccounts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblCustomerAccounts.Controls.Add(this.label3, 0, 0);
            this.tblCustomerAccounts.Controls.Add(this.label4, 1, 0);
            this.tblCustomerAccounts.Controls.Add(this.label5, 2, 0);
            this.tblCustomerAccounts.Location = new System.Drawing.Point(44, 244);
            this.tblCustomerAccounts.Name = "tblCustomerAccounts";
            this.tblCustomerAccounts.RowCount = 2;
            this.tblCustomerAccounts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblCustomerAccounts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblCustomerAccounts.Size = new System.Drawing.Size(858, 91);
            this.tblCustomerAccounts.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 50);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(604, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 50);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Email"});
            this.comboBox1.Location = new System.Drawing.Point(748, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Select";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(651, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sort By:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearch.Location = new System.Drawing.Point(99, 175);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(442, 33);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Search";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(566, 111);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(197, 37);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRequests
            // 
            this.btnRequests.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequests.Location = new System.Drawing.Point(188, 111);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(197, 37);
            this.btnRequests.TabIndex = 1;
            this.btnRequests.Text = "Requests";
            this.btnRequests.UseVisualStyleBackColor = true;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Account Manager";
            // 
            // Appointments
            // 
            this.Appointments.Location = new System.Drawing.Point(84, 4);
            this.Appointments.Name = "Appointments";
            this.Appointments.Size = new System.Drawing.Size(963, 657);
            this.Appointments.TabIndex = 2;
            this.Appointments.Text = "Appointments";
            this.Appointments.UseVisualStyleBackColor = true;
            // 
            // PartsInventory
            // 
            this.PartsInventory.Location = new System.Drawing.Point(84, 4);
            this.PartsInventory.Name = "PartsInventory";
            this.PartsInventory.Size = new System.Drawing.Size(963, 657);
            this.PartsInventory.TabIndex = 3;
            this.PartsInventory.Text = "Parts Inventory";
            this.PartsInventory.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.Profile.Location = new System.Drawing.Point(84, 4);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(963, 657);
            this.Profile.TabIndex = 4;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // frmReceptionistMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 661);
            this.Controls.Add(this.tabReceptionist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReceptionistMain";
            this.Text = "CarCare Service Center";
            this.Load += new System.EventHandler(this.frmReceptionistMain_Load);
            this.tabReceptionist.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.ManageAccounts.ResumeLayout(false);
            this.ManageAccounts.PerformLayout();
            this.tblCustomerAccounts.ResumeLayout(false);
            this.tblCustomerAccounts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReceptionist;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage ManageAccounts;
        private System.Windows.Forms.TabPage Appointments;
        private System.Windows.Forms.TabPage PartsInventory;
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.TableLayoutPanel tblCustomerAccounts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDate;
    }
}