using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            var inValue = Console.ReadLine();
            var outValue = Console.ReadLine();
            var bgn = 1.0;
            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;
            if (inValue == "BGN")
            {
                amount = amount * bgn;
            }
            else if (inValue == "EUR")
            {
                amount = amount * eur;
            }
            else if (inValue == "USD")
            {
                amount = amount * usd;
            }
            else if (inValue == "GBP")
            {
                amount = amount * gbp;
            }
            var newamount = amount;

            if (outValue == "BGN")
            {
                Console.WriteLine("{0}" + " " + "{1}", Math.Round(newamount * bgn, 2), outValue);
            }
            else if (outValue == "EUR")
            {
                Console.WriteLine("{0}" + " " + "{1}", Math.Round(newamount / eur, 2), outValue);
            }
            else if (outValue == "USD")
            {
                Console.WriteLine("{0}" + " " + "{1}", Math.Round(newamount / usd, 2), outValue);
            }
            else if (outValue == "GBP")
            {
                Console.WriteLine("{0}" + " " + "{1}", Math.Round(newamount / gbp, 2), outValue);
            }
            
        }
    }
}
