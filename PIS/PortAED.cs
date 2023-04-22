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
    public partial class PortAED : Form
    {
        private int port_id = 0;
        private int UserID = 0;

        public PortAED(int mode, int id, int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();

            port_id = id;

            if (mode == 1)
            {
                port_id = 0;
                EnableEdit();
                lblCust_ID.Text = "Not Assigned";


                tbCode.Focus();
            }
            else
            {
                LoadPortDetails();
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

        private void LoadCountry()
        {

            DataTable Country = new DataTable();
            SqlConnection con = new SqlConnection(DBUtil.constring);
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT id, name FROM M_Country", con);
                SqlDataReader dtr;
                con.Open();
                dtr = cmd.ExecuteReader();
                Country.Load(dtr);
                foreach (DataRow row in Country.Rows)
                {
                    string name = (string)row["name"];
                    row["name"] = name.Trim();
                }

                cbCountry.DataSource = Country;
                cbCountry.DisplayMember = "name";
                cbCountry.ValueMember = "id";


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

            cbCountry.SelectedIndex = cbCountry.FindStringExact("Malaysia", 0);


        }
        
        private void LoadPortDetails()
        {
            
            int ctry = 0;
            string sql = "SELECT * FROM M_Port WHERE id=" + port_id.ToString();
            SqlConnection sqConnection = new SqlConnection(DBUtil.constring);
            SqlCommand sqCommand = new SqlCommand(sql, sqConnection);
            sqConnection.Open();
            try
            {
                SqlDataReader sqReader = sqCommand.ExecuteReader();

                while (sqReader.Read())
                {
                    lblCust_ID.Text = port_id.ToString();
                    tbCode.Text = SqlGetString(sqReader, "code");
                    tbName.Text = SqlGetString(sqReader, "name");
                    ctry = sqReader.GetInt16(sqReader.GetOrdinal("country"));
                    string country = DBUtil.GetCountryName(ctry);
                    txtCountry.Text = country;
                    cbCountry.SelectedIndex = cbCountry.FindStringExact(country, 0);
                    cbFav.Checked = Util.isChecked(sqReader.GetByte(sqReader.GetOrdinal("fav")));
                    ChkSpecialStorage.Checked = Util.isChecked(sqReader.GetByte(sqReader.GetOrdinal("special_storage_days")));

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
            tbCode.ReadOnly = false;
            tbName.ReadOnly = false;
            cbFav.Enabled = true;
            cbCountry.Visible = true;
            txtCountry.Visible = false;
            cbCountry.SelectedIndex = cbCountry.FindStringExact(txtCountry.Text, 0);
            ChkSpecialStorage.Enabled = true;
            tbCode.Focus();
        }
        private void CustAED_Load(object sender, EventArgs e)
        {

            LoadCountry();
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

            string sql = "DELETE FROM M_Port WHERE id=" + port_id.ToString();

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
            int value = 0;

            if (tbCode.TextLength==0)
            {
               
                MessageBox.Show("Port code must be entered");
                tbCode.Focus();
                return;

            }
            
            if (tbName.TextLength == 0)
            {
               

                MessageBox.Show("Port Name must be entered");
                tbName.Focus();
                return;
            }
            
            
            StringBuilder sq = new StringBuilder();
            if (port_id == 0)
            {

                sq.Append("INSERT INTO M_Port (code,name,country,fav,special_storage_days) VALUES (");
                sq.Append("'" + tbCode.Text.Trim());
                sq.Append("','" + tbName.Text.Trim());
                sq.Append("'," + cbCountry.SelectedValue);
                sq.Append("," + Util.BoolToInt(cbFav.Checked));
                sq.Append("," + Util.BoolToInt(ChkSpecialStorage.Checked));
                sq.Append(")");
                sql = sq.ToString();
            }
            else
            {
                sq.Append("UPDATE M_Port SET ");
                sq.Append("code='" + tbCode.Text.Trim() + "',");
                sq.Append("name='" + tbName.Text.Trim() + "',");
                sq.Append("country=" + cbCountry.SelectedValue + ",");
                sq.Append("fav=" + Util.BoolToInt(cbFav.Checked) + ",");
                sq.Append("special_storage_days=" + Util.BoolToInt(ChkSpecialStorage.Checked));
                sq.Append(" ");
                sq.Append("WHERE id=" + port_id.ToString());
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
                if (port_id == 0)
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
            tbCode.ReadOnly = true;
            tbName.ReadOnly = true;
            cbFav.Enabled = false;
            ChkSpecialStorage.Enabled = false;

            txtCountry.ReadOnly = true;
            txtCountry.Visible = true;
            cbCountry.Visible = false;
            
            LoadPortDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (port_id == 0)
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
            tbCode.Text = tbCode.Text.ToUpper();
        }

        private void txtAdd1_Leave(object sender, EventArgs e)
        {
            tbName.Text = tbName.Text.ToUpper();
        }

        
        
    }
}
