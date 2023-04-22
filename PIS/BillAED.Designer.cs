namespace PIS
{
    partial class BillAED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillAED));
            this.lblOBL = new System.Windows.Forms.Label();
            this.lblOBLID = new System.Windows.Forms.Label();
            this.lblHouseBillNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.PortList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarking = new System.Windows.Forms.TextBox();
            this.lblMarking = new System.Windows.Forms.Label();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtGoodsQty = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.ClassList = new System.Windows.Forms.ComboBox();
            this.txtSearchClassCode = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.rbShipmentNo = new System.Windows.Forms.RadioButton();
            this.rbShipmentYes = new System.Windows.Forms.RadioButton();
            this.lblTranshipment = new System.Windows.Forms.Label();
            this.txtConsignee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchConsignee = new System.Windows.Forms.TextBox();
            this.lblConsignee = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchUnitID = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtCargoDesc = new System.Windows.Forms.TextBox();
            this.lblCargoDesc = new System.Windows.Forms.Label();
            this.txtHouseBillNo = new System.Windows.Forms.TextBox();
            this.UnitList = new System.Windows.Forms.ComboBox();
            this.ConsigneeList = new System.Windows.Forms.ComboBox();
            this.lblHBL = new System.Windows.Forms.Label();
            this.lblHBLID = new System.Windows.Forms.Label();
            this.lblCont = new System.Windows.Forms.Label();
            this.lblContID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOBL
            // 
            this.lblOBL.AutoSize = true;
            this.lblOBL.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBL.ForeColor = System.Drawing.SystemColors.Info;
            this.lblOBL.Location = new System.Drawing.Point(12, 9);
            this.lblOBL.Name = "lblOBL";
            this.lblOBL.Size = new System.Drawing.Size(50, 15);
            this.lblOBL.TabIndex = 0;
            this.lblOBL.Tag = "cv";
            this.lblOBL.Text = "OBL ID :";
            this.lblOBL.Visible = false;
            // 
            // lblOBLID
            // 
            this.lblOBLID.AutoSize = true;
            this.lblOBLID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblOBLID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBLID.ForeColor = System.Drawing.Color.White;
            this.lblOBLID.Location = new System.Drawing.Point(63, 9);
            this.lblOBLID.Name = "lblOBLID";
            this.lblOBLID.Size = new System.Drawing.Size(14, 15);
            this.lblOBLID.TabIndex = 0;
            this.lblOBLID.Text = "0";
            this.lblOBLID.Visible = false;
            // 
            // lblHouseBillNo
            // 
            this.lblHouseBillNo.AutoSize = true;
            this.lblHouseBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseBillNo.ForeColor = System.Drawing.Color.White;
            this.lblHouseBillNo.Location = new System.Drawing.Point(31, 27);
            this.lblHouseBillNo.Name = "lblHouseBillNo";
            this.lblHouseBillNo.Size = new System.Drawing.Size(111, 16);
            this.lblHouseBillNo.TabIndex = 0;
            this.lblHouseBillNo.Text = "House Bill No :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddCust);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.PortList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearchPort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMarking);
            this.panel1.Controls.Add(this.lblMarking);
            this.panel1.Controls.Add(this.pnlSave);
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtVolume);
            this.panel1.Controls.Add(this.txtGoodsQty);
            this.panel1.Controls.Add(this.lblVolume);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.Controls.Add(this.lblWeight);
            this.panel1.Controls.Add(this.lblQty);
            this.panel1.Controls.Add(this.txtClass);
            this.panel1.Controls.Add(this.ClassList);
            this.panel1.Controls.Add(this.txtSearchClassCode);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.rbShipmentNo);
            this.panel1.Controls.Add(this.rbShipmentYes);
            this.panel1.Controls.Add(this.lblTranshipment);
            this.panel1.Controls.Add(this.txtConsignee);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSearchConsignee);
            this.panel1.Controls.Add(this.lblConsignee);
            this.panel1.Controls.Add(this.txtUnit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSearchUnitID);
            this.panel1.Controls.Add(this.lblUnit);
            this.panel1.Controls.Add(this.txtCargoDesc);
            this.panel1.Controls.Add(this.lblCargoDesc);
            this.panel1.Controls.Add(this.txtHouseBillNo);
            this.panel1.Controls.Add(this.lblHouseBillNo);
            this.panel1.Controls.Add(this.UnitList);
            this.panel1.Controls.Add(this.ConsigneeList);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 687);
            this.panel1.TabIndex = 0;
            // 
            // btnAddCust
            // 
            this.btnAddCust.CausesValidation = false;
            this.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCust.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddCust.Location = new System.Drawing.Point(503, 59);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(123, 29);
            this.btnAddCust.TabIndex = 111;
            this.btnAddCust.Text = "Add New Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.Black;
            this.txtPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.Yellow;
            this.txtPort.Location = new System.Drawing.Point(292, 404);
            this.txtPort.MaxLength = 15;
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = true;
            this.txtPort.Size = new System.Drawing.Size(192, 23);
            this.txtPort.TabIndex = 110;
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
            this.PortList.Location = new System.Drawing.Point(292, 404);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(192, 23);
            this.PortList.TabIndex = 15;
            this.PortList.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(267, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 108;
            this.label2.Text = "---";
            // 
            // txtSearchPort
            // 
            this.txtSearchPort.BackColor = System.Drawing.Color.Black;
            this.txtSearchPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPort.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchPort.Location = new System.Drawing.Point(161, 404);
            this.txtSearchPort.MaxLength = 15;
            this.txtSearchPort.Name = "txtSearchPort";
            this.txtSearchPort.ReadOnly = true;
            this.txtSearchPort.Size = new System.Drawing.Size(100, 23);
            this.txtSearchPort.TabIndex = 14;
            this.txtSearchPort.Leave += new System.EventHandler(this.txtSearchPort_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 106;
            this.label1.Text = "Port :";
            // 
            // txtMarking
            // 
            this.txtMarking.BackColor = System.Drawing.Color.Black;
            this.txtMarking.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarking.ForeColor = System.Drawing.Color.Yellow;
            this.txtMarking.Location = new System.Drawing.Point(161, 297);
            this.txtMarking.MaxLength = 100000000;
            this.txtMarking.Multiline = true;
            this.txtMarking.Name = "txtMarking";
            this.txtMarking.ReadOnly = true;
            this.txtMarking.Size = new System.Drawing.Size(323, 61);
            this.txtMarking.TabIndex = 11;
            // 
            // lblMarking
            // 
            this.lblMarking.AutoSize = true;
            this.lblMarking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarking.ForeColor = System.Drawing.Color.White;
            this.lblMarking.Location = new System.Drawing.Point(71, 299);
            this.lblMarking.Name = "lblMarking";
            this.lblMarking.Size = new System.Drawing.Size(71, 16);
            this.lblMarking.TabIndex = 105;
            this.lblMarking.Text = "Marking :";
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Controls.Add(this.btnCancel);
            this.pnlSave.Location = new System.Drawing.Point(853, 625);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(121, 56);
            this.pnlSave.TabIndex = 17;
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
            this.btnSave.TabIndex = 18;
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
            this.btnCancel.TabIndex = 19;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.btnBack);
            this.pnlEdit.Controls.Add(this.btnDel);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Location = new System.Drawing.Point(803, 628);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(174, 56);
            this.pnlEdit.TabIndex = 20;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(27, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 41);
            this.btnBack.TabIndex = 21;
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
            this.btnDel.TabIndex = 23;
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
            this.btnEdit.TabIndex = 22;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(267, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 101;
            this.label6.Text = "---";
            // 
            // txtVolume
            // 
            this.txtVolume.BackColor = System.Drawing.Color.Black;
            this.txtVolume.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.ForeColor = System.Drawing.Color.Yellow;
            this.txtVolume.Location = new System.Drawing.Point(161, 264);
            this.txtVolume.MaxLength = 100000000;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(100, 23);
            this.txtVolume.TabIndex = 10;
            this.txtVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolume_KeyPress);
            // 
            // txtGoodsQty
            // 
            this.txtGoodsQty.BackColor = System.Drawing.Color.Black;
            this.txtGoodsQty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsQty.ForeColor = System.Drawing.Color.Yellow;
            this.txtGoodsQty.Location = new System.Drawing.Point(161, 146);
            this.txtGoodsQty.MaxLength = 100000000;
            this.txtGoodsQty.Name = "txtGoodsQty";
            this.txtGoodsQty.ReadOnly = true;
            this.txtGoodsQty.Size = new System.Drawing.Size(100, 23);
            this.txtGoodsQty.TabIndex = 6;
            this.txtGoodsQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsQty_KeyPress);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(40, 266);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(102, 16);
            this.lblVolume.TabIndex = 89;
            this.lblVolume.Text = "Volume (M3) :";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.Black;
            this.txtWeight.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ForeColor = System.Drawing.Color.Yellow;
            this.txtWeight.Location = new System.Drawing.Point(161, 227);
            this.txtWeight.MaxLength = 100000000;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(100, 23);
            this.txtWeight.TabIndex = 9;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(36, 229);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(106, 16);
            this.lblWeight.TabIndex = 87;
            this.lblWeight.Text = "Weight (KGs) :";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(66, 148);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(76, 16);
            this.lblQty.TabIndex = 84;
            this.lblQty.Text = "Quantity : ";
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.Color.Black;
            this.txtClass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.ForeColor = System.Drawing.Color.Yellow;
            this.txtClass.Location = new System.Drawing.Point(292, 106);
            this.txtClass.MaxLength = 15;
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(192, 23);
            this.txtClass.TabIndex = 83;
            // 
            // ClassList
            // 
            this.ClassList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClassList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClassList.BackColor = System.Drawing.Color.Black;
            this.ClassList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassList.ForeColor = System.Drawing.Color.Yellow;
            this.ClassList.FormattingEnabled = true;
            this.ClassList.Location = new System.Drawing.Point(292, 106);
            this.ClassList.Name = "ClassList";
            this.ClassList.Size = new System.Drawing.Size(192, 23);
            this.ClassList.TabIndex = 5;
            this.ClassList.Visible = false;
            // 
            // txtSearchClassCode
            // 
            this.txtSearchClassCode.BackColor = System.Drawing.Color.Black;
            this.txtSearchClassCode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchClassCode.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchClassCode.Location = new System.Drawing.Point(161, 106);
            this.txtSearchClassCode.MaxLength = 15;
            this.txtSearchClassCode.Name = "txtSearchClassCode";
            this.txtSearchClassCode.ReadOnly = true;
            this.txtSearchClassCode.Size = new System.Drawing.Size(100, 23);
            this.txtSearchClassCode.TabIndex = 4;
            this.txtSearchClassCode.Leave += new System.EventHandler(this.txtSearchClassCode_Leave);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.White;
            this.lblClass.Location = new System.Drawing.Point(87, 108);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(55, 16);
            this.lblClass.TabIndex = 79;
            this.lblClass.Text = "Class :";
            // 
            // rbShipmentNo
            // 
            this.rbShipmentNo.AutoSize = true;
            this.rbShipmentNo.Checked = true;
            this.rbShipmentNo.ForeColor = System.Drawing.Color.White;
            this.rbShipmentNo.Location = new System.Drawing.Point(161, 366);
            this.rbShipmentNo.Name = "rbShipmentNo";
            this.rbShipmentNo.Size = new System.Drawing.Size(44, 20);
            this.rbShipmentNo.TabIndex = 13;
            this.rbShipmentNo.TabStop = true;
            this.rbShipmentNo.Text = "No";
            this.rbShipmentNo.UseVisualStyleBackColor = true;
            // 
            // rbShipmentYes
            // 
            this.rbShipmentYes.AutoSize = true;
            this.rbShipmentYes.ForeColor = System.Drawing.Color.White;
            this.rbShipmentYes.Location = new System.Drawing.Point(216, 366);
            this.rbShipmentYes.Name = "rbShipmentYes";
            this.rbShipmentYes.Size = new System.Drawing.Size(50, 20);
            this.rbShipmentYes.TabIndex = 12;
            this.rbShipmentYes.Text = "Yes";
            this.rbShipmentYes.UseVisualStyleBackColor = true;
            this.rbShipmentYes.CheckedChanged += new System.EventHandler(this.rbShipmentYes_CheckedChanged);
            // 
            // lblTranshipment
            // 
            this.lblTranshipment.AutoSize = true;
            this.lblTranshipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranshipment.ForeColor = System.Drawing.Color.White;
            this.lblTranshipment.Location = new System.Drawing.Point(32, 366);
            this.lblTranshipment.Name = "lblTranshipment";
            this.lblTranshipment.Size = new System.Drawing.Size(110, 16);
            this.lblTranshipment.TabIndex = 74;
            this.lblTranshipment.Text = "Transhipment :";
            // 
            // txtConsignee
            // 
            this.txtConsignee.BackColor = System.Drawing.Color.Black;
            this.txtConsignee.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsignee.ForeColor = System.Drawing.Color.Yellow;
            this.txtConsignee.Location = new System.Drawing.Point(292, 65);
            this.txtConsignee.MaxLength = 15;
            this.txtConsignee.Name = "txtConsignee";
            this.txtConsignee.ReadOnly = true;
            this.txtConsignee.Size = new System.Drawing.Size(192, 23);
            this.txtConsignee.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(267, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 69;
            this.label4.Text = "---";
            // 
            // txtSearchConsignee
            // 
            this.txtSearchConsignee.BackColor = System.Drawing.Color.Black;
            this.txtSearchConsignee.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchConsignee.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchConsignee.Location = new System.Drawing.Point(161, 65);
            this.txtSearchConsignee.MaxLength = 15;
            this.txtSearchConsignee.Name = "txtSearchConsignee";
            this.txtSearchConsignee.ReadOnly = true;
            this.txtSearchConsignee.Size = new System.Drawing.Size(100, 23);
            this.txtSearchConsignee.TabIndex = 2;
            this.txtSearchConsignee.Leave += new System.EventHandler(this.txtSearchConsignee_Leave);
            // 
            // lblConsignee
            // 
            this.lblConsignee.AutoSize = true;
            this.lblConsignee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsignee.ForeColor = System.Drawing.Color.White;
            this.lblConsignee.Location = new System.Drawing.Point(52, 67);
            this.lblConsignee.Name = "lblConsignee";
            this.lblConsignee.Size = new System.Drawing.Size(90, 16);
            this.lblConsignee.TabIndex = 67;
            this.lblConsignee.Text = "Consignee :";
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.Black;
            this.txtUnit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.ForeColor = System.Drawing.Color.Yellow;
            this.txtUnit.Location = new System.Drawing.Point(292, 189);
            this.txtUnit.MaxLength = 15;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(192, 23);
            this.txtUnit.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(267, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "---";
            // 
            // txtSearchUnitID
            // 
            this.txtSearchUnitID.BackColor = System.Drawing.Color.Black;
            this.txtSearchUnitID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUnitID.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchUnitID.Location = new System.Drawing.Point(161, 186);
            this.txtSearchUnitID.MaxLength = 15;
            this.txtSearchUnitID.Name = "txtSearchUnitID";
            this.txtSearchUnitID.ReadOnly = true;
            this.txtSearchUnitID.Size = new System.Drawing.Size(100, 23);
            this.txtSearchUnitID.TabIndex = 7;
            this.txtSearchUnitID.Leave += new System.EventHandler(this.txtSearchUnitID_Leave);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.White;
            this.lblUnit.Location = new System.Drawing.Point(64, 188);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(78, 16);
            this.lblUnit.TabIndex = 62;
            this.lblUnit.Text = "Package :";
            // 
            // txtCargoDesc
            // 
            this.txtCargoDesc.BackColor = System.Drawing.Color.Black;
            this.txtCargoDesc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoDesc.ForeColor = System.Drawing.Color.Yellow;
            this.txtCargoDesc.Location = new System.Drawing.Point(161, 446);
            this.txtCargoDesc.MaxLength = 100000000;
            this.txtCargoDesc.Multiline = true;
            this.txtCargoDesc.Name = "txtCargoDesc";
            this.txtCargoDesc.ReadOnly = true;
            this.txtCargoDesc.Size = new System.Drawing.Size(323, 64);
            this.txtCargoDesc.TabIndex = 16;
            // 
            // lblCargoDesc
            // 
            this.lblCargoDesc.AutoSize = true;
            this.lblCargoDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoDesc.ForeColor = System.Drawing.Color.White;
            this.lblCargoDesc.Location = new System.Drawing.Point(44, 448);
            this.lblCargoDesc.Name = "lblCargoDesc";
            this.lblCargoDesc.Size = new System.Drawing.Size(98, 16);
            this.lblCargoDesc.TabIndex = 60;
            this.lblCargoDesc.Text = "Cargo Desc :";
            // 
            // txtHouseBillNo
            // 
            this.txtHouseBillNo.BackColor = System.Drawing.Color.Black;
            this.txtHouseBillNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouseBillNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtHouseBillNo.Location = new System.Drawing.Point(161, 25);
            this.txtHouseBillNo.MaxLength = 100000000;
            this.txtHouseBillNo.Name = "txtHouseBillNo";
            this.txtHouseBillNo.ReadOnly = true;
            this.txtHouseBillNo.Size = new System.Drawing.Size(323, 23);
            this.txtHouseBillNo.TabIndex = 1;
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
            this.UnitList.Location = new System.Drawing.Point(292, 189);
            this.UnitList.Name = "UnitList";
            this.UnitList.Size = new System.Drawing.Size(192, 23);
            this.UnitList.TabIndex = 8;
            this.UnitList.Visible = false;
            // 
            // ConsigneeList
            // 
            this.ConsigneeList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ConsigneeList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ConsigneeList.BackColor = System.Drawing.Color.Black;
            this.ConsigneeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsigneeList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsigneeList.ForeColor = System.Drawing.Color.Yellow;
            this.ConsigneeList.FormattingEnabled = true;
            this.ConsigneeList.Location = new System.Drawing.Point(292, 65);
            this.ConsigneeList.Name = "ConsigneeList";
            this.ConsigneeList.Size = new System.Drawing.Size(192, 23);
            this.ConsigneeList.TabIndex = 3;
            this.ConsigneeList.Visible = false;
            // 
            // lblHBL
            // 
            this.lblHBL.AutoSize = true;
            this.lblHBL.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHBL.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHBL.Location = new System.Drawing.Point(170, 9);
            this.lblHBL.Name = "lblHBL";
            this.lblHBL.Size = new System.Drawing.Size(49, 15);
            this.lblHBL.TabIndex = 0;
            this.lblHBL.Tag = "cv";
            this.lblHBL.Text = "HBL ID :";
            this.lblHBL.Visible = false;
            // 
            // lblHBLID
            // 
            this.lblHBLID.AutoSize = true;
            this.lblHBLID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblHBLID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHBLID.ForeColor = System.Drawing.Color.White;
            this.lblHBLID.Location = new System.Drawing.Point(225, 9);
            this.lblHBLID.Name = "lblHBLID";
            this.lblHBLID.Size = new System.Drawing.Size(14, 15);
            this.lblHBLID.TabIndex = 0;
            this.lblHBLID.Text = "0";
            this.lblHBLID.Visible = false;
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCont.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCont.Location = new System.Drawing.Point(301, 9);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(54, 15);
            this.lblCont.TabIndex = 0;
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
            this.lblContID.Location = new System.Drawing.Point(361, 9);
            this.lblContID.Name = "lblContID";
            this.lblContID.Size = new System.Drawing.Size(14, 15);
            this.lblContID.TabIndex = 0;
            this.lblContID.Text = "0";
            this.lblContID.Visible = false;
            // 
            // BillAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1004, 726);
            this.Controls.Add(this.lblContID);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.lblHBLID);
            this.Controls.Add(this.lblHBL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOBLID);
            this.Controls.Add(this.lblOBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillAED";
            this.ShowIcon = false;
            this.Text = "Bill Details";
            this.Load += new System.EventHandler(this.BillAED_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSave.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOBL;
        private System.Windows.Forms.Label lblOBLID;
        private System.Windows.Forms.Label lblHouseBillNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHouseBillNo;
        private System.Windows.Forms.TextBox txtConsignee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchConsignee;
        private System.Windows.Forms.Label lblConsignee;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchUnitID;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtCargoDesc;
        private System.Windows.Forms.Label lblCargoDesc;
        private System.Windows.Forms.ComboBox UnitList;
        private System.Windows.Forms.ComboBox ConsigneeList;
        private System.Windows.Forms.RadioButton rbShipmentNo;
        private System.Windows.Forms.RadioButton rbShipmentYes;
        private System.Windows.Forms.Label lblTranshipment;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.ComboBox ClassList;
        private System.Windows.Forms.TextBox txtSearchClassCode;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtGoodsQty;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHBL;
        private System.Windows.Forms.Label lblHBLID;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtMarking;
        private System.Windows.Forms.Label lblMarking;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Label lblContID;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCust;
    }
}