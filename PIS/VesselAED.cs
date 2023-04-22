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
    public partial class VesselAED : Form
    {
        private int row_id = 0;
        private string dbtblname = "M_Vessel";

        public VesselAED(int mode, int id)
        {
            InitializeComponent();

            row_id = id;

            if (mode == 1)
            {
                row_id = 0;
                EnableEdit();
                lbl_ID.Text = "Not Assigned";


                tbVessel_Id.Focus();
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

        private void LoadCustomerList(ComboBox cb)
        {

            DataTable Customer = new DataTable();
            SqlConnection con = new SqlConnection(DBUtil.constring);
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT id, name FROM M_CompanyInfo", con);
                SqlDataReader dtr;
                con.Open();
                dtr = cmd.ExecuteReader();
                Customer.Load(dtr);
                foreach (DataRow row in Customer.Rows)
                {
                    string name = (string)row["name"];
                    row["name"] = name.Trim();
                }

                cb.DataSource = Customer;
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


            int portoperator = 0;
            int psa = 0;
            int sa = 0;
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
                    tbVessel_Id.Text = SqlGetString(sqReader, "vid");
                    tbVesselName.Text = SqlGetString(sqReader, "name");

                    //Load Combo type data
                    portoperator = sqReader.GetInt32(sqReader.GetOrdinal("port_operator"));
                    string s_portoperator = DBUtil.GetCompanyName(portoperator);
                    txtPortOperator.Text = s_portoperator;
                    cbPortOperator.SelectedIndex = cbPortOperator.FindStringExact(s_portoperator, 0);

                    psa = sqReader.GetInt32(sqReader.GetOrdinal("psa"));
                    string s_psa = DBUtil.GetCompanyName(psa);
                    tbPSA.Text = s_psa;
                    cbPSA.SelectedIndex = cbPSA.FindStringExact(s_psa, 0);

                    sa = sqReader.GetInt32(sqReader.GetOrdinal("s_agent"));
                    string s_sa = DBUtil.GetCompanyName(sa);
                    tbShippingAgent.Text = s_sa;
                    cbShippingAgent.SelectedIndex = cbShippingAgent.FindStringExact(s_sa, 0);

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
            tbVesselName.ReadOnly = false;
            tbVessel_Id.ReadOnly = false;

            //For combobox
            tbShippingAgent.Visible = false;
            txtPortOperator.Visible = false;
            tbPSA.Visible = false;

            cbPortOperator.Visible = true;
            cbPSA.Visible = true;
            cbShippingAgent.Visible = true;


            cbPortOperator.SelectedIndex = cbPortOperator.FindStringExact(txtPortOperator.Text, 0);
            cbPSA.SelectedIndex = cbPSA.FindStringExact(tbPSA.Text, 0);
            cbShippingAgent.SelectedIndex = cbShippingAgent.FindStringExact(tbShippingAgent.Text, 0);

            if (row_id != 0)
            {
                lblEdit.Visible = true;
                tbVessel_Id.ReadOnly = true;
                tbVesselName.Focus();
            }
            else
            {
                tbVessel_Id.ReadOnly = false;
                tbVessel_Id.Focus();
            }
            
           
            
        }
        private void CustAED_Load(object sender, EventArgs e)
        {

            LoadCustomerList(cbPortOperator);
            LoadCustomerList(cbPSA);
            LoadCustomerList(cbShippingAgent);
          
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
     
            if (tbVessel_Id.TextLength==0)
            {
               
                MessageBox.Show("Code must be entered");
                tbVessel_Id.Focus();
                return;

            }
            else
            {
                if (row_id == 0)
                {
                    if (DBUtil.isExistinDB(dbtblname, "vid", tbVessel_Id.Text))
                    {

                        MessageBox.Show("Code already exist, try another");
                        tbVessel_Id.Focus();
                        return;
                    }
                }
            }
            
            if (tbVesselName.TextLength == 0)
            {
               

                MessageBox.Show("Name must be entered");
                tbVesselName.Focus();
                return;
            }
            
            
            StringBuilder sq = new StringBuilder();
            if (row_id == 0)
            {

                sq.Append("INSERT INTO ");
                sq.Append(dbtblname +" ");
                sq.Append ("(vid,name,port_operator,psa,s_agent) VALUES (");
                sq.Append("'" + tbVessel_Id.Text.Trim());
                sq.Append("','" + tbVesselName.Text.Trim());
                sq.Append("'," + cbPortOperator.SelectedValue);
                sq.Append("," + cbPSA.SelectedValue);
                sq.Append("," + cbShippingAgent.SelectedValue);
                sq.Append(")");
                sql = sq.ToString();
            }
            else
            {
                sq.Append("UPDATE ");
                sq.Append(dbtblname +" SET ");
               // sq.Append("code='" + tbCode.Text.Trim() + "',");
                sq.Append("name='" + tbVesselName.Text.Trim() + "',");
                sq.Append("port_operator=" + cbPortOperator.SelectedValue.ToString() + ",");
                sq.Append("psa=" + cbPSA.SelectedValue.ToString() + ",");
                sq.Append("s_agent=" + cbShippingAgent.SelectedValue.ToString());
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
            tbVessel_Id.ReadOnly = true;
            tbVesselName.ReadOnly = true;

            //For combobox
            tbPSA.ReadOnly = true;
            tbShippingAgent.ReadOnly = true;
            txtPortOperator.ReadOnly = true;

            tbPSA.Visible = true;
            tbShippingAgent.Visible = true;
            txtPortOperator.Visible = true;

            cbPortOperator.Visible = false;
            cbShippingAgent.Visible = false;
            cbPSA.Visible = false;

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
            tbVessel_Id.Text = tbVessel_Id.Text.ToUpper();
        }

        private void txtAdd1_Leave(object sender, EventArgs e)
        {
            tbVesselName.Text = tbVesselName.Text.ToUpper();
        }

       

        
    }
}
