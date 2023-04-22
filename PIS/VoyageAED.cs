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
    public partial class VoyageAED : Form
    {
        private int row_id = 0;
        private string dbtblname = "M_Voyage";
        private int UserID = 0;

        public VoyageAED(int mode, int id, int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();

            row_id = id;

            if (mode == 1)
            {
                row_id = 0;
                EnableEdit();
                lbl_ID.Text = "Not Assigned";

                LoadVesselList(cbVesselName, "NONE");
                tbSCN.Focus();
            }
            else
            {
                LoadDetails();
                btnBack.Focus();
            }

        }

        private string SqlGetString(SqlDataReader sqr, string column)
        {
            string data = "";
            try
            {
                data = sqr.GetString(sqr.GetOrdinal(column));
                return data.Trim();

            }

            catch
            {
                return "";
            }


        }

        private void LoadVesselList(ComboBox cb, string searchq)
        {

            cb.DataSource = null;

            DataTable Vessel = new DataTable();
            SqlConnection con = new SqlConnection(DBUtil.constring);
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT id,vid,name FROM [dbo].[M_Vessel] WHERE name LIKE '%" + searchq + "%'", con);
                SqlDataReader dtr;
                con.Open();
                dtr = cmd.ExecuteReader();
                Vessel.Load(dtr);
                foreach (DataRow row in Vessel.Rows)
                {
                    string name = (string)row["vid"];
                    row["vid"] = name.Trim();
                }

                cb.DataSource = Vessel;
                cb.DisplayMember = "name";
                cb.ValueMember = "id";


            }
            catch (Exception ex)
            {
                // Handle the error
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

            


        }

        private void LoadDetails()
        {

            int vid = 0;
            
           
            string sql = "SELECT * FROM "+ dbtblname +" WHERE id=" + row_id.ToString();
            SqlConnection sqConnection = new SqlConnection(DBUtil.constring);
            SqlCommand sqCommand = new SqlCommand(sql, sqConnection);

            sqConnection.Open();
            try
            {
                SqlDataReader sqReader = sqCommand.ExecuteReader();

                while (sqReader.Read())
                {
                    lbl_ID.Text = row_id.ToString();
                    tbSCN.Text = SqlGetString(sqReader, "scn");
                    tbVoyageNo.Text = SqlGetString(sqReader, "voyage_no");

                    //Load Combo type data
                    vid = sqReader.GetInt32(sqReader.GetOrdinal("vessel_id"));
                    string s_vid = DBUtil.GetVessel_Id(vid);
                    txtVesselName.Text = s_vid;
                    cbVesselName.SelectedIndex = cbVesselName.FindStringExact(s_vid, 0);

                    //Load Date

                    //
                    dtETA.Value = sqReader.GetDateTime(sqReader.GetOrdinal("eta"));

                    dtETD.Value = sqReader.GetDateTime(sqReader.GetOrdinal("etd"));

                }
                // always call Close when done reading. 
                sqReader.Close();

                // Close the connection when done with it. 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Close();
            }
            finally
            {
                sqConnection.Close();
            }



        }

        private void EnableEdit()
        {
            pnlEdit.Visible = false;
            pnlSave.Visible = true;
            tbVoyageNo.ReadOnly = false;
            tbSCN.ReadOnly = false;
            tbSVN.ReadOnly = false;

            //For combobox
            txtVesselName.Visible = false;
            cbVesselName.Visible = true;
            tbSVN.Text = txtVesselName.Text;
            LoadVesselList(cbVesselName, txtVesselName.Text);
            //cbVesselName.SelectedIndex = cbVesselName.FindStringExact(txtVesselName.Text, 0);



            if (row_id != 0)
            {
                lblEdit.Visible = true;
                tbSCN.ReadOnly = true;
                tbVoyageNo.Focus();
            }
            else
            {
                tbSCN.ReadOnly = false;
                tbSCN.Focus();
            }
            
           
            
        }
        private void CustAED_Load(object sender, EventArgs e)
        {

            //LoadVesselList();
          
        }



        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int Admin = 0;
            Admin = DBUtil.GetAdminFlag(UserID);

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                // Yes, continue 
            }
            else if (dlgResult == DialogResult.No)
            {
                return;
            }

            if (Admin == 0)
            {
                MessageBox.Show("Sorry, You do not have admin privilege to delete this master.", "Warning!");
                return;
            }

            string sql = "DELETE FROM " + dbtblname + " WHERE id=" + row_id.ToString();


            SqlConnection sqConnection = new SqlConnection(DBUtil.constring);
            SqlCommand sqCommand = new SqlCommand(sql, sqConnection);
            sqConnection.Open();
            try
            {
                sqCommand.ExecuteNonQuery();


                // Close the connection when done with it. 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Close();
            }
            finally
            {
                sqConnection.Close();
                Close();

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string sql = "";
     
            if (tbSCN.TextLength==0)
            {
               
                MessageBox.Show("SCN must be entered");
                tbSCN.Focus();
                return;

            }
            else
            {
                if (row_id == 0)
                {
                    if (DBUtil.isExistinDB(dbtblname, "scn", tbSCN.Text))
                    {

                        MessageBox.Show("SCN already exist, try another");
                        tbSCN.Focus();
                        return;
                    }
                }
            }
            
            if (tbVoyageNo.TextLength == 0)
            {
               

                MessageBox.Show("Voyage No must be entered");
                tbVoyageNo.Focus();
                return;
            }
            
            
            StringBuilder sq = new StringBuilder();
            if (row_id == 0)
            {

                sq.Append("INSERT INTO ");
                sq.Append(dbtblname +" ");
                sq.Append ("(scn,voyage_no,vessel_id,eta,etd) VALUES (");
                sq.Append("'" + tbSCN.Text.Trim());
                sq.Append("','" + tbVoyageNo.Text.Trim());
                sq.Append("','" + cbVesselName.SelectedValue);
                sq.Append("','" + dtETA.Value.Date.ToString("yyyy-MM-dd"));
                sq.Append("','" + dtETD.Value.Date.ToString("yyyy-MM-dd"));
                sq.Append("')");
                sql = sq.ToString();
            }
            else
            {
                sq.Append("UPDATE ");
                sq.Append(dbtblname +" SET ");
               // sq.Append("code='" + tbCode.Text.Trim() + "',");
                sq.Append("scn='" + tbSCN.Text.Trim() + "',");
                sq.Append("voyage_no='" + tbVoyageNo.Text.Trim() + "',");
                sq.Append("vessel_id=" + cbVesselName.SelectedValue.ToString() + ",");
                sq.Append("eta='" + dtETA.Value.Date.ToString("yyyy-MM-dd") + "',");
                sq.Append("etd='" + dtETD.Value.Date.ToString("yyyy-MM-dd") + "'");
                sq.Append(" ");
                sq.Append("WHERE id=" + row_id.ToString());
                sql = sq.ToString();

            }

            SqlConnection sqConnection = new SqlConnection(DBUtil.constring);
            SqlCommand sqCommand = new SqlCommand(sql, sqConnection);
            sqConnection.Open();


            try
            {
                sqCommand.ExecuteNonQuery();


                // Close the connection when done with it. 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Close();
            }
            finally
            {
                sqConnection.Close();
                if (row_id == 0)
                {
                    Close();
                }
                else
                {
                    DisableEdit();
                }


            }
        }


        private void DisableEdit()
        {
            pnlEdit.Visible = true;
            pnlSave.Visible = false;
            lblEdit.Visible = false;
            tbSCN.ReadOnly = true;
            tbVoyageNo.ReadOnly = true;
            tbSVN.ReadOnly = true;

            //For combobox
            txtVesselName.ReadOnly = true;
            txtVesselName.Visible = true;

            cbVesselName.Visible = false;
 
            LoadDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (row_id == 0)
            {
                Close();
            }
            else
            {

                DisableEdit();
            }
        }



        private void txtCompanyName_Leave(object sender, EventArgs e)
        {
            tbSCN.Text = tbSCN.Text.ToUpper();
        }

        private void txtAdd1_Leave(object sender, EventArgs e)
        {
            tbVoyageNo.Text = tbVoyageNo.Text.ToUpper();
        }

        private void tbSVN_Leave(object sender, EventArgs e)
        {
            LoadVesselList(cbVesselName, tbSVN.Text);
            cbVesselName.Focus();
            cbVesselName.DroppedDown = true;
       }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            VesselAED VAED = new VesselAED(1, 0);
            VAED.ShowDialog();
        }
    }
}
