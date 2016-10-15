using System;


namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            if(type == "face")
            {
                PrintFaceDiagonal(s);
            }
            else if(type == "space")
            {
                PrintSpaceDiagonal(s);
            }
            else if(type == "volume")
            {
                PrintVolume(s);
            }
            else if(type == "area")
            {
                PrintArea(s);
            }
        }
        static void PrintFaceDiagonal(double x)
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(x, 2));
            Console.WriteLine("{0}", Math.Round(faceDiagonal, 2));
        }
        static void PrintSpaceDiagonal(double x)
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(x, 2));
            Console.WriteLine("{0}", Math.Round(spaceDiagonal, 2));
        }
        static void PrintVolume(double x)
        {
            double volume = Math.Pow(x, 3);
            Console.WriteLine("{0}", Math.Round(volume, 2));
        }
        static void PrintArea(double x)
        {
            double area = 6 * Math.Pow(x, 2);
            Console.WriteLine("{0}", Math.Round(area, 2));
        }
    }
}
