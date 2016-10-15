using System;

namespace _8.Employee_Data
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fisrtName = Console.ReadLine();
            var lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            long personalID = long.Parse(Console.ReadLine());
            int UEN = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}",
              fisrtName, lastName, age, gender, personalID, UEN);
        }
    }
}
