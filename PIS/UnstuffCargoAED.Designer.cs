namespace PIS
{
    partial class UnstuffCargoAED
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnstuffCargoAED));
            this.lblCont = new System.Windows.Forms.Label();
            this.lblContID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrintTally = new System.Windows.Forms.Button();
            this.GroupBoxHBL = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.PortList = new System.Windows.Forms.ComboBox();
            this.txtSearchPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbInwardSurveyYes = new System.Windows.Forms.RadioButton();
            this.rbInwardSurveyNo = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbShipmentYes = new System.Windows.Forms.RadioButton();
            this.rbShipmentNo = new System.Windows.Forms.RadioButton();
            this.txtPackaging = new System.Windows.Forms.TextBox();
            this.lblPackaging = new System.Windows.Forms.Label();
            this.txtMarking = new System.Windows.Forms.TextBox();
            this.lblOBLID = new System.Windows.Forms.Label();
            this.lblOBL = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblInwardSurvey = new System.Windows.Forms.Label();
            this.lblCargoDesc = new System.Windows.Forms.Label();
            this.lblSysCargoDesc = new System.Windows.Forms.Label();
            this.lblSysTranshipment = new System.Windows.Forms.Label();
            this.lblSysMarking = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblSysWeight = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblSysVolume = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblSysQty = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblSysClass = new System.Windows.Forms.Label();
            this.lblConsigneeID = new System.Windows.Forms.Label();
            this.lblConsignee = new System.Windows.Forms.Label();
            this.lblSysConsignee = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.lblSysUnit = new System.Windows.Forms.Label();
            this.lblHouseBillNo = new System.Windows.Forms.Label();
            this.lblSysHouseBillNo = new System.Windows.Forms.Label();
            this.lblHBLID = new System.Windows.Forms.Label();
            this.lblHBL = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.ChkUnstuff = new System.Windows.Forms.CheckBox();
            this.lblUnstuff = new System.Windows.Forms.Label();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.DtUnstuff = new System.Windows.Forms.DateTimePicker();
            this.lblUnstuffDate = new System.Windows.Forms.Label();
            this.txtContainerNo = new System.Windows.Forms.TextBox();
            this.lblContainerNo = new System.Windows.Forms.Label();
            this.lblSysOBL = new System.Windows.Forms.Label();
            this.lblSysOBLID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GroupBoxHBL.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.pnlSave.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCont.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCont.Location = new System.Drawing.Point(12, 9);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(54, 15);
            this.lblCont.TabIndex = 19;
            this.lblCont.Tag = "cv";
            this.lblCont.Text = "Cont ID :";
            this.lblCont.Visible = false;
            // 
            // lblContID
            // 
            this.lblContID.AutoSize = true;
            this.lblContID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblContID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContID.ForeColor = System.Drawing.Color.White;
            this.lblContID.Location = new System.Drawing.Point(72, 9);
            this.lblContID.Name = "lblContID";
            this.lblContID.Size = new System.Drawing.Size(14, 15);
            this.lblContID.TabIndex = 20;
            this.lblContID.Text = "1";
            this.lblContID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrintTally);
            this.panel1.Controls.Add(this.GroupBoxHBL);
            this.panel1.Controls.Add(this.ChkUnstuff);
            this.panel1.Controls.Add(this.lblUnstuff);
            this.panel1.Controls.Add(this.pnlSave);
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Controls.Add(this.DtUnstuff);
            this.panel1.Controls.Add(this.lblUnstuffDate);
            this.panel1.Controls.Add(this.txtContainerNo);
            this.panel1.Controls.Add(this.lblContainerNo);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 687);
            this.panel1.TabIndex = 21;
            // 
            // btnPrintTally
            // 
            this.btnPrintTally.CausesValidation = false;
            this.btnPrintTally.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTally.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTally.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPrintTally.Location = new System.Drawing.Point(902, 141);
            this.btnPrintTally.Name = "btnPrintTally";
            this.btnPrintTally.Size = new System.Drawing.Size(75, 29);
            this.btnPrintTally.TabIndex = 105;
            this.btnPrintTally.Text = "Tally Sheet";
            this.btnPrintTally.UseVisualStyleBackColor = true;
            this.btnPrintTally.Click += new System.EventHandler(this.btnPrintTally_Click);
            // 
            // GroupBoxHBL
            // 
            this.GroupBoxHBL.Controls.Add(this.txtLocation);
            this.GroupBoxHBL.Controls.Add(this.PortList);
            this.GroupBoxHBL.Controls.Add(this.txtSearchPort);
            this.GroupBoxHBL.Controls.Add(this.lblPort);
            this.GroupBoxHBL.Controls.Add(this.panel3);
            this.GroupBoxHBL.Controls.Add(this.panel2);
            this.GroupBoxHBL.Controls.Add(this.txtPackaging);
            this.GroupBoxHBL.Controls.Add(this.lblPackaging);
            this.GroupBoxHBL.Controls.Add(this.txtMarking);
            this.GroupBoxHBL.Controls.Add(this.lblOBLID);
            this.GroupBoxHBL.Controls.Add(this.lblOBL);
            this.GroupBoxHBL.Controls.Add(this.btnAdd);
            this.GroupBoxHBL.Controls.Add(this.lblLocation);
            this.GroupBoxHBL.Controls.Add(this.lblRemarks);
            this.GroupBoxHBL.Controls.Add(this.txtRemarks);
            this.GroupBoxHBL.Controls.Add(this.lblInwardSurvey);
            this.GroupBoxHBL.Controls.Add(this.lblCargoDesc);
            this.GroupBoxHBL.Controls.Add(this.lblSysCargoDesc);
            this.GroupBoxHBL.Controls.Add(this.lblSysTranshipment);
            this.GroupBoxHBL.Controls.Add(this.lblSysMarking);
            this.GroupBoxHBL.Controls.Add(this.lblWeight);
            this.GroupBoxHBL.Controls.Add(this.lblSysWeight);
            this.GroupBoxHBL.Controls.Add(this.lblVolume);
            this.GroupBoxHBL.Controls.Add(this.lblSysVolume);
            this.GroupBoxHBL.Controls.Add(this.lblQty);
            this.GroupBoxHBL.Controls.Add(this.lblSysQty);
            this.GroupBoxHBL.Controls.Add(this.lblClassID);
            this.GroupBoxHBL.Controls.Add(this.lblClass);
            this.GroupBoxHBL.Controls.Add(this.lblSysClass);
            this.GroupBoxHBL.Controls.Add(this.lblConsigneeID);
            this.GroupBoxHBL.Controls.Add(this.lblConsignee);
            this.GroupBoxHBL.Controls.Add(this.lblSysConsignee);
            this.GroupBoxHBL.Controls.Add(this.lblUnitID);
            this.GroupBoxHBL.Controls.Add(this.lblUnitName);
            this.GroupBoxHBL.Controls.Add(this.lblSysUnit);
            this.GroupBoxHBL.Controls.Add(this.lblHouseBillNo);
            this.GroupBoxHBL.Controls.Add(this.lblSysHouseBillNo);
            this.GroupBoxHBL.Controls.Add(this.lblHBLID);
            this.GroupBoxHBL.Controls.Add(this.lblHBL);
            this.GroupBoxHBL.Controls.Add(this.dgvBill);
            this.GroupBoxHBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxHBL.ForeColor = System.Drawing.Color.White;
            this.GroupBoxHBL.Location = new System.Drawing.Point(3, 176);
            this.GroupBoxHBL.Name = "GroupBoxHBL";
            this.GroupBoxHBL.Size = new System.Drawing.Size(974, 508);
            this.GroupBoxHBL.TabIndex = 104;
            this.GroupBoxHBL.TabStop = false;
            this.GroupBoxHBL.Text = "HOUSE BILL";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.Black;
            this.txtLocation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.ForeColor = System.Drawing.Color.Yellow;
            this.txtLocation.Location = new System.Drawing.Point(743, 234);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(223, 102);
            this.txtLocation.TabIndex = 12;
            // 
            // PortList
            // 
            this.PortList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PortList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PortList.BackColor = System.Drawing.Color.Black;
            this.PortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortList.ForeColor = System.Drawing.Color.Yellow;
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(827, 160);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(141, 23);
            this.PortList.TabIndex = 10;
            // 
            // txtSearchPort
            // 
            this.txtSearchPort.BackColor = System.Drawing.Color.Black;
            this.txtSearchPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPort.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchPort.Location = new System.Drawing.Point(738, 160);
            this.txtSearchPort.MaxLength = 15;
            this.txtSearchPort.Name = "txtSearchPort";
            this.txtSearchPort.ReadOnly = true;
            this.txtSearchPort.Size = new System.Drawing.Size(83, 23);
            this.txtSearchPort.TabIndex = 9;
            this.txtSearchPort.Leave += new System.EventHandler(this.txtSearchPort_Leave);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(688, 162);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(44, 16);
            this.lblPort.TabIndex = 127;
            this.lblPort.Text = "Port :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbInwardSurveyYes);
            this.panel3.Controls.Add(this.rbInwardSurveyNo);
            this.panel3.Location = new System.Drawing.Point(389, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 29);
            this.panel3.TabIndex = 7;
            // 
            // rbInwardSurveyYes
            // 
            this.rbInwardSurveyYes.AutoSize = true;
            this.rbInwardSurveyYes.Checked = true;
            this.rbInwardSurveyYes.ForeColor = System.Drawing.Color.White;
            this.rbInwardSurveyYes.Location = new System.Drawing.Point(64, 8);
            this.rbInwardSurveyYes.Name = "rbInwardSurveyYes";
            this.rbInwardSurveyYes.Size = new System.Drawing.Size(46, 17);
            this.rbInwardSurveyYes.TabIndex = 107;
            this.rbInwardSurveyYes.TabStop = true;
            this.rbInwardSurveyYes.Text = "Yes";
            this.rbInwardSurveyYes.UseVisualStyleBackColor = true;
            // 
            // rbInwardSurveyNo
            // 
            this.rbInwardSurveyNo.AutoSize = true;
            this.rbInwardSurveyNo.ForeColor = System.Drawing.Color.White;
            this.rbInwardSurveyNo.Location = new System.Drawing.Point(12, 8);
            this.rbInwardSurveyNo.Name = "rbInwardSurveyNo";
            this.rbInwardSurveyNo.Size = new System.Drawing.Size(41, 17);
            this.rbInwardSurveyNo.TabIndex = 107;
            this.rbInwardSurveyNo.Text = "No";
            this.rbInwardSurveyNo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbShipmentYes);
            this.panel2.Controls.Add(this.rbShipmentNo);
            this.panel2.Location = new System.Drawing.Point(389, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 29);
            this.panel2.TabIndex = 6;
            // 
            // rbShipmentYes
            // 
            this.rbShipmentYes.AutoSize = true;
            this.rbShipmentYes.ForeColor = System.Drawing.Color.White;
            this.rbShipmentYes.Location = new System.Drawing.Point(64, 9);
            this.rbShipmentYes.Name = "rbShipmentYes";
            this.rbShipmentYes.Size = new System.Drawing.Size(46, 17);
            this.rbShipmentYes.TabIndex = 119;
            this.rbShipmentYes.Text = "Yes";
            this.rbShipmentYes.UseVisualStyleBackColor = true;
            this.rbShipmentYes.CheckedChanged += new System.EventHandler(this.rbShipmentYes_CheckedChanged);
            // 
            // rbShipmentNo
            // 
            this.rbShipmentNo.AutoSize = true;
            this.rbShipmentNo.Checked = true;
            this.rbShipmentNo.ForeColor = System.Drawing.Color.White;
            this.rbShipmentNo.Location = new System.Drawing.Point(12, 9);
            this.rbShipmentNo.Name = "rbShipmentNo";
            this.rbShipmentNo.Size = new System.Drawing.Size(41, 17);
            this.rbShipmentNo.TabIndex = 120;
            this.rbShipmentNo.TabStop = true;
            this.rbShipmentNo.Text = "No";
            this.rbShipmentNo.UseVisualStyleBackColor = true;
            // 
            // txtPackaging
            // 
            this.txtPackaging.BackColor = System.Drawing.Color.Black;
            this.txtPackaging.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackaging.ForeColor = System.Drawing.Color.Yellow;
            this.txtPackaging.Location = new System.Drawing.Point(743, 363);
            this.txtPackaging.MaxLength = 100000000;
            this.txtPackaging.Multiline = true;
            this.txtPackaging.Name = "txtPackaging";
            this.txtPackaging.Size = new System.Drawing.Size(225, 103);
            this.txtPackaging.TabIndex = 13;
            this.txtPackaging.TextChanged += new System.EventHandler(this.txtPackaging_TextChanged);
            // 
            // lblPackaging
            // 
            this.lblPackaging.AutoSize = true;
            this.lblPackaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackaging.ForeColor = System.Drawing.Color.White;
            this.lblPackaging.Location = new System.Drawing.Point(642, 365);
            this.lblPackaging.Name = "lblPackaging";
            this.lblPackaging.Size = new System.Drawing.Size(90, 16);
            this.lblPackaging.TabIndex = 122;
            this.lblPackaging.Text = "Packaging :";
            // 
            // txtMarking
            // 
            this.txtMarking.BackColor = System.Drawing.Color.Black;
            this.txtMarking.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarking.ForeColor = System.Drawing.Color.Yellow;
            this.txtMarking.Location = new System.Drawing.Point(389, 398);
            this.txtMarking.MaxLength = 100000000;
            this.txtMarking.Multiline = true;
            this.txtMarking.Name = "txtMarking";
            this.txtMarking.Size = new System.Drawing.Size(225, 103);
            this.txtMarking.TabIndex = 11;
            // 
            // lblOBLID
            // 
            this.lblOBLID.AutoSize = true;
            this.lblOBLID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblOBLID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBLID.ForeColor = System.Drawing.Color.White;
            this.lblOBLID.Location = new System.Drawing.Point(738, 19);
            this.lblOBLID.Name = "lblOBLID";
            this.lblOBLID.Size = new System.Drawing.Size(14, 15);
            this.lblOBLID.TabIndex = 118;
            this.lblOBLID.Text = "1";
            this.lblOBLID.Visible = false;
            // 
            // lblOBL
            // 
            this.lblOBL.AutoSize = true;
            this.lblOBL.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBL.ForeColor = System.Drawing.SystemColors.Info;
            this.lblOBL.Location = new System.Drawing.Point(682, 19);
            this.lblOBL.Name = "lblOBL";
            this.lblOBL.Size = new System.Drawing.Size(50, 15);
            this.lblOBL.TabIndex = 117;
            this.lblOBL.Tag = "cv";
            this.lblOBL.Text = "OBL ID :";
            this.lblOBL.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.CausesValidation = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Location = new System.Drawing.Point(891, 472);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(657, 229);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(75, 16);
            this.lblLocation.TabIndex = 115;
            this.lblLocation.Text = "Location :";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.White;
            this.lblRemarks.Location = new System.Drawing.Point(305, 298);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(78, 16);
            this.lblRemarks.TabIndex = 114;
            this.lblRemarks.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.Black;
            this.txtRemarks.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.Color.Yellow;
            this.txtRemarks.Location = new System.Drawing.Point(389, 279);
            this.txtRemarks.MaxLength = 100000000;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(225, 95);
            this.txtRemarks.TabIndex = 8;
            // 
            // lblInwardSurvey
            // 
            this.lblInwardSurvey.AutoSize = true;
            this.lblInwardSurvey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInwardSurvey.ForeColor = System.Drawing.Color.White;
            this.lblInwardSurvey.Location = new System.Drawing.Point(270, 242);
            this.lblInwardSurvey.Name = "lblInwardSurvey";
            this.lblInwardSurvey.Size = new System.Drawing.Size(113, 16);
            this.lblInwardSurvey.TabIndex = 113;
            this.lblInwardSurvey.Text = "Inward Survey :";
            // 
            // lblCargoDesc
            // 
            this.lblCargoDesc.AutoSize = true;
            this.lblCargoDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoDesc.ForeColor = System.Drawing.Color.White;
            this.lblCargoDesc.Location = new System.Drawing.Point(738, 196);
            this.lblCargoDesc.Name = "lblCargoDesc";
            this.lblCargoDesc.Size = new System.Drawing.Size(0, 13);
            this.lblCargoDesc.TabIndex = 112;
            // 
            // lblSysCargoDesc
            // 
            this.lblSysCargoDesc.AutoSize = true;
            this.lblSysCargoDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysCargoDesc.ForeColor = System.Drawing.Color.White;
            this.lblSysCargoDesc.Location = new System.Drawing.Point(634, 196);
            this.lblSysCargoDesc.Name = "lblSysCargoDesc";
            this.lblSysCargoDesc.Size = new System.Drawing.Size(98, 16);
            this.lblSysCargoDesc.TabIndex = 111;
            this.lblSysCargoDesc.Text = "Cargo Desc :";
            // 
            // lblSysTranshipment
            // 
            this.lblSysTranshipment.AutoSize = true;
            this.lblSysTranshipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysTranshipment.ForeColor = System.Drawing.Color.White;
            this.lblSysTranshipment.Location = new System.Drawing.Point(273, 205);
            this.lblSysTranshipment.Name = "lblSysTranshipment";
            this.lblSysTranshipment.Size = new System.Drawing.Size(110, 16);
            this.lblSysTranshipment.TabIndex = 109;
            this.lblSysTranshipment.Text = "Transhipment :";
            // 
            // lblSysMarking
            // 
            this.lblSysMarking.AutoSize = true;
            this.lblSysMarking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysMarking.ForeColor = System.Drawing.Color.White;
            this.lblSysMarking.Location = new System.Drawing.Point(312, 400);
            this.lblSysMarking.Name = "lblSysMarking";
            this.lblSysMarking.Size = new System.Drawing.Size(71, 16);
            this.lblSysMarking.TabIndex = 107;
            this.lblSysMarking.Text = "Marking :";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(389, 162);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(0, 13);
            this.lblWeight.TabIndex = 93;
            // 
            // lblSysWeight
            // 
            this.lblSysWeight.AutoSize = true;
            this.lblSysWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysWeight.ForeColor = System.Drawing.Color.White;
            this.lblSysWeight.Location = new System.Drawing.Point(277, 162);
            this.lblSysWeight.Name = "lblSysWeight";
            this.lblSysWeight.Size = new System.Drawing.Size(106, 16);
            this.lblSysWeight.TabIndex = 92;
            this.lblSysWeight.Text = "Weight (KGs) :";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(738, 127);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(0, 13);
            this.lblVolume.TabIndex = 91;
            // 
            // lblSysVolume
            // 
            this.lblSysVolume.AutoSize = true;
            this.lblSysVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysVolume.ForeColor = System.Drawing.Color.White;
            this.lblSysVolume.Location = new System.Drawing.Point(630, 127);
            this.lblSysVolume.Name = "lblSysVolume";
            this.lblSysVolume.Size = new System.Drawing.Size(102, 16);
            this.lblSysVolume.TabIndex = 90;
            this.lblSysVolume.Text = "Volume (M3) :";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(389, 127);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(0, 13);
            this.lblQty.TabIndex = 86;
            // 
            // lblSysQty
            // 
            this.lblSysQty.AutoSize = true;
            this.lblSysQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysQty.ForeColor = System.Drawing.Color.White;
            this.lblSysQty.Location = new System.Drawing.Point(307, 127);
            this.lblSysQty.Name = "lblSysQty";
            this.lblSysQty.Size = new System.Drawing.Size(76, 16);
            this.lblSysQty.TabIndex = 85;
            this.lblSysQty.Text = "Quantity : ";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassID.ForeColor = System.Drawing.Color.White;
            this.lblClassID.Location = new System.Drawing.Point(950, 91);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(0, 16);
            this.lblClassID.TabIndex = 82;
            this.lblClassID.Visible = false;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.White;
            this.lblClass.Location = new System.Drawing.Point(738, 91);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(0, 13);
            this.lblClass.TabIndex = 81;
            // 
            // lblSysClass
            // 
            this.lblSysClass.AutoSize = true;
            this.lblSysClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysClass.ForeColor = System.Drawing.Color.White;
            this.lblSysClass.Location = new System.Drawing.Point(677, 91);
            this.lblSysClass.Name = "lblSysClass";
            this.lblSysClass.Size = new System.Drawing.Size(55, 16);
            this.lblSysClass.TabIndex = 80;
            this.lblSysClass.Text = "Class :";
            // 
            // lblConsigneeID
            // 
            this.lblConsigneeID.AutoSize = true;
            this.lblConsigneeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsigneeID.ForeColor = System.Drawing.Color.White;
            this.lblConsigneeID.Location = new System.Drawing.Point(933, 91);
            this.lblConsigneeID.Name = "lblConsigneeID";
            this.lblConsigneeID.Size = new System.Drawing.Size(0, 16);
            this.lblConsigneeID.TabIndex = 70;
            this.lblConsigneeID.Visible = false;
            // 
            // lblConsignee
            // 
            this.lblConsignee.AutoSize = true;
            this.lblConsignee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsignee.ForeColor = System.Drawing.Color.White;
            this.lblConsignee.Location = new System.Drawing.Point(389, 91);
            this.lblConsignee.Name = "lblConsignee";
            this.lblConsignee.Size = new System.Drawing.Size(0, 13);
            this.lblConsignee.TabIndex = 69;
            // 
            // lblSysConsignee
            // 
            this.lblSysConsignee.AutoSize = true;
            this.lblSysConsignee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysConsignee.ForeColor = System.Drawing.Color.White;
            this.lblSysConsignee.Location = new System.Drawing.Point(293, 91);
            this.lblSysConsignee.Name = "lblSysConsignee";
            this.lblSysConsignee.Size = new System.Drawing.Size(90, 16);
            this.lblSysConsignee.TabIndex = 68;
            this.lblSysConsignee.Text = "Consignee :";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.ForeColor = System.Drawing.Color.White;
            this.lblUnitID.Location = new System.Drawing.Point(950, 54);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(0, 16);
            this.lblUnitID.TabIndex = 65;
            this.lblUnitID.Visible = false;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.ForeColor = System.Drawing.Color.White;
            this.lblUnitName.Location = new System.Drawing.Point(738, 54);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(0, 13);
            this.lblUnitName.TabIndex = 64;
            // 
            // lblSysUnit
            // 
            this.lblSysUnit.AutoSize = true;
            this.lblSysUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysUnit.ForeColor = System.Drawing.Color.White;
            this.lblSysUnit.Location = new System.Drawing.Point(689, 54);
            this.lblSysUnit.Name = "lblSysUnit";
            this.lblSysUnit.Size = new System.Drawing.Size(43, 16);
            this.lblSysUnit.TabIndex = 63;
            this.lblSysUnit.Text = "Unit :";
            // 
            // lblHouseBillNo
            // 
            this.lblHouseBillNo.AutoSize = true;
            this.lblHouseBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseBillNo.ForeColor = System.Drawing.Color.White;
            this.lblHouseBillNo.Location = new System.Drawing.Point(389, 54);
            this.lblHouseBillNo.Name = "lblHouseBillNo";
            this.lblHouseBillNo.Size = new System.Drawing.Size(0, 13);
            this.lblHouseBillNo.TabIndex = 27;
            // 
            // lblSysHouseBillNo
            // 
            this.lblSysHouseBillNo.AutoSize = true;
            this.lblSysHouseBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysHouseBillNo.ForeColor = System.Drawing.Color.White;
            this.lblSysHouseBillNo.Location = new System.Drawing.Point(272, 54);
            this.lblSysHouseBillNo.Name = "lblSysHouseBillNo";
            this.lblSysHouseBillNo.Size = new System.Drawing.Size(111, 16);
            this.lblSysHouseBillNo.TabIndex = 26;
            this.lblSysHouseBillNo.Text = "House Bill No :";
            // 
            // lblHBLID
            // 
            this.lblHBLID.AutoSize = true;
            this.lblHBLID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblHBLID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHBLID.ForeColor = System.Drawing.Color.White;
            this.lblHBLID.Location = new System.Drawing.Point(389, 19);
            this.lblHBLID.Name = "lblHBLID";
            this.lblHBLID.Size = new System.Drawing.Size(14, 15);
            this.lblHBLID.TabIndex = 22;
            this.lblHBLID.Text = "0";
            // 
            // lblHBL
            // 
            this.lblHBL.AutoSize = true;
            this.lblHBL.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHBL.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHBL.Location = new System.Drawing.Point(334, 19);
            this.lblHBL.Name = "lblHBL";
            this.lblHBL.Size = new System.Drawing.Size(49, 15);
            this.lblHBL.TabIndex = 25;
            this.lblHBL.Tag = "cv";
            this.lblHBL.Text = "HBL ID :";
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBill.GridColor = System.Drawing.Color.White;
            this.dgvBill.Location = new System.Drawing.Point(6, 19);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(237, 482);
            this.dgvBill.TabIndex = 24;
            this.dgvBill.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBill_RowHeaderMouseClick);
            // 
            // ChkUnstuff
            // 
            this.ChkUnstuff.AutoSize = true;
            this.ChkUnstuff.Location = new System.Drawing.Point(137, 63);
            this.ChkUnstuff.Name = "ChkUnstuff";
            this.ChkUnstuff.Size = new System.Drawing.Size(15, 14);
            this.ChkUnstuff.TabIndex = 3;
            this.ChkUnstuff.UseVisualStyleBackColor = true;
            // 
            // lblUnstuff
            // 
            this.lblUnstuff.AutoSize = true;
            this.lblUnstuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnstuff.ForeColor = System.Drawing.Color.White;
            this.lblUnstuff.Location = new System.Drawing.Point(68, 61);
            this.lblUnstuff.Name = "lblUnstuff";
            this.lblUnstuff.Size = new System.Drawing.Size(63, 16);
            this.lblUnstuff.TabIndex = 102;
            this.lblUnstuff.Text = "Unstuff :";
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Controls.Add(this.btnCancel);
            this.pnlSave.Location = new System.Drawing.Point(756, 72);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(108, 56);
            this.pnlSave.TabIndex = 4;
            this.pnlSave.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(3, 4);
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
            this.btnCancel.Location = new System.Drawing.Point(54, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 41);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.btnBack);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Location = new System.Drawing.Point(870, 72);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(107, 56);
            this.pnlEdit.TabIndex = 5;
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
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(54, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 41);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // DtUnstuff
            // 
            this.DtUnstuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtUnstuff.Location = new System.Drawing.Point(629, 25);
            this.DtUnstuff.Name = "DtUnstuff";
            this.DtUnstuff.Size = new System.Drawing.Size(249, 20);
            this.DtUnstuff.TabIndex = 2;
            // 
            // lblUnstuffDate
            // 
            this.lblUnstuffDate.AutoSize = true;
            this.lblUnstuffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnstuffDate.ForeColor = System.Drawing.Color.White;
            this.lblUnstuffDate.Location = new System.Drawing.Point(523, 24);
            this.lblUnstuffDate.Name = "lblUnstuffDate";
            this.lblUnstuffDate.Size = new System.Drawing.Size(100, 16);
            this.lblUnstuffDate.TabIndex = 99;
            this.lblUnstuffDate.Text = "Unstuff Date :";
            // 
            // txtContainerNo
            // 
            this.txtContainerNo.BackColor = System.Drawing.Color.Black;
            this.txtContainerNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContainerNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtContainerNo.Location = new System.Drawing.Point(137, 22);
            this.txtContainerNo.MaxLength = 15;
            this.txtContainerNo.Name = "txtContainerNo";
            this.txtContainerNo.ReadOnly = true;
            this.txtContainerNo.Size = new System.Drawing.Size(249, 23);
            this.txtContainerNo.TabIndex = 1;
            // 
            // lblContainerNo
            // 
            this.lblContainerNo.AutoSize = true;
            this.lblContainerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContainerNo.ForeColor = System.Drawing.Color.White;
            this.lblContainerNo.Location = new System.Drawing.Point(25, 24);
            this.lblContainerNo.Name = "lblContainerNo";
            this.lblContainerNo.Size = new System.Drawing.Size(106, 16);
            this.lblContainerNo.TabIndex = 19;
            this.lblContainerNo.Text = "Container No :";
            // 
            // lblSysOBL
            // 
            this.lblSysOBL.AutoSize = true;
            this.lblSysOBL.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysOBL.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSysOBL.Location = new System.Drawing.Point(110, 9);
            this.lblSysOBL.Name = "lblSysOBL";
            this.lblSysOBL.Size = new System.Drawing.Size(50, 15);
            this.lblSysOBL.TabIndex = 22;
            this.lblSysOBL.Tag = "cv";
            this.lblSysOBL.Text = "OBL ID :";
            this.lblSysOBL.Visible = false;
            // 
            // lblSysOBLID
            // 
            this.lblSysOBLID.AutoSize = true;
            this.lblSysOBLID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblSysOBLID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysOBLID.ForeColor = System.Drawing.Color.White;
            this.lblSysOBLID.Location = new System.Drawing.Point(166, 9);
            this.lblSysOBLID.Name = "lblSysOBLID";
            this.lblSysOBLID.Size = new System.Drawing.Size(14, 15);
            this.lblSysOBLID.TabIndex = 23;
            this.lblSysOBLID.Text = "1";
            this.lblSysOBLID.Visible = false;
            // 
            // UnstuffCargoAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1004, 726);
            this.Controls.Add(this.lblSysOBLID);
            this.Controls.Add(this.lblSysOBL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblContID);
            this.Controls.Add(this.lblCont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnstuffCargoAED";
            this.ShowIcon = false;
            this.Text = "Container Unstuffing Details";
            this.Load += new System.EventHandler(this.UnstuffCargoAED_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GroupBoxHBL.ResumeLayout(false);
            this.GroupBoxHBL.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.pnlSave.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Label lblContID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContainerNo;
        private System.Windows.Forms.TextBox txtContainerNo;
        private System.Windows.Forms.Label lblUnstuffDate;
        private System.Windows.Forms.DateTimePicker DtUnstuff;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ChkUnstuff;
        private System.Windows.Forms.Label lblUnstuff;
        private System.Windows.Forms.GroupBox GroupBoxHBL;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label lblHBL;
        private System.Windows.Forms.Label lblHBLID;
        private System.Windows.Forms.Label lblHouseBillNo;
        private System.Windows.Forms.Label lblSysHouseBillNo;
        private System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Label lblSysUnit;
        private System.Windows.Forms.Label lblConsigneeID;
        private System.Windows.Forms.Label lblConsignee;
        private System.Windows.Forms.Label lblSysConsignee;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblSysClass;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblSysQty;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblSysVolume;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSysWeight;
        private System.Windows.Forms.Label lblSysMarking;
        private System.Windows.Forms.Label lblSysTranshipment;
        private System.Windows.Forms.Label lblInwardSurvey;
        private System.Windows.Forms.Label lblCargoDesc;
        private System.Windows.Forms.Label lblSysCargoDesc;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.RadioButton rbInwardSurveyYes;
        private System.Windows.Forms.RadioButton rbInwardSurveyNo;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOBL;
        private System.Windows.Forms.Label lblOBLID;
        private System.Windows.Forms.RadioButton rbShipmentYes;
        private System.Windows.Forms.RadioButton rbShipmentNo;
        private System.Windows.Forms.TextBox txtPackaging;
        private System.Windows.Forms.Label lblPackaging;
        private System.Windows.Forms.TextBox txtMarking;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtSearchPort;
        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblSysOBL;
        private System.Windows.Forms.Label lblSysOBLID;
        private System.Windows.Forms.Button btnPrintTally;
    }
}