using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitkon = int.Parse(Console.ReadLine());
            var ion = double.Parse(Console.ReadLine());
            var kom = double.Parse(Console.ReadLine());

            var leva = bitkon * 1168;
            var dollar = ion * 0.15;
            var dollartobgn = dollar * 1.76;
            var euro = (leva + dollartobgn) / 1.95;
            var commision = (euro * kom) / 100;
            var total = euro - commision;
            Console.WriteLine(total);

             

        }
    }
}
