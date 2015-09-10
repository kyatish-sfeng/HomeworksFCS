using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class Conjugates
    {
        public bool IsConjugate(string firstInput, string secondInput)
        {
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

            return false;
        }
    }
}
