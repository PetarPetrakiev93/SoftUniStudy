﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.Write(ReverseNumber(number));
            Console.WriteLine();
        }
        static string ReverseNumber(string number)
        {
            string result = "";
            for(int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i];
            }
            return result;
        }
    }
}
