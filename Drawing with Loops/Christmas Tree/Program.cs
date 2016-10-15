using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write(new string(' ', n));
            Console.WriteLine(" |");
            for (var r = 1; r <= n; r++)
            {
                Console.Write(new string(' ', n - r));
                Console.Write(new string('*', r));
                Console.Write(" | ");
                Console.Write(new string('*', r));
                Console.WriteLine();
            }
        }
    }
}

