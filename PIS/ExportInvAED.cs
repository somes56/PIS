using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace PIS
{
    public partial class ExportInvAED : Form
    {
        private int UserID = 0;

        public ExportInvAED(int ID, int LoginID)
        {
            UserID = LoginID;

        
            InitializeComponent();

            AdvSearchExportInvoiceCFS("~!");
            AdvSearchBillTo("~!");

            if (ID > 0)
            {
                lblInvID.Text = ID.ToString();
                txtInvNo.Select();
                LoadExportInvoice(ID);
                DisableEdit();
            }
            else
            {
                lblInvID.Text = "0";
                lblCPID.Text = "0";
                txtSearchCFSNo.Select();
                EnableEdit();
                LoadExportInvoiceItem(0);
            }

            dgvInv.Columns[0].Name = "id";
            dgvInv.Columns[0].HeaderText = "ID";
            dgvInv.Columns[0].Visible = false;

            dgvInv.Columns[1].Name = "item_id";
            dgvInv.Columns[1].HeaderText = "Item Code";

            dgvInv.Columns[2].Name = "name";
            dgvInv.Columns[2].HeaderText = "Item Description";

            dgvInv.Columns[3].Name = "qty";
            dgvInv.Columns[3].HeaderText = "Quantity";

            dgvInv.Columns[4].Name = "unit_price";
            dgvInv.Columns[4].HeaderText = "Unit Price";

            dgvInv.Columns[5].Name = "amount";
            dgvInv.Columns[5].HeaderText = "Amount";
        }

        public void AdvSearchExportInvoiceCFS(string SearchBy)
        {
            DataTable CFS = new DataTable();
            CFS = DBUtil.AdvSearchExportInvoiceCFS(SearchBy);

            CFSList.DataSource = CFS;
            CFSList.DisplayMember = "cfs_no";
            CFSList.ValueMember = "cfs_id";
        }

        public void AdvSearchBillTo(string SearchBy)
        {
            DataTable BillTo = new DataTable();
            BillTo = DBUtil.spMst_AdvSearchCustomer(SearchBy);

            BillToList.DataSource = BillTo;
            BillToList.DisplayMember = "name";
            BillToList.ValueMember = "id";
        }

        private void AdvSearchItems(string SearchBy)
        {
            DataTable Items = new DataTable();
            Items = DBUtil.AdvSearchInvoiceItems(SearchBy);

            ItemsList.DataSource = Items;
            ItemsList.DisplayMember = "name";
            ItemsList.ValueMember = "id";
        }

        private void txtSearchCFSNo_TextChanged(object sender, EventArgs e)
        {
            string SearchBy = txtSearchCFSNo.Text.ToString().Trim().Length > 0 ? txtSearchCFSNo.Text.ToString().Trim() : "~!";

            AdvSearchExportInvoiceCFS(SearchBy);
        }

        private void txtSearchBillTo_TextChanged(object sender, EventArgs e)
        {
            string SearchBy = txtSearchBillTo.Text.ToString().Trim().Length > 0 ? txtSearchBillTo.Text.ToString().Trim() : "~!";

            AdvSearchBillTo(SearchBy);
        }

        private void txtSearchItems_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchItems.Text.Trim();

            if (SearchBy.Length != 0)
            {
                AdvSearchItems(SearchBy);
                ItemsList.Focus();
            }
            else
            {
                AdvSearchItems("NONE");
            }
        }

        private void CFSList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CFSList.SelectedIndex > -1)
            {
                int CFSID = Convert.ToInt32(CFSList.SelectedValue.ToString());
                LoadCPSCPDetails(CFSID);
            }
        }

        public string CheckedCPIssueInvoiceBox(int CFSID)
        {
            string CheckedIssueInvoice = "";
            DataTable CP = new DataTable();

            CP = DBUtil.LoadCFSCP(CFSID);
            CheckedIssueInvoice = CP.Rows.Count > 0 ? Convert.ToInt32(CP.Rows[0]["issue_invoice"]) > 0 ? "Y" : "N" : "E";

            return CheckedIssueInvoice;
        }

        public bool IssuedInvoice(int CFSID)
        {
            return DBUtil.GetExportInvoiceIDByCFSID(CFSID);
        }

        public void LoadCPSCPDetails(int CFSID)
        {
            DataTable CP = new DataTable();
            CP = DBUtil.LoadCFSCP(CFSID);

            txtSCNNo.Text = CP.Rows[0]["scn"].ToString();
            txtVessel.Text = CP.Rows[0]["vessel"].ToString();
            txtVoyage.Text = CP.Rows[0]["voyage_no"].ToString();
            txtContainerNo.Text = CP.Rows[0]["container_no"].ToString();
            txtDestinationPort.Text = CP.Rows[0]["destination_port"].ToString();
            txtCustomer.Text = CP.Rows[0]["customer"].ToString();
            txtQty.Text = CP.Rows[0]["goods_qty"].ToString();
            txtWeight.Text = CP.Rows[0]["weight"].ToString();
            txtVolume.Text = CP.Rows[0]["volume"].ToString();
            txtOperator.Text = CP.Rows[0]["operator"].ToString();
            dtDateReceived.Value = (DateTime)CP.Rows[0]["date_receive"];
            dtDatePacked.Value = (DateTime)CP.Rows[0]["pack_date"];
            txtStorageDays.Text = CP.Rows[0]["storage_days"].ToString();
            lblCPID.Text = CP.Rows[0]["id"].ToString();
        }

        public void LoadExportInvoice(int InvoiceID)
        {
            DataTable Invoice = new DataTable();
            decimal TotalAmount = 0.00m;
            int PaymentMethod = 0;

            Invoice = DBUtil.LoadExportInvoice(InvoiceID);

            lblInvID.Text = Invoice.Rows[0]["id"].ToString();
            lblCPID.Text = Invoice.Rows[0]["cp_id"].ToString();
            txtInvNo.Text = Invoice.Rows[0]["inv_no"].ToString();
            txtSearchCFSNo.Text = Invoice.Rows[0]["cfs_no"].ToString();
            txtCFSNo.Text = Invoice.Rows[0]["cfs_no"].ToString();
            txtSCNNo.Text = Invoice.Rows[0]["scn"].ToString();
            txtVessel.Text = Invoice.Rows[0]["vessel"].ToString();
            txtVoyage.Text = Invoice.Rows[0]["voyage_no"].ToString();
            txtContainerNo.Text = Invoice.Rows[0]["container_no"].ToString();
            txtDestinationPort.Text = Invoice.Rows[0]["destination_port"].ToString();
            txtCustomer.Text = Invoice.Rows[0]["customer"].ToString();
            txtQty.Text = Invoice.Rows[0]["goods_qty"].ToString();
            txtWeight.Text = Invoice.Rows[0]["weight"].ToString();
            txtVolume.Text = Invoice.Rows[0]["volume"].ToString();
            txtOperator.Text = Invoice.Rows[0]["operator"].ToString();
            dtDateReceived.Value = (DateTime)Invoice.Rows[0]["date_receive"];
            dtDatePacked.Value = (DateTime)Invoice.Rows[0]["pack_date"];
            txtStorageDays.Text = Invoice.Rows[0]["storage_days"].ToString();
            txtSearchBillTo.Text = Invoice.Rows[0]["billTo"].ToString();
            txtBillTo.Text = Invoice.Rows[0]["billTo"].ToString();
            txtTtlInv.Text = Invoice.Rows[0]["TotalAmount"].ToString();
            TotalAmount = Convert.ToDecimal(Invoice.Rows[0]["TotalAmount"]);
            PaymentMethod = Convert.ToInt32(Invoice.Rows[0]["payment_method"]);

            if (PaymentMethod == 0)
            {
                rbCash.Checked = true;
            }
            else if (PaymentMethod == 1)
            {
                rbCredit.Checked = true;
            }
            else if (PaymentMethod == 2)
            {
                rbCheque.Checked = true;
            }
            else if (PaymentMethod == 3)
            {
                rbOnlineTransfer.Checked = true;
            }

            LoadExportInvoiceItem(InvoiceID);

            UpdateTotalAmountWords(InvoiceID, TotalAmount);
        }

        public void LoadExportInvoiceItem(int InvoiceID)
        {
            DataTable InvoiceItems = new DataTable();
            InvoiceItems = DBUtil.LoadExportInvoiceItems(InvoiceID);

            dgvInv.DataSource = InvoiceItems;
        }

        public string GetIssuePort()
        {
            var rtn = "";

            try
            {
                rtn = ConfigurationManager.AppSettings["IssuePort"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Issue Port Key in App Config File is missing.", "Error");
                rtn = "";
            }

            return rtn;
        }

        public void DisableEdit()
        {
            pnlEdit.Visible = true;
            pnlSave.Visible = false;
            txtInvNo.ReadOnly = true;
            txtSearchCFSNo.ReadOnly = true;
            txtSearchCFSNo.Visible = false;
            CFSList.Visible = false;
            txtCFSNo.ReadOnly = true;
            txtCFSNo.Visible = true;
            txtSCNNo.ReadOnly = true;
            txtVessel.ReadOnly = true;
            txtVoyage.ReadOnly = true;
            txtContainerNo.ReadOnly = true;
            txtDestinationPort.ReadOnly = true;
            txtCustomer.ReadOnly = true;
            txtQty.ReadOnly = true;
            txtWeight.ReadOnly = true;
            txtVolume.ReadOnly = true;
            txtOperator.ReadOnly = true;
            dtDateReceived.Enabled = false;
            dtDatePacked.Enabled = false;
            txtStorageDays.ReadOnly = true;
            txtSearchBillTo.ReadOnly = true;
            txtSearchBillTo.Visible = false;
            BillToList.Visible = false;
            txtBillTo.ReadOnly = true;
            txtBillTo.Visible = true;
            panelMethod.Enabled = false;
        }

        public void EnableEdit()
        {
            pnlEdit.Visible = false;
            pnlSave.Visible = true;
            txtInvNo.ReadOnly = true;
            txtSearchCFSNo.ReadOnly = false;
            txtSearchCFSNo.Visible = true;
            CFSList.Visible = true;
            txtCFSNo.ReadOnly = true;
            txtCFSNo.Visible = false;
            txtSCNNo.ReadOnly = true;
            txtVessel.ReadOnly = true;
            txtVoyage.ReadOnly = true;
            txtContainerNo.ReadOnly = true;
            txtDestinationPort.ReadOnly = true;
            txtCustomer.ReadOnly = true;
            txtQty.ReadOnly = true;
            txtWeight.ReadOnly = true;
            txtVolume.ReadOnly = true;
            txtOperator.ReadOnly = true;
            dtDateReceived.Enabled = false;
            dtDatePacked.Enabled = false;
            txtStorageDays.ReadOnly = true;
            txtSearchBillTo.ReadOnly = false;
            txtSearchBillTo.Visible = true;
            BillToList.Visible = true;
            txtBillTo.ReadOnly = true;
            txtBillTo.Visible = false;
            panelMethod.Enabled = true;
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            CustAED CustAED = new CustAED(1, 0, UserID);
            CustAED.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CFSList.SelectedIndex == -1)
            {
                MessageBox.Show("CFS No is required");
                return;
            }

            if (BillToList.SelectedIndex == -1)
            {
                MessageBox.Show("Bill To is required");
                return;
            }

            int InvoiceID = Convert.ToInt32(lblInvID.Text.ToString().Trim());
            int CFSID = Convert.ToInt32(CFSList.SelectedValue.ToString());
            int CPID = Convert.ToInt32(lblCPID.Text.ToString().Trim());
            int GoodsQty = Convert.ToInt32(txtQty.Text.ToString().Trim());
            decimal Weight = Convert.ToDecimal(txtWeight.Text.ToString().Trim());
            decimal Volume = Convert.ToDecimal(txtVolume.Text.ToString().Trim());
            int StorageDays = Convert.ToInt32(txtStorageDays.Text.ToString().Trim());
            int BillToID = Convert.ToInt32(BillToList.SelectedValue.ToString());
            DateTime DateReceive = dtDateReceived.Value;
            DateTime DatePack = dtDatePacked.Value;
            string IssuePort = GetIssuePort();
            string UpsertInvoice = "";
            int PaymentMethod = rbCredit.Checked ? 1 : rbCheque.Checked ? 2 : rbOnlineTransfer.Checked ? 3 : 0;


            if (InvoiceID < 1)
            {
                string CheckedIssueInvoiceBox = CheckedIssueInvoiceBox = CheckedCPIssueInvoiceBox(CFSID);

                if (CheckedIssueInvoiceBox == "Y")
                {
                    bool InvoiceIssued = IssuedInvoice(CFSID);

                    if (InvoiceIssued == true)
                    {
                        MessageBox.Show("An Invoice Has Been Issued Already For Selected CFS");
                        return;
                    }
                }
                else if (CheckedIssueInvoiceBox == "N")
                {
                    MessageBox.Show("Container Packaging's Issue Invoice Checkbox Is Not Ticked");
                    return;
                }
                else
                {
                    MessageBox.Show("No Container Packaging Details Found For Selected CFS");
                    return;
                }
            }

            if (string.IsNullOrEmpty(IssuePort))
            {
                return;
            }

            string InvoiceNo = InvoiceID > 0 ? txtInvNo.Text.ToString().Trim() : DBUtil.GenerateExportInvoiceNo(IssuePort);

            if (!string.IsNullOrEmpty(InvoiceNo))
            {
                UpsertInvoice = DBUtil.UpsertExportInvoice(InvoiceID, InvoiceNo, CFSID, CPID, GoodsQty, Weight, Volume, StorageDays, BillToID, PaymentMethod, DateReceive, DatePack, UserID);

                if (UpsertInvoice == "OK")
                {
                    InvoiceID = DBUtil.GetExportInvoiceIDByInvoiceNo(InvoiceNo);

                    if (InvoiceID != 0)
                    {
                        LoadExportInvoice(InvoiceID);
                    }
                    else
                    {
                        MessageBox.Show("System Failed To Get Invoice ID");
                        return;
                    }

                    DisableEdit();
                }
                else
                {
                    MessageBox.Show(UpsertInvoice);
                    return;
                }
            }
            else
            {
                MessageBox.Show("System Failed To Generate Export Invoice No");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int InvoiceID = Convert.ToInt32(lblInvID.Text.ToString().Trim());

            if (InvoiceID > 0) DisableEdit(); else this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int InvoiceID = Convert.ToInt32(lblInvID.Text.ToString().Trim());
            string rtn = "";

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this Invoice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)
            {
                rtn = DBUtil.DelExportInvoice(InvoiceID);

                if (rtn == "OK")
                {
                    rtn = DBUtil.DelAllExportInvoiceItem(InvoiceID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fail To Delete Invoice : " + txtInvNo.Text.ToString(), "Error");
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void btnGenerateInv_Click(object sender, EventArgs e)
        {
            int InvoiceID = Convert.ToInt32(lblInvID.Text.ToString().Trim());
            int StorageDays = Convert.ToInt32(txtStorageDays.Text.ToString().Trim());
            int Qty = CalculateQty();
            decimal UnitPrice = 0.00m, Amount = 0.00m;
            bool IsHandlingInc = false, IsFafInc = false, IsStorageInc = false, IsRemovalInc = false, IsSpecialStorageDays = false;
            string rtn = "";
            
            if (InvoiceID < 1)
            {
                MessageBox.Show("Invoice No is required");
                return;
            }

            if (StorageDays < 1)
            {
                MessageBox.Show("Storage Days should be more than 0");
                return;
            }

            if (Qty < 0)
            {
                MessageBox.Show("Error in calculating Volume and Weight");
                return;
            }

            var Invoice = DBUtil.LoadExportInvoice(InvoiceID);

            var InvoiceItems = DBUtil.LoadExportInvoiceItems(InvoiceID);

            foreach (DataRow Row in InvoiceItems.Rows)
            {
                if (Convert.ToInt32(Row["item_id"]) == 3) IsHandlingInc = true;
                if (Convert.ToInt32(Row["item_id"]) == 118) IsFafInc = true;
                if (Convert.ToInt32(Row["item_id"]) == 9) IsStorageInc = true;
                if (Convert.ToInt32(Row["item_id"]) == 10) IsRemovalInc = true;
            }

            IsSpecialStorageDays = Convert.ToInt32(Invoice.Rows[0]["special_storage_days"]) > 0 ? true : false;

            if (StorageDays <= 4)
            {
                //Handling
                UnitPrice = Qty <= 1 ? 20.00m : 12.00m;
                Amount = (UnitPrice * Qty);
                rtn = IsHandlingInc == false ? DBUtil.UpsertExportInvoiceItems(0, InvoiceID, 3, Qty, UnitPrice, Amount, UserID) : "OK";

                //FAF
                UnitPrice = 3.50m;
                Amount = (UnitPrice * Qty);
                rtn = IsFafInc == false ? DBUtil.UpsertExportInvoiceItems(0, InvoiceID, 118, Qty, UnitPrice, Amount, UserID) : "OK";
            }
            else
            {
                //Handling
                UnitPrice = Qty <= 1 ? 20.00m : 12.00m;
                Amount = (UnitPrice * Qty);
                rtn = IsHandlingInc == false ? DBUtil.UpsertExportInvoiceItems(0, InvoiceID, 3, Qty, UnitPrice, Amount, UserID) : "OK";

                //FAF
                UnitPrice = 3.50m;
                Amount = (UnitPrice * Qty);
                rtn = IsFafInc == false ? DBUtil.UpsertExportInvoiceItems(0, InvoiceID, 118, Qty, UnitPrice, Amount, UserID) : "OK";

                //Storage
                UnitPrice = 4.50m;
                Amount = (UnitPrice * StorageDays * Qty);
                rtn = IsStorageInc == false ? (StorageDays == 5 && IsSpecialStorageDays == true) ? "OK" : DBUtil.UpsertExportInvoiceItems(0, InvoiceID, 9, Qty, UnitPrice, Amount, UserID) : "OK";

                //Removal
                UnitPrice = 3.00m;
                Amount = (UnitPrice * Qty);
                rtn = IsRemovalInc == false ? DBUtil.UpsertExportInvoiceItems(0, InvoiceID, 10, Qty, UnitPrice, Amount, UserID) : "OK";
            }

            LoadExportInvoice(InvoiceID);

        }

        public int CalculateQty()
        {
            int rtn = 0;
            decimal Weight;
            decimal Volume;
            decimal WeightFractions;
            decimal VolumeFractions;
            int WeightFloor = 0;
            int VolumeFloor = 0;

            try
            {
                Weight = Convert.ToDecimal(txtWeight.Text.Trim().ToString());
                WeightFloor = Convert.ToInt32(Math.Floor(Weight / 1000));
                WeightFractions = (Weight / 1000) - WeightFloor;

                Volume = Convert.ToDecimal(txtVolume.Text.Trim().ToString());
                VolumeFloor = Convert.ToInt32(Math.Floor(Volume));
                VolumeFractions = Volume - VolumeFloor;

                if (WeightFractions != 0)
                {
                    WeightFloor = WeightFloor + 1;
                }


                if (VolumeFractions != 0)
                {
                    VolumeFloor = VolumeFloor + 1;
                }

                if (WeightFloor >= VolumeFloor)
                {
                    rtn = WeightFloor;
                }
                else
                {
                    rtn = VolumeFloor;
                }
            }
            catch
            {
                rtn = -1;
            }


            return rtn;
        }

        private void txtItemQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            int InvoiceID = 0, InvoiceItemID = 0, ItemID = 0, Quantity = 0;
            decimal UnitPrice = 0.00m, TotalAmount = 0.00m;
            string rtn = "";

            InvoiceID = Convert.ToInt32(lblInvID.Text.ToString().Trim());

            if (InvoiceID < 1)
            {
                MessageBox.Show("Invoice No is required");
                return;
            }

            if (ItemsList.SelectedIndex == -1)
            {
                MessageBox.Show("Invoice Item is required");
                return;
            }

            if (string.IsNullOrEmpty(txtItemQty.Text))
            {
                MessageBox.Show("Item Quantity is required");
                return;
            }

            if (string.IsNullOrEmpty(txtUnitPrice.Text))
            {
                MessageBox.Show("Unit Price is required");
                return;
            }

            InvoiceItemID = Convert.ToInt32(lblItemsID.Text.ToString().Trim());
            ItemID = Convert.ToInt32(ItemsList.SelectedValue.ToString().Trim());
            Quantity = Convert.ToInt32(txtItemQty.Text.ToString().Trim());
            UnitPrice = Convert.ToDecimal(txtUnitPrice.Text.ToString().Trim());
            TotalAmount = Quantity * UnitPrice;

            rtn = DBUtil.UpsertExportInvoiceItems(InvoiceItemID, InvoiceID, ItemID, Quantity, UnitPrice, TotalAmount, UserID);

            if (rtn == "OK")
            {
                lblItemsID.Text = "0";
                txtSearchItems.Text = "";
                ItemsList.SelectedIndex = -1;
                txtItemQty.Text = "";
                txtUnitPrice.Text = "";
                txtAmount.Text = "";

                LoadExportInvoice(InvoiceID);
            }
            else
            {
                MessageBox.Show("Fail To Save Invoice Item");
                return;
            }

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int InvoiceID = 0, InvoiceItemID = 0;
            string rtn = "";

            InvoiceID = Convert.ToInt32(lblInvID.Text.ToString().Trim());
            InvoiceItemID = Convert.ToInt32(lblItemsID.Text.ToString());

            if (InvoiceID < 1)
            {
                MessageBox.Show("Invoice No is required");
                return;
            }

            if (InvoiceItemID < 1)
            {
                MessageBox.Show("Invoice Item is required");
                return;
            }

            rtn = DBUtil.DelExportInvoiceItem(InvoiceItemID);

            if (rtn == "OK")
            {
                lblItemsID.Text = "0";
                txtSearchItems.Text = "";
                ItemsList.SelectedIndex = -1;
                txtItemQty.Text = "";
                txtUnitPrice.Text = "";
                txtAmount.Text = "";

                LoadExportInvoice(InvoiceID);
            }
            else
            {
                MessageBox.Show("Fail To Delete Invoice Item");
                return;
            }

        }

        private void dgvInv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblItemsID.Text = dgvInv.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            txtSearchItems.Text = dgvInv.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            txtItemQty.Text = dgvInv.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            txtUnitPrice.Text = dgvInv.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
            txtAmount.Text = dgvInv.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
            AdvSearchItems(txtSearchItems.Text.ToString().Trim());
        }

        public void UpdateTotalAmountWords(int InvoiceID, decimal TotalAmount)
        {
            string TotalAmountStr = TotalAmount.ToString(), rtn = "";

            TotalAmountStr = TotalAmountStr.Contains("-") ? TotalAmountStr.Substring(1, TotalAmountStr.Length - 1) : TotalAmountStr;

            lblTotalAmountWords.Text = TotalAmount > 0 ? "RINGGIT MALAYSIA : " + ConvertToWords(TotalAmountStr) : "";

            rtn = DBUtil.UpdateExportInvoiceTotalAmountWords(InvoiceID, lblTotalAmountWords.Text.ToString().Trim());

            if (rtn != "OK") MessageBox.Show("Fail To Update Export Invoice Total Amount In Words");
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            int InvoiceID = Convert.ToInt32(lblInvID.Text.ToString().Trim());

            if (InvoiceID < 1)
            {
                MessageBox.Show("Invoice No is required");
                return;
            }

            ExportInvoiceSht ExportInvoice = new ExportInvoiceSht(InvoiceID, UserID);
            ExportInvoice.ShowDialog();
        }

        #region TotalAmountToWords

        public string ConvertToWords(string TotalAmountStr)
        {
            string Val = "", TotalAmountStrFloor = TotalAmountStr, Points = "", AndStr = "", PointStr = "", EndStr = "ONLY";
            int decimalPlace = TotalAmountStr.IndexOf(".");

            if (decimalPlace > 0)
            {
                TotalAmountStrFloor = TotalAmountStr.Substring(0, decimalPlace);

                Points = TotalAmountStr.Substring(decimalPlace + 1);

                if (Convert.ToInt32(Points) > 0)
                {
                    AndStr = "AND SEN ";
                    PointStr = ConvertDecimals(Points);
                }
            }

            Val = string.Format("{0} {1}{2} {3}", ConvertWholeNumber(TotalAmountStrFloor).Trim(), AndStr, PointStr, EndStr);

            return Val;
        }

        public string ConvertWholeNumber(string TotalAmountStrFloor)
        {
            string word = "";
            bool beginsZero = false, isDone = false;
            double dblAmt = (Convert.ToDouble(TotalAmountStrFloor));

            if (dblAmt > 0)
            {
                beginsZero = TotalAmountStrFloor.StartsWith("0");

                int numDigits = TotalAmountStrFloor.Length;
                int pos = 0;
                string place = "";
                switch (numDigits)
                {
                    case 1:
                        word = Ones(TotalAmountStrFloor);
                        isDone = true;
                        break;
                    case 2:
                        word = Tens(TotalAmountStrFloor);
                        isDone = true;
                        break;
                    case 3:
                        pos = (numDigits % 3) + 1;
                        place = " HUNDRED ";
                        break;
                    case 4:
                    case 5:
                    case 6:
                        pos = (numDigits % 4) + 1;
                        place = " THOUSAND ";
                        break;
                    case 7:
                    case 8:
                    case 9:
                        pos = (numDigits % 7) + 1;
                        place = " MILLION ";
                        break;
                    case 10:
                    case 11:
                    case 12:

                        pos = (numDigits % 10) + 1;
                        place = " BILLION ";
                        break;
                    default:
                        isDone = true;
                        break;
                }

                if (!isDone)
                {
                    if (TotalAmountStrFloor.Substring(0, pos) != "0" && TotalAmountStrFloor.Substring(pos) != "0")
                    {
                        word = ConvertWholeNumber(TotalAmountStrFloor.Substring(0, pos)) + place + ConvertWholeNumber(TotalAmountStrFloor.Substring(pos));
                    }
                    else
                    {
                        word = ConvertWholeNumber(TotalAmountStrFloor.Substring(0, pos)) + ConvertWholeNumber(TotalAmountStrFloor.Substring(pos));
                    }
                }

                if (word.Trim().Equals(place.Trim())) word = "";
            }

            return word.Trim();
        }

        public string Ones(string TotalAmountStrFloor)
        {
            string name = "";

            switch (Convert.ToInt32(TotalAmountStrFloor))
            {

                case 1:
                    name = "ONE";
                    break;
                case 2:
                    name = "TWO";
                    break;
                case 3:
                    name = "THREE";
                    break;
                case 4:
                    name = "FOUR";
                    break;
                case 5:
                    name = "FIVE";
                    break;
                case 6:
                    name = "SIX";
                    break;
                case 7:
                    name = "SEVEN";
                    break;
                case 8:
                    name = "EIGHT";
                    break;
                case 9:
                    name = "NINE";
                    break;
            }

            return name;
        }

        public string Tens(string TotalAmountStrFloor)
        {
            string name = "";

            switch (Convert.ToInt32(TotalAmountStrFloor))
            {
                case 10:
                    name = "TEN";
                    break;
                case 11:
                    name = "ELEVEN";
                    break;
                case 12:
                    name = "TWELVE";
                    break;
                case 13:
                    name = "THIRTEEN";
                    break;
                case 14:
                    name = "FOURTEEN";
                    break;
                case 15:
                    name = "FIFTEEN";
                    break;
                case 16:
                    name = "SIXTEEN";
                    break;
                case 17:
                    name = "SEVENTEEN";
                    break;
                case 18:
                    name = "EIGHTEEN";
                    break;
                case 19:
                    name = "NINETEEN";
                    break;
                case 20:
                    name = "TWENTY";
                    break;
                case 30:
                    name = "THIRTY";
                    break;
                case 40:
                    name = "FOURTY";
                    break;
                case 50:
                    name = "FIFTY";
                    break;
                case 60:
                    name = "SIXTY";
                    break;
                case 70:
                    name = "SEVENTY";
                    break;
                case 80:
                    name = "EIGHTY";
                    break;
                case 90:
                    name = "NINETY";
                    break;
                default:
                    if (Convert.ToInt32(TotalAmountStrFloor) > 0)
                    {
                        name = Tens(TotalAmountStrFloor.Substring(0, 1) + "0") + " " + Ones(TotalAmountStrFloor.Substring(1));
                    }
                    break;
            }

            return name;
        }

        public string ConvertDecimals(string Points)
        {
            return ConvertWholeNumber(Points);
        }


        #endregion TotalAmountToWords

    }
}
