using System;


namespace _12.Rectangle_Properties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = (width * 2f) + (height * 2f);
            double area = width * height;
            double diagonal = Math.Sqrt((width * width) + (height * height));
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);

        }
    }
}
