using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var fistName = Console.ReadLine();
            var lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {fistName} {lastName}. You are {age} years old.");
        }
    }
}
