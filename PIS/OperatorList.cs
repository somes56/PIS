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
    public partial class OperatorList : Form
    {
        private int UserID = 0;

        public OperatorList(int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();

            AdvSearchOperator("");

            dgvOperator.Columns[0].Name = "id";
            dgvOperator.Columns[0].HeaderText = "Id";
            dgvOperator.Columns[0].Visible = false;

            dgvOperator.Columns[1].Name = "code";
            dgvOperator.Columns[1].HeaderText = "Code";

            dgvOperator.Columns[2].Name = "liner_name";
            dgvOperator.Columns[2].HeaderText = "Liner Name";
        }

        private void AdvSearchOperator(string SearchBy)
        {
            DataTable Operator = new DataTable();
            Operator = DBUtil.spMst_AdvSearchOperator(SearchBy);

            dgvOperator.DataSource = Operator;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperatorAED OperatorAED = new OperatorAED(0, UserID);
            OperatorAED.ShowDialog();
            AdvSearchOperator("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOperator_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());

            if (currow > -1)
            {
                var SearchBy = txtOperatorSearch.Text.Trim();
                int OperatorID = Convert.ToInt32(dgvOperator[0, currow].Value.ToString());
                OperatorAED OperatorAED = new OperatorAED(OperatorID, UserID);
                OperatorAED.ShowDialog();
                AdvSearchOperator(SearchBy);
            }
        }

        private void txtOperatorSearch_TextChanged(object sender, EventArgs e)
        {
            string SearchBy = "";
            SearchBy = txtOperatorSearch.Text.ToString().Trim();

            if (SearchBy.Length > 0)
            {
                AdvSearchOperator(SearchBy);
            }
            else
            {
                AdvSearchOperator("");
            }
        }
    }
}
