namespace CarCare_Service_Center
{
    partial class Update
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateBack = new System.Windows.Forms.Button();
            this.btnUpdateDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(857, 93);
            this.label8.TabIndex = 4;
            this.label8.Text = "Inventory Update";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 449);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts Used";
            // 
            // btnUpdateBack
            // 
            this.btnUpdateBack.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBack.Location = new System.Drawing.Point(248, 575);
            this.btnUpdateBack.Name = "btnUpdateBack";
            this.btnUpdateBack.Size = new System.Drawing.Size(187, 78);
            this.btnUpdateBack.TabIndex = 11;
            this.btnUpdateBack.Text = "Back";
            this.btnUpdateBack.UseVisualStyleBackColor = true;
            this.btnUpdateBack.Click += new System.EventHandler(this.btnUpdateBack_Click);
            // 
            // btnUpdateDone
            // 
            this.btnUpdateDone.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDone.Location = new System.Drawing.Point(565, 575);
            this.btnUpdateDone.Name = "btnUpdateDone";
            this.btnUpdateDone.Size = new System.Drawing.Size(187, 78);
            this.btnUpdateDone.TabIndex = 12;
            this.btnUpdateDone.Text = "Done";
            this.btnUpdateDone.UseVisualStyleBackColor = true;
            this.btnUpdateDone.Click += new System.EventHandler(this.btnUpdateDone_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 665);
            this.Controls.Add(this.btnUpdateDone);
            this.Controls.Add(this.btnUpdateBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateBack;
        private System.Windows.Forms.Button btnUpdateDone;
    }
}