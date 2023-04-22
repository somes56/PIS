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
    public partial class TeusRpt : Form
    {
        private int UserID = 0;

        public TeusRpt(string DateFrom, string DateTo, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptTeus rptTeus = new RptTeus();
            rptTeus.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptTeus.SetDataSource(DBUtil.LoadK4TeusReport(DateFrom, DateTo));
            this.TeusRptViewer.ReportSource = rptTeus;
            this.TeusRptViewer.Refresh();
        }
    }
}
