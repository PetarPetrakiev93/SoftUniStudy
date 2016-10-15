using System;

namespace _5.Boolean_Variable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string variableBool = Console.ReadLine();
            bool IsTrue = Convert.ToBoolean(variableBool);
            if (IsTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
