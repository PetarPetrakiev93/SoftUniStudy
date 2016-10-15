using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 0;
            var sum = 0;
            for (var i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine(sum);
        }
    }
}