using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            for (; stars <= n; stars += 2)
            {
                Console.Write(new string('-', (n - stars) / 2));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', (n - stars) / 2));

            }
            for (var i = 1; i <= n / 2 ; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}
