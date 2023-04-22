namespace PIS
{
    partial class VoyageAED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoyageAED));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtETD = new System.Windows.Forms.DateTimePicker();
            this.lblEtd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSVN = new System.Windows.Forms.TextBox();
            this.dtETA = new System.Windows.Forms.DateTimePicker();
            this.lblEta = new System.Windows.Forms.Label();
            this.txtVesselName = new System.Windows.Forms.TextBox();
            this.cbVesselName = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbVoyageNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSCN = new System.Windows.Forms.TextBox();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 2;
            this.label2.Tag = "cv";
            this.label2.Text = "ID :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dtETD);
            this.panel1.Controls.Add(this.lblEtd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbSVN);
            this.panel1.Controls.Add(this.dtETA);
            this.panel1.Controls.Add(this.lblEta);
            this.panel1.Controls.Add(this.txtVesselName);
            this.panel1.Controls.Add(this.cbVesselName);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblEdit);
            this.panel1.Controls.Add(this.pnlSave);
            this.panel1.Controls.Add(this.tbVoyageNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbSCN);
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 311);
            this.panel1.TabIndex = 14;
            // 
            // dtETD
            // 
            this.dtETD.Location = new System.Drawing.Point(119, 161);
            this.dtETD.Name = "dtETD";
            this.dtETD.Size = new System.Drawing.Size(200, 20);
            this.dtETD.TabIndex = 46;
            this.dtETD.Visible = false;
            // 
            // lblEtd
            // 
            this.lblEtd.AutoSize = true;
            this.lblEtd.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblEtd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtd.ForeColor = System.Drawing.SystemColors.Info;
            this.lblEtd.Location = new System.Drawing.Point(75, 166);
            this.lblEtd.Name = "lblEtd";
            this.lblEtd.Size = new System.Drawing.Size(37, 15);
            this.lblEtd.TabIndex = 45;
            this.lblEtd.Text = "ETD  :";
            this.lblEtd.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(225, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "---";
            // 
            // tbSVN
            // 
            this.tbSVN.BackColor = System.Drawing.Color.Black;
            this.tbSVN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSVN.ForeColor = System.Drawing.Color.Yellow;
            this.tbSVN.Location = new System.Drawing.Point(119, 84);
            this.tbSVN.MaxLength = 15;
            this.tbSVN.Name = "tbSVN";
            this.tbSVN.ReadOnly = true;
            this.tbSVN.Size = new System.Drawing.Size(100, 23);
            this.tbSVN.TabIndex = 40;
            this.tbSVN.Leave += new System.EventHandler(this.tbSVN_Leave);
            // 
            // dtETA
            // 
            this.dtETA.Location = new System.Drawing.Point(119, 125);
            this.dtETA.Name = "dtETA";
            this.dtETA.Size = new System.Drawing.Size(200, 20);
            this.dtETA.TabIndex = 15;
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblEta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEta.ForeColor = System.Drawing.SystemColors.Info;
            this.lblEta.Location = new System.Drawing.Point(75, 130);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(36, 15);
            this.lblEta.TabIndex = 39;
            this.lblEta.Text = "ETA  :";
            // 
            // txtVesselName
            // 
            this.txtVesselName.BackColor = System.Drawing.Color.Black;
            this.txtVesselName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVesselName.ForeColor = System.Drawing.Color.Yellow;
            this.txtVesselName.Location = new System.Drawing.Point(245, 84);
            this.txtVesselName.MaxLength = 15;
            this.txtVesselName.Name = "txtVesselName";
            this.txtVesselName.ReadOnly = true;
            this.txtVesselName.Size = new System.Drawing.Size(242, 23);
            this.txtVesselName.TabIndex = 3;
            // 
            // cbVesselName
            // 
            this.cbVesselName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVesselName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVesselName.BackColor = System.Drawing.Color.Black;
            this.cbVesselName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVesselName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVesselName.ForeColor = System.Drawing.Color.Yellow;
            this.cbVesselName.FormattingEnabled = true;
            this.cbVesselName.Location = new System.Drawing.Point(245, 84);
            this.cbVesselName.Name = "cbVesselName";
            this.cbVesselName.Size = new System.Drawing.Size(242, 23);
            this.cbVesselName.TabIndex = 3;
            this.cbVesselName.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Highlight;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Info;
            this.label14.Location = new System.Drawing.Point(27, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 15);
            this.label14.TabIndex = 36;
            this.label14.Text = "Vessel Name :";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.Color.Red;
            this.lblEdit.Location = new System.Drawing.Point(236, 12);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(251, 15);
            this.lblEdit.TabIndex = 23;
            this.lblEdit.Tag = "cv";
            this.lblEdit.Text = "SCN  cannot be edited. Delete and add again.";
            this.lblEdit.Visible = false;
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Controls.Add(this.btnCancel);
            this.pnlSave.Location = new System.Drawing.Point(572, 188);
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
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(65, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 41);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbVoyageNo
            // 
            this.tbVoyageNo.BackColor = System.Drawing.Color.Black;
            this.tbVoyageNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVoyageNo.ForeColor = System.Drawing.Color.Yellow;
            this.tbVoyageNo.Location = new System.Drawing.Point(119, 45);
            this.tbVoyageNo.MaxLength = 10;
            this.tbVoyageNo.Name = "tbVoyageNo";
            this.tbVoyageNo.ReadOnly = true;
            this.tbVoyageNo.Size = new System.Drawing.Size(100, 23);
            this.tbVoyageNo.TabIndex = 2;
            this.tbVoyageNo.Leave += new System.EventHandler(this.txtAdd1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(36, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Voyage No  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(56, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "SCN No :";
            // 
            // tbSCN
            // 
            this.tbSCN.BackColor = System.Drawing.Color.Black;
            this.tbSCN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSCN.ForeColor = System.Drawing.Color.Yellow;
            this.tbSCN.Location = new System.Drawing.Point(119, 9);
            this.tbSCN.MaxLength = 10;
            this.tbSCN.Name = "tbSCN";
            this.tbSCN.ReadOnly = true;
            this.tbSCN.Size = new System.Drawing.Size(100, 23);
            this.tbSCN.TabIndex = 1;
            this.tbSCN.Leave += new System.EventHandler(this.txtCompanyName_Leave);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.btnBack);
            this.pnlEdit.Controls.Add(this.btnDel);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Location = new System.Drawing.Point(519, 250);
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
            this.btnBack.TabIndex = 9;
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
            this.btnDel.TabIndex = 11;
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
            this.btnEdit.TabIndex = 10;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbl_ID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(36, 9);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(14, 15);
            this.lbl_ID.TabIndex = 13;
            this.lbl_ID.Text = "1";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Location = new System.Drawing.Point(617, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 37);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add Vessel";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // VoyageAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(722, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoyageAED";
            this.Text = "Voyage Details";
            this.Load += new System.EventHandler(this.CustAED_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSave.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbVoyageNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSCN;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.TextBox txtVesselName;
        private System.Windows.Forms.ComboBox cbVesselName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtETA;
        private System.Windows.Forms.TextBox tbSVN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtETD;
        private System.Windows.Forms.Label lblEtd;
        private System.Windows.Forms.Button btnAdd;
    }
}

