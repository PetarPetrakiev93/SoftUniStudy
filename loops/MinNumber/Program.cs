using System;
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
            var min = int.MaxValue;

            for (var i = 0; i < n; i++)
            {
                var max = int.Parse(Console.ReadLine());
                if (max < min)
                {
                    min = max;
                }
            }
            Console.WriteLine(min);
        }
    }
}