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
    public partial class TallySht : Form
    {
        public int UserID = 0;

        public TallySht(int OBLID, int ContID, int LogID)
        {
            UserID = LogID;

            InitializeComponent();

            var Server = ConfigurationManager.AppSettings["IP"].ToString();
            var LoginID = ConfigurationManager.AppSettings["LoginID"].ToString();
            var Password = ConfigurationManager.AppSettings["Password"].ToString();
            var Database = ConfigurationManager.AppSettings["DB"].ToString();

            RptTallySht rptTallySht = new RptTallySht();
            rptTallySht.SetDatabaseLogon(LoginID, Password, Server, Database);
            rptTallySht.SetDataSource(DBUtil.LoadContainerTallySheetOBLDetails(OBLID, ContID, UserID));
            TallyShtViewer.ReportSource = rptTallySht;
            TallyShtViewer.Refresh();
        }
    }
}
