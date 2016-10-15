using System;
using System.Globalization;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = int.Parse(Console.ReadLine());
            string upper1 = Convert.ToString(num, 16).ToUpper();
            Console.WriteLine(upper1);
            Console.WriteLine(Convert.ToString(num, 2));
        }
    }
}
