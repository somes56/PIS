using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace PIS
{
    public partial class InvoiceCreditSht : Form
    {
        private int UserID = 0;

        public InvoiceCreditSht(int CreditID, string Amount, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptCreditSht rptCredit = new RptCreditSht();
            rptCredit.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptCredit.SetDataSource(DBUtil.LoadCreditSheet(CreditID, Amount, UserID));
            CreditNoteViewer.ReportSource = rptCredit;
            CreditNoteViewer.Refresh();
        }

        private void InvoiceCreditSht_Load(object sender, EventArgs e)
        {

        }
    }
}
