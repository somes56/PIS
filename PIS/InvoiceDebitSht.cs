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
    public partial class InvoiceDebitSht : Form
    {
        private int UserID = 0;

        public InvoiceDebitSht(int DebitID, string Amount, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptDebitSht rptDebit = new RptDebitSht();
            rptDebit.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptDebit.SetDataSource(DBUtil.LoadDebitSheet(DebitID, Amount, UserID));
            DebitNoteViewer.ReportSource = rptDebit;
            DebitNoteViewer.Refresh();
        }

        private void InvoiceDebitSht_Load(object sender, EventArgs e)
        {

        }
    }
}
