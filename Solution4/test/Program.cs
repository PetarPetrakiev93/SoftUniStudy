using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isTrue = false;
            while (num > 0)
            {
                int check = num % 10;
                if(check % 2 == 0)
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
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        
            
        
    }
}
