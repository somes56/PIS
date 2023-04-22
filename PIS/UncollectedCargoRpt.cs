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
    public partial class UncollectedCargoRpt : Form
    {
        private int UserID = 0;

        public UncollectedCargoRpt(string DateFrom, string DateTo, int AgentID, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptUncollectedCargo rptUncollectedCargo = new RptUncollectedCargo();
            rptUncollectedCargo.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptUncollectedCargo.SetDataSource(DBUtil.LoadUncollectedCargoReport(DateFrom, DateTo, AgentID));
            this.UncollectedCargoRptViewer.ReportSource = rptUncollectedCargo;
            this.UncollectedCargoRptViewer.Refresh();
        }
    }
}
