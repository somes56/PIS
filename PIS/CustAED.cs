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
    public partial class CustAED : Form
    {
        private int cust_id = 0;
        private int UserID = 0;

        public CustAED(int mode, int id, int LoginID)
        {
            UserID = LoginID;

            InitializeComponent();

            LoadState();

            cust_id = id;

            if (mode == 1)
            {
                cust_id = 0;
                EnableEdit();
                lblCust_ID.Text = "Not Assigned";


                txtCompanyName.Focus();
            }
            else
            {
                LoadCustDetails();
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


        private void LoadState()
        {
            DataTable State = new DataTable();
            SqlConnection con = new SqlConnection(DBUtil.constring);
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT id, name FROM M_State", con);
                SqlDataReader dtr;
                con.Open();
                dtr = cmd.ExecuteReader();
                State.Load(dtr);
                foreach (DataRow row in State.Rows)
                {
                    string name = (string)row["name"];
                    row["name"] = name.Trim();
                }

                cbState.DataSource = State;
                cbState.DisplayMember = "name";
                cbState.ValueMember = "id";

                cbState.SelectedIndex = cbState.FindStringExact("Selangor", 0);

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



        private void LoadTerms()
        {

            DataTable Terms = new DataTable();
            SqlConnection con = new SqlConnection(DBUtil.constring);
            try
            {

                //SqlDataAdapter adapter = new SqlDataAdapter("SELECT type, name FROM M_Terms", con);
                SqlCommand cmd = new SqlCommand("SELECT type, name FROM M_Terms", con);
                SqlDataReader dtr;
                con.Open();
                dtr = cmd.ExecuteReader();
                Terms.Load(dtr);
                foreach (DataRow row in Terms.Rows)
                {
                    string name = (string)row["name"];
                    row["name"] = name.Trim();
                }

                cbTerm.DataSource = Terms;
                cbTerm.DisplayMember = "name";
                cbTerm.ValueMember = "type";


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

            cbTerm.SelectedIndex = 4;


        }

        private void LoadCustDetails()
        {
            int term = 0;
            int ctry = 0;
            int cbstate = 0;
            string sql = "SELECT * FROM M_CompanyInfo WHERE id=" + cust_id.ToString();
            SqlConnection sqConnection = new SqlConnection(DBUtil.constring);
            SqlCommand sqCommand = new SqlCommand(sql, sqConnection);
            sqConnection.Open();
            try
            {
                SqlDataReader sqReader = sqCommand.ExecuteReader();

                while (sqReader.Read())
                {
                    lblCust_ID.Text = cust_id.ToString();

                    txtCompanyName.Text = SqlGetString(sqReader, "name");
                    txtAdd1.Text = SqlGetString(sqReader, "add1");
                   // txtAdd2.Text = SqlGetString(sqReader, "add2");
                  //  txtAdd3.Text = SqlGetString(sqReader, "add3");
                    txtEmail.Text = SqlGetString(sqReader, "email");
                    txtFax.Text = SqlGetString(sqReader, "fax");
                    txtMobile.Text = SqlGetString(sqReader, "tel");
                    txtPic.Text = SqlGetString(sqReader, "pic");
                    txtPostcode.Text = SqlGetString(sqReader, "postcode");
                    txtTel.Text = SqlGetString(sqReader, "tel");
                    txtCity.Text = SqlGetString(sqReader, "city");
                    string state = DBUtil.GetStateName(Convert.ToInt32(sqReader["state"]));
                    int index = cbState.FindStringExact(state);
                    cbState.SelectedIndex = index;
                    txtState.Text = state;
                    



                    //ctry = sqReader.GetByte(sqReader.GetOrdinal("country"));
                    ctry = sqReader.GetInt16(sqReader.GetOrdinal("country"));
                    string country = DBUtil.GetCountryName(ctry);
                    txtCountry.Text = country;
                    cbCountry.SelectedIndex = cbCountry.FindStringExact(country, 0);

                    decimal c = sqReader.GetDecimal(sqReader.GetOrdinal("limit"));
                    txtCredit.Text = c.ToString();
                    //txtCredit.Text = sqReader.GetDecimal(sqReader.GetOrdinal("limit")).ToString();

                    term = sqReader.GetInt16(sqReader.GetOrdinal("term"));
                    string termstr = DBUtil.GetTermName(term);
                    txtTerm.Text = termstr;
                    cbTerm.SelectedIndex = cbTerm.FindStringExact(termstr, 0);

                    cbInvoice.Checked = Util.isChecked(sqReader.GetByte(sqReader.GetOrdinal("allow_invoice")));
                    cbDO.Checked = Util.isChecked(sqReader.GetByte(sqReader.GetOrdinal("allow_do")));


                    /*
                    txtAdd2.Text = sqReader.GetString(sqReader.GetOrdinal("add2"));
                    
                    txtEmail.Text = sqReader.GetString(sqReader.GetOrdinal("email"));
                    txtFax.Text = sqReader.GetString(sqReader.GetOrdinal("fax"));
                    txtMobile.Text = sqReader.GetString(sqReader.GetOrdinal("tel"));
                    txtPic.Text = sqReader.GetString(sqReader.GetOrdinal("pic"));
                    txtPostcode.Text = sqReader.GetString(sqReader.GetOrdinal("postcode"));
                    txtTel.Text = sqReader.GetString(sqReader.GetOrdinal("tel"));
                    string state = sqReader.GetString(sqReader.GetOrdinal("state"));
                    txtState.Text = state;
                    */
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
            txtCompanyName.ReadOnly = false;
            txtAdd1.ReadOnly = false;
            //txtAdd2.ReadOnly = false;
            // txtAdd3.ReadOnly = false;
            txtCredit.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtFax.ReadOnly = false;
            txtMobile.ReadOnly = false;
            txtPic.ReadOnly = false;
            txtPostcode.ReadOnly = false;
            txtTel.ReadOnly = false;
            txtCity.ReadOnly = false;
            cbState.Enabled = true;
            txtCountry.Visible = false;
            txtTerm.Visible = false;
            cbDO.Enabled = true;
            cbInvoice.Enabled = true;
            txtState.ReadOnly = true;
            txtState.Visible = false;
            cbCountry.Visible = true;
            cbTerm.Visible = true;
            cbTerm.SelectedIndex = cbTerm.FindStringExact(txtTerm.Text, 0);

            cbCountry.SelectedIndex = cbCountry.FindStringExact(txtCountry.Text, 0);
            txtCompanyName.Focus();
        }
        private void CustAED_Load(object sender, EventArgs e)
        {

            LoadTerms();

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


            string sql = "DELETE FROM M_CompanyInfo WHERE id=" + cust_id.ToString();

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
            float credit = 0;
            string sql = "";



            if (txtCompanyName.TextLength == 0)
            {
                MessageBox.Show("Company Name must be entered");
                txtCompanyName.Focus();
                return;
            }
            if (txtPic.TextLength == 0)
            {
                MessageBox.Show("PIC must be entered");
                txtPic.Focus();
                return;
            }
            if (txtTel.TextLength == 0)
            {
                MessageBox.Show("Tel No. must be entered");
                txtTel.Focus();
                return;
            }
            try
            {
                credit = float.Parse(txtCredit.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Credit limit is not valid");
                txtCredit.Focus();
                return;
            }


            StringBuilder sq = new StringBuilder();
            if (cust_id == 0)
            {

                sq.Append("INSERT INTO M_CompanyInfo (name,add1,postcode,city,state,country,pic,tel,fax,mobile,email,limit,term,allow_invoice,allow_do) VALUES (");
                sq.Append("'" + txtCompanyName.Text.Trim());
                sq.Append("','" + txtAdd1.Text.Trim());
               // sq.Append("','" + txtAdd2.Text.Trim());
                //sq.Append("','" + txtAdd3.Text.Trim());
                sq.Append("','" + txtPostcode.Text.Trim());
                sq.Append("','" + txtCity.Text.Trim());
                sq.Append("','" + cbState.SelectedValue);
                sq.Append("'," + cbCountry.SelectedValue);
                sq.Append(",'" + txtPic.Text.Trim());
                sq.Append("','" + txtTel.Text.Trim());
                sq.Append("','" + txtFax.Text.Trim());
                sq.Append("','" + txtMobile.Text.Trim());
                sq.Append("','" + txtEmail.Text.Trim());
                sq.Append("'," + credit.ToString());
                sq.Append("," + cbTerm.SelectedValue);
                sq.Append("," + Util.BoolToInt(cbInvoice.Checked));
                sq.Append("," + Util.BoolToInt(cbDO.Checked));
                sq.Append(")");
                sql = sq.ToString();
            }
            else
            {
                sq.Append("UPDATE M_CompanyInfo SET ");
                sq.Append("name='" + txtCompanyName.Text.Trim() + "',");
                sq.Append("add1='" + txtAdd1.Text.Trim() + "',");
                //sq.Append("add2='" + txtAdd2.Text.Trim() + "',");
                //sq.Append("add3='" + txtAdd3.Text.Trim() + "',");
                sq.Append("postcode='" + txtPostcode.Text.Trim() + "',");
                sq.Append("city='" + txtCity.Text.Trim() + "',");
                sq.Append("state='" + cbState.SelectedValue + "',");
                sq.Append("country=" + cbCountry.SelectedValue + ",");
                sq.Append("pic='" + txtPic.Text.Trim() + "',");
                sq.Append("tel='" + txtTel.Text.Trim() + "',");
                sq.Append("fax='" + txtFax.Text.Trim() + "',");
                sq.Append("mobile='" + txtMobile.Text.Trim() + "',");
                sq.Append("email='" + txtEmail.Text.Trim() + "',");
                sq.Append("limit=" + credit.ToString() + ",");
                sq.Append("term=" + cbTerm.SelectedValue.ToString() + ",");
                sq.Append("allow_invoice=" + Util.BoolToInt(cbInvoice.Checked)+ ",");
                sq.Append("allow_do=" + Util.BoolToInt(cbDO.Checked));
                sq.Append(" ");
                sq.Append("WHERE id=" + cust_id.ToString());
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
                if (cust_id == 0)
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
            txtCompanyName.ReadOnly = true;
            txtAdd1.ReadOnly = true;
            //txtAdd2.ReadOnly = true;
            //txtAdd3.ReadOnly = true;
            txtCredit.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtFax.ReadOnly = true;
            txtMobile.ReadOnly = true;
            txtPic.ReadOnly = true;
            txtPostcode.ReadOnly = true;
            txtTel.ReadOnly = true;
            //txtState.ReadOnly = true;
            txtCountry.ReadOnly = true;
            cbInvoice.Enabled = false;
            cbDO.Enabled = false;
            cbState.Enabled = false;
            txtCountry.Visible = true;
            cbCountry.Visible = false;
            txtTerm.Visible = true;
            cbTerm.Visible = false;
            txtState.ReadOnly = true;
            txtState.Visible = true;
            LoadCustDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cust_id == 0)
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
            txtCompanyName.Text = txtCompanyName.Text.ToUpper();
        }

        private void txtAdd1_Leave(object sender, EventArgs e)
        {
            txtAdd1.Text = txtAdd1.Text.ToUpper();
        }

      //  private void txtAdd2_Leave(object sender, EventArgs e)
     //   {
           // txtAdd2.Text = txtAdd2.Text.ToUpper();
      //  }

       // private void txtAdd3_Leave(object sender, EventArgs e)
       // {
            //txtAdd3.Text = txtAdd3.Text.ToUpper();
     //   }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            txtCity.Text = txtCity.Text.ToUpper();
        }

        private void txtPic_Leave(object sender, EventArgs e)
        {
            txtPic.Text = txtPic.Text.ToUpper();
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountry.SelectedIndex > -1)
            {
                int Country = cbCountry.SelectedIndex;
                int Index = cbCountry.FindStringExact("Malaysia");

                if (Country != Index)
                {
                    int State = cbState.FindStringExact("Others");
                    cbState.SelectedIndex = State;
                }
                else
                {
                    if (lblCust_ID.Text == "Not Assigned")
                    {

                        int State = cbState.FindStringExact("Selangor");
                        cbState.SelectedIndex = State;
                    }
                }
            }
        }
    }
}
