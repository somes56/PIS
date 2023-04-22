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
    public partial class DebitAED : Form
    {
        private int UserID = 0;

        public DebitAED(int DebitID, int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            AdvSearchInvoice("NONE");

            AdvSearchItems("NONE");

            if (DebitID != 0)
            {
                lblDebitID.Text = DebitID.ToString();
                LoadDebit(DebitID);
                DisableEdit();
            }
            else
            {
                lblDebitID.Text = "0";
                txtSearchInvNo.Focus();
                EnableEdit();
            }

        }

        private void DebitAED_Load(object sender, EventArgs e)
        {
            int DebitID = Convert.ToInt32(lblDebitID.Text.Trim());

            LoadDebitItems(DebitID);

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

        private void AdvSearchInvoice(string SearchBy)
        {
            DataTable Invoice = new DataTable();
            Invoice = DBUtil.AdvSearchInvoiceDebit(SearchBy);

            InvoiceList.DataSource = Invoice;
            InvoiceList.DisplayMember = "inv_no";
            InvoiceList.ValueMember = "id";
        }

        private void AdvSearchItems(string SearchBy)
        {
            DataTable Items = new DataTable();
            Items = DBUtil.AdvSearchInvoiceItems(SearchBy);

            ItemsList.DataSource = Items;
            ItemsList.DisplayMember = "name";
            ItemsList.ValueMember = "id";
        }

        private void txtSearchInvNo_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchInvNo.Text.Trim();

            if (SearchBy.Length > 0)
            {
                AdvSearchInvoice(SearchBy);
            }
            else
            {
                AdvSearchInvoice("NONE");
            }
        }

        private void txtSearchInvNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchItems_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchItems.Text.Trim();

            if (SearchBy.Length != 0)
            {
                ItemsList.Focus();
                AdvSearchItems(SearchBy);
            }
            else
            {
                AdvSearchItems("NONE");
            }
        }

        private void InvoiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int InvID = 0;

            if (InvoiceList.SelectedIndex > -1)
            {
                InvID = Convert.ToInt32(InvoiceList.SelectedValue.ToString().Trim());
                LoadInvoiceDetails(InvID);
            }
        }

        private void LoadInvoiceDetails(int InvoiceID)
        {
            int DebitID = 0;
            DebitID = Convert.ToInt32("0" + lblDebitID.Text.ToString().Trim());

            try
            {
                DataTable InvoiceDetails = new DataTable();
                InvoiceDetails = DBUtil.AdvSearchInvoiceDebit(InvoiceID, DebitID);

                int count = 0;
                count = InvoiceDetails.Rows.Count;

                if (count == 1)
                {
                    foreach (DataRow dr in InvoiceDetails.Rows)
                    {
                        txtInvNo.Text = dr["inv_no"].ToString();
                        txtSearchInvNo.Text = dr["inv_no"].ToString();
                        DtInvoice.Value = ((DateTime)dr["inv_date"]);
                        txtHBLNo.Text = dr["hbl_no"].ToString();
                        txtSCNNo.Text = dr["scn"].ToString();
                        txtVessel.Text = dr["vessel"].ToString();
                        txtLoadPort.Text = dr["load_port"].ToString();
                        txtUnloadPort.Text = dr["unload_port"].ToString();
                        txtStorageDays.Text = dr["storage_days"].ToString();
                        txtUnstuffDate.Text = Convert.ToDateTime(dr["unstuff_date"]).ToString("dd/MM/yyyy");
                        txtRefNo.Text = dr["ref_no"].ToString();
                        ChkPartial.Checked = ((bool)dr["partial"]);
                        txtIIDNo.Text = dr["iid_no"].ToString();
                        txtOBL.Text = dr["obl_no"].ToString();
                        txtVoyage.Text = dr["voyage_no"].ToString();
                        txtEta.Text = Convert.ToDateTime(dr["eta"]).ToString("dd/MM/yyyy");
                        txtConsignee.Text = dr["consignee"].ToString();
                        txtQty.Text = dr["goods_qty"].ToString();
                        txtWeight.Text = dr["weight"].ToString();
                        txtVolume.Text = dr["volume"].ToString();
                        txtLocation.Text = dr["location"].ToString();

                        if (Convert.ToInt32(dr["payment_method"]) == 0)
                        {
                            rbCash.Checked = true;
                        }
                        else if (Convert.ToInt32(dr["payment_method"]) == 1)
                        {
                            rbCredit.Checked = true;
                        }
                        else if (Convert.ToInt32(dr["payment_method"]) == 2)
                        {
                            rbCheque.Checked = true;
                        }
                        else if (Convert.ToInt32(dr["payment_method"]) == 3)
                        {
                            rbOnlineTransfer.Checked = true;
                        }
                    }
                }
                else
                {
                    txtInvNo.ResetText();
                    DtInvoice.ResetText();
                    txtHBLNo.ResetText();
                    txtSCNNo.ResetText();
                    txtVessel.ResetText();
                    txtLoadPort.ResetText();
                    txtUnloadPort.ResetText();
                    txtStorageDays.ResetText();
                    txtUnstuffDate.ResetText();
                    rbCash.Checked = true;
                    rbCredit.Checked = false;
                    rbCheque.Checked = false;
                    rbOnlineTransfer.Checked = false;
                    txtRefNo.ResetText();
                    ChkPartial.Checked = false;
                    txtIIDNo.ResetText();
                    txtOBL.ResetText();
                    txtVoyage.ResetText();
                    txtEta.ResetText();
                    txtConsignee.ResetText();
                    txtQty.ResetText();
                    txtWeight.ResetText();
                    txtVolume.ResetText();
                    txtLocation.ResetText();
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
            }
        }

        private void LoadDebit(int DebitID)
        {
            try
            {
                DataTable Debit = new DataTable();
                Debit = DBUtil.LoadDebit(DebitID);

                int count = Debit.Rows.Count;

                if (count != 0)
                {
                    lblDebitID.Text = Debit.Rows[0]["id"].ToString();
                    txtDebitNo.Text = Debit.Rows[0]["dr_no"].ToString();
                    txtInvNo.Text = Debit.Rows[0]["inv_no"].ToString();
                    txtTtlInv.Text = Debit.Rows[0]["ttl_inv"].ToString();
                    txtDrRefNo.Text = Debit.Rows[0]["ref_no"].ToString();

                    if (Convert.ToInt32(Debit.Rows[0]["payment_method"]) == 0)
                    {
                        rbDrCash.Checked = true;
                    }
                    else if (Convert.ToInt32(Debit.Rows[0]["payment_method"]) == 1)
                    {
                        rbDrCredit.Checked = true;
                    }
                    else if (Convert.ToInt32(Debit.Rows[0]["payment_method"]) == 2)
                    {
                        rbDrCheque.Checked = true;
                    }
                    else if (Convert.ToInt32(Debit.Rows[0]["payment_method"]) == 3)
                    {
                        rbDrOnlineTransfer.Checked = true;
                    }
                    LoadDebitItems(DebitID);
                    AdvSearchInvoice(txtInvNo.Text);
                    GetAmountInWords(Convert.ToDecimal("0" + txtTtlInv.Text.ToString().Trim()));
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                return;
            }
        }

        private void LoadDebitItems(int DebitID)
        {
            try
            {
                DataTable DebitItems = new DataTable();
                DebitItems = DBUtil.LoadDebitItems(DebitID);

                dgvInv.DataSource = DebitItems;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail To Load Invoice Items List." + e.Message, "Error");
                return;
            }
        }


        private void btnAddItems_Click(object sender, EventArgs e)
        {
            int DebitID = 0;
            int ItemID = 0;
            int ItemCodeID = 0;
            int Qty = 0;
            int Uuser = UserID;
            decimal UnitPrice;
            decimal Amount;
            var rtn = "";
            int Days = 0;

            if (ItemsList.SelectedIndex == -1)
            {
                MessageBox.Show("Invoice Item must be entered");
                txtSearchItems.Focus();
                return;
            }

            if (txtQty.Text == "")
            {
                MessageBox.Show("Invoice Item Quantity must be entered");
                txtQty.Focus();
                return;
            }

            if (txtUnitPrice.Text == "")
            {
                MessageBox.Show("Invoice Item Unit Price must be entered");
                txtUnitPrice.Focus();
                return;
            }

            ItemID = Convert.ToInt32(lblItemsID.Text.ToString().Trim());
            DebitID = Convert.ToInt32(lblDebitID.Text.ToString().Trim());
            ItemCodeID = Convert.ToInt32(ItemsList.SelectedValue.ToString());
            Qty = Convert.ToInt32(txtItemQty.Text.ToString().Trim());
            UnitPrice = Convert.ToDecimal(txtUnitPrice.Text.ToString().Trim());
            Days = Convert.ToInt32(txtStorageDays.Text.ToString().Trim());

            if (ItemCodeID == 9)
            {
                if (Days > 3)
                {
                    Amount = (Qty * UnitPrice * Days);
                }
                else
                {
                    Amount = (Qty * UnitPrice);
                }
            }
            else
            {
                Amount = (Qty * UnitPrice);
            }

            txtAmount.Text = Amount.ToString();

            rtn = DBUtil.UpsertDebitItems(ItemID, DebitID, ItemCodeID, Qty, UnitPrice, Amount, Uuser);

            if (rtn == "OK")
            {
                lblItemsID.Text = "0";
                txtSearchItems.ResetText();
                txtSearchItems.ReadOnly = false;
                ItemsList.Enabled = true;
                ItemsList.SelectedIndex = -1;
                ItemsList.ResetText();
                txtItemQty.ResetText();
                txtItemQty.ReadOnly = false;
                txtUnitPrice.ResetText();
                txtUnitPrice.ReadOnly = false;
                txtAmount.ResetText();
                AdvSearchItems("NONE");

                LoadDebit(DebitID);
            }
            else
            {
                MessageBox.Show("Error : " + rtn);
                return;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            int DebitID = 0;
            var rtn = "";

            if (dgvInv.Rows.Count == 0)
            {
                return;
            }

            DebitID = Convert.ToInt32(lblDebitID.Text.ToString().Trim());

            rtn = DBUtil.DelAllDebitItem(DebitID);

            if (rtn != "OK")
            {
                MessageBox.Show("ERROR : System unable to delete all invoice items");
                return;
            }
            else
            {
                LoadDebit(DebitID);
            }
        }

        private void dgvInv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ItemID = 0;
            int ItemCode = 0;
            var ItemDesc = "";
            int Qty = 0;
            decimal UnitPrice;
            decimal Amount;

            ItemID = Convert.ToInt32(dgvInv.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            ItemCode = Convert.ToInt32(dgvInv.Rows[e.RowIndex].Cells[1].Value.ToString().Trim());
            ItemDesc = dgvInv.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            Qty = Convert.ToInt32(dgvInv.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
            UnitPrice = Convert.ToDecimal(dgvInv.Rows[e.RowIndex].Cells[4].Value.ToString().Trim());
            Amount = Convert.ToDecimal(dgvInv.Rows[e.RowIndex].Cells[5].Value.ToString().Trim());

            lblItemsID.Text = ItemID.ToString();
            txtSearchItems.Text = ItemDesc;
            txtItemQty.Text = Qty.ToString();
            txtUnitPrice.Text = UnitPrice.ToString();
            txtAmount.Text = Amount.ToString();
            AdvSearchItems(ItemDesc);

            txtSearchItems.ReadOnly = true;
            ItemsList.Enabled = false;

            if (ItemCode == 3 || ItemCode == 9 || ItemCode == 10 || ItemCode == 118)
            {
                txtItemQty.ReadOnly = true;
                txtUnitPrice.ReadOnly = true;
            }
            else
            {
                txtItemQty.ReadOnly = false;
                txtUnitPrice.ReadOnly = false;
            }
        }

        private void EnableEdit()
        {
            pnlEdit.Visible = false;
            pnlSave.Visible = true;

            txtSearchInvNo.ReadOnly = false;
            txtInvNo.ReadOnly = true;
            InvoiceList.Visible = true;
            txtInvNo.Visible = false;

            DtInvoice.Enabled = false;

            ChkPartial.Enabled = false;

            panelMethod.Enabled = false;

            pnlDebitMethod.Enabled = true;

            txtDebitNo.ReadOnly = true;

            txtRefNo.ReadOnly = true;

            txtDrRefNo.ReadOnly = false;

            txtIIDNo.ReadOnly = true;

            txtHBLNo.Visible = true;
            txtHBLNo.ReadOnly = true;

            txtConsignee.Visible = true;
            txtConsignee.ReadOnly = true;

            txtSCNNo.ReadOnly = true;

            txtVessel.ReadOnly = true;

            txtLoadPort.ReadOnly = true;

            txtUnloadPort.ReadOnly = true;

            txtStorageDays.ReadOnly = true;

            txtUnstuffDate.ReadOnly = true;

            txtOBL.ReadOnly = true;

            txtVoyage.ReadOnly = true;

            txtEta.ReadOnly = true;

            txtQty.ReadOnly = true;

            txtWeight.ReadOnly = true;

            txtVolume.ReadOnly = true;

            txtSearchItems.ReadOnly = false;

            txtItemQty.ReadOnly = false;

            txtUnitPrice.ReadOnly = false;

            txtAmount.ReadOnly = true;
        }

        private void DisableEdit()
        {
            pnlEdit.Visible = true;
            pnlSave.Visible = false;

            ChkPartial.Enabled = false;

            panelMethod.Enabled = false;

            pnlDebitMethod.Enabled = false;

            txtRefNo.ReadOnly = true;

            txtDrRefNo.ReadOnly = true;

            txtIIDNo.ReadOnly = true;

            txtDebitNo.ReadOnly = true;

            txtSearchInvNo.ReadOnly = true;
            txtInvNo.ReadOnly = true;
            InvoiceList.Visible = false;
            txtInvNo.Visible = true;

            DtInvoice.Enabled = false;


            txtHBLNo.ReadOnly = true;

            txtConsignee.ReadOnly = true;

            txtSCNNo.ReadOnly = true;

            txtVessel.ReadOnly = true;

            txtLoadPort.ReadOnly = true;

            txtUnloadPort.ReadOnly = true;

            txtStorageDays.ReadOnly = true;

            txtUnstuffDate.ReadOnly = true;

            txtOBL.ReadOnly = true;

            txtVoyage.ReadOnly = true;

            txtEta.ReadOnly = true;

            txtQty.ReadOnly = true;

            txtWeight.ReadOnly = true;

            txtVolume.ReadOnly = true;

            txtSearchItems.ReadOnly = false;

            txtItemQty.ReadOnly = false;

            txtUnitPrice.ReadOnly = false;

            txtAmount.ReadOnly = true;
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            int DebitID = 0;
            string Amount = "";

            DebitID = Convert.ToInt32(lblDebitID.Text.ToString().Trim());
            Amount = lblAmountInWords.Text.ToString().Trim();

            if (dgvInv.Rows.Count != 0)
            {
                InvoiceDebitSht DebitSht = new InvoiceDebitSht(DebitID, Amount, UserID);
                DebitSht.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Debit Item Added To Generate Debit Note", "Warning");
                return;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(lblDebitID.Text.ToString().Trim());
            var DebitNo = txtDebitNo.Text.ToString().Trim();
            int InvoiceID = Convert.ToInt32(InvoiceList.SelectedValue);
            int Payment = 0;
            var DrRefNo = txtDrRefNo.Text.ToString().Trim();
            int Uuser = UserID;
            var rtn = "";
            var IssuePort = "";

            if (InvoiceList.SelectedIndex == -1)
            {
                MessageBox.Show("Invoice No is required.", "Warning");
                txtSearchInvNo.Focus();
                return;
            }

            if (rbDrCash.Checked)
            {
                Payment = 0;
            }
            else if (rbDrCredit.Checked)
            {
                Payment = 1;
                if (txtDrRefNo.Text == "")
                {
                    MessageBox.Show("Reference No is required.");
                    return;
                }
            }
            else if (rbDrCheque.Checked)
            {
                Payment = 2;
                if (txtDrRefNo.Text == "")
                {
                    MessageBox.Show("Reference No is required.");
                    return;
                }
            }
            else if (rbDrOnlineTransfer.Checked)
            {
                Payment = 3;
                if (txtDrRefNo.Text == "")
                {
                    MessageBox.Show("Reference No is required.");
                    return;
                }
            }

            IssuePort = GetIssuePort();
            if (IssuePort == "-")
            {
                return;
            }

            if (ID == 0)
            {
                DebitNo = DBUtil.GenerateDebitNo(IssuePort);

                if (DebitNo != "")
                {
                    rtn = DBUtil.UpsertDebit(ID, DebitNo, InvoiceID, Payment, DrRefNo, Uuser);

                    if (rtn == "OK")
                    {
                        ID = DBUtil.GetDebitID(DebitNo);

                        if (ID != 0)
                        {
                            LoadDebit(ID);
                            DisableEdit();
                        }
                        else
                        {
                            MessageBox.Show("System Unable To Load Data For " + DebitNo, "Error");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(rtn, "Error");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(DebitNo, "Error");
                    return;
                }
            }
            else
            {
                rtn = DBUtil.UpsertDebit(ID, DebitNo, InvoiceID, Payment, DrRefNo, Uuser);
                if (rtn == "OK")
                {
                    LoadDebit(ID);
                    DisableEdit();
                }
                else
                {
                    MessageBox.Show(rtn, "Error");
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableEdit();
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
            int DebitID = 0;
            var rtn = "";

            DebitID = Convert.ToInt32(lblDebitID.Text.ToString().Trim());

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this Debit Note?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)
            {
                rtn = DBUtil.DelDebit(DebitID);

                if (rtn != "ERROR")
                {
                    rtn = DBUtil.DelAllDebitItem(DebitID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("System Unable To Delete Credit Note : " + txtDebitNo.Text.ToString(), "Error");
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int DebitID = 0;
            int ItemID = 0;
            var rtn = "";

            DebitID = Convert.ToInt32(lblDebitID.Text.ToString().Trim());
            ItemID = Convert.ToInt32(lblItemsID.Text.ToString().Trim());

            if (ItemID == 0)
            {
                return;
            }

            rtn = DBUtil.DelDebitItems(ItemID);

            if (rtn != "ERROR")
            {
                LoadDebit(DebitID);

                lblItemsID.Text = "0";
                txtSearchItems.ResetText();
                txtSearchItems.ReadOnly = false;
                ItemsList.Enabled = true;
                ItemsList.SelectedIndex = -1;
                ItemsList.ResetText();
                txtItemQty.ResetText();
                txtItemQty.ReadOnly = false;
                txtUnitPrice.ResetText();
                txtUnitPrice.ReadOnly = false;
                txtAmount.ResetText();
                AdvSearchItems("NONE");
            }
            else
            {
                MessageBox.Show("System Unable To Delete Selected Debit Item", "Error");
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblItemsID.Text = "0";
            txtSearchItems.ResetText();
            txtSearchItems.ReadOnly = false;
            ItemsList.Enabled = true;
            ItemsList.SelectedIndex = -1;
            ItemsList.ResetText();
            txtItemQty.ResetText();
            txtItemQty.ReadOnly = false;
            txtUnitPrice.ResetText();
            txtUnitPrice.ReadOnly = false;
            txtAmount.ResetText();
            AdvSearchItems("NONE");
        }

        private void ItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ItemID = 0;
            int ItemCodeID = 0;
            int InvoiceID = 0;
            int ClassID = 0;
            int Qty = 0;
            int StorageDays = 0;

            ItemID = Convert.ToInt32(lblItemsID.Text.ToString().Trim());

            if (ItemsList.SelectedIndex > -1)
            {
                if (ItemID == 0)
                {
                    ItemCodeID = Convert.ToInt32(ItemsList.SelectedValue);

                    if (ItemCodeID == 3 || ItemCodeID == 9 || ItemCodeID == 10 || ItemCodeID == 118)
                    {
                        txtItemQty.ReadOnly = true;
                        txtUnitPrice.ReadOnly = true;

                        if (InvoiceList.SelectedIndex > -1)
                        {
                            InvoiceID = Convert.ToInt32(InvoiceList.SelectedValue);
                            ClassID = DBUtil.GetClassID(InvoiceID);
                            Qty = CalculateQty();
                            StorageDays = Convert.ToInt32(txtStorageDays.Text.ToString().Trim());

                            if (Qty != -1 && ClassID != -1)
                            {
                                GetUnitPrice(ItemCodeID, ClassID, StorageDays, Qty, InvoiceID);
                            }
                            else
                            {
                                txtItemQty.ResetText();
                                txtUnitPrice.ResetText();
                                return;
                            }
                        }
                    }
                    else
                    {
                        txtItemQty.ResetText();
                        txtUnitPrice.ResetText();
                        txtItemQty.ReadOnly = false;
                        txtUnitPrice.ReadOnly = false;
                    }
                }
            }
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
            catch (Exception e)
            {
                rtn = -1;
            }
            return rtn;
        }

        public void GetUnitPrice(int ItemCodeID, int ClassID, int Days, int Qty, int InvoiceID)
        {
            if (ClassID == 6)
            {
                if (Days <= 3)
                {
                    if (Qty <= 1)
                    {
                        if (ItemCodeID == 3)//Handling
                        {
                            txtUnitPrice.Text = "20.00";
                            txtItemQty.Text = "1";
                        }
                        else if (ItemCodeID == 9)//Storage
                        {
                            txtUnitPrice.Text = "0.00";
                            txtItemQty.Text = "0";
                        }
                        else if (ItemCodeID == 10)//Removal
                        {
                            txtUnitPrice.Text = "0.00";
                            txtItemQty.Text = "0";
                        }
                        else if (ItemCodeID == 118)//FAF
                        {
                            txtUnitPrice.Text = "3.50";
                            txtItemQty.Text = "1";
                        }
                    }
                    else
                    {
                        if (ItemCodeID == 3)//Handling
                        {
                            txtUnitPrice.Text = "12.00";
                            txtItemQty.Text = Qty.ToString();
                        }
                        else if (ItemCodeID == 9)//Storage
                        {
                            txtUnitPrice.Text = "0.00";
                            txtItemQty.Text = "0";
                        }
                        else if (ItemCodeID == 10)//Removal
                        {
                            txtUnitPrice.Text = "0.00";
                            txtItemQty.Text = "0";
                        }
                        else if (ItemCodeID == 118)//FAF
                        {
                            txtUnitPrice.Text = "3.50";
                            txtItemQty.Text = Qty.ToString();
                        }
                    }
                }
                else //Days >3
                {
                    if (Qty <= 1)
                    {
                        if (ItemCodeID == 3)//Handling
                        {
                            txtUnitPrice.Text = "20.00";
                            txtItemQty.Text = "1";
                        }
                        else if (ItemCodeID == 9)//Storage
                        {
                            txtUnitPrice.Text = "4.50";
                            txtItemQty.Text = "1";
                        }
                        else if (ItemCodeID == 10)//Removal
                        {
                            txtUnitPrice.Text = "3.00";
                            txtItemQty.Text = "1";
                        }
                        else if (ItemCodeID == 118)//FAF
                        {
                            txtUnitPrice.Text = "3.50";
                            txtItemQty.Text = "1";
                        }
                    }
                    else
                    {
                        if (ItemCodeID == 3)//Handling
                        {
                            txtUnitPrice.Text = "12.00";
                            txtItemQty.Text = Qty.ToString();
                        }
                        else if (ItemCodeID == 9)//Storage
                        {
                            txtUnitPrice.Text = "4.50";
                            txtItemQty.Text = Qty.ToString();
                        }
                        else if (ItemCodeID == 10)//Removal
                        {
                            txtUnitPrice.Text = "3.00";
                            txtItemQty.Text = Qty.ToString();
                        }
                        else if (ItemCodeID == 118)//FAF
                        {
                            txtUnitPrice.Text = "3.50";
                            txtItemQty.Text = Qty.ToString();
                        }
                    }
                }
            }
            else if (ClassID == 7 || ClassID == 8 || ClassID == 9)
            {
                if (Days <= 3)
                {
                    if (Qty <= 1)
                    {
                        if (ItemCodeID == 3)//Handling
                        {
                            txtUnitPrice.Text = "20.00";
                            txtItemQty.Text = "1";
                        }
                        else if (ItemCodeID == 9)//Storage
                        {
                            txtUnitPrice.Text = "0.00";
                            txtItemQty.Text = "0";
                        }
                        else if (ItemCodeID == 10)//Removal
                        {
                            txtUnitPrice.Text = "0.00";
                            txtItemQty.Text = "0";
                        }
                        else if (ItemCodeID == 118)//FAF
                        {
                            txtUnitPrice.Text = "3.50";
                            txtItemQty.Text = "1";
                        }
                    }
                    else
                    {
                        if (ItemCodeID == 3)//Handling
                        {
                            txtUnitPrice.Text = "12.00";
                            txtItemQty.Text = Qty.ToString();
                        }
                        else if (ItemCodeID == 9)//Storage
                        {
                            txtUnitPrice.Text = "0.00";
                            txtItemQty.Text = "0";
                        }
                        else if (ItemCodeID == 10)//Removal
                        {
                            txtUnitPrice.Text = "0.00";
                            txtItemQty.Text = "0";
                        }
                        else if (ItemCodeID == 118)//FAF
                        {
                            txtUnitPrice.Text = "3.50";
                            txtItemQty.Text = Qty.ToString();
                        }
                    }
                }
                else //Days >3
                {
                    if (Qty <= 1)
                    {
                        if (ItemCodeID == 3)//Handling
                        {
                            txtUnitPrice.Text = "20.00";
                            txtItemQty.Text = "1";
                        }
                        else if (ItemCodeID == 9)//Storage
                        {
                            txtUnitPrice.Text = "0.00";
                            txtItemQty.Text = "0";
                        }
                        else if (ItemCodeID == 10)//Removal
                        {
                            txtUnitPrice.Text = "0.00";
                            txtItemQty.Text = "0";
                        }
                        else if (ItemCodeID == 118)//FAF
                        {
                            txtUnitPrice.Text = "3.50";
                            txtItemQty.Text = "1";
                        }
                    }
                    else
                    {
                        if (ItemCodeID == 3)//Handling
                        {
                            txtUnitPrice.Text = "12.00";
                            txtItemQty.Text = Qty.ToString();
                        }
                        else if (ItemCodeID == 9)//Storage
                        {
                            txtUnitPrice.Text = "0.00";
                            txtItemQty.Text = "0";
                        }
                        else if (ItemCodeID == 10)//Removal
                        {
                            txtUnitPrice.Text = "0.00";
                            txtItemQty.Text = "0";
                        }
                        else if (ItemCodeID == 118)//FAF
                        {
                            txtUnitPrice.Text = "3.50";
                            txtItemQty.Text = Qty.ToString();
                        }
                    }
                }
            }
            else
            {
                txtItemQty.ResetText();
                txtUnitPrice.ResetText();
                MessageBox.Show("ERROR : Unable To Generate Invoice As Selected HBL Not In Normal/DG Cargo");
                return;
            }
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            CustAED CustAED = new CustAED(1, 0, UserID);
            CustAED.ShowDialog();
        }

        public void GetAmountInWords(decimal TtlInvoiceAmount)
        {
            try
            {
                string Amount = "";
                Amount = TtlInvoiceAmount.ToString();

                if (Amount.Contains("-"))
                {
                    Amount = Amount.Substring(1, Amount.Length - 1);
                }
                if (Amount == "0")
                {
                    lblAmountInWords.Text = "";
                }
                else
                {
                    lblAmountInWords.Text = "RINGGIT MALAYSIA : " + ConvertToWords(Amount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string ConvertToWords(string numb)
        {
            string val = "";
            string wholeNo = numb;
            string points = "";
            string andStr = "";
            string pointStr = "";
            string endStr = "ONLY";
            try
            {
                int decimalPlace = numb.IndexOf(".");
                if (decimalPlace > 0)
                {
                    wholeNo = numb.Substring(0, decimalPlace);
                    points = numb.Substring(decimalPlace + 1);
                    if (Convert.ToInt32(points) > 0)
                    {
                        andStr = "AND SEN ";
                        pointStr = ConvertDecimals(points);
                    }
                }
                val = string.Format("{0} {1}{2} {3}", ConvertWholeNumber(wholeNo).Trim(), andStr, pointStr, endStr);
            }
            catch
            {
            }
            return val;
        }

        public string ConvertWholeNumber(string Number)
        {
            string word = "";
            try
            {
                bool beginsZero = false;
                bool isDone = false;
                double dblAmt = (Convert.ToDouble(Number));

                if (dblAmt > 0)
                {
                    beginsZero = Number.StartsWith("0");

                    int numDigits = Number.Length;
                    int pos = 0;
                    string place = "";
                    switch (numDigits)
                    {
                        case 1:
                            word = Ones(Number);
                            isDone = true;
                            break;
                        case 2:
                            word = Tens(Number);
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
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                word = ConvertWholeNumber(Number.Substring(0, pos)) + place + ConvertWholeNumber(Number.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = ConvertWholeNumber(Number.Substring(0, pos)) + ConvertWholeNumber(Number.Substring(pos));
                        }
                    }
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch
            {
            }
            return word.Trim();
        }

        public string Ones(string Number)
        {
            string name = "";
            switch (Convert.ToInt32(Number))
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

        public string Tens(string Number)
        {
            string name = "";
            switch (Convert.ToInt32(Number))
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
                    if (Convert.ToInt32(Number) > 0)
                    {
                        name = Tens(Number.Substring(0, 1) + "0") + " " + Ones(Number.Substring(1));
                    }
                    break;
            }
            return name;
        }

        public string ConvertDecimals(string number)
        {
            string cd = "";
            cd = ConvertWholeNumber(number);
            return cd;
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
                MessageBox.Show("Issue Port Key of App Settings in App Config is missing.", "Error");
                rtn = "-";
            }

            return rtn;
        }
    }
}
