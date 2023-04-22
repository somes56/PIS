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
    public partial class InvoiceAED : Form
    {
        private int inv_id = 0;
        public InvoiceAED(int mode, int id)
        {
            InitializeComponent();

            inv_id = id;

            if (mode == 1)
            {
                inv_id = 0;
                EnableEdit();
                lblCust_ID.Text = "Not Assigned";
                //cbState.SelectedIndex = 14;
                
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

               // cbTerm.DataSource = Terms;
               // cbTerm.DisplayMember = "name";
               // cbTerm.ValueMember = "type";


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

           // cbTerm.SelectedIndex = 4;


        }

        private void LoadCustDetails()
        {
            int term = 0;
            string sql = "SELECT * FROM M_CompanyInfo WHERE id=" + inv_id.ToString();
            SqlConnection sqConnection = new SqlConnection(DBUtil.constring);
            SqlCommand sqCommand = new SqlCommand(sql, sqConnection);
            sqConnection.Open();
            try
            {
                SqlDataReader sqReader = sqCommand.ExecuteReader();

                while (sqReader.Read())
                {
                    lblCust_ID.Text = inv_id.ToString();

                    txtCompanyName.Text = SqlGetString(sqReader, "name");
                    txtAdd1.Text = SqlGetString(sqReader, "add1");
  
                 //   txtEmail.Text = SqlGetString(sqReader, "email");
                    txtFax.Text = SqlGetString(sqReader, "fax");
                    txtMobile.Text = SqlGetString(sqReader, "tel");
                  //  txtPic.Text = SqlGetString(sqReader, "pic");
                    txtPostcode.Text = SqlGetString(sqReader, "postcode");
                    txtTel.Text = SqlGetString(sqReader, "tel");
                 //   txtCity.Text = SqlGetString(sqReader, "city");
                    string state = SqlGetString(sqReader, "state");
                 //   txtState.Text = state;
                    //cbState.SelectedIndex = cbState.FindStringExact(state, 0);
                    decimal c = sqReader.GetDecimal(sqReader.GetOrdinal("limit"));
                    //txtCredit.Text = sqReader.GetDecimal(sqReader.GetOrdinal("limit")).ToString();
                    term = sqReader.GetInt16(sqReader.GetOrdinal("term"));
                    string termstr= DBUtil.GetTermName(term);
               //     txtTerm.Text = termstr;
                //    cbTerm.SelectedIndex = cbTerm.FindStringExact(termstr, 0);
                //    txtCredit.Text = c.ToString();
                    
                   
                    

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
         //    txtCredit.ReadOnly = false;
         //   txtEmail.ReadOnly = false;
            txtFax.ReadOnly = false;
            txtMobile.ReadOnly = false;
         //   txtPic.ReadOnly = false;
            txtPostcode.ReadOnly = false;
            txtTel.ReadOnly = false;
         //   txtCity.ReadOnly = false;
         //   txtState.Visible = false;
         //   txtTerm.Visible = false;
          //  cbState.Visible = true;
         //   cbTerm.Visible = true;
         //   cbTerm.SelectedIndex = cbTerm.FindStringExact(txtTerm.Text, 0);
           // cbState.SelectedIndex = cbState.FindStringExact(txtState.Text, 0);
            txtCompanyName.Focus();
        }
        private void CustAED_Load(object sender, EventArgs e)
        {

            LoadTerms();

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

            string sql = "DELETE FROM M_CompanyInfo WHERE id=" + inv_id.ToString();

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
           // if (txtPic.TextLength == 0)
           // {
                MessageBox.Show("PIC must be entered");
             //   txtPic.Focus();
          //      return;
           // }
            if (txtTel.TextLength == 0)
            {
                MessageBox.Show("Tel No. must be entered");
                txtTel.Focus();
                return;
            }
            try
            {
                //credit = float.Parse(txtCredit.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Credit limit is not valid");
                //txtCredit.Focus();
                return;
            }
            StringBuilder sq = new StringBuilder();
            if (inv_id == 0)
            {

                sq.Append("INSERT INTO M_CompanyInfo (name,add1,add2,add3,postcode,city,state,pic,tel,fax,mobile,email,limit,term) VALUES (");
                sq.Append("'" + txtCompanyName.Text.Trim());
                sq.Append("','" + txtAdd1.Text.Trim());
 
                sq.Append("','" + txtPostcode.Text.Trim());
              //  sq.Append("','" + txtCity.Text.Trim());
               // sq.Append("','" + cbState.GetItemText(cbState.SelectedItem).Trim());
               // sq.Append("','" + txtPic.Text.Trim());
                sq.Append("','" + txtTel.Text.Trim());
                sq.Append("','" + txtFax.Text.Trim());
                sq.Append("','" + txtMobile.Text.Trim());
               // sq.Append("','" + txtEmail.Text.Trim());
                sq.Append("'," + credit.ToString());
              //  sq.Append("," + cbTerm.SelectedValue);
                sq.Append(")");
                sql = sq.ToString();
            }
            else
            {
                sq.Append("UPDATE M_CompanyInfo SET ");
                sq.Append("name='" + txtCompanyName.Text.Trim() + "',");
                sq.Append("add1='" + txtAdd1.Text.Trim() + "',");
                
                sq.Append("postcode='" + txtPostcode.Text.Trim() + "',");
                //sq.Append("city='" + txtCity.Text.Trim() + "',");
              //  sq.Append("state='" + cbState.GetItemText(cbState.SelectedItem) + "',");
              //  sq.Append("pic='" + txtPic.Text.Trim() + "',");
                sq.Append("tel='" + txtTel.Text.Trim() + "',");
                sq.Append("fax='" + txtFax.Text.Trim() + "',");
                sq.Append("mobile='" + txtMobile.Text.Trim() + "',");
              //  sq.Append("email='" + txtEmail.Text.Trim() + "',");
                sq.Append("limit=" + credit.ToString() + ",");
               // sq.Append("term=" + cbTerm.SelectedValue.ToString());
                sq.Append(" ");
                sq.Append("WHERE id=" + inv_id.ToString());
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
                if (inv_id == 0)
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
    
         //   txtCredit.ReadOnly = true;
         //   txtEmail.ReadOnly = true;
            txtFax.ReadOnly = true;
            txtMobile.ReadOnly = true;
          //  txtPic.ReadOnly = true;
            txtPostcode.ReadOnly = true;
            txtTel.ReadOnly = true;
          //  txtState.ReadOnly = true;
           // txtState.ReadOnly = true;
          //  txtState.Visible = true;
          //  cbState.Visible = false;
          //  txtTerm.Visible = true;
          //  cbTerm.Visible = false;
            LoadCustDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (inv_id == 0)
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

       

        private void txtCity_Leave(object sender, EventArgs e)
        {
            //txtCity.Text = txtCity.Text.ToUpper();
        }

        private void txtPic_Leave(object sender, EventArgs e)
        {
           // txtPic.Text = txtPic.Text.ToUpper();
        }

       

     



    

    }
}
