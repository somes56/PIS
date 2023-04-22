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
    public partial class UnstuffCargoList : Form
    {
        private int UserID = 0;

        public UnstuffCargoList(int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            AdvSearchNotUnstuffContainers("",0);

            AdvSearchUnstuffedContainers("",1);

            dgvNotUnstuffCargo.Columns[0].Name = "id";
            dgvNotUnstuffCargo.Columns[0].HeaderText = "Id";
            dgvNotUnstuffCargo.Columns[0].Visible = false;

            dgvNotUnstuffCargo.Columns[1].Name = "container_no";
            dgvNotUnstuffCargo.Columns[1].HeaderText = "Container";

            dgvNotUnstuffCargo.Columns[2].Name = "unstuff_date";
            dgvNotUnstuffCargo.Columns[2].HeaderText = "Unstuff Date";

            dgvNotUnstuffCargo.Columns[3].Name = "obl_id";
            dgvNotUnstuffCargo.Columns[3].HeaderText = "OBL ID";
            dgvNotUnstuffCargo.Columns[3].Visible = false;


            dgvUnstuffedCargo.Columns[0].Name = "id";
            dgvUnstuffedCargo.Columns[0].HeaderText = "Id";
            dgvUnstuffedCargo.Columns[0].Visible = false;

            dgvUnstuffedCargo.Columns[1].Name = "container_no";
            dgvUnstuffedCargo.Columns[1].HeaderText = "Container";

            dgvUnstuffedCargo.Columns[2].Name = "unstuff_date";
            dgvUnstuffedCargo.Columns[2].HeaderText = "Unstuff Date";

            dgvUnstuffedCargo.Columns[3].Name = "obl_id";
            dgvUnstuffedCargo.Columns[3].HeaderText = "OBL ID";
            dgvUnstuffedCargo.Columns[3].Visible = false;
        }

        private void AdvSearchNotUnstuffContainers(string SearchBy, int Flag)
        {
            try
            {
                DataTable NotUnstuffContainers = new DataTable();
                NotUnstuffContainers = DBUtil.AdvSearchUnstuffContainer(SearchBy,Flag);

                dgvNotUnstuffCargo.DataSource = NotUnstuffContainers;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail To Load Not Unstuff Container List." + e.Message, "Error");
                return;
            }
        }

        private void AdvSearchUnstuffedContainers(string SearchBy, int Flag)
        {
            try
            {
                DataTable UnstuffedContainers = new DataTable();
                UnstuffedContainers = DBUtil.AdvSearchUnstuffContainer(SearchBy, Flag);

                dgvUnstuffedCargo.DataSource = UnstuffedContainers;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail To Load Unstuff Container List." + e.Message, "Error");
                return;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNotUnstuffCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());
            var SearchByPND = tbSearchq.Text.Trim();
            var SearchByCMPLT = txtSearchCMPLTCont.Text.Trim();

            if (currow > -1)
            {
                int ContID = Convert.ToInt32(dgvNotUnstuffCargo[0, currow].Value.ToString());
                int OBLID = Convert.ToInt32(dgvNotUnstuffCargo[3, currow].Value.ToString());
                UnstuffCargoAED UnstuffCargo = new UnstuffCargoAED(ContID, UserID, OBLID);
                UnstuffCargo.ShowDialog();
                AdvSearchNotUnstuffContainers(SearchByPND, 0);
                AdvSearchUnstuffedContainers(SearchByCMPLT, 1);
            }
        }

        private void dgvUnstuffedCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currow = int.Parse(e.RowIndex.ToString());
            var SearchByPND = tbSearchq.Text.Trim();
            var SearchByCMPLT = txtSearchCMPLTCont.Text.Trim();

            if (currow > -1)
            {
                int ContID = Convert.ToInt32(dgvUnstuffedCargo[0, currow].Value.ToString());
                int OBLID = Convert.ToInt32(dgvUnstuffedCargo[3, currow].Value.ToString());
                UnstuffCargoAED UnstuffCargo = new UnstuffCargoAED(ContID, UserID, OBLID);
                UnstuffCargo.ShowDialog();
                AdvSearchNotUnstuffContainers(SearchByPND, 0);
                AdvSearchUnstuffedContainers(SearchByCMPLT, 1);
            }
        }

        private void tbSearchq_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = tbSearchq.Text.Trim();

            if (SearchBy.Length > 0)
            {
                AdvSearchNotUnstuffContainers(SearchBy, 0);
            }
            else
            {
                AdvSearchNotUnstuffContainers("", 0);
            }
        }

        private void txtSearchCMPLTCont_TextChanged(object sender, EventArgs e)
        {
            var SearchBy = txtSearchCMPLTCont.Text.Trim();

            if (SearchBy.Length > 0)
            {
                AdvSearchUnstuffedContainers(SearchBy, 1);
            }
            else
            {
                AdvSearchUnstuffedContainers("", 1);
            }
        }
    }
}
