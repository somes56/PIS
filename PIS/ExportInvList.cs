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
    public partial class ExportInvList : Form
    {
        private int UserID = 0;

        public ExportInvList(int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            AdvSearchInvoice("");

            dgvInvoice.Columns[0].Name = "id";
            dgvInvoice.Columns[0].HeaderText = "Id";
            dgvInvoice.Columns[0].Visible = false;

            dgvInvoice.Columns[1].Name = "inv_no";
            dgvInvoice.Columns[1].HeaderText = "Invoice No";

            dgvInvoice.Columns[2].Name = "cfs_no";
            dgvInvoice.Columns[2].HeaderText = "CFS No";

            dgvInvoice.Columns[3].Name = "goods_qty";
            dgvInvoice.Columns[3].HeaderText = "Quantity";

            dgvInvoice.Columns[4].Name = "weight";
            dgvInvoice.Columns[4].HeaderText = "Weight";

            dgvInvoice.Columns[5].Name = "volume";
            dgvInvoice.Columns[5].HeaderText = "Volume";
        }

        public void AdvSearchInvoice(string SearchBy)
        {
            DataTable Invoice = new DataTable();
            Invoice = DBUtil.AdvSearchExportInvoice(SearchBy);
            int x = Invoice.Rows.Count;
            dgvInvoice.DataSource = Invoice;
        }

        private void tbSearchq_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";
            SearchBy = tbSearchq.Text.ToString().Trim();

            if (SearchBy.Length > 0)
            {
                AdvSearchInvoice(SearchBy);
            }
            else
            {
                AdvSearchInvoice("");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            ExportInvAED ExportInvAED = new ExportInvAED(0, UserID);
            ExportInvAED.ShowDialog();
            AdvSearchInvoice("");
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
                int InvoiceID = Convert.ToInt32(dgvInvoice[0, currow].Value.ToString());
                ExportInvAED InvoiceAED = new ExportInvAED(InvoiceID, UserID);
                InvoiceAED.ShowDialog();
                AdvSearchInvoice(SearchBy);
            }
        }
    }
}
