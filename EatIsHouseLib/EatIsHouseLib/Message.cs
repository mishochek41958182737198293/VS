using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace EatIsHouseLib
{
    public static class Message
    {
        public static DialogResult NonSelected()
        {
            return MessageBox.Show("Вы не выбрали ни одну позицию!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowSum(string sum)
        {
            return MessageBox.Show(sum+"₽", "Сумма покупки", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
