using System;

namespace _16.Comparing_Floats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double numSub = Math.Abs(num1 - num2);
            double eps = 0.000001;
            if (numSub < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
