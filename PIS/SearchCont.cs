using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS
{
    public partial class SearchCont : Form
    {
        public SearchCont()
        {
            InitializeComponent();
            AdvSearchOBLByContainer("");
            AdvSearchHBLByOBL(0, 0);
        }

        private void SearchCont_Load(object sender, EventArgs e)
        {
            //OBL
            dgvOBL.Columns[0].Name = "id";
            dgvOBL.Columns[0].HeaderText = "Id";
            dgvOBL.Columns[0].Visible = false;

            dgvOBL.Columns[1].Name = "obl_no";
            dgvOBL.Columns[1].HeaderText = "Obl";

            dgvOBL.Columns[2].Name = "scn";
            dgvOBL.Columns[2].HeaderText = "Scn";

            dgvOBL.Columns[3].Name = "voyage_no";
            dgvOBL.Columns[3].HeaderText = "Voyage";

            dgvOBL.Columns[4].Name = "name";
            dgvOBL.Columns[4].HeaderText = "Vessel";

            dgvOBL.Columns[5].Name = "eta";
            dgvOBL.Columns[5].HeaderText = "Eta";

            dgvOBL.Columns[6].Name = "unstuff_date";
            dgvOBL.Columns[6].HeaderText = "Unstuff On";

            //HBL
            dgvHBL.Columns[0].Name = "id";
            dgvHBL.Columns[0].HeaderText = "Id";
            dgvHBL.Columns[0].Visible = false;

            dgvHBL.Columns[1].Name = "hbl_no";
            dgvHBL.Columns[1].HeaderText = "HBL";

            dgvHBL.Columns[2].Name = "goods_qty";
            dgvHBL.Columns[2].HeaderText = "Quantity";

            dgvHBL.Columns[3].Name = "weight";
            dgvHBL.Columns[3].HeaderText = "Weight";

            dgvHBL.Columns[4].Name = "volume";
            dgvHBL.Columns[4].HeaderText = "Volume (m3)";
        }

        public void AdvSearchContainer(string SearchBy)
        {
            DataTable Container = new DataTable();
            Container = DBUtil.AdvSearchContainer(SearchBy);

            ContList.DataSource = Container.DefaultView;
            ContList.ValueMember = "container_no";
            ContList.DisplayMember = "container_no";
        }

        private void AdvSearchOBLByContainer(string SearchBy)
        {
            DataTable OBL = new DataTable();
            OBL = DBUtil.AdvSearchOBLByContainer(SearchBy);

            dgvOBL.DataSource = OBL;
        }

        private void AdvSearchHBLByOBL(int OBLID, int ContID)
        {
            DataTable HBL = new DataTable();
            HBL = DBUtil.AdvSearchHBLByOBL(OBLID, ContID);

            dgvHBL.DataSource = HBL;
        }

        private void txtSearchCont_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";
            SearchBy = txtSearchCont.Text.ToString().Trim();

            if (SearchBy.Length > 0)
            {
                AdvSearchContainer(SearchBy);
                AdvSearchOBLByContainer("");
                LoadOBL(0, "");
                LoadHBL(0);
            }
            else
            {
                AdvSearchContainer("NONE");
                AdvSearchOBLByContainer("");
                AdvSearchHBLByOBL(0, 0);
                LoadOBL(0, "");
                LoadHBL(0);
            }
        }

        private void ContList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ContainerNo = "";

            if (ContList.SelectedIndex > -1)
            {
                ContainerNo = ContList.SelectedValue.ToString();
                AdvSearchOBLByContainer(ContainerNo);
                AdvSearchHBLByOBL(0,0);
            }
            else
            {
                AdvSearchOBLByContainer("");
                AdvSearchHBLByOBL(0, 0);
            }
        }

        private void dgvOBL_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int OBLID = 0;
            var UnstuffOn = "";
            int ContainerID = 0;

            OBLID = Convert.ToInt32(dgvOBL.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            UnstuffOn = dgvOBL.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
            ContainerID = DBUtil.GetContainerID(ContList.SelectedValue.ToString());

            LoadOBL(OBLID, UnstuffOn);

            AdvSearchHBLByOBL(OBLID, ContainerID);
        }

        private void dgvHBL_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int HBLID = 0;
            var HBLNo = "";

            HBLID = Convert.ToInt32(dgvHBL.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            HBLNo = dgvHBL.Rows[e.RowIndex].Cells[1].Value.ToString().Trim().ToUpper();

            Clipboard.SetText(HBLNo);

            LoadHBL(HBLID);
        }

        private void LoadOBL(int OBLID, string UnstuffOn)
        {
            DataTable OBL = new DataTable();
            OBL = DBUtil.LoadOceanBillDetails(OBLID.ToString());

            if (OBL.Rows.Count > 0)
            {
                lblSCNNo.Text = OBL.Rows[0]["scn"].ToString();
                lblVessel.Text = OBL.Rows[0]["vessel"].ToString();
                lblVoyage.Text = OBL.Rows[0]["voyage_no"].ToString();
                lblETA.Text = Convert.ToDateTime(OBL.Rows[0]["eta"]).ToString("dd/MM/yyyy");
                lblOBLNo.Text = OBL.Rows[0]["obl_no"].ToString();
                lblPortLoad.Text = OBL.Rows[0]["load_port"].ToString();
                lblPortUnload.Text = OBL.Rows[0]["unload_port"].ToString();
                lblPortDest.Text = OBL.Rows[0]["dest_port"].ToString();
                lblShipAgent.Text = OBL.Rows[0]["ship_agent"].ToString();
                lblOBLConsignee.Text = OBL.Rows[0]["obl_consignee"].ToString();
                lblUnstuffOn.Text = UnstuffOn;
            }
            else
            {
                lblSCNNo.Text = "";
                lblVessel.Text = "";
                lblVoyage.Text = "";
                lblETA.Text = "";
                lblOBLNo.Text = "";
                lblPortLoad.Text = "";
                lblPortUnload.Text = "";
                lblPortDest.Text = "";
                lblShipAgent.Text = "";
                lblOBLConsignee.Text = "";
                lblUnstuffOn.Text = "";
            }


        }

        private void LoadHBL(int HBLID)
        {
            DataTable HBL = new DataTable();
            HBL = DBUtil.LoadHBL(HBLID);

            if (HBL.Rows.Count > 0)
            {
                lblHouseBillNo.Text = HBL.Rows[0]["hbl_no"].ToString();
                lblUnit.Text = HBL.Rows[0]["unit"].ToString();
                lblConsignee.Text = HBL.Rows[0]["consignee"].ToString();
                lblClass.Text = HBL.Rows[0]["fullname"].ToString();
                lblQty.Text = HBL.Rows[0]["goods_qty"].ToString();
                lblVolume.Text = HBL.Rows[0]["volume"].ToString();
                lblWeight.Text = HBL.Rows[0]["weight"].ToString();
                lblMarking.Text = HBL.Rows[0]["marking"].ToString();
                lblCargoDesc.Text = HBL.Rows[0]["cargo_desc"].ToString();
                if (HBL.Rows[0]["transhipment"].ToString() == "0")
                {
                    lblTranshipment.Text = "No";
                    lblPort.Text = "";
                }
                else if (HBL.Rows[0]["transhipment"].ToString() == "1")
                {
                    lblTranshipment.Text = "Yes";
                    lblPort.Text = HBL.Rows[0]["port"].ToString().Trim();
                }
                else
                {
                    lblTranshipment.Text = "";
                }

            }
            else
            {
                lblHouseBillNo.Text = "";
                lblUnit.Text = "";
                lblConsignee.Text = "";
                lblClass.Text = "";
                lblQty.Text = "";
                lblVolume.Text = "";
                lblWeight.Text = "";
                lblMarking.Text = "";
                lblCargoDesc.Text = "";
                lblTranshipment.Text = "";
                lblPort.Text = "";
            }
        }
    }
}
