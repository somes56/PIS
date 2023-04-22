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
    public partial class CPList : Form
    {
        private int UserID = 0;

        public CPList(int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            AdvSearchCP(0, "");

            dgvCP.Columns[0].Name = "id";
            dgvCP.Columns[0].HeaderText = "Id";
            dgvCP.Columns[0].Visible = false;

            dgvCP.Columns[1].Name = "container_no";
            dgvCP.Columns[1].HeaderText = "Container No";

            dgvCP.Columns[2].Name = "scn";
            dgvCP.Columns[2].HeaderText = "Ship Call No";

            dgvCP.Columns[3].Name = "voyage_no";
            dgvCP.Columns[3].HeaderText = "Voyage No";

            dgvCP.Columns[4].Name = "vessel";
            dgvCP.Columns[4].HeaderText = "Vessel";

            dgvCP.Columns[5].Name = "cust";
            dgvCP.Columns[5].HeaderText = "Customer";
        }

        public void AdvSearchCP(int SearchMode, string SearchBy)
        {
            try
            {
                DataTable CP = new DataTable();
                CP = DBUtil.AdvSearchCP(SearchMode, SearchBy);
                dgvCP.DataSource = CP;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR : " + e.ToString());
                return;
            }
        }

        private void txtContSearch_TextChanged(object sender, EventArgs e)
        {
            string SearchBy = txtContSearch.Text.ToString().Trim();

            if (SearchBy.Length > 0) AdvSearchCP(1, SearchBy); else AdvSearchCP(0, "");
        }

        private void txtCustSearch_TextChanged(object sender, EventArgs e)
        {
            string SearchBy = txtCustSearch.Text.ToString().Trim();

            if (SearchBy.Length > 0) AdvSearchCP(2, SearchBy); else AdvSearchCP(0, "");
        }

        private void txtContSearch_Enter(object sender, EventArgs e)
        {
            txtCustSearch.ResetText();
        }

        private void txtCustSearch_Enter(object sender, EventArgs e)
        {
            txtContSearch.ResetText();
        }

        private void dgvCP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());

            if (currow > -1)
            {
                if (!string.IsNullOrEmpty(txtContSearch.Text.ToString().Trim()))
                {
                    var SearchBy = txtContSearch.Text.Trim();
                    int CPID = Convert.ToInt32(dgvCP[0, currow].Value.ToString());
                    CPAED CPAED = new CPAED(UserID, CPID);
                    CPAED.ShowDialog();
                    AdvSearchCP(1, SearchBy);
                }
                else if (!string.IsNullOrEmpty(txtCustSearch.Text.ToString().Trim()))
                {
                    var SearchBy = txtCustSearch.Text.Trim();
                    int CPID = Convert.ToInt32(dgvCP[0, currow].Value.ToString());
                    CPAED CPAED = new CPAED(UserID, CPID);
                    CPAED.ShowDialog();
                    AdvSearchCP(2, SearchBy);
                }
                else
                {
                    int CPID = Convert.ToInt32(dgvCP[0, currow].Value.ToString());
                    CPAED CPAED = new CPAED(UserID, CPID);
                    CPAED.ShowDialog();
                    AdvSearchCP(0, "");
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContSearch.Text.ToString().Trim()))
            {
                var SearchBy = txtContSearch.Text.Trim();
                CPAED CPAED = new CPAED(UserID, 0);
                CPAED.ShowDialog();
                AdvSearchCP(1, SearchBy);
            }
            else if (!string.IsNullOrEmpty(txtCustSearch.Text.ToString().Trim()))
            {
                var SearchBy = txtCustSearch.Text.Trim();
                CPAED CPAED = new CPAED(UserID, 0);
                CPAED.ShowDialog();
                AdvSearchCP(2, SearchBy);
            }
            else
            {
                CPAED CPAED = new CPAED(UserID, 0);
                CPAED.ShowDialog();
                AdvSearchCP(0, "");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
