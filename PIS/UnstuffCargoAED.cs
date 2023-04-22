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
    public partial class UnstuffCargoAED : Form
    {
        private int UserID = 0;

        public UnstuffCargoAED(int ContID, int LoginID, int OBLID)
        {
            UserID = LoginID;

            InitializeComponent();

            lblContID.Text = ContID.ToString();

            lblSysOBLID.Text = OBLID.ToString();

            AdvSearchHBLByContainer(ContID);

            LoadUnstuffContainerDetails(ContID);

            AdvSearchPort(0, "~!");

            DisableEdit();
        }

        private void UnstuffCargoAED_Load(object sender, EventArgs e)
        {
            ////Bill
            dgvBill.Columns[0].Name = "id";
            dgvBill.Columns[0].HeaderText = "ID";
            dgvBill.Columns[0].Visible = false;

            dgvBill.Columns[1].Name = "obl_id";
            dgvBill.Columns[1].HeaderText = "OBLID";
            dgvBill.Columns[1].Visible = false;

            dgvBill.Columns[2].Name = "hbl_no";
            dgvBill.Columns[2].HeaderText = "HBL";
        }

        private void AdvSearchHBLByContainer(int ContID)
        {
            try
            {
                DataTable HBL = new DataTable();
                HBL = DBUtil.AdvSearchHBLByUnstuffContainer(ContID);

                dgvBill.DataSource = HBL;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail To Load Goods Bill List." + e.Message, "Error");
                return;
            }
        }

        public void LoadUnstuffContainerDetails(int ContID)
        {
            var ContainerNo = "";
            int UnstuffFlag = 0;

            lblContID.Text = ContID.ToString();

            DataTable UnstuffContainerDetails = new DataTable();
            UnstuffContainerDetails = DBUtil.LoadUnstuffContainers(ContID);

            int count = UnstuffContainerDetails.Rows.Count;

            if (count == 1)
            {
                foreach (DataRow dr in UnstuffContainerDetails.Rows)
                {
                    ContainerNo = (string)dr["container_no"];
                    UnstuffFlag = Convert.ToInt32(dr["unstuff_flag"]);

                    if (UnstuffFlag != 0)
                    {
                        DtUnstuff.Value = ((DateTime)dr["unstuff_date"]);
                    }
                    else
                    {
                        DtUnstuff.Value = DateTime.Now;
                    }
                    ChkUnstuff.Checked = Convert.ToBoolean(dr["unstuff_flag"]);
                }

                txtContainerNo.Text = ContainerNo.Trim();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ContainerID = Convert.ToInt32(lblContID.Text.Trim());
            var ContainerNo = txtContainerNo.Text.Trim();
            bool Unstuff = ChkUnstuff.Checked;
            var rtn = "";

            rtn = DBUtil.UpdateUnstuffContainer(ContainerID, Unstuff, DtUnstuff.Value);

            if (rtn == "OK")
            {
                DisableEdit();
            }
            else
            {
                MessageBox.Show(rtn);
                return;
            }

        }

        private void EnableEdit()
        {
            pnlEdit.Visible = false;
            pnlSave.Visible = true;

            txtContainerNo.ReadOnly = false;

            ChkUnstuff.Enabled = true;

            DtUnstuff.Enabled = true;
        }

        private void DisableEdit()
        {
            pnlEdit.Visible = true;
            pnlSave.Visible = false;

            txtContainerNo.ReadOnly = true;

            ChkUnstuff.Enabled = false;

            DtUnstuff.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DisableEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBill_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int HBLID = 0;

            HBLID = Convert.ToInt32(dgvBill.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            lblHBLID.Text = HBLID.ToString();
            LoadHBL(HBLID);
        }

        private void LoadHBL(int HBLID)
        {
            int ID = 0;
            var HBLNo = "";
            int OBLID = 0;
            var CargoDesc = "";
            var Unit = "";
            var Consignee = "";
            var Remarks = "";
            int InwardSurvey = 0;
            var Marking = "";
            int Transhipment = 0;
            var Port = "";
            var Packaging = "";
            var Location = "";
            var Class = "";
            int GoodQty = 0;
            decimal Weight = 0;
            decimal Volume = 0;

            DataTable HBL = new DataTable();
            HBL = DBUtil.LoadHBL(HBLID);

            int count = 0;
            count = HBL.Rows.Count;

            if (count == 1)
            {
                foreach (DataRow dr in HBL.Rows)
                {
                    ID = Convert.ToInt32(dr["id"]);
                    HBLNo = (string)dr["hbl_no"];
                    OBLID = Convert.ToInt32(dr["obl_id"]);
                    CargoDesc = (string)dr["cargo_desc"];
                    Unit = (string)dr["unit"];
                    Consignee = (string)dr["consignee"];
                    Remarks = (string)dr["remarks"];
                    InwardSurvey = Convert.ToInt32(dr["inward_survey"]);
                    Marking = (string)dr["marking"];
                    Transhipment = Convert.ToInt32(dr["transhipment"]);
                    Port = dr["port"].ToString().Trim();
                    Packaging = (string)dr["packaging"];
                    //Location = Convert.ToInt32(dr["location"]);
                    Class = (string)dr["fullname"];
                    GoodQty = Convert.ToInt32(dr["goods_qty"]);
                    Weight = Convert.ToDecimal(dr["weight"]);
                    Volume = Convert.ToDecimal(dr["volume"]);
                    Location = dr["location"].ToString();

                }

                lblOBLID.Text = OBLID.ToString();
                lblHBLID.Text = ID.ToString();

                lblHouseBillNo.Text = HBLNo;

                lblCargoDesc.Text = CargoDesc;

                lblUnitName.Text = Unit;

                lblConsignee.Text = Consignee;

                txtMarking.Text = Marking;

                lblClass.Text = Class;

                lblQty.Text = GoodQty.ToString();

                lblWeight.Text = Weight.ToString();

                lblVolume.Text = Volume.ToString();

                if (Transhipment == 0)
                {
                    rbShipmentNo.Checked = true;
                    txtSearchPort.Text = "";
                    AdvSearchPort(0, "~!");
                }
                else if (Transhipment == 1)
                {
                    rbShipmentYes.Checked = true;
                    txtSearchPort.Text = Port;
                    AdvSearchPort(1, Port.ToString());
                }
                else
                {
                    rbShipmentYes.Checked = false;
                    rbShipmentNo.Checked = false;
                }

                txtRemarks.Text = Remarks.ToString();

                if (InwardSurvey == 0)
                {
                    rbInwardSurveyNo.Checked = true;
                }
                else if (InwardSurvey == 1)
                {
                    rbInwardSurveyYes.Checked = true;
                }
                else
                {
                    rbInwardSurveyNo.Checked = false;
                    rbInwardSurveyYes.Checked = false;
                }

                txtPackaging.Text = Packaging.ToString();

                txtLocation.Text = Location.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int HBLID = Convert.ToInt32(lblHBLID.Text);
            var Marking = txtMarking.Text.Trim();
            var Remarks = txtRemarks.Text.Trim();
            var Packaging = txtPackaging.Text.Trim();
            int Transhipment = 0;
            int InwardSurvey = 0;
            var Location = txtLocation.Text.Trim();
            var rtn = "";
            int Port = 0;

            if (rbShipmentYes.Checked)
            {
                if (PortList.SelectedIndex == -1)
                {
                    MessageBox.Show("Port must be entered");
                    txtSearchPort.Focus();
                    return;
                }
            }

            if (rbShipmentNo.Checked == true)
            {
                Transhipment = 0;
                Port = 0;
            }
            else if (rbShipmentYes.Checked == true)
            {
                Transhipment = 1;
                Port = Convert.ToInt32(PortList.SelectedValue.ToString());
            }

            if (rbInwardSurveyNo.Checked == true)
            {
                InwardSurvey = 0;
            }
            else if (rbInwardSurveyYes.Checked == true)
            {
                InwardSurvey = 1;
            }

            if (Location.Length == 0)
            {
                MessageBox.Show("Location must be entered");
                txtLocation.Focus();
                return;
            }

            rtn = DBUtil.UpdateHBLUnstuffContainer(Marking, Transhipment, Port, InwardSurvey, Remarks, Packaging, Location, HBLID);

            if (rtn != "OK")
            {
                MessageBox.Show(rtn);
                return;
            }
            else
            {
                MessageBox.Show("HBL Updated");
                return;
            }
        }

        private void txtSearchPort_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchPort.Text.Trim();

            if (SearchBy.Length != 0)
            {
                PortList.Focus();
                AdvSearchPort(0, SearchBy);
            }
            else
            {
                AdvSearchPort(0, "~!");
            }
        }

        private void rbShipmentYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShipmentYes.Checked == true)
            {
                txtSearchPort.ReadOnly = false;
                PortList.Visible = true;
            }
            else
            {
                txtSearchPort.ResetText();
                txtSearchPort.ReadOnly = true;
                PortList.Visible = true;
                PortList.SelectedIndex = -1;
            }
        }

        private void AdvSearchPort(int Mode, string SearchBy)
        {
            DataTable Port = new DataTable();
            Port = DBUtil.spMst_AdvSearchPort(SearchBy);

            if (Mode == 0)
            {
                PortList.DataSource = Port;
                PortList.DisplayMember = "name";
                PortList.ValueMember = "id";
            }
            else
            {
                DataTable Temp = new DataTable();
                Temp.Clear();
                Temp = Port.Select("name = '" + SearchBy + "'").CopyToDataTable();
                PortList.DataSource = Temp;
                PortList.DisplayMember = "name";
                PortList.ValueMember = "id";
            }
        }

        private void btnPrintTally_Click(object sender, EventArgs e)
        {
            int OBLID = 0;
            int ContID = 0;

            OBLID = Convert.ToInt32("0" + lblSysOBLID.Text.ToString().Trim());
            ContID = Convert.ToInt32("0" + lblContID.Text.ToString().Trim());

            TallySht TallyShtDlg = new TallySht(OBLID, ContID, UserID);
            TallyShtDlg.ShowDialog();
        }

        private void txtPackaging_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
