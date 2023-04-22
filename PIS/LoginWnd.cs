using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS
{
    public partial class LoginWnd : Form
    {
        private DBUtil dbutil=new DBUtil();
        public LoginWnd()
        {
            InitializeComponent();

            lblDeploy.Text = "BUILD 20220728 (DEPLOY25)";
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            int LoginID = 0;
             
            DataSet ds = new DataSet();
            ds = DBUtil.ValidateUser(this.tbUsername.Text.Trim(), this.tbPassword.Text.Trim());
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.Hide();
                //Disabling Pioneerpac intergrated system for now.
                //MainApp mainwindow = new MainApp();
                //mainwindow.Show();

                LoginID = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
                MainAppWH mainwindowwh = new MainAppWH(LoginID);
                mainwindowwh.Show();


            }

            else
            {
                MessageBox.Show("Invalid Login, Try Again", "Error");
            }
        }

            
   

        private void LoginWnd_Load(object sender, EventArgs e)
        {

        }
    }
}
