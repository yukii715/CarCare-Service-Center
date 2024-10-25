namespace CarCare_Service_Center
{
    partial class frmMechanicMain
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
            this.tabMechanic = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabMechanic.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMechanic
            // 
            this.tabMechanic.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabMechanic.Controls.Add(this.tabPage1);
            this.tabMechanic.Controls.Add(this.tabPage2);
            this.tabMechanic.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabMechanic.ItemSize = new System.Drawing.Size(50, 80);
            this.tabMechanic.Location = new System.Drawing.Point(-3, -2);
            this.tabMechanic.Multiline = true;
            this.tabMechanic.Name = "tabMechanic";
            this.tabMechanic.SelectedIndex = 0;
            this.tabMechanic.Size = new System.Drawing.Size(1181, 826);
            this.tabMechanic.TabIndex = 0;
            this.tabMechanic.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabMechanic_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(84, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 818);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(84, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1093, 818);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmMechanicMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 827);
            this.Controls.Add(this.tabMechanic);
            this.Name = "frmMechanicMain";
            this.Text = "Mechanic";
            this.tabMechanic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMechanic;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}