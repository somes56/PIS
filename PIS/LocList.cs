using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PIS
{
    public partial class LocList : Form
    {
        public LocList()
        {
            InitializeComponent();
        }

        private void LocList_Load(object sender, EventArgs e)
        {
            AdvSearchLoc();

            dgvLoc.Columns[0].Name = "id";
            dgvLoc.Columns[0].HeaderText = "ID";
            dgvLoc.Columns[0].Visible = false;

            dgvLoc.Columns[1].Name = "code";
            dgvLoc.Columns[1].HeaderText = "Code";

            dgvLoc.Columns[2].Name = "port";
            dgvLoc.Columns[2].HeaderText = "Port";

        }

        private void AdvSearchLoc()
        {
            SqlConnection conn = new SqlConnection(DBUtil.constring);
            DataTable Location = new DataTable();

            try
            {
                string sqlstr = "SELECT id, code, CASE WHEN port = 1 THEN 'NORTH PORT' ELSE 'WEST PORT' END AS port FROM M_Location";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(Location);

                dgvLoc.DataSource = Location;
            }
            catch
            {
                Location.Clear();
                dgvLoc.DataSource = Location;
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvLoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());

            if (currow > -1)
            {
                int LocID = Convert.ToInt32(dgvLoc[0, currow].Value.ToString());

                LocAED LocAED = new LocAED(LocID);
                LocAED.ShowDialog();
                AdvSearchLoc();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            LocAED LocAED = new LocAED(0);
            LocAED.ShowDialog();
            AdvSearchLoc();
        }
    }
}
