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
    public partial class CSizeAED : Form
    {
        private int row_id = 0;
        private string dbtblname = "M_CSize";
        private int UserID = 0;

        public CSizeAED(int mode, int id, int LoginID)
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
                    tbName.Text = SqlGetString(sqReader, "name");
                    nmTeus.Value = sqReader.GetByte(sqReader.GetOrdinal("teus"));


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
            nmTeus.ReadOnly = false;
            nmTeus.Enabled = true;
           
            tbCode.Focus();
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
            
            if (tbName.TextLength == 0)
            {
               

                MessageBox.Show("Description must be entered");
                tbName.Focus();
                return;
            }
            
            
            StringBuilder sq = new StringBuilder();
            if (row_id == 0)
            {

                sq.Append("INSERT INTO ");
                sq.Append(dbtblname +" ");
                sq.Append ("(code,name,teus) VALUES (");
                sq.Append("'" + tbCode.Text.Trim());
                sq.Append("','" + tbName.Text.Trim());
                sq.Append("'," + nmTeus.Value.ToString());
                sq.Append(")");
                sql = sq.ToString();
            }
            else
            {
                sq.Append("UPDATE ");
                sq.Append(dbtblname +" SET ");
                sq.Append("code='" + tbCode.Text.Trim() + "',");
                sq.Append("name='" + tbName.Text.Trim() + "',");
                sq.Append("teus=" + nmTeus.Value.ToString());

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
            tbCode.ReadOnly = true;
            tbName.ReadOnly = true;
            nmTeus.ReadOnly = true;
            nmTeus.Enabled = false;
            
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
            tbName.Text = tbName.Text.ToUpper();
        }

       

        
    }
}
