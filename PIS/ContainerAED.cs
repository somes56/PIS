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
    public partial class ContainerAED : Form
    {
        public int UserID = 0;

        public ContainerAED(int OBLID, int OBLContID, int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            AdvSearchSize("NONE");

            if (OBLContID != 0)
            {
                LoadOBLContainers(OBLContID);
                DisableEdit();

                lblOBlID.Text = OBLID.ToString();
                lblContID.Text = OBLContID.ToString();
            }
            else
            {
                lblOBlID.Text = OBLID.ToString();
                lblContID.Text = "0";

                EnableEdit();
            }
        }


        private void ContainerAED_Load(object sender, EventArgs e)
        {

        }

        private void AdvSearchSize(string SearchBy)
        {
            DataTable Size = new DataTable();
            Size = DBUtil.spMst_AdvSearchSize(SearchBy);

            ContainerSizeList.DataSource = Size;
            ContainerSizeList.DisplayMember = "name";
            ContainerSizeList.ValueMember = "id";
        }

        private void txtSearchSize_Leave(object sender, EventArgs e)
        {
            var SearchBy = txtSearchSize.Text.Trim();

            if (SearchBy.Length != 0)
            {
                ContainerSizeList.Focus();
                AdvSearchSize(SearchBy);
            }
            else
            {
                AdvSearchSize("NONE");
            }
        }

        private void EnableEdit()
        {
            pnlSave.Visible = true;
            pnlEdit.Visible = false;

            txtContainerNo.ReadOnly = false;

            txtSealNo.ReadOnly = false;

            txtSearchSize.ReadOnly = false;
            txtContainerSize.Visible = false;
            ContainerSizeList.Visible = true;

            pnlType.Enabled = true;
            pnlStatus.Enabled = true;
            pnlShipType.Enabled = true;
            pnlMovement.Enabled = true;
            pnlSealParty.Enabled = true;
            pnlSupp.Enabled = true;
        }

        private void DisableEdit()
        {
            pnlSave.Visible = false;
            pnlEdit.Visible = true;

            txtContainerNo.ReadOnly = true;

            txtSealNo.ReadOnly = true;

            txtSearchSize.ReadOnly = true;
            txtContainerSize.Visible = true;
            txtContainerSize.ReadOnly = true;
            ContainerSizeList.Visible = false;

            pnlType.Enabled = false;
            pnlStatus.Enabled = false;
            pnlShipType.Enabled = false;
            pnlMovement.Enabled = false;
            pnlSealParty.Enabled = false;
            pnlSupp.Enabled = false;
        }

        private void LoadOBLContainers(int ContID)
        {
            int ID = 0;
            int OBLID = 0;
            var ContainerNo = "";
            var SealNo = "";
            int SizeID = 0;
            var Size = "";
            int Type = 0;
            int Status = 0;
            int Ship = 0;
            int Movement = 0;
            int SealParty = 0;
            int Supplier = 0;

            DataTable OBLContainers = new DataTable();
            OBLContainers = DBUtil.LoadOBLContainers(ContID);

            int count = 0;
            count = OBLContainers.Rows.Count;

            if (count == 1)
            {
                foreach (DataRow dr in OBLContainers.Rows)
                {
                    ID = Convert.ToInt32(dr["id"]);
                    OBLID = Convert.ToInt32(dr["obl_id"]);
                    ContainerNo = (string)dr["container_no"];
                    SealNo = (string)dr["seal_no"];
                    SizeID = Convert.ToInt32(dr["size_id"]);
                    Size = (string)dr["size"];
                    Type = Convert.ToInt32(dr["type"]);
                    Status = Convert.ToInt32(dr["status"]);
                    Ship = Convert.ToInt32(dr["ship"]);
                    Movement = Convert.ToInt32(dr["movement"]);
                    SealParty = Convert.ToInt32(dr["seal_party"]);
                    Supplier = Convert.ToInt32(dr["supplier"]);
                }

                int LabelCont = Convert.ToInt32(lblContID.Text);
                int LabelOBL = Convert.ToInt32(lblOBlID.Text);

                LabelCont = ID;
                LabelOBL = OBLID;

                txtContainerNo.Text = ContainerNo;

                txtSealNo.Text = SealNo;

                txtSearchSize.Text = Size;
                txtContainerSize.Text = Size;
                AdvSearchSize(Size);


                //ContainerType
                if (Type == 0)
                {
                    rbTypeContainer.Checked = true;
                }
                else if (Type == 1)
                {
                    rbTypeBreakBulk.Checked = true;
                }
                else if (Type == 2)
                {
                    rbTypeBulkCargo.Checked = true;
                }
                else if (Type == 3)
                {
                    rbTypeBondedTruck.Checked = true;
                }
                else
                {
                    rbTypeContainer.Checked = false;
                    rbTypeBreakBulk.Checked = false;
                    rbTypeBulkCargo.Checked = false;
                    rbTypeBondedTruck.Checked = false;
                }

                //ContainerStatus
                if (Status == 0)
                {
                   rbStatusEmpty.Checked = true ;
                }
                else if (Status == 1)
                {
                    rbStatusFull.Checked = true;
                }
                else
                {
                    rbStatusEmpty.Checked = false;
                    rbStatusFull.Checked = false;
                }

                //Ship Type
                if (Ship == 0)
                {
                    rbShipTypeLCL.Checked = true;
                }
                else if (Ship == 1)
                {
                    rbShipTypeFCL.Checked = true;
                }
                else if (Ship == 2)
                {
                    rbShipTypeCoLoad.Checked = true;
                }
                else
                {
                    rbShipTypeLCL.Checked = false;
                    rbShipTypeFCL.Checked = false;
                    rbShipTypeCoLoad.Checked = false;
                }

                //Movement
                if (Movement == 0)
                {
                    rbMoveExport.Checked = true;
                }
                else if (Movement == 1)
                {
                    rbMoveImport.Checked = true;
                }
                else if (Movement == 2)
                {
                    rbMoveRBoard.Checked = true;
                }
                else if (Movement == 3)
                {
                    rbMoveTShip.Checked = true;
                }
                else if (Movement == 4)
                {
                    rbMoveTRail.Checked = true;
                }
                else
                {
                    rbMoveExport.Checked = false;
                    rbMoveImport.Checked = false;
                    rbMoveRBoard.Checked = false;
                    rbMoveTShip.Checked = false;
                    rbMoveTRail.Checked = false;
                }

                //SealParty
                if (SealParty == 0)
                {
                   rbSealPartyCarrier.Checked = true;
                }
                else if (SealParty == 1)
                {
                    rbSealPartyShipper.Checked = true;
                }
                else if (SealParty == 2)
                {
                    rbSealPartyTOperator.Checked = true;
                }
                else if (SealParty == 3)
                {
                    rbSealPartyCustom.Checked = true;
                }
                else
                {
                    rbSealPartyCarrier.Checked = false;
                    rbSealPartyShipper.Checked = false;
                    rbSealPartyTOperator.Checked = false;
                    rbSealPartyCustom.Checked = false;
                }

                //Supplier
                if (Supplier == 0)
                {
                    rbSuppContractor.Checked = true;
                }
                else if (Supplier == 1)
                {
                    rbSuppPortOperator.Checked = true;
                }
                else
                {
                    rbSuppContractor.Checked = false;
                    rbSuppPortOperator.Checked = false;
                }



            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Submit Validation

            if (txtContainerNo.Text == "")
            {
                MessageBox.Show("Container No must be entered");
                txtContainerNo.Focus();
                return;
            }

            if (txtSealNo.Text == "")
            {
                MessageBox.Show("Seal No must be entered");
                txtSealNo.Focus();
                return;
            }

            if (ContainerSizeList.SelectedIndex == -1)
            {
                MessageBox.Show("Container Size must be entered");
                txtSearchSize.Focus();
                return;
            }

            if (rbTypeContainer.Checked == false && rbTypeBreakBulk.Checked == false && rbTypeBulkCargo.Checked == false &&  rbTypeBondedTruck.Checked == false)
            {
                MessageBox.Show("Type of Container must be entered");
                return;
            }

            if (rbStatusEmpty.Checked == false && rbStatusFull.Checked == false)
            {
                MessageBox.Show("Status of Container must be entered");
                return;
            }

            if (rbShipTypeLCL.Checked == false && rbShipTypeFCL.Checked == false && rbShipTypeCoLoad.Checked == false)
            {
                MessageBox.Show("Ship Type must be entered");
                return;
            }

            if (rbMoveExport.Checked == false && rbMoveImport.Checked == false && rbMoveRBoard.Checked == false && rbMoveTRail.Checked == false && rbMoveTShip.Checked == false)
            {
                MessageBox.Show("Movement must be entered");
                return;
            }

            if (rbSealPartyCarrier.Checked == false && rbSealPartyCustom.Checked == false && rbSealPartyShipper.Checked == false && rbSealPartyTOperator.Checked == false)
            {
                MessageBox.Show("Seal Party must be entered");
                return;
            }

            if (rbSuppContractor.Checked == false && rbSuppPortOperator.Checked == false)
            {
                MessageBox.Show("Supplier must be entered");
                return;
            }

            //Assign variables
            int ContID = Convert.ToInt32(lblContID.Text.ToString().Trim());
            int OBLID = Convert.ToInt32(lblOBlID.Text.Trim());
            var ContainerNo = txtContainerNo.Text;
            var SealNo = txtSealNo.Text;
            int SizeID = Convert.ToInt32(ContainerSizeList.SelectedValue);
            int Type = 0;
            int Status = 0;
            int Ship = 0;
            int Movement = 0;
            int SealParty = 0;
            int Supplier = 0;
            var rtn = "";

            //ContainerType
            if (rbTypeContainer.Checked == true)
            {
                Type = 0;
            }
            else if (rbTypeBreakBulk.Checked == true)
            {
                Type = 1;
            }
            else if (rbTypeBulkCargo.Checked == true)
            {
                Type = 2;
            }
            else if (rbTypeBondedTruck.Checked == true)
            {
                Type = 3;
            }

            //ContainerStatus
            if (rbStatusEmpty.Checked == true)
            {
                Status = 0;
            }
            else if (rbStatusFull.Checked == true)
            {
                Status = 1;
            }

            //Ship Type
            if (rbShipTypeLCL.Checked == true)
            {
                Ship = 0;
            }
            else if (rbShipTypeFCL.Checked == true)
            {
                Ship = 1;
            }
            else if (rbShipTypeCoLoad.Checked == true)
            {
                Ship = 2;
            }

            //Movement
            if (rbMoveExport.Checked == true)
            {
                Movement = 0;
            }
            else if (rbMoveImport.Checked == true)
            {
                Movement = 1;
            }
            else if (rbMoveRBoard.Checked == true)
            {
                Movement = 2;
            }
            else if (rbMoveTShip.Checked == true)
            {
                Movement = 3;
            }
            else if (rbMoveTRail.Checked == true)
            {
                Movement = 4;
            }

            //SealParty
            if (rbSealPartyCarrier.Checked == true)
            {
                SealParty = 0;
            }
            else if (rbSealPartyShipper.Checked == true)
            {
                SealParty = 1;
            }
            else if (rbSealPartyTOperator.Checked == true)
            {
                SealParty = 2;
            }
            else if (rbSealPartyCustom.Checked == true)
            {
                SealParty = 3;
            }

            //Supplier
            if (rbSuppContractor.Checked == true)
            {
                Supplier = 0;
            }
            else if (rbSuppPortOperator.Checked == true)
            {
                Supplier = 1;
            }

            rtn = DBUtil.UpsertOBLContainer(ContID, OBLID, ContainerNo, SealNo, SizeID, Type, Status, Ship, Movement, SealParty, Supplier, UserID);

            if (rtn == "OK")
            {
                DisableEdit();

                if (ContID == 0)
                {
                    ContID = DBUtil.GetContID(ContainerNo);
                    lblContID.Text = ContID.ToString();
                }
                LoadOBLContainers(ContID);
            }
            else
            {
                MessageBox.Show(rtn);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lblContID.Text == "0")
            {
                Close();
            }
            else
            {
                DisableEdit();
                //Load
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
            int ContID = 0;
            ContID = Convert.ToInt32(lblContID.Text.Trim());

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                
            }
            else if (dlgResult == DialogResult.No)
            {
                return;
            }

            rtn = DBUtil.DelOBLContainers(ContID);

            if (rtn == "OK")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Fail to delete Container, Container No : " + txtContainerNo.Text.Trim(), "Error");
                Close();
            }

        }
    }
}
