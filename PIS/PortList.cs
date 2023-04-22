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
    public partial class PortList : Form
    {

        DataSet ds = new DataSet();
        int count = 0;
        private int UserID = 0;

        public PortList(int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();
        }

        private void BankList_Load(object sender, EventArgs e)
        {

            
            LoadPortData(0, "");
            dgvPort.Columns[0].HeaderText = "ID";
            dgvPort.Columns[0].Width = 40;
            dgvPort.Columns[0].Visible = false;

            dgvPort.Columns[1].HeaderText = "Port Code";
            dgvPort.Columns[1].Width = 250;

            dgvPort.Columns[2].HeaderText = "Port Name";
           

        }


        private void LoadPortData(int mode, string searchq)
        {

            
            string sql="";
            ds.Reset();
            if (mode==0)
            {


                count = DBUtil.GetTableCount("M_Port");
                lbCount.Text = "Record Count : " + count.ToString();
                sql = "SELECT id,code,name FROM M_Port";
            }
            else
            {
                sql = "SELECT id,code,name  FROM M_Port Where name LIKE '%" + searchq + "%'";

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

                        dgvPort.DataSource = ds.Tables[0].DefaultView;

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
            PortAED dlg = new PortAED(1, 0, UserID);
            dlg.ShowDialog();
            tbSearchq.Text = "";
            LoadPortData(0,"");
        }

        private void dgvBank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());
            if (currow > -1)
            {
                string id = dgvPort[0, currow].Value.ToString();
                PortAED Portdetaildlg = new PortAED(0, int.Parse(id), UserID);
                Portdetaildlg.ShowDialog();
                LoadPortData(1, tbSearchq.Text.Trim());
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";
            SearchBy = tbSearchq.Text.ToString().Trim();

            if (SearchBy.Length > 0)
            {
                LoadPortData(1, SearchBy);
            }
            else
            {
                LoadPortData(0, "");
            }
        }

    }
}
