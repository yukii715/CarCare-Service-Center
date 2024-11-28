
namespace CarCare_Service_Center
{
    partial class frmChangeUserName
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.txtboxNewUserName = new System.Windows.Forms.TextBox();
            this.lblOldUsername = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblChangeUsernameValidation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(219, 58);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(208, 58);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User Name :";
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUsername.Location = new System.Drawing.Point(145, 144);
            this.lblNewUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(281, 58);
            this.lblNewUsername.TabIndex = 1;
            this.lblNewUsername.Text = "New User Name :";
            // 
            // txtboxNewUserName
            // 
            this.txtboxNewUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxNewUserName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNewUserName.Location = new System.Drawing.Point(460, 144);
            this.txtboxNewUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxNewUserName.Name = "txtboxNewUserName";
            this.txtboxNewUserName.Size = new System.Drawing.Size(463, 50);
            this.txtboxNewUserName.TabIndex = 2;
            this.txtboxNewUserName.TextChanged += new System.EventHandler(this.txtboxNewUserName_TextChanged);
            // 
            // lblOldUsername
            // 
            this.lblOldUsername.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldUsername.Location = new System.Drawing.Point(452, 58);
            this.lblOldUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldUsername.Name = "lblOldUsername";
            this.lblOldUsername.Size = new System.Drawing.Size(563, 58);
            this.lblOldUsername.TabIndex = 3;
            // 
            // btnDone
            // 
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(264, 264);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(163, 60);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(547, 264);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(163, 60);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblChangeUsernameValidation
            // 
            this.lblChangeUsernameValidation.AutoSize = true;
            this.lblChangeUsernameValidation.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeUsernameValidation.Location = new System.Drawing.Point(455, 209);
            this.lblChangeUsernameValidation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeUsernameValidation.Name = "lblChangeUsernameValidation";
            this.lblChangeUsernameValidation.Size = new System.Drawing.Size(188, 30);
            this.lblChangeUsernameValidation.TabIndex = 12;
            this.lblChangeUsernameValidation.Text = "*3-20 characters";
            // 
            // frmChangeUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 386);
            this.Controls.Add(this.lblChangeUsernameValidation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblOldUsername);
            this.Controls.Add(this.txtboxNewUserName);
            this.Controls.Add(this.lblNewUsername);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChangeUserName";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.TextBox txtboxNewUserName;
        private System.Windows.Forms.Label lblOldUsername;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblChangeUsernameValidation;
    }
}
