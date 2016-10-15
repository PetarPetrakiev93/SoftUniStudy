using System;


namespace _4.Variable_in_Hexadecimal_Format
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string varInHex = Console.ReadLine();
            int number = Convert.ToInt32(varInHex, 16);
            Console.WriteLine(number);
        }
    }
}
