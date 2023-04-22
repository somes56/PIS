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
    public partial class CreditList : Form
    {
        private int UserID = 0;

        public CreditList(int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();
        }

        private void CreditList_Load(object sender, EventArgs e)
        {
            AdvSearchCreditInvoice("");

            dgInvoice.Columns[0].Name = "id";
            dgInvoice.Columns[0].HeaderText = "Credit ID";
            dgInvoice.Columns[0].Visible = false;

            dgInvoice.Columns[1].Name = "cr_no";
            dgInvoice.Columns[1].HeaderText = "Credit No";

            dgInvoice.Columns[2].Name = "inv_no";
            dgInvoice.Columns[2].HeaderText = "Invoice No";

            dgInvoice.Columns[3].Name = "cr_date";
            dgInvoice.Columns[3].HeaderText = "Credit Date";
        }

        private void AdvSearchCreditInvoice(string SearchBy)
        {
            try
            {
                DataTable Invoice = new DataTable();
                Invoice = DBUtil.AdvSearchCreditInvoice(SearchBy);

                dgInvoice.DataSource = Invoice;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail To Load Credit List." + e.Message, "Error");
                return;
            }
        }
   
        private void tbSearchq_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = tbSearchq.Text.Trim();

            if (SearchBy.Length > 0)
            {
                AdvSearchCreditInvoice(SearchBy);
            }
            else
            {
                AdvSearchCreditInvoice("");
            }
        }

        private void dgInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());

            if (currow > -1)
            {
                var SearchBy = tbSearchq.Text.Trim();
                int CreditID = Convert.ToInt32(dgInvoice[0, currow].Value.ToString());
                CreditAED CreditAED = new CreditAED(CreditID, UserID);
                CreditAED.ShowDialog();
                AdvSearchCreditInvoice(SearchBy);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CreditAED CreditAED = new CreditAED(0, UserID);
            CreditAED.ShowDialog();
            AdvSearchCreditInvoice("");
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
