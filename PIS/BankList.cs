using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PIS
{
    public partial class BankList : Form
    {

        DataSet ds = new DataSet();
        int count = 0;
        public BankList()
        {
            InitializeComponent();
        }

        private void BankList_Load(object sender, EventArgs e)
        {

            
            LoadBankData(0, "");
            dgvBank.Columns[0].HeaderText = "ID";
            dgvBank.Columns[0].Width = 40;
            dgvBank.Columns[0].Visible = false;

            dgvBank.Columns[1].HeaderText = "Bank Name";
            dgvBank.Columns[1].Width = 250;

            dgvBank.Columns[2].HeaderText = "Contact Person";
            dgvBank.Columns[3].HeaderText = "Tel";
            dgvBank.Columns[4].HeaderText = "Mobile";

        }


        private void LoadBankData(int mode, string searchq)
        {

            
            string sql="";
            ds.Reset();
            if (mode==0)
            {


                count = DBUtil.GetTableCount("M_BankInfo");
                lbCount.Text = "Record Count : " + count.ToString();
                sql = "SELECT id,name,pic,tel,mobile FROM M_BankInfo";
            }
            else
            {
                sql = "SELECT id,name,pic,tel,mobile FROM M_BankInfo Where name LIKE '" + searchq + "%'";

            }
            
            
            if (count == 0)
            {
                return;
            }
            
           
            
            try
            {
                using (SqlConnection conn = new SqlConnection(DBUtil.constring))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {

                        da.Fill(ds);

                        dgvBank.DataSource = ds.Tables[0].DefaultView;

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Close();
            }
           

        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            BankAED Bankdetaildlg = new BankAED(1, 0);
            Bankdetaildlg.ShowDialog();
            tbSearchq.Text = "";
            LoadBankData(0,"");
        }

        private void dgvBank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());
            if (currow > -1)
            {
                string id = dgvBank[0, currow].Value.ToString();
                BankAED bankdetaildlg = new BankAED(0, int.Parse(id));
                bankdetaildlg.ShowDialog();
                LoadBankData(1, tbSearchq.Text.Trim());
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            tbSearchq.Text=tbSearchq.Text.Trim();
            if (tbSearchq.Text.Length > 0)
            {
                LoadBankData(1, tbSearchq.Text.Trim());
            }
            else
            {
                LoadBankData(0, "");
            }

        }

    }
}
