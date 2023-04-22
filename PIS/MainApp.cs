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
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {

            
              
      

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {


            //CustList custdlg = new CustList();
            //custdlg.ShowDialog();

        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            ItemCodeList itemdlg = new ItemCodeList(0);
            itemdlg.ShowDialog();
        }

        private void btInvoice_Click(object sender, EventArgs e)
        {
            InvoiceMain invmain = new InvoiceMain();
            invmain.ShowDialog();
        }

    }
}
