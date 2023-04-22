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
    public partial class VoyageList : Form
    {

        DataSet ds = new DataSet();
        int count = 0;
        private int UserID = 0;

        public VoyageList(int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();
        }

        private void VoyageList_Load(object sender, EventArgs e)
        {

            LoadData(0,"");
            dgvVoyage.Columns[0].HeaderText = "ID";
            dgvVoyage.Columns[0].Width = 10;

            dgvVoyage.Columns[1].HeaderText = "SCN";
            dgvVoyage.Columns[1].Width = 60;

            dgvVoyage.Columns[2].HeaderText = "Voyage No";
            dgvVoyage.Columns[2].Width = 60;
            dgvVoyage.Columns[3].HeaderText = "ETA";
            dgvVoyage.Columns[3].Width = 60;



        }


        private void LoadData(int mode, string searchq)
        {

            
            string sql="";
            ds.Reset();
            if (mode==0)
            {


                count = DBUtil.GetTableCount("M_Voyage");
                lbCount.Text = "Record Count : " + count.ToString();
                sql = "SELECT id,scn,voyage_no,eta FROM M_Voyage";
            }
            else
            {
                sql = "SELECT  id,scn,voyage_no,eta FROM M_Voyage Where scn LIKE '" + searchq + "%'";

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

                        dgvVoyage.DataSource = ds.Tables[0].DefaultView;

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
            VoyageAED detaildlg = new VoyageAED(1, 0, UserID);
            detaildlg.ShowDialog();
            tbSearchq.Text = "";
            LoadData(0,"");
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());
            if (currow > -1)
            {
                string id = dgvVoyage[0, currow].Value.ToString();
                VoyageAED detaildlg = new VoyageAED(0, int.Parse(id), UserID);
                detaildlg.ShowDialog();
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
