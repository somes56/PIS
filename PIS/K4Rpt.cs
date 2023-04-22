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
    public partial class K4Rpt : Form
    {
        private int UserID = 0;

        public K4Rpt(int ContainerID, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptK4 rptK4 = new RptK4();
            rptK4.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptK4.SetDataSource(DBUtil.LoadK4Report(ContainerID, UserID));
            this.K4RptViewer.ReportSource = rptK4;
            this.K4RptViewer.Refresh();
        }
    }
}
