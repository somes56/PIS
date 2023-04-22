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
    public partial class LocAED : Form
    {
        public LocAED(int LocID)
        {
            InitializeComponent();

            if (LocID != 0)
            {
                DisableEdit();
                LoadMstLocation(LocID);
            }
            else
            {
                EnableEdit();
                lblLocID.Text = "0";
            }

        }

        private void LocAED_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ID = 0;
            int LocID = 0;
            var Code = "";
            int Port = 0;
            var rtn = "";

            LocID = Convert.ToInt32(lblLocID.Text.ToString().Trim());
            Code = txtLocCode.Text.Trim().ToString().ToUpper();

            if (rbPortWest.Checked)
            {
                Port = 0;
            }
            else if (rbPortNorth.Checked)
            {
                Port = 1;
            }

            rtn = DBUtil.UpsertMstLocation(LocID, Code, Port);

            if (rtn == "OK")
            {
                ID = DBUtil.GetLocID(Code);

                if (ID != -1)
                {
                    lblLocID.Text = ID.ToString();
                    DisableEdit();
                    LoadMstLocation(ID);
                }
                else
                {
                    MessageBox.Show("ERROR : System is unable to get register location id.");
                    return;
                }

            }
            else
            {
                MessageBox.Show("ERROR : System is unable to register new location.");
                return;
            }
        }

        private void LoadMstLocation(int ID)
        {
            int Port = 0;
            DataTable Location = new DataTable();
            Location = DBUtil.LoadMstLocation(ID);

            foreach (DataRow dr in Location.Rows)
            {
                lblLocID.Text = dr["id"].ToString();
                txtLocCode.Text = dr["code"].ToString();
                Port = Convert.ToInt32(dr["port"]);

                if (Port == 1)
                {
                    rbPortNorth.Checked = true;
                }
                else
                {
                    rbPortWest.Checked = true;
                }
            }

        }

        private void EnableEdit()
        {
            pnlEdit.Visible = false;
            pnlSave.Visible = true;

            txtLocCode.ReadOnly = false;

            rbPortNorth.Enabled = true;
            rbPortWest.Enabled = true;

        }

        private void DisableEdit()
        {
            pnlEdit.Visible = true;
            pnlSave.Visible = false;

            txtLocCode.ReadOnly = true;

            rbPortNorth.Enabled = false;
            rbPortWest.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableEdit();
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int ID = 0;
            int LocID = 0;
            var Code = "";
            int Port = 0;
            var rtn = "";

            LocID = Convert.ToInt32(lblLocID.Text.ToString().Trim());
            Code = txtLocCode.Text.Trim().ToString();

            if (rbPortWest.Checked)
            {
                Port = 0;
            }
            else if (rbPortNorth.Checked)
            {
                Port = 1;
            }


            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this Location?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                rtn = DBUtil.DelMstLocation(LocID);

                if (rtn == "OK")
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ERROR : System is unable to delete location master");
                    return;
                }
            }
            else if (dlgResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
