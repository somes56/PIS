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
    public partial class CalTariff : Form
    {
        public CalTariff()
        {
            InitializeComponent();
        }

        private void CalTariff_Load(object sender, EventArgs e)
        {

            cbCargo.SelectedIndex = cbCargo.FindStringExact("Normal", 0);



        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }


        private void btCalculate_Click(object sender, EventArgs e)
        {
            int cargo_type = 0;
            string cargo = cbCargo.SelectedItem.ToString();
            if (cargo=="Dangerous")
            {
                cargo_type = 1;

            }

            float m3 = Util.isFloat(tbM3.Text.Trim());
            if (m3==0)
            {

                MessageBox.Show("M3 must be float");
                tbM3.Focus();
                return;

            }

            var result = DBUtil.GetTariff(cargo_type, int.Parse(nupDays.Value.ToString()), m3);
            float handling = result.Item1;
            float faf = result.Item2;
            float storage = result.Item3;
            float removal = result.Item4;
            
            float days = (float)nupDays.Value;
            if (nupDays.Value > 3)
            {
               
                if (m3 > 1)
                {
                    handling = handling * m3;
                    storage = storage * days * m3;
                    removal = removal * m3;
                    faf = faf * m3;

                }
                else
                {
                    storage = storage * days;

                }

            }
            else
            {

                if (m3 > 1)
                {
                    handling = handling * m3;
                    faf = faf * m3;

                }

            }
            float total = handling + faf + storage + removal;
            tbHandling.Text = handling.ToString();
            tbFAF.Text = faf.ToString();
            tbStorage.Text = storage.ToString();
            tbRemoval.Text = removal.ToString();
            tbTotal.Text = total.ToString();
        }
    }
}
