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
    public partial class OperatorAED : Form
    {
        private int UserID = 0;

        public OperatorAED(int OperatorID, int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();

            if (OperatorID > 0)
            {
                DisableEdit();
                lblOperatorID.Text = OperatorID.ToString();
                LoadOperator(OperatorID);
            }
            else
            {
                EnableEdit();
            }

        }

        private void LoadOperator(int OperatorID)
        {
            DataTable Operator = new DataTable();
            Operator = DBUtil.LoadMstOperator(OperatorID);

            txtOperatorCode.Text = Operator.Rows[0]["code"].ToString().Trim();
            txtLinerName.Text = Operator.Rows[0]["liner_name"].ToString().Trim();
        }

        private void DisableEdit()
        {
            pnlSave.Visible = false;
            pnlEdit.Visible = true;

            txtOperatorCode.ReadOnly = true;
            txtLinerName.ReadOnly = true;
        }

        private void EnableEdit()
        {
            pnlSave.Visible = true;
            pnlEdit.Visible = false;

            txtOperatorCode.ReadOnly = false;
            txtLinerName.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int OperatorID = 0;
            int Insert = 0;
            var Update = "";

            OperatorID = Convert.ToInt32(lblOperatorID.Text);

            if (string.IsNullOrEmpty(txtOperatorCode.Text))
            {
                MessageBox.Show("Operator Code is required");
                return;
            }

            if (string.IsNullOrEmpty(txtLinerName.Text))
            {
                MessageBox.Show("Liner Name is required");
                return;
            }

            if (OperatorID > 0)
            {

                Update = DBUtil.UpdateMstOperator(OperatorID, txtOperatorCode.Text, txtLinerName.Text);

                if (Update == "OK")
                {
                    DisableEdit();
                    LoadOperator(OperatorID);
                }
                else
                {
                    MessageBox.Show("Operator Details is not successfully save");
                    return;
                }
            }
            else
            {
                Insert = DBUtil.UpsertMstOperator(txtOperatorCode.Text, txtLinerName.Text);

                if (Insert > 0)
                {
                    DisableEdit();
                    LoadOperator(Insert);
                    lblOperatorID.Text = Insert.ToString();
                }
                else
                {
                    MessageBox.Show("Operator Details is not successfully save");
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int OperatorID = 0;
            OperatorID = Convert.ToInt32(lblOperatorID.Text);

            if (OperatorID > 0)
            {
                DisableEdit();
            }
            else
            {
                this.Close();
            }
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
            int OperatorID = 0;
            var rtn = "";

            OperatorID = Convert.ToInt32("0" + lblOperatorID.Text.ToString().Trim());

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this Operator?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)
            {
                rtn = DBUtil.DelMstOperator(OperatorID);

                if (rtn != "ERROR") this.Close(); else MessageBox.Show("Delete is not successful", "Error"); return;
            }
            else
            {
                return;
            }
        }
    }
}
