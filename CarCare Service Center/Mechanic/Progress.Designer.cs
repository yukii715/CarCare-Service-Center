
namespace CarCare_Service_Center
{
    partial class Progress
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
            this.btnProgressDone = new System.Windows.Forms.Button();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUsedAmount = new System.Windows.Forms.Label();
            this.cmbInventoryUsed1 = new System.Windows.Forms.ComboBox();
            this.lblInventoryUsed = new System.Windows.Forms.Label();
            this.txtUsedAmount1 = new System.Windows.Forms.TextBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.panelProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProgressDone
            // 
            this.btnProgressDone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgressDone.Location = new System.Drawing.Point(386, 565);
            this.btnProgressDone.Name = "btnProgressDone";
            this.btnProgressDone.Size = new System.Drawing.Size(135, 59);
            this.btnProgressDone.TabIndex = 0;
            this.btnProgressDone.Text = "Done";
            this.btnProgressDone.UseVisualStyleBackColor = true;
            this.btnProgressDone.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelProgress
            // 
            this.panelProgress.AutoScroll = true;
            this.panelProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProgress.Controls.Add(this.btnAdd);
            this.panelProgress.Controls.Add(this.lblUsedAmount);
            this.panelProgress.Controls.Add(this.cmbInventoryUsed1);
            this.panelProgress.Controls.Add(this.lblInventoryUsed);
            this.panelProgress.Controls.Add(this.txtUsedAmount1);
            this.panelProgress.Location = new System.Drawing.Point(12, 244);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(876, 315);
            this.panelProgress.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(760, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUsedAmount
            // 
            this.lblUsedAmount.AutoSize = true;
            this.lblUsedAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedAmount.Location = new System.Drawing.Point(417, 14);
            this.lblUsedAmount.Name = "lblUsedAmount";
            this.lblUsedAmount.Size = new System.Drawing.Size(155, 27);
            this.lblUsedAmount.TabIndex = 3;
            this.lblUsedAmount.Text = "Used Amount :";
            // 
            // cmbInventoryUsed1
            // 
            this.cmbInventoryUsed1.FormattingEnabled = true;
            this.cmbInventoryUsed1.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.cmbInventoryUsed1.Location = new System.Drawing.Point(193, 16);
            this.cmbInventoryUsed1.Name = "cmbInventoryUsed1";
            this.cmbInventoryUsed1.Size = new System.Drawing.Size(185, 28);
            this.cmbInventoryUsed1.TabIndex = 0;
            // 
            // lblInventoryUsed
            // 
            this.lblInventoryUsed.AutoSize = true;
            this.lblInventoryUsed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryUsed.Location = new System.Drawing.Point(15, 14);
            this.lblInventoryUsed.Name = "lblInventoryUsed";
            this.lblInventoryUsed.Size = new System.Drawing.Size(172, 27);
            this.lblInventoryUsed.TabIndex = 2;
            this.lblInventoryUsed.Text = "Inventory Used :";
            // 
            // txtUsedAmount1
            // 
            this.txtUsedAmount1.Location = new System.Drawing.Point(578, 16);
            this.txtUsedAmount1.Multiline = true;
            this.txtUsedAmount1.Name = "txtUsedAmount1";
            this.txtUsedAmount1.Size = new System.Drawing.Size(101, 25);
            this.txtUsedAmount1.TabIndex = 1;
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(8, 18);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(880, 223);
            this.lblProgress.TabIndex = 3;
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 648);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.btnProgressDone);
            this.Name = "Progress";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProgressDone;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblUsedAmount;
        private System.Windows.Forms.Label lblInventoryUsed;
        private System.Windows.Forms.TextBox txtUsedAmount1;
        private System.Windows.Forms.ComboBox cmbInventoryUsed1;
        private System.Windows.Forms.Label lblProgress;
    }
}
