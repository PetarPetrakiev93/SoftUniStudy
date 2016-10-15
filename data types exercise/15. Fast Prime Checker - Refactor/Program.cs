using System;


namespace _15.Fast_Prime_Checker___Refactor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int n = 2; n <= num; n++)
            {
                bool boolenValue = true;
                for (int prime = 2; prime <= Math.Sqrt(n); prime++)
                {
                    if (n % prime == 0)
                    {
                        boolenValue = false;
                        break;
                    }
                }
                Console.WriteLine($"{n} -> {boolenValue}");
            }

        }
    }
}
