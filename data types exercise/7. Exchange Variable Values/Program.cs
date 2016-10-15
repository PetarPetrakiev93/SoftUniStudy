using System;

namespace _7.Exchange_Variable_Values
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int newA = b;
            int newB = a;
            Console.WriteLine("Before:\na = {0}\nb = {1}\nAfter:\na = {2}\nb = {3}", a, b, newA, newB);
        }
    }
}
