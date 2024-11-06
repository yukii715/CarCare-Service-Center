namespace CarCare_Service_Center
{
    partial class EditProfile
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
            this.label7 = new System.Windows.Forms.Label();
            this.nameProfile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(810, 87);
            this.label7.TabIndex = 4;
            this.label7.Text = "Edit Profile";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // nameProfile
            // 
            this.nameProfile.AutoSize = true;
            this.nameProfile.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProfile.Location = new System.Drawing.Point(118, 151);
            this.nameProfile.Name = "nameProfile";
            this.nameProfile.Size = new System.Drawing.Size(198, 41);
            this.nameProfile.TabIndex = 5;
            this.nameProfile.Text = "New Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Mail :";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(359, 412);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(187, 78);
            this.btnEditProfile.TabIndex = 8;
            this.btnEditProfile.Text = "Done";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click_1);
            // 
            // txtNewName
            // 
            this.txtNewName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewName.Location = new System.Drawing.Point(322, 151);
            this.txtNewName.Multiline = true;
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(409, 41);
            this.txtNewName.TabIndex = 9;
            // 
            // txtNewMail
            // 
            this.txtNewMail.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewMail.Location = new System.Drawing.Point(322, 260);
            this.txtNewMail.Multiline = true;
            this.txtNewMail.Name = "txtNewMail";
            this.txtNewMail.Size = new System.Drawing.Size(409, 41);
            this.txtNewMail.TabIndex = 10;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 581);
            this.Controls.Add(this.txtNewMail);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameProfile);
            this.Controls.Add(this.label7);
            this.Name = "EditProfile";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nameProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewMail;
    }
}