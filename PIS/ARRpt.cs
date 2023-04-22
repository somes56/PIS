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
    public partial class ARRpt : Form
    {
        private int UserID = 0;

        public ARRpt(string Rpt, string DateFrom, string DateTo, int Payment, int Customer, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptAR rptAR = new RptAR();
            rptAR.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptAR.SetDataSource(DBUtil.LoadARInvoiceReport(Rpt, DateFrom, DateTo, Payment, Customer));
            this.ARRptViewer.ReportSource = rptAR;
            this.ARRptViewer.Refresh();

        }
    }
}
