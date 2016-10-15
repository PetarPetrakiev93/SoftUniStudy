using System;


namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                PrintTriangleArea(side, height);
            }
            else if(type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                PrintSquareArea(side);
            }
            else if(type == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                PrintRectangleArea(width, height);
            }
            else if(type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                PrintCircleArea(radius);
            }
                
        }
        static void PrintTriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            Console.WriteLine("{0:f2}", area);
        }
        static void PrintSquareArea(double side)
        {
            double area = side * side;
            Console.WriteLine("{0:f2}", area);
        }
        static void PrintRectangleArea(double width, double height)
        {
            double area = width * height;
            Console.WriteLine("{0:f2}", area);
        }
        static void PrintCircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("{0:f2}", area);
        }
    }
}
