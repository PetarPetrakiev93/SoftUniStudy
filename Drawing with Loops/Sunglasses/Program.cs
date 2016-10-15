using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var framestars = (new string('*', 2 * n));
            var middle = (new string(' ', n));
            var middleframe = (new string('|', n));
            var glass = (new string('/', (2 * n) - 2));

            Console.WriteLine("{0}{1}{0}", framestars, middle);
            for (var i = 1; i <= n -2; i++)
            {
                Console.Write("{0}{1}{0}", "*", glass);
                if (i == (n - 1) / 2)
                {
                    Console.Write(middleframe);
                }
                else
                {
                    Console.Write(middle);
                }
                Console.WriteLine("{0}{1}{0}", "*", glass);
            }
            Console.WriteLine("{0}{1}{0}", framestars, middle);
        }
    }
}
