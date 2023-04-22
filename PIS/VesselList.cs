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
    public partial class VesselList : Form
    {

        DataSet ds = new DataSet();
        int count = 0;
        private int UserID = 0;

        public VesselList(int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();
        }

        private void VoyageList_Load(object sender, EventArgs e)
        {

            LoadData(0,"");
            dgvVoyage.Columns[0].HeaderText = "ID";
            dgvVoyage.Columns[0].Width = 40;

            dgvVoyage.Columns[1].HeaderText = "Vessel ID";
            dgvVoyage.Columns[1].Width = 50;

            dgvVoyage.Columns[2].HeaderText = "Vessel Name";
           //dgvVoyage.Columns[2].Width = 100;



        }


        private void LoadData(int mode, string searchq)
        {

            
            string sql="";
            ds.Reset();
            if (mode==0)
            {


                count = DBUtil.GetTableCount("M_Vessel");
                lbCount.Text = "Record Count : " + count.ToString();
                sql = "SELECT id,vid,name FROM M_Vessel";
            }
            else
            {
                sql = "SELECT  id,vid,name FROM M_Vessel Where name LIKE '" + searchq + "%'";

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
            VesselAED2 detaildlg = new VesselAED2(1, 0, UserID);
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
                VesselAED2 detaildlg = new VesselAED2(0, int.Parse(id), UserID);
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
