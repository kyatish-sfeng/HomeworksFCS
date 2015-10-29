using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class Ordering
    {
        private List<string> _leftOrderedList;
        private List<string> _rightOrderedList;

        public void Order(string input)
        {
            var tempLeftOrderedList=new string[input.Count()];
            var tempRightOrderedList=new string[input.Count()];
            var reversedWord = ReversedString(input);
            for (int i = 1; i <= reversedWord.Count(); i++)
            {
                tempLeftOrderedList[i-1] = (reversedWord.Substring(0, i));
                tempRightOrderedList[i-1] = (reversedWord.Substring(0, i));
            }

            //Array.Sort(tempLeftOrderedList, StringComparer.);

            foreach (var val in tempLeftOrderedList)
            {
                _leftOrderedList.Add(val);
            }
        }

        public List<string> LeftOrdering()
        {
            return _leftOrderedList;
        }

        public List<string> RightOrdering()
        {
            return _rightOrderedList;
        }

        public string ReversedString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
 
    }
}
