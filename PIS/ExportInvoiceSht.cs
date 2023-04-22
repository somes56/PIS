using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PIS
{
    public partial class ExportInvoiceSht : Form
    {
        private int UserID = 0;

        public ExportInvoiceSht(int InvoiceID, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptExportInvoice RptExport = new RptExportInvoice();
            RptExport.SetDatabaseLogon(LoginID, Password, Server, Database);
            RptExport.SetParameterValue("InvoiceID", InvoiceID);
            RptExport.SetParameterValue("UserID", UserID);
            ExportInvoiceViewer.ReportSource = RptExport;
            ExportInvoiceViewer.Refresh();
        }
    }
}
