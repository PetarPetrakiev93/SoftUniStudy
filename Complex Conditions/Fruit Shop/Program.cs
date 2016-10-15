using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (type == "banana")
                {
                    Console.WriteLine("{0:F2}", quantity * 2.50);
                }
                else if (type == "apple")
                {
                    Console.WriteLine("{0:F2}", quantity * 1.20);
                }
                else if (type == "orange")
                {
                    Console.WriteLine("{0:F2}", quantity * 0.85);
                }
                else if (type == "grapefruit")
                {
                    Console.WriteLine("{0:F2}", quantity * 1.45);
                }
                else if (type == "kiwi")
                {
                    Console.WriteLine("{0:F2}", quantity * 2.70);
                }
                else if (type == "pineapple")
                {
                    Console.WriteLine("{0:F2}", quantity * 5.50);
                }
                else if (type == "grapes")
                {
                    Console.WriteLine("{0:F2}", quantity * 3.85);
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (day == "saturday" || day == "sunday")
            {
                if (type == "banana")
                {
                    Console.WriteLine("{0:F2}", quantity * 2.70);
                }
                else if (type == "apple")
                {
                    Console.WriteLine("{0:F2}", quantity * 1.25);
                }
                else if (type == "orange")
                {
                    Console.WriteLine("{0:F2}", quantity * 0.90);
                }
                else if (type == "grapefruit")
                {
                    Console.WriteLine("{0:F2}", quantity * 1.60);
                }
                else if (type == "kiwi")
                {
                    Console.WriteLine("{0:F2}", quantity * 3.00);
                }
                else if (type == "pineapple")
                {
                    Console.WriteLine("{0:F2}", quantity * 5.60);
                }
                else if (type == "grapes")
                {
                    Console.WriteLine("{0:F2}", quantity * 4.20);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
