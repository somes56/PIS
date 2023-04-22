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
    public partial class ItemCodeList : Form
    {

        DataSet ds = new DataSet();
        int count = 0;
        private int UserID = 0;

        public ItemCodeList(int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();
        }

        private void ItemCodeList_Load(object sender, EventArgs e)
        {

            LoadCustData(0,"",0);
            dgvCust.Columns[0].HeaderText = "ID";
            dgvCust.Columns[0].Visible = false;

            dgvCust.Columns[1].HeaderText = "Item Code";
            dgvCust.Columns[1].Width = 50;

            dgvCust.Columns[2].HeaderText = "Item Description";
            //dgvCust.Columns[2].Width = 240;

        }


        private void LoadCustData(int mode, string searchq, int searchtype)
        {

            
            string sql="";
            ds.Reset();
            if (mode==0)
            {


                count = DBUtil.GetTableCount("M_ItemCode");
                lbCount.Text = "Record Count : " + count.ToString();
                sql = "SELECT id,code,name FROM M_ItemCode";
            }
            else
            {
                if (searchtype==1)
                {

                    sql = "SELECT id,code,name FROM M_ItemCode Where name LIKE '" + searchq + "%'";
                }
                
                else
                {
                    sql = "SELECT id,code,name FROM M_ItemCode Where code= " + Convert.ToInt32(searchq.ToString()) ;

                }
                

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
            ItemCodeAED ItemAED = new ItemCodeAED(0, UserID);
            ItemAED.ShowDialog();
            LoadCustData(0, "", 1);
        }

        private void dgvCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());
            var CodeSearch = tbCodeSearch.Text.ToString().Trim();
            var ItemSearch = tbItemSearch.Text.ToString().Trim();

            if (currow > -1)
            {
                int id = Convert.ToInt32(dgvCust[0, currow].Value.ToString());
                ItemCodeAED ItemAED = new ItemCodeAED(id, UserID);
                ItemAED.ShowDialog();

                if (CodeSearch.Length != 0)
                {
                    LoadCustData(1, CodeSearch, 2);
                }
                else if (ItemSearch.Length != 0)
                {
                    LoadCustData(1, ItemSearch, 1);
                }
                else
                {
                    LoadCustData(0, "", 1);
                }
            }
        }

        private void CodeSearch_TextChanged(object sender, EventArgs e)
        {
            int value;
            var SearchBy = "";
            SearchBy = tbCodeSearch.Text.ToString().Trim();

            if (!(int.TryParse(SearchBy, out value)))
            {
                LoadCustData(0, "", 0);
                return;
            }

            if (SearchBy.Length > 0)
            {
                LoadCustData(1, SearchBy, 0);
            }
            else
            {
                LoadCustData(0, "", 0);
            }

        }

        private void tbItemSearch_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";
            SearchBy = tbItemSearch.Text.ToString().Trim();

            if (SearchBy.Length > 0)
            {
                LoadCustData(1, SearchBy, 1);
            }
            else
            {
                LoadCustData(0, "", 0);
            }
        }

        private void tbCodeSearch_GotFocus(object sender, System.EventArgs e)
        {
            tbItemSearch.Text = "";
        }

        private void tbItemSearch_GotFocus(object sender, System.EventArgs e)
        {
            tbCodeSearch.Text = "";
        }

        private void tbCodeSearch_Enter(object sender, EventArgs e)
        {
            tbItemSearch.ResetText();
        }

        private void tbItemSearch_Enter(object sender, EventArgs e)
        {
            tbCodeSearch.ResetText();
        }

        private void tbCodeSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
