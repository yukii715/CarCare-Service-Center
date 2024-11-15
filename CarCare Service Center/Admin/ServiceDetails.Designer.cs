
using System.Drawing;
using System.Windows.Forms;
namespace CarCare_Service_Center
{
    partial class ServiceDetails
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
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBriefing = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpPrice = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBriefing = new System.Windows.Forms.Panel();
            this.picService = new System.Windows.Forms.PictureBox();
            this.lblBriefDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlBriefing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picService)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(24, 129);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(209, 38);
            this.lblServiceType.TabIndex = 3;
            this.lblServiceType.Text = "Service Type: -";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(24, 226);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(220, 38);
            this.lblServiceName.TabIndex = 4;
            this.lblServiceName.Text = "Service Name: -";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(24, 323);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(88, 38);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(24, 431);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(242, 38);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Estimated Time: -";
            // 
            // lblBriefing
            // 
            this.lblBriefing.AutoSize = true;
            this.lblBriefing.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBriefing.Location = new System.Drawing.Point(24, 641);
            this.lblBriefing.Name = "lblBriefing";
            this.lblBriefing.Size = new System.Drawing.Size(118, 38);
            this.lblBriefing.TabIndex = 7;
            this.lblBriefing.Text = "Briefing";
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceID.Location = new System.Drawing.Point(24, 36);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(182, 38);
            this.lblServiceID.TabIndex = 8;
            this.lblServiceID.Text = "Service ID: -";
            // 
            // lblDescriptionTitle
            // 
            this.lblDescriptionTitle.AutoSize = true;
            this.lblDescriptionTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionTitle.Location = new System.Drawing.Point(24, 521);
            this.lblDescriptionTitle.Name = "lblDescriptionTitle";
            this.lblDescriptionTitle.Size = new System.Drawing.Size(168, 38);
            this.lblDescriptionTitle.TabIndex = 13;
            this.lblDescriptionTitle.Text = "Description:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(24, 576);
            this.lblDescription.MaximumSize = new System.Drawing.Size(1016, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(28, 38);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "-";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(30, 775);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 71);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(431, 775);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 71);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(839, 775);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 71);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tlpPrice);
            this.panel1.Controls.Add(this.pnlBriefing);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblDescriptionTitle);
            this.panel1.Controls.Add(this.lblServiceID);
            this.panel1.Controls.Add(this.lblBriefing);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblServiceName);
            this.panel1.Controls.Add(this.lblServiceType);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 715);
            this.panel1.TabIndex = 0;
            // 
            // tlpPrice
            // 
            this.tlpPrice.AutoSize = true;
            this.tlpPrice.ColumnCount = 3;
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.38284F));
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.61716F));
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 376F));
            this.tlpPrice.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpPrice.Location = new System.Drawing.Point(139, 323);
            this.tlpPrice.Name = "tlpPrice";
            this.tlpPrice.RowCount = 1;
            this.tlpPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrice.Size = new System.Drawing.Size(651, 50);
            this.tlpPrice.TabIndex = 16;
            // 
            // pnlBriefing
            // 
            this.pnlBriefing.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBriefing.Controls.Add(this.picService);
            this.pnlBriefing.Controls.Add(this.lblBriefDescription);
            this.pnlBriefing.Controls.Add(this.lblTitle);
            this.pnlBriefing.Location = new System.Drawing.Point(31, 709);
            this.pnlBriefing.Name = "pnlBriefing";
            this.pnlBriefing.Size = new System.Drawing.Size(1029, 406);
            this.pnlBriefing.TabIndex = 15;
            // 
            // picService
            // 
            this.picService.BackColor = System.Drawing.Color.Transparent;
            this.picService.Location = new System.Drawing.Point(613, 77);
            this.picService.Name = "picService";
            this.picService.Size = new System.Drawing.Size(359, 265);
            this.picService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picService.TabIndex = 17;
            this.picService.TabStop = false;
            // 
            // lblBriefDescription
            // 
            this.lblBriefDescription.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBriefDescription.Location = new System.Drawing.Point(3, 77);
            this.lblBriefDescription.MaximumSize = new System.Drawing.Size(580, 285);
            this.lblBriefDescription.Name = "lblBriefDescription";
            this.lblBriefDescription.Size = new System.Drawing.Size(580, 285);
            this.lblBriefDescription.TabIndex = 16;
            this.lblBriefDescription.Text = "----------------";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 52);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "---------";
            // 
            // ServiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 931);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Name = "ServiceDetails";
            this.Text = "CarCare Service Centre - Service Details";
            this.Load += new System.EventHandler(this.ServiceDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBriefing.ResumeLayout(false);
            this.pnlBriefing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBriefing;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.Label lblDescriptionTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBriefing;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpPrice;
        private System.Windows.Forms.Label lblBriefDescription;
        private System.Windows.Forms.PictureBox picService;
    }
}
