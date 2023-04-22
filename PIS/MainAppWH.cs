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
    public partial class MainAppWH : Form
    {
        private int UserID = 0;

        public MainAppWH(int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

        }

        private void MainAppWH_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btMasterFile_Click(object sender, EventArgs e)
        {

            MasterFileMenu menudlg = new MasterFileMenu(UserID);
            menudlg.ShowDialog();

        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            ItemCodeList itemdlg = new ItemCodeList(UserID);
            itemdlg.ShowDialog();
        }

        private void btInvoice_Click(object sender, EventArgs e)
        {
            InvoiceMain invmain = new InvoiceMain();
            invmain.ShowDialog();
        }

        private void btnOceanBill_Click(object sender, EventArgs e)
        {
            //OceanBillList OBLDlg = new OceanBillList();
            //OBLDlg.ShowDialog();
            OceanBill OBLDlg = new OceanBill(UserID);
            OBLDlg.ShowDialog();
        }

        private void btnUnstuffCargo_Click(object sender, EventArgs e)
        {
            UnstuffCargoList UnstuffList = new UnstuffCargoList(UserID);
            UnstuffList.ShowDialog();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            ImportInvList InvoiceList = new ImportInvList(UserID);
            InvoiceList.ShowDialog();
        }

        private void btnDebitNotes_Click(object sender, EventArgs e)
        {
            DebitList DebitList = new DebitList(UserID);
            DebitList.ShowDialog();
        }

        private void btnCreditNotes_Click(object sender, EventArgs e)
        {
            CreditList CreditList = new CreditList(UserID);
            CreditList.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchCont SearchCont = new SearchCont();
            SearchCont.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports Rpt = new Reports(UserID);
            Rpt.ShowDialog();
        }

        private void btCalTarrif_Click(object sender, EventArgs e)
        {
            CalTariff dlg = new CalTariff();
            dlg.ShowDialog();
        }

        private void btnCFS_Click(object sender, EventArgs e)
        {
            CFSList CFSListDlg = new CFSList(UserID);
            CFSListDlg.ShowDialog();
        }

        private void btnCP_Click(object sender, EventArgs e)
        {
            CPList CPListDlg = new CPList(UserID);
            CPListDlg.ShowDialog();
        }

        private void btnExportInvoice_Click(object sender, EventArgs e)
        {
            ExportInvList ExportInvList = new ExportInvList(UserID);
            ExportInvList.ShowDialog();
        }

        private void buttonExportReport_Click(object sender, EventArgs e)
        {
            ExportReports Rpt = new ExportReports(UserID);
            Rpt.ShowDialog();
        }
    }
}
