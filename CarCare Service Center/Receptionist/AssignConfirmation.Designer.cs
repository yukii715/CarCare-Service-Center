namespace CarCare_Service_Center
{
    partial class frmAssignConfirmation
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
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(636, 141);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(106, 41);
            this.btnNo.TabIndex = 34;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(185, 141);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(106, 41);
            this.btnYes.TabIndex = 33;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(41, 34);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(129, 33);
            this.lblMessage.TabIndex = 32;
            this.lblMessage.Text = "[Message]";
            // 
            // frmAssignConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 194);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblMessage);
            this.Name = "frmAssignConfirmation";
            this.Text = "AssignConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblMessage;
    }
}