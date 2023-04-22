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
    public partial class ImportInvList : Form
    {
        private int UserID = 0;

        public ImportInvList(int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            AdvSearchInvoice(0, "");

            dgvInvoice.Columns[0].Name = "id";
            dgvInvoice.Columns[0].HeaderText = "Id";
            dgvInvoice.Columns[0].Visible = false;

            dgvInvoice.Columns[1].Name = "inv_no";
            dgvInvoice.Columns[1].HeaderText = "Invoice No";

            dgvInvoice.Columns[2].Name = "hbl_no";
            dgvInvoice.Columns[2].HeaderText = "House Bill No";

            dgvInvoice.Columns[3].Name = "inv_date";
            dgvInvoice.Columns[3].HeaderText = "Invoice Date";
        }

        private void AdvSearchInvoice(int SearchType, string SearchBy)
        {
            try
            {
                DataTable Invoice = new DataTable();
                Invoice = DBUtil.AdvSearchInvoice(SearchType, SearchBy);

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
                AdvSearchInvoice(1, SearchBy);
            }
            else
            {
                AdvSearchInvoice(0, "");
            }
        }

        private void txtSearchHBL_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchHBL.Text.Trim();

            if (SearchBy.Length > 0)
            {
                AdvSearchInvoice(2, SearchBy);
            }
            else
            {
                AdvSearchInvoice(0, "");
            }
        }

        private void tbSearchq_Enter(object sender, EventArgs e)
        {
            txtSearchHBL.ResetText();
        }

        private void txtSearchHBL_Enter(object sender, EventArgs e)
        {
            tbSearchq.ResetText();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            ImportInvAED InvoiceAED = new ImportInvAED(0, UserID);
            InvoiceAED.ShowDialog();
            AdvSearchInvoice(0, "");
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());

            if (currow > -1)
            {
                if (tbSearchq.Text != "")
                {
                    var SearchBy = tbSearchq.Text.Trim();
                    int InvoiceID = Convert.ToInt32(dgvInvoice[0, currow].Value.ToString());
                    ImportInvAED InvoiceAED = new ImportInvAED(InvoiceID, UserID);
                    InvoiceAED.ShowDialog();
                    AdvSearchInvoice(1, SearchBy);
                }
                else if (txtSearchHBL.Text != "")
                {
                    var SearchBy = txtSearchHBL.Text.Trim();
                    int InvoiceID = Convert.ToInt32(dgvInvoice[0, currow].Value.ToString());
                    ImportInvAED InvoiceAED = new ImportInvAED(InvoiceID, UserID);
                    InvoiceAED.ShowDialog();
                    AdvSearchInvoice(2, SearchBy);
                }
                else
                {
                    int InvoiceID = Convert.ToInt32(dgvInvoice[0, currow].Value.ToString());
                    ImportInvAED InvoiceAED = new ImportInvAED(InvoiceID, UserID);
                    InvoiceAED.ShowDialog();
                    AdvSearchInvoice(0, "");
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
