using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddsum = 0.0;
            var oddmin = 10000000.0;
            var oddmax = -1000000.0;
            var evensum = 0.0;
            var evenmin = 10000000.0;
            var evenmax = -10000000.0;
            for (var i = 1; i <= n; i++)
            {
                var digit = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evensum += digit;
                    if (evenmin > digit)
                    {
                        evenmin = digit;
                    }
                    if (evenmax < digit)
                    {
                        evenmax = digit;
                    }
                    
                }
                else
                {
                    oddsum += digit;
                    if (oddmin > digit)
                    {
                        oddmin = digit;
                    }
                    if (oddmax < digit)
                    {
                        oddmax = digit;
                    }

                }
                


            }
            Console.WriteLine("OddSum=" + oddsum);
            Console.WriteLine("OddMin=" + oddmin);
            Console.WriteLine("OddMax=" + oddmax);
            Console.WriteLine("EvenSum=" + evensum);
            Console.WriteLine("EvenMin=" + evenmin);
            Console.WriteLine("EvenMax=" + evenmax);
        }
    }
}
