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
    public partial class CFSAED : Form
    {
        public int UserID = 0;

        public CFSAED(int LoginID, int CFSID)
        {
            UserID = LoginID;
        
            InitializeComponent();

            AdvSearchShipper("~!");
            AdvSearchUnit("~!");
            AdvSearchDischargePort("~!");
            AdvSearchFinalPort("~!");
            AdvSearchVessel("~!");

            if (CFSID > 0)
            {
                lblCFSID.Text = CFSID.ToString();
                LoadCFS(CFSID);
                DisableEdit();
            }
            else
            {
                EnableEdit();
                lblCFSID.Text = "0";
                txtSearchShipper.Focus();
            }

        }

        public void AdvSearchShipper(string SearchBy)
        {
            DataTable Shipper = new DataTable();
            Shipper = DBUtil.spMst_AdvSearchCustomer(SearchBy);

            ShipperList.DataSource = Shipper;
            ShipperList.DisplayMember = "name";
            ShipperList.ValueMember = "id";
        }

        public void AdvSearchUnit(string SearchBy)
        {
            DataTable Unit = new DataTable();
            Unit = DBUtil.spMst_AdvSearchUnit(SearchBy);

            UnitList.DataSource = Unit;
            UnitList.DisplayMember = "shortname";
            UnitList.ValueMember = "id";
        }

        public void AdvSearchDischargePort(string SearchBy)
        {
            DataTable Port = new DataTable();
            Port = DBUtil.spMst_AdvSearchPort(SearchBy);

            DischargePortList.DataSource = Port;
            DischargePortList.DisplayMember = "name";
            DischargePortList.ValueMember = "id";
        }

        public void AdvSearchFinalPort(string SearchBy)
        {
            DataTable Port = new DataTable();
            Port = DBUtil.spMst_AdvSearchPort(SearchBy);

            FinalPortList.DataSource = Port;
            FinalPortList.DisplayMember = "name";
            FinalPortList.ValueMember = "id";
        }

        public void AdvSearchVessel(string SearchBy)
        {
            DataTable Vessel = new DataTable();
            Vessel = DBUtil.spMst_AdvSearchVessel(SearchBy);

            VesselList.DataSource = Vessel;
            VesselList.DisplayMember = "name";
            VesselList.ValueMember = "id";
            
        }

        private void txtSearchShipper_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";

            SearchBy = txtSearchShipper.Text.ToString().Trim();

            if (!string.IsNullOrWhiteSpace(SearchBy) && SearchBy.Length > 0)
            {
                AdvSearchShipper(SearchBy);
            }
            else
            {
                AdvSearchShipper("~!");
            }
        }

        private void txtSearchUnit_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";

            SearchBy = txtSearchUnit.Text.ToString().Trim();

            if (!string.IsNullOrWhiteSpace(SearchBy) && SearchBy.Length > 0)
            {
                AdvSearchUnit(SearchBy);
            }
            else
            {
                AdvSearchUnit("~!");
            }
        }

        private void txtSearchDisChrgPort_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";

            SearchBy = txtSearchDisChrgPort.Text.ToString().Trim();

            if (!string.IsNullOrWhiteSpace(SearchBy) && SearchBy.Length > 0)
            {
                AdvSearchDischargePort(SearchBy);
            }
            else
            {
                AdvSearchDischargePort("~!");
            }
        }

        private void txtSearchFinalPort_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";

            SearchBy = txtSearchFinalPort.Text.ToString().Trim();

            if (!string.IsNullOrWhiteSpace(SearchBy) && SearchBy.Length > 0)
            {
                AdvSearchFinalPort(SearchBy);
            }
            else
            {
                AdvSearchFinalPort("~!");
            }
        }

        private void txtSearchVessel_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";

            SearchBy = txtSearchVessel.Text.ToString().Trim();

            if (!string.IsNullOrWhiteSpace(SearchBy) && SearchBy.Length > 0)
            {
                AdvSearchVessel(SearchBy);
            }
            else
            {
                AdvSearchVessel("~!");
            }
        }

        public void EnableEdit()
        {
            pnlEdit.Visible = false;
            pnlSave.Visible = true;

            txtCFSNo.ReadOnly = true;

            txtSearchShipper.Visible = true;
            txtSearchShipper.ReadOnly = false;
            ShipperList.Visible = true;
            txtShipper.ReadOnly = true;
            txtShipper.Visible = false;

            txtQty.ReadOnly = false;

            txtSearchUnit.Visible = true;
            txtSearchUnit.ReadOnly = false;
            UnitList.Visible = true;
            txtUnit.Visible = false;
            txtUnit.ReadOnly = true;

            txtCargoDesc.ReadOnly = false;

            txtWeight.ReadOnly = false;

            txtVolume.ReadOnly = false;

            txtMarking.ReadOnly = false;

            txtRefNo.ReadOnly = false;

            txtRemarks.ReadOnly = false;

            txtSearchDisChrgPort.Visible = true;
            txtSearchDisChrgPort.ReadOnly = false;
            DischargePortList.Visible = true;
            txtDisChrgPort.Visible = false;
            txtDisChrgPort.ReadOnly = true;

            txtSearchFinalPort.Visible = true;
            txtSearchFinalPort.ReadOnly = false;
            FinalPortList.Visible = true;
            txtFinalPort.Visible = false;
            txtFinalPort.ReadOnly = true;

            txtSearchVessel.Visible = true;
            txtSearchVessel.ReadOnly = false;
            VesselList.Visible = true;
            txtVessel.Visible = false;
            txtVessel.ReadOnly = true;

            dtDateReceived.Enabled = true;

            dtReceiveTime.Enabled = true;

            txtReceivedBy.ReadOnly = false;

            txtLocation.ReadOnly = false;

        }

        public void DisableEdit()
        {
            pnlEdit.Visible = true;
            pnlSave.Visible = false;

            txtCFSNo.ReadOnly = true;

            txtSearchShipper.Visible = false;
            txtSearchShipper.ReadOnly = true;
            ShipperList.Visible = false;
            txtShipper.ReadOnly = true;
            txtShipper.Visible = true;

            txtQty.ReadOnly = true;

            txtSearchUnit.Visible = false;
            txtSearchUnit.ReadOnly = true;
            UnitList.Visible = false;
            txtUnit.Visible = true;
            txtUnit.ReadOnly = true;

            txtCargoDesc.ReadOnly = true;

            txtWeight.ReadOnly = true;

            txtVolume.ReadOnly = true;

            txtMarking.ReadOnly = true;

            txtRefNo.ReadOnly = true;

            txtRemarks.ReadOnly = true;

            txtSearchDisChrgPort.Visible = false;
            txtSearchDisChrgPort.ReadOnly = true;
            DischargePortList.Visible = false;
            txtDisChrgPort.Visible = true;
            txtDisChrgPort.ReadOnly = true;

            txtSearchFinalPort.Visible = false;
            txtSearchFinalPort.ReadOnly = true;
            FinalPortList.Visible = false;
            txtFinalPort.Visible = true;
            txtFinalPort.ReadOnly = true;

            txtSearchVessel.Visible = false;
            txtSearchVessel.ReadOnly = true;
            VesselList.Visible = false;
            txtVessel.Visible = true;
            txtVessel.ReadOnly = true;

            dtDateReceived.Enabled = false;

            dtReceiveTime.Enabled = false;

            txtReceivedBy.ReadOnly = true;

            txtLocation.ReadOnly = true;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
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

        public void LoadCFS(int CFSID)
        {
            DataTable CFS = new DataTable();
            CFS = DBUtil.LoadCFS(CFSID);

            if (CFS.Rows.Count > 0)
            {
                lblCFSID.Text = CFS.Rows[0]["id"].ToString();
                txtCFSNo.Text = CFS.Rows[0]["cfs_no"].ToString();
                txtSearchShipper.Text = CFS.Rows[0]["shipper"].ToString();
                txtShipper.Text = CFS.Rows[0]["shipper"].ToString();
                txtQty.Text = CFS.Rows[0]["qty"].ToString();
                txtSearchUnit.Text = CFS.Rows[0]["unit"].ToString();
                txtUnit.Text = CFS.Rows[0]["unit"].ToString();
                txtCargoDesc.Text = CFS.Rows[0]["cargo_desc"].ToString();
                txtWeight.Text = CFS.Rows[0]["weight"].ToString();
                txtVolume.Text = CFS.Rows[0]["volume"].ToString();
                txtMarking.Text = CFS.Rows[0]["marking"].ToString();
                txtSearchDisChrgPort.Text = CFS.Rows[0]["discharge_port"].ToString();
                txtDisChrgPort.Text = CFS.Rows[0]["discharge_port"].ToString();
                txtSearchFinalPort.Text = CFS.Rows[0]["final_port"].ToString();
                txtFinalPort.Text = CFS.Rows[0]["final_port"].ToString();
                txtSearchVessel.Text = CFS.Rows[0]["vessel"].ToString();
                txtVessel.Text = CFS.Rows[0]["vessel"].ToString();
                dtDateReceived.Value = ((DateTime)CFS.Rows[0]["date_receive"]);
                dtReceiveTime.Value = ((DateTime)CFS.Rows[0]["time_receive"]);
                txtReceivedBy.Text = CFS.Rows[0]["receive_by"].ToString();
                txtLocation.Text = CFS.Rows[0]["location"].ToString();
                txtRefNo.Text = CFS.Rows[0]["reference_no"].ToString();
                txtRemarks.Text = CFS.Rows[0]["remarks"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var CFSNo = "";
            var IssuePort = "";
            int CFSID = Convert.ToInt32("0" + lblCFSID.Text.ToString().Trim());
            DateTime TimeReceive = Convert.ToDateTime(dtDateReceived.Value.ToString("yyyy-MM-dd") + " " + dtReceiveTime.Value.ToString("HH:mm:ss tt"));
            var rtn = "";

            if (CFSID > 0 && txtCFSNo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("CFS No is required");
                return;
            }

            if (ShipperList.SelectedIndex == -1)
            {
                MessageBox.Show("Shipper is required");
                return;
            }

            if (txtQty.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Quantity is required");
                return;
            }

            if (UnitList.SelectedIndex == -1)
            {
                MessageBox.Show("Unit is required");
                return;
            }

            if (txtCargoDesc.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Cargo Description is required");
                return;
            }

            if (txtWeight.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Weight is required");
                return;
            }

            if(txtVolume.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Volume is required");
                return;
            }

            if(txtMarking.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Marking is required");
                return;
            }

            if(DischargePortList.SelectedIndex == -1)
            {
                MessageBox.Show("Discharge Port is required");
                return;
            }

            if (FinalPortList.SelectedIndex == -1)
            {
                MessageBox.Show("Final Port is required");
                return;
            }

            if(VesselList.SelectedIndex == -1)
            {
                MessageBox.Show("Vessel is required");
                return;
            }

            if (txtReceivedBy.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Received By is required");
                return;
            }

            if (txtLocation.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Location is required");
                return;
            }

            if (txtRefNo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Reference No is required");
                return;
            }


            if (txtRemarks.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Remarks is required");
                return;
            }

            IssuePort = GetIssuePort();

            if (IssuePort == "-")
            {
                return;
            }

            if (CFSID == 0)
            {
                CFSNo = DBUtil.GenerateCFSNo(IssuePort);

                if (CFSNo != "")
                {
                    rtn = DBUtil.UpsertCFS(CFSID, CFSNo, Convert.ToInt32(ShipperList.SelectedValue), Convert.ToInt32(DischargePortList.SelectedValue), Convert.ToInt32(FinalPortList.SelectedValue),
                       Convert.ToInt32(VesselList.SelectedValue), Convert.ToInt32(txtQty.Text.ToString().Trim()), Convert.ToInt32(UnitList.SelectedValue),
                       Convert.ToDecimal(txtWeight.Text.ToString().Trim()), Convert.ToDecimal(txtVolume.Text.ToString().Trim()), txtMarking.Text.ToString().Trim(),
                       txtCargoDesc.Text.ToString().Trim(), dtDateReceived.Value, TimeReceive, txtReceivedBy.Text.ToString().Trim(), txtLocation.Text.ToString().Trim(),
                       txtRefNo.Text.ToString().Trim(), txtRemarks.Text.ToString().Trim(), UserID);

                    if (rtn == "OK")
                    {
                        CFSID = DBUtil.GetCFSID(CFSNo);

                        if (CFSID != 0)
                        {
                            LoadCFS(CFSID);
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
                        MessageBox.Show("ERROR : " + rtn.Trim());
                    }
                }
                else
                {
                    MessageBox.Show("ERROR : Fail To Generate CFS No");
                    return;
                }
            }
            else
            {
                CFSNo = txtCFSNo.Text.ToString().Trim().ToUpper();

                rtn = DBUtil.UpsertCFS(CFSID, CFSNo, Convert.ToInt32(ShipperList.SelectedValue), Convert.ToInt32(DischargePortList.SelectedValue), Convert.ToInt32(FinalPortList.SelectedValue),
                       Convert.ToInt32(VesselList.SelectedValue), Convert.ToInt32(txtQty.Text.ToString().Trim()), Convert.ToInt32(UnitList.SelectedValue),
                       Convert.ToDecimal(txtWeight.Text.ToString().Trim()), Convert.ToDecimal(txtVolume.Text.ToString().Trim()), txtMarking.Text.ToString().Trim(),
                       txtCargoDesc.Text.ToString().Trim(), dtDateReceived.Value, dtReceiveTime.Value, txtReceivedBy.Text.ToString().Trim(), txtLocation.Text.ToString().Trim(),
                       txtRefNo.Text.ToString().Trim(), txtRemarks.Text.ToString().Trim(), UserID);

                if (rtn == "OK")
                {
                    LoadCFS(CFSID);
                    DisableEdit();
                }
                else
                {
                    MessageBox.Show("ERROR : " + rtn.Trim());
                    return;
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int CFSID = Convert.ToInt32("0" + lblCFSID.Text.ToString().Trim());

            if (CFSID == 0) this.Close(); else DisableEdit();
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
            int CFSID = 0;
            var rtn = "";

            CFSID = Convert.ToInt32("0" + lblCFSID.Text.ToString().Trim());

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this Container Shipping Note?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)
            {
                rtn = DBUtil.DelCFS(CFSID);

                if (rtn != "ERROR") this.Close(); else MessageBox.Show("System Unable To Delete Container Shipping Note : " + txtCFSNo.Text.ToString(), "Error"); return;
            }
            else
            {
                return;
            }
        }

        private void btnAddShipper_Click(object sender, EventArgs e)
        {
            CustAED CustAED = new CustAED(1, 0, UserID);
            CustAED.ShowDialog();
        }

        private void btnAddPort_Click(object sender, EventArgs e)
        {
            PortAED PortAED = new PortAED(1, 0, UserID);
            PortAED.ShowDialog();
        }

        private void btnAddVessel_Click(object sender, EventArgs e)
        {
            VesselAED2 detaildlg = new VesselAED2(1, 0, UserID);
            detaildlg.ShowDialog();
        }
    }
}
