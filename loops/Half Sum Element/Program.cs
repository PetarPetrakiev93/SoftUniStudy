using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            var total = 0;
            for (var i = 1; i <= num; i++)
            {
                var digit = int.Parse(Console.ReadLine());
                total = total + digit;
                if (digit > sum)
                {
                    sum = digit;
                }
                
            }
            total = total - sum;
            if (total == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sum - total));
            }
        }
    }
}
