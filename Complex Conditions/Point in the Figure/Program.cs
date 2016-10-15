using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var xa = 0;
            var ya = 0;
            var xb = 0;
            var yb = h;
            var xc = 3 * h;
            var yc = 0;
            var xd = 3 * h;
            var yd = h;
            var xa1 = h;
            var ya1 = h;
            var xb1 = 2 * h;
            var yb1 = h;
            var xc1 = h;
            var yc1 = 4 * h;
            var xd1 = 2 * h;
            var yd1 = 4 * h;
            if (((y == ya) && (x >= xa) && (x <= xc)) || ((x == xa) && (y >= ya) && (x <= yb)) || ((y == yb) && (x >= xb) && (x <= xa1)) || ((x == xa1) && (y >= ya1) && (y <= yc1)) || ((y == yc1) && (x >= xc1) && (x <= xd1)) || ((x == xd1) && (y >= yb1) && (y <= yd1)) || ((y == yb1) && (x >= xb1) && (x <= xd)) || ((x == xd) && (y >= yc) && (y <= yd)))
                {
                Console.WriteLine("border");
            }
            else if (x > xa && x < xc && x > xb && x < xd && y > ya && y < yc1)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
