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
    public partial class CPAED : Form
    {
        private int UserID = 0;

        public CPAED(int LoginID, int CPID)
        {
            InitializeComponent();

            UserID = LoginID;

            AdvSearchCustomer("~!");
            AdvSearchMtPoint("~!");
            AdvSearchSCN("~!");
            AdvSearchPort("~!");
            AdvSearchSize("~!");
            AdvSearchOperator("~!");
            AdvSearchTranshipmentHBL("~!");
            AdvSearchCFS("~!");
            LoadCPItems(CPID);

            dgvCP.Columns[0].Name = "id";
            dgvCP.Columns[0].HeaderText = "ID";
            dgvCP.Columns[0].Visible = false;

            dgvCP.Columns[1].Name = "cp_id";
            dgvCP.Columns[1].HeaderText = "CP ID";
            dgvCP.Columns[1].Visible = false;

            dgvCP.Columns[2].Name = "cfs_id";
            dgvCP.Columns[2].HeaderText = "CFS ID";
            dgvCP.Columns[2].Visible = false;

            dgvCP.Columns[3].Name = "cfs_no";
            dgvCP.Columns[3].HeaderText = "CFS No";

            dgvCP.Columns[4].Name = "marking";
            dgvCP.Columns[4].HeaderText = "Marking";

            dgvCP.Columns[5].Name = "weight";
            dgvCP.Columns[5].HeaderText = "Weight";

            dgvCP.Columns[6].Name = "volume";
            dgvCP.Columns[6].HeaderText = "Volume";

            dgvCP.Columns[7].Name = "qty";
            dgvCP.Columns[7].HeaderText = "Quantity";

            dgvCP.Columns[8].Name = "unit";
            dgvCP.Columns[8].HeaderText = "Unit";

            dgvCP.Columns[9].Name = "transhipment";
            dgvCP.Columns[9].HeaderText = "Transhipment";
            dgvCP.Columns[9].Visible = false;

            dgvCP.Columns[10].Name = "total_qty";
            dgvCP.Columns[10].HeaderText = "Total Quantity";
            dgvCP.Columns[10].Visible = false;

            dgvCP.Columns[11].Name = "total_volume";
            dgvCP.Columns[11].HeaderText = "Total Volume";
            dgvCP.Columns[11].Visible = false;

            dgvCP.Columns[12].Name = "total_goods_weight";
            dgvCP.Columns[12].HeaderText = "Total Goods Weight";
            dgvCP.Columns[12].Visible = false;

            dgvCP.Columns[13].Name = "cont_weight";
            dgvCP.Columns[13].HeaderText = "Container Weight";
            dgvCP.Columns[13].Visible = false;

            dgvCP.Columns[14].Name = "total_weight";
            dgvCP.Columns[14].HeaderText = "Total Weight";
            dgvCP.Columns[14].Visible = false;


            if (CPID > 0)
            {
                lblCPID.Text = CPID.ToString();
                LoadCP(CPID);
                DisableEdit();
            }
            else
            {
                lblCPID.Text = "0";
                EnableEdit();
            }
        }

        public void AdvSearchCustomer(string SearchBy)
        {
            DataTable Customer = new DataTable();
            Customer = DBUtil.spMst_AdvSearchCustomer(SearchBy);

            CustList.DataSource = Customer;
            CustList.DisplayMember = "name";
            CustList.ValueMember = "id";
        }

        public void AdvSearchMtPoint(string SearchBy)
        {
            DataTable Customer = new DataTable();
            Customer = DBUtil.spMst_AdvSearchCustomer(SearchBy);

            MtPointList.DataSource = Customer;
            MtPointList.DisplayMember = "name";
            MtPointList.ValueMember = "id";
        }

        public void AdvSearchSCN(string SearchBy)
        {
            DataTable SCN = new DataTable();
            SCN = DBUtil.spMst_AdvSearchSCN(SearchBy);

            SCNList.DataSource = SCN;
            SCNList.DisplayMember = "scn";
            SCNList.ValueMember = "id";
        }

        private void AdvSearchPort(string SearchBy)
        {
            DataTable Port = new DataTable();
            Port = DBUtil.spMst_AdvSearchPort(SearchBy);

            DestList.DataSource = Port;
            DestList.DisplayMember = "name";
            DestList.ValueMember = "id";
        }

        private void AdvSearchSize(string SearchBy)
        {
            DataTable Size = new DataTable();
            Size = DBUtil.spMst_AdvSearchSize(SearchBy);

            SizeList.DataSource = Size;
            SizeList.DisplayMember = "name";
            SizeList.ValueMember = "id";
        }

        private void AdvSearchOperator(string SearchBy)
        {
            DataTable Operator = new DataTable();
            Operator = DBUtil.spMst_AdvSearchOperator(SearchBy);

            OprList.DataSource = Operator;
            OprList.DisplayMember = "code";
            OprList.ValueMember = "id";
        }

        private void AdvSearchTranshipmentHBL(string SearchBy)
        {
            DataTable HBL = new DataTable();
            HBL = DBUtil.AdvSearchTranshipmentHBL(SearchBy);

            HBLList.DataSource = HBL;
            HBLList.DisplayMember = "hbl_no";
            HBLList.ValueMember = "id";

            if (HBL.Rows.Count == 0)
            {
                HBLList.SelectedIndex = -1;
                lblHBLMark.Text = "";
                lblHBLWeight.Text = "";
                lblHBLVolume.Text = "";
                lblHBLQty.Text = "";
            }
        }

        private void AdvSearchCFS(string SearchBy)
        {
            DataTable CFS = new DataTable();
            CFS = DBUtil.AdvSearchCFS(SearchBy);

            CFSList.DataSource = CFS;
            CFSList.DisplayMember = "cfs_no";
            CFSList.ValueMember = "id";

            if (CFS.Rows.Count == 0)
            {
                lblCFSMark.Text = "";
                lblCFSWeight.Text = "";
                lblCFSVolume.Text = "";
                lblCFSQty.Text = "";
            }
        }

        private void LoadVoyageDetails(string ID)
        {
            DataTable Voyage = new DataTable();
            Voyage = DBUtil.LoadVoyageDetails(ID);

            txtVessel.Text = Voyage.Rows[0]["vid"].ToString().Trim() + " : " + Voyage.Rows[0]["name"].ToString().Trim();
            txtVoyage.Text = Voyage.Rows[0]["voyage_no"].ToString().Trim();
        }

        private void LoadHBL(int HBLID)
        {
            DataTable HBL = new DataTable();
            HBL = DBUtil.LoadHBL(HBLID);

            lblHBLMark.Text = HBL.Rows[0]["marking"].ToString().Trim();
            lblHBLWeight.Text = HBL.Rows[0]["weight"].ToString().Trim();
            lblHBLVolume.Text = HBL.Rows[0]["volume"].ToString().Trim();
            lblHBLQty.Text = HBL.Rows[0]["goods_qty"].ToString().Trim();

        }

        private void LoadCFS(int CFSID)
        {
            DataTable CFS = new DataTable();
            CFS = DBUtil.LoadCFS(CFSID);

            lblCFSMark.Text = CFS.Rows[0]["marking"].ToString().Trim();
            lblCFSWeight.Text = CFS.Rows[0]["weight"].ToString().Trim();
            lblCFSVolume.Text = CFS.Rows[0]["volume"].ToString().Trim();
            lblCFSQty.Text = CFS.Rows[0]["qty"].ToString().Trim();

        }

        private void LoadCPItems(int CPID)
        {
            DataTable Items = new DataTable();
            Items = DBUtil.LoadCPItems(CPID);

            if (Items.Rows.Count > 0)
            {
                txtTotalGoodsWeight.Text = Items.Rows[0]["total_goods_weight"].ToString().Trim();
                txtContWeight.Text = Items.Rows[0]["cont_weight"].ToString().Trim();
                txtTotalWeight.Text = Items.Rows[0]["total_weight"].ToString().Trim();
                txtTotalVolume.Text = Items.Rows[0]["total_volume"].ToString().Trim();
                txtTotalQty.Text = Items.Rows[0]["total_qty"].ToString().Trim();
            }
            else
            {
                txtTotalGoodsWeight.Text = "0";
                txtContWeight.Text = "0";
                txtTotalWeight.Text = "0";
                txtTotalVolume.Text = "0";
                txtTotalQty.Text = "0";
            }
           


            dgvCP.DataSource = Items;
        }


        public void LoadCP(int CPID)
        {
            DataTable CP = new DataTable();
            CP = DBUtil.LoadCP(CPID);

            if (CP.Rows.Count > 0)
            {
                lblCPID.Text = CP.Rows[0]["id"].ToString().Trim();
                txtSearchCust.Text = CP.Rows[0]["cust"].ToString().Trim();
                txtCust.Text = CP.Rows[0]["cust"].ToString().Trim();
                txtSearchSCN.Text = CP.Rows[0]["scn"].ToString().Trim();
                txtSCN.Text = CP.Rows[0]["scn"].ToString().Trim();
                dtEta.Value = ((DateTime)CP.Rows[0]["eta"]);
                dtClose.Value = ((DateTime)CP.Rows[0]["closing_time"]);
                txtBkRef.Text = CP.Rows[0]["booking_ref"].ToString().Trim();
                txtSearchDest.Text = CP.Rows[0]["dest"].ToString().Trim();
                txtDest.Text = CP.Rows[0]["dest"].ToString().Trim();
                txtContNo.Text = CP.Rows[0]["container_no"].ToString().Trim();
                txtSearchSize.Text = CP.Rows[0]["size"].ToString().Trim();
                txtSize.Text = CP.Rows[0]["size"].ToString().Trim();
                txtLocation.Text = CP.Rows[0]["location"].ToString().Trim();
                txtSearchOpr.Text = CP.Rows[0]["opr"].ToString().Trim();
                txtOpr.Text = CP.Rows[0]["opr"].ToString().Trim();
                txtSealNo.Text = CP.Rows[0]["seal_no"].ToString().Trim();
                txtK8No.Text = CP.Rows[0]["k8_no"].ToString().Trim();
                dtPacked.Value = ((DateTime)CP.Rows[0]["pack_date"]);
                txtCargoPkdBy.Text = CP.Rows[0]["cargo_pack_by"].ToString().Trim();
                txtTallyPkdBy.Text = CP.Rows[0]["tally_pack_by"].ToString().Trim();
                txtChk.Text = CP.Rows[0]["check_by"].ToString().Trim();
                txtSearchMtPoint.Text = CP.Rows[0]["mt_point"].ToString().Trim();
                txtMtPoint.Text = CP.Rows[0]["mt_point"].ToString().Trim();
                ChkIssueInvoice.Checked = Convert.ToInt32(CP.Rows[0]["issue_invoice"].ToString().Trim()) > 0 ? true : false;

                if (Convert.ToInt32(CP.Rows[0]["pkg_type"]) == 1)
                {
                    rbConsole.Checked = true;
                }
                else if (Convert.ToInt32(CP.Rows[0]["pkg_type"]) == 2)
                {
                    rbFull.Checked = true;
                }
                else if (Convert.ToInt32(CP.Rows[0]["pkg_type"]) == 3)
                {
                    rbBondedTruck.Checked = true;
                }
                else
                {
                    rbDirect.Checked = true;
                }

                if (Convert.ToInt32(CP.Rows[0]["vgm"]) == 1)
                {
                    rbVGMYes.Checked = true;
                }
                else
                {
                    rbVGMNo.Checked = true;
                }

                if (Convert.ToInt32(CP.Rows[0]["gang"]) == 1)
                {
                    rbGangYes.Checked = true;
                }
                else
                {
                    rbGangNo.Checked = true;
                }

                if (Convert.ToInt32(CP.Rows[0]["terminal"]) == 1)
                {
                    rbTermCT1.Checked = true;
                }
                else if (Convert.ToInt32(CP.Rows[0]["terminal"]) == 2)
                {
                    rbTermCT2.Checked = true;
                }
                else if (Convert.ToInt32(CP.Rows[0]["terminal"]) == 3)
                {
                    rbTermKMT.Checked = true;
                }
                else
                {
                    rbTermCalling.Checked = true;
                }

                if (Convert.ToInt32(CP.Rows[0]["ledger_acc"]) == 1)
                {
                    rbLedWP.Checked = true;
                }
                else if (Convert.ToInt32(CP.Rows[0]["ledger_acc"]) == 2)
                {
                    rbLedNB.Checked = true;
                }
                else if (Convert.ToInt32(CP.Rows[0]["ledger_acc"]) == 3)
                {
                    rbLedHQ.Checked = true;
                }
                else
                {
                    rbLedNP.Checked = true;
                }

                if (Convert.ToInt32(CP.Rows[0]["ship_type"]) == 1)
                {
                    rbShipTypeFCL.Checked = true;
                }
                else if (Convert.ToInt32(CP.Rows[0]["ship_type"]) == 2)
                {
                    rbShipTypeCoLoad.Checked = true;
                }
                else
                {
                    rbShipTypeLCL.Checked = true;
                }

            }
        }

        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchCust.Text.ToString().Trim();

            if (SearchBy.Length > 0) AdvSearchCustomer(SearchBy); else AdvSearchCustomer("~!");
        }

        private void txtSearchMtPoint_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchMtPoint.Text.ToString().Trim();

            if (SearchBy.Length > 0) AdvSearchMtPoint(SearchBy); else AdvSearchMtPoint("~!");
        }

        private void txtSearchSCN_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchSCN.Text.ToString().Trim();

            if (SearchBy.Length > 0) AdvSearchSCN(SearchBy); else AdvSearchSCN("~!");
        }

        private void txtSearchDest_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchDest.Text.ToString().Trim();

            if (SearchBy.Length > 0) AdvSearchPort(SearchBy); else AdvSearchPort("~!");
        }

        private void txtSearchSize_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchSize.Text.ToString().Trim();

            if (SearchBy.Length > 0) AdvSearchSize(SearchBy); else AdvSearchSize("~!");
        }

        private void txtSearchOpr_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchOpr.Text.ToString().Trim();

            if (SearchBy.Length > 0) AdvSearchOperator(SearchBy); else AdvSearchOperator("!~");
        }

        private void txtSearchHBL_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchHBL.Text.ToString().Trim();

            if (SearchBy.Length > 0) AdvSearchTranshipmentHBL(SearchBy); else AdvSearchTranshipmentHBL("!");
        }

        private void txtSearchCFS_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchCFS.Text.ToString().Trim();

            if (SearchBy.Length > 0) AdvSearchCFS(SearchBy); else AdvSearchCFS("~!");
        }

        private void SCNList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ID = "";

            if (SCNList.SelectedIndex > -1)
            {
                ID = SCNList.SelectedValue.ToString().Trim();
                LoadVoyageDetails(ID);
            }
            else
            {
                txtVoyage.Text = "";
                txtVessel.Text = "";
            }
        }


        private void HBLList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int HBLID = 0;

            if (HBLList.SelectedIndex > -1)
            {
                HBLID = Convert.ToInt32(HBLList.SelectedValue.ToString());
                LoadHBL(HBLID);
            }
        }

        private void CFSList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CFSID = 0;

            if (CFSList.SelectedIndex > -1)
            {
                CFSID = Convert.ToInt32(CFSList.SelectedValue.ToString());
                LoadCFS(CFSID);
            }
        }


        public void DisableEdit()
        {
            pnlEdit.Visible = true;
            pnlSave.Visible = false;

            rbDirect.Enabled = false;
            rbConsole.Enabled = false;
            rbFull.Enabled = false;
            rbBondedTruck.Enabled = false;

            txtSearchCust.ReadOnly = true;
            txtSearchCust.Visible = true;
            CustList.Visible = false;
            txtCust.ReadOnly = true;
            txtCust.Visible = true;

            txtSearchSCN.ReadOnly = true;
            txtSearchSCN.Visible = true;
            SCNList.Visible = false;
            txtSCN.ReadOnly = true;
            txtSCN.Visible = true;

            txtVessel.Visible = true;
            txtVessel.ReadOnly = true;

            txtVoyage.Visible = true;
            txtVoyage.ReadOnly = true;

            dtEta.Enabled = false;

            dtClose.Enabled = false;

            txtBkRef.Visible = true;
            txtBkRef.ReadOnly = true;

            txtSearchDest.ReadOnly = true;
            txtSearchDest.Visible = true;
            DestList.Visible = false;
            txtDest.ReadOnly = true;
            txtDest.Visible = true;

            txtContNo.Visible = true;
            txtContNo.ReadOnly = true;

            txtSearchSize.ReadOnly = true;
            txtSearchSize.Visible = true;
            SizeList.Visible = false;
            txtSize.ReadOnly = true;
            txtSize.Visible = true;

            txtLocation.ReadOnly = true;
            txtLocation.Visible = true;

            txtSearchOpr.ReadOnly = true;
            txtSearchOpr.Visible = true;
            OprList.Visible = false;
            txtOpr.ReadOnly = true;
            txtOpr.Visible = true;

            rbVGMYes.Enabled = false;
            rbVGMNo.Enabled = false;

            rbTermCT1.Enabled = false;
            rbTermCT2.Enabled = false;
            rbTermKMT.Enabled = false;
            rbTermCalling.Enabled = false;

            txtSealNo.ReadOnly = true;
            txtSealNo.Visible = true;

            txtK8No.ReadOnly = true;
            txtK8No.Visible = true;

            rbLedNP.Enabled = false;
            rbLedWP.Enabled = false;
            rbLedNB.Enabled = false;

            dtPacked.Enabled = false;

            txtCargoPkdBy.ReadOnly = true;
            txtCargoPkdBy.Visible = true;

            txtTallyPkdBy.ReadOnly = true;
            txtTallyPkdBy.Visible = true;

            txtChk.ReadOnly = true;
            txtChk.Visible = true;

            rbGangYes.Enabled = false;
            rbGangNo.Enabled = false;

            txtSearchMtPoint.ReadOnly = true;
            txtSearchMtPoint.Visible = false;
            MtPointList.Visible = false;
            MtPointList.Enabled = false;
            txtMtPoint.Visible = true;
            txtMtPoint.ReadOnly = true;

            ChkIssueInvoice.Enabled = false;

            pnlShipType.Enabled = false;
        }

        public void EnableEdit()
        {
            pnlEdit.Visible = false;
            pnlSave.Visible = true;

            rbDirect.Enabled = true;
            rbConsole.Enabled = true;
            rbFull.Enabled = true;
            rbBondedTruck.Enabled = true;

            txtSearchCust.ReadOnly = false;
            txtSearchCust.Visible = true;
            CustList.Visible = true;
            txtCust.ReadOnly = true;
            txtCust.Visible = false;

            txtSearchSCN.ReadOnly = false;
            txtSearchSCN.Visible = true;
            SCNList.Visible = true;
            txtSCN.ReadOnly = true;
            txtSCN.Visible = false;

            txtVessel.Visible = true;
            txtVessel.ReadOnly = false;

            txtVoyage.Visible = true;
            txtVoyage.ReadOnly = false;

            dtEta.Enabled = true;

            dtClose.Enabled = true;

            txtBkRef.Visible = true;
            txtBkRef.ReadOnly = false;

            txtSearchDest.ReadOnly = false;
            txtSearchDest.Visible = true;
            DestList.Visible = true;
            txtDest.ReadOnly = true;
            txtDest.Visible = false;

            txtContNo.Visible = true;
            txtContNo.ReadOnly = false;

            txtSearchSize.ReadOnly = false;
            txtSearchSize.Visible = true;
            SizeList.Visible = true;
            txtSize.ReadOnly = true;
            txtSize.Visible = false;

            txtLocation.ReadOnly = false;
            txtLocation.Visible = true;

            txtSearchOpr.ReadOnly = false;
            txtSearchOpr.Visible = true;
            OprList.Visible = true;
            txtOpr.ReadOnly = true;
            txtOpr.Visible = false;

            rbVGMYes.Enabled = true;
            rbVGMNo.Enabled = true;

            rbTermCT1.Enabled = true;
            rbTermCT2.Enabled = true;
            rbTermKMT.Enabled = true;
            rbTermCalling.Enabled = true;

            txtSealNo.ReadOnly = false;
            txtSealNo.Visible = true;

            txtK8No.ReadOnly = false;
            txtK8No.Visible = true;

            rbLedNP.Enabled = true;
            rbLedWP.Enabled = true;
            rbLedNB.Enabled = true;

            dtPacked.Enabled = true;

            txtCargoPkdBy.ReadOnly = false;
            txtCargoPkdBy.Visible = true;

            txtTallyPkdBy.ReadOnly = false;
            txtTallyPkdBy.Visible = true;

            txtChk.ReadOnly = false;
            txtChk.Visible = true;

            rbGangYes.Enabled = true;
            rbGangNo.Enabled = true;

            txtSearchMtPoint.ReadOnly = false;
            txtSearchMtPoint.Visible = true;
            MtPointList.Visible = true;
            MtPointList.Enabled = true;
            txtMtPoint.Visible = false;
            txtMtPoint.ReadOnly = true;

            ChkIssueInvoice.Enabled = true;

            pnlShipType.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int CPID = 0;
            int PkgType = 0;
            int CustID = 0;
            int VoyageID = 0;
            DateTime Eta = new DateTime();
            DateTime ClosingTime = new DateTime();
            string BookingRef = "";
            int DestID = 0;
            string ContainerNo = "";
            int SizeID = 0;
            string Location = "";
            int OprID = 0;
            int Vgm = 0;
            int Gang = 0;
            int Terminal = 0;
            string SealNo = "";
            string K8No = "";
            int MtPointID = 0;
            int LedgerAcc = 0;
            DateTime PackDate = new DateTime();
            string CargoPackedBy = "";
            string TallyPackedBy = "";
            string CheckBy = "";
            int IssueInvoice = 0;
            int ShipType = 0;
            int Uuser = 0;
            int rtn = 0;

            CPID = Convert.ToInt32("0" +lblCPID.Text.ToString().Trim());
            PkgType = rbConsole.Checked ? 1 : rbFull.Checked ? 2 : rbBondedTruck.Checked ? 3 : 0;
            Eta = Convert.ToDateTime(dtEta.Value.ToString("yyyy-MM-dd HH:mm:ss tt"));
            ClosingTime = Convert.ToDateTime(dtClose.Value.ToString("yyyy-MM-dd HH:mm:ss tt"));
            BookingRef = txtBkRef.Text.ToString().Trim();
            ContainerNo = txtContNo.Text.ToString().Trim();
            Location = txtLocation.Text.ToString().Trim();
            Vgm = rbVGMYes.Checked ? 1 : 0;
            Gang = rbGangYes.Checked ? 1 : 0;
            SealNo = txtSealNo.Text.ToString().Trim();
            K8No = txtK8No.Text.ToString().Trim();
            LedgerAcc = rbLedNP.Checked ? 0 : rbLedWP.Checked ? 1 : rbLedNB.Checked ? 2 : 3;
            PackDate = Convert.ToDateTime(dtPacked.Value.ToString("yyyy-MM-dd"));
            CargoPackedBy = txtCargoPkdBy.Text.ToString().Trim();
            TallyPackedBy = txtTallyPkdBy.Text.ToString().Trim();
            CheckBy = txtChk.Text.ToString().ToString();
            IssueInvoice = ChkIssueInvoice.Checked == true ? 1 : 0;
            Uuser = UserID;

            if (rbTermCT1.Checked)
            {
                Terminal = 1;
            }
            else if (rbTermCT2.Checked)
            {
                Terminal = 2;
            }
            else if (rbTermKMT.Checked)
            {
                Terminal = 3;
            }
            else
            {
                Terminal = 4;
            }

            if (CustList.SelectedIndex == -1)
            {
                MessageBox.Show("Customer is required");
                return;
            }
            else
            {
                CustID = Convert.ToInt32(CustList.SelectedValue);
            }

            if (SCNList.SelectedIndex == -1)
            {
                MessageBox.Show("SCN is required");
                return;
            }
            else
            {
                VoyageID = Convert.ToInt32(SCNList.SelectedValue);
            }

            if (string.IsNullOrEmpty(BookingRef))
            {
                MessageBox.Show("Booking Ref is required");
                return;
            }

            if (DestList.SelectedIndex == -1)
            {
                MessageBox.Show("Destination is required");
                return;
            }
            else
            {
                DestID = Convert.ToInt32(DestList.SelectedValue);
            }

            if (string.IsNullOrEmpty(ContainerNo))
            {
                MessageBox.Show("Container No is required");
                return;
            }

            if (SizeList.SelectedIndex == -1)
            {
                MessageBox.Show("Size is required");
                return;
            }
            else
            {
                SizeID = Convert.ToInt32(SizeList.SelectedValue);
            }

            if (OprList.SelectedIndex == -1)
            {
                MessageBox.Show("Operator is required");
                return;
            }
            else
            {
                OprID = Convert.ToInt32(OprList.SelectedValue);
            }

            if (MtPointList.SelectedIndex == -1)
            {
                MessageBox.Show("Mt Pick Up Point is required");
                return;
            }
            else
            {
                MtPointID = Convert.ToInt32(MtPointList.SelectedValue);
            }

            if (string.IsNullOrEmpty(SealNo))
            {
                MessageBox.Show("Seal No is required");
                return;
            }

            //if (string.IsNullOrEmpty(CargoPackedBy))
            //{
            //    MessageBox.Show("Cargo Packed By is required");
            //    return;
            //}

            //if (string.IsNullOrEmpty(TallyPackedBy))
            //{
            //    MessageBox.Show("Tally & Packed By is required");
            //    return;
            //}

            //if (string.IsNullOrEmpty(CheckBy))
            //{
            //    MessageBox.Show("Check By is required");
            //    return;
            //}

            if (rbShipTypeFCL.Checked == true)
            {
                ShipType = 1;
            }
            else if (rbShipTypeCoLoad.Checked == true)
            {
                ShipType = 2;
            }
            else
            {
                ShipType = 0;
            }



            rtn = DBUtil.UpsertCP(CPID, PkgType, CustID, VoyageID, Eta, ClosingTime, BookingRef, DestID, ContainerNo, SizeID, ShipType, Location, OprID, Vgm, Gang, Terminal,
                                  SealNo, K8No, MtPointID, LedgerAcc, PackDate, CargoPackedBy, TallyPackedBy, CheckBy, IssueInvoice, Uuser);

            if (rtn != -1)
            {
                LoadCP(rtn);
                DisableEdit();
            }
            else
            {
                MessageBox.Show("ERROR : Fail to save");
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int CPID = Convert.ToInt32("0" + lblCPID.Text.ToString().Trim());

            if (CPID == 0) this.Close(); else DisableEdit();
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
            int CPID = 0;
            var rtn = "";

            CPID = Convert.ToInt32("0" + lblCPID.Text.ToString().Trim());

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this Container Packging List?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)
            {
                rtn = DBUtil.DelCP(CPID);

                if (rtn != "ERROR") this.Close(); else MessageBox.Show("System Unable To Delete Container Packging List : " + txtContNo.Text.ToString(), "Error"); return;
            }
            else
            {
                return;
            }
        }

        private void btnHBLAdd_Click(object sender, EventArgs e)
        {
            int CPID = 0;
            int CFSID = 0;
            int ItemID = 0;
            var rtn = "";

            CPID = Convert.ToInt32("0" + lblCPID.Text.ToString().Trim());
            ItemID = Convert.ToInt32("0" + lblHBLID.Text.ToString().Trim());

            if (CPID == 0)
            {
                MessageBox.Show("Container Packaging Details is required");
                return;
            }

            if (HBLList.SelectedIndex == -1)
            {
                MessageBox.Show("HBL No is required");
                return;
            }

            CFSID = Convert.ToInt32(HBLList.SelectedValue.ToString().Trim());

            rtn = DBUtil.UpsertCPItems(ItemID, CPID, CFSID, 1, UserID);

            if (rtn != "OK") MessageBox.Show(rtn);

            lblHBLID.Text = "0";
            txtSearchHBL.Text = "";
            AdvSearchTranshipmentHBL("~!");
            LoadCPItems(CPID);
        }

        private void btnCFSAdd_Click(object sender, EventArgs e)
        {
            int CPID = 0;
            int CFSID = 0;
            int ItemID = 0;
            var rtn = "";

            CPID = Convert.ToInt32("0" + lblCPID.Text.ToString().Trim());
            ItemID = Convert.ToInt32("0" + lblCFSID.Text.ToString().Trim());

            if (CPID == 0)
            {
                MessageBox.Show("Container Packaging Details is required");
                return;
            }

            if (CFSList.SelectedIndex == -1)
            {
                MessageBox.Show("CFS No is required");
                return;
            }

            CFSID = Convert.ToInt32(CFSList.SelectedValue.ToString().Trim());

            rtn = DBUtil.UpsertCPItems(ItemID, CPID, CFSID, 0, UserID);

            if (rtn != "OK") MessageBox.Show(rtn);

            lblCFSID.Text = "0";
            txtSearchCFS.Text = "";
            AdvSearchCFS("~!");
            LoadCPItems(CPID);
        }

        private void dgvCP_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ItemID = 0;
            int Transhipment = 0;
            string CFSNo = "";

            ItemID = Convert.ToInt32(dgvCP.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            Transhipment = Convert.ToInt32(dgvCP.Rows[e.RowIndex].Cells[9].Value.ToString().Trim());
            CFSNo = dgvCP.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();

            if (Transhipment == 0)
            {
                AdvSearchCFS(CFSNo);
                txtSearchCFS.Text = CFSNo;
                lblCFSID.Text = ItemID.ToString();
            }
            else
            {
                AdvSearchTranshipmentHBL(CFSNo);
                txtSearchHBL.Text = CFSNo;
                lblHBLID.Text = ItemID.ToString();
            }
        }

        private void btnHBLDelete_Click(object sender, EventArgs e)
        {
            int CPID = 0;
            int ItemID = 0;
            var HBLNo = "";
            var rtn = "";

            CPID = Convert.ToInt32("0" + lblCPID.Text.ToString().Trim());
            ItemID = Convert.ToInt32("0" + lblHBLID.Text.ToString().Trim());
            HBLNo = txtSearchHBL.Text.ToString().Trim();

            if (CPID == 0)
            {
                MessageBox.Show("Container Packging Details is required");
                return;
            }

            if (ItemID == 0)
            {
                MessageBox.Show("CFS No is required");
                return;
            }

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this Item from Container Packing List?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)
            {
                rtn = DBUtil.DelCPItems(ItemID);


                if (rtn == "OK")
                {
                    LoadCPItems(CPID);
                    lblHBLID.Text = "0";
                    txtSearchHBL.Text = "";
                    AdvSearchTranshipmentHBL("~!");
                }
                else
                {
                    MessageBox.Show("System Unable To Delete Item : " + HBLNo + " From Container Packging List", "Error");
                    lblHBLID.Text = "0";
                    txtSearchHBL.Text = "";
                    AdvSearchTranshipmentHBL("~!");
                    return;
                } 
            }
            else
            {
                LoadCPItems(CPID);
                lblHBLID.Text = "0";
                txtSearchHBL.Text = "";
                AdvSearchTranshipmentHBL("~!");
                return;
            }
        }

        private void btnCFSDelete_Click(object sender, EventArgs e)
        {
            int CPID = 0;
            int ItemID = 0;
            var CFSNo = "";
            var rtn = "";

            CPID = Convert.ToInt32("0" + lblCPID.Text.ToString().Trim());
            ItemID = Convert.ToInt32("0" + lblCFSID.Text.ToString().Trim());
            CFSNo = txtSearchCFS.Text.ToString().Trim();

            if (CPID == 0)
            {
                MessageBox.Show("Container Packging Details is required");
                return;
            }

            if (ItemID == 0)
            {
                MessageBox.Show("CFS No is required");
                return;
            }

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this Item from Container Packing List?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)
            {
                rtn = DBUtil.DelCPItems(ItemID);
                

                lblCFSID.Text = "0";
                txtSearchCFS.Text = "";
                AdvSearchCFS("~!");

                if (rtn == "OK")
                {
                    LoadCPItems(CPID);
                    lblCFSID.Text = "0";
                    txtSearchCFS.Text = "";
                    AdvSearchCFS("~!");
                }
                else
                {
                    MessageBox.Show("System Unable To Delete Item : " + CFSNo + " From Container Packging List", "Error");
                    LoadCPItems(CPID);
                    lblCFSID.Text = "0";
                    txtSearchCFS.Text = "";
                    AdvSearchCFS("~!");
                    return;
                } 
            }
            else
            {
                LoadCPItems(CPID);
                lblCFSID.Text = "0";
                txtSearchCFS.Text = "";
                AdvSearchCFS("~!");
                return;
            }
        }

        private void btnAddSCN_Click(object sender, EventArgs e)
        {
            VoyageAED VoyageAED = new VoyageAED(1, 0, UserID);
            VoyageAED.ShowDialog();
        }

        private void btnAddPort_Click(object sender, EventArgs e)
        {
            PortAED PortAED = new PortAED(1, 0, UserID);
            PortAED.ShowDialog();
        }

        private void btnAddOperator_Click(object sender, EventArgs e)
        {
            OperatorAED OperatorAED = new OperatorAED(0, UserID);
            OperatorAED.ShowDialog();

        }

        private void btnAddMT_Click(object sender, EventArgs e)
        {
            CustAED CustAED = new CustAED(1, 0, UserID);
            CustAED.ShowDialog();
        }

        private void btnPrintCP_Click(object sender, EventArgs e)
        {
            int CPID = 0;
            CPID = Convert.ToInt32(lblCPID.Text.ToString().Trim());

            if (CPID > 0)
            {
                CPSht CPSht = new CPSht(CPID, UserID);
                CPSht.ShowDialog();
            }
            else
            {
                MessageBox.Show("Container Packing is required");
                return;
            }
        }
    }
}
