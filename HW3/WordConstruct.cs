using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class WordConstruct
    {
        List<int> IIterations = null;
        List<string> IWords = null;
        public void ComputeIList(int p)
        {
            IIterations = new List<int>();
            for (int i = 2; i <= p; i++)
            {
                IIterations.Add(i);
            }
        }

        public void ConstructIWord(int p, int q)
        {
            foreach (var item in IIterations)
            {
                int lengthOfWord = p + q - item;
                int totalDistinctLetter = item;

            }
        }

        public void ConstructIWordWithPeriodicity()
        {
            //number of rows (total length -p) 
            //char[][] 
        }
    }
}
