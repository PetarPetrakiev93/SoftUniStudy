using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;

            for (var i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    sum1 = sum1 + num;
                }
                else
                {
                    sum2 = sum2 + num;
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum1);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sum1 - sum2));
            }



        }
    }
}
