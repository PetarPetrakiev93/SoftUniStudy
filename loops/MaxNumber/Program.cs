﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            
            for (var i = 0; i < n; i++)
            {
                var min = int.Parse(Console.ReadLine());
                if (max < min)
                {
                   max = min;
                }
            }
            Console.WriteLine(max);
        }
    }
}
