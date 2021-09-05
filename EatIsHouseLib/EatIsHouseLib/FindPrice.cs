using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatIsHouseLib
{
    public static class FindPrice
    {
        public static double FindPriceInLine(string findLine)
        {
            string dishSum = "";
            for (int i = 0; i < findLine.Length; i++)
            {
                if (char.IsNumber(findLine[i]) && char.IsSymbol(findLine[i + 1]))
                {
                    int number = 0;
                    for (int k = i; char.IsNumber(findLine[k]); k--)
                    {
                        number = k;
                    }
                    for (int p = number; p <= i; p++)
                        dishSum = dishSum + findLine[p];
                }
            }
            return Convert.ToDouble(dishSum);
        }
    }
}
