namespace CarCare_Service_Center
{
    partial class PartsRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPartType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.lblNewPartType = new System.Windows.Forms.Label();
            this.txtNewPartType = new System.Windows.Forms.TextBox();
            this.lblPartID = new System.Windows.Forms.Label();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Part Name:";
            // 
            // cmbPartType
            // 
            this.cmbPartType.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPartType.FormattingEnabled = true;
            this.cmbPartType.Items.AddRange(new object[] {
            "New Type"});
            this.cmbPartType.Location = new System.Drawing.Point(210, 119);
            this.cmbPartType.Name = "cmbPartType";
            this.cmbPartType.Size = new System.Drawing.Size(192, 32);
            this.cmbPartType.TabIndex = 2;
            this.cmbPartType.TextChanged += new System.EventHandler(this.cmbPartType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prefix: ";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefix.Location = new System.Drawing.Point(509, 118);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.ReadOnly = true;
            this.txtPrefix.Size = new System.Drawing.Size(85, 33);
            this.txtPrefix.TabIndex = 4;
            // 
            // txtPartName
            // 
            this.txtPartName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartName.Location = new System.Drawing.Point(210, 51);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(384, 33);
            this.txtPartName.TabIndex = 1;
            // 
            // lblNewPartType
            // 
            this.lblNewPartType.AutoSize = true;
            this.lblNewPartType.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPartType.Location = new System.Drawing.Point(47, 190);
            this.lblNewPartType.Name = "lblNewPartType";
            this.lblNewPartType.Size = new System.Drawing.Size(138, 24);
            this.lblNewPartType.TabIndex = 0;
            this.lblNewPartType.Text = "New Part Type:";
            // 
            // txtNewPartType
            // 
            this.txtNewPartType.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPartType.Location = new System.Drawing.Point(210, 187);
            this.txtNewPartType.Name = "txtNewPartType";
            this.txtNewPartType.ReadOnly = true;
            this.txtNewPartType.Size = new System.Drawing.Size(384, 33);
            this.txtNewPartType.TabIndex = 5;
            // 
            // lblPartID
            // 
            this.lblPartID.AutoSize = true;
            this.lblPartID.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartID.Location = new System.Drawing.Point(107, 261);
            this.lblPartID.Name = "lblPartID";
            this.lblPartID.Size = new System.Drawing.Size(78, 24);
            this.lblPartID.TabIndex = 0;
            this.lblPartID.Text = "Part ID:";
            // 
            // txtPartID
            // 
            this.txtPartID.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartID.Location = new System.Drawing.Point(210, 258);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.ReadOnly = true;
            this.txtPartID.Size = new System.Drawing.Size(192, 33);
            this.txtPartID.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(61, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 34);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.AutoSize = true;
            this.btnApprove.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(262, 350);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(124, 34);
            this.btnApprove.TabIndex = 7;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.AutoSize = true;
            this.btnReject.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Location = new System.Drawing.Point(470, 350);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(124, 34);
            this.btnReject.TabIndex = 8;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // PartsRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 424);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.txtNewPartType);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.lblPartID);
            this.Controls.Add(this.cmbPartType);
            this.Controls.Add(this.lblNewPartType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartsRequest";
            this.Text = "Parts Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPartType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label lblNewPartType;
        private System.Windows.Forms.TextBox txtNewPartType;
        private System.Windows.Forms.Label lblPartID;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
    }
}