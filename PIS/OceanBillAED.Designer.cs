namespace PIS
{
    partial class OceanBillAED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OceanBillAED));
            this.lblID = new System.Windows.Forms.Label();
            this.lblOBLID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnAddPort = new System.Windows.Forms.Button();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.DtETA = new System.Windows.Forms.DateTimePicker();
            this.txtOceanBillConsignee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OceanBillConsigneeList = new System.Windows.Forms.ComboBox();
            this.txtUnloadPort = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchSCNNo = new System.Windows.Forms.TextBox();
            this.txtSearchOceanBillConsigneeID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSCNNo = new System.Windows.Forms.TextBox();
            this.txtLoadPort = new System.Windows.Forms.TextBox();
            this.txtShipAgent = new System.Windows.Forms.TextBox();
            this.SCNNoList = new System.Windows.Forms.ComboBox();
            this.ShipAgentList = new System.Windows.Forms.ComboBox();
            this.txtDestPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchShipAgentID = new System.Windows.Forms.TextBox();
            this.lblVessel = new System.Windows.Forms.Label();
            this.lblShipAgent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVesselName = new System.Windows.Forms.TextBox();
            this.lblVoyage = new System.Windows.Forms.Label();
            this.DestPortList = new System.Windows.Forms.ComboBox();
            this.txtVoyageNo = new System.Windows.Forms.TextBox();
            this.lblETA = new System.Windows.Forms.Label();
            this.txtSearchDestPortCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPortLoad = new System.Windows.Forms.Label();
            this.lblOBLNo = new System.Windows.Forms.Label();
            this.txtOceanBillNo = new System.Windows.Forms.TextBox();
            this.txtSearchLoadPortCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UnloadPortList = new System.Windows.Forms.ComboBox();
            this.LoadPortList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchUnloadPort = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlEdit.SuspendLayout();
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
            this.lblID.TabIndex = 4;
            this.lblID.Tag = "cv";
            this.lblID.Text = "ID :";
            this.lblID.Visible = false;
            // 
            // lblOBLID
            // 
            this.lblOBLID.AutoSize = true;
            this.lblOBLID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblOBLID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBLID.ForeColor = System.Drawing.Color.White;
            this.lblOBLID.Location = new System.Drawing.Point(43, 9);
            this.lblOBLID.Name = "lblOBLID";
            this.lblOBLID.Size = new System.Drawing.Size(14, 15);
            this.lblOBLID.TabIndex = 15;
            this.lblOBLID.Text = "0";
            this.lblOBLID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddCust);
            this.panel1.Controls.Add(this.btnAddPort);
            this.panel1.Controls.Add(this.pnlSave);
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Controls.Add(this.DtETA);
            this.panel1.Controls.Add(this.txtOceanBillConsignee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OceanBillConsigneeList);
            this.panel1.Controls.Add(this.txtUnloadPort);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtSearchSCNNo);
            this.panel1.Controls.Add(this.txtSearchOceanBillConsigneeID);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSCNNo);
            this.panel1.Controls.Add(this.txtLoadPort);
            this.panel1.Controls.Add(this.txtShipAgent);
            this.panel1.Controls.Add(this.SCNNoList);
            this.panel1.Controls.Add(this.ShipAgentList);
            this.panel1.Controls.Add(this.txtDestPort);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSearchShipAgentID);
            this.panel1.Controls.Add(this.lblVessel);
            this.panel1.Controls.Add(this.lblShipAgent);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtVesselName);
            this.panel1.Controls.Add(this.lblVoyage);
            this.panel1.Controls.Add(this.DestPortList);
            this.panel1.Controls.Add(this.txtVoyageNo);
            this.panel1.Controls.Add(this.lblETA);
            this.panel1.Controls.Add(this.txtSearchDestPortCode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblPortLoad);
            this.panel1.Controls.Add(this.lblOBLNo);
            this.panel1.Controls.Add(this.txtOceanBillNo);
            this.panel1.Controls.Add(this.txtSearchLoadPortCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.UnloadPortList);
            this.panel1.Controls.Add(this.LoadPortList);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSearchUnloadPort);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 691);
            this.panel1.TabIndex = 0;
            // 
            // btnAddCust
            // 
            this.btnAddCust.CausesValidation = false;
            this.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCust.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddCust.Location = new System.Drawing.Point(805, 228);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(123, 29);
            this.btnAddCust.TabIndex = 81;
            this.btnAddCust.Text = "Add New Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnAddPort
            // 
            this.btnAddPort.CausesValidation = false;
            this.btnAddPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPort.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddPort.Location = new System.Drawing.Point(697, 228);
            this.btnAddPort.Name = "btnAddPort";
            this.btnAddPort.Size = new System.Drawing.Size(102, 29);
            this.btnAddPort.TabIndex = 60;
            this.btnAddPort.Text = "Add New Port";
            this.btnAddPort.UseVisualStyleBackColor = true;
            this.btnAddPort.Click += new System.EventHandler(this.btnAddPort_Click);
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Controls.Add(this.btnCancel);
            this.pnlSave.Location = new System.Drawing.Point(873, 629);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(105, 56);
            this.pnlSave.TabIndex = 0;
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
            this.btnSave.TabIndex = 14;
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
            this.btnCancel.TabIndex = 0;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.btnBack);
            this.pnlEdit.Controls.Add(this.btnDel);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Location = new System.Drawing.Point(822, 632);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(159, 56);
            this.pnlEdit.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 41);
            this.btnBack.TabIndex = 0;
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
            this.btnDel.TabIndex = 0;
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
            this.btnEdit.TabIndex = 15;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // DtETA
            // 
            this.DtETA.Enabled = false;
            this.DtETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtETA.Location = new System.Drawing.Point(207, 152);
            this.DtETA.Name = "DtETA";
            this.DtETA.Size = new System.Drawing.Size(446, 20);
            this.DtETA.TabIndex = 0;
            // 
            // txtOceanBillConsignee
            // 
            this.txtOceanBillConsignee.BackColor = System.Drawing.Color.Black;
            this.txtOceanBillConsignee.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOceanBillConsignee.ForeColor = System.Drawing.Color.Yellow;
            this.txtOceanBillConsignee.Location = new System.Drawing.Point(371, 393);
            this.txtOceanBillConsignee.MaxLength = 15;
            this.txtOceanBillConsignee.Name = "txtOceanBillConsignee";
            this.txtOceanBillConsignee.ReadOnly = true;
            this.txtOceanBillConsignee.Size = new System.Drawing.Size(282, 23);
            this.txtOceanBillConsignee.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCN No :";
            // 
            // OceanBillConsigneeList
            // 
            this.OceanBillConsigneeList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.OceanBillConsigneeList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.OceanBillConsigneeList.BackColor = System.Drawing.Color.Black;
            this.OceanBillConsigneeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OceanBillConsigneeList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OceanBillConsigneeList.ForeColor = System.Drawing.Color.Yellow;
            this.OceanBillConsigneeList.FormattingEnabled = true;
            this.OceanBillConsigneeList.Location = new System.Drawing.Point(371, 393);
            this.OceanBillConsigneeList.Name = "OceanBillConsigneeList";
            this.OceanBillConsigneeList.Size = new System.Drawing.Size(298, 23);
            this.OceanBillConsigneeList.TabIndex = 13;
            this.OceanBillConsigneeList.Visible = false;
            // 
            // txtUnloadPort
            // 
            this.txtUnloadPort.BackColor = System.Drawing.Color.Black;
            this.txtUnloadPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnloadPort.ForeColor = System.Drawing.Color.Yellow;
            this.txtUnloadPort.Location = new System.Drawing.Point(371, 270);
            this.txtUnloadPort.MaxLength = 15;
            this.txtUnloadPort.Name = "txtUnloadPort";
            this.txtUnloadPort.ReadOnly = true;
            this.txtUnloadPort.Size = new System.Drawing.Size(282, 23);
            this.txtUnloadPort.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(346, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 15);
            this.label11.TabIndex = 78;
            this.label11.Text = "---";
            // 
            // txtSearchSCNNo
            // 
            this.txtSearchSCNNo.BackColor = System.Drawing.Color.Black;
            this.txtSearchSCNNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSCNNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchSCNNo.Location = new System.Drawing.Point(207, 28);
            this.txtSearchSCNNo.MaxLength = 15;
            this.txtSearchSCNNo.Name = "txtSearchSCNNo";
            this.txtSearchSCNNo.ReadOnly = true;
            this.txtSearchSCNNo.Size = new System.Drawing.Size(133, 23);
            this.txtSearchSCNNo.TabIndex = 1;
            this.txtSearchSCNNo.Leave += new System.EventHandler(this.txtSearchSCNNo_Leave);
            // 
            // txtSearchOceanBillConsigneeID
            // 
            this.txtSearchOceanBillConsigneeID.BackColor = System.Drawing.Color.Black;
            this.txtSearchOceanBillConsigneeID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchOceanBillConsigneeID.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchOceanBillConsigneeID.Location = new System.Drawing.Point(207, 393);
            this.txtSearchOceanBillConsigneeID.MaxLength = 15;
            this.txtSearchOceanBillConsigneeID.Name = "txtSearchOceanBillConsigneeID";
            this.txtSearchOceanBillConsigneeID.ReadOnly = true;
            this.txtSearchOceanBillConsigneeID.Size = new System.Drawing.Size(133, 23);
            this.txtSearchOceanBillConsigneeID.TabIndex = 12;
            this.txtSearchOceanBillConsigneeID.Leave += new System.EventHandler(this.txtSearchOceanBillConsigneeID_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 76;
            this.label10.Text = "OBL Consignee :";
            // 
            // txtSCNNo
            // 
            this.txtSCNNo.BackColor = System.Drawing.Color.Black;
            this.txtSCNNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSCNNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtSCNNo.Location = new System.Drawing.Point(371, 28);
            this.txtSCNNo.MaxLength = 15;
            this.txtSCNNo.Name = "txtSCNNo";
            this.txtSCNNo.ReadOnly = true;
            this.txtSCNNo.Size = new System.Drawing.Size(282, 23);
            this.txtSCNNo.TabIndex = 5;
            // 
            // txtLoadPort
            // 
            this.txtLoadPort.BackColor = System.Drawing.Color.Black;
            this.txtLoadPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoadPort.ForeColor = System.Drawing.Color.Yellow;
            this.txtLoadPort.Location = new System.Drawing.Point(371, 232);
            this.txtLoadPort.MaxLength = 15;
            this.txtLoadPort.Name = "txtLoadPort";
            this.txtLoadPort.ReadOnly = true;
            this.txtLoadPort.Size = new System.Drawing.Size(282, 23);
            this.txtLoadPort.TabIndex = 60;
            // 
            // txtShipAgent
            // 
            this.txtShipAgent.BackColor = System.Drawing.Color.Black;
            this.txtShipAgent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipAgent.ForeColor = System.Drawing.Color.Yellow;
            this.txtShipAgent.Location = new System.Drawing.Point(371, 351);
            this.txtShipAgent.MaxLength = 15;
            this.txtShipAgent.Name = "txtShipAgent";
            this.txtShipAgent.ReadOnly = true;
            this.txtShipAgent.Size = new System.Drawing.Size(282, 23);
            this.txtShipAgent.TabIndex = 75;
            // 
            // SCNNoList
            // 
            this.SCNNoList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SCNNoList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SCNNoList.BackColor = System.Drawing.Color.Black;
            this.SCNNoList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SCNNoList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCNNoList.ForeColor = System.Drawing.Color.Yellow;
            this.SCNNoList.FormattingEnabled = true;
            this.SCNNoList.Location = new System.Drawing.Point(371, 28);
            this.SCNNoList.Name = "SCNNoList";
            this.SCNNoList.Size = new System.Drawing.Size(298, 23);
            this.SCNNoList.TabIndex = 2;
            this.SCNNoList.Visible = false;
            this.SCNNoList.SelectedIndexChanged += new System.EventHandler(this.SCNNoList_SelectedIndexChanged);
            // 
            // ShipAgentList
            // 
            this.ShipAgentList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ShipAgentList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ShipAgentList.BackColor = System.Drawing.Color.Black;
            this.ShipAgentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShipAgentList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipAgentList.ForeColor = System.Drawing.Color.Yellow;
            this.ShipAgentList.FormattingEnabled = true;
            this.ShipAgentList.Location = new System.Drawing.Point(371, 351);
            this.ShipAgentList.Name = "ShipAgentList";
            this.ShipAgentList.Size = new System.Drawing.Size(298, 23);
            this.ShipAgentList.TabIndex = 11;
            this.ShipAgentList.Visible = false;
            // 
            // txtDestPort
            // 
            this.txtDestPort.BackColor = System.Drawing.Color.Black;
            this.txtDestPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestPort.ForeColor = System.Drawing.Color.Yellow;
            this.txtDestPort.Location = new System.Drawing.Point(371, 310);
            this.txtDestPort.MaxLength = 15;
            this.txtDestPort.Name = "txtDestPort";
            this.txtDestPort.ReadOnly = true;
            this.txtDestPort.Size = new System.Drawing.Size(282, 23);
            this.txtDestPort.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(346, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 73;
            this.label9.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(346, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "---";
            // 
            // txtSearchShipAgentID
            // 
            this.txtSearchShipAgentID.BackColor = System.Drawing.Color.Black;
            this.txtSearchShipAgentID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchShipAgentID.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchShipAgentID.Location = new System.Drawing.Point(207, 351);
            this.txtSearchShipAgentID.MaxLength = 15;
            this.txtSearchShipAgentID.Name = "txtSearchShipAgentID";
            this.txtSearchShipAgentID.ReadOnly = true;
            this.txtSearchShipAgentID.Size = new System.Drawing.Size(133, 23);
            this.txtSearchShipAgentID.TabIndex = 10;
            this.txtSearchShipAgentID.Leave += new System.EventHandler(this.txtSearchShipAgentID_Leave);
            // 
            // lblVessel
            // 
            this.lblVessel.AutoSize = true;
            this.lblVessel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVessel.Location = new System.Drawing.Point(137, 69);
            this.lblVessel.Name = "lblVessel";
            this.lblVessel.Size = new System.Drawing.Size(64, 16);
            this.lblVessel.TabIndex = 46;
            this.lblVessel.Text = "Vessel :";
            // 
            // lblShipAgent
            // 
            this.lblShipAgent.AutoSize = true;
            this.lblShipAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipAgent.Location = new System.Drawing.Point(110, 353);
            this.lblShipAgent.Name = "lblShipAgent";
            this.lblShipAgent.Size = new System.Drawing.Size(91, 16);
            this.lblShipAgent.TabIndex = 71;
            this.lblShipAgent.Text = "Ship Agent :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(346, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 68;
            this.label8.Text = "---";
            // 
            // txtVesselName
            // 
            this.txtVesselName.BackColor = System.Drawing.Color.Black;
            this.txtVesselName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVesselName.ForeColor = System.Drawing.Color.Yellow;
            this.txtVesselName.Location = new System.Drawing.Point(207, 67);
            this.txtVesselName.MaxLength = 15;
            this.txtVesselName.Name = "txtVesselName";
            this.txtVesselName.ReadOnly = true;
            this.txtVesselName.Size = new System.Drawing.Size(446, 23);
            this.txtVesselName.TabIndex = 0;
            // 
            // lblVoyage
            // 
            this.lblVoyage.AutoSize = true;
            this.lblVoyage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoyage.Location = new System.Drawing.Point(131, 112);
            this.lblVoyage.Name = "lblVoyage";
            this.lblVoyage.Size = new System.Drawing.Size(70, 16);
            this.lblVoyage.TabIndex = 51;
            this.lblVoyage.Text = "Voyage :";
            // 
            // DestPortList
            // 
            this.DestPortList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DestPortList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DestPortList.BackColor = System.Drawing.Color.Black;
            this.DestPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestPortList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestPortList.ForeColor = System.Drawing.Color.Yellow;
            this.DestPortList.FormattingEnabled = true;
            this.DestPortList.Location = new System.Drawing.Point(371, 310);
            this.DestPortList.Name = "DestPortList";
            this.DestPortList.Size = new System.Drawing.Size(298, 23);
            this.DestPortList.TabIndex = 9;
            this.DestPortList.Visible = false;
            // 
            // txtVoyageNo
            // 
            this.txtVoyageNo.BackColor = System.Drawing.Color.Black;
            this.txtVoyageNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoyageNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtVoyageNo.Location = new System.Drawing.Point(207, 110);
            this.txtVoyageNo.MaxLength = 100000000;
            this.txtVoyageNo.Name = "txtVoyageNo";
            this.txtVoyageNo.ReadOnly = true;
            this.txtVoyageNo.Size = new System.Drawing.Size(446, 23);
            this.txtVoyageNo.TabIndex = 0;
            // 
            // lblETA
            // 
            this.lblETA.AutoSize = true;
            this.lblETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETA.Location = new System.Drawing.Point(151, 156);
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(50, 16);
            this.lblETA.TabIndex = 55;
            this.lblETA.Text = "ETA : ";
            // 
            // txtSearchDestPortCode
            // 
            this.txtSearchDestPortCode.BackColor = System.Drawing.Color.Black;
            this.txtSearchDestPortCode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDestPortCode.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchDestPortCode.Location = new System.Drawing.Point(207, 310);
            this.txtSearchDestPortCode.MaxLength = 15;
            this.txtSearchDestPortCode.Name = "txtSearchDestPortCode";
            this.txtSearchDestPortCode.ReadOnly = true;
            this.txtSearchDestPortCode.Size = new System.Drawing.Size(133, 23);
            this.txtSearchDestPortCode.TabIndex = 8;
            this.txtSearchDestPortCode.Leave += new System.EventHandler(this.txtSearchDestPortCode_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "Destination Port :";
            // 
            // lblPortLoad
            // 
            this.lblPortLoad.AutoSize = true;
            this.lblPortLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortLoad.Location = new System.Drawing.Point(80, 234);
            this.lblPortLoad.Name = "lblPortLoad";
            this.lblPortLoad.Size = new System.Drawing.Size(121, 16);
            this.lblPortLoad.TabIndex = 56;
            this.lblPortLoad.Text = "Port of Loading :";
            // 
            // lblOBLNo
            // 
            this.lblOBLNo.AutoSize = true;
            this.lblOBLNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBLNo.Location = new System.Drawing.Point(132, 194);
            this.lblOBLNo.Name = "lblOBLNo";
            this.lblOBLNo.Size = new System.Drawing.Size(69, 16);
            this.lblOBLNo.TabIndex = 53;
            this.lblOBLNo.Text = "OBL No :";
            // 
            // txtOceanBillNo
            // 
            this.txtOceanBillNo.BackColor = System.Drawing.Color.Black;
            this.txtOceanBillNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOceanBillNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtOceanBillNo.Location = new System.Drawing.Point(207, 192);
            this.txtOceanBillNo.MaxLength = 100000000;
            this.txtOceanBillNo.Name = "txtOceanBillNo";
            this.txtOceanBillNo.ReadOnly = true;
            this.txtOceanBillNo.Size = new System.Drawing.Size(446, 23);
            this.txtOceanBillNo.TabIndex = 3;
            // 
            // txtSearchLoadPortCode
            // 
            this.txtSearchLoadPortCode.BackColor = System.Drawing.Color.Black;
            this.txtSearchLoadPortCode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLoadPortCode.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchLoadPortCode.Location = new System.Drawing.Point(207, 232);
            this.txtSearchLoadPortCode.MaxLength = 15;
            this.txtSearchLoadPortCode.Name = "txtSearchLoadPortCode";
            this.txtSearchLoadPortCode.ReadOnly = true;
            this.txtSearchLoadPortCode.Size = new System.Drawing.Size(133, 23);
            this.txtSearchLoadPortCode.TabIndex = 4;
            this.txtSearchLoadPortCode.Leave += new System.EventHandler(this.txtSearchLoadPortCode_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(346, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "---";
            // 
            // UnloadPortList
            // 
            this.UnloadPortList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UnloadPortList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UnloadPortList.BackColor = System.Drawing.Color.Black;
            this.UnloadPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnloadPortList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnloadPortList.ForeColor = System.Drawing.Color.Yellow;
            this.UnloadPortList.FormattingEnabled = true;
            this.UnloadPortList.Location = new System.Drawing.Point(371, 270);
            this.UnloadPortList.Name = "UnloadPortList";
            this.UnloadPortList.Size = new System.Drawing.Size(298, 23);
            this.UnloadPortList.TabIndex = 7;
            this.UnloadPortList.Visible = false;
            // 
            // LoadPortList
            // 
            this.LoadPortList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LoadPortList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LoadPortList.BackColor = System.Drawing.Color.Black;
            this.LoadPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoadPortList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortList.ForeColor = System.Drawing.Color.Yellow;
            this.LoadPortList.FormattingEnabled = true;
            this.LoadPortList.Location = new System.Drawing.Point(371, 232);
            this.LoadPortList.Name = "LoadPortList";
            this.LoadPortList.Size = new System.Drawing.Size(298, 23);
            this.LoadPortList.TabIndex = 5;
            this.LoadPortList.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(346, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 63;
            this.label5.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Port of Unloading :";
            // 
            // txtSearchUnloadPort
            // 
            this.txtSearchUnloadPort.BackColor = System.Drawing.Color.Black;
            this.txtSearchUnloadPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUnloadPort.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchUnloadPort.Location = new System.Drawing.Point(207, 270);
            this.txtSearchUnloadPort.MaxLength = 15;
            this.txtSearchUnloadPort.Name = "txtSearchUnloadPort";
            this.txtSearchUnloadPort.ReadOnly = true;
            this.txtSearchUnloadPort.Size = new System.Drawing.Size(133, 23);
            this.txtSearchUnloadPort.TabIndex = 6;
            this.txtSearchUnloadPort.Leave += new System.EventHandler(this.txtSearchUnloadPort_Leave);
            // 
            // OceanBillAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOBLID);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OceanBillAED";
            this.ShowIcon = false;
            this.Text = "Ocean Bill Details";
            this.Load += new System.EventHandler(this.OceanBillAED_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSave.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblOBLID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchSCNNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SCNNoList;
        private System.Windows.Forms.TextBox txtSCNNo;
        private System.Windows.Forms.TextBox txtVesselName;
        private System.Windows.Forms.Label lblVessel;
        private System.Windows.Forms.TextBox txtOceanBillNo;
        private System.Windows.Forms.Label lblOBLNo;
        private System.Windows.Forms.TextBox txtVoyageNo;
        private System.Windows.Forms.Label lblVoyage;
        private System.Windows.Forms.Label lblETA;
        private System.Windows.Forms.TextBox txtLoadPort;
        private System.Windows.Forms.ComboBox LoadPortList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchLoadPortCode;
        private System.Windows.Forms.Label lblPortLoad;
        private System.Windows.Forms.TextBox txtOceanBillConsignee;
        private System.Windows.Forms.ComboBox OceanBillConsigneeList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchOceanBillConsigneeID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtShipAgent;
        private System.Windows.Forms.ComboBox ShipAgentList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchShipAgentID;
        private System.Windows.Forms.Label lblShipAgent;
        private System.Windows.Forms.TextBox txtDestPort;
        private System.Windows.Forms.ComboBox DestPortList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchDestPortCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnloadPort;
        private System.Windows.Forms.ComboBox UnloadPortList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchUnloadPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker DtETA;
        private System.Windows.Forms.Button btnAddPort;
        private System.Windows.Forms.Button btnAddCust;
    }
}