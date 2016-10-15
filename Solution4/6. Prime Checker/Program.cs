using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(n);
            Console.WriteLine(isPrime);
        }

        static bool IsPrime(long n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            else
            {
                for (long divider = 2; divider <= Math.Sqrt(n); divider++)
                {
                    if (n % divider == 0)
                    {
                        return false;
                        
                    }
                }
                return true;
            }
            
            
        }
    }
}
