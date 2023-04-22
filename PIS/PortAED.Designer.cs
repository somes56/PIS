namespace PIS
{
    partial class PortAED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortAED));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFav = new System.Windows.Forms.CheckBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblCust_ID = new System.Windows.Forms.Label();
            this.ChkSpecialStorage = new System.Windows.Forms.CheckBox();
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
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Tag = "cv";
            this.label2.Text = "Port  ID :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ChkSpecialStorage);
            this.panel1.Controls.Add(this.cbFav);
            this.panel1.Controls.Add(this.txtCountry);
            this.panel1.Controls.Add(this.cbCountry);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.pnlSave);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbCode);
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Location = new System.Drawing.Point(7, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 259);
            this.panel1.TabIndex = 14;
            // 
            // cbFav
            // 
            this.cbFav.AutoSize = true;
            this.cbFav.Enabled = false;
            this.cbFav.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbFav.Location = new System.Drawing.Point(103, 130);
            this.cbFav.Name = "cbFav";
            this.cbFav.Size = new System.Drawing.Size(109, 17);
            this.cbFav.TabIndex = 38;
            this.cbFav.Text = "Add to Favourites";
            this.cbFav.UseVisualStyleBackColor = true;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.Black;
            this.txtCountry.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.Color.Yellow;
            this.txtCountry.Location = new System.Drawing.Point(103, 95);
            this.txtCountry.MaxLength = 15;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(215, 23);
            this.txtCountry.TabIndex = 37;
            // 
            // cbCountry
            // 
            this.cbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCountry.BackColor = System.Drawing.Color.Black;
            this.cbCountry.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.ForeColor = System.Drawing.Color.Yellow;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(103, 95);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(233, 23);
            this.cbCountry.TabIndex = 34;
            this.cbCountry.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Highlight;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Info;
            this.label14.Location = new System.Drawing.Point(36, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Country  :";
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Controls.Add(this.btnCancel);
            this.pnlSave.Location = new System.Drawing.Point(376, 114);
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
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Black;
            this.tbName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Yellow;
            this.tbName.Location = new System.Drawing.Point(103, 66);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(392, 23);
            this.tbName.TabIndex = 2;
            this.tbName.Leave += new System.EventHandler(this.txtAdd1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Port Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Port Code :";
            // 
            // tbCode
            // 
            this.tbCode.BackColor = System.Drawing.Color.Black;
            this.tbCode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.ForeColor = System.Drawing.Color.Yellow;
            this.tbCode.Location = new System.Drawing.Point(103, 38);
            this.tbCode.MaxLength = 100;
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.Size = new System.Drawing.Size(97, 23);
            this.tbCode.TabIndex = 1;
            this.tbCode.Leave += new System.EventHandler(this.txtCompanyName_Leave);
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
            // lblCust_ID
            // 
            this.lblCust_ID.AutoSize = true;
            this.lblCust_ID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCust_ID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust_ID.ForeColor = System.Drawing.Color.White;
            this.lblCust_ID.Location = new System.Drawing.Point(68, 9);
            this.lblCust_ID.Name = "lblCust_ID";
            this.lblCust_ID.Size = new System.Drawing.Size(14, 15);
            this.lblCust_ID.TabIndex = 13;
            this.lblCust_ID.Text = "1";
            // 
            // ChkSpecialStorage
            // 
            this.ChkSpecialStorage.AutoSize = true;
            this.ChkSpecialStorage.Enabled = false;
            this.ChkSpecialStorage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkSpecialStorage.Location = new System.Drawing.Point(103, 153);
            this.ChkSpecialStorage.Name = "ChkSpecialStorage";
            this.ChkSpecialStorage.Size = new System.Drawing.Size(128, 17);
            this.ChkSpecialStorage.TabIndex = 39;
            this.ChkSpecialStorage.Text = "Special Storage Days";
            this.ChkSpecialStorage.UseVisualStyleBackColor = true;
            // 
            // PortAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(521, 296);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCust_ID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortAED";
            this.Text = "Port Details";
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
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCust_ID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.CheckBox cbFav;
        private System.Windows.Forms.CheckBox ChkSpecialStorage;
    }
}

