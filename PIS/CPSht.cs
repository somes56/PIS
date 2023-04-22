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
    public partial class CPSht : Form
    {
        public int UserID = 0;

        public CPSht(int CPID, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptCPSht rptCPSht = new RptCPSht();
            rptCPSht.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptCPSht.SetParameterValue("CPID", CPID);
            rptCPSht.SetParameterValue("UserID", UserID);
            CPShtViewer.ReportSource = rptCPSht;
            CPShtViewer.Refresh();
        }
    }
}
