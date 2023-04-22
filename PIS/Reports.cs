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
    public partial class Reports : Form
    {
        public int UserID = 0;

        public Reports(int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            AdvSearchActivityContainer("~!");

            AdvSearchK4Container("~!");

            AdvSearchCustomer("~!");
        }

        private void AdvSearchActivityContainer(string SearchBy)
        {
            DataTable Container = new DataTable();
            Container = DBUtil.AdvSearchContainer(SearchBy);

            ActivityContainerList.DataSource = Container;
            ActivityContainerList.DisplayMember = "container_no";
            ActivityContainerList.ValueMember = "id";
        }

        private void AdvSearchK4Container(string SearchBy)
        {
            DataTable Container = new DataTable();
            Container = DBUtil.AdvSearchContainer(SearchBy);

            K4ContainerList.DataSource = Container;
            K4ContainerList.DisplayMember = "container_no";
            K4ContainerList.ValueMember = "id";
        }

        private void AdvSearchCustomer(string SearchBy)
        {
            DataTable Customer = new DataTable();
            Customer = DBUtil.AdvSearchInvoiceConsignee(SearchBy);

            CustomerList.DataSource = Customer;
            CustomerList.DisplayMember = "name";
            CustomerList.ValueMember = "id";
        }

        private void AdvSearchAgent(string SearchBy)
        {
            DataTable Agent = new DataTable();
            Agent = DBUtil.spMst_AdvSearchCustomer(SearchBy);

            AgentList.DataSource = Agent;
            AgentList.DisplayMember = "name";
            AgentList.ValueMember = "id";
        }

        private void txtActivitySearchContainer_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtActivitySearchContainer.Text.ToString().Trim();

            if (SearchBy.Length != 0)
            {
                AdvSearchActivityContainer(SearchBy);
            }
            else
            {
                AdvSearchActivityContainer("~!");
            }
        }

        private void txtK4SearchContainer_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtK4SearchContainer.Text.ToString().Trim();

            if (SearchBy.Length != 0)
            {
                AdvSearchK4Container(SearchBy);
            }
            else
            {
                AdvSearchK4Container("~!");
            }
        }

        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchCust.Text.ToString().Trim();

            if (SearchBy.Length != 0)
            {
                AdvSearchCustomer(SearchBy);
            }
            else
            {
                AdvSearchCustomer("~!");
            }
        }

        private void TxtSearchAgent_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = TxtSearchAgent.Text.ToString().Trim();

            if (SearchBy.Length != 0)
            {
                AdvSearchAgent(SearchBy);
            }
            else
            {
                AdvSearchAgent("!~");
            }
        }

        private void btnGenerateActivityRpt_Click(object sender, EventArgs e)
        {
            int ContainerID = 0;

            if (ActivityContainerList.SelectedIndex > -1)
            {
                ContainerID = Convert.ToInt32(ActivityContainerList.SelectedValue.ToString().Trim());
                ActivityRpt ActivityRptDlg = new ActivityRpt(ContainerID, UserID);
                ActivityRptDlg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Container Selection is required.", "Warning !");
            }
        }

        private void btnGenerateK4Rpt_Click(object sender, EventArgs e)
        {
            int ContainerID = 0;

            if (K4ContainerList.SelectedIndex > -1)

            {
                ContainerID = Convert.ToInt32(K4ContainerList.SelectedValue.ToString().Trim());
                K4Rpt K4RptDlg = new K4Rpt(ContainerID, UserID);
                K4RptDlg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Container Selection is required.", "Warning !");
            }
        }

        private void btnGenerateARRpt_Click(object sender, EventArgs e)
        {
            var Rpt = "";
            var DateFrom = "";
            var DateTo = "";
            int Payment = 0;
            int Customer = 0;

            DateFrom = DtARFrom.Value.ToString("yyyy-MM-dd");
            DateTo = DtARTo.Value.ToString("yyyy-MM-dd");

            if (rbDebit.Checked)
            {
                Rpt = "D";
            }
            else if (rbCredit.Checked)
            {
                Rpt = "C";
            }
            else
            {
                Rpt = "I";
            }

            if (rbCash.Checked)
            {
                Payment = 0;
            }
            else if (rbCrdt.Checked)
            {
                Payment = 1;
            }
            else if (rbCheque.Checked)
            {
                Payment = 2;
            }
            else if (rbOnline.Checked)
            {
                Payment = 3;
            }
            else
            {
                Payment = 4;
            }

            if (CustomerList.SelectedIndex > -1)
            {
                Customer = Convert.ToInt32(CustomerList.SelectedValue.ToString().Trim());
            }

            ARRpt ARRpt = new ARRpt(Rpt, DateFrom, DateTo, Payment, Customer, UserID);
            ARRpt.ShowDialog();
        }

        private void btnGenerateTeusRpt_Click(object sender, EventArgs e)
        {
            var DateFrom = "";
            var DateTo = "";

            DateFrom = DtTeFrom.Value.ToString("yyyy-MM-dd");
            DateTo = DtTeTo.Value.ToString("yyyy-MM-dd");
            TeusRpt TeusRpt = new TeusRpt(DateFrom, DateTo, UserID);
            TeusRpt.ShowDialog();
        }

        private void btnGenerateUncollectedCargoRpt_Click(object sender, EventArgs e)
        {
            var DateFrom = "";
            var DateTo = "";
            int AgentID = 0;

            DateFrom = DtUcFrom.Value.ToString("yyyy-MM-dd");
            DateTo = DtUcTo.Value.ToString("yyyy-MM-dd");

            if (AgentList.SelectedIndex > -1)
            {
                AgentID = Convert.ToInt32(AgentList.SelectedValue.ToString().Trim());
            }

            UncollectedCargoRpt UncollectedCargoRpt = new UncollectedCargoRpt(DateFrom, DateTo, AgentID, UserID);
            UncollectedCargoRpt.Show();

        }

        private void rbInvoice_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchCust.Enabled = true;
            CustomerList.Enabled = true;

            txtSearchCust.Text = "";
            CustomerList.SelectedIndex = -1;

            rbAll.Checked = true;
            rbAll.Enabled = true;
            rbCash.Checked = false;
            rbCash.Enabled = true;
            rbCheque.Checked = false;
            rbCheque.Enabled = true;
            rbCrdt.Checked = false;
            rbCrdt.Enabled = true;
            rbOnline.Checked = false;
            rbOnline.Enabled = true;
        }

        private void rbDebit_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchCust.Enabled = false;
            CustomerList.Enabled = false;

            txtSearchCust.Text = "";
            CustomerList.SelectedIndex = -1;

            rbAll.Checked = true;
            rbAll.Enabled = true;
            rbCash.Checked = false;
            rbCash.Enabled = true;
            rbCheque.Checked = false;
            rbCheque.Enabled = true;
            rbCrdt.Checked = false;
            rbCrdt.Enabled = true;
            rbOnline.Checked = false;
            rbOnline.Enabled = true;
        }

        private void rbCredit_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchCust.Enabled = false;
            CustomerList.Enabled = false;

            txtSearchCust.Text = "";
            CustomerList.SelectedIndex = -1;

            rbAll.Checked = false;
            rbAll.Enabled = false;
            rbCash.Checked = false;
            rbCash.Enabled = false; 
            rbCheque.Checked = false;
            rbCheque.Enabled = false;
            rbCrdt.Checked = true;
            rbCrdt.Enabled = true;
            rbOnline.Checked = false;
            rbOnline.Enabled = false;
        }
    }
}
