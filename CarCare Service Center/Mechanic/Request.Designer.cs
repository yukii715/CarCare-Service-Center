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
            this.label8 = new System.Windows.Forms.Label();
            this.nameProfile = new System.Windows.Forms.Label();
            this.txtboxRequest = new System.Windows.Forms.TextBox();
            this.btnRequestDone = new System.Windows.Forms.Button();
            this.btnRequestBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(857, 93);
            this.label8.TabIndex = 3;
            this.label8.Text = "Inventory Request";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameProfile
            // 
            this.nameProfile.AutoSize = true;
            this.nameProfile.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProfile.Location = new System.Drawing.Point(18, 118);
            this.nameProfile.Name = "nameProfile";
            this.nameProfile.Size = new System.Drawing.Size(335, 46);
            this.nameProfile.TabIndex = 5;
            this.nameProfile.Text = "Application Target :";
            this.nameProfile.Click += new System.EventHandler(this.nameProfile_Click);
            // 
            // txtboxRequest
            // 
            this.txtboxRequest.Location = new System.Drawing.Point(26, 191);
            this.txtboxRequest.Multiline = true;
            this.txtboxRequest.Name = "txtboxRequest";
            this.txtboxRequest.Size = new System.Drawing.Size(808, 288);
            this.txtboxRequest.TabIndex = 7;
            // 
            // btnRequestDone
            // 
            this.btnRequestDone.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestDone.Location = new System.Drawing.Point(485, 495);
            this.btnRequestDone.Name = "btnRequestDone";
            this.btnRequestDone.Size = new System.Drawing.Size(187, 78);
            this.btnRequestDone.TabIndex = 9;
            this.btnRequestDone.Text = "Done";
            this.btnRequestDone.UseVisualStyleBackColor = true;
            this.btnRequestDone.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnRequestBack
            // 
            this.btnRequestBack.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestBack.Location = new System.Drawing.Point(184, 495);
            this.btnRequestBack.Name = "btnRequestBack";
            this.btnRequestBack.Size = new System.Drawing.Size(187, 78);
            this.btnRequestBack.TabIndex = 10;
            this.btnRequestBack.Text = "Back";
            this.btnRequestBack.UseVisualStyleBackColor = true;
            this.btnRequestBack.Click += new System.EventHandler(this.btnRequestBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = " Receptionist";
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRequestBack);
            this.Controls.Add(this.btnRequestDone);
            this.Controls.Add(this.txtboxRequest);
            this.Controls.Add(this.nameProfile);
            this.Controls.Add(this.label8);
            this.Name = "Request";
            this.Text = "Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nameProfile;
        private System.Windows.Forms.TextBox txtboxRequest;
        private System.Windows.Forms.Button btnRequestDone;
        private System.Windows.Forms.Button btnRequestBack;
        private System.Windows.Forms.Label label1;
    }
}