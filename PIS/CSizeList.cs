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
    public partial class CSizeList : Form
    {

        DataSet ds = new DataSet();
        int count = 0;
        string dbtblname = "M_CSize";
        private int UserID = 0;

        public CSizeList(int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();
        }


        private void SetDG ()
        {
            dgvCSize.Columns[0].HeaderText = "ID";
            dgvCSize.Columns[0].Width = 40;
            dgvCSize.Columns[0].Visible = false;

            dgvCSize.Columns[1].HeaderText = "Short Code";
            dgvCSize.Columns[1].Width = 250;

            dgvCSize.Columns[2].HeaderText = "Description";

        }
        private void CSizeList_Load(object sender, EventArgs e)
        {


            LoadData(0, "");
           

        }


        private void LoadData(int mode, string searchq)
        {

            
            string sql="";
            ds.Reset();
            if (mode==0)
            {


                count = DBUtil.GetTableCount(dbtblname);
                lbCount.Text = "Record Count : " + count.ToString();
                sql = "SELECT id,code,name FROM " + dbtblname;
            }
            else
            {
                sql = "SELECT id,code,name  FROM "+dbtblname+ " Where name LIKE '%" + searchq + "%'";


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

                        dgvCSize.DataSource = ds.Tables[0].DefaultView;

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Close();
            }
            SetDG();



        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CSizeAED dlg = new CSizeAED(1, 0, UserID);
            dlg.ShowDialog();
            tbSearchq.Text = "";
            LoadData(0,"");
        }

        private void dgvCSize_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());
            if (currow > -1)
            {
                string id = dgvCSize[0, currow].Value.ToString();
                CSizeAED dlg = new CSizeAED(0, int.Parse(id), UserID);
                dlg.ShowDialog();
                LoadData(1, tbSearchq.Text.Trim());
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";
            SearchBy = tbSearchq.Text.ToString().Trim();

            if (SearchBy.Length > 0)
            {
                LoadData(1, SearchBy);
            }
            else
            {
                LoadData(0, "");
            }
        }

    }
}
