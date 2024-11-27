
namespace CarCare_Service_Center
{
    partial class frmChangeEmail
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtboxNewEmail = new System.Windows.Forms.TextBox();
            this.lblNewEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblShowUserEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(460, 209);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 48);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(232, 209);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(122, 48);
            this.btnDone.TabIndex = 18;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtboxNewEmail
            // 
            this.txtboxNewEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxNewEmail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNewEmail.Location = new System.Drawing.Point(306, 133);
            this.txtboxNewEmail.Multiline = true;
            this.txtboxNewEmail.Name = "txtboxNewEmail";
            this.txtboxNewEmail.Size = new System.Drawing.Size(480, 34);
            this.txtboxNewEmail.TabIndex = 17;
            // 
            // lblNewEmail
            // 
            this.lblNewEmail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewEmail.Location = new System.Drawing.Point(118, 133);
            this.lblNewEmail.Name = "lblNewEmail";
            this.lblNewEmail.Size = new System.Drawing.Size(165, 47);
            this.lblNewEmail.TabIndex = 16;
            this.lblNewEmail.Text = "New Email :";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(175, 76);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(108, 47);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email :";
            // 
            // lblShowUserEmail
            // 
            this.lblShowUserEmail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowUserEmail.Location = new System.Drawing.Point(300, 76);
            this.lblShowUserEmail.Name = "lblShowUserEmail";
            this.lblShowUserEmail.Size = new System.Drawing.Size(510, 47);
            this.lblShowUserEmail.TabIndex = 20;
            // 
            // frmChangeUserEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 345);
            this.Controls.Add(this.lblShowUserEmail);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtboxNewEmail);
            this.Controls.Add(this.lblNewEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "frmChangeUserEmail";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtboxNewEmail;
        private System.Windows.Forms.Label lblNewEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblShowUserEmail;
    }
}
