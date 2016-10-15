using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var score = int.Parse(Console.ReadLine());
            var BonusScore = 0.0;
            if (score <= 100) 
            {
                BonusScore = BonusScore + 5;
            }
            else if (score <= 1000)
            {
                BonusScore = score * 0.2;
            }
            else
            {
                BonusScore = score * 0.1;
            }
            if (score % 2 == 0)
            {
                BonusScore += 1;
            }
            if (score % 10 == 5)
            {
                BonusScore += 2;
            }
            Console.WriteLine("Bonus score: {0}", BonusScore);
            Console.WriteLine("Total score: {0}", score + BonusScore);

        }
    }
}
