namespace PIS
{
    partial class CFSAED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFSAED));
            this.lblID = new System.Windows.Forms.Label();
            this.lblCFSID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtReceivedBy = new System.Windows.Forms.TextBox();
            this.lblReceivedBy = new System.Windows.Forms.Label();
            this.dtReceiveTime = new System.Windows.Forms.DateTimePicker();
            this.lblTimeReceived = new System.Windows.Forms.Label();
            this.dtDateReceived = new System.Windows.Forms.DateTimePicker();
            this.lblDateReceive = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.lblRefNo = new System.Windows.Forms.Label();
            this.btnAddVessel = new System.Windows.Forms.Button();
            this.btnAddPort = new System.Windows.Forms.Button();
            this.btnAddShipper = new System.Windows.Forms.Button();
            this.txtVessel = new System.Windows.Forms.TextBox();
            this.VesselList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchVessel = new System.Windows.Forms.TextBox();
            this.lblVessel = new System.Windows.Forms.Label();
            this.txtFinalPort = new System.Windows.Forms.TextBox();
            this.FinalPortList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchFinalPort = new System.Windows.Forms.TextBox();
            this.lblFinalPort = new System.Windows.Forms.Label();
            this.txtDisChrgPort = new System.Windows.Forms.TextBox();
            this.DischargePortList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchDisChrgPort = new System.Windows.Forms.TextBox();
            this.lblDisChargePort = new System.Windows.Forms.Label();
            this.txtMarking = new System.Windows.Forms.TextBox();
            this.lblMarking = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtCargoDesc = new System.Windows.Forms.TextBox();
            this.lblCargoDesc = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchUnit = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtShipper = new System.Windows.Forms.TextBox();
            this.ShipperList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchShipper = new System.Windows.Forms.TextBox();
            this.lblShipper = new System.Windows.Forms.Label();
            this.txtCFSNo = new System.Windows.Forms.TextBox();
            this.lblCFSNo = new System.Windows.Forms.Label();
            this.UnitList = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.Info;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 15);
            this.lblID.TabIndex = 5;
            this.lblID.Tag = "cv";
            this.lblID.Text = "ID :";
            this.lblID.Visible = false;
            // 
            // lblCFSID
            // 
            this.lblCFSID.AutoSize = true;
            this.lblCFSID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCFSID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCFSID.ForeColor = System.Drawing.Color.White;
            this.lblCFSID.Location = new System.Drawing.Point(43, 9);
            this.lblCFSID.Name = "lblCFSID";
            this.lblCFSID.Size = new System.Drawing.Size(14, 15);
            this.lblCFSID.TabIndex = 16;
            this.lblCFSID.Text = "0";
            this.lblCFSID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Controls.Add(this.pnlSave);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 691);
            this.panel1.TabIndex = 17;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.btnBack);
            this.pnlEdit.Controls.Add(this.btnDel);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Location = new System.Drawing.Point(1160, 592);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(159, 56);
            this.pnlEdit.TabIndex = 25;
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
            this.btnDel.Location = new System.Drawing.Point(105, 3);
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
            this.btnEdit.Location = new System.Drawing.Point(54, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 41);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Controls.Add(this.btnCancel);
            this.pnlSave.Location = new System.Drawing.Point(1214, 589);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(105, 56);
            this.pnlSave.TabIndex = 24;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLocation);
            this.groupBox2.Controls.Add(this.lblLocation);
            this.groupBox2.Controls.Add(this.txtReceivedBy);
            this.groupBox2.Controls.Add(this.lblReceivedBy);
            this.groupBox2.Controls.Add(this.dtReceiveTime);
            this.groupBox2.Controls.Add(this.lblTimeReceived);
            this.groupBox2.Controls.Add(this.dtDateReceived);
            this.groupBox2.Controls.Add(this.lblDateReceive);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1316, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OFFICE USE";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.Black;
            this.txtLocation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.ForeColor = System.Drawing.Color.Yellow;
            this.txtLocation.Location = new System.Drawing.Point(622, 83);
            this.txtLocation.MaxLength = 15;
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(332, 60);
            this.txtLocation.TabIndex = 135;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(541, 85);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(75, 16);
            this.lblLocation.TabIndex = 139;
            this.lblLocation.Text = "Location :";
            // 
            // txtReceivedBy
            // 
            this.txtReceivedBy.BackColor = System.Drawing.Color.Black;
            this.txtReceivedBy.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedBy.ForeColor = System.Drawing.Color.Yellow;
            this.txtReceivedBy.Location = new System.Drawing.Point(622, 36);
            this.txtReceivedBy.MaxLength = 15;
            this.txtReceivedBy.Name = "txtReceivedBy";
            this.txtReceivedBy.ReadOnly = true;
            this.txtReceivedBy.Size = new System.Drawing.Size(332, 23);
            this.txtReceivedBy.TabIndex = 135;
            // 
            // lblReceivedBy
            // 
            this.lblReceivedBy.AutoSize = true;
            this.lblReceivedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedBy.Location = new System.Drawing.Point(511, 38);
            this.lblReceivedBy.Name = "lblReceivedBy";
            this.lblReceivedBy.Size = new System.Drawing.Size(105, 16);
            this.lblReceivedBy.TabIndex = 138;
            this.lblReceivedBy.Text = "Received By :";
            // 
            // dtReceiveTime
            // 
            this.dtReceiveTime.CustomFormat = "hh:mm tt";
            this.dtReceiveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReceiveTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReceiveTime.Location = new System.Drawing.Point(155, 81);
            this.dtReceiveTime.Name = "dtReceiveTime";
            this.dtReceiveTime.ShowUpDown = true;
            this.dtReceiveTime.Size = new System.Drawing.Size(332, 20);
            this.dtReceiveTime.TabIndex = 1;
            // 
            // lblTimeReceived
            // 
            this.lblTimeReceived.AutoSize = true;
            this.lblTimeReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeReceived.Location = new System.Drawing.Point(27, 85);
            this.lblTimeReceived.Name = "lblTimeReceived";
            this.lblTimeReceived.Size = new System.Drawing.Size(122, 16);
            this.lblTimeReceived.TabIndex = 137;
            this.lblTimeReceived.Text = "Time Received :";
            // 
            // dtDateReceived
            // 
            this.dtDateReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateReceived.Location = new System.Drawing.Point(155, 34);
            this.dtDateReceived.Name = "dtDateReceived";
            this.dtDateReceived.Size = new System.Drawing.Size(332, 20);
            this.dtDateReceived.TabIndex = 136;
            // 
            // lblDateReceive
            // 
            this.lblDateReceive.AutoSize = true;
            this.lblDateReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReceive.Location = new System.Drawing.Point(29, 38);
            this.lblDateReceive.Name = "lblDateReceive";
            this.lblDateReceive.Size = new System.Drawing.Size(120, 16);
            this.lblDateReceive.TabIndex = 135;
            this.lblDateReceive.Text = "Date Received :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.lblRemarks);
            this.groupBox1.Controls.Add(this.txtRefNo);
            this.groupBox1.Controls.Add(this.lblRefNo);
            this.groupBox1.Controls.Add(this.btnAddVessel);
            this.groupBox1.Controls.Add(this.btnAddPort);
            this.groupBox1.Controls.Add(this.btnAddShipper);
            this.groupBox1.Controls.Add(this.txtVessel);
            this.groupBox1.Controls.Add(this.VesselList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSearchVessel);
            this.groupBox1.Controls.Add(this.lblVessel);
            this.groupBox1.Controls.Add(this.txtFinalPort);
            this.groupBox1.Controls.Add(this.FinalPortList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSearchFinalPort);
            this.groupBox1.Controls.Add(this.lblFinalPort);
            this.groupBox1.Controls.Add(this.txtDisChrgPort);
            this.groupBox1.Controls.Add(this.DischargePortList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearchDisChrgPort);
            this.groupBox1.Controls.Add(this.lblDisChargePort);
            this.groupBox1.Controls.Add(this.txtMarking);
            this.groupBox1.Controls.Add(this.lblMarking);
            this.groupBox1.Controls.Add(this.txtVolume);
            this.groupBox1.Controls.Add(this.lblVolume);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.txtCargoDesc);
            this.groupBox1.Controls.Add(this.lblCargoDesc);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchUnit);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.txtShipper);
            this.groupBox1.Controls.Add(this.ShipperList);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSearchShipper);
            this.groupBox1.Controls.Add(this.lblShipper);
            this.groupBox1.Controls.Add(this.txtCFSNo);
            this.groupBox1.Controls.Add(this.lblCFSNo);
            this.groupBox1.Controls.Add(this.UnitList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1316, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTAINER SHIPPING NOTE DETAILS";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.Black;
            this.txtRemarks.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.Color.Yellow;
            this.txtRemarks.Location = new System.Drawing.Point(155, 337);
            this.txtRemarks.MaxLength = 1000;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.Size = new System.Drawing.Size(332, 77);
            this.txtRemarks.TabIndex = 12;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(37, 339);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(78, 16);
            this.lblRemarks.TabIndex = 140;
            this.lblRemarks.Text = "Remarks :";
            // 
            // txtRefNo
            // 
            this.txtRefNo.BackColor = System.Drawing.Color.Black;
            this.txtRefNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtRefNo.Location = new System.Drawing.Point(155, 295);
            this.txtRefNo.MaxLength = 1000;
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.ReadOnly = true;
            this.txtRefNo.Size = new System.Drawing.Size(332, 23);
            this.txtRefNo.TabIndex = 11;
            // 
            // lblRefNo
            // 
            this.lblRefNo.AutoSize = true;
            this.lblRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefNo.Location = new System.Drawing.Point(37, 297);
            this.lblRefNo.Name = "lblRefNo";
            this.lblRefNo.Size = new System.Drawing.Size(112, 16);
            this.lblRefNo.TabIndex = 138;
            this.lblRefNo.Text = "Reference No :";
            // 
            // btnAddVessel
            // 
            this.btnAddVessel.CausesValidation = false;
            this.btnAddVessel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVessel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVessel.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddVessel.Location = new System.Drawing.Point(1082, 285);
            this.btnAddVessel.Name = "btnAddVessel";
            this.btnAddVessel.Size = new System.Drawing.Size(102, 33);
            this.btnAddVessel.TabIndex = 137;
            this.btnAddVessel.Text = "Add Vessel";
            this.btnAddVessel.UseVisualStyleBackColor = true;
            this.btnAddVessel.Click += new System.EventHandler(this.btnAddVessel_Click);
            // 
            // btnAddPort
            // 
            this.btnAddPort.CausesValidation = false;
            this.btnAddPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPort.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddPort.Location = new System.Drawing.Point(1082, 212);
            this.btnAddPort.Name = "btnAddPort";
            this.btnAddPort.Size = new System.Drawing.Size(102, 33);
            this.btnAddPort.TabIndex = 136;
            this.btnAddPort.Text = "Add Port";
            this.btnAddPort.UseVisualStyleBackColor = true;
            this.btnAddPort.Click += new System.EventHandler(this.btnAddPort_Click);
            // 
            // btnAddShipper
            // 
            this.btnAddShipper.CausesValidation = false;
            this.btnAddShipper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShipper.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShipper.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddShipper.Location = new System.Drawing.Point(493, 79);
            this.btnAddShipper.Name = "btnAddShipper";
            this.btnAddShipper.Size = new System.Drawing.Size(102, 33);
            this.btnAddShipper.TabIndex = 135;
            this.btnAddShipper.Text = "Add Shipper";
            this.btnAddShipper.UseVisualStyleBackColor = true;
            this.btnAddShipper.Click += new System.EventHandler(this.btnAddShipper_Click);
            // 
            // txtVessel
            // 
            this.txtVessel.BackColor = System.Drawing.Color.Black;
            this.txtVessel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVessel.ForeColor = System.Drawing.Color.Yellow;
            this.txtVessel.Location = new System.Drawing.Point(719, 295);
            this.txtVessel.MaxLength = 15;
            this.txtVessel.Name = "txtVessel";
            this.txtVessel.ReadOnly = true;
            this.txtVessel.Size = new System.Drawing.Size(332, 23);
            this.txtVessel.TabIndex = 134;
            // 
            // VesselList
            // 
            this.VesselList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VesselList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VesselList.BackColor = System.Drawing.Color.Black;
            this.VesselList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VesselList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VesselList.ForeColor = System.Drawing.Color.Yellow;
            this.VesselList.FormattingEnabled = true;
            this.VesselList.Location = new System.Drawing.Point(855, 295);
            this.VesselList.Name = "VesselList";
            this.VesselList.Size = new System.Drawing.Size(196, 23);
            this.VesselList.TabIndex = 18;
            this.VesselList.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(830, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 132;
            this.label4.Text = "---";
            // 
            // txtSearchVessel
            // 
            this.txtSearchVessel.BackColor = System.Drawing.Color.Black;
            this.txtSearchVessel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchVessel.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchVessel.Location = new System.Drawing.Point(719, 295);
            this.txtSearchVessel.MaxLength = 15;
            this.txtSearchVessel.Name = "txtSearchVessel";
            this.txtSearchVessel.ReadOnly = true;
            this.txtSearchVessel.Size = new System.Drawing.Size(105, 23);
            this.txtSearchVessel.TabIndex = 17;
            this.txtSearchVessel.TextChanged += new System.EventHandler(this.txtSearchVessel_TextChanged);
            // 
            // lblVessel
            // 
            this.lblVessel.AutoSize = true;
            this.lblVessel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVessel.Location = new System.Drawing.Point(649, 292);
            this.lblVessel.Name = "lblVessel";
            this.lblVessel.Size = new System.Drawing.Size(64, 16);
            this.lblVessel.TabIndex = 130;
            this.lblVessel.Text = "Vessel :";
            // 
            // txtFinalPort
            // 
            this.txtFinalPort.BackColor = System.Drawing.Color.Black;
            this.txtFinalPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalPort.ForeColor = System.Drawing.Color.Yellow;
            this.txtFinalPort.Location = new System.Drawing.Point(719, 241);
            this.txtFinalPort.MaxLength = 15;
            this.txtFinalPort.Name = "txtFinalPort";
            this.txtFinalPort.ReadOnly = true;
            this.txtFinalPort.Size = new System.Drawing.Size(332, 23);
            this.txtFinalPort.TabIndex = 129;
            // 
            // FinalPortList
            // 
            this.FinalPortList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FinalPortList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FinalPortList.BackColor = System.Drawing.Color.Black;
            this.FinalPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FinalPortList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalPortList.ForeColor = System.Drawing.Color.Yellow;
            this.FinalPortList.FormattingEnabled = true;
            this.FinalPortList.Location = new System.Drawing.Point(855, 241);
            this.FinalPortList.Name = "FinalPortList";
            this.FinalPortList.Size = new System.Drawing.Size(196, 23);
            this.FinalPortList.TabIndex = 16;
            this.FinalPortList.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(830, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 127;
            this.label3.Text = "---";
            // 
            // txtSearchFinalPort
            // 
            this.txtSearchFinalPort.BackColor = System.Drawing.Color.Black;
            this.txtSearchFinalPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFinalPort.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchFinalPort.Location = new System.Drawing.Point(719, 241);
            this.txtSearchFinalPort.MaxLength = 15;
            this.txtSearchFinalPort.Name = "txtSearchFinalPort";
            this.txtSearchFinalPort.ReadOnly = true;
            this.txtSearchFinalPort.Size = new System.Drawing.Size(105, 23);
            this.txtSearchFinalPort.TabIndex = 15;
            this.txtSearchFinalPort.TextChanged += new System.EventHandler(this.txtSearchFinalPort_TextChanged);
            // 
            // lblFinalPort
            // 
            this.lblFinalPort.AutoSize = true;
            this.lblFinalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPort.Location = new System.Drawing.Point(631, 243);
            this.lblFinalPort.Name = "lblFinalPort";
            this.lblFinalPort.Size = new System.Drawing.Size(82, 16);
            this.lblFinalPort.TabIndex = 125;
            this.lblFinalPort.Text = "Final Port :";
            // 
            // txtDisChrgPort
            // 
            this.txtDisChrgPort.BackColor = System.Drawing.Color.Black;
            this.txtDisChrgPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisChrgPort.ForeColor = System.Drawing.Color.Yellow;
            this.txtDisChrgPort.Location = new System.Drawing.Point(719, 195);
            this.txtDisChrgPort.MaxLength = 15;
            this.txtDisChrgPort.Name = "txtDisChrgPort";
            this.txtDisChrgPort.ReadOnly = true;
            this.txtDisChrgPort.Size = new System.Drawing.Size(332, 23);
            this.txtDisChrgPort.TabIndex = 124;
            // 
            // DischargePortList
            // 
            this.DischargePortList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DischargePortList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DischargePortList.BackColor = System.Drawing.Color.Black;
            this.DischargePortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DischargePortList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DischargePortList.ForeColor = System.Drawing.Color.Yellow;
            this.DischargePortList.FormattingEnabled = true;
            this.DischargePortList.Location = new System.Drawing.Point(855, 195);
            this.DischargePortList.Name = "DischargePortList";
            this.DischargePortList.Size = new System.Drawing.Size(196, 23);
            this.DischargePortList.TabIndex = 14;
            this.DischargePortList.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(830, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 122;
            this.label2.Text = "---";
            // 
            // txtSearchDisChrgPort
            // 
            this.txtSearchDisChrgPort.BackColor = System.Drawing.Color.Black;
            this.txtSearchDisChrgPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDisChrgPort.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchDisChrgPort.Location = new System.Drawing.Point(719, 195);
            this.txtSearchDisChrgPort.MaxLength = 15;
            this.txtSearchDisChrgPort.Name = "txtSearchDisChrgPort";
            this.txtSearchDisChrgPort.ReadOnly = true;
            this.txtSearchDisChrgPort.Size = new System.Drawing.Size(105, 23);
            this.txtSearchDisChrgPort.TabIndex = 13;
            this.txtSearchDisChrgPort.TextChanged += new System.EventHandler(this.txtSearchDisChrgPort_TextChanged);
            // 
            // lblDisChargePort
            // 
            this.lblDisChargePort.AutoSize = true;
            this.lblDisChargePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisChargePort.Location = new System.Drawing.Point(594, 194);
            this.lblDisChargePort.Name = "lblDisChargePort";
            this.lblDisChargePort.Size = new System.Drawing.Size(119, 16);
            this.lblDisChargePort.TabIndex = 120;
            this.lblDisChargePort.Text = "Discharge Port :";
            // 
            // txtMarking
            // 
            this.txtMarking.BackColor = System.Drawing.Color.Black;
            this.txtMarking.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarking.ForeColor = System.Drawing.Color.Yellow;
            this.txtMarking.Location = new System.Drawing.Point(719, 135);
            this.txtMarking.MaxLength = 1000;
            this.txtMarking.Multiline = true;
            this.txtMarking.Name = "txtMarking";
            this.txtMarking.ReadOnly = true;
            this.txtMarking.Size = new System.Drawing.Size(332, 40);
            this.txtMarking.TabIndex = 10;
            // 
            // lblMarking
            // 
            this.lblMarking.AutoSize = true;
            this.lblMarking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarking.Location = new System.Drawing.Point(642, 137);
            this.lblMarking.Name = "lblMarking";
            this.lblMarking.Size = new System.Drawing.Size(71, 16);
            this.lblMarking.TabIndex = 118;
            this.lblMarking.Text = "Marking :";
            // 
            // txtVolume
            // 
            this.txtVolume.BackColor = System.Drawing.Color.Black;
            this.txtVolume.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.ForeColor = System.Drawing.Color.Yellow;
            this.txtVolume.Location = new System.Drawing.Point(719, 83);
            this.txtVolume.MaxLength = 15;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(332, 23);
            this.txtVolume.TabIndex = 8;
            this.txtVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolume_KeyPress);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(611, 85);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(102, 16);
            this.lblVolume.TabIndex = 116;
            this.lblVolume.Text = "Volume (M3) :";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.Black;
            this.txtWeight.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ForeColor = System.Drawing.Color.Yellow;
            this.txtWeight.Location = new System.Drawing.Point(719, 34);
            this.txtWeight.MaxLength = 15;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(332, 23);
            this.txtWeight.TabIndex = 7;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(609, 36);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(104, 16);
            this.lblWeight.TabIndex = 114;
            this.lblWeight.Text = "Weight (Kgs) :";
            // 
            // txtCargoDesc
            // 
            this.txtCargoDesc.BackColor = System.Drawing.Color.Black;
            this.txtCargoDesc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoDesc.ForeColor = System.Drawing.Color.Yellow;
            this.txtCargoDesc.Location = new System.Drawing.Point(155, 247);
            this.txtCargoDesc.MaxLength = 1000;
            this.txtCargoDesc.Name = "txtCargoDesc";
            this.txtCargoDesc.ReadOnly = true;
            this.txtCargoDesc.Size = new System.Drawing.Size(332, 23);
            this.txtCargoDesc.TabIndex = 9;
            // 
            // lblCargoDesc
            // 
            this.lblCargoDesc.AutoSize = true;
            this.lblCargoDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoDesc.Location = new System.Drawing.Point(8, 243);
            this.lblCargoDesc.Name = "lblCargoDesc";
            this.lblCargoDesc.Size = new System.Drawing.Size(141, 16);
            this.lblCargoDesc.TabIndex = 56;
            this.lblCargoDesc.Text = "Cargo Description :";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(106, 194);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(43, 16);
            this.lblUnit.TabIndex = 55;
            this.lblUnit.Text = "Unit :";
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.Black;
            this.txtUnit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.ForeColor = System.Drawing.Color.Yellow;
            this.txtUnit.Location = new System.Drawing.Point(155, 192);
            this.txtUnit.MaxLength = 15;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(332, 23);
            this.txtUnit.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(266, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "---";
            // 
            // txtSearchUnit
            // 
            this.txtSearchUnit.BackColor = System.Drawing.Color.Black;
            this.txtSearchUnit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUnit.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchUnit.Location = new System.Drawing.Point(155, 192);
            this.txtSearchUnit.MaxLength = 15;
            this.txtSearchUnit.Name = "txtSearchUnit";
            this.txtSearchUnit.ReadOnly = true;
            this.txtSearchUnit.Size = new System.Drawing.Size(105, 23);
            this.txtSearchUnit.TabIndex = 5;
            this.txtSearchUnit.TextChanged += new System.EventHandler(this.txtSearchUnit_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.Black;
            this.txtQty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Yellow;
            this.txtQty.Location = new System.Drawing.Point(155, 142);
            this.txtQty.MaxLength = 15;
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(332, 23);
            this.txtQty.TabIndex = 4;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(77, 144);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(72, 16);
            this.lblQty.TabIndex = 49;
            this.lblQty.Text = "Quantity :";
            // 
            // txtShipper
            // 
            this.txtShipper.BackColor = System.Drawing.Color.Black;
            this.txtShipper.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipper.ForeColor = System.Drawing.Color.Yellow;
            this.txtShipper.Location = new System.Drawing.Point(155, 85);
            this.txtShipper.MaxLength = 15;
            this.txtShipper.Name = "txtShipper";
            this.txtShipper.ReadOnly = true;
            this.txtShipper.Size = new System.Drawing.Size(332, 23);
            this.txtShipper.TabIndex = 48;
            // 
            // ShipperList
            // 
            this.ShipperList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ShipperList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ShipperList.BackColor = System.Drawing.Color.Black;
            this.ShipperList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShipperList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipperList.ForeColor = System.Drawing.Color.Yellow;
            this.ShipperList.FormattingEnabled = true;
            this.ShipperList.Location = new System.Drawing.Point(291, 85);
            this.ShipperList.Name = "ShipperList";
            this.ShipperList.Size = new System.Drawing.Size(196, 23);
            this.ShipperList.TabIndex = 3;
            this.ShipperList.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(266, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "---";
            // 
            // txtSearchShipper
            // 
            this.txtSearchShipper.BackColor = System.Drawing.Color.Black;
            this.txtSearchShipper.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchShipper.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchShipper.Location = new System.Drawing.Point(155, 85);
            this.txtSearchShipper.MaxLength = 15;
            this.txtSearchShipper.Name = "txtSearchShipper";
            this.txtSearchShipper.ReadOnly = true;
            this.txtSearchShipper.Size = new System.Drawing.Size(105, 23);
            this.txtSearchShipper.TabIndex = 2;
            this.txtSearchShipper.TextChanged += new System.EventHandler(this.txtSearchShipper_TextChanged);
            // 
            // lblShipper
            // 
            this.lblShipper.AutoSize = true;
            this.lblShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipper.Location = new System.Drawing.Point(79, 87);
            this.lblShipper.Name = "lblShipper";
            this.lblShipper.Size = new System.Drawing.Size(70, 16);
            this.lblShipper.TabIndex = 20;
            this.lblShipper.Text = "Shipper :";
            // 
            // txtCFSNo
            // 
            this.txtCFSNo.BackColor = System.Drawing.Color.Black;
            this.txtCFSNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCFSNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtCFSNo.Location = new System.Drawing.Point(155, 34);
            this.txtCFSNo.MaxLength = 15;
            this.txtCFSNo.Name = "txtCFSNo";
            this.txtCFSNo.ReadOnly = true;
            this.txtCFSNo.Size = new System.Drawing.Size(332, 23);
            this.txtCFSNo.TabIndex = 1;
            // 
            // lblCFSNo
            // 
            this.lblCFSNo.AutoSize = true;
            this.lblCFSNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCFSNo.Location = new System.Drawing.Point(80, 36);
            this.lblCFSNo.Name = "lblCFSNo";
            this.lblCFSNo.Size = new System.Drawing.Size(69, 16);
            this.lblCFSNo.TabIndex = 2;
            this.lblCFSNo.Text = "CFS No :";
            // 
            // UnitList
            // 
            this.UnitList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UnitList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UnitList.BackColor = System.Drawing.Color.Black;
            this.UnitList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitList.ForeColor = System.Drawing.Color.Yellow;
            this.UnitList.FormattingEnabled = true;
            this.UnitList.Location = new System.Drawing.Point(291, 192);
            this.UnitList.Name = "UnitList";
            this.UnitList.Size = new System.Drawing.Size(196, 23);
            this.UnitList.TabIndex = 6;
            this.UnitList.Visible = false;
            // 
            // CFSAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1346, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCFSID);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CFSAED";
            this.ShowIcon = false;
            this.Text = "Container Shipping Note Details";
            this.panel1.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCFSID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCFSNo;
        private System.Windows.Forms.TextBox txtCFSNo;
        private System.Windows.Forms.Label lblShipper;
        private System.Windows.Forms.TextBox txtSearchShipper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ShipperList;
        private System.Windows.Forms.TextBox txtShipper;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.ComboBox UnitList;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblCargoDesc;
        private System.Windows.Forms.TextBox txtCargoDesc;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblMarking;
        private System.Windows.Forms.TextBox txtMarking;
        private System.Windows.Forms.TextBox txtDisChrgPort;
        private System.Windows.Forms.ComboBox DischargePortList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchDisChrgPort;
        private System.Windows.Forms.Label lblDisChargePort;
        private System.Windows.Forms.Label lblFinalPort;
        private System.Windows.Forms.TextBox txtSearchFinalPort;
        private System.Windows.Forms.ComboBox FinalPortList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFinalPort;
        private System.Windows.Forms.Label lblVessel;
        private System.Windows.Forms.ComboBox VesselList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchVessel;
        private System.Windows.Forms.TextBox txtVessel;
        private System.Windows.Forms.DateTimePicker dtReceiveTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtDateReceived;
        private System.Windows.Forms.Label lblDateReceive;
        private System.Windows.Forms.Label lblTimeReceived;
        private System.Windows.Forms.TextBox txtReceivedBy;
        private System.Windows.Forms.Label lblReceivedBy;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddShipper;
        private System.Windows.Forms.Button btnAddPort;
        private System.Windows.Forms.Button btnAddVessel;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label lblRefNo;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
    }
}