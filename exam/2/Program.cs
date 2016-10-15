using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var totalgr = x * y;
            var production = (totalgr * 40) / 250;

            if (production > z) 
            {
                var wineleft = production - z;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", production);
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineleft), Math.Ceiling(wineleft / workers));
            }
            else
            {
                var neededwine = z - production;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Ceiling(neededwine));
            }
        }
    }
}
