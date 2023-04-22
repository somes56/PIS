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
    public partial class ImportInvAED : Form
    {
        private int UserID = 0;

        public ImportInvAED(int ID, int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            AdvSearchInvoiceHBL("NONE");

            AdvSearchInvoiceConsignee("!~");

            AdvSearchItems("NONE");

            if (ID != 0)
            {
                lblInvID.Text = ID.ToString();
                LoadInvoice(ID);
                DisableEdit();
            }
            else
            {
                lblInvID.Text = "0";
                txtSearchHBLNo.Focus();
                EnableEdit();
            }

        }

        private void ImportInvAED_Load(object sender, EventArgs e)
        {
            var ID = Convert.ToInt32(lblInvID.Text.Trim());

            LoadInvoiceItems(ID);

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

        private void AdvSearchInvoiceHBL(string SearchBy)
        {
            DataTable HBL = new DataTable();
            HBL = DBUtil.AdvSearchInvoiceHBL(SearchBy);

            HBLNoList.DataSource = HBL;
            HBLNoList.DisplayMember = "hbl_no";
            HBLNoList.ValueMember = "id";
        }

        private void AdvSearchInvoiceConsignee(string SearchBy)
        {
            DataTable Consignee = new DataTable();
            Consignee = DBUtil.AdvSearchInvoiceConsignee(SearchBy);

            ConsigneeList.DataSource = Consignee;
            ConsigneeList.DisplayMember = "name";
            ConsigneeList.ValueMember = "id";
        }

        private void AdvSearchItems(string SearchBy)
        {
            DataTable Items = new DataTable();
            Items = DBUtil.AdvSearchInvoiceItems(SearchBy);

            ItemsList.DataSource = Items;
            ItemsList.DisplayMember = "name";
            ItemsList.ValueMember = "id";
        }

        private void HBLNoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int HBLID = 0;
            int INVID = 0;

            INVID = Convert.ToInt32(lblInvID.Text.ToString().Trim());

            if (HBLNoList.SelectedIndex > -1)
            {
                HBLID = Convert.ToInt32(HBLNoList.SelectedValue.ToString().Trim());
                LoadOBLHBLDetails(HBLID, INVID);
            }
        }

        private void txtSearchHBLNo_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchHBLNo.Text.Trim();

            if (SearchBy.Length != 0)
            {
                HBLNoList.Focus();
                AdvSearchInvoiceHBL(SearchBy);
            }
            else
            {
                AdvSearchInvoiceHBL("NONE");
            }
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

        private void txtSearchConsignee_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchConsignee.Text.Trim();

            if (SearchBy.Length != 0)
            {
                ConsigneeList.Focus();
                AdvSearchInvoiceConsignee(SearchBy);
            }
            else
            {
                AdvSearchInvoiceConsignee("~!");
            }
        }

        private void LoadInvoiceItems(int InvID)
        {
            try
            {
                DataTable Items = new DataTable();
                Items = DBUtil.LoadInvoiceItems(InvID);

                dgvInv.DataSource = Items;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail To Load Invoice Items List." + e.Message, "Error");
                return;
            }
        }

        private void LoadOBLHBLDetails(int HBLID, int INVID)
        {
            DataTable OBLHBL = new DataTable();
            var IssueDate = DtInvoice.Value.ToString("yyyy/MM/dd");

            OBLHBL = DBUtil.LoadOBLHBL(HBLID, INVID, IssueDate);

            if (OBLHBL.Rows.Count > 0)
            {
                txtSCNNo.Text = OBLHBL.Rows[0]["SCN"].ToString();
                txtVessel.Text = OBLHBL.Rows[0]["Vessel"].ToString();
                txtLoadPort.Text = OBLHBL.Rows[0]["LoadPort"].ToString();
                txtUnloadPort.Text = OBLHBL.Rows[0]["UnloadPort"].ToString();
                txtUnstuffDate.Text = Convert.ToDateTime(OBLHBL.Rows[0]["UnstuffDate"]).ToString("dd/MM/yyyy");
                txtOBL.Text = OBLHBL.Rows[0]["OBLNo"].ToString();
                txtVoyage.Text = OBLHBL.Rows[0]["VoyageNo"].ToString();
                txtEta.Text = OBLHBL.Rows[0]["ETA"].ToString();
                txtLocation.Text = OBLHBL.Rows[0]["Location"].ToString();
                txtPackaging.Text = OBLHBL.Rows[0]["Packaging"].ToString();
                GetPartialLoadDetails(HBLID);
                if (INVID == 0)
                {
                    txtStorageDays.Text = OBLHBL.Rows[0]["StorageDays"].ToString();
                    txtSearchConsignee.Text = OBLHBL.Rows[0]["Consignee"].ToString();
                    txtConsignee.Text = OBLHBL.Rows[0]["Consignee"].ToString();
                    AdvSearchInvoiceConsignee(txtSearchConsignee.Text.Trim().ToString());
                    txtQty.Text = OBLHBL.Rows[0]["Qty"].ToString();
                    txtWeight.Text = OBLHBL.Rows[0]["Weight"].ToString();
                    txtVolume.Text = OBLHBL.Rows[0]["Volume"].ToString();
                }

            }
            else
            {
                txtSCNNo.ResetText();
                txtVessel.ResetText();
                txtLoadPort.ResetText();
                txtUnloadPort.ResetText();
                txtUnstuffDate.ResetText();
                txtOBL.ResetText();
                txtVoyage.ResetText();
                txtEta.ResetText();

                if (INVID == 0)
                {
                    txtStorageDays.ResetText();
                    txtSearchConsignee.ResetText();
                    txtConsignee.ResetText();
                    AdvSearchInvoiceConsignee("");
                    txtQty.ResetText();
                    txtWeight.ResetText();
                    txtVolume.ResetText();
                }

                MessageBox.Show("System Unable To Load OBL & HBL Details", "Error");
            }           
        }


        private void GetPartialLoadDetails(int HBLID)
        {
            DataTable Partial = new DataTable();
            Partial = DBUtil.GetPartialLoadDetails(HBLID);

            int count = 0;
            count = Partial.Rows.Count;

            if (count == 1)
            {
                foreach (DataRow dr in Partial.Rows)
                {
                    lblIntialQty.Text = dr["InitialQty"].ToString();
                    lblInitialWeight.Text = dr["InitialWeight"].ToString();
                    lblInitialVolume.Text = dr["InitialVolume"].ToString();
                    lblBalQty.Text = dr["BalanceQty"].ToString();
                    lblBalWeight.Text = dr["BalanceWeight"].ToString();
                    lblBalVolume.Text = dr["BalanceVolume"].ToString();
                }
            }
        }

        private void LoadInvoice(int InvoiceID)
        {
            var InvNo = "";
            var HBLNo = "";
            var IIDNo = "";
            int PaymentMethod = 0;
            var RefNo = "";
            var Qty = "";
            var Weight = "";
            var Volume = "";
            var Consignee = "";
            bool Partial = false;
            var StorageDays = "";

            lblInvID.Text = InvoiceID.ToString();

            DataTable InvoiceDetails = new DataTable();
            InvoiceDetails = DBUtil.LoadInvoice(InvoiceID);

            int count = 0;
            count = InvoiceDetails.Rows.Count;

            if (count == 1)
            {
                foreach (DataRow dr in InvoiceDetails.Rows)
                {
                    InvNo = (string)dr["inv_no"].ToString();
                    DtInvoice.Value = ((DateTime)dr["inv_date"]);
                    HBLNo = (string)dr["hbl_no"];
                    txtTtlInv.Text = (string)dr["ttl_inv"].ToString();
                    IIDNo = (string)dr["iid_no"].ToString();
                    PaymentMethod = Convert.ToInt32(dr["payment_method"]);
                    RefNo = (string)dr["ref_no"].ToString();
                    Qty = (string)dr["goods_qty"].ToString();
                    Weight = dr["weight"].ToString();
                    Volume = dr["volume"].ToString();
                    Partial = (bool)dr["partial"];
                    Consignee = (string)dr["consignee"];
                    StorageDays = dr["storage_days"].ToString();
                }
                txtInvNo.Text = InvNo.Trim();
                txtHBLNo.Text = HBLNo.Trim();
                txtSearchHBLNo.Text = HBLNo.Trim();
                txtSearchConsignee.Text = Consignee;
                txtConsignee.Text = Consignee;
                txtIIDNo.Text = IIDNo;
                txtRefNo.Text = RefNo;
                txtQty.Text = Qty;
                txtWeight.Text = Weight;
                txtVolume.Text = Volume;
                ChkPartial.Checked = Partial;
                txtStorageDays.Text = StorageDays;

                AdvSearchInvoiceConsignee(Consignee);

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

                AdvSearchInvoiceHBL(HBLNo.Trim());

                LoadInvoiceItems(InvoiceID);

                GetAmountInWords(Convert.ToDecimal("0" + txtTtlInv.Text.ToString().Trim()));

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (HBLNoList.SelectedIndex == -1)
            {
                MessageBox.Show("HBL is required to issue invoice", "Warning !");
                return;
            }

            int ID = Convert.ToInt32(lblInvID.Text.ToString().Trim());
            var InvNo = txtInvNo.Text.ToString().Trim();
            DateTime InvDate = DtInvoice.Value;
            int HBLID = Convert.ToInt32(HBLNoList.SelectedValue);
            int PaymentMethod = 0;
            var RefNo = txtRefNo.Text.ToString().Trim();
            bool Partial = ChkPartial.Checked;
            var IIDNo = txtIIDNo.Text.ToString().Trim();
            var Qty = txtQty.Text.ToString().Trim();
            decimal Weight = Convert.ToDecimal(txtWeight.Text.ToString().Trim());
            decimal Volume = Convert.ToDecimal(txtVolume.Text.ToString().Trim());
            int Uuser = UserID;
            //var rtnInvNo = "";
            var rtn = "";
            int NewID = 0;
            int ConsigneeID = Convert.ToInt32(ConsigneeList.SelectedValue);
            int StorageDays = Convert.ToInt32(txtStorageDays.Text.Trim().ToString());
            var IssuePort = "";
            var InvoiceIssueFlag = "";
            InvoiceIssueFlag = DBUtil.CheckHBLIssuedInvoice(HBLID);

            if (ID == 0)
            {
                if (InvoiceIssueFlag == "N")
                {
                    MessageBox.Show("An Invoice has been issued for selected HBL." + Environment.NewLine + "Please select a new HBL", "Warning!");
                    return;
                }
                else if (InvoiceIssueFlag != "N" && InvoiceIssueFlag != "Y")
                {
                    MessageBox.Show(InvoiceIssueFlag, "Application Error");
                    return;
                }
            }

            if (rbCash.Checked)
            {
                PaymentMethod = 0;
            }
            else if (rbCredit.Checked)
            {
                PaymentMethod = 1;
                if (txtRefNo.Text == "")
                {
                    MessageBox.Show("Reference No is required.");
                    return;
                }
            }
            else if (rbCheque.Checked)
            {
                PaymentMethod = 2;
                if (txtRefNo.Text == "")
                {
                    MessageBox.Show("Reference No is required.");
                    return;
                }
            }
            else if (rbOnlineTransfer.Checked)
            {
                PaymentMethod = 3;
                if (txtRefNo.Text == "")
                {
                    MessageBox.Show("Reference No is required.");
                    return;
                }
            }

            if (txtIIDNo.Text == "")
            {
                MessageBox.Show("IID No is required.");
                return;
            }

            if (ChkPartial.Checked)
            {
                Partial = true;

                if (txtQty.Text == "")
                {
                    MessageBox.Show("Quantity is required.");
                    return;
                }

                if (txtWeight.Text == "")
                {
                    MessageBox.Show("Weight is required.");
                    return;
                }

                if (txtVolume.Text == "")
                {
                    MessageBox.Show("Volume is required.");
                    return;
                }
            }
            else
            {
                Partial = false;
            }

            if (txtStorageDays.Text == "")
            {
                MessageBox.Show("No Storage Days", "Warning !");
                return;
            }

            if (StorageDays < 0)
            {
                MessageBox.Show("Storage Days is less than 0", "Warning !");
                return;
            }

            IssuePort = GetIssuePort();

            if (IssuePort == "-")
            {
                return;
            }
            
            int ContainerUnstuffStatus = 0;

            ContainerUnstuffStatus = DBUtil.GetContainerUnstuffStatus(Convert.ToInt32(HBLID));

            if (ContainerUnstuffStatus == 1)
            {
                if (ID == 0)
                {
                    InvNo = DBUtil.GenerateInvoiceNo(IssuePort);

                    if (InvNo != "")
                    {
                        rtn = DBUtil.UpsertInvoice(ID, InvNo.ToString(), InvDate, IIDNo, PaymentMethod, RefNo,
                                        HBLID, ConsigneeID, Qty, Weight, Volume, Partial, StorageDays, Uuser);

                        if (rtn == "OK")
                        {
                            NewID = DBUtil.GetInvoiceID(InvNo);
                            if (NewID != 0)
                            {
                                LoadInvoice(NewID);
                                DisableEdit();
                            }
                            else
                            {
                                MessageBox.Show("ERROR : Fail To Load Saved Data");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error : " + rtn.Trim());
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error : Fail To Generate Invoice No");
                        return;
                    }

                }
                else
                {
                    rtn = DBUtil.UpsertInvoice(ID, InvNo, InvDate, IIDNo, PaymentMethod, RefNo,
                                                HBLID, ConsigneeID, Qty, Weight, Volume, Partial, StorageDays, Uuser);

                    if (rtn == "OK")
                    {
                        LoadInvoice(ID);
                        DisableEdit();
                    }
                    else
                    {
                        MessageBox.Show("Error : " + rtn.Trim());
                        return;
                    }
                }
            }
            else if (ContainerUnstuffStatus == 0)
            {
                MessageBox.Show("Container is not unstuff. Please unstuff before issue invoice");
                return;
            }
            else
            {
                MessageBox.Show("Error : Unable to obtain Container Unstuff Status");
                return;
            }
        }

        private void btnGenerateInv_Click(object sender, EventArgs e)
        {
            int InvoiceID = 0;
            int Qty = 0;
            int Days = 0;
            int ClassID = 0;
            var UnstuffDate = "";
            var InvoiceDate = "";

            InvoiceID = Convert.ToInt32(0 + lblInvID.Text.ToString().Trim());
            UnstuffDate = txtUnstuffDate.Text.ToString().Trim();
            InvoiceDate = DtInvoice.Value.ToString("dd/MM/yyyy");
            Days = Convert.ToInt32(txtStorageDays.Text.ToString());
            ClassID = DBUtil.GetClassID(InvoiceID);
            Qty = CalculateQty();

            if (InvoiceID == 0)
            {
                return;
            }

            if (txtStorageDays.Text == "")
            {
                MessageBox.Show("No Storage Days","Warning !");
                return;
            }

            if (Days <0)
            {
                MessageBox.Show("Storage Days is less than 0", "Warning !");
                return;
            }

            if (Qty == -1)
            {
                MessageBox.Show("ERROR : System is unable to calculate volume(m3) and weight.");
                return;
            }

            if (ClassID != -1)
            {
                if (ClassID == 6)
                {
                    NormalCargo(Days, Qty, InvoiceID);
                }
                else if (ClassID == 7 || ClassID == 8 || ClassID == 9)
                {
                    DangerousCargo(Days, Qty, InvoiceID);
                }
                else
                {
                    MessageBox.Show("ERROR : Unable To Generate Invoice As Selected HBL Not In Normal/DG Cargo");
                    return;
                }
            }
            else
            {
                MessageBox.Show("ERROR : Unable To Get Container Class");
                return;
            }
            LoadInvoice(InvoiceID);

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
            catch(Exception e)
            {
                rtn = -1;
            }


            return rtn;
        }

        public void NormalCargo(int Days, int Qty, int InvoiceID)
        {
            var Exist = "";
            decimal UnitPrice;
            decimal Amount;

            if (Days <= 3)
            {
                if (Qty <= 1)
                {
                    //Check Exist - Handling
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 3);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 20.00m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 3, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check Handling Charges Included.");
                        return;
                    }

                    //Check Exist - FAF
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 118);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 3.50m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 118, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check FAF Charges Included.");
                        return;
                    }
                }
                else
                {
                    //Check Exist - Handling
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 3);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 12.00m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 3, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check Handling Charges Included.");
                        return;
                    }

                    //Check Exist - FAF
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 118);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 3.50m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 118, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check FAF Charges Included.");
                        return;
                    }
                }
            }
            else
            {
                if (Qty <= 1)
                {
                    //Check Exist - Handling
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 3);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 20.00m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 3, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check Handling Charges Included.");
                        return;
                    }

                    //Check Exist - storage
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 9);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 4.50m;
                            Amount = (UnitPrice * Days * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 9, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check Storage Charges Included.");
                        return;
                    }

                    //Check Exist - Removal
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 10);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 3.00m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 10, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check Removal Charges Included.");
                        return;
                    }

                    //Check Exist - FAF
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 118);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 3.50m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 118, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check FAF Charges Included.");
                        return;
                    }
                }
                else
                {
                    //Check Exist - Handling
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 3);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 12.00m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 3, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check Handling Charges Included.");
                        return;
                    }

                    //Check Exist - storage
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 9);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 4.50m;
                            Amount = (UnitPrice * Days * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 9, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check Storage Charges Included.");
                        return;
                    }

                    //Check Exist - Removal
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 10);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 3.00m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 10, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check Removal Charges Included.");
                        return;
                    }

                    //Check Exist - FAF
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 118);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 3.50m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 118, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check FAF Charges Included.");
                        return;
                    }
                }

            }
        }

        public void DangerousCargo(int Days, int Qty, int InvoiceID)
        {
            var Exist = "";
            decimal UnitPrice;
            decimal Amount;

            if (Days <= 3)
            {
                if (Qty <= 1)
                {
                    //Check Exist - Handling
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 3);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 20.00m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 3, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check Handling Charges Included.");
                        return;
                    }

                    //Check Exist - FAF
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 118);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 3.50m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 118, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check FAF Charges Included.");
                        return;
                    }
                }
                else
                {
                    //Check Exist - Handling
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 3);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 12.00m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 3, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check Handling Charges Included.");
                        return;
                    }

                    //Check Exist - FAF
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 118);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 3.50m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 118, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check FAF Charges Included.");
                        return;
                    }
                }
            }
            else
            {
                if (Qty <= 1)
                {
                    //Check Exist - Handling
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 3);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 20.00m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 3, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check Handling Charges Included.");
                        return;
                    }

                    //Check Exist - FAF
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 118);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 3.50m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 118, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check FAF Charges Included.");
                        return;
                    }
                }
                else
                {
                    //Check Exist - Handling
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 3);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 12.00m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 3, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check Handling Charges Included.");
                        return;
                    }

                    //Check Exist - FAF
                    Exist = DBUtil.CheckInvoiceItemExist(InvoiceID, 118);
                    if (Exist != "E")
                    {
                        if (Exist == "N")
                        {
                            UnitPrice = 3.50m;
                            Amount = (UnitPrice * Qty);
                            var rtn = DBUtil.UpsertInvoiceItems(0, InvoiceID, 118, Qty, UnitPrice, Amount, UserID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Fail To Check FAF Charges Included.");
                        return;
                    }
                }

            }
        }

        private void dgvInv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ItemID = 0;
            var ItemDesc = "";
            int Qty = 0;
            decimal UnitPrice;
            decimal Amount;

            ItemID = Convert.ToInt32(dgvInv.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
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

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            int InvID = 0;
            int ItemID = 0;
            int ItemCodeID = 0;
            int Qty;
            decimal UnitPrice;
            decimal Amount;
            var rtn = "";

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

            InvID = Convert.ToInt32(lblInvID.Text.ToString().Trim());
            ItemID = Convert.ToInt32(lblItemsID.Text.ToString().Trim());
            ItemCodeID = Convert.ToInt32(ItemsList.SelectedValue.ToString());
            Qty = Convert.ToInt32(txtItemQty.Text.ToString().Trim());
            UnitPrice = Convert.ToDecimal(txtUnitPrice.Text.ToString().Trim());
            Amount = (Qty * UnitPrice);


            rtn = DBUtil.UpsertInvoiceItems(ItemID, InvID, ItemCodeID, Qty, UnitPrice, Amount, UserID);

            if (rtn == "OK")
            {
                lblItemsID.Text = "0";
                txtSearchItems.Text = "";
                ItemsList.SelectedIndex = -1;
                txtItemQty.Text = "";
                txtUnitPrice.Text = "";
                txtAmount.Text = "";

                LoadInvoice(InvID);
            }
            else
            {
                MessageBox.Show("Error : " + rtn);
                return;
            }

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int InvID = 0;
            int ItemID = 0;
            var rtn = "";

            InvID = Convert.ToInt32(lblInvID.Text.ToString());
            ItemID = Convert.ToInt32(lblItemsID.Text.ToString());

            rtn = DBUtil.DelInvoiceItem(ItemID);

            if (rtn == "OK")
            {
                lblItemsID.Text = "0";
                txtSearchItems.Text = "";
                ItemsList.SelectedIndex = -1;
                txtItemQty.Text = "";
                txtUnitPrice.Text = "";
                txtAmount.Text = "";

                LoadInvoice(InvID);
            }
            else
            {
                MessageBox.Show("Error : " + rtn);
                return;
            }
        }

        private void EnableEdit()
        {
            pnlEdit.Visible = false;
            pnlSave.Visible = true;

            txtInvNo.ReadOnly = true;

            if (Convert.ToInt32("0" + lblInvID.Text.ToString().Trim()) == 0)
            {
                DtInvoice.Enabled = true;
            }

            ChkPartial.Enabled = true;

            panelMethod.Enabled = true;

            txtRefNo.ReadOnly = false;

            txtIIDNo.ReadOnly = false;

            if (Convert.ToInt32(lblInvID.Text.ToString().Trim()) != 0)
            {
                txtSearchHBLNo.ReadOnly = true;
                txtHBLNo.Visible = true;
                HBLNoList.Visible = false;
            }
            else
            {
                txtSearchHBLNo.ReadOnly = false;
                txtHBLNo.Visible = false;
                HBLNoList.Visible = true;
            }

            txtSearchConsignee.ReadOnly = false;
            txtConsignee.Visible = false;
            ConsigneeList.Visible = true;

            txtSCNNo.ReadOnly = true;

            txtVessel.ReadOnly = true;

            txtLoadPort.ReadOnly = true;

            txtUnloadPort.ReadOnly = true;

            //txtRemark.ReadOnly = false;

            //txtDesc.ReadOnly = true;

            txtStorageDays.ReadOnly = true;

            txtUnstuffDate.ReadOnly = true;

            txtOBL.ReadOnly = true;

            txtVoyage.ReadOnly = true;

            //txtEtd.ReadOnly = true;

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

            txtRefNo.ReadOnly = true;

            txtIIDNo.ReadOnly = true;

            txtInvNo.ReadOnly = true;

            DtInvoice.Enabled = false;

            txtSearchHBLNo.ReadOnly = true;
            txtSearchConsignee.Visible = true;
            txtHBLNo.Visible = true;
            HBLNoList.Visible = false;

            txtSearchConsignee.ReadOnly = true;
            txtSearchConsignee.Visible = true;
            ConsigneeList.Visible = false;
            txtConsignee.Visible = true;

            txtSCNNo.ReadOnly = true;

            txtVessel.ReadOnly = true;

            txtLoadPort.ReadOnly = true;

            txtUnloadPort.ReadOnly = true;

            //txtRemark.ReadOnly = true;

            //txtDesc.ReadOnly = true;

            txtStorageDays.ReadOnly = true;

            txtUnstuffDate.ReadOnly = true;

            txtOBL.ReadOnly = true;

            txtVoyage.ReadOnly = true;

            //txtEtd.ReadOnly = true;

            txtEta.ReadOnly = true;

            txtQty.ReadOnly = true;

            txtWeight.ReadOnly = true;

            txtVolume.ReadOnly = true;

            txtSearchItems.ReadOnly = false;

            txtItemQty.ReadOnly = false;

            txtUnitPrice.ReadOnly = false;

            txtAmount.ReadOnly = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            int InvID = 0;
            string Amount = "";

            InvID = Convert.ToInt32(lblInvID.Text.Trim());
            Amount = lblAmountInWords.Text.ToString().Trim();

            InvoiceSht InvoiceSheetDlg = new InvoiceSht(InvID, Amount, UserID);
            InvoiceSheetDlg.ShowDialog();
            LoadInvoice(InvID);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int InvoiceID = 0;
            var rtn = "";

            InvoiceID = Convert.ToInt32(lblInvID.Text.ToString().Trim());

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this Invoice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                rtn = DBUtil.DelInvoice(InvoiceID);

                if (rtn != "ERROR")
                {
                    rtn = DBUtil.DelAllInvoiceItem(InvoiceID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("System Unable To Delete Invoice : " + txtInvNo.Text.ToString(), "Error");
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void ChkPartial_MouseClick(object sender, MouseEventArgs e)
        {
            int InvID = 0;
            InvID = Convert.ToInt32(lblInvID.Text.ToString().Trim());

            if (ChkPartial.Checked)
            {
                txtQty.ResetText();
                txtQty.ReadOnly = false;

                txtWeight.ResetText();
                txtWeight.ReadOnly = false;

                txtVolume.ResetText();
                txtVolume.ReadOnly = false;
            }
            else
            {

                if (InvID != 0)
                {
                    LoadInvoice(InvID);
                }
                else
                {
                    txtQty.Text = lblBalQty.Text.ToString().Trim();
                    txtQty.ReadOnly = true;

                    txtWeight.Text = lblBalWeight.Text.ToString().Trim();
                    txtWeight.ReadOnly = true;

                    txtVolume.Text = lblBalVolume.Text.ToString().Trim();
                    txtVolume.ReadOnly = true;
                }
            }
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            CustAED CustAED = new CustAED(1,0, UserID);
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
            catch(Exception)
            {
                MessageBox.Show("Issue Port Key of App Settings in App Config is missing.","Error");
                rtn = "-";
            }

            return rtn;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtInvoice_ValueChanged(object sender, EventArgs e)
        {
            int InvoiceID = 0;
            var IssueDate = "";
            var UnstuffDate = "";
            int StorageDays = 0;

            InvoiceID = Convert.ToInt32(lblInvID.Text.ToString().Trim());

            if (InvoiceID == 0 && HBLNoList.SelectedIndex > -1)
            {
                IssueDate = DtInvoice.Value.ToString("yyyy/MM/dd");
                UnstuffDate = Convert.ToDateTime(txtUnstuffDate.Text).ToString("yyyy/MM/dd");
                StorageDays = DBUtil.GetStorageDays(UnstuffDate, IssueDate);
                txtStorageDays.Text = StorageDays.ToString();
            }
        }
    }
}
