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
    public partial class DebitList : Form
    {
        private int UserID = 0;
        public DebitList(int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();
        }

        private void DebitList_Load(object sender, EventArgs e)
        {
            AdvSearchDebitInvoice("");

            dgvInvoice.Columns[0].Name = "id";
            dgvInvoice.Columns[0].HeaderText = "Credit ID";
            dgvInvoice.Columns[0].Visible = false;

            dgvInvoice.Columns[1].Name = "dr_no";
            dgvInvoice.Columns[1].HeaderText = "Debit No";

            dgvInvoice.Columns[2].Name = "inv_no";
            dgvInvoice.Columns[2].HeaderText = "Invoice No";

            dgvInvoice.Columns[3].Name = "dr_date";
            dgvInvoice.Columns[3].HeaderText = "Debit Date";
        }

        private void AdvSearchDebitInvoice(string SearchBy)
        {
            try
            {
                DataTable Invoice = new DataTable();
                Invoice = DBUtil.AdvSearchDebitInvoice(SearchBy);

                dgvInvoice.DataSource = Invoice;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail To Load Invoice List." + e.Message, "Error");
                return;
            }
        }

        private void tbSearchq_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = tbSearchq.Text.Trim();

            if (SearchBy.Length > 0)
            {
                AdvSearchDebitInvoice(SearchBy);
            }
            else
            {
                AdvSearchDebitInvoice("");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DebitAED DebitAED = new DebitAED(0, UserID);
            DebitAED.ShowDialog();
            AdvSearchDebitInvoice("");
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());

            if (currow > -1)
            {
                var SearchBy = tbSearchq.Text.Trim();
                int DebitID = Convert.ToInt32(dgvInvoice[0, currow].Value.ToString());
                DebitAED DebitAED = new DebitAED(DebitID, UserID);
                DebitAED.ShowDialog();
                AdvSearchDebitInvoice(SearchBy);
            }
        }
    }
}
