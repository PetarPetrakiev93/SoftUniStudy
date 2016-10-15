using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var letter = 97; letter < 97 + 26; letter++)
            {
                Console.WriteLine((char)letter);
            }
        }
    }
}
