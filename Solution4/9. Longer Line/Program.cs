using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLine = GetDistanceBetweenTwoPoints(x1, y1, x2, y2);
            double secondLine = GetDistanceBetweenTwoPoints(x3, y3, x4, y4);
            if (firstLine >= secondLine)
            {
                PrintLine(x1, y1, x2, y2);
            }
            else
            {
                PrintLine(x3, y3, x4, y4);
            }
                   
                              
        }

        static void PrintLine(double x1, double y1, double x2, double y2)
        {
            double distancePoint1 = GetDistanceBetweenTwoPoints(x1, y1, 0, 0);
            double distancePoint2 = GetDistanceBetweenTwoPoints(x2, y2, 0, 0);
            if (distancePoint1 < distancePoint2)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }


        }
        static double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }
    }
}