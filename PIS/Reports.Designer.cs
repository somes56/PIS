namespace PIS
{
    partial class Reports
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AgentList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSearchAgent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DtUcTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DtUcFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerateUncollectedCargoRpt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtTeTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DtTeFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateTeusRpt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGenerateK4Rpt = new System.Windows.Forms.Button();
            this.K4ContainerList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtK4SearchContainer = new System.Windows.Forms.TextBox();
            this.lblK4Container = new System.Windows.Forms.Label();
            this.gr = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbCrdt = new System.Windows.Forms.RadioButton();
            this.rbOnline = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbInvoice = new System.Windows.Forms.RadioButton();
            this.rbDebit = new System.Windows.Forms.RadioButton();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.CustomerList = new System.Windows.Forms.ComboBox();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnGenerateARRpt = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRpt = new System.Windows.Forms.Label();
            this.DtARFrom = new System.Windows.Forms.DateTimePicker();
            this.DtARTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateActivityRpt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ActivityContainerList = new System.Windows.Forms.ComboBox();
            this.txtActivitySearchContainer = new System.Windows.Forms.TextBox();
            this.lblActivityContainer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gr.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.gr);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 723);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AgentList);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.TxtSearchAgent);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.DtUcTo);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.DtUcFrom);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnGenerateUncollectedCargoRpt);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 502);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(978, 98);
            this.groupBox4.TabIndex = 129;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UNCOLLECTED CARGOES REPORT";
            // 
            // AgentList
            // 
            this.AgentList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AgentList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AgentList.BackColor = System.Drawing.Color.Black;
            this.AgentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgentList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentList.ForeColor = System.Drawing.Color.Yellow;
            this.AgentList.FormattingEnabled = true;
            this.AgentList.Location = new System.Drawing.Point(389, 60);
            this.AgentList.Name = "AgentList";
            this.AgentList.Size = new System.Drawing.Size(248, 23);
            this.AgentList.TabIndex = 128;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(370, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 128;
            this.label9.Text = "-";
            // 
            // TxtSearchAgent
            // 
            this.TxtSearchAgent.BackColor = System.Drawing.Color.Black;
            this.TxtSearchAgent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchAgent.ForeColor = System.Drawing.Color.Yellow;
            this.TxtSearchAgent.Location = new System.Drawing.Point(167, 60);
            this.TxtSearchAgent.MaxLength = 15;
            this.TxtSearchAgent.Name = "TxtSearchAgent";
            this.TxtSearchAgent.Size = new System.Drawing.Size(197, 23);
            this.TxtSearchAgent.TabIndex = 128;
            this.TxtSearchAgent.TextChanged += new System.EventHandler(this.TxtSearchAgent_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 128;
            this.label8.Text = "Customer :";
            // 
            // DtUcTo
            // 
            this.DtUcTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtUcTo.Location = new System.Drawing.Point(391, 26);
            this.DtUcTo.Name = "DtUcTo";
            this.DtUcTo.Size = new System.Drawing.Size(197, 20);
            this.DtUcTo.TabIndex = 128;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 128;
            this.label5.Text = "-";
            // 
            // DtUcFrom
            // 
            this.DtUcFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtUcFrom.Location = new System.Drawing.Point(169, 26);
            this.DtUcFrom.Name = "DtUcFrom";
            this.DtUcFrom.Size = new System.Drawing.Size(197, 20);
            this.DtUcFrom.TabIndex = 128;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 128;
            this.label7.Text = "Date :";
            // 
            // btnGenerateUncollectedCargoRpt
            // 
            this.btnGenerateUncollectedCargoRpt.CausesValidation = false;
            this.btnGenerateUncollectedCargoRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateUncollectedCargoRpt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateUncollectedCargoRpt.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerateUncollectedCargoRpt.Location = new System.Drawing.Point(676, 24);
            this.btnGenerateUncollectedCargoRpt.Name = "btnGenerateUncollectedCargoRpt";
            this.btnGenerateUncollectedCargoRpt.Size = new System.Drawing.Size(75, 29);
            this.btnGenerateUncollectedCargoRpt.TabIndex = 51;
            this.btnGenerateUncollectedCargoRpt.Text = "Generate";
            this.btnGenerateUncollectedCargoRpt.UseVisualStyleBackColor = true;
            this.btnGenerateUncollectedCargoRpt.Click += new System.EventHandler(this.btnGenerateUncollectedCargoRpt_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(3, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 68);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "K4 TEUS REPORT";
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
            this.groupBox3.Controls.Add(this.btnGenerateK4Rpt);
            this.groupBox3.Controls.Add(this.K4ContainerList);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtK4SearchContainer);
            this.groupBox3.Controls.Add(this.lblK4Container);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(978, 83);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "K4 COSTING REPORT";
            // 
            // btnGenerateK4Rpt
            // 
            this.btnGenerateK4Rpt.CausesValidation = false;
            this.btnGenerateK4Rpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateK4Rpt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateK4Rpt.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerateK4Rpt.Location = new System.Drawing.Point(676, 40);
            this.btnGenerateK4Rpt.Name = "btnGenerateK4Rpt";
            this.btnGenerateK4Rpt.Size = new System.Drawing.Size(75, 29);
            this.btnGenerateK4Rpt.TabIndex = 51;
            this.btnGenerateK4Rpt.Text = "Generate";
            this.btnGenerateK4Rpt.UseVisualStyleBackColor = true;
            this.btnGenerateK4Rpt.Click += new System.EventHandler(this.btnGenerateK4Rpt_Click);
            // 
            // K4ContainerList
            // 
            this.K4ContainerList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.K4ContainerList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.K4ContainerList.BackColor = System.Drawing.Color.Black;
            this.K4ContainerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.K4ContainerList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K4ContainerList.ForeColor = System.Drawing.Color.Yellow;
            this.K4ContainerList.FormattingEnabled = true;
            this.K4ContainerList.Location = new System.Drawing.Point(350, 44);
            this.K4ContainerList.Name = "K4ContainerList";
            this.K4ContainerList.Size = new System.Drawing.Size(287, 23);
            this.K4ContainerList.TabIndex = 51;
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
            // txtK4SearchContainer
            // 
            this.txtK4SearchContainer.BackColor = System.Drawing.Color.Black;
            this.txtK4SearchContainer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtK4SearchContainer.ForeColor = System.Drawing.Color.Yellow;
            this.txtK4SearchContainer.Location = new System.Drawing.Point(169, 44);
            this.txtK4SearchContainer.MaxLength = 15;
            this.txtK4SearchContainer.Name = "txtK4SearchContainer";
            this.txtK4SearchContainer.Size = new System.Drawing.Size(150, 23);
            this.txtK4SearchContainer.TabIndex = 51;
            this.txtK4SearchContainer.TextChanged += new System.EventHandler(this.txtK4SearchContainer_TextChanged);
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
            this.gr.Controls.Add(this.panel3);
            this.gr.Controls.Add(this.panel2);
            this.gr.Controls.Add(this.label1);
            this.gr.Controls.Add(this.lblCustomer);
            this.gr.Controls.Add(this.CustomerList);
            this.gr.Controls.Add(this.txtSearchCust);
            this.gr.Controls.Add(this.lblPayment);
            this.gr.Controls.Add(this.btnGenerateARRpt);
            this.gr.Controls.Add(this.lblTo);
            this.gr.Controls.Add(this.lblDate);
            this.gr.Controls.Add(this.lblRpt);
            this.gr.Controls.Add(this.DtARFrom);
            this.gr.Controls.Add(this.DtARTo);
            this.gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr.ForeColor = System.Drawing.Color.White;
            this.gr.Location = new System.Drawing.Point(3, 86);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(978, 247);
            this.gr.TabIndex = 1;
            this.gr.TabStop = false;
            this.gr.Text = "AR AUDIT REPORT";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbAll);
            this.panel3.Controls.Add(this.rbCrdt);
            this.panel3.Controls.Add(this.rbOnline);
            this.panel3.Controls.Add(this.rbCash);
            this.panel3.Controls.Add(this.rbCheque);
            this.panel3.Location = new System.Drawing.Point(169, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 23);
            this.panel3.TabIndex = 127;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(3, 3);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(39, 17);
            this.rbAll.TabIndex = 121;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbCrdt
            // 
            this.rbCrdt.AutoSize = true;
            this.rbCrdt.Location = new System.Drawing.Point(181, 3);
            this.rbCrdt.Name = "rbCrdt";
            this.rbCrdt.Size = new System.Drawing.Size(58, 17);
            this.rbCrdt.TabIndex = 124;
            this.rbCrdt.Text = "Credit";
            this.rbCrdt.UseVisualStyleBackColor = true;
            // 
            // rbOnline
            // 
            this.rbOnline.AutoSize = true;
            this.rbOnline.Location = new System.Drawing.Point(245, 3);
            this.rbOnline.Name = "rbOnline";
            this.rbOnline.Size = new System.Drawing.Size(112, 17);
            this.rbOnline.TabIndex = 125;
            this.rbOnline.Text = "Online Transfer";
            this.rbOnline.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(48, 3);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(53, 17);
            this.rbCash.TabIndex = 122;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Location = new System.Drawing.Point(107, 3);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(68, 17);
            this.rbCheque.TabIndex = 123;
            this.rbCheque.Text = "Cheque";
            this.rbCheque.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbInvoice);
            this.panel2.Controls.Add(this.rbDebit);
            this.panel2.Controls.Add(this.rbCredit);
            this.panel2.Location = new System.Drawing.Point(169, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 23);
            this.panel2.TabIndex = 126;
            // 
            // rbInvoice
            // 
            this.rbInvoice.AutoSize = true;
            this.rbInvoice.Checked = true;
            this.rbInvoice.Location = new System.Drawing.Point(3, 3);
            this.rbInvoice.Name = "rbInvoice";
            this.rbInvoice.Size = new System.Drawing.Size(67, 17);
            this.rbInvoice.TabIndex = 113;
            this.rbInvoice.TabStop = true;
            this.rbInvoice.Text = "Invoice";
            this.rbInvoice.UseVisualStyleBackColor = true;
            this.rbInvoice.CheckedChanged += new System.EventHandler(this.rbInvoice_CheckedChanged);
            // 
            // rbDebit
            // 
            this.rbDebit.AutoSize = true;
            this.rbDebit.Location = new System.Drawing.Point(76, 3);
            this.rbDebit.Name = "rbDebit";
            this.rbDebit.Size = new System.Drawing.Size(55, 17);
            this.rbDebit.TabIndex = 114;
            this.rbDebit.Text = "Debit";
            this.rbDebit.UseVisualStyleBackColor = true;
            this.rbDebit.CheckedChanged += new System.EventHandler(this.rbDebit_CheckedChanged);
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Location = new System.Drawing.Point(137, 3);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(58, 17);
            this.rbCredit.TabIndex = 115;
            this.rbCredit.Text = "Credit";
            this.rbCredit.UseVisualStyleBackColor = true;
            this.rbCredit.CheckedChanged += new System.EventHandler(this.rbCredit_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 119;
            this.label1.Text = "-";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(82, 183);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(81, 16);
            this.lblCustomer.TabIndex = 118;
            this.lblCustomer.Text = "Customer :";
            // 
            // CustomerList
            // 
            this.CustomerList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustomerList.BackColor = System.Drawing.Color.Black;
            this.CustomerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerList.ForeColor = System.Drawing.Color.Yellow;
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.Location = new System.Drawing.Point(391, 181);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(246, 23);
            this.CustomerList.TabIndex = 51;
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.BackColor = System.Drawing.Color.Black;
            this.txtSearchCust.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCust.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchCust.Location = new System.Drawing.Point(169, 181);
            this.txtSearchCust.MaxLength = 15;
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(197, 23);
            this.txtSearchCust.TabIndex = 51;
            this.txtSearchCust.TextChanged += new System.EventHandler(this.txtSearchCust_TextChanged);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(87, 132);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(76, 16);
            this.lblPayment.TabIndex = 120;
            this.lblPayment.Text = "Payment :";
            // 
            // btnGenerateARRpt
            // 
            this.btnGenerateARRpt.CausesValidation = false;
            this.btnGenerateARRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateARRpt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateARRpt.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerateARRpt.Location = new System.Drawing.Point(676, 119);
            this.btnGenerateARRpt.Name = "btnGenerateARRpt";
            this.btnGenerateARRpt.Size = new System.Drawing.Size(75, 29);
            this.btnGenerateARRpt.TabIndex = 103;
            this.btnGenerateARRpt.Text = "Generate";
            this.btnGenerateARRpt.UseVisualStyleBackColor = true;
            this.btnGenerateARRpt.Click += new System.EventHandler(this.btnGenerateARRpt_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(372, 87);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(13, 16);
            this.lblTo.TabIndex = 117;
            this.lblTo.Text = "-";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(114, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 16);
            this.lblDate.TabIndex = 116;
            this.lblDate.Text = "Date :";
            // 
            // lblRpt
            // 
            this.lblRpt.AutoSize = true;
            this.lblRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRpt.Location = new System.Drawing.Point(100, 35);
            this.lblRpt.Name = "lblRpt";
            this.lblRpt.Size = new System.Drawing.Size(63, 16);
            this.lblRpt.TabIndex = 112;
            this.lblRpt.Text = "Report :";
            // 
            // DtARFrom
            // 
            this.DtARFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtARFrom.Location = new System.Drawing.Point(169, 83);
            this.DtARFrom.Name = "DtARFrom";
            this.DtARFrom.Size = new System.Drawing.Size(197, 20);
            this.DtARFrom.TabIndex = 102;
            // 
            // DtARTo
            // 
            this.DtARTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtARTo.Location = new System.Drawing.Point(391, 83);
            this.DtARTo.Name = "DtARTo";
            this.DtARTo.Size = new System.Drawing.Size(197, 20);
            this.DtARTo.TabIndex = 111;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateActivityRpt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ActivityContainerList);
            this.groupBox1.Controls.Add(this.txtActivitySearchContainer);
            this.groupBox1.Controls.Add(this.lblActivityContainer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACTIVITY REPORT";
            // 
            // btnGenerateActivityRpt
            // 
            this.btnGenerateActivityRpt.CausesValidation = false;
            this.btnGenerateActivityRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateActivityRpt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateActivityRpt.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerateActivityRpt.Location = new System.Drawing.Point(676, 37);
            this.btnGenerateActivityRpt.Name = "btnGenerateActivityRpt";
            this.btnGenerateActivityRpt.Size = new System.Drawing.Size(75, 29);
            this.btnGenerateActivityRpt.TabIndex = 50;
            this.btnGenerateActivityRpt.Text = "Generate";
            this.btnGenerateActivityRpt.UseVisualStyleBackColor = true;
            this.btnGenerateActivityRpt.Click += new System.EventHandler(this.btnGenerateActivityRpt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(325, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "---";
            // 
            // ActivityContainerList
            // 
            this.ActivityContainerList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ActivityContainerList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ActivityContainerList.BackColor = System.Drawing.Color.Black;
            this.ActivityContainerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActivityContainerList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityContainerList.ForeColor = System.Drawing.Color.Yellow;
            this.ActivityContainerList.FormattingEnabled = true;
            this.ActivityContainerList.Location = new System.Drawing.Point(350, 37);
            this.ActivityContainerList.Name = "ActivityContainerList";
            this.ActivityContainerList.Size = new System.Drawing.Size(287, 23);
            this.ActivityContainerList.TabIndex = 47;
            // 
            // txtActivitySearchContainer
            // 
            this.txtActivitySearchContainer.BackColor = System.Drawing.Color.Black;
            this.txtActivitySearchContainer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivitySearchContainer.ForeColor = System.Drawing.Color.Yellow;
            this.txtActivitySearchContainer.Location = new System.Drawing.Point(169, 34);
            this.txtActivitySearchContainer.MaxLength = 15;
            this.txtActivitySearchContainer.Name = "txtActivitySearchContainer";
            this.txtActivitySearchContainer.Size = new System.Drawing.Size(150, 23);
            this.txtActivitySearchContainer.TabIndex = 23;
            this.txtActivitySearchContainer.TextChanged += new System.EventHandler(this.txtActivitySearchContainer_TextChanged);
            // 
            // lblActivityContainer
            // 
            this.lblActivityContainer.AutoSize = true;
            this.lblActivityContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityContainer.Location = new System.Drawing.Point(81, 34);
            this.lblActivityContainer.Name = "lblActivityContainer";
            this.lblActivityContainer.Size = new System.Drawing.Size(82, 16);
            this.lblActivityContainer.TabIndex = 2;
            this.lblActivityContainer.Text = "Container :";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1008, 747);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reports";
            this.ShowIcon = false;
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gr.ResumeLayout(false);
            this.gr.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gr;
        private System.Windows.Forms.Label lblActivityContainer;
        private System.Windows.Forms.TextBox txtActivitySearchContainer;
        private System.Windows.Forms.ComboBox ActivityContainerList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerateActivityRpt;
        private System.Windows.Forms.Button btnGenerateK4Rpt;
        private System.Windows.Forms.ComboBox K4ContainerList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtK4SearchContainer;
        private System.Windows.Forms.Label lblK4Container;
        private System.Windows.Forms.Button btnGenerateARRpt;
        private System.Windows.Forms.DateTimePicker DtARFrom;
        private System.Windows.Forms.DateTimePicker DtARTo;
        private System.Windows.Forms.ComboBox CustomerList;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rbDebit;
        private System.Windows.Forms.RadioButton rbInvoice;
        private System.Windows.Forms.Label lblRpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.RadioButton rbOnline;
        private System.Windows.Forms.RadioButton rbCrdt;
        private System.Windows.Forms.RadioButton rbCheque;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerateTeusRpt;
        private System.Windows.Forms.DateTimePicker DtTeTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtTeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox AgentList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSearchAgent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtUcTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtUcFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerateUncollectedCargoRpt;
    }
}