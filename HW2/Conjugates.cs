using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class Conjugates
    {
        public bool IsConjugate(string firstInput, string secondInput)
        {
            bool returnValue = false;
            int lenghtOfString = firstInput.Length;

            char[] firstArray = firstInput.ToCharArray();
            char[] secondArray = secondInput.ToCharArray();

            //pseudo code
            /*
             * from 1 to lenght of string
             * substring of i-1 = a and remaining =b
             * concatinate b and a
             * verify that ba contains second input           
             */
            for (int i = 1; i <= lenghtOfString; i++)
            {
                string u = firstInput.Substring(0, i);  //sub string of first
                string v = firstInput.Substring(i, lenghtOfString); //substring of second

                string vu = v + u;//String concatenation

                if (vu.Contains(secondInput))
                {
                    returnValue = true;
                }
                else
                {
                    for (int j = 0; j < lenghtOfString; j++)
                    {
                        
                    }
                }
            }

            return returnValue;
        }
    }
}
