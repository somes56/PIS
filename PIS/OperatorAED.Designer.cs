namespace PIS
{
    partial class OperatorAED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorAED));
            this.label2 = new System.Windows.Forms.Label();
            this.lblOperatorID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLinerName = new System.Windows.Forms.TextBox();
            this.lblLinerName = new System.Windows.Forms.Label();
            this.lblOperatorCode = new System.Windows.Forms.Label();
            this.txtOperatorCode = new System.Windows.Forms.TextBox();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 3;
            this.label2.Tag = "cv";
            this.label2.Text = "ID :";
            this.label2.Visible = false;
            // 
            // lblOperatorID
            // 
            this.lblOperatorID.AutoSize = true;
            this.lblOperatorID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblOperatorID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorID.ForeColor = System.Drawing.Color.White;
            this.lblOperatorID.Location = new System.Drawing.Point(43, 9);
            this.lblOperatorID.Name = "lblOperatorID";
            this.lblOperatorID.Size = new System.Drawing.Size(14, 15);
            this.lblOperatorID.TabIndex = 14;
            this.lblOperatorID.Text = "0";
            this.lblOperatorID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlSave);
            this.panel1.Controls.Add(this.txtLinerName);
            this.panel1.Controls.Add(this.lblLinerName);
            this.panel1.Controls.Add(this.lblOperatorCode);
            this.panel1.Controls.Add(this.txtOperatorCode);
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 253);
            this.panel1.TabIndex = 15;
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Controls.Add(this.btnCancel);
            this.pnlSave.Location = new System.Drawing.Point(370, 110);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(121, 56);
            this.pnlSave.TabIndex = 20;
            this.pnlSave.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 41);
            this.btnSave.TabIndex = 22;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(60, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 41);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLinerName
            // 
            this.txtLinerName.BackColor = System.Drawing.Color.Black;
            this.txtLinerName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinerName.ForeColor = System.Drawing.Color.Yellow;
            this.txtLinerName.Location = new System.Drawing.Point(125, 37);
            this.txtLinerName.MaxLength = 1000;
            this.txtLinerName.Name = "txtLinerName";
            this.txtLinerName.ReadOnly = true;
            this.txtLinerName.Size = new System.Drawing.Size(340, 23);
            this.txtLinerName.TabIndex = 2;
            // 
            // lblLinerName
            // 
            this.lblLinerName.AutoSize = true;
            this.lblLinerName.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblLinerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinerName.ForeColor = System.Drawing.SystemColors.Info;
            this.lblLinerName.Location = new System.Drawing.Point(24, 39);
            this.lblLinerName.Name = "lblLinerName";
            this.lblLinerName.Size = new System.Drawing.Size(95, 16);
            this.lblLinerName.TabIndex = 11;
            this.lblLinerName.Text = "Liner Name :";
            // 
            // lblOperatorCode
            // 
            this.lblOperatorCode.AutoSize = true;
            this.lblOperatorCode.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblOperatorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorCode.ForeColor = System.Drawing.SystemColors.Info;
            this.lblOperatorCode.Location = new System.Drawing.Point(66, 11);
            this.lblOperatorCode.Name = "lblOperatorCode";
            this.lblOperatorCode.Size = new System.Drawing.Size(53, 16);
            this.lblOperatorCode.TabIndex = 10;
            this.lblOperatorCode.Text = "Code :";
            // 
            // txtOperatorCode
            // 
            this.txtOperatorCode.BackColor = System.Drawing.Color.Black;
            this.txtOperatorCode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperatorCode.ForeColor = System.Drawing.Color.Yellow;
            this.txtOperatorCode.Location = new System.Drawing.Point(125, 9);
            this.txtOperatorCode.MaxLength = 100;
            this.txtOperatorCode.Name = "txtOperatorCode";
            this.txtOperatorCode.ReadOnly = true;
            this.txtOperatorCode.Size = new System.Drawing.Size(340, 23);
            this.txtOperatorCode.TabIndex = 1;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.btnBack);
            this.pnlEdit.Controls.Add(this.btnDel);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Location = new System.Drawing.Point(326, 172);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(174, 56);
            this.pnlEdit.TabIndex = 20;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 41);
            this.btnBack.TabIndex = 22;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(109, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(45, 41);
            this.btnDel.TabIndex = 20;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(53, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 41);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // OperatorAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(517, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOperatorID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperatorAED";
            this.ShowIcon = false;
            this.Text = "Operator Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSave.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperatorID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLinerName;
        private System.Windows.Forms.Label lblLinerName;
        private System.Windows.Forms.Label lblOperatorCode;
        private System.Windows.Forms.TextBox txtOperatorCode;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
    }
}