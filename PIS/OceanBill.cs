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
    public partial class OceanBill : Form
    {
        public int UserID = 0;

        public OceanBill(int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();
        }

        private void OceanBill_Load(object sender, EventArgs e)
        {
            AdvSearchOBLContainers(0);
            AdvSearchHBLByContainer(0);

            //Container
            dgvCont.Columns[0].Name = "id";
            dgvCont.Columns[0].HeaderText = "ID";
            dgvCont.Columns[0].Visible = false;

            dgvCont.Columns[1].Name = "obl_id";
            dgvCont.Columns[1].HeaderText = "OBLID";
            dgvCont.Columns[1].Visible = false;

            dgvCont.Columns[2].Name = "container_no";
            dgvCont.Columns[2].HeaderText = "Container";

            dgvCont.Columns[3].Name = "seal_no";
            dgvCont.Columns[3].HeaderText = "Seal";

            dgvCont.Columns[4].Name = "size";
            dgvCont.Columns[4].HeaderText = "Size";

            //Bill
            dgvBill.Columns[0].Name = "id";
            dgvBill.Columns[0].HeaderText = "ID";
            dgvBill.Columns[0].Visible = false;

            dgvBill.Columns[1].Name = "obl_id";
            dgvBill.Columns[1].HeaderText = "OBLID";
            dgvBill.Columns[1].Visible = false;

            dgvBill.Columns[2].Name = "hbl_no";
            dgvBill.Columns[2].HeaderText = "HBL";

            dgvBill.Columns[3].Name = "goods_qty";
            dgvBill.Columns[3].HeaderText = "Quantity";

            dgvBill.Columns[4].Name = "weight";
            dgvBill.Columns[4].HeaderText = "Weight";

            dgvBill.Columns[5].Name = "volume";
            dgvBill.Columns[5].HeaderText = "Volume (m3)";
        }

        private void AdvSearchOBLNo(string SearchBy)
        {
            DataTable OBLNo = new DataTable();
            OBLNo = DBUtil.AdvSearchOceanBill(SearchBy);

            OBLNoList.DataSource = OBLNo;
            OBLNoList.DisplayMember = "obl_no";
            OBLNoList.ValueMember = "id";
        }

        private void AdvSearchOBLContainers(int OBLID)
        {
            try
            {
                DataTable OBLContainers = new DataTable();
                OBLContainers = DBUtil.AdvSearchOBLContainers(OBLID);

                dgvCont.DataSource = OBLContainers;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail To Load Container List." + e.Message, "Error");
                return;
            }
        }

        private void AdvSearchHBLByContainer(int ContID)
        {
            try
            {
                DataTable HBL = new DataTable();
                HBL = DBUtil.AdvSearchHBLByContainer(ContID);

                dgvBill.DataSource = HBL;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail To Load Goods Bill List." + e.Message, "Error");
                return;
            }
        }

        private void txtSearchOBLNo_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchOBLNo.Text.Trim();

            if (SearchBy.Length > 0)
            {
                AdvSearchOBLNo(SearchBy);
                AdvSearchOBLContainers(0);
            }
            else
            {
                AdvSearchOBLNo("~!");
                AdvSearchOBLContainers(0);
                AdvSearchHBLByContainer(0);
                lblSelectedContID.Text = "0";
            }
        }

        private void OBLNoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var OBLID = "";

            if (OBLNoList.SelectedIndex > -1)
            {
                OBLID = OBLNoList.SelectedValue.ToString().Trim();

                if (OBLID != "System.Data.DataRowView")
                {
                    AdvSearchOBLContainers(Convert.ToInt32(OBLID.ToString().Trim()));
                    AdvSearchHBLByContainer(0);
                }
                else
                {
                    AdvSearchOBLContainers(0);
                    AdvSearchHBLByContainer(0);
                }

            }
        }

        private void btnAddOBL_Click(object sender, EventArgs e)
        {
            var OBLID = "";
            var SearchBy = OBLNoList.Text.ToString().Trim();


            if (OBLNoList.SelectedIndex > -1)
            {
                OBLID = OBLNoList.SelectedValue.ToString().Trim();
                OceanBillAED OBLAEDDlg = new OceanBillAED(OBLID, UserID);
                OBLAEDDlg.ShowDialog();
                txtSearchOBLNo.Text = SearchBy;
                AdvSearchOBLNo(SearchBy);
            }
            else
            {
                OceanBillAED OBLAEDDlg = new OceanBillAED("", UserID);
                OBLAEDDlg.ShowDialog();
                AdvSearchOBLContainers(0);
            }


        }

        private void btnAddCont_Click(object sender, EventArgs e)
        {
            var OBLID = "";

            if (OBLNoList.SelectedIndex > -1)
            {
                OBLID = OBLNoList.SelectedValue.ToString().Trim();
                ContainerAED ContAEDdlg = new ContainerAED(Convert.ToInt32(OBLID), 0, UserID);
                ContAEDdlg.ShowDialog();
                AdvSearchOBLContainers(Convert.ToInt32(OBLID));
            }
            else
            {
                MessageBox.Show("OBL must be selected");
            }
        }

        private void dgvCont_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());

            if (currow > -1)
            {
                int ContID = Convert.ToInt32(dgvCont[0, currow].Value.ToString());
                int OBLID = Convert.ToInt32(dgvCont[1, currow].Value.ToString());

                ContainerAED ContAEDdlg = new ContainerAED(OBLID, ContID, UserID);
                ContAEDdlg.ShowDialog();
                AdvSearchOBLContainers(Convert.ToInt32(OBLID));
            }
        }

        private void dgvCont_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ContID = 0;

            ContID = Convert.ToInt32(dgvCont.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());

            lblSelectedContID.Text = ContID.ToString();

            AdvSearchHBLByContainer(ContID);
        }

        private void btnHBLAdd_Click(object sender, EventArgs e)
        {
            var OBLID = "";
            int ContID = 0;

            ContID = Convert.ToInt32(lblSelectedContID.Text.ToString().Trim());

            if (ContID !=0)
            {
                OBLID = OBLNoList.SelectedValue.ToString().Trim();
                BillAED BillAEDDlg = new BillAED(Convert.ToInt32(OBLID), 0, ContID, UserID);
                BillAEDDlg.ShowDialog();
                AdvSearchOBLContainers(Convert.ToInt32(OBLID));
                AdvSearchHBLByContainer(ContID);
            }
            else
            {
                MessageBox.Show("Container must be selected");
            }
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());
            int ContID = 0;

            ContID = Convert.ToInt32(lblSelectedContID.Text.ToString().Trim());

            if (currow > -1)
            {
                int HBLID = Convert.ToInt32(dgvBill[0, currow].Value.ToString());
                int OBLID = Convert.ToInt32(dgvBill[1, currow].Value.ToString());

                BillAED BillAEDDlg = new BillAED(OBLID, HBLID, ContID, UserID);
                BillAEDDlg.ShowDialog();
                AdvSearchOBLContainers(Convert.ToInt32(OBLID));
                AdvSearchHBLByContainer(ContID);
                
            }
        }

        private void btnPrintTally_Click(object sender, EventArgs e)
        {

            int OBLID = 0;
            int ContID = 0;
            int Index = 0;

            ContID = Convert.ToInt32(lblSelectedContID.Text.ToString().Trim());
            Index = OBLNoList.SelectedIndex;

            if (ContID != 0)
            {
                OBLID = Convert.ToInt32(OBLNoList.SelectedValue.ToString().Trim());

                TallySht TallyShtDlg = new TallySht(OBLID, ContID, UserID);
                TallyShtDlg.ShowDialog();
                //AdvSearchOBLContainers(OBLID);
                //AdvSearchHBLByContainer(ContID);
               OBLNoList.SelectedIndex = Index;
            }
            else
            {
                MessageBox.Show("Container Must be Selected", "Warning !");
            }


        }

        private void dgvBill_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var HBLNo = "";

            HBLNo = dgvBill.Rows[e.RowIndex].Cells[2].Value.ToString().Trim().ToUpper();

            Clipboard.SetText(HBLNo);
        }
    }
}
