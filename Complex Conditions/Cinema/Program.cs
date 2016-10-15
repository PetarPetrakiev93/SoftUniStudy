using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var places = r * c;

            if (type == "Premiere")
            {
                Console.WriteLine("{0:F2}" + " " + "leva", places * 12.00);
            }
            else if (type == "Normal")
            {
                Console.WriteLine("{0:F2}" + " " + "leva", places * 7.50);
            }
            else if (type == "Discount")
            {
                Console.WriteLine("{0:F2}" + " " +"leva", places * 5.00);
            }


        }
    }
}
