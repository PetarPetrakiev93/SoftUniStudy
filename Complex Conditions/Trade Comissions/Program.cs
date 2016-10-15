using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            
            if (town == "Sofia")
            {
                if (quantity >= 0 && quantity <= 500)
                {
                    Console.WriteLine("{0:F2}", (quantity * 0.05));
                }
                else if (quantity > 500 && quantity <= 1000)
                {
                    Console.WriteLine("{0:F2}", (quantity * 0.07));
                }
                else if (quantity > 1000 && quantity <= 10000)
                {
                    Console.WriteLine("{0:F2}", (quantity * 0.08));
                }
                else if (quantity > 10000)
                {
                    Console.WriteLine("{0:F2}", (quantity * 0.12));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (quantity >= 0 && quantity <= 500)
                {
                    Console.WriteLine("{0:F2}", (quantity * 0.045));
                }
                else if (quantity > 500 && quantity <= 1000)
                {
                    Console.WriteLine("{0:F2}", (quantity * 0.075));
                }
                else if (quantity > 1000 && quantity <= 10000)
                {
                    Console.WriteLine("{0:F2}", (quantity * 0.1));
                }
                else if (quantity > 10000)
                {
                    Console.WriteLine("{0:F2}", (quantity * 0.13));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (quantity >= 0 && quantity <= 500)
                {
                    Console.WriteLine("{0:F2}", (quantity * 0.055));
                }
                else if (quantity > 500 && quantity <= 1000)
                {
                    Console.WriteLine("{0:F2}", (quantity * 0.08));
                }
                else if (quantity > 1000 && quantity <= 10000)
                {
                    Console.WriteLine("{0:F2}", (quantity * 0.12));
                }
                else if (quantity > 10000)
                {
                    Console.WriteLine("{0:F2}", (quantity * 0.145));
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
