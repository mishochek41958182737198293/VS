using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using EatIsHouseLib;

namespace EatIsHouse
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            comboBoxMain1.Items.AddRange(System.IO.File.ReadAllLines("1st.txt"));
            comboBoxMain2.Items.AddRange(System.IO.File.ReadAllLines("2nd.txt"));
            comboBoxMain3.Items.AddRange(System.IO.File.ReadAllLines("3rd.txt"));
        }

        private void buttonMain1_Click(object sender, EventArgs e)
        {
            if (comboBoxMain1.Text != null && comboBoxMain1.Text != "")
            {
                listBoxChoice.Items.Add(comboBoxMain1.Text);
            }
            else
                EatIsHouseLib.Message.NonSelected();
        }

        private void buttonMain2_Click(object sender, EventArgs e)
        {
            if (comboBoxMain2.Text != null && comboBoxMain2.Text != "")
            {
                listBoxChoice.Items.Add(comboBoxMain2.Text);
            }
            else
                EatIsHouseLib.Message.NonSelected();
        }

        private void buttonMain3_Click(object sender, EventArgs e)
        {
            if (comboBoxMain3.Text != null && comboBoxMain3.Text != "")
            {
                listBoxChoice.Items.Add(comboBoxMain3.Text);
            }
            else
                EatIsHouseLib.Message.NonSelected();
        }

        private void buttonMainChoice_Click(object sender, EventArgs e)
        {
            listBoxChoice.Items.Remove(listBoxChoice.Text);
        }

        private void buttonMainCal_Click(object sender, EventArgs e)
        {
            FormBonusProgram F3 = new FormBonusProgram(this);
            F3.ShowDialog();
        }
        private void buttonMainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
