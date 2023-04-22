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
    public partial class CustList : Form
    {

        DataSet ds = new DataSet();
        int count = 0;
        private int UserID = 0;

        public CustList(int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();
        }

        private void CustList_Load(object sender, EventArgs e)
        {

            LoadCustData(0,"");
            dgvCust.Columns[0].HeaderText = "ID";
            dgvCust.Columns[0].Width = 40;
            dgvCust.Columns[0].Visible = false;

            dgvCust.Columns[1].HeaderText = "Customer Name";
            dgvCust.Columns[1].Width = 250;

            dgvCust.Columns[2].HeaderText = "Contact Person";
            dgvCust.Columns[3].HeaderText = "Tel";
            dgvCust.Columns[4].HeaderText = "Mobile";

        }


        private void LoadCustData(int mode, string searchq)
        {

            
            string sql="";
            ds.Reset();
            if (mode==0)
            {


                count = DBUtil.GetTableCount("M_CompanyInfo");
                lbCount.Text = "Record Count : " + count.ToString();
                sql = "SELECT id,name,pic,tel,mobile FROM M_CompanyInfo";
            }
            else
            {
                sql = "SELECT id,name,pic,tel,mobile FROM M_CompanyInfo Where name LIKE '" + searchq + "%'";

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

                        dgvCust.DataSource = ds.Tables[0].DefaultView;

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
            CustAED custdetaildlg = new CustAED(1, 0, UserID);
            custdetaildlg.ShowDialog();
            tbSearchq.Text = "";
            LoadCustData(0,"");
        }

        private void dgvCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());
            if (currow > -1)
            {
                int id = Convert.ToInt32(dgvCust[0, currow].Value.ToString());
                CustAED custdetaildlg = new CustAED(0, id, UserID);
                custdetaildlg.ShowDialog();
                LoadCustData(1, tbSearchq.Text.Trim());
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";
            SearchBy = tbSearchq.Text.ToString().Trim();

            if (SearchBy.Length > 0)
            {
                LoadCustData(1, SearchBy);
            }
            else
            {
                LoadCustData(0, "");
            }
        }

    }
}
