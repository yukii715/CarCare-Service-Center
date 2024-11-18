
namespace CarCare_Service_Center
{
    partial class ServiceEdit
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
            this.btnApply = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpPrice = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddPrice = new System.Windows.Forms.Button();
            this.pnlBriefing = new System.Windows.Forms.Panel();
            this.btnImage = new System.Windows.Forms.Button();
            this.txtBriefDescription = new System.Windows.Forms.TextBox();
            this.picService = new System.Windows.Forms.PictureBox();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.lblBriefing = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fileImage = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tlpPrice.SuspendLayout();
            this.pnlBriefing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picService)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(847, 775);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(200, 71);
            this.btnApply.TabIndex = 23;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tlpPrice);
            this.panel1.Controls.Add(this.pnlBriefing);
            this.panel1.Controls.Add(this.lblDescriptionTitle);
            this.panel1.Controls.Add(this.lblServiceID);
            this.panel1.Controls.Add(this.lblBriefing);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblServiceName);
            this.panel1.Controls.Add(this.lblServiceType);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(7, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 715);
            this.panel1.TabIndex = 20;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(31, 578);
            this.txtDescription.MaximumSize = new System.Drawing.Size(1029, 292);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(1029, 292);
            this.txtDescription.TabIndex = 19;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(293, 428);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 45);
            this.txtTime.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mins";
            // 
            // tlpPrice
            // 
            this.tlpPrice.AutoSize = true;
            this.tlpPrice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpPrice.ColumnCount = 4;
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.07821F));
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.92179F));
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tlpPrice.Controls.Add(this.btnAddPrice, 0, 0);
            this.tlpPrice.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpPrice.Location = new System.Drawing.Point(139, 323);
            this.tlpPrice.Name = "tlpPrice";
            this.tlpPrice.RowCount = 1;
            this.tlpPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpPrice.Size = new System.Drawing.Size(768, 62);
            this.tlpPrice.TabIndex = 16;
            // 
            // btnAddPrice
            // 
            this.btnAddPrice.AutoSize = true;
            this.btnAddPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPrice.Location = new System.Drawing.Point(3, 3);
            this.btnAddPrice.Name = "btnAddPrice";
            this.btnAddPrice.Size = new System.Drawing.Size(108, 56);
            this.btnAddPrice.TabIndex = 0;
            this.btnAddPrice.Text = "Add";
            this.btnAddPrice.UseVisualStyleBackColor = true;
            this.btnAddPrice.Click += new System.EventHandler(this.btnAddPrice_Click);
            // 
            // pnlBriefing
            // 
            this.pnlBriefing.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBriefing.Controls.Add(this.btnImage);
            this.pnlBriefing.Controls.Add(this.txtBriefDescription);
            this.pnlBriefing.Controls.Add(this.picService);
            this.pnlBriefing.Location = new System.Drawing.Point(31, 1005);
            this.pnlBriefing.Name = "pnlBriefing";
            this.pnlBriefing.Size = new System.Drawing.Size(1029, 406);
            this.pnlBriefing.TabIndex = 15;
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(708, 328);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(200, 54);
            this.btnImage.TabIndex = 24;
            this.btnImage.Text = "Upload";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // txtBriefDescription
            // 
            this.txtBriefDescription.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBriefDescription.Location = new System.Drawing.Point(25, 77);
            this.txtBriefDescription.MaximumSize = new System.Drawing.Size(547, 265);
            this.txtBriefDescription.Multiline = true;
            this.txtBriefDescription.Name = "txtBriefDescription";
            this.txtBriefDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBriefDescription.Size = new System.Drawing.Size(547, 265);
            this.txtBriefDescription.TabIndex = 20;
            // 
            // picService
            // 
            this.picService.BackColor = System.Drawing.Color.Transparent;
            this.picService.Location = new System.Drawing.Point(627, 38);
            this.picService.Name = "picService";
            this.picService.Size = new System.Drawing.Size(359, 265);
            this.picService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picService.TabIndex = 17;
            this.picService.TabStop = false;
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
            // lblBriefing
            // 
            this.lblBriefing.AutoSize = true;
            this.lblBriefing.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBriefing.Location = new System.Drawing.Point(24, 937);
            this.lblBriefing.Name = "lblBriefing";
            this.lblBriefing.Size = new System.Drawing.Size(118, 38);
            this.lblBriefing.TabIndex = 7;
            this.lblBriefing.Text = "Briefing";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(24, 431);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(223, 38);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Estimated Time:";
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
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(38, 775);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 71);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fileImage
            // 
            this.fileImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
            this.fileImage.InitialDirectory = "C:\\\\";
            this.fileImage.Title = "Select an Image";
            // 
            // ServiceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 931);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Name = "ServiceEdit";
            this.Text = "CarCare Service Centre - Service Edit";
            this.Load += new System.EventHandler(this.ServiceEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlpPrice.ResumeLayout(false);
            this.tlpPrice.PerformLayout();
            this.pnlBriefing.ResumeLayout(false);
            this.pnlBriefing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpPrice;
        private System.Windows.Forms.Panel pnlBriefing;
        private System.Windows.Forms.PictureBox picService;
        private System.Windows.Forms.Label lblDescriptionTitle;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.Label lblBriefing;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtBriefDescription;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.OpenFileDialog fileImage;
    }
}
