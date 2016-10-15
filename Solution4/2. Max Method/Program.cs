using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int bigNum = GetMax(num1, num2);
            int max = GetMax(num3, bigNum);
            Console.WriteLine(max);
        }
        static int GetMax(int a, int b)
        {
            if(a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
