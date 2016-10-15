using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var weekends = 48;

            if (year == "leap")
            {
                var gamesSofia = (weekends - h) * 3.0 / 4.0;
                var gamesHome = h;
                var gamesHolidays = p * 2.0 / 3.0;
                var gamesTotal = (gamesSofia + gamesHome + gamesHolidays) * 115.0 / 100.0;
                Console.WriteLine(Math.Floor(gamesTotal));
                               
            }
            else if (year == "normal")
            {
                var gamesSofia = (weekends - h) * 3.0 / 4.0;
                var gamesHome = h;
                var gamesHolidays = p * 2.0 / 3.0;
                var gamesTotal = gamesSofia + gamesHome + gamesHolidays;
                Console.WriteLine(Math.Floor(gamesTotal));
            }
        }
    }
}
