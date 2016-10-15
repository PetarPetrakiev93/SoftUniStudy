using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
                    {
            TimeSpan span1 = TimeSpan.FromHours(int.Parse(Console.ReadLine()));
            TimeSpan span2 = TimeSpan.FromMinutes(int.Parse(Console.ReadLine()));
            TimeSpan span3 = TimeSpan.FromMinutes(15);
            TimeSpan span4 = span1.Add(span2).Add(span3);

            Console.WriteLine("{0:h\\:mm}", span4);
        }
    }
}
