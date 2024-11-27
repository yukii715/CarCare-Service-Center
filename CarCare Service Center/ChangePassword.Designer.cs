
namespace CarCare_Service_Center
{
    partial class frmChangePassword
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
            this.txtboxNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldpassword = new System.Windows.Forms.Label();
            this.lblComfirmNewPassword = new System.Windows.Forms.Label();
            this.txtboxComfirmNewPassword = new System.Windows.Forms.TextBox();
            this.txtboxOldPassword = new System.Windows.Forms.TextBox();
            this.lblPwValidation = new System.Windows.Forms.Label();
            this.lblConfirmPwValidation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(488, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 43);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(237, 300);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(122, 43);
            this.btnDone.TabIndex = 10;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtboxNewPassword
            // 
            this.txtboxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxNewPassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNewPassword.Location = new System.Drawing.Point(359, 127);
            this.txtboxNewPassword.Multiline = true;
            this.txtboxNewPassword.Name = "txtboxNewPassword";
            this.txtboxNewPassword.Size = new System.Drawing.Size(442, 31);
            this.txtboxNewPassword.TabIndex = 8;
            this.txtboxNewPassword.TextChanged += new System.EventHandler(this.txtboxNewPassword_TextChanged);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(151, 127);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(202, 42);
            this.lblNewPassword.TabIndex = 7;
            this.lblNewPassword.Text = "New Password :";
            // 
            // lblOldpassword
            // 
            this.lblOldpassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldpassword.Location = new System.Drawing.Point(158, 64);
            this.lblOldpassword.Name = "lblOldpassword";
            this.lblOldpassword.Size = new System.Drawing.Size(189, 42);
            this.lblOldpassword.TabIndex = 6;
            this.lblOldpassword.Text = "Old Password :";
            // 
            // lblComfirmNewPassword
            // 
            this.lblComfirmNewPassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComfirmNewPassword.Location = new System.Drawing.Point(43, 215);
            this.lblComfirmNewPassword.Name = "lblComfirmNewPassword";
            this.lblComfirmNewPassword.Size = new System.Drawing.Size(310, 42);
            this.lblComfirmNewPassword.TabIndex = 12;
            this.lblComfirmNewPassword.Text = "Comfirm New Password :";
            // 
            // txtboxComfirmNewPassword
            // 
            this.txtboxComfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxComfirmNewPassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxComfirmNewPassword.Location = new System.Drawing.Point(359, 215);
            this.txtboxComfirmNewPassword.Multiline = true;
            this.txtboxComfirmNewPassword.Name = "txtboxComfirmNewPassword";
            this.txtboxComfirmNewPassword.Size = new System.Drawing.Size(444, 31);
            this.txtboxComfirmNewPassword.TabIndex = 13;
            this.txtboxComfirmNewPassword.TextChanged += new System.EventHandler(this.txtConfirmPw_TextChanged);
            // 
            // txtboxOldPassword
            // 
            this.txtboxOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxOldPassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxOldPassword.Location = new System.Drawing.Point(359, 64);
            this.txtboxOldPassword.Multiline = true;
            this.txtboxOldPassword.Name = "txtboxOldPassword";
            this.txtboxOldPassword.Size = new System.Drawing.Size(442, 31);
            this.txtboxOldPassword.TabIndex = 14;
            // 
            // lblPwValidation
            // 
            this.lblPwValidation.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwValidation.Location = new System.Drawing.Point(359, 160);
            this.lblPwValidation.Name = "lblPwValidation";
            this.lblPwValidation.Size = new System.Drawing.Size(416, 52);
            this.lblPwValidation.TabIndex = 15;
            this.lblPwValidation.Text = "*8-20 characters,  must contain at least one uppercase letter, one lowercase lett" +
    "er, one number, one symbol";
            // 
            // lblConfirmPwValidation
            // 
            this.lblConfirmPwValidation.AutoSize = true;
            this.lblConfirmPwValidation.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPwValidation.Location = new System.Drawing.Point(359, 248);
            this.lblConfirmPwValidation.Name = "lblConfirmPwValidation";
            this.lblConfirmPwValidation.Size = new System.Drawing.Size(0, 23);
            this.lblConfirmPwValidation.TabIndex = 16;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 397);
            this.Controls.Add(this.lblConfirmPwValidation);
            this.Controls.Add(this.lblPwValidation);
            this.Controls.Add(this.txtboxOldPassword);
            this.Controls.Add(this.txtboxComfirmNewPassword);
            this.Controls.Add(this.lblComfirmNewPassword);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtboxNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblOldpassword);
            this.Name = "frmChangePassword";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtboxNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOldpassword;
        private System.Windows.Forms.Label lblComfirmNewPassword;
        private System.Windows.Forms.TextBox txtboxComfirmNewPassword;
        private System.Windows.Forms.TextBox txtboxOldPassword;
        private System.Windows.Forms.Label lblPwValidation;
        private System.Windows.Forms.Label lblConfirmPwValidation;
    }
}
