using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class MinimumWeakPeriod
    {
        public int GetMinWeakPeriod(string input)
        {
            int minperiod = 0;
            string str1 = input;
            string str2 = "*";
            string str = str1 + str2;

            char[] pword = str.ToCharArray();
            int lenPWord = pword.Length;
            List<int> period = new List<int>();
            int i, j, k, m, temp = 0;

            for (i = 1; i < lenPWord; i++)
            {
                temp = 0;
                for (j = 1; j <= i; j++)
                {
                    k = j;
                    m = k + i;
                    while (k < (lenPWord - i))
                    {
                        if ((pword[k] == pword[m]) || pword[k] == '^' || pword[m] == '^')
                        {
                        }
                        else
                        {
                            temp = 1;
                        }
                        k = k + i;
                        m = m + i;
                    }
                }
                if (temp == 0)
                {
                    period.Add(i);

                }
            }
            minperiod = period.Min();
            return minperiod;
        }
    }
}
