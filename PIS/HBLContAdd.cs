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
    public partial class HBLContAdd : Form
    {
        public HBLContAdd(int OBLID, int HBLID)
        {
            InitializeComponent();

            lblHBLID.Text = HBLID.ToString();

            AdvSearchHBLContainers(OBLID);

            dgvContAdd.Columns[0].Name = "id";
            dgvContAdd.Columns[0].HeaderText = "ID";
            dgvContAdd.Columns[0].Visible = false;

            dgvContAdd.Columns[1].Name = "container_no";
            dgvContAdd.Columns[1].HeaderText = "Container";
        }

        private void AdvSearchHBLContainers(int OBLID)
        {
            try
            {
                DataTable HBLContainers = new DataTable();
                HBLContainers = DBUtil.AdvSearchHBLContainers(OBLID,0);

                dgvContAdd.DataSource = HBLContainers;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail To Load Container List." + e.Message, "Error");
                return;
            }
        }

        private void dgvContAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());

            if (currow > -1)
            {
                int ContID = Convert.ToInt32(dgvContAdd[0, currow].Value);
                var ContNo = dgvContAdd[1, currow].Value;

                var Exist = "";
                Exist = CheckExist(ContID,Convert.ToInt32(lblHBLID.Text.Trim()));

                var rtn = "";

                if (Exist != "Y")
                {
                    DialogResult dlgResult = MessageBox.Show("Are you sure?", "Add this Container?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlgResult == DialogResult.Yes)
                    {
                        // Yes, continue 
                    }
                    else if (dlgResult == DialogResult.No)
                    {
                        return;
                    }

                    rtn = DBUtil.UpsertHBLContainers(ContID, Convert.ToInt32(lblHBLID.Text.Trim()));

                    if (rtn == "OK")
                    {
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(rtn, "Error");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Container : " + ContNo + " is in the List", "Warning");
                    return;
                }
            }
        }

        private string CheckExist(int ContID, int HBLID)
        {
            var rtn = "";

            rtn = DBUtil.CheckContExist(ContID, HBLID);

            return rtn;
        }
    }
}
