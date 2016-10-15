using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var sum = 12000;
            var age = 17;
            for (var i = 1800; i <= year; i++)
            {
                age += 1;
                if (age % 2 == 0)
                {
                    money = money - sum;
                }
                else
                {
                    money = money - (sum + (50 * age));
                }
            }
            if (money > 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", money);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(money));
            }
        }
    }
}
