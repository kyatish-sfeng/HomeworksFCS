using HW1;
using HW2;
using HW3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCSMasterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CallHW3_2();
        }

        static void CallHW1()
        {
            Console.WriteLine("Enter the inpur partial word");
            string inputString = Console.ReadLine();

            int minPeriod = (new MinimumWeakPeriod()).GetMinWeakPeriod(inputString);
            Console.WriteLine("Minimum Weak Period :{0}", minPeriod);
            Console.ReadLine();
        }

        static void CallHW2()
        {
            Console.WriteLine("First Input");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Second Input");
            string secondInput = Console.ReadLine();

            //Proceed if length of both the strings is equal
            bool returnValue = (new Conjugates()).IsConjugate(firstInput, secondInput);

            if (returnValue)
            {
                Console.WriteLine("{0} and {1} are conjugates", firstInput, secondInput);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not conjugates", firstInput, secondInput);
            }

            Console.ReadLine();
        }

        static void CallHW3_2()
        {
            Console.WriteLine("Enter Partial Word");
            string pWord = Console.ReadLine();
            Console.WriteLine("Enter First Periodicity");
            string firstPeriodicity = Console.ReadLine();
            Console.WriteLine("Enter Second Periodicity");
            string secondPeriodicity = Console.ReadLine();

            var instance = new MinimumWeakPeriodDiagram();

            instance.ConstructPWordWithWkPeroid(pWord, Convert.ToInt16(firstPeriodicity));

            for (int i = 0; i < instance.PWordPresentation.Length; i++)
            {
                char[] innerArray = instance.PWordPresentation[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write(innerArray[a] + " ");
                }
                Console.WriteLine();
            }

            var instance2 = new MinimumWeakPeriodDiagram();

            instance2.ConstructPWordWithWkPeroid(pWord, Convert.ToInt16(secondPeriodicity));

            for (int i = 0; i < instance2.PWordPresentation.Length; i++)
            {
                char[] innerArray = instance2.PWordPresentation[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write(innerArray[a] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
