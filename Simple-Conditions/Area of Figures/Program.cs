using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a * a, 3));
            }
            else if (type == "rectangle")
            {
                var height = double.Parse(Console.ReadLine());
                var width = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(height * width, 3));
            }
            else if (type == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * radius * radius, 3));
            }
            else if (type == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((side * h) / 2, 3));
            }
            else
            {
                Console.WriteLine("Not Valid");
            }  

        }
    }
}
