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
    public partial class K5TeusRpt : Form
    {
        private int UserID = 0;

        public K5TeusRpt(string DateFrom, string DateTo, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptK5Teus rptK5Teus = new RptK5Teus();
            rptK5Teus.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptK5Teus.SetParameterValue("DateFrom", DateFrom);
            rptK5Teus.SetParameterValue("DateTo", DateTo);
            this.K5TeusRptViewer.ReportSource = rptK5Teus;
            this.K5TeusRptViewer.Refresh();
        }
    }
}
