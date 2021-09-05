using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EatIsHouse
{
    public partial class FormBonusProgram : Form
    {
        FormMain F2;
        public FormBonusProgram(FormMain F2_)
        {
            F2 = F2_;
            InitializeComponent();
        }

        private void buttonBonusCal_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int j = 0; j < F2.listBoxChoice.Items.Count; j++)
            {
                string findLine = Convert.ToString(F2.listBoxChoice.Items[j]);
                sum += EatIsHouseLib.FindPrice.FindPriceInLine(findLine);
            }

            if (radioButtonBonus2.Checked)
            {
                sum = sum * 0.94;
            }
            else if (radioButtonBonus3.Checked)
            {
                sum = sum * 0.85;
            }
            
            if (sum == 0)
            {
                EatIsHouseLib.Message.NonSelected();
            }
            else
                EatIsHouseLib.Message.ShowSum(Convert.ToString(sum));
        }
        private void buttonBonusCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonBonusExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
