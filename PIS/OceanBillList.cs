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
    public partial class OceanBillList : Form
    {
        int count = 0;
        DataSet ds = new DataSet();


        public OceanBillList()
        {
            InitializeComponent();
        }

        private void OceanBillList_Load(object sender, EventArgs e)
        {
            // Fill Gridview on Form Load
            LoadOceanBillList("");

            //Set Columns
            dgvOBL.Columns[0].Name = "id";
            dgvOBL.Columns[0].HeaderText = "OBL ID";
            dgvOBL.Columns[0].Visible = false;

            dgvOBL.Columns[1].Name = "scn";
            dgvOBL.Columns[1].HeaderText = "SCN";

            dgvOBL.Columns[2].Name = "vessel";
            dgvOBL.Columns[2].HeaderText = "Vessel";

            dgvOBL.Columns[3].Name = "voyage_no";
            dgvOBL.Columns[3].HeaderText = "Voyage";

            dgvOBL.Columns[4].Name = "eta";
            dgvOBL.Columns[4].HeaderText = "ETA";
        }

        private void LoadOceanBillList(string SearchBy)
        {
            try
            {

                count = DBUtil.GetTableCount("OBL");
                lbCount.Text = "Record Count : " + count.ToString();

                DataTable PIS_OceanBillLists = new DataTable();
                PIS_OceanBillLists = DBUtil.AdvSearchOceanBill(SearchBy);

                dgvOBL.DataSource = PIS_OceanBillLists.DefaultView;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                Close();
            }
            
        }

        private void tbSearchq_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = tbSearchq.Text.Trim();

            if (SearchBy.Length > 0)
            {
                LoadOceanBillList(SearchBy);
            }
            else
            {
                LoadOceanBillList("");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //OceanBillAED OBLAEDdlg = new OceanBillAED("");
            //OBLAEDdlg.ShowDialog();
            LoadOceanBillList("");
        }

        private void dgvOBL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());

            if (currow > -1)
            {
                var SearchBy = tbSearchq.Text.Trim();
                var OBLID = dgvOBL[0, currow].Value.ToString();
                //OceanBillAED OBLAEDdlg = new OceanBillAED(OBLID);
                //OBLAEDdlg.ShowDialog();
                LoadOceanBillList(SearchBy);
            }
        }
    }
}
