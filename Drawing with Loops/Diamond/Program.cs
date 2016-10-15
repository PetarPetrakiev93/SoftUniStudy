using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var points = n;
            var points1 = (n * 3) - 2;
            var points2 = 0;
            var points3 = (5 * n) - 2;
            Console.Write(new string('.', n));
            Console.Write(new string('*', 3 * n));
            Console.WriteLine(new string('.', n));
            for (var i = 1; i < n; i++)
            {
                points -= 1;
                points1 += 2;
                Console.Write(new string('.', points));
                Console.Write("*");
                Console.Write(new string('.', points1));
                Console.Write("*");
                Console.WriteLine(new string('.', points));
            }
            Console.WriteLine(new string('*', n * 5));
            for (var i = 1; i <= n * 2; i++)
            {
                points2 += 1;
                points3 -= 2;
                Console.Write(new string('.', points2));
                Console.Write("*");
                Console.Write(new string('.', points3));
                Console.Write("*");
                Console.WriteLine(new string('.', points2));
            }
            var bottom = ((5 * n) - points3) / 2;
            Console.Write(new string('.', bottom));
            Console.Write(new string('*', points3));
            Console.WriteLine(new string('.', bottom));


        }
    }
}
