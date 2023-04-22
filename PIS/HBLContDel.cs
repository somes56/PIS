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
    public partial class HBLContDel : Form
    {
        public HBLContDel(int OBLID, int HBLID)
        {
            InitializeComponent();

            lblHBLID.Text = HBLID.ToString();

            AdvSearchHBLContainers(HBLID);

            dgvContDel.Columns[0].Name = "id";
            dgvContDel.Columns[0].HeaderText = "ID";
            dgvContDel.Columns[0].Visible = false;

            dgvContDel.Columns[1].Name = "container_no";
            dgvContDel.Columns[1].HeaderText = "Container";
        }

        private void AdvSearchHBLContainers(int HBLID)
        {
            try
            {
                DataTable HBLContainers = new DataTable();
                HBLContainers = DBUtil.AdvSearchHBLContainers(HBLID, 1);

                dgvContDel.DataSource = HBLContainers;
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

            var rtn = "";

            if (currow > -1)
            {
                int HBLContID = Convert.ToInt32(dgvContDel[0, currow].Value);
                var ContNo = dgvContDel[1, currow].Value;

                DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this Container?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    // Yes, continue 
                }
                else if (dlgResult == DialogResult.No)
                {
                    return;
                }

                rtn = DBUtil.DelHBLContainers(HBLContID,0);

                if (rtn == "OK")
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to remove " + ContNo + " from list", "Error");
                    Close();
                }
            }
        }
    }
}
