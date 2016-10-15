using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            var price = 0.0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    price = 0.50;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "water")
                {
                    price = 0.80;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "beer")
                {
                    price = 1.20;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "sweets")
                {
                    price = 1.45;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "peanuts")
                {
                    price = 1.60;
                    Console.WriteLine(price * quantity);
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.40;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "water")
                {
                    price = 0.70;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "beer")
                {
                    price = 1.15;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "sweets")
                {
                    price = 1.30;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "peanuts")
                {
                    price = 1.50;
                    Console.WriteLine(price * quantity);
                }
            }
            if (town == "Varna")
            {
                if (product == "coffee")
                {
                    price = 0.45;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "water")
                {
                    price = 0.70;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "beer")
                {
                    price = 1.10;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                    Console.WriteLine(price * quantity);
                }
                else if (product == "peanuts")
                {
                    price = 1.55;
                    Console.WriteLine(price * quantity);
                }
            }

        }
    }
}
