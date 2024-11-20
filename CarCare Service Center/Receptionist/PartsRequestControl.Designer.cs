namespace CarCare_Service_Center
{
    partial class PartsRequestControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserData = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblPartType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPartRequestID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserData
            // 
            this.lblUserData.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUserData.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserData.Location = new System.Drawing.Point(0, 11);
            this.lblUserData.Name = "lblUserData";
            this.lblUserData.Size = new System.Drawing.Size(198, 237);
            this.lblUserData.TabIndex = 0;
            this.lblUserData.Text = "[UserData]";
            this.lblUserData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartName.Location = new System.Drawing.Point(326, 24);
            this.lblPartName.MaximumSize = new System.Drawing.Size(225, 0);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(129, 30);
            this.lblPartName.TabIndex = 1;
            this.lblPartName.Tag = "PartsRequestControl";
            this.lblPartName.Text = "[PartName]";
            // 
            // lblPartType
            // 
            this.lblPartType.AutoSize = true;
            this.lblPartType.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartType.Location = new System.Drawing.Point(700, 24);
            this.lblPartType.MaximumSize = new System.Drawing.Size(171, 0);
            this.lblPartType.Name = "lblPartType";
            this.lblPartType.Size = new System.Drawing.Size(121, 30);
            this.lblPartType.TabIndex = 1;
            this.lblPartType.Text = "[PartType]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Part Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part Type:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDescription.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(209, 122);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(661, 111);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Tag = "PartsRequestControl";
            this.txtDescription.Text = "[Description]";
            // 
            // lblPartRequestID
            // 
            this.lblPartRequestID.Enabled = false;
            this.lblPartRequestID.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartRequestID.Location = new System.Drawing.Point(33, 24);
            this.lblPartRequestID.Name = "lblPartRequestID";
            this.lblPartRequestID.Size = new System.Drawing.Size(137, 27);
            this.lblPartRequestID.TabIndex = 1;
            this.lblPartRequestID.Text = "[RequestID]";
            this.lblPartRequestID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PartsRequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPartRequestID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPartType);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblUserData);
            this.Name = "PartsRequestControl";
            this.Padding = new System.Windows.Forms.Padding(0, 11, 6, 11);
            this.Size = new System.Drawing.Size(892, 259);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PartsRequestControl_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserData;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblPartType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPartRequestID;
    }
}