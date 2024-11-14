using System.Drawing;

namespace CarCare_Service_Center
{
    partial class ServiceInsertion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceInsertion));
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewType = new System.Windows.Forms.Button();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTimeMins = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.tlpPrice = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddPrice = new System.Windows.Forms.Button();
            this.txtPriceDescription = new System.Windows.Forms.TextBox();
            this.txtPriceAmount = new System.Windows.Forms.TextBox();
            this.lblPriceCurrency = new System.Windows.Forms.Label();
            this.pnlBriefing = new System.Windows.Forms.Panel();
            this.txtBriefing = new System.Windows.Forms.TextBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.picService = new System.Windows.Forms.PictureBox();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
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
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(637, 572);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 51);
            this.btnCreate.TabIndex = 26;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnNewType);
            this.panel1.Controls.Add(this.cmbServiceType);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.lblTimeMins);
            this.panel1.Controls.Add(this.txtServiceName);
            this.panel1.Controls.Add(this.tlpPrice);
            this.panel1.Controls.Add(this.pnlBriefing);
            this.panel1.Controls.Add(this.lblDescriptionTitle);
            this.panel1.Controls.Add(this.lblBriefing);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblServiceName);
            this.panel1.Controls.Add(this.lblServiceType);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 504);
            this.panel1.TabIndex = 24;
            // 
            // btnNewType
            // 
            this.btnNewType.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewType.Location = new System.Drawing.Point(604, 20);
            this.btnNewType.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewType.Name = "btnNewType";
            this.btnNewType.Size = new System.Drawing.Size(119, 36);
            this.btnNewType.TabIndex = 27;
            this.btnNewType.Text = "New";
            this.btnNewType.UseVisualStyleBackColor = true;
            this.btnNewType.Click += new System.EventHandler(this.btnNewType_Click);
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceType.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Location = new System.Drawing.Point(197, 20);
            this.cmbServiceType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(391, 36);
            this.cmbServiceType.TabIndex = 40;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(22, 460);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(730, 230);
            this.txtDescription.TabIndex = 20;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(202, 348);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(92, 36);
            this.txtTime.TabIndex = 19;
            this.txtTime.Text = "\r\n";
            // 
            // lblTimeMins
            // 
            this.lblTimeMins.AutoSize = true;
            this.lblTimeMins.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeMins.Location = new System.Drawing.Point(306, 350);
            this.lblTimeMins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeMins.Name = "lblTimeMins";
            this.lblTimeMins.Size = new System.Drawing.Size(59, 29);
            this.lblTimeMins.TabIndex = 18;
            this.lblTimeMins.Text = "Mins";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.Location = new System.Drawing.Point(197, 90);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(391, 36);
            this.txtServiceName.TabIndex = 17;
            this.txtServiceName.Text = "\r\n";
            // 
            // tlpPrice
            // 
            this.tlpPrice.AutoSize = true;
            this.tlpPrice.ColumnCount = 4;
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.67327F));
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.32674F));
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tlpPrice.Controls.Add(this.btnAddPrice, 0, 1);
            this.tlpPrice.Controls.Add(this.txtPriceDescription, 2, 0);
            this.tlpPrice.Controls.Add(this.txtPriceAmount, 1, 0);
            this.tlpPrice.Controls.Add(this.lblPriceCurrency, 0, 0);
            this.tlpPrice.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpPrice.Location = new System.Drawing.Point(151, 173);
            this.tlpPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tlpPrice.Name = "tlpPrice";
            this.tlpPrice.RowCount = 2;
            this.tlpPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpPrice.Size = new System.Drawing.Size(672, 90);
            this.tlpPrice.TabIndex = 16;
            // 
            // btnAddPrice
            // 
            this.btnAddPrice.AutoSize = true;
            this.btnAddPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPrice.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrice.Location = new System.Drawing.Point(2, 47);
            this.btnAddPrice.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPrice.Name = "btnAddPrice";
            this.btnAddPrice.Size = new System.Drawing.Size(89, 41);
            this.btnAddPrice.TabIndex = 29;
            this.btnAddPrice.Text = "Add";
            this.btnAddPrice.UseVisualStyleBackColor = true;
            this.btnAddPrice.Click += new System.EventHandler(this.btnAddPrice_Click);
            // 
            // txtPriceDescription
            // 
            this.txtPriceDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPriceDescription.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceDescription.Location = new System.Drawing.Point(288, 2);
            this.txtPriceDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceDescription.Name = "txtPriceDescription";
            this.txtPriceDescription.Size = new System.Drawing.Size(214, 36);
            this.txtPriceDescription.TabIndex = 25;
            // 
            // txtPriceAmount
            // 
            this.txtPriceAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPriceAmount.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAmount.Location = new System.Drawing.Point(95, 2);
            this.txtPriceAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceAmount.Name = "txtPriceAmount";
            this.txtPriceAmount.Size = new System.Drawing.Size(189, 36);
            this.txtPriceAmount.TabIndex = 23;
            this.txtPriceAmount.TabStop = false;
            // 
            // lblPriceCurrency
            // 
            this.lblPriceCurrency.AutoSize = true;
            this.lblPriceCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriceCurrency.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceCurrency.Location = new System.Drawing.Point(2, 0);
            this.lblPriceCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceCurrency.Name = "lblPriceCurrency";
            this.lblPriceCurrency.Size = new System.Drawing.Size(89, 45);
            this.lblPriceCurrency.TabIndex = 17;
            this.lblPriceCurrency.Text = "RM";
            this.lblPriceCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBriefing
            // 
            this.pnlBriefing.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBriefing.Controls.Add(this.txtBriefing);
            this.pnlBriefing.Controls.Add(this.btnImage);
            this.pnlBriefing.Controls.Add(this.picService);
            this.pnlBriefing.Location = new System.Drawing.Point(23, 776);
            this.pnlBriefing.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBriefing.Name = "pnlBriefing";
            this.pnlBriefing.Size = new System.Drawing.Size(772, 292);
            this.pnlBriefing.TabIndex = 15;
            // 
            // txtBriefing
            // 
            this.txtBriefing.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBriefing.Location = new System.Drawing.Point(26, 39);
            this.txtBriefing.Margin = new System.Windows.Forms.Padding(2);
            this.txtBriefing.Multiline = true;
            this.txtBriefing.Name = "txtBriefing";
            this.txtBriefing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBriefing.Size = new System.Drawing.Size(391, 175);
            this.txtBriefing.TabIndex = 21;
            this.txtBriefing.TabStop = false;
            this.txtBriefing.Text = "\r\n";
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(532, 237);
            this.btnImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(152, 37);
            this.btnImage.TabIndex = 24;
            this.btnImage.TabStop = false;
            this.btnImage.Text = "Upload";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // picService
            // 
            this.picService.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picService.Image = ((System.Drawing.Image)(resources.GetObject("picService.Image")));
            this.picService.Location = new System.Drawing.Point(460, 22);
            this.picService.Margin = new System.Windows.Forms.Padding(2);
            this.picService.Name = "picService";
            this.picService.Size = new System.Drawing.Size(269, 191);
            this.picService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picService.TabIndex = 18;
            this.picService.TabStop = false;
            // 
            // lblDescriptionTitle
            // 
            this.lblDescriptionTitle.AutoSize = true;
            this.lblDescriptionTitle.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionTitle.Location = new System.Drawing.Point(16, 415);
            this.lblDescriptionTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescriptionTitle.Name = "lblDescriptionTitle";
            this.lblDescriptionTitle.Size = new System.Drawing.Size(131, 29);
            this.lblDescriptionTitle.TabIndex = 13;
            this.lblDescriptionTitle.Text = "Description:";
            // 
            // lblBriefing
            // 
            this.lblBriefing.AutoSize = true;
            this.lblBriefing.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBriefing.Location = new System.Drawing.Point(17, 728);
            this.lblBriefing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBriefing.Name = "lblBriefing";
            this.lblBriefing.Size = new System.Drawing.Size(92, 29);
            this.lblBriefing.TabIndex = 7;
            this.lblBriefing.Text = "Briefing";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(16, 350);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(178, 29);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Estimated Time: ";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(16, 173);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(131, 67);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price and Description:";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(16, 92);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(160, 29);
            this.lblServiceName.TabIndex = 4;
            this.lblServiceName.Text = "Service Name: ";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(16, 23);
            this.lblServiceType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(152, 29);
            this.lblServiceType.TabIndex = 3;
            this.lblServiceType.Text = "Service Type: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(97, 572);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 51);
            this.btnCancel.TabIndex = 25;
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
            // ServiceInsertion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 658);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServiceInsertion";
            this.Text = "CarCare Service Centre - Add Service Details";
            this.Load += new System.EventHandler(this.ServiceInsertion_Load);
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

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTimeMins;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TableLayoutPanel tlpPrice;
        private System.Windows.Forms.TextBox txtPriceDescription;
        private System.Windows.Forms.TextBox txtPriceAmount;
        private System.Windows.Forms.Label lblPriceCurrency;
        private System.Windows.Forms.Panel pnlBriefing;
        private System.Windows.Forms.TextBox txtBriefing;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox picService;
        private System.Windows.Forms.Label lblDescriptionTitle;
        private System.Windows.Forms.Label lblBriefing;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddPrice;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.Button btnNewType;
        private System.Windows.Forms.OpenFileDialog fileImage;
    }
}