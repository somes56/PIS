namespace PIS
{
    partial class ExportReports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtTeTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DtTeFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateTeusRpt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGenerateK5Rpt = new System.Windows.Forms.Button();
            this.K5ContainerList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtK5SearchContainer = new System.Windows.Forms.TextBox();
            this.lblK4Container = new System.Windows.Forms.Label();
            this.gr = new System.Windows.Forms.GroupBox();
            this.btnGenerateDailyRpt = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.DtDailyFrom = new System.Windows.Forms.DateTimePicker();
            this.DtDailyTo = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.gr);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 727);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtTeTo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DtTeFrom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnGenerateTeusRpt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 68);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "K5 TEUS REPORT";
            // 
            // DtTeTo
            // 
            this.DtTeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtTeTo.Location = new System.Drawing.Point(391, 26);
            this.DtTeTo.Name = "DtTeTo";
            this.DtTeTo.Size = new System.Drawing.Size(197, 20);
            this.DtTeTo.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 128;
            this.label4.Text = "-";
            // 
            // DtTeFrom
            // 
            this.DtTeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtTeFrom.Location = new System.Drawing.Point(169, 26);
            this.DtTeFrom.Name = "DtTeFrom";
            this.DtTeFrom.Size = new System.Drawing.Size(197, 20);
            this.DtTeFrom.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 128;
            this.label3.Text = "Date :";
            // 
            // btnGenerateTeusRpt
            // 
            this.btnGenerateTeusRpt.CausesValidation = false;
            this.btnGenerateTeusRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateTeusRpt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTeusRpt.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerateTeusRpt.Location = new System.Drawing.Point(676, 24);
            this.btnGenerateTeusRpt.Name = "btnGenerateTeusRpt";
            this.btnGenerateTeusRpt.Size = new System.Drawing.Size(75, 29);
            this.btnGenerateTeusRpt.TabIndex = 51;
            this.btnGenerateTeusRpt.Text = "Generate";
            this.btnGenerateTeusRpt.UseVisualStyleBackColor = true;
            this.btnGenerateTeusRpt.Click += new System.EventHandler(this.btnGenerateTeusRpt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGenerateK5Rpt);
            this.groupBox3.Controls.Add(this.K5ContainerList);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtK5SearchContainer);
            this.groupBox3.Controls.Add(this.lblK4Container);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(982, 83);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "K5 COSTING REPORT";
            // 
            // btnGenerateK5Rpt
            // 
            this.btnGenerateK5Rpt.CausesValidation = false;
            this.btnGenerateK5Rpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateK5Rpt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateK5Rpt.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerateK5Rpt.Location = new System.Drawing.Point(676, 40);
            this.btnGenerateK5Rpt.Name = "btnGenerateK5Rpt";
            this.btnGenerateK5Rpt.Size = new System.Drawing.Size(75, 29);
            this.btnGenerateK5Rpt.TabIndex = 51;
            this.btnGenerateK5Rpt.Text = "Generate";
            this.btnGenerateK5Rpt.UseVisualStyleBackColor = true;
            this.btnGenerateK5Rpt.Click += new System.EventHandler(this.btnGenerateK5Rpt_Click);
            // 
            // K5ContainerList
            // 
            this.K5ContainerList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.K5ContainerList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.K5ContainerList.BackColor = System.Drawing.Color.Black;
            this.K5ContainerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.K5ContainerList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K5ContainerList.ForeColor = System.Drawing.Color.Yellow;
            this.K5ContainerList.FormattingEnabled = true;
            this.K5ContainerList.Location = new System.Drawing.Point(350, 44);
            this.K5ContainerList.Name = "K5ContainerList";
            this.K5ContainerList.Size = new System.Drawing.Size(287, 23);
            this.K5ContainerList.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(325, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "---";
            // 
            // txtK5SearchContainer
            // 
            this.txtK5SearchContainer.BackColor = System.Drawing.Color.Black;
            this.txtK5SearchContainer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtK5SearchContainer.ForeColor = System.Drawing.Color.Yellow;
            this.txtK5SearchContainer.Location = new System.Drawing.Point(169, 44);
            this.txtK5SearchContainer.MaxLength = 15;
            this.txtK5SearchContainer.Name = "txtK5SearchContainer";
            this.txtK5SearchContainer.Size = new System.Drawing.Size(150, 23);
            this.txtK5SearchContainer.TabIndex = 51;
            this.txtK5SearchContainer.TextChanged += new System.EventHandler(this.txtK5SearchContainer_TextChanged);
            // 
            // lblK4Container
            // 
            this.lblK4Container.AutoSize = true;
            this.lblK4Container.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblK4Container.Location = new System.Drawing.Point(81, 46);
            this.lblK4Container.Name = "lblK4Container";
            this.lblK4Container.Size = new System.Drawing.Size(82, 16);
            this.lblK4Container.TabIndex = 51;
            this.lblK4Container.Text = "Container :";
            // 
            // gr
            // 
            this.gr.Controls.Add(this.btnGenerateDailyRpt);
            this.gr.Controls.Add(this.lblTo);
            this.gr.Controls.Add(this.lblDate);
            this.gr.Controls.Add(this.DtDailyFrom);
            this.gr.Controls.Add(this.DtDailyTo);
            this.gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr.ForeColor = System.Drawing.Color.White;
            this.gr.Location = new System.Drawing.Point(3, 3);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(982, 97);
            this.gr.TabIndex = 2;
            this.gr.TabStop = false;
            this.gr.Text = "DAILY REPORT";
            // 
            // btnGenerateDailyRpt
            // 
            this.btnGenerateDailyRpt.CausesValidation = false;
            this.btnGenerateDailyRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateDailyRpt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateDailyRpt.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerateDailyRpt.Location = new System.Drawing.Point(676, 39);
            this.btnGenerateDailyRpt.Name = "btnGenerateDailyRpt";
            this.btnGenerateDailyRpt.Size = new System.Drawing.Size(75, 29);
            this.btnGenerateDailyRpt.TabIndex = 103;
            this.btnGenerateDailyRpt.Text = "Generate";
            this.btnGenerateDailyRpt.UseVisualStyleBackColor = true;
            this.btnGenerateDailyRpt.Click += new System.EventHandler(this.btnGenerateDailyRpt_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(372, 45);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(13, 16);
            this.lblTo.TabIndex = 117;
            this.lblTo.Text = "-";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(114, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 16);
            this.lblDate.TabIndex = 116;
            this.lblDate.Text = "Date :";
            // 
            // DtDailyFrom
            // 
            this.DtDailyFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtDailyFrom.Location = new System.Drawing.Point(169, 41);
            this.DtDailyFrom.Name = "DtDailyFrom";
            this.DtDailyFrom.Size = new System.Drawing.Size(197, 20);
            this.DtDailyFrom.TabIndex = 102;
            // 
            // DtDailyTo
            // 
            this.DtDailyTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtDailyTo.Location = new System.Drawing.Point(391, 41);
            this.DtDailyTo.Name = "DtDailyTo";
            this.DtDailyTo.Size = new System.Drawing.Size(197, 20);
            this.DtDailyTo.TabIndex = 111;
            // 
            // ExportReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1012, 751);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportReports";
            this.ShowIcon = false;
            this.Text = "Export Reports";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gr.ResumeLayout(false);
            this.gr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gr;
        private System.Windows.Forms.Button btnGenerateDailyRpt;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker DtDailyFrom;
        private System.Windows.Forms.DateTimePicker DtDailyTo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGenerateK5Rpt;
        private System.Windows.Forms.ComboBox K5ContainerList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtK5SearchContainer;
        private System.Windows.Forms.Label lblK4Container;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DtTeTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtTeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerateTeusRpt;
    }
}