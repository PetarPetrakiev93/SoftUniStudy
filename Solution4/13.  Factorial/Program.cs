using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;
            int lastDigit = 0;
            int num = int.Parse(Console.ReadLine());
            {
                
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
            }
            while(factorial % 10 == 0)
            {
                lastDigit++;
                factorial = factorial / 10;
            }
            Console.WriteLine(lastDigit);
        }
        
    }
}
