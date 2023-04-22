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
    public partial class K5Rpt : Form
    {
        private int UserID = 0;

        public K5Rpt(int CPID, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptK5 rptK5 = new RptK5();
            rptK5.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptK5.SetParameterValue("CPID", CPID);
            rptK5.SetParameterValue("LogID", LogID);
            this.K5RptViewer.ReportSource = rptK5;
            this.K5RptViewer.Refresh();
        }
    }
}
