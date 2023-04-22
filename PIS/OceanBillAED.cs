using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIS
{
    public partial class OceanBillAED : Form
    {
        public int UserID = 0;

        public OceanBillAED(string OBLID, int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            //Initialise DropDown
            AdvSearchSCN("NONE");
            AdvSearchLoadPort("NONE");
            AdvSearchUnloadPort("NONE");
            AdvSearchDestPort("NONE");
            AdvSearchShipAgent("~!");
            AdvSearchConsignee("~!");

            if (string.IsNullOrEmpty(OBLID) == false)
            {
                LoadOceanBillDetails(OBLID);
            }
            else
            {
                //New Registration
                lblOBLID.Text = "0";
                EnableEdit();
                txtSearchSCNNo.Focus();
            }


        }

        private void OceanBillAED_Load(object sender, EventArgs e)
        {

        }

        private void AdvSearchSCN(string SearchBy)
        {
            DataTable SCN = new DataTable();
            SCN = DBUtil.spMst_AdvSearchSCN(SearchBy);

            SCNNoList.DataSource = SCN;
            SCNNoList.DisplayMember = "scn";
            SCNNoList.ValueMember = "id";
        }

        private void AdvSearchLoadPort(string SearchBy)
        {
            DataTable LoadPort = new DataTable();
            LoadPort = DBUtil.spMst_AdvSearchPort(SearchBy);

            LoadPortList.DataSource = LoadPort;
            LoadPortList.DisplayMember = "name";
            LoadPortList.ValueMember = "id";
        }

        private void AdvSearchUnloadPort(string SearchBy)
        {
            DataTable UnloadPort = new DataTable();
            UnloadPort = DBUtil.spMst_AdvSearchPort(SearchBy);

            UnloadPortList.DataSource = UnloadPort;
            UnloadPortList.DisplayMember = "name";
            UnloadPortList.ValueMember = "id";
        }

        private void AdvSearchDestPort(string SearchBy)
        {
            DataTable DestPort = new DataTable();
            DestPort = DBUtil.spMst_AdvSearchPort(SearchBy);

            DestPortList.DataSource = DestPort;
            DestPortList.DisplayMember = "name";
            DestPortList.ValueMember = "id";
        }

        private void AdvSearchShipAgent(string SearchBy)
        {
            DataTable ShipAgent = new DataTable();
            ShipAgent = DBUtil.spMst_AdvSearchCustomer(SearchBy);

            ShipAgentList.DataSource = ShipAgent;
            ShipAgentList.DisplayMember = "name";
            ShipAgentList.ValueMember = "id";
        }

        private void AdvSearchConsignee(string SearchBy)
        {
            DataTable Consignee = new DataTable();
            Consignee = DBUtil.spMst_AdvSearchCustomer(SearchBy);

            OceanBillConsigneeList.DataSource = Consignee;
            OceanBillConsigneeList.DisplayMember = "name";
            OceanBillConsigneeList.ValueMember = "id";
        }

        private void txtSearchSCNNo_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchSCNNo.Text.Trim();

            if (SearchBy.Length != 0)
            {
                SCNNoList.Focus();
                AdvSearchSCN(SearchBy);
            }
            else
            {
                AdvSearchSCN("NONE");
            }
        }

        private void txtSearchLoadPortCode_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchLoadPortCode.Text.Trim();

            if (SearchBy.Length != 0)
            {
                LoadPortList.Focus();
                AdvSearchLoadPort(SearchBy);
            }
            else
            {
                AdvSearchLoadPort("NONE");
            }
        }

        private void txtSearchUnloadPort_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchUnloadPort.Text.Trim();

            if (SearchBy.Length != 0)
            {
                UnloadPortList.Focus();
                AdvSearchUnloadPort(SearchBy);
            }
            else
            {
                AdvSearchUnloadPort("NONE");
            }
        }

        private void txtSearchDestPortCode_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchDestPortCode.Text.Trim();

            if (SearchBy.Length != 0)
            {
                DestPortList.Focus();
                AdvSearchDestPort(SearchBy);
            }
            else
            {
                AdvSearchDestPort("NONE");
            }
        }

        private void txtSearchShipAgentID_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchShipAgentID.Text.Trim();

            if (SearchBy.Length != 0)
            {
                ShipAgentList.Focus();
                AdvSearchShipAgent(SearchBy);
            }
            else
            {
                AdvSearchShipAgent("~!");
            }
        }

        private void txtSearchOceanBillConsigneeID_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchOceanBillConsigneeID.Text.Trim();

            if (SearchBy.Length != 0)
            {
                OceanBillConsigneeList.Focus();
                AdvSearchConsignee(SearchBy);
            }
            else
            {
                AdvSearchConsignee("~!");
            }
        }

        private void SCNNoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ID = "";

            if (SCNNoList.SelectedIndex > -1)
            {
                ID = SCNNoList.SelectedValue.ToString().Trim();
                LoadVoyageDetails(ID);
            }
        }

        private void LoadVoyageDetails(string ID)
        {
            DataTable Voyage = new DataTable();
            Voyage = DBUtil.LoadVoyageDetails(ID);

            foreach (DataRow dr in Voyage.Rows)
            {
                txtSCNNo.Text = (string)dr["scn"].ToString().Trim();
                txtVesselName.Text = (string)dr["vid"].ToString().Trim();
                txtVoyageNo.Text = (string)dr["voyage_no"].ToString().Trim();
                DtETA.Value = ((DateTime)dr["Eta"]);
            }
        }

        public void LoadOceanBillDetails(string OBLID)
        {
            var SCN = "";
            var OBLNo = "";
            var LoadPort = "";
            var UnloadPort = "";
            var DestPort = "";
            var ShipAgent = "";
            var OBLConsignee = "";

            lblOBLID.Text = OBLID.Trim();


            DataTable OceanBillDetails = new DataTable();
            OceanBillDetails = DBUtil.LoadOceanBillDetails(OBLID);

            int count = OceanBillDetails.Rows.Count;

            if (count == 1)
            {
                foreach (DataRow dr in OceanBillDetails.Rows)
                {
                    SCN = (string)dr["scn"];
                    OBLNo = (string)dr["obl_no"];
                    LoadPort = (string)dr["load_port"];
                    UnloadPort = (string)dr["unload_port"];
                    DestPort = (string)dr["dest_port"];
                    ShipAgent = (string)dr["ship_agent"];
                    OBLConsignee = (string)dr["obl_consignee"];
                }

                txtSearchSCNNo.Text = SCN.Trim();
                AdvSearchSCN(SCN.Trim());

                txtOceanBillNo.Text = OBLNo.Trim();

                txtSearchLoadPortCode.Text = LoadPort.Trim();
                txtLoadPort.Text = LoadPort.Trim();
                AdvSearchLoadPort(LoadPort.Trim());

                txtSearchUnloadPort.Text = UnloadPort.Trim();
                txtUnloadPort.Text = UnloadPort.Trim();
                AdvSearchUnloadPort(UnloadPort.Trim());

                txtSearchDestPortCode.Text = DestPort.Trim();
                txtDestPort.Text = DestPort.Trim();
                AdvSearchDestPort(DestPort.Trim());

                txtSearchShipAgentID.Text = ShipAgent.Trim();
                txtShipAgent.Text = ShipAgent.Trim();
                AdvSearchShipAgent(ShipAgent.Trim());

                txtSearchOceanBillConsigneeID.Text = OBLConsignee.Trim();
                txtOceanBillConsignee.Text = OBLConsignee.Trim();
                AdvSearchConsignee(OBLConsignee.Trim());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lblOBLID.Text == "0")
            {
                Close();
            }
            else
            {
                DisableEdit();
                LoadOceanBillDetails(lblOBLID.Text.Trim());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var rtn = "";
            int NewID = 0;

            //Validate Form 
            if (SCNNoList.SelectedIndex == -1)
            {
                MessageBox.Show("SCN No must be entered");
                txtSearchSCNNo.Focus();
                return;
            }

            if (txtVesselName.Text.ToString() == "")
            {
                MessageBox.Show("Voyage No must be entered");
                txtVesselName.Focus();
                return;
            }

            if (txtVoyageNo.Text.ToString() == "")
            {
                MessageBox.Show("Voyage must be entered");
                txtVoyageNo.Focus();
                return;
            }

            if (txtOceanBillNo.Text.ToString() == "")
            {
                MessageBox.Show("Ocean Bill No must be entered");
                txtOceanBillNo.Focus();
                return;
            }

            if (LoadPortList.SelectedIndex == -1)
            {
                MessageBox.Show("Port Of Loading must be entered");
                txtSearchLoadPortCode.Focus();
                return;
            }

            if (UnloadPortList.SelectedIndex == -1)
            {
                MessageBox.Show("Port Of Unloading must be entered");
                txtUnloadPort.Focus();
                return;
            }

            if (DestPortList.SelectedIndex == -1)
            {
                MessageBox.Show("Destination Port must be entered");
                txtDestPort.Focus();
                return;
            }

            if (ShipAgentList.SelectedIndex == -1)
            {
                MessageBox.Show("Ship Agent must be entered");
                txtSearchShipAgentID.Focus();
                return;
            }

            if (OceanBillConsigneeList.SelectedIndex == -1)
            {
                MessageBox.Show("OBL Consignee must be entered");
                txtOceanBillConsignee.Focus();
                return;
            }

            //Assign Form Input Items to local variables
            int ID = Convert.ToInt32(lblOBLID.Text.Trim());
            int VoyageID = Convert.ToInt32(SCNNoList.SelectedValue);
            var OBLNo = txtOceanBillNo.Text.Trim();
            int LoadPort = Convert.ToInt32(LoadPortList.SelectedValue);
            int UnloadPort = Convert.ToInt32(UnloadPortList.SelectedValue);
            int DestPort = Convert.ToInt32(DestPortList.SelectedValue);
            int ShipAgent = Convert.ToInt32(ShipAgentList.SelectedValue);
            int OBLConsignee = Convert.ToInt32(OceanBillConsigneeList.SelectedValue);
            //int CUser = 1;
            int UUser = UserID;

            //Upsert OceanBillDetails
            rtn = DBUtil.UpsertOBL(ID, VoyageID, OBLNo, LoadPort, UnloadPort, DestPort, ShipAgent, OBLConsignee, UUser);

            if (rtn == "OK")
            {
                //disable edit
                DisableEdit();

                NewID = DBUtil.GetOBLID(VoyageID);
                if (NewID != 0)
                {
                    LoadOceanBillDetails(NewID.ToString().Trim());
                }
                else
                {
                    MessageBox.Show("ERROR : Fail To Load Saved Data");
                    return;
                }
            }
            else
            {
                MessageBox.Show(rtn);
                return;
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var rtn = "";
            int OBLID = Convert.ToInt32(lblOBLID.Text.Trim());

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                // Yes, continue 
            }
            else if (dlgResult == DialogResult.No)
            {
                return;
            }

            rtn = DBUtil.DelOceanBillDetails(OBLID);

            if (rtn == "OK")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Fail to delete OceanBill, SCN : " + txtSCNNo.Text.Trim(), "Error");
                Close();
            }
        }

        private void EnableEdit()
        {
            pnlEdit.Visible = false;
            pnlSave.Visible = true;

            txtSearchSCNNo.ReadOnly = false;
            txtSCNNo.Visible = false;
            SCNNoList.Visible = true;

            txtVesselName.ReadOnly = true;

            txtVoyageNo.ReadOnly = true;

            DtETA.Enabled = false;

            txtOceanBillNo.ReadOnly = false;

            txtSearchLoadPortCode.ReadOnly = false;
            txtLoadPort.Visible = false;
            LoadPortList.Visible = true;

            txtSearchUnloadPort.ReadOnly = false;
            txtUnloadPort.Visible = false;
            UnloadPortList.Visible = true;

            txtSearchDestPortCode.ReadOnly = false;
            txtDestPort.Visible = false;
            DestPortList.Visible = true;

            txtSearchShipAgentID.ReadOnly = false;
            txtShipAgent.Visible = false;
            ShipAgentList.Visible = true;

            txtSearchOceanBillConsigneeID.ReadOnly = false;
            txtOceanBillConsignee.Visible = false;
            OceanBillConsigneeList.Visible = true;
        }

        private void DisableEdit()
        {
            pnlEdit.Visible = true;
            pnlSave.Visible = false;

            txtSearchSCNNo.ReadOnly = true;
            txtSearchSCNNo.ResetText();
            SCNNoList.Visible = false;
            txtSCNNo.Visible = true;
            txtSCNNo.ReadOnly = true;

            txtVesselName.ReadOnly = true;

            txtVoyageNo.ReadOnly = true;

            DtETA.Enabled = false;

            txtOceanBillNo.ReadOnly = true;

            txtSearchLoadPortCode.ReadOnly = true;
            txtSearchLoadPortCode.ResetText();
            LoadPortList.Visible = false;
            txtLoadPort.ReadOnly = true;
            txtLoadPort.Visible = true;

            txtSearchUnloadPort.ReadOnly = true;
            txtSearchUnloadPort.ResetText();
            UnloadPortList.Visible = false;
            txtUnloadPort.ReadOnly = true;
            txtUnloadPort.Visible = true;

            txtSearchDestPortCode.ReadOnly = true;
            txtSearchDestPortCode.ResetText();
            DestPortList.Visible = false;
            txtDestPort.ReadOnly = true;
            txtDestPort.Visible = true;

            txtSearchShipAgentID.ReadOnly = true;
            txtSearchShipAgentID.ResetText();
            ShipAgentList.Visible = false;
            txtShipAgent.ReadOnly = true;
            txtShipAgent.Visible = true;

            txtSearchOceanBillConsigneeID.ReadOnly = true;
            txtSearchOceanBillConsigneeID.ResetText();
            OceanBillConsigneeList.Visible = false;
            txtOceanBillConsignee.ReadOnly = true;
            txtOceanBillConsignee.Visible = true;
        }

        private void btnAddPort_Click(object sender, EventArgs e)
        {
            PortAED PortAED = new PortAED(1, 0, UserID);
            PortAED.ShowDialog();

        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            CustAED CustAED = new CustAED(1, 0, UserID);
            CustAED.ShowDialog();
        }
    }
}
