using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (IsPalindrome(i) == true && SumOfDigits(i) == true && ContainsEvenDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool IsPalindrome(int currentNumber)
        {
            int num = currentNumber;
            int reverse = 0;
            while (currentNumber > 0)
            {
                int dig = currentNumber % 10;
                reverse = reverse * 10 + dig;
                currentNumber = currentNumber / 10; 
            }
            if (num == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool SumOfDigits(int num)
        {
            int addNum = 0;
            while (num > 0)
            {
                addNum += num % 10;
                num = num / 10;
            }
            if(addNum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ContainsEvenDigit(int num)
        {
            bool isTrue = false;
            while (num > 0)
            {
                int check = num % 10;
                if (check % 2 == 0)
                {
                    isTrue = true;
                    break;
                }
                else
                {
                    num = num / 10;
                }
            }
            if (isTrue == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
