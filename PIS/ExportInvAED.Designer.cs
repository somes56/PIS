namespace PIS
{
    partial class ExportInvAED
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportInvAED));
            this.lblID = new System.Windows.Forms.Label();
            this.lblInvID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoxInvoiceItemDetails = new System.Windows.Forms.GroupBox();
            this.lblTotalAmountWords = new System.Windows.Forms.Label();
            this.lblAmountInWords = new System.Windows.Forms.Label();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.lblTtlInv = new System.Windows.Forms.Label();
            this.txtTtlInv = new System.Windows.Forms.TextBox();
            this.BoxAddItems = new System.Windows.Forms.GroupBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtItemQty = new System.Windows.Forms.TextBox();
            this.lblItemQty = new System.Windows.Forms.Label();
            this.ItemsList = new System.Windows.Forms.ComboBox();
            this.txtSearchItems = new System.Windows.Forms.TextBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblItemsID = new System.Windows.Forms.Label();
            this.lblAddItems = new System.Windows.Forms.Label();
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.btnGenerateInv = new System.Windows.Forms.Button();
            this.BoxInvoiceDetails = new System.Windows.Forms.GroupBox();
            this.dtDatePacked = new System.Windows.Forms.DateTimePicker();
            this.txtCFSNo = new System.Windows.Forms.TextBox();
            this.txtBillTo = new System.Windows.Forms.TextBox();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.lblDatePacked = new System.Windows.Forms.Label();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.dtDateReceived = new System.Windows.Forms.DateTimePicker();
            this.lblOperator = new System.Windows.Forms.Label();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblDestinationPort = new System.Windows.Forms.Label();
            this.txtDestinationPort = new System.Windows.Forms.TextBox();
            this.lblContainerNo = new System.Windows.Forms.Label();
            this.txtContainerNo = new System.Windows.Forms.TextBox();
            this.CFSList = new System.Windows.Forms.ComboBox();
            this.lblCFSNo = new System.Windows.Forms.Label();
            this.BillToList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBillTo = new System.Windows.Forms.TextBox();
            this.lblConsignee = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtVoyage = new System.Windows.Forms.TextBox();
            this.lblVoyage = new System.Windows.Forms.Label();
            this.txtStorageDays = new System.Windows.Forms.TextBox();
            this.lblStorageDays = new System.Windows.Forms.Label();
            this.txtSCNNo = new System.Windows.Forms.TextBox();
            this.lblSCN = new System.Windows.Forms.Label();
            this.txtVessel = new System.Windows.Forms.TextBox();
            this.lblVessel = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblInvNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchCFSNo = new System.Windows.Forms.TextBox();
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.lblIDCP = new System.Windows.Forms.Label();
            this.lblCPID = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.panelMethod = new System.Windows.Forms.Panel();
            this.rbOnlineTransfer = new System.Windows.Forms.RadioButton();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.BoxInvoiceItemDetails.SuspendLayout();
            this.BoxAddItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.BoxInvoiceDetails.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.panelMethod.SuspendLayout();
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
            this.lblID.TabIndex = 6;
            this.lblID.Tag = "cv";
            this.lblID.Text = "ID :";
            this.lblID.Visible = false;
            // 
            // lblInvID
            // 
            this.lblInvID.AutoSize = true;
            this.lblInvID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblInvID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvID.ForeColor = System.Drawing.Color.White;
            this.lblInvID.Location = new System.Drawing.Point(43, 9);
            this.lblInvID.Name = "lblInvID";
            this.lblInvID.Size = new System.Drawing.Size(14, 15);
            this.lblInvID.TabIndex = 17;
            this.lblInvID.Text = "0";
            this.lblInvID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BoxInvoiceItemDetails);
            this.panel1.Controls.Add(this.BoxInvoiceDetails);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 650);
            this.panel1.TabIndex = 18;
            // 
            // BoxInvoiceItemDetails
            // 
            this.BoxInvoiceItemDetails.Controls.Add(this.lblTotalAmountWords);
            this.BoxInvoiceItemDetails.Controls.Add(this.lblAmountInWords);
            this.BoxInvoiceItemDetails.Controls.Add(this.btnPrintInvoice);
            this.BoxInvoiceItemDetails.Controls.Add(this.lblTtlInv);
            this.BoxInvoiceItemDetails.Controls.Add(this.txtTtlInv);
            this.BoxInvoiceItemDetails.Controls.Add(this.BoxAddItems);
            this.BoxInvoiceItemDetails.Controls.Add(this.dgvInv);
            this.BoxInvoiceItemDetails.Controls.Add(this.btnGenerateInv);
            this.BoxInvoiceItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxInvoiceItemDetails.ForeColor = System.Drawing.Color.White;
            this.BoxInvoiceItemDetails.Location = new System.Drawing.Point(3, 372);
            this.BoxInvoiceItemDetails.Name = "BoxInvoiceItemDetails";
            this.BoxInvoiceItemDetails.Size = new System.Drawing.Size(1316, 275);
            this.BoxInvoiceItemDetails.TabIndex = 49;
            this.BoxInvoiceItemDetails.TabStop = false;
            this.BoxInvoiceItemDetails.Text = "INVOICE ITEM DETAILS";
            // 
            // lblTotalAmountWords
            // 
            this.lblTotalAmountWords.AutoSize = true;
            this.lblTotalAmountWords.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalAmountWords.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountWords.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmountWords.Location = new System.Drawing.Point(9, 240);
            this.lblTotalAmountWords.Name = "lblTotalAmountWords";
            this.lblTotalAmountWords.Size = new System.Drawing.Size(14, 15);
            this.lblTotalAmountWords.TabIndex = 81;
            this.lblTotalAmountWords.Text = "0";
            this.lblTotalAmountWords.Visible = false;
            // 
            // lblAmountInWords
            // 
            this.lblAmountInWords.AutoSize = true;
            this.lblAmountInWords.Location = new System.Drawing.Point(9, 242);
            this.lblAmountInWords.Name = "lblAmountInWords";
            this.lblAmountInWords.Size = new System.Drawing.Size(0, 13);
            this.lblAmountInWords.TabIndex = 80;
            this.lblAmountInWords.Visible = false;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.CausesValidation = false;
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPrintInvoice.Location = new System.Drawing.Point(791, 83);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(75, 46);
            this.btnPrintInvoice.TabIndex = 79;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // lblTtlInv
            // 
            this.lblTtlInv.AutoSize = true;
            this.lblTtlInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlInv.Location = new System.Drawing.Point(634, 242);
            this.lblTtlInv.Name = "lblTtlInv";
            this.lblTtlInv.Size = new System.Drawing.Size(52, 16);
            this.lblTtlInv.TabIndex = 78;
            this.lblTtlInv.Text = "Total :";
            // 
            // txtTtlInv
            // 
            this.txtTtlInv.BackColor = System.Drawing.Color.Black;
            this.txtTtlInv.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTtlInv.ForeColor = System.Drawing.Color.Yellow;
            this.txtTtlInv.Location = new System.Drawing.Point(692, 240);
            this.txtTtlInv.MaxLength = 15;
            this.txtTtlInv.Name = "txtTtlInv";
            this.txtTtlInv.ReadOnly = true;
            this.txtTtlInv.Size = new System.Drawing.Size(93, 23);
            this.txtTtlInv.TabIndex = 78;
            // 
            // BoxAddItems
            // 
            this.BoxAddItems.Controls.Add(this.btnDeleteItem);
            this.BoxAddItems.Controls.Add(this.btnAddItems);
            this.BoxAddItems.Controls.Add(this.txtAmount);
            this.BoxAddItems.Controls.Add(this.lblAmount);
            this.BoxAddItems.Controls.Add(this.txtUnitPrice);
            this.BoxAddItems.Controls.Add(this.lblUnitPrice);
            this.BoxAddItems.Controls.Add(this.txtItemQty);
            this.BoxAddItems.Controls.Add(this.lblItemQty);
            this.BoxAddItems.Controls.Add(this.ItemsList);
            this.BoxAddItems.Controls.Add(this.txtSearchItems);
            this.BoxAddItems.Controls.Add(this.lblItems);
            this.BoxAddItems.Controls.Add(this.lblItemsID);
            this.BoxAddItems.Controls.Add(this.lblAddItems);
            this.BoxAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAddItems.ForeColor = System.Drawing.Color.White;
            this.BoxAddItems.Location = new System.Drawing.Point(872, 9);
            this.BoxAddItems.Name = "BoxAddItems";
            this.BoxAddItems.Size = new System.Drawing.Size(438, 260);
            this.BoxAddItems.TabIndex = 52;
            this.BoxAddItems.TabStop = false;
            this.BoxAddItems.Text = "ADD ITEMS";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.CausesValidation = false;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDeleteItem.Location = new System.Drawing.Point(194, 196);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 29);
            this.btnDeleteItem.TabIndex = 85;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.CausesValidation = false;
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItems.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddItems.Location = new System.Drawing.Point(113, 196);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(75, 29);
            this.btnAddItems.TabIndex = 53;
            this.btnAddItems.Text = "Add";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.Black;
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Yellow;
            this.txtAmount.Location = new System.Drawing.Point(112, 157);
            this.txtAmount.MaxLength = 15;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(93, 23);
            this.txtAmount.TabIndex = 84;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(39, 164);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(67, 16);
            this.lblAmount.TabIndex = 83;
            this.lblAmount.Text = "Amount :";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.Black;
            this.txtUnitPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.ForeColor = System.Drawing.Color.Yellow;
            this.txtUnitPrice.Location = new System.Drawing.Point(112, 122);
            this.txtUnitPrice.MaxLength = 15;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(93, 23);
            this.txtUnitPrice.TabIndex = 82;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(23, 129);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(83, 16);
            this.lblUnitPrice.TabIndex = 81;
            this.lblUnitPrice.Text = "Unit Price :";
            // 
            // txtItemQty
            // 
            this.txtItemQty.BackColor = System.Drawing.Color.Black;
            this.txtItemQty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemQty.ForeColor = System.Drawing.Color.Yellow;
            this.txtItemQty.Location = new System.Drawing.Point(112, 87);
            this.txtItemQty.MaxLength = 15;
            this.txtItemQty.Name = "txtItemQty";
            this.txtItemQty.Size = new System.Drawing.Size(93, 23);
            this.txtItemQty.TabIndex = 80;
            this.txtItemQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemQty_KeyPress);
            // 
            // lblItemQty
            // 
            this.lblItemQty.AutoSize = true;
            this.lblItemQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemQty.Location = new System.Drawing.Point(34, 89);
            this.lblItemQty.Name = "lblItemQty";
            this.lblItemQty.Size = new System.Drawing.Size(72, 16);
            this.lblItemQty.TabIndex = 79;
            this.lblItemQty.Text = "Quantity :";
            // 
            // ItemsList
            // 
            this.ItemsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemsList.BackColor = System.Drawing.Color.Black;
            this.ItemsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsList.ForeColor = System.Drawing.Color.Yellow;
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.Location = new System.Drawing.Point(209, 49);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(220, 23);
            this.ItemsList.TabIndex = 78;
            // 
            // txtSearchItems
            // 
            this.txtSearchItems.BackColor = System.Drawing.Color.Black;
            this.txtSearchItems.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItems.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchItems.Location = new System.Drawing.Point(112, 51);
            this.txtSearchItems.MaxLength = 15;
            this.txtSearchItems.Name = "txtSearchItems";
            this.txtSearchItems.Size = new System.Drawing.Size(91, 23);
            this.txtSearchItems.TabIndex = 78;
            this.txtSearchItems.TextChanged += new System.EventHandler(this.txtSearchItems_TextChanged);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(53, 53);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(53, 16);
            this.lblItems.TabIndex = 78;
            this.lblItems.Text = "Items :";
            // 
            // lblItemsID
            // 
            this.lblItemsID.AutoSize = true;
            this.lblItemsID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblItemsID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsID.ForeColor = System.Drawing.Color.White;
            this.lblItemsID.Location = new System.Drawing.Point(112, 24);
            this.lblItemsID.Name = "lblItemsID";
            this.lblItemsID.Size = new System.Drawing.Size(14, 15);
            this.lblItemsID.TabIndex = 17;
            this.lblItemsID.Text = "0";
            // 
            // lblAddItems
            // 
            this.lblAddItems.AutoSize = true;
            this.lblAddItems.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItems.ForeColor = System.Drawing.SystemColors.Info;
            this.lblAddItems.Location = new System.Drawing.Point(81, 24);
            this.lblAddItems.Name = "lblAddItems";
            this.lblAddItems.Size = new System.Drawing.Size(25, 15);
            this.lblAddItems.TabIndex = 17;
            this.lblAddItems.Tag = "cv";
            this.lblAddItems.Text = "ID :";
            // 
            // dgvInv
            // 
            this.dgvInv.AllowUserToAddRows = false;
            this.dgvInv.AllowUserToDeleteRows = false;
            this.dgvInv.AllowUserToResizeColumns = false;
            this.dgvInv.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInv.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvInv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInv.GridColor = System.Drawing.Color.White;
            this.dgvInv.Location = new System.Drawing.Point(12, 19);
            this.dgvInv.MultiSelect = false;
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.ReadOnly = true;
            this.dgvInv.RowHeadersWidth = 20;
            this.dgvInv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInv.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInv.Size = new System.Drawing.Size(773, 215);
            this.dgvInv.TabIndex = 51;
            this.dgvInv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInv_RowHeaderMouseClick);
            // 
            // btnGenerateInv
            // 
            this.btnGenerateInv.CausesValidation = false;
            this.btnGenerateInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateInv.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateInv.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerateInv.Location = new System.Drawing.Point(791, 33);
            this.btnGenerateInv.Name = "btnGenerateInv";
            this.btnGenerateInv.Size = new System.Drawing.Size(75, 29);
            this.btnGenerateInv.TabIndex = 49;
            this.btnGenerateInv.Text = "Generate";
            this.btnGenerateInv.UseVisualStyleBackColor = true;
            this.btnGenerateInv.Click += new System.EventHandler(this.btnGenerateInv_Click);
            // 
            // BoxInvoiceDetails
            // 
            this.BoxInvoiceDetails.Controls.Add(this.panelMethod);
            this.BoxInvoiceDetails.Controls.Add(this.lblPaymentMethod);
            this.BoxInvoiceDetails.Controls.Add(this.dtDatePacked);
            this.BoxInvoiceDetails.Controls.Add(this.txtCFSNo);
            this.BoxInvoiceDetails.Controls.Add(this.txtBillTo);
            this.BoxInvoiceDetails.Controls.Add(this.btnAddCust);
            this.BoxInvoiceDetails.Controls.Add(this.lblDatePacked);
            this.BoxInvoiceDetails.Controls.Add(this.lblDateReceived);
            this.BoxInvoiceDetails.Controls.Add(this.dtDateReceived);
            this.BoxInvoiceDetails.Controls.Add(this.lblOperator);
            this.BoxInvoiceDetails.Controls.Add(this.txtOperator);
            this.BoxInvoiceDetails.Controls.Add(this.lblCustomer);
            this.BoxInvoiceDetails.Controls.Add(this.txtCustomer);
            this.BoxInvoiceDetails.Controls.Add(this.lblDestinationPort);
            this.BoxInvoiceDetails.Controls.Add(this.txtDestinationPort);
            this.BoxInvoiceDetails.Controls.Add(this.lblContainerNo);
            this.BoxInvoiceDetails.Controls.Add(this.txtContainerNo);
            this.BoxInvoiceDetails.Controls.Add(this.CFSList);
            this.BoxInvoiceDetails.Controls.Add(this.lblCFSNo);
            this.BoxInvoiceDetails.Controls.Add(this.BillToList);
            this.BoxInvoiceDetails.Controls.Add(this.label2);
            this.BoxInvoiceDetails.Controls.Add(this.txtSearchBillTo);
            this.BoxInvoiceDetails.Controls.Add(this.lblConsignee);
            this.BoxInvoiceDetails.Controls.Add(this.txtVolume);
            this.BoxInvoiceDetails.Controls.Add(this.lblVolume);
            this.BoxInvoiceDetails.Controls.Add(this.txtWeight);
            this.BoxInvoiceDetails.Controls.Add(this.pnlSave);
            this.BoxInvoiceDetails.Controls.Add(this.lblWeight);
            this.BoxInvoiceDetails.Controls.Add(this.txtQty);
            this.BoxInvoiceDetails.Controls.Add(this.lblQty);
            this.BoxInvoiceDetails.Controls.Add(this.txtVoyage);
            this.BoxInvoiceDetails.Controls.Add(this.lblVoyage);
            this.BoxInvoiceDetails.Controls.Add(this.txtStorageDays);
            this.BoxInvoiceDetails.Controls.Add(this.lblStorageDays);
            this.BoxInvoiceDetails.Controls.Add(this.txtSCNNo);
            this.BoxInvoiceDetails.Controls.Add(this.lblSCN);
            this.BoxInvoiceDetails.Controls.Add(this.txtVessel);
            this.BoxInvoiceDetails.Controls.Add(this.lblVessel);
            this.BoxInvoiceDetails.Controls.Add(this.pnlEdit);
            this.BoxInvoiceDetails.Controls.Add(this.lblInvNo);
            this.BoxInvoiceDetails.Controls.Add(this.label6);
            this.BoxInvoiceDetails.Controls.Add(this.txtSearchCFSNo);
            this.BoxInvoiceDetails.Controls.Add(this.txtInvNo);
            this.BoxInvoiceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxInvoiceDetails.ForeColor = System.Drawing.Color.White;
            this.BoxInvoiceDetails.Location = new System.Drawing.Point(6, 3);
            this.BoxInvoiceDetails.Name = "BoxInvoiceDetails";
            this.BoxInvoiceDetails.Size = new System.Drawing.Size(1313, 363);
            this.BoxInvoiceDetails.TabIndex = 1;
            this.BoxInvoiceDetails.TabStop = false;
            this.BoxInvoiceDetails.Text = "INVOICE DETAILS";
            // 
            // dtDatePacked
            // 
            this.dtDatePacked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDatePacked.Location = new System.Drawing.Point(730, 214);
            this.dtDatePacked.Name = "dtDatePacked";
            this.dtDatePacked.Size = new System.Drawing.Size(345, 20);
            this.dtDatePacked.TabIndex = 140;
            // 
            // txtCFSNo
            // 
            this.txtCFSNo.BackColor = System.Drawing.Color.Black;
            this.txtCFSNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCFSNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtCFSNo.Location = new System.Drawing.Point(159, 63);
            this.txtCFSNo.MaxLength = 15;
            this.txtCFSNo.Name = "txtCFSNo";
            this.txtCFSNo.ReadOnly = true;
            this.txtCFSNo.Size = new System.Drawing.Size(345, 23);
            this.txtCFSNo.TabIndex = 47;
            // 
            // txtBillTo
            // 
            this.txtBillTo.BackColor = System.Drawing.Color.Black;
            this.txtBillTo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillTo.ForeColor = System.Drawing.Color.Yellow;
            this.txtBillTo.Location = new System.Drawing.Point(730, 293);
            this.txtBillTo.MaxLength = 15;
            this.txtBillTo.Name = "txtBillTo";
            this.txtBillTo.ReadOnly = true;
            this.txtBillTo.Size = new System.Drawing.Size(345, 23);
            this.txtBillTo.TabIndex = 107;
            // 
            // btnAddCust
            // 
            this.btnAddCust.CausesValidation = false;
            this.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCust.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddCust.Location = new System.Drawing.Point(1205, 15);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(102, 33);
            this.btnAddCust.TabIndex = 80;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // lblDatePacked
            // 
            this.lblDatePacked.AutoSize = true;
            this.lblDatePacked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePacked.Location = new System.Drawing.Point(618, 218);
            this.lblDatePacked.Name = "lblDatePacked";
            this.lblDatePacked.Size = new System.Drawing.Size(106, 16);
            this.lblDatePacked.TabIndex = 139;
            this.lblDatePacked.Text = "Date Packed :";
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReceived.Location = new System.Drawing.Point(604, 180);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(120, 16);
            this.lblDateReceived.TabIndex = 138;
            this.lblDateReceived.Text = "Date Received :";
            // 
            // dtDateReceived
            // 
            this.dtDateReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateReceived.Location = new System.Drawing.Point(730, 176);
            this.dtDateReceived.Name = "dtDateReceived";
            this.dtDateReceived.Size = new System.Drawing.Size(345, 20);
            this.dtDateReceived.TabIndex = 137;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(647, 142);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(77, 16);
            this.lblOperator.TabIndex = 115;
            this.lblOperator.Text = "Operator :";
            // 
            // txtOperator
            // 
            this.txtOperator.BackColor = System.Drawing.Color.Black;
            this.txtOperator.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperator.ForeColor = System.Drawing.Color.Yellow;
            this.txtOperator.Location = new System.Drawing.Point(730, 140);
            this.txtOperator.MaxLength = 15;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.ReadOnly = true;
            this.txtOperator.Size = new System.Drawing.Size(345, 23);
            this.txtOperator.TabIndex = 114;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(72, 295);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(81, 16);
            this.lblCustomer.TabIndex = 113;
            this.lblCustomer.Text = "Customer :";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.Black;
            this.txtCustomer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.ForeColor = System.Drawing.Color.Yellow;
            this.txtCustomer.Location = new System.Drawing.Point(159, 293);
            this.txtCustomer.MaxLength = 15;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(345, 23);
            this.txtCustomer.TabIndex = 112;
            // 
            // lblDestinationPort
            // 
            this.lblDestinationPort.AutoSize = true;
            this.lblDestinationPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationPort.Location = new System.Drawing.Point(27, 257);
            this.lblDestinationPort.Name = "lblDestinationPort";
            this.lblDestinationPort.Size = new System.Drawing.Size(126, 16);
            this.lblDestinationPort.TabIndex = 111;
            this.lblDestinationPort.Text = "Destination Port :";
            // 
            // txtDestinationPort
            // 
            this.txtDestinationPort.BackColor = System.Drawing.Color.Black;
            this.txtDestinationPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationPort.ForeColor = System.Drawing.Color.Yellow;
            this.txtDestinationPort.Location = new System.Drawing.Point(159, 255);
            this.txtDestinationPort.MaxLength = 15;
            this.txtDestinationPort.Name = "txtDestinationPort";
            this.txtDestinationPort.ReadOnly = true;
            this.txtDestinationPort.Size = new System.Drawing.Size(345, 23);
            this.txtDestinationPort.TabIndex = 110;
            // 
            // lblContainerNo
            // 
            this.lblContainerNo.AutoSize = true;
            this.lblContainerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContainerNo.Location = new System.Drawing.Point(47, 218);
            this.lblContainerNo.Name = "lblContainerNo";
            this.lblContainerNo.Size = new System.Drawing.Size(106, 16);
            this.lblContainerNo.TabIndex = 109;
            this.lblContainerNo.Text = "Container No :";
            // 
            // txtContainerNo
            // 
            this.txtContainerNo.BackColor = System.Drawing.Color.Black;
            this.txtContainerNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContainerNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtContainerNo.Location = new System.Drawing.Point(159, 216);
            this.txtContainerNo.MaxLength = 15;
            this.txtContainerNo.Name = "txtContainerNo";
            this.txtContainerNo.ReadOnly = true;
            this.txtContainerNo.Size = new System.Drawing.Size(345, 23);
            this.txtContainerNo.TabIndex = 108;
            // 
            // CFSList
            // 
            this.CFSList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CFSList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CFSList.BackColor = System.Drawing.Color.Black;
            this.CFSList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CFSList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CFSList.ForeColor = System.Drawing.Color.Yellow;
            this.CFSList.FormattingEnabled = true;
            this.CFSList.Location = new System.Drawing.Point(283, 63);
            this.CFSList.Name = "CFSList";
            this.CFSList.Size = new System.Drawing.Size(221, 23);
            this.CFSList.TabIndex = 46;
            this.CFSList.Visible = false;
            this.CFSList.SelectedIndexChanged += new System.EventHandler(this.CFSList_SelectedIndexChanged);
            // 
            // lblCFSNo
            // 
            this.lblCFSNo.AutoSize = true;
            this.lblCFSNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCFSNo.Location = new System.Drawing.Point(83, 65);
            this.lblCFSNo.Name = "lblCFSNo";
            this.lblCFSNo.Size = new System.Drawing.Size(69, 16);
            this.lblCFSNo.TabIndex = 21;
            this.lblCFSNo.Text = "CFS No :";
            // 
            // BillToList
            // 
            this.BillToList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BillToList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BillToList.BackColor = System.Drawing.Color.Black;
            this.BillToList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BillToList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillToList.ForeColor = System.Drawing.Color.Yellow;
            this.BillToList.FormattingEnabled = true;
            this.BillToList.Location = new System.Drawing.Point(838, 293);
            this.BillToList.Name = "BillToList";
            this.BillToList.Size = new System.Drawing.Size(237, 23);
            this.BillToList.TabIndex = 106;
            this.BillToList.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(813, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 105;
            this.label2.Text = "---";
            // 
            // txtSearchBillTo
            // 
            this.txtSearchBillTo.BackColor = System.Drawing.Color.Black;
            this.txtSearchBillTo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBillTo.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchBillTo.Location = new System.Drawing.Point(730, 293);
            this.txtSearchBillTo.MaxLength = 15;
            this.txtSearchBillTo.Name = "txtSearchBillTo";
            this.txtSearchBillTo.ReadOnly = true;
            this.txtSearchBillTo.Size = new System.Drawing.Size(77, 23);
            this.txtSearchBillTo.TabIndex = 104;
            this.txtSearchBillTo.TextChanged += new System.EventHandler(this.txtSearchBillTo_TextChanged);
            // 
            // lblConsignee
            // 
            this.lblConsignee.AutoSize = true;
            this.lblConsignee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsignee.Location = new System.Drawing.Point(663, 295);
            this.lblConsignee.Name = "lblConsignee";
            this.lblConsignee.Size = new System.Drawing.Size(61, 16);
            this.lblConsignee.TabIndex = 103;
            this.lblConsignee.Text = "Bill To :";
            // 
            // txtVolume
            // 
            this.txtVolume.BackColor = System.Drawing.Color.Black;
            this.txtVolume.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.ForeColor = System.Drawing.Color.Yellow;
            this.txtVolume.Location = new System.Drawing.Point(730, 102);
            this.txtVolume.MaxLength = 15;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(345, 23);
            this.txtVolume.TabIndex = 77;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(622, 104);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(102, 16);
            this.lblVolume.TabIndex = 76;
            this.lblVolume.Text = "Volume (M3) :";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.Black;
            this.txtWeight.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ForeColor = System.Drawing.Color.Yellow;
            this.txtWeight.Location = new System.Drawing.Point(730, 63);
            this.txtWeight.MaxLength = 15;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(345, 23);
            this.txtWeight.TabIndex = 75;
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Controls.Add(this.btnCancel);
            this.pnlSave.Location = new System.Drawing.Point(1202, 255);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(105, 56);
            this.pnlSave.TabIndex = 23;
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
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(620, 65);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(104, 16);
            this.lblWeight.TabIndex = 74;
            this.lblWeight.Text = "Weight (Kgs) :";
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.Black;
            this.txtQty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Yellow;
            this.txtQty.Location = new System.Drawing.Point(730, 25);
            this.txtQty.MaxLength = 15;
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(345, 23);
            this.txtQty.TabIndex = 71;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(652, 27);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(72, 16);
            this.lblQty.TabIndex = 70;
            this.lblQty.Text = "Quantity :";
            // 
            // txtVoyage
            // 
            this.txtVoyage.BackColor = System.Drawing.Color.Black;
            this.txtVoyage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoyage.ForeColor = System.Drawing.Color.Yellow;
            this.txtVoyage.Location = new System.Drawing.Point(159, 178);
            this.txtVoyage.MaxLength = 15;
            this.txtVoyage.Name = "txtVoyage";
            this.txtVoyage.ReadOnly = true;
            this.txtVoyage.Size = new System.Drawing.Size(345, 23);
            this.txtVoyage.TabIndex = 65;
            // 
            // lblVoyage
            // 
            this.lblVoyage.AutoSize = true;
            this.lblVoyage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoyage.Location = new System.Drawing.Point(59, 180);
            this.lblVoyage.Name = "lblVoyage";
            this.lblVoyage.Size = new System.Drawing.Size(94, 16);
            this.lblVoyage.TabIndex = 64;
            this.lblVoyage.Text = "Voyage No :";
            // 
            // txtStorageDays
            // 
            this.txtStorageDays.BackColor = System.Drawing.Color.Black;
            this.txtStorageDays.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStorageDays.ForeColor = System.Drawing.Color.Yellow;
            this.txtStorageDays.Location = new System.Drawing.Point(730, 255);
            this.txtStorageDays.MaxLength = 15;
            this.txtStorageDays.Name = "txtStorageDays";
            this.txtStorageDays.ReadOnly = true;
            this.txtStorageDays.Size = new System.Drawing.Size(345, 23);
            this.txtStorageDays.TabIndex = 61;
            // 
            // lblStorageDays
            // 
            this.lblStorageDays.AutoSize = true;
            this.lblStorageDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageDays.Location = new System.Drawing.Point(613, 257);
            this.lblStorageDays.Name = "lblStorageDays";
            this.lblStorageDays.Size = new System.Drawing.Size(111, 16);
            this.lblStorageDays.TabIndex = 60;
            this.lblStorageDays.Text = "Storage Days :";
            // 
            // txtSCNNo
            // 
            this.txtSCNNo.BackColor = System.Drawing.Color.Black;
            this.txtSCNNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSCNNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtSCNNo.Location = new System.Drawing.Point(159, 102);
            this.txtSCNNo.MaxLength = 15;
            this.txtSCNNo.Name = "txtSCNNo";
            this.txtSCNNo.ReadOnly = true;
            this.txtSCNNo.Size = new System.Drawing.Size(345, 23);
            this.txtSCNNo.TabIndex = 55;
            // 
            // lblSCN
            // 
            this.lblSCN.AutoSize = true;
            this.lblSCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSCN.Location = new System.Drawing.Point(51, 104);
            this.lblSCN.Name = "lblSCN";
            this.lblSCN.Size = new System.Drawing.Size(102, 16);
            this.lblSCN.TabIndex = 54;
            this.lblSCN.Text = "Ship Call No :";
            // 
            // txtVessel
            // 
            this.txtVessel.BackColor = System.Drawing.Color.Black;
            this.txtVessel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVessel.ForeColor = System.Drawing.Color.Yellow;
            this.txtVessel.Location = new System.Drawing.Point(159, 140);
            this.txtVessel.MaxLength = 15;
            this.txtVessel.Name = "txtVessel";
            this.txtVessel.ReadOnly = true;
            this.txtVessel.Size = new System.Drawing.Size(345, 23);
            this.txtVessel.TabIndex = 49;
            // 
            // lblVessel
            // 
            this.lblVessel.AutoSize = true;
            this.lblVessel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVessel.Location = new System.Drawing.Point(89, 142);
            this.lblVessel.Name = "lblVessel";
            this.lblVessel.Size = new System.Drawing.Size(64, 16);
            this.lblVessel.TabIndex = 48;
            this.lblVessel.Text = "Vessel :";
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.btnBack);
            this.pnlEdit.Controls.Add(this.btnDel);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Location = new System.Drawing.Point(1148, 255);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(159, 56);
            this.pnlEdit.TabIndex = 22;
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
            // lblInvNo
            // 
            this.lblInvNo.AutoSize = true;
            this.lblInvNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvNo.Location = new System.Drawing.Point(63, 27);
            this.lblInvNo.Name = "lblInvNo";
            this.lblInvNo.Size = new System.Drawing.Size(90, 16);
            this.lblInvNo.TabIndex = 1;
            this.lblInvNo.Text = "Invoice No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(258, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "---";
            // 
            // txtSearchCFSNo
            // 
            this.txtSearchCFSNo.BackColor = System.Drawing.Color.Black;
            this.txtSearchCFSNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCFSNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchCFSNo.Location = new System.Drawing.Point(159, 63);
            this.txtSearchCFSNo.MaxLength = 15;
            this.txtSearchCFSNo.Name = "txtSearchCFSNo";
            this.txtSearchCFSNo.ReadOnly = true;
            this.txtSearchCFSNo.Size = new System.Drawing.Size(93, 23);
            this.txtSearchCFSNo.TabIndex = 22;
            this.txtSearchCFSNo.TextChanged += new System.EventHandler(this.txtSearchCFSNo_TextChanged);
            // 
            // txtInvNo
            // 
            this.txtInvNo.BackColor = System.Drawing.Color.Black;
            this.txtInvNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtInvNo.Location = new System.Drawing.Point(159, 25);
            this.txtInvNo.MaxLength = 10000;
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.ReadOnly = true;
            this.txtInvNo.Size = new System.Drawing.Size(345, 23);
            this.txtInvNo.TabIndex = 18;
            // 
            // lblIDCP
            // 
            this.lblIDCP.AutoSize = true;
            this.lblIDCP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCP.ForeColor = System.Drawing.SystemColors.Info;
            this.lblIDCP.Location = new System.Drawing.Point(77, 9);
            this.lblIDCP.Name = "lblIDCP";
            this.lblIDCP.Size = new System.Drawing.Size(25, 15);
            this.lblIDCP.TabIndex = 20;
            this.lblIDCP.Tag = "cv";
            this.lblIDCP.Text = "ID :";
            this.lblIDCP.Visible = false;
            // 
            // lblCPID
            // 
            this.lblCPID.AutoSize = true;
            this.lblCPID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCPID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPID.ForeColor = System.Drawing.Color.White;
            this.lblCPID.Location = new System.Drawing.Point(101, 9);
            this.lblCPID.Name = "lblCPID";
            this.lblCPID.Size = new System.Drawing.Size(14, 15);
            this.lblCPID.TabIndex = 19;
            this.lblCPID.Text = "0";
            this.lblCPID.Visible = false;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(21, 331);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(131, 16);
            this.lblPaymentMethod.TabIndex = 141;
            this.lblPaymentMethod.Text = "Payment Method :";
            // 
            // panelMethod
            // 
            this.panelMethod.Controls.Add(this.rbOnlineTransfer);
            this.panelMethod.Controls.Add(this.rbCheque);
            this.panelMethod.Controls.Add(this.rbCredit);
            this.panelMethod.Controls.Add(this.rbCash);
            this.panelMethod.Location = new System.Drawing.Point(159, 325);
            this.panelMethod.Name = "panelMethod";
            this.panelMethod.Size = new System.Drawing.Size(316, 22);
            this.panelMethod.TabIndex = 142;
            // 
            // rbOnlineTransfer
            // 
            this.rbOnlineTransfer.AutoSize = true;
            this.rbOnlineTransfer.Location = new System.Drawing.Point(198, 2);
            this.rbOnlineTransfer.Name = "rbOnlineTransfer";
            this.rbOnlineTransfer.Size = new System.Drawing.Size(112, 17);
            this.rbOnlineTransfer.TabIndex = 3;
            this.rbOnlineTransfer.Text = "Online Transfer";
            this.rbOnlineTransfer.UseVisualStyleBackColor = true;
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Location = new System.Drawing.Point(124, 3);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(68, 17);
            this.rbCheque.TabIndex = 2;
            this.rbCheque.Text = "Cheque";
            this.rbCheque.UseVisualStyleBackColor = true;
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Location = new System.Drawing.Point(60, 3);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(58, 17);
            this.rbCredit.TabIndex = 1;
            this.rbCredit.Text = "Credit";
            this.rbCredit.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Location = new System.Drawing.Point(3, 3);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(53, 17);
            this.rbCash.TabIndex = 0;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // ExportInvAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1346, 689);
            this.Controls.Add(this.lblIDCP);
            this.Controls.Add(this.lblCPID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInvID);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportInvAED";
            this.ShowIcon = false;
            this.Text = "Export Invoice Details";
            this.panel1.ResumeLayout(false);
            this.BoxInvoiceItemDetails.ResumeLayout(false);
            this.BoxInvoiceItemDetails.PerformLayout();
            this.BoxAddItems.ResumeLayout(false);
            this.BoxAddItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            this.BoxInvoiceDetails.ResumeLayout(false);
            this.BoxInvoiceDetails.PerformLayout();
            this.pnlSave.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.panelMethod.ResumeLayout(false);
            this.panelMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblInvID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox BoxInvoiceDetails;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.TextBox txtBillTo;
        private System.Windows.Forms.ComboBox BillToList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBillTo;
        private System.Windows.Forms.Label lblConsignee;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtVoyage;
        private System.Windows.Forms.Label lblVoyage;
        private System.Windows.Forms.TextBox txtStorageDays;
        private System.Windows.Forms.Label lblStorageDays;
        private System.Windows.Forms.TextBox txtSCNNo;
        private System.Windows.Forms.Label lblSCN;
        private System.Windows.Forms.TextBox txtVessel;
        private System.Windows.Forms.Label lblVessel;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtCFSNo;
        private System.Windows.Forms.Label lblInvNo;
        private System.Windows.Forms.ComboBox CFSList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchCFSNo;
        private System.Windows.Forms.Label lblCFSNo;
        private System.Windows.Forms.TextBox txtInvNo;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblContainerNo;
        private System.Windows.Forms.TextBox txtContainerNo;
        private System.Windows.Forms.Label lblDestinationPort;
        private System.Windows.Forms.TextBox txtDestinationPort;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.DateTimePicker dtDateReceived;
        private System.Windows.Forms.DateTimePicker dtDatePacked;
        private System.Windows.Forms.Label lblDatePacked;
        private System.Windows.Forms.Label lblIDCP;
        private System.Windows.Forms.Label lblCPID;
        private System.Windows.Forms.GroupBox BoxInvoiceItemDetails;
        private System.Windows.Forms.Label lblAmountInWords;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Label lblTtlInv;
        private System.Windows.Forms.TextBox txtTtlInv;
        private System.Windows.Forms.GroupBox BoxAddItems;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtItemQty;
        private System.Windows.Forms.Label lblItemQty;
        private System.Windows.Forms.ComboBox ItemsList;
        private System.Windows.Forms.TextBox txtSearchItems;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblItemsID;
        private System.Windows.Forms.Label lblAddItems;
        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.Button btnGenerateInv;
        private System.Windows.Forms.Label lblTotalAmountWords;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Panel panelMethod;
        private System.Windows.Forms.RadioButton rbOnlineTransfer;
        private System.Windows.Forms.RadioButton rbCheque;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rbCash;
    }
}