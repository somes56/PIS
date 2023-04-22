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
    public partial class DailyRpt : Form
    {
        private int UserID = 0;

        public DailyRpt(string DateFrom, string DateTo, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptDaily rptDaily = new RptDaily();
            rptDaily.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptDaily.SetParameterValue("DateFrom", DateFrom);
            rptDaily.SetParameterValue("DateTo", DateTo);
            DailyRptViewer.ReportSource = rptDaily;
            DailyRptViewer.Refresh();
        }
    }
}
