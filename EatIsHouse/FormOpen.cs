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
    public partial class FormOpen : Form
    {
        public FormOpen()
        {
            InitializeComponent();
        }

        private void buttonOpenExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOpenCal_Click(object sender, EventArgs e)
        {
            FormMain F2 = new FormMain();
            F2.Show();
            this.Hide();
        }
    }
}
