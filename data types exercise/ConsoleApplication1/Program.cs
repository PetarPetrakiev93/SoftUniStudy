using System;
using System.Collections.Generic;
using System.Text;

namespace PrintASCII
{
    class PrintASCII
    {

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                System.Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }

}
