﻿using HW1;
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
            CallHW1();
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
        }


    }
}
