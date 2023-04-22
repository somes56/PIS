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
    public partial class ExportReports : Form
    {
        public int UserID = 0;

        public ExportReports(int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            AdvSearchK5Container("~!");
        }

        private void AdvSearchK5Container(string SearchBy)
        {
            DataTable Container = new DataTable();
            Container = DBUtil.AdvSearchCPContainer(SearchBy);

            K5ContainerList.DataSource = Container;
            K5ContainerList.DisplayMember = "container_no";
            K5ContainerList.ValueMember = "id";
        }

        private void txtK5SearchContainer_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtK5SearchContainer.Text.ToString().Trim();

            if (SearchBy.Length != 0)
            {
                AdvSearchK5Container(SearchBy);
            }
            else
            {
                AdvSearchK5Container("~!");
            }
        }

        private void btnGenerateDailyRpt_Click(object sender, EventArgs e)
        {
            string DateFrom = DtDailyFrom.Value.ToString("yyyy-MM-dd");
            string DateTo = DtDailyTo.Value.ToString("yyyy-MM-dd");

            DailyRpt DailyRpt = new DailyRpt(DateFrom, DateTo, UserID);
            DailyRpt.ShowDialog();
        }

        private void btnGenerateK5Rpt_Click(object sender, EventArgs e)
        {
            int CPID = 0;

            if (K5ContainerList.SelectedIndex > -1)
            {
                CPID = Convert.ToInt32(K5ContainerList.SelectedValue.ToString().Trim());
                K5Rpt K5RptDlg = new K5Rpt(CPID,UserID);
                K5RptDlg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Container Selection is required.", "Warning !");
            }
        }

        private void btnGenerateTeusRpt_Click(object sender, EventArgs e)
        {
            var DateFrom = "";
            var DateTo = "";

            DateFrom = DtTeFrom.Value.ToString("yyyy-MM-dd");
            DateTo = DtTeTo.Value.ToString("yyyy-MM-dd");
            K5TeusRpt K5TeusRpt = new K5TeusRpt(DateFrom, DateTo, UserID);
            K5TeusRpt.ShowDialog();
        }
    }
}
