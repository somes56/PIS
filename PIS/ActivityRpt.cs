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
    public partial class ActivityRpt : Form
    {
        private int UserID = 0;

        public ActivityRpt(int ContainerID, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptActivity rptActivity = new RptActivity();
            rptActivity.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptActivity.SetDataSource(DBUtil.LoadActivityReport(ContainerID, UserID));
            this.ActivityRptViewer.ReportSource = rptActivity;
            this.ActivityRptViewer.Refresh();
        }
    }
}
