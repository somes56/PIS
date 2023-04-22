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
    public partial class BillAED : Form
    {
        public int UserID = 0;

        public BillAED(int OBLID, int HBLID, int ContID, int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            AdvSearchUnit("~!");
            AdvSearchConsignee("~!");
            AdvSearchClass(0,"~!");
            AdvSearchPort(0, "~!");

            if (HBLID != 0)
            {
                lblOBLID.Text = OBLID.ToString();
                lblHBLID.Text = HBLID.ToString();
                lblContID.Text = ContID.ToString();

                LoadHBL(HBLID);
                DisableEdit();
            }
            else
            {
                lblOBLID.Text = OBLID.ToString();
                lblHBLID.Text = "0";
                lblContID.Text = ContID.ToString();

                EnableEdit();
            }
        }

        private void BillAED_Load(object sender, EventArgs e)
        {

        }

        private void AdvSearchUnit(string SearchBy)
        {
            DataTable Unit = new DataTable();
            Unit = DBUtil.spMst_AdvSearchUnit(SearchBy);

            UnitList.DataSource = Unit;
            UnitList.DisplayMember = "shortname";
            UnitList.ValueMember = "id";
        }

        private void AdvSearchConsignee(string SearchBy)
        {
            DataTable Consignee = new DataTable();
            Consignee = DBUtil.spMst_AdvSearchCustomer(SearchBy);

            ConsigneeList.DataSource = Consignee;
            ConsigneeList.DisplayMember = "name";
            ConsigneeList.ValueMember = "id";
        }

        private void AdvSearchClass(int Mode, string SearchBy)
        {
            DataTable Class = new DataTable();
            Class = DBUtil.spMst_AdvSearchClass(SearchBy);

            if (Mode == 0)
            {
                ClassList.DataSource = Class;
                ClassList.DisplayMember = "fullname";
                ClassList.ValueMember = "id";
            }
            else
            {
                DataTable Temp = new DataTable();
                Temp.Clear();
                Temp = Class.Select("fullname = '" + SearchBy + "'").CopyToDataTable();
                ClassList.DataSource = Temp;
                ClassList.DisplayMember = "fullname";
                ClassList.ValueMember = "id";
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

        private void txtSearchUnitID_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchUnitID.Text.Trim();

            if (SearchBy.Length != 0)
            {
                UnitList.Focus();
                AdvSearchUnit(SearchBy);
            }
            else
            {
                AdvSearchUnit("NONE");
            }
        }

        private void txtSearchConsignee_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchConsignee.Text.Trim();

            if (SearchBy.Length != 0)
            {
                ConsigneeList.Focus();
                AdvSearchConsignee(SearchBy);
            }
            else
            {
                AdvSearchConsignee("~!");
            }
        }

        private void txtSearchClassCode_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchClassCode.Text.Trim();

            if (SearchBy.Length != 0)
            {
                ClassList.Focus();
                AdvSearchClass(0,SearchBy);
            }
            else
            {
                AdvSearchClass(0,"NONE");
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

        private void txtGoodsQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void EnableEdit()
        {
            pnlEdit.Visible = false;
            pnlSave.Visible = true;

            txtHouseBillNo.ReadOnly = false;

            txtCargoDesc.ReadOnly = false;

            txtSearchUnitID.ReadOnly = false;
            txtUnit.Visible = false;
            UnitList.Visible = true;

            txtSearchConsignee.ReadOnly = false;
            txtConsignee.Visible = false;
            ConsigneeList.Visible = true;

            rbShipmentNo.Enabled = true;
            rbShipmentYes.Enabled = true;

            txtMarking.ReadOnly = false;

            txtSearchClassCode.ReadOnly = false;
            txtClass.Visible = false;
            ClassList.Visible = true;

            txtGoodsQty.ReadOnly = false;
            txtVolume.ReadOnly = false;
            txtWeight.ReadOnly = false;

            if (rbShipmentYes.Checked == true)
            {
                txtSearchPort.ReadOnly = false;
                txtPort.Visible = false;
                PortList.Visible = true;
            }
        }

        private void DisableEdit()
        {
            pnlEdit.Visible = true;
            pnlSave.Visible = false;

            txtHouseBillNo.ReadOnly = true;

            txtCargoDesc.ReadOnly = true;

            txtSearchUnitID.ReadOnly = true;
            txtUnit.Visible = true;
            UnitList.Visible = false;

            txtSearchConsignee.ReadOnly = true;
            txtConsignee.Visible = true;
            ConsigneeList.Visible = false;

            rbShipmentNo.Enabled = false;
            rbShipmentYes.Enabled = false;

            txtMarking.ReadOnly = true;

            txtSearchClassCode.ReadOnly = true;
            txtClass.Visible = true;
            ClassList.Visible = false;

            txtGoodsQty.ReadOnly = true;
            txtVolume.ReadOnly = true;
            txtWeight.ReadOnly = true;

            txtSearchPort.ReadOnly = true;
            txtPort.Visible = true;
            txtPort.ReadOnly = true;
            PortList.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lblHBLID.Text == "0")
            {
                Close();
            }
            else
            {
                DisableEdit();
                LoadHBL(Convert.ToInt32(lblHBLID.Text.Trim()));
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            var rtn = "";
            int HBLID = 0;
            int ContID = 0;
            HBLID = Convert.ToInt32(lblHBLID.Text.Trim());
            ContID = Convert.ToInt32(lblContID.Text.Trim());

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                // Yes, continue 
            }
            else if (dlgResult == DialogResult.No)
            {
                return;
            }

            rtn = DBUtil.DelHBL(HBLID);

            if (rtn == "OK")
            {
                rtn = DBUtil.DelHBLContainers(HBLID,ContID);

                if (rtn == "OK")
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Fail to delete HBL from Container List , HBL : " + txtHouseBillNo.Text.Trim(), "Error");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Fail to delete House Bill , HBL : " + txtHouseBillNo.Text.Trim(), "Error");
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var rtn = "";

            //Validate Form
            if (txtHouseBillNo.Text == "")
            {
                MessageBox.Show("House Bill No must be entered");
                txtHouseBillNo.Focus();
                return;
            }

            if (txtCargoDesc.Text == "")
            {
                MessageBox.Show("Cargo Desc must be entered");
                txtCargoDesc.Focus();
                return;
            }

            if (UnitList.SelectedIndex == -1)
            {
                MessageBox.Show("Shipper must be entered");
                txtSearchUnitID.Focus();
                return;
            }

            if (ConsigneeList.SelectedIndex == -1)
            {
                MessageBox.Show("Consignee must be entered");
                txtSearchConsignee.Focus();
                return;
            }

            if (rbShipmentYes.Checked == false && rbShipmentNo.Checked == false)
            {
                MessageBox.Show("Transhipment must be entered");
                return;
            }

            if (txtMarking.Text == "")
            {
                MessageBox.Show("Marking must be entered");
                txtMarking.Focus();
                return;
            }

            if (ClassList.SelectedIndex == -1)
            {
                MessageBox.Show("Class must be entered");
                txtSearchClassCode.Focus();
                return;
            }

            if (txtGoodsQty.Text == "")
            {
                MessageBox.Show("Quantity must be entered");
                txtGoodsQty.Focus();
                return;
            }

            if (txtWeight.Text == "")
            {
                MessageBox.Show("Weight must be entered");
                txtWeight.Focus();
                return;
            }

            if (txtVolume.Text == "")
            {
                MessageBox.Show("Volume must be entered");
                txtVolume.Focus();
                return;
            }

            if (rbShipmentYes.Checked)
            {
                if (PortList.SelectedIndex == -1)
                {
                    MessageBox.Show("Port must be entered");
                    txtSearchPort.Focus();
                    return;
                }
            }

            //Assign to variables
            int HBLID = Convert.ToInt32(lblHBLID.Text.ToString().Trim());
            var HBLNo = txtHouseBillNo.Text.Trim();
            int OBLID = Convert.ToInt32(lblOBLID.Text.Trim());
            int ContID = Convert.ToInt32(lblContID.Text.Trim());
            var CargoDesc = txtCargoDesc.Text.Trim();
            int Unit = Convert.ToInt32(UnitList.SelectedValue);
            int Consignee = Convert.ToInt32(ConsigneeList.SelectedValue);
            var Remarks = "";
            int InwardSurvey = 0;
            var Marking = txtMarking.Text.Trim();
            int Transhipment = 0;
            int Port = 0;
            var Packaging = "";
            var Location = "";
            int Class = Convert.ToInt32(ClassList.SelectedValue);
            int GoodQty = Convert.ToInt32(txtGoodsQty.Text.Trim());
            decimal Weight = Convert.ToDecimal(txtWeight.Text.Trim().ToString());
            decimal Volume = Convert.ToDecimal(txtVolume.Text.Trim());
            int uuser = UserID;

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

            rtn = DBUtil.spPIS_UpsertHBL(HBLID, HBLNo, OBLID, ContID, CargoDesc, Unit, Consignee, Remarks, InwardSurvey,
                                        Marking, Transhipment, Port, Packaging, Location, Class, GoodQty, Weight, Volume, uuser);

            if (rtn == "OK")
            {
                DisableEdit();

                int NewID = 0;
                NewID = DBUtil.GetHBLID(HBLNo);
                lblHBLID.Text = NewID.ToString();

                if (NewID != 0)
                {
                    //MessageBox.Show("HBL ID : " + NewID + "");
                    LoadHBL(NewID);
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
                    Port = dr["port"].ToString();
                    Packaging = (string)dr["packaging"];
                    Location = dr["location"].ToString();
                    Class = (string)dr["fullname"];
                    GoodQty = Convert.ToInt32(dr["goods_qty"]);
                    Weight = Convert.ToDecimal(dr["weight"]);
                    Volume = Convert.ToDecimal(dr["volume"]);
                    
                    
                }

                lblOBLID.Text = OBLID.ToString();
                lblHBLID.Text = ID.ToString();

                txtHouseBillNo.Text = HBLNo;

                txtCargoDesc.Text = CargoDesc;

                txtSearchUnitID.Text = Unit;
                txtUnit.Text = Unit;
                AdvSearchUnit(Unit);

                txtSearchConsignee.Text = Consignee;
                txtConsignee.Text = Consignee;
                AdvSearchConsignee(Consignee);

                txtMarking.Text = Marking;

                txtSearchClassCode.Text = Class;
                txtClass.Text = Class;
                AdvSearchClass(1,Class);

                txtGoodsQty.Text = GoodQty.ToString();

                txtWeight.Text = Weight.ToString();

                txtVolume.Text = Volume.ToString();

                if (Transhipment == 0)
                {
                    rbShipmentNo.Checked = true;
                    txtSearchPort.Text = "";
                    txtPort.Text = "";
                    AdvSearchPort(0, "~!");
                }
                else if (Transhipment == 1)
                {
                    rbShipmentYes.Checked = true;
                    txtSearchPort.Text = Port;
                    txtPort.Text = Port;
                    AdvSearchPort(1, Port.ToString());
                }
                else
                {
                    rbShipmentYes.Checked = false;
                    rbShipmentNo.Checked = false;
                    txtSearchPort.Text = "";
                    txtPort.Text = "";
                    AdvSearchPort(0, "~!");
                }
            }
        }

        private void rbShipmentYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShipmentYes.Checked == true)
            {
                txtSearchPort.ReadOnly = false;
                txtPort.Visible = false;
                PortList.Visible = true;
            }
            else
            {
                txtSearchPort.ResetText();
                txtSearchPort.ReadOnly = true;
                txtPort.Visible = true;
                txtPort.ResetText();
                txtPort.ReadOnly = true;
                PortList.Visible = false;
            }
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            CustAED CustAED = new CustAED(1, 0, UserID);
            CustAED.ShowDialog();
        }
    }
}
