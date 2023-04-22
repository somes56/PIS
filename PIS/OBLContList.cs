using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS
{
    public partial class OBLContList : Form
    {
        public OBLContList(int OBLID)
        {
            InitializeComponent();

            lblOBLID.Text = OBLID.ToString();

            AdvSearchOBLContainers(OBLID);

            dgvContList.Columns[0].Name = "id";
            dgvContList.Columns[0].HeaderText = "ID";
            dgvContList.Columns[0].Visible = false;

            dgvContList.Columns[1].Name = "container_no";
            dgvContList.Columns[1].HeaderText = "Container";

        }

        private void OBLContList_Load(object sender, EventArgs e)
        {

        }

        private void AdvSearchOBLContainers(int OBLID)
        {
            try
            {
                DataTable HBLContainers = new DataTable();
                HBLContainers = DBUtil.AdvSearchHBLContainers(OBLID, 0);

                dgvContList.DataSource = HBLContainers;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail To Load Container List." + e.Message, "Error");
                return;
            }
        }

        private void dgvContList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());

            if (currow > -1)
            {
                int ContID = Convert.ToInt32(dgvContList[0, currow].Value);
                var ContNo = dgvContList[1, currow].Value;

                DialogResult dlgResult = MessageBox.Show("Do you want to Print Tally Sheet for "+ ContNo +" ?", "Print Container Tally Sheet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgResult == DialogResult.Yes)
                {
                    //TallySht TallyShtdlg = new TallySht(Convert.ToInt32(lblOBLID.Text.Trim()),ContID);
                    //TallyShtdlg.ShowDialog();
                    AdvSearchOBLContainers(Convert.ToInt32(lblOBLID.Text.Trim()));
                }
                else if (dlgResult == DialogResult.No)
                {
                    return;
                }
            }
        }
    }
}
