

namespace CarCare_Service_Center
{
    partial class Progress
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
            this.btnProgressDone = new System.Windows.Forms.Button();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.cmbPartNameUsed = new System.Windows.Forms.ComboBox();
            this.lblPartNameUsed = new System.Windows.Forms.Label();
            this.btnProgressAdd = new System.Windows.Forms.Button();
            this.lblUsedAmount = new System.Windows.Forms.Label();
            this.cmbPartTypeUsed = new System.Windows.Forms.ComboBox();
            this.lblPartTypeUsed = new System.Windows.Forms.Label();
            this.txtUsedAmount = new System.Windows.Forms.TextBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.tlpProgress = new System.Windows.Forms.TableLayoutPanel();
            this.lblProgressUserID = new System.Windows.Forms.Label();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProgressApointmentId = new System.Windows.Forms.Label();
            this.lblAppointmentId = new System.Windows.Forms.Label();
            this.lblProgressNoPlate = new System.Windows.Forms.Label();
            this.lblProgressCusName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.panelProgress.SuspendLayout();
            this.tlpProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProgressDone
            // 
            this.btnProgressDone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgressDone.Location = new System.Drawing.Point(563, 577);
            this.btnProgressDone.Name = "btnProgressDone";
            this.btnProgressDone.Size = new System.Drawing.Size(135, 59);
            this.btnProgressDone.TabIndex = 0;
            this.btnProgressDone.Text = "Done";
            this.btnProgressDone.UseVisualStyleBackColor = true;
            this.btnProgressDone.Click += new System.EventHandler(this.btnProgressDone_Click);
            // 
            // panelProgress
            // 
            this.panelProgress.AutoScroll = true;
            this.panelProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProgress.Controls.Add(this.cmbPartNameUsed);
            this.panelProgress.Controls.Add(this.lblPartNameUsed);
            this.panelProgress.Controls.Add(this.btnProgressAdd);
            this.panelProgress.Controls.Add(this.lblUsedAmount);
            this.panelProgress.Controls.Add(this.cmbPartTypeUsed);
            this.panelProgress.Controls.Add(this.lblPartTypeUsed);
            this.panelProgress.Controls.Add(this.txtUsedAmount);
            this.panelProgress.Location = new System.Drawing.Point(12, 244);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(1231, 315);
            this.panelProgress.TabIndex = 2;
            // 
            // cmbPartNameUsed
            // 
            this.cmbPartNameUsed.FormattingEnabled = true;
            this.cmbPartNameUsed.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.cmbPartNameUsed.Location = new System.Drawing.Point(610, 16);
            this.cmbPartNameUsed.Name = "cmbPartNameUsed";
            this.cmbPartNameUsed.Size = new System.Drawing.Size(185, 28);
            this.cmbPartNameUsed.TabIndex = 5;
            // 
            // lblPartNameUsed
            // 
            this.lblPartNameUsed.AutoSize = true;
            this.lblPartNameUsed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartNameUsed.Location = new System.Drawing.Point(423, 17);
            this.lblPartNameUsed.Name = "lblPartNameUsed";
            this.lblPartNameUsed.Size = new System.Drawing.Size(181, 27);
            this.lblPartNameUsed.TabIndex = 6;
            this.lblPartNameUsed.Text = "Part Name Used :";
            // 
            // btnProgressAdd
            // 
            this.btnProgressAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgressAdd.Location = new System.Drawing.Point(1124, 14);
            this.btnProgressAdd.Name = "btnProgressAdd";
            this.btnProgressAdd.Size = new System.Drawing.Size(93, 43);
            this.btnProgressAdd.TabIndex = 4;
            this.btnProgressAdd.Text = "Add";
            this.btnProgressAdd.UseVisualStyleBackColor = true;
            this.btnProgressAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUsedAmount
            // 
            this.lblUsedAmount.AutoSize = true;
            this.lblUsedAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedAmount.Location = new System.Drawing.Point(824, 16);
            this.lblUsedAmount.Name = "lblUsedAmount";
            this.lblUsedAmount.Size = new System.Drawing.Size(155, 27);
            this.lblUsedAmount.TabIndex = 3;
            this.lblUsedAmount.Text = "Used Amount :";
            // 
            // cmbPartTypeUsed
            // 
            this.cmbPartTypeUsed.FormattingEnabled = true;
            this.cmbPartTypeUsed.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.cmbPartTypeUsed.Location = new System.Drawing.Point(193, 16);
            this.cmbPartTypeUsed.Name = "cmbPartTypeUsed";
            this.cmbPartTypeUsed.Size = new System.Drawing.Size(185, 28);
            this.cmbPartTypeUsed.TabIndex = 0;
            // 
            // lblPartTypeUsed
            // 
            this.lblPartTypeUsed.AutoSize = true;
            this.lblPartTypeUsed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartTypeUsed.Location = new System.Drawing.Point(15, 14);
            this.lblPartTypeUsed.Name = "lblPartTypeUsed";
            this.lblPartTypeUsed.Size = new System.Drawing.Size(171, 27);
            this.lblPartTypeUsed.TabIndex = 2;
            this.lblPartTypeUsed.Text = "Part Type Used :";
            // 
            // txtUsedAmount
            // 
            this.txtUsedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsedAmount.Location = new System.Drawing.Point(985, 17);
            this.txtUsedAmount.Multiline = true;
            this.txtUsedAmount.Name = "txtUsedAmount";
            this.txtUsedAmount.Size = new System.Drawing.Size(101, 25);
            this.txtUsedAmount.TabIndex = 1;
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(8, 9);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(1235, 223);
            this.lblProgress.TabIndex = 3;
            // 
            // tlpProgress
            // 
            this.tlpProgress.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpProgress.ColumnCount = 4;
            this.tlpProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpProgress.Controls.Add(this.lblProgressUserID, 2, 0);
            this.tlpProgress.Controls.Add(this.lblProgressApointmentId, 0, 0);
            this.tlpProgress.Controls.Add(this.lblAppointmentId, 1, 0);
            this.tlpProgress.Controls.Add(this.lblProgressNoPlate, 2, 1);
            this.tlpProgress.Controls.Add(this.lblProgressCusName, 0, 1);
            this.tlpProgress.Controls.Add(this.lblName, 1, 1);
            this.tlpProgress.Controls.Add(this.lblUserID, 3, 0);
            this.tlpProgress.Controls.Add(this.lblPlateNumber, 3, 1);
            this.tlpProgress.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpProgress.Location = new System.Drawing.Point(12, 12);
            this.tlpProgress.Name = "tlpProgress";
            this.tlpProgress.RowCount = 2;
            this.tlpProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProgress.Size = new System.Drawing.Size(1231, 220);
            this.tlpProgress.TabIndex = 15;
            // 
            // lblProgressUserID
            // 
            this.lblProgressUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgressUserID.Location = new System.Drawing.Point(619, 2);
            this.lblProgressUserID.Name = "lblProgressUserID";
            this.lblProgressUserID.Size = new System.Drawing.Size(238, 107);
            this.lblProgressUserID.TabIndex = 12;
            this.lblProgressUserID.Text = "USER ID";
            this.lblProgressUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlateNumber.Location = new System.Drawing.Point(865, 111);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(361, 107);
            this.lblPlateNumber.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(251, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(360, 107);
            this.lblName.TabIndex = 10;
            // 
            // lblProgressApointmentId
            // 
            this.lblProgressApointmentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgressApointmentId.Location = new System.Drawing.Point(5, 2);
            this.lblProgressApointmentId.Name = "lblProgressApointmentId";
            this.lblProgressApointmentId.Size = new System.Drawing.Size(238, 107);
            this.lblProgressApointmentId.TabIndex = 8;
            this.lblProgressApointmentId.Text = "APPOINTMENT ID";
            this.lblProgressApointmentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppointmentId
            // 
            this.lblAppointmentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppointmentId.Location = new System.Drawing.Point(251, 2);
            this.lblAppointmentId.Name = "lblAppointmentId";
            this.lblAppointmentId.Size = new System.Drawing.Size(360, 107);
            this.lblAppointmentId.TabIndex = 9;
            // 
            // lblProgressNoPlate
            // 
            this.lblProgressNoPlate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgressNoPlate.Location = new System.Drawing.Point(619, 111);
            this.lblProgressNoPlate.Name = "lblProgressNoPlate";
            this.lblProgressNoPlate.Size = new System.Drawing.Size(238, 107);
            this.lblProgressNoPlate.TabIndex = 6;
            this.lblProgressNoPlate.Text = "PLATE NUMBER";
            this.lblProgressNoPlate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProgressCusName
            // 
            this.lblProgressCusName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgressCusName.Location = new System.Drawing.Point(5, 111);
            this.lblProgressCusName.Name = "lblProgressCusName";
            this.lblProgressCusName.Size = new System.Drawing.Size(238, 107);
            this.lblProgressCusName.TabIndex = 4;
            this.lblProgressCusName.Text = "NAME";
            this.lblProgressCusName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserID
            // 
            this.lblUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserID.Location = new System.Drawing.Point(865, 2);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(361, 107);
            this.lblUserID.TabIndex = 13;
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 648);
            this.Controls.Add(this.tlpProgress);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.btnProgressDone);
            this.Name = "Progress";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            this.tlpProgress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProgressDone;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Button btnProgressAdd;
        private System.Windows.Forms.Label lblUsedAmount;
        private System.Windows.Forms.Label lblPartTypeUsed;
        private System.Windows.Forms.TextBox txtUsedAmount;
        private System.Windows.Forms.ComboBox cmbPartTypeUsed;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ComboBox cmbPartNameUsed;
        private System.Windows.Forms.Label lblPartNameUsed;
        private System.Windows.Forms.TableLayoutPanel tlpProgress;
        private System.Windows.Forms.Label lblProgressUserID;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProgressApointmentId;
        private System.Windows.Forms.Label lblAppointmentId;
        private System.Windows.Forms.Label lblProgressNoPlate;
        private System.Windows.Forms.Label lblProgressCusName;
        private System.Windows.Forms.Label lblUserID;
    }
}
