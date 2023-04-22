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
    public partial class CurrencyList : Form
    {

        int count = 0;
        DataSet ds = new DataSet();
        private int UserID = 0;

        public CurrencyList(int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();
        }


        private void CurrencyList_Load(object sender, EventArgs e)
        {
            // Fill Gridview on Form Load
            LoadCurrencyData(0, "");

            //Set Columns
            dgvCurrency.Columns[0].Name = "id";
            dgvCurrency.Columns[0].HeaderText = "ID";
            dgvCurrency.Columns[0].Visible = false;

            dgvCurrency.Columns[1].Name = "code";
            dgvCurrency.Columns[1].HeaderText = "Code";
            dgvCurrency.Columns[1].Width = 250;

            dgvCurrency.Columns[2].Name = "name";
            dgvCurrency.Columns[2].HeaderText = "Name";

        }


        private void LoadCurrencyData(int mode, string searchq)
        {
            
            string sqlstr = "";
            ds.Reset();

            if (mode == 0)
            {
                count = DBUtil.GetTableCount("M_Currency");
                lbCount.Text = "Record Count : " + count.ToString();

                sqlstr = "SELECT id,code,name FROM [dbo].[M_Currency]";
            }
            else
            {
                //Search
                sqlstr = "SELECT id,code,name FROM [dbo].[M_Currency] WHERE name LIKE '%" + searchq + "%'";
            }

            if (count == 0)
            {
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection(DBUtil.constring);

                var command = new SqlCommand(sqlstr, conn);

                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);
                dgvCurrency.DataSource = ds.Tables[0].DefaultView;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                Close();
            }
        }

        private void tbSearchq_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = "";
            SearchBy = tbSearchq.Text.ToString().Trim();

            if (SearchBy.Length > 0)
            {
                LoadCurrencyData(1, SearchBy);
            }
            else
            {
                LoadCurrencyData(0, "");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CurrencyAED dlgAED = new CurrencyAED(1, 0, UserID);
            dlgAED.ShowDialog();
            tbSearchq.Text = "";
            LoadCurrencyData(0, "");
        }

        private void dgvCurrency_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());

            if (currow > -1)
            {
                string id = dgvCurrency[0, currow].Value.ToString();
                CurrencyAED CurrencyDetaildlg = new CurrencyAED(0, int.Parse(id), UserID);
                CurrencyDetaildlg.ShowDialog();
                if (tbSearchq.Text.Length > 0)
                {
                    LoadCurrencyData(1, tbSearchq.Text.Trim());
                }
                else
                {
                    LoadCurrencyData(0, "");
                }
                
            }
        }
    }
}
