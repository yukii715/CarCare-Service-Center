namespace CarCare_Service_Center
{
    partial class Shortages
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
            this.btnUpdateDone = new System.Windows.Forms.Button();
            this.btnUpdateBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateDone
            // 
            this.btnUpdateDone.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDone.Location = new System.Drawing.Point(573, 573);
            this.btnUpdateDone.Name = "btnUpdateDone";
            this.btnUpdateDone.Size = new System.Drawing.Size(187, 78);
            this.btnUpdateDone.TabIndex = 16;
            this.btnUpdateDone.Text = "Done";
            this.btnUpdateDone.UseVisualStyleBackColor = true;
            this.btnUpdateDone.Click += new System.EventHandler(this.btnUpdateDone_Click);
            // 
            // btnUpdateBack
            // 
            this.btnUpdateBack.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBack.Location = new System.Drawing.Point(256, 573);
            this.btnUpdateBack.Name = "btnUpdateBack";
            this.btnUpdateBack.Size = new System.Drawing.Size(187, 78);
            this.btnUpdateBack.TabIndex = 15;
            this.btnUpdateBack.Text = "Back";
            this.btnUpdateBack.UseVisualStyleBackColor = true;
            this.btnUpdateBack.Click += new System.EventHandler(this.btnUpdateBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 461);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Complement";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(857, 93);
            this.label8.TabIndex = 13;
            this.label8.Text = "Inventory Shortages";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shortages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 658);
            this.Controls.Add(this.btnUpdateDone);
            this.Controls.Add(this.btnUpdateBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Name = "Shortages";
            this.Text = "Shortages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateDone;
        private System.Windows.Forms.Button btnUpdateBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
    }
}