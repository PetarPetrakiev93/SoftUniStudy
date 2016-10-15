using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (var c = 1; c <= n - 2; c++)
                Console.Write("- ");
            Console.WriteLine("+");
            for (var r = 1; r <= n - 2; r++)
            {
                Console.Write("| ");
                for (var c = 1; c <= n - 2; c++)
                    Console.Write("- ");
                Console.WriteLine("|");
            }
            Console.Write("+ ");
            for (var c = 1; c <= n - 2; c++)
                Console.Write("- ");
            Console.WriteLine("+");

        }
    }
}
