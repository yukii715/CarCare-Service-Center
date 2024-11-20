namespace CarCare_Service_Center
{
    partial class frmRejectConfirmation
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
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(326, 118);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(106, 41);
            this.btnNo.TabIndex = 31;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(83, 118);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(106, 41);
            this.btnYes.TabIndex = 30;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(468, 33);
            this.label6.TabIndex = 29;
            this.label6.Text = "Are you sure to delete this appointment?";
            // 
            // frmRejectConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 175);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label6);
            this.Name = "frmRejectConfirmation";
            this.Text = "RejectConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label label6;
    }
}