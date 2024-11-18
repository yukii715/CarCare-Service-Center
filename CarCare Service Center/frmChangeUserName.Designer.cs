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
            this.lblUsername.Location = new System.Drawing.Point(164, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(156, 47);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User Name :";
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUsername.Location = new System.Drawing.Point(109, 115);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(211, 47);
            this.lblNewUsername.TabIndex = 1;
            this.lblNewUsername.Text = "New User Name :";
            // 
            // txtboxNewUserName
            // 
            this.txtboxNewUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxNewUserName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNewUserName.Location = new System.Drawing.Point(345, 115);
            this.txtboxNewUserName.Multiline = true;
            this.txtboxNewUserName.Name = "txtboxNewUserName";
            this.txtboxNewUserName.Size = new System.Drawing.Size(348, 34);
            this.txtboxNewUserName.TabIndex = 2;
            // 
            // lblOldUsername
            // 
            this.lblOldUsername.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldUsername.Location = new System.Drawing.Point(339, 47);
            this.lblOldUsername.Name = "lblOldUsername";
            this.lblOldUsername.Size = new System.Drawing.Size(422, 47);
            this.lblOldUsername.TabIndex = 3;
            // 
            // btnDone
            // 
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(198, 211);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(122, 48);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(410, 211);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 48);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblChangeUsernameValidation
            // 
            this.lblChangeUsernameValidation.AutoSize = true;
            this.lblChangeUsernameValidation.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeUsernameValidation.Location = new System.Drawing.Point(341, 152);
            this.lblChangeUsernameValidation.Name = "lblChangeUsernameValidation";
            this.lblChangeUsernameValidation.Size = new System.Drawing.Size(139, 23);
            this.lblChangeUsernameValidation.TabIndex = 12;
            this.lblChangeUsernameValidation.Text = "*3-20 characters";
            // 
            // frmChangeUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 309);
            this.Controls.Add(this.lblChangeUsernameValidation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblOldUsername);
            this.Controls.Add(this.txtboxNewUserName);
            this.Controls.Add(this.lblNewUsername);
            this.Controls.Add(this.lblUsername);
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