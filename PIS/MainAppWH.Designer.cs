namespace PIS
{
    partial class MainAppWH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppWH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btMasterFile = new System.Windows.Forms.Button();
            this.btnOceanBill = new System.Windows.Forms.Button();
            this.btnUnstuffCargo = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnDebitNotes = new System.Windows.Forms.Button();
            this.btnCreditNotes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btCalTarrif = new System.Windows.Forms.Button();
            this.btnCFS = new System.Windows.Forms.Button();
            this.btnCP = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabImport = new System.Windows.Forms.TabPage();
            this.TabExport = new System.Windows.Forms.TabPage();
            this.btnExportInvoice = new System.Windows.Forms.Button();
            this.buttonExportReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabImport.SuspendLayout();
            this.TabExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIONEERPAC WAREHOUSE SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.Info;
            this.btExit.Location = new System.Drawing.Point(309, 316);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 29);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "&Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btMasterFile
            // 
            this.btMasterFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMasterFile.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMasterFile.ForeColor = System.Drawing.SystemColors.Info;
            this.btMasterFile.Location = new System.Drawing.Point(6, 6);
            this.btMasterFile.Name = "btMasterFile";
            this.btMasterFile.Size = new System.Drawing.Size(75, 44);
            this.btMasterFile.TabIndex = 6;
            this.btMasterFile.Text = "&Master Files";
            this.btMasterFile.UseVisualStyleBackColor = true;
            this.btMasterFile.Click += new System.EventHandler(this.btMasterFile_Click);
            // 
            // btnOceanBill
            // 
            this.btnOceanBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOceanBill.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOceanBill.ForeColor = System.Drawing.SystemColors.Info;
            this.btnOceanBill.Location = new System.Drawing.Point(87, 6);
            this.btnOceanBill.Name = "btnOceanBill";
            this.btnOceanBill.Size = new System.Drawing.Size(75, 44);
            this.btnOceanBill.TabIndex = 7;
            this.btnOceanBill.Text = "&Ocean Bill";
            this.btnOceanBill.UseVisualStyleBackColor = true;
            this.btnOceanBill.Click += new System.EventHandler(this.btnOceanBill_Click);
            // 
            // btnUnstuffCargo
            // 
            this.btnUnstuffCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnstuffCargo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnstuffCargo.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUnstuffCargo.Location = new System.Drawing.Point(168, 6);
            this.btnUnstuffCargo.Name = "btnUnstuffCargo";
            this.btnUnstuffCargo.Size = new System.Drawing.Size(75, 44);
            this.btnUnstuffCargo.TabIndex = 8;
            this.btnUnstuffCargo.Text = "&Unstuff Cargo";
            this.btnUnstuffCargo.UseVisualStyleBackColor = true;
            this.btnUnstuffCargo.Click += new System.EventHandler(this.btnUnstuffCargo_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.SystemColors.Info;
            this.btnInvoice.Location = new System.Drawing.Point(249, 56);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(75, 44);
            this.btnInvoice.TabIndex = 9;
            this.btnInvoice.Text = "&Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnDebitNotes
            // 
            this.btnDebitNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebitNotes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebitNotes.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDebitNotes.Location = new System.Drawing.Point(6, 56);
            this.btnDebitNotes.Name = "btnDebitNotes";
            this.btnDebitNotes.Size = new System.Drawing.Size(75, 44);
            this.btnDebitNotes.TabIndex = 10;
            this.btnDebitNotes.Text = "&Debit Notes";
            this.btnDebitNotes.UseVisualStyleBackColor = true;
            this.btnDebitNotes.Click += new System.EventHandler(this.btnDebitNotes_Click);
            // 
            // btnCreditNotes
            // 
            this.btnCreditNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditNotes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditNotes.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCreditNotes.Location = new System.Drawing.Point(87, 56);
            this.btnCreditNotes.Name = "btnCreditNotes";
            this.btnCreditNotes.Size = new System.Drawing.Size(75, 44);
            this.btnCreditNotes.TabIndex = 11;
            this.btnCreditNotes.Text = "&Credit Notes";
            this.btnCreditNotes.UseVisualStyleBackColor = true;
            this.btnCreditNotes.Click += new System.EventHandler(this.btnCreditNotes_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(168, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Search Container";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.Info;
            this.btnReports.Location = new System.Drawing.Point(249, 6);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(75, 44);
            this.btnReports.TabIndex = 13;
            this.btnReports.Text = "&Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btCalTarrif
            // 
            this.btCalTarrif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalTarrif.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalTarrif.ForeColor = System.Drawing.SystemColors.Info;
            this.btCalTarrif.Location = new System.Drawing.Point(6, 106);
            this.btCalTarrif.Name = "btCalTarrif";
            this.btCalTarrif.Size = new System.Drawing.Size(75, 44);
            this.btCalTarrif.TabIndex = 16;
            this.btCalTarrif.Text = "&Tariff";
            this.btCalTarrif.UseVisualStyleBackColor = true;
            this.btCalTarrif.Click += new System.EventHandler(this.btCalTarrif_Click);
            // 
            // btnCFS
            // 
            this.btnCFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCFS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCFS.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCFS.Location = new System.Drawing.Point(6, 6);
            this.btnCFS.Name = "btnCFS";
            this.btnCFS.Size = new System.Drawing.Size(75, 44);
            this.btnCFS.TabIndex = 17;
            this.btnCFS.Text = "C&FS";
            this.btnCFS.UseVisualStyleBackColor = true;
            this.btnCFS.Click += new System.EventHandler(this.btnCFS_Click);
            // 
            // btnCP
            // 
            this.btnCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCP.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCP.Location = new System.Drawing.Point(87, 6);
            this.btnCP.Name = "btnCP";
            this.btnCP.Size = new System.Drawing.Size(75, 44);
            this.btnCP.TabIndex = 18;
            this.btnCP.Text = "Container &Packing";
            this.btnCP.UseVisualStyleBackColor = true;
            this.btnCP.Click += new System.EventHandler(this.btnCP_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabImport);
            this.tabControl1.Controls.Add(this.TabExport);
            this.tabControl1.Location = new System.Drawing.Point(12, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 192);
            this.tabControl1.TabIndex = 19;
            // 
            // TabImport
            // 
            this.TabImport.BackColor = System.Drawing.Color.RoyalBlue;
            this.TabImport.Controls.Add(this.btMasterFile);
            this.TabImport.Controls.Add(this.btnDebitNotes);
            this.TabImport.Controls.Add(this.btCalTarrif);
            this.TabImport.Controls.Add(this.btnReports);
            this.TabImport.Controls.Add(this.btnInvoice);
            this.TabImport.Controls.Add(this.button1);
            this.TabImport.Controls.Add(this.btnOceanBill);
            this.TabImport.Controls.Add(this.btnCreditNotes);
            this.TabImport.Controls.Add(this.btnUnstuffCargo);
            this.TabImport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TabImport.Location = new System.Drawing.Point(4, 22);
            this.TabImport.Name = "TabImport";
            this.TabImport.Padding = new System.Windows.Forms.Padding(3);
            this.TabImport.Size = new System.Drawing.Size(364, 166);
            this.TabImport.TabIndex = 0;
            this.TabImport.Text = "Import";
            // 
            // TabExport
            // 
            this.TabExport.BackColor = System.Drawing.Color.RoyalBlue;
            this.TabExport.Controls.Add(this.buttonExportReport);
            this.TabExport.Controls.Add(this.btnExportInvoice);
            this.TabExport.Controls.Add(this.btnCP);
            this.TabExport.Controls.Add(this.btnCFS);
            this.TabExport.Location = new System.Drawing.Point(4, 22);
            this.TabExport.Name = "TabExport";
            this.TabExport.Padding = new System.Windows.Forms.Padding(3);
            this.TabExport.Size = new System.Drawing.Size(364, 166);
            this.TabExport.TabIndex = 1;
            this.TabExport.Text = "Export";
            // 
            // btnExportInvoice
            // 
            this.btnExportInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportInvoice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportInvoice.ForeColor = System.Drawing.SystemColors.Info;
            this.btnExportInvoice.Location = new System.Drawing.Point(168, 6);
            this.btnExportInvoice.Name = "btnExportInvoice";
            this.btnExportInvoice.Size = new System.Drawing.Size(75, 44);
            this.btnExportInvoice.TabIndex = 19;
            this.btnExportInvoice.Text = "&Invoice";
            this.btnExportInvoice.UseVisualStyleBackColor = true;
            this.btnExportInvoice.Click += new System.EventHandler(this.btnExportInvoice_Click);
            // 
            // buttonExportReport
            // 
            this.buttonExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportReport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportReport.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonExportReport.Location = new System.Drawing.Point(249, 6);
            this.buttonExportReport.Name = "buttonExportReport";
            this.buttonExportReport.Size = new System.Drawing.Size(75, 44);
            this.buttonExportReport.TabIndex = 20;
            this.buttonExportReport.Text = "&Reports";
            this.buttonExportReport.UseVisualStyleBackColor = true;
            this.buttonExportReport.Click += new System.EventHandler(this.buttonExportReport_Click);
            // 
            // MainAppWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(407, 350);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MainAppWH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PioneerPac Integrated System";
            this.Load += new System.EventHandler(this.MainAppWH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabImport.ResumeLayout(false);
            this.TabExport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btMasterFile;
        private System.Windows.Forms.Button btnOceanBill;
        private System.Windows.Forms.Button btnUnstuffCargo;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnDebitNotes;
        private System.Windows.Forms.Button btnCreditNotes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btCalTarrif;
        private System.Windows.Forms.Button btnCFS;
        private System.Windows.Forms.Button btnCP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabImport;
        private System.Windows.Forms.TabPage TabExport;
        private System.Windows.Forms.Button btnExportInvoice;
        private System.Windows.Forms.Button buttonExportReport;
    }
}

