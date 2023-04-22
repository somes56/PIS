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
    public partial class InvoiceSht : Form
    {
        private int UserID = 0;

        public InvoiceSht(int InvID, string Amount, int LogID)
        {
            UserID = LogID;
            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptInvoiceSht rptInvoice = new RptInvoiceSht();
            rptInvoice.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptInvoice.SetDataSource(DBUtil.LoadInvoiceSheet(InvID, Amount, UserID));
            this.InvoiceShtViewer.ReportSource = rptInvoice;
            this.InvoiceShtViewer.Refresh();
        }
    }
}
