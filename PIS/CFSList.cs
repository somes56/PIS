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
    public partial class CFSList : Form
    {
        private int UserID = 0;

        public CFSList(int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            AdvSearchCFS("");

            dgvCFS.Columns[0].Name = "id";
            dgvCFS.Columns[0].HeaderText = "Id";
            dgvCFS.Columns[0].Visible = false;

            dgvCFS.Columns[1].Name = "cfs_no";
            dgvCFS.Columns[1].HeaderText = "CFS No";

            dgvCFS.Columns[2].Name = "shipper";
            dgvCFS.Columns[2].HeaderText = "Shipper";

            dgvCFS.Columns[3].Name = "discharge_port";
            dgvCFS.Columns[3].HeaderText = "Discharge Port";

            dgvCFS.Columns[4].Name = "final_port";
            dgvCFS.Columns[4].HeaderText = "Final Port";

            dgvCFS.Columns[5].Name = "qty";
            dgvCFS.Columns[5].HeaderText = "Quantity";

            dgvCFS.Columns[6].Name = "weight";
            dgvCFS.Columns[6].HeaderText = "Weight";

            dgvCFS.Columns[7].Name = "volume";
            dgvCFS.Columns[7].HeaderText = "Volume";

        }

        public void AdvSearchCFS(string SearchBy)
        {
            try
            {
                DataTable CFS = new DataTable();
                CFS = DBUtil.AdvSearchCFS(SearchBy);
                dgvCFS.DataSource = CFS;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR : " + e.ToString());
                return;
            }
        }

        private void txtCFSSearch_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";
            SearchBy = txtCFSSearch.Text.ToString().Trim();

            if (SearchBy.Length > 0)
            {
                AdvSearchCFS(SearchBy);
            }
            else
            {
                AdvSearchCFS("");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var SearchBy = txtCFSSearch.Text.Trim();
            CFSAED CFSAED = new CFSAED(UserID, 0);
            CFSAED.ShowDialog();
            AdvSearchCFS(SearchBy);
        }

        private void dgvCFS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());

            if (currow > -1)
            {
                var SearchBy = txtCFSSearch.Text.Trim();
                int CFSID = Convert.ToInt32(dgvCFS[0, currow].Value.ToString());
                CFSAED CFSAED = new CFSAED(UserID, CFSID);
                CFSAED.ShowDialog();
                AdvSearchCFS(SearchBy);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
