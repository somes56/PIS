namespace PIS
{
    partial class LocAED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocAED));
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblLocID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbPortNorth = new System.Windows.Forms.RadioButton();
            this.rbPortWest = new System.Windows.Forms.RadioButton();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtLocCode = new System.Windows.Forms.TextBox();
            this.lblLocCode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.SystemColors.Info;
            this.lblLoc.Location = new System.Drawing.Point(12, 9);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(46, 15);
            this.lblLoc.TabIndex = 1;
            this.lblLoc.Tag = "cv";
            this.lblLoc.Text = "Loc ID :";
            this.lblLoc.Visible = false;
            // 
            // lblLocID
            // 
            this.lblLocID.AutoSize = true;
            this.lblLocID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblLocID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocID.ForeColor = System.Drawing.Color.White;
            this.lblLocID.Location = new System.Drawing.Point(64, 9);
            this.lblLocID.Name = "lblLocID";
            this.lblLocID.Size = new System.Drawing.Size(14, 15);
            this.lblLocID.TabIndex = 2;
            this.lblLocID.Text = "1";
            this.lblLocID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Controls.Add(this.pnlSave);
            this.panel1.Controls.Add(this.rbPortNorth);
            this.panel1.Controls.Add(this.rbPortWest);
            this.panel1.Controls.Add(this.lblPort);
            this.panel1.Controls.Add(this.txtLocCode);
            this.panel1.Controls.Add(this.lblLocCode);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 340);
            this.panel1.TabIndex = 3;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.btnBack);
            this.pnlEdit.Controls.Add(this.btnDel);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Location = new System.Drawing.Point(344, 281);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(174, 56);
            this.pnlEdit.TabIndex = 104;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(27, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 41);
            this.btnBack.TabIndex = 18;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(129, 0);
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
            this.btnEdit.Location = new System.Drawing.Point(78, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 41);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Controls.Add(this.btnCancel);
            this.pnlSave.Location = new System.Drawing.Point(397, 194);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(121, 56);
            this.pnlSave.TabIndex = 16;
            this.pnlSave.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(25, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 41);
            this.btnSave.TabIndex = 16;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(76, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 41);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbPortNorth
            // 
            this.rbPortNorth.AutoSize = true;
            this.rbPortNorth.Checked = true;
            this.rbPortNorth.ForeColor = System.Drawing.Color.White;
            this.rbPortNorth.Location = new System.Drawing.Point(226, 81);
            this.rbPortNorth.Name = "rbPortNorth";
            this.rbPortNorth.Size = new System.Drawing.Size(73, 17);
            this.rbPortNorth.TabIndex = 14;
            this.rbPortNorth.TabStop = true;
            this.rbPortNorth.Text = "North Port";
            this.rbPortNorth.UseVisualStyleBackColor = true;
            // 
            // rbPortWest
            // 
            this.rbPortWest.AutoSize = true;
            this.rbPortWest.ForeColor = System.Drawing.Color.White;
            this.rbPortWest.Location = new System.Drawing.Point(148, 82);
            this.rbPortWest.Name = "rbPortWest";
            this.rbPortWest.Size = new System.Drawing.Size(72, 17);
            this.rbPortWest.TabIndex = 13;
            this.rbPortWest.Text = "West Port";
            this.rbPortWest.UseVisualStyleBackColor = true;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(98, 82);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(44, 16);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port :";
            // 
            // txtLocCode
            // 
            this.txtLocCode.BackColor = System.Drawing.Color.Black;
            this.txtLocCode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocCode.ForeColor = System.Drawing.Color.Yellow;
            this.txtLocCode.Location = new System.Drawing.Point(148, 27);
            this.txtLocCode.MaxLength = 100000000;
            this.txtLocCode.Name = "txtLocCode";
            this.txtLocCode.ReadOnly = true;
            this.txtLocCode.Size = new System.Drawing.Size(295, 23);
            this.txtLocCode.TabIndex = 2;
            // 
            // lblLocCode
            // 
            this.lblLocCode.AutoSize = true;
            this.lblLocCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocCode.ForeColor = System.Drawing.Color.White;
            this.lblLocCode.Location = new System.Drawing.Point(26, 29);
            this.lblLocCode.Name = "lblLocCode";
            this.lblLocCode.Size = new System.Drawing.Size(116, 16);
            this.lblLocCode.TabIndex = 1;
            this.lblLocCode.Text = "Location Code :";
            // 
            // LocAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(545, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLocID);
            this.Controls.Add(this.lblLoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "LocAED";
            this.ShowIcon = false;
            this.Text = "Location Details";
            this.Load += new System.EventHandler(this.LocAED_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblLocID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLocCode;
        private System.Windows.Forms.TextBox txtLocCode;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.RadioButton rbPortWest;
        private System.Windows.Forms.RadioButton rbPortNorth;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
    }
}