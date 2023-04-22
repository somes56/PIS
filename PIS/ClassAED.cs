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
    public partial class ClassAED : Form
    {
        private int row_id = 0;
        private string dbtblname = "M_Class";
        private int UserID = 0;

        public ClassAED(int mode, int id, int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();

            row_id = id;

            if (mode == 1)
            {
                row_id = 0;
                EnableEdit();
                lblCust_ID.Text = "Not Assigned";


                tbCode.Focus();
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

       
        
        private void LoadDetails()
        {
            
           
            string sql = "SELECT * FROM "+ dbtblname +" WHERE id=" + row_id.ToString();
            SqlConnection sqConnection = new SqlConnection(DBUtil.constring);
            SqlCommand sqCommand = new SqlCommand(sql, sqConnection);
            sqConnection.Open();
            try
            {
                SqlDataReader sqReader = sqCommand.ExecuteReader();

                while (sqReader.Read())
                {
                    lblCust_ID.Text = row_id.ToString();
                    tbCode.Text = SqlGetString(sqReader, "code");
                    tbShortName.Text = SqlGetString(sqReader, "shortname");
                    tbFullName.Text = SqlGetString(sqReader, "fullname");


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
            tbShortName.ReadOnly = false;
            tbFullName.ReadOnly = false;

            if (row_id != 0)
            {
                lblEdit.Visible = true;
                tbCode.ReadOnly = true;
                tbShortName.Focus();
            }
            else
            {
                tbCode.ReadOnly = false;
                tbCode.Focus();
            }
            
           
            
        }
        private void CustAED_Load(object sender, EventArgs e)
        {

          
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
     
            if (tbCode.TextLength==0)
            {
               
                MessageBox.Show("Code must be entered");
                tbCode.Focus();
                return;

            }
            else
            {
                if (row_id == 0)
                {
                    if (DBUtil.isExistinDB(dbtblname, "code", tbCode.Text))
                    {

                        MessageBox.Show("Code already exist, try another");
                        tbCode.Focus();
                        return;
                    }
                }
            }
            
            if (tbShortName.TextLength == 0)
            {
               

                MessageBox.Show("Short Name must be entered");
                tbShortName.Focus();
                return;
            }
            
            
            StringBuilder sq = new StringBuilder();
            if (row_id == 0)
            {

                sq.Append("INSERT INTO ");
                sq.Append(dbtblname +" ");
                sq.Append ("(code,shortname,fullname) VALUES (");
                sq.Append("'" + tbCode.Text.Trim());
                sq.Append("','" + tbShortName.Text.Trim());
                sq.Append("','" + tbFullName.Text.Trim());
                sq.Append("')");
                sql = sq.ToString();
            }
            else
            {
                sq.Append("UPDATE ");
                sq.Append(dbtblname +" SET ");
               // sq.Append("code='" + tbCode.Text.Trim() + "',");
                sq.Append("shortname='" + tbShortName.Text.Trim() + "',");
                sq.Append("fullname='" + tbFullName.Text.Trim() + "'");

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
            tbCode.ReadOnly = true;
            tbShortName.ReadOnly = true;
            tbFullName.ReadOnly = true;
            
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
            tbCode.Text = tbCode.Text.ToUpper();
        }

        private void txtAdd1_Leave(object sender, EventArgs e)
        {
            tbShortName.Text = tbShortName.Text.ToUpper();
        }

       

        
    }
}
