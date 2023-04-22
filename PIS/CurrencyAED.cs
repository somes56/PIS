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
    public partial class CurrencyAED : Form
    {
        private int Currency_ID = 0;
        private int UserID = 0;

        public CurrencyAED(int Mode, int ID, int LoginID)
        {
            Currency_ID = ID;
            UserID = LoginID;
            InitializeComponent();

            if (Mode == 1)
            {
                Currency_ID = 0;
                EnableEdit();
                lblCurr_ID.Text = "Not Assigned";

            }
            else
            {
                LoadCurrencyDetails();
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

        public void LoadCurrencyDetails()
        {
            SqlConnection conn = new SqlConnection(DBUtil.constring);

            string sqlstr = "SELECT * FROM [dbo].[M_Currency] WHERE id = '" + Currency_ID.ToString() + "' ";

            var command = new SqlCommand(sqlstr, conn);

            conn.Open();

            try
            {
                SqlDataReader sqReader = command.ExecuteReader();

                while (sqReader.Read())
                {
                    lblCurr_ID.Text = Currency_ID.ToString();
                    tbCode.Text = SqlGetString(sqReader, "code") ;
                    tbName.Text = SqlGetString(sqReader, "name");
                    cbFav.Checked = Util.isChecked(sqReader.GetByte(sqReader.GetOrdinal("fav")));
                }
                sqReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void EnableEdit()
        {
            pnlEdit.Visible = false;
            pnlSave.Visible = true;
            tbCode.ReadOnly = false;
            tbName.ReadOnly = false;
            cbFav.Enabled = true;
            tbCode.Focus();
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

            SqlConnection conn = new SqlConnection(DBUtil.constring);

            string sqlstr = "DELETE FROM [dbo].[M_Currency] WHERE id = '" + Currency_ID.ToString() + "' ";

            var command = new SqlCommand(sqlstr, conn);

            conn.Open();

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Close();
            }
            finally
            {
                conn.Close();
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sqlstr = "";

            if (tbCode.TextLength == 0)
            {
                MessageBox.Show("Currency Code must be entered");
                tbCode.Focus();
                return;
            }

            if (tbName.TextLength == 0)
            {
                MessageBox.Show("Currency Name must be entered");
                tbName.Focus();
                return;
            }

            StringBuilder sq = new StringBuilder();

            if (Currency_ID == 0)
            {
                sq.Append("INSERT INTO M_Currency (code,name,fav) VALUES (");
                sq.Append("'" + tbCode.Text.Trim());
                sq.Append("','" + tbName.Text.Trim());
                sq.Append("'," + Util.BoolToInt(cbFav.Checked));
                sq.Append(")");

                sqlstr = sq.ToString();
            }
            else
            {
                sq.Append("UPDATE [dbo].[M_Currency] SET ");
                sq.Append("code='" + tbCode.Text.Trim() + "',");
                sq.Append("name='" + tbName.Text.Trim() + "',");
                sq.Append("fav=" + Util.BoolToInt(cbFav.Checked));
                sq.Append(" ");
                sq.Append("WHERE id=" + Currency_ID.ToString());
                sqlstr = sq.ToString();
            }

            SqlConnection conn = new SqlConnection(DBUtil.constring);

            var command = new SqlCommand(sqlstr, conn);

            conn.Open();

            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Close();
            }
            finally
            {
                conn.Close();

                if (Currency_ID == 0)
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

            LoadCurrencyDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Currency_ID == 0)
            {
                Close();
            }
            else
            {

                DisableEdit();
            }
        }

        private void tbCode_Leave(object sender, EventArgs e)
        {
            tbCode.Text = tbCode.Text.ToUpper();
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            tbName.Text = tbName.Text.ToUpper();
        }
    }
}
