using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS
{
    public partial class MasterFileMenu : Form
    {
        private int UserID = 0;

        public MasterFileMenu(int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();
        }

        private void MasterFileMenu_Load(object sender, EventArgs e)
        {
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btVoyage_Click(object sender, EventArgs e)
        {
            VesselList vlistdlg = new VesselList(UserID);
            vlistdlg.ShowDialog();


          
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustList clistdlg = new CustList(UserID);
            clistdlg.ShowDialog();
        }

        private void btItem_Click(object sender, EventArgs e)
        {
            ItemCodeList itemdlg = new ItemCodeList(UserID);
            itemdlg.ShowDialog();

        }

        private void btnBankInfo_Click(object sender, EventArgs e)
        {
            BankList bnkdlg = new BankList();
            bnkdlg.ShowDialog();
        }

        private void btnPort_Click(object sender, EventArgs e)
        {
            PortList portdlg = new PortList(UserID);
            portdlg.ShowDialog();
        }

        private void btnCSize_Click(object sender, EventArgs e)
        {
            CSizeList czdlg = new CSizeList(UserID);
            czdlg.ShowDialog();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            ClassList classdlg = new ClassList(UserID);
            classdlg.ShowDialog();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            UnitList unitdlg = new UnitList(UserID);
            unitdlg.ShowDialog();
        }

        private void btVoyage_Click_1(object sender, EventArgs e)
        {
            VoyageList dlg = new VoyageList(UserID);
            dlg.ShowDialog();
        }

        private void btCalTarrif_Click(object sender, EventArgs e)
        {
            CalTariff dlg = new CalTariff();
            dlg.ShowDialog();
        }

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            CurrencyList currdlg = new CurrencyList(UserID);
            currdlg.ShowDialog();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LocList LocList = new LocList();
            LocList.ShowDialog();
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            OperatorList OperatorList = new OperatorList(UserID);
            OperatorList.ShowDialog();
        }
    }
}
