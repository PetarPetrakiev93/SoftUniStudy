using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            var sum = sec1 + sec2 + sec3;
            var minutes = sum / 60;
            var seconds = sum % 60;
            var sec = "";
            if (seconds <= 9)
            {
                sec += "0";
            }
            Console.WriteLine(minutes + ":" + sec + seconds);
        }
    }
}
