using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = int.Parse(Console.ReadLine());
            var catgory = Console.ReadLine();
            var numberp = double.Parse(Console.ReadLine());
            var newbudget = 0;
            var vip = 499.99;
            var normal = 249.99;

                     
            if (catgory == "Normal")
            {

                if (numberp >= 1 && numberp <= 4)
                {
                    newbudget = budget - ((75 * budget) / 100);
                }
                else if (numberp >= 5 && numberp <= 9)
                {
                    newbudget = budget - ((60 * budget) / 100);
                }
                else if (numberp >= 10 && numberp <= 24)
                {
                    newbudget = budget - ((50 * budget) / 100);
                }
                else if (numberp >= 25 && numberp <= 49)
                {
                    newbudget = budget - ((40 * budget) / 100);
                }
                else if (numberp >= 50)
                {
                    newbudget = budget - ((25 * budget) / 100);
                }
                var normal1 = (normal * numberp);

                if (newbudget > normal1)
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", newbudget - normal1);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", normal1 - newbudget);
                }
            }
            else if (catgory == "VIP")
            {
                if (numberp >= 1 && numberp <= 4)
                {
                    newbudget = budget - ((75 * budget) / 100);
                }
                else if (numberp >= 5 && numberp <= 9)
                {
                    newbudget = budget - ((60 * budget) / 100);
                }
                else if (numberp >= 10 && numberp <= 24)
                {
                    newbudget = budget - ((50 * budget) / 100);
                }
                else if (numberp >= 25 && numberp <= 49)
                {
                    newbudget = budget - ((40 * budget) / 100);
                }
                else if (numberp >= 50)
                {
                    newbudget = budget - ((25 * budget) / 100);
                }
                var vip1 = vip * numberp;
                if (newbudget > vip1)
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", newbudget - vip1);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", vip1 - newbudget);
                }
            }
        }
    }
}
