using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PIS
{
    public partial class ItemCodeAED : Form
    {
        private int UserID = 0;

        public ItemCodeAED(int ItemID, int LoginID)
        {
            UserID = LoginID;
            InitializeComponent();

            if (ItemID != 0)
            {
                LoadItemDetails(ItemID);
                lblItemID.Text = ItemID.ToString();
                DisableEdit();
            }
            else
            {
                lblItemID.Text = "0";
                EnableEdit();
            }
        }

        private void ItemCodeAED_Load(object sender, EventArgs e)
        {

        }

        public void LoadItemDetails(int ID)
        {
            SqlConnection conn = new SqlConnection(DBUtil.constring);

            try
            {
                string sqlstr = "SELECT id, code, name FROM [dbo].[M_ItemCode] WHERE id = '" + ID + "'";

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    lblItemID.Text = dr["id"].ToString().Trim();
                    txtItemCode.Text = dr["code"].ToString().Trim();
                    txtItemName.Text = dr["name"].ToString().Trim();
                }
                dr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                txtItemCode.ResetText();
                txtItemName.ResetText();
                return;
            }
            finally
            {
                conn.Close();
            }

        }

        public void EnableEdit()
        {
            pnlEdit.Visible = false;
            pnlSave.Visible = true;
            txtItemCode.ReadOnly = false;
            txtItemName.ReadOnly = false;
        }

        public void DisableEdit()
        {
            pnlEdit.Visible = true;
            pnlSave.Visible = false;
            txtItemCode.ReadOnly = true;
            txtItemName.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(lblItemID.Text.ToString().Trim());
            var ItemCode = txtItemCode.Text.ToString().Trim();
            var ItemName = txtItemName.Text.ToString().Trim();
            string sqlstr = "";

            if (ItemCode == "")
            {
                MessageBox.Show("Item Code is required.", "Warning");
                return;
            }

            if (ItemName == "")
            {
                MessageBox.Show("Item Name is required.", "Warning");
                return;
            }

            if (ID != 0)
            {
                sqlstr = "UPDATE [dbo].[M_ItemCode] SET code = '" + ItemCode + "', name = '" + ItemName + "' WHERE id = '" + ID + "'";
            }
            else
            {
                sqlstr = "INSERT INTO [dbo].[M_ItemCode](code,name)VALUES('" + ItemCode + "','" + ItemName + "')";
            }

            SqlConnection conn = new SqlConnection(DBUtil.constring);

            try
            {
                var command = new SqlCommand(sqlstr, conn);
                conn.Open();
                command.ExecuteNonQuery();
                LoadItemDetails(ID);
                DisableEdit();
            }
            catch(Exception)
            {
                MessageBox.Show(e.ToString());
                return;
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableEdit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int ID = 0;
            ID = Convert.ToInt32(lblItemID.Text.ToString().Trim());
            int Admin = 0;
            Admin = DBUtil.GetAdminFlag(UserID);

            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Delete this record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                if (Admin == 0)
                {
                    MessageBox.Show("Sorry, You do not have admin privilege to delete this master.", "Warning!");
                    return;
                }

                SqlConnection conn = new SqlConnection(DBUtil.constring);

                try
                {
                    string sqlstr = "DELETE FROM [dbo].[M_ItemCode] WHERE id = '" + ID + "'";
                    var command = new SqlCommand(sqlstr, conn);
                    conn.Open();
                    command.ExecuteNonQuery();
                    this.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show(e.ToString(),"Error");
                    return;
                }
                finally
                {
                    conn.Close();
                }

            }
            else if (dlgResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
