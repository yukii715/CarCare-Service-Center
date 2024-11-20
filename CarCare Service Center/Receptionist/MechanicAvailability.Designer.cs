namespace CarCare_Service_Center
{
    partial class frmMechanicAvailability
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
            this.label14 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblButtomMargin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(893, 83);
            this.label14.TabIndex = 11;
            this.label14.Text = "Mechanics";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(590, 645);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 40);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.AutoSize = true;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssign.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(151, 645);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(168, 40);
            this.btnAssign.TabIndex = 13;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblButtomMargin
            // 
            this.lblButtomMargin.AutoSize = true;
            this.lblButtomMargin.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButtomMargin.Location = new System.Drawing.Point(379, 692);
            this.lblButtomMargin.Name = "lblButtomMargin";
            this.lblButtomMargin.Size = new System.Drawing.Size(181, 30);
            this.lblButtomMargin.TabIndex = 14;
            this.lblButtomMargin.Text = "[Bottom Margin]";
            // 
            // frmMechanicAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 731);
            this.Controls.Add(this.lblButtomMargin);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label14);
            this.Name = "frmMechanicAvailability";
            this.Text = "MechanicAvailability";
            this.Load += new System.EventHandler(this.frmMechanicAvailability_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblButtomMargin;
    }
}