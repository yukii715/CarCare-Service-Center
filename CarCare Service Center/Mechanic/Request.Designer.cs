
namespace CarCare_Service_Center
{
    partial class Request
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
            this.lblInventoryRequest = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnRequestRequest = new System.Windows.Forms.Button();
            this.btnRequestBack = new System.Windows.Forms.Button();
            this.cmbPartType = new System.Windows.Forms.ComboBox();
            this.lblRequestPartType = new System.Windows.Forms.Label();
            this.lblRequestPartName = new System.Windows.Forms.Label();
            this.lblRequestDescription = new System.Windows.Forms.Label();
            this.txtboxPartName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInventoryRequest
            // 
            this.lblInventoryRequest.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryRequest.Location = new System.Drawing.Point(-20, 0);
            this.lblInventoryRequest.Name = "lblInventoryRequest";
            this.lblInventoryRequest.Size = new System.Drawing.Size(795, 85);
            this.lblInventoryRequest.TabIndex = 3;
            this.lblInventoryRequest.Text = "Inventory Request";
            this.lblInventoryRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(79, 293);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(554, 261);
            this.txtDescription.TabIndex = 7;
            // 
            // btnRequestRequest
            // 
            this.btnRequestRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRequestRequest.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestRequest.Location = new System.Drawing.Point(407, 571);
            this.btnRequestRequest.Name = "btnRequestRequest";
            this.btnRequestRequest.Size = new System.Drawing.Size(144, 53);
            this.btnRequestRequest.TabIndex = 9;
            this.btnRequestRequest.Text = "Request";
            this.btnRequestRequest.UseVisualStyleBackColor = true;
            this.btnRequestRequest.Click += new System.EventHandler(this.btnRequestRequest_Click);
            // 
            // btnRequestBack
            // 
            this.btnRequestBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRequestBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestBack.Location = new System.Drawing.Point(167, 571);
            this.btnRequestBack.Name = "btnRequestBack";
            this.btnRequestBack.Size = new System.Drawing.Size(143, 53);
            this.btnRequestBack.TabIndex = 10;
            this.btnRequestBack.Text = "Back";
            this.btnRequestBack.UseVisualStyleBackColor = true;
            this.btnRequestBack.Click += new System.EventHandler(this.btnRequestBack_Click);
            // 
            // cmbPartType
            // 
            this.cmbPartType.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPartType.FormattingEnabled = true;
            this.cmbPartType.Items.AddRange(new object[] {
            "New"});
            this.cmbPartType.Location = new System.Drawing.Point(271, 115);
            this.cmbPartType.Name = "cmbPartType";
            this.cmbPartType.Size = new System.Drawing.Size(296, 41);
            this.cmbPartType.TabIndex = 11;
            // 
            // lblRequestPartType
            // 
            this.lblRequestPartType.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestPartType.Location = new System.Drawing.Point(73, 115);
            this.lblRequestPartType.Name = "lblRequestPartType";
            this.lblRequestPartType.Size = new System.Drawing.Size(181, 38);
            this.lblRequestPartType.TabIndex = 13;
            this.lblRequestPartType.Text = "Part Type :";
            // 
            // lblRequestPartName
            // 
            this.lblRequestPartName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestPartName.Location = new System.Drawing.Point(73, 184);
            this.lblRequestPartName.Name = "lblRequestPartName";
            this.lblRequestPartName.Size = new System.Drawing.Size(168, 38);
            this.lblRequestPartName.TabIndex = 14;
            this.lblRequestPartName.Text = "Part Name : ";
            // 
            // lblRequestDescription
            // 
            this.lblRequestDescription.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestDescription.Location = new System.Drawing.Point(73, 252);
            this.lblRequestDescription.Name = "lblRequestDescription";
            this.lblRequestDescription.Size = new System.Drawing.Size(224, 38);
            this.lblRequestDescription.TabIndex = 15;
            this.lblRequestDescription.Text = "Description";
            // 
            // txtboxPartName
            // 
            this.txtboxPartName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxPartName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPartName.Location = new System.Drawing.Point(271, 184);
            this.txtboxPartName.Name = "txtboxPartName";
            this.txtboxPartName.Size = new System.Drawing.Size(296, 40);
            this.txtboxPartName.TabIndex = 16;
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(724, 661);
            this.Controls.Add(this.txtboxPartName);
            this.Controls.Add(this.lblRequestDescription);
            this.Controls.Add(this.lblRequestPartName);
            this.Controls.Add(this.lblRequestPartType);
            this.Controls.Add(this.cmbPartType);
            this.Controls.Add(this.btnRequestBack);
            this.Controls.Add(this.btnRequestRequest);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblInventoryRequest);
            this.Name = "Request";
            this.Text = "Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventoryRequest;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnRequestRequest;
        private System.Windows.Forms.Button btnRequestBack;
        private System.Windows.Forms.ComboBox cmbPartType;
        private System.Windows.Forms.Label lblRequestPartType;
        private System.Windows.Forms.Label lblRequestPartName;
        private System.Windows.Forms.Label lblRequestDescription;
        private System.Windows.Forms.TextBox txtboxPartName;
    }
}
