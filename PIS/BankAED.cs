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
    public partial class BankAED : Form
    {
        private int bank_id = 0;

        public BankAED(int mode, int id)
        {
            InitializeComponent();

            bank_id = id;

            if (mode == 1)
            {
                bank_id = 0;
                EnableEdit();
                lblCust_ID.Text = "Not Assigned";


                tbAccNo.Focus();
            }
            else
            {
                LoadBankDetails();
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
        
        private void LoadBankDetails()
        {
            
            int ctry = 0;
            string sql = "SELECT * FROM M_BankInfo WHERE id=" + bank_id.ToString();
            SqlConnection sqConnection = new SqlConnection(DBUtil.constring);
            SqlCommand sqCommand = new SqlCommand(sql, sqConnection);
            sqConnection.Open();
            try
            {
                SqlDataReader sqReader = sqCommand.ExecuteReader();

                while (sqReader.Read())
                {
                    lblCust_ID.Text = bank_id.ToString();

                    tbAccNo.Text = SqlGetString(sqReader, "accno");
                    txtBankName.Text = SqlGetString(sqReader, "name");
                    txtAdd1.Text = SqlGetString(sqReader, "add1");
                    txtAdd2.Text = SqlGetString(sqReader, "add2");
                    txtAdd3.Text = SqlGetString(sqReader, "add3");
                    txtEmail.Text = SqlGetString(sqReader, "email");
                    txtFax.Text = SqlGetString(sqReader, "fax");
                    txtMobile.Text = SqlGetString(sqReader, "tel");
                    txtPic.Text = SqlGetString(sqReader, "pic");
                    txtPostcode.Text = SqlGetString(sqReader, "postcode");
                    txtTel.Text = SqlGetString(sqReader, "tel");
                    txtCity.Text = SqlGetString(sqReader, "city");
                    txtState.Text = SqlGetString(sqReader, "state");

                    ctry = sqReader.GetInt16(sqReader.GetOrdinal("country"));
                    string country = DBUtil.GetCountryName(ctry);
                    txtCountry.Text = country;
                    cbCountry.SelectedIndex = cbCountry.FindStringExact(country, 0);

                   
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
            txtBankName.ReadOnly = false;
            txtAdd1.ReadOnly = false;
            txtAdd2.ReadOnly = false;
            txtAdd3.ReadOnly = false;
            tbAccNo.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtFax.ReadOnly = false;
            txtMobile.ReadOnly = false;
            txtPic.ReadOnly = false;
            txtPostcode.ReadOnly = false;
            txtTel.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtState.ReadOnly = false;
            txtCountry.Visible = false;
            cbCountry.Visible = true;

            cbCountry.SelectedIndex = cbCountry.FindStringExact(txtCountry.Text, 0);
            tbAccNo.Focus();
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
            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                // Yes, continue 
            }
            else if (dlgResult == DialogResult.No)
            {
                return;
            }

            string sql = "DELETE FROM M_BankInfo WHERE id=" + bank_id.ToString();

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

            if (tbAccNo.TextLength==0)
            {
               
                MessageBox.Show("Account No. must be entered");
                tbAccNo.Focus();
                return;

            }
            if (!(int.TryParse(tbAccNo.Text, out value)))
            {
                MessageBox.Show("Account No. must be ONLY numbers");
                tbAccNo.Focus();
                return;
            }

            if (txtBankName.TextLength == 0)
            {
               

                MessageBox.Show("Bank Name must be entered");
                txtBankName.Focus();
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
            
            StringBuilder sq = new StringBuilder();
            if (bank_id == 0)
            {

                sq.Append("INSERT INTO M_BankInfo (accno,name,add1,add2,add3,postcode,city,state,country,pic,tel,fax,mobile,email) VALUES (");
                sq.Append("'" + tbAccNo.Text.Trim());
                sq.Append("','" + txtBankName.Text.Trim());
                sq.Append("','" + txtAdd1.Text.Trim());
                sq.Append("','" + txtAdd2.Text.Trim());
                sq.Append("','" + txtAdd3.Text.Trim());
                sq.Append("','" + txtPostcode.Text.Trim());
                sq.Append("','" + txtCity.Text.Trim());
                sq.Append("','" + txtState.Text.Trim());
                sq.Append("'," + cbCountry.SelectedValue);
                sq.Append(",'" + txtPic.Text.Trim());
                sq.Append("','" + txtTel.Text.Trim());
                sq.Append("','" + txtFax.Text.Trim());
                sq.Append("','" + txtMobile.Text.Trim());
                sq.Append("','" + txtEmail.Text.Trim());
                sq.Append("')");
                sql = sq.ToString();
            }
            else
            {
                sq.Append("UPDATE M_BankInfo SET ");
                sq.Append("name='" + txtBankName.Text.Trim() + "',");
                sq.Append("accno='" + tbAccNo.Text.Trim() + "',");
                sq.Append("add1='" + txtAdd1.Text.Trim() + "',");
                sq.Append("add2='" + txtAdd2.Text.Trim() + "',");
                sq.Append("add3='" + txtAdd3.Text.Trim() + "',");
                sq.Append("postcode='" + txtPostcode.Text.Trim() + "',");
                sq.Append("city='" + txtCity.Text.Trim() + "',");
                sq.Append("state='" + txtState.Text.Trim() + "',");
                sq.Append("country=" + cbCountry.SelectedValue + ",");
                sq.Append("pic='" + txtPic.Text.Trim() + "',");
                sq.Append("tel='" + txtTel.Text.Trim() + "',");
                sq.Append("fax='" + txtFax.Text.Trim() + "',");
                sq.Append("mobile='" + txtMobile.Text.Trim() + "',");
                sq.Append("email='" + txtEmail.Text.Trim() + "'");
                sq.Append(" ");
                sq.Append("WHERE id=" + bank_id.ToString());
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
                if (bank_id == 0)
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
            txtBankName.ReadOnly = true;
            txtAdd1.ReadOnly = true;
            txtAdd2.ReadOnly = true;
            txtAdd3.ReadOnly = true;
            tbAccNo.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtFax.ReadOnly = true;
            txtMobile.ReadOnly = true;
            txtPic.ReadOnly = true;
            txtPostcode.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtState.ReadOnly = true;
            txtCountry.ReadOnly = true;
            
            txtState.ReadOnly = true;
            txtCountry.Visible = true;
            cbCountry.Visible = false;
            
            LoadBankDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bank_id == 0)
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
            txtBankName.Text = txtBankName.Text.ToUpper();
        }

        private void txtAdd1_Leave(object sender, EventArgs e)
        {
            txtAdd1.Text = txtAdd1.Text.ToUpper();
        }

        private void txtAdd2_Leave(object sender, EventArgs e)
        {
            txtAdd2.Text = txtAdd2.Text.ToUpper();
        }

        private void txtAdd3_Leave(object sender, EventArgs e)
        {
            txtAdd3.Text = txtAdd3.Text.ToUpper();
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            txtCity.Text = txtCity.Text.ToUpper();
        }

        private void txtPic_Leave(object sender, EventArgs e)
        {
            txtPic.Text = txtPic.Text.ToUpper();
        }

        
    }
}
