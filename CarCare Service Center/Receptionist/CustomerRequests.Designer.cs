
namespace CarCare_Service_Center
{
    partial class CustomerRequests
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
            this.tblCustomerRequests = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDenyRequest = new System.Windows.Forms.Button();
            this.btnConfirmRequest = new System.Windows.Forms.Button();
            this.tblCustomerRequests.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCustomerRequests
            // 
            this.tblCustomerRequests.AutoSize = true;
            this.tblCustomerRequests.BackColor = System.Drawing.Color.Gainsboro;
            this.tblCustomerRequests.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblCustomerRequests.ColumnCount = 4;
            this.tblCustomerRequests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblCustomerRequests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblCustomerRequests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCustomerRequests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblCustomerRequests.Controls.Add(this.label2, 1, 0);
            this.tblCustomerRequests.Controls.Add(this.label3, 2, 0);
            this.tblCustomerRequests.Controls.Add(this.label4, 3, 0);
            this.tblCustomerRequests.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblCustomerRequests.Location = new System.Drawing.Point(29, 81);
            this.tblCustomerRequests.Name = "tblCustomerRequests";
            this.tblCustomerRequests.RowCount = 1;
            this.tblCustomerRequests.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblCustomerRequests.Size = new System.Drawing.Size(738, 70);
            this.tblCustomerRequests.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 64);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 64);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Requests";
            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDenyRequest.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDenyRequest.Location = new System.Drawing.Point(0, 420);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(836, 36);
            this.btnDenyRequest.TabIndex = 2;
            this.btnDenyRequest.Text = "Deny Request";
            this.btnDenyRequest.UseVisualStyleBackColor = true;
            this.btnDenyRequest.Click += new System.EventHandler(this.btnDenyRequest_Click);
            // 
            // btnConfirmRequest
            // 
            this.btnConfirmRequest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfirmRequest.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmRequest.Location = new System.Drawing.Point(0, 384);
            this.btnConfirmRequest.Name = "btnConfirmRequest";
            this.btnConfirmRequest.Size = new System.Drawing.Size(836, 36);
            this.btnConfirmRequest.TabIndex = 3;
            this.btnConfirmRequest.Text = "ConfirmRequest";
            this.btnConfirmRequest.UseVisualStyleBackColor = true;
            this.btnConfirmRequest.Click += new System.EventHandler(this.btnConfirmRequest_Click);
            // 
            // CustomerRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(836, 456);
            this.Controls.Add(this.btnConfirmRequest);
            this.Controls.Add(this.btnDenyRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblCustomerRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerRequests";
            this.Text = "Customer Requests";
            this.Load += new System.EventHandler(this.tblCustomerRequests_Load);
            this.tblCustomerRequests.ResumeLayout(false);
            this.tblCustomerRequests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblCustomerRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDenyRequest;
        private System.Windows.Forms.Button btnConfirmRequest;
    }
}
