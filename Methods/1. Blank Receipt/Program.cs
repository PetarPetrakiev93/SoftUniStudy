using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }
        public static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        public static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");

        }
        public static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");

        }
        public static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

    }
}
