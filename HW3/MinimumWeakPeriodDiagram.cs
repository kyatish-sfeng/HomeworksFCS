using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class MinimumWeakPeriodDiagram
    {
        public char[][] PWordPresentation { get; set; }

        public void ConstructPWordWithWkPeroid(string pword, int periodicity)
        {
            int lenghtOfWord = pword.Length;
            char[] pwordChar=pword.ToCharArray();
            int rows = 0;
            if (lenghtOfWord % periodicity == 0)
            {
                rows = lenghtOfWord / periodicity;

            }
            else
            {
                rows = (lenghtOfWord / periodicity)+1;
            }
            PWordPresentation = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                if (i == rows - 1)
                {
                    int wordRemainder = lenghtOfWord % periodicity;
                    PWordPresentation[i] = new char[wordRemainder];
                    for (int a = 0; a < wordRemainder; a++)
                    {
                        PWordPresentation[i][a] = pwordChar[(i * periodicity) + a];
                    }
                }
                else
                {
                    PWordPresentation[i] = new char[periodicity];
                    for (int j = 0; j < periodicity; j++)
                    {
                        PWordPresentation[i][j] = pwordChar[(i * periodicity) + j];
                    }
                }
            }

        }
    }
}
