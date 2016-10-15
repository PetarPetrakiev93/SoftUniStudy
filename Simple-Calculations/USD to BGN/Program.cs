using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD = ");
            var usd = decimal.Parse(Console.ReadLine());
            var bgn = usd * 1.79549m;
            Console.WriteLine(Math.Round(bgn, 2) + " BGN");
        }
    }
}
