using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var inValue = Console.ReadLine();
            var outValue = Console.ReadLine();
            var factor = 0.0;
            if (inValue == "m")
            {
                factor = 1; 
            }
            else if (inValue == "mm")
            {
                factor = 0.001;
            }
            else if (inValue == "cm")
            {
                factor = 0.01;
            }
            else if (inValue == "km")
            {
                factor = 1000;
            }
            else if (inValue == "mi")
            {
                factor = 1 / 0.000621371192;
            }
            else if (inValue == "in")
            {
                factor = 1 / 39.3700787;
            }
            else if (inValue == "ft")
            {
                factor = 1 / 3.2808399;
            }
            else if (inValue == "yd")
            {
                factor = 1 / 1.0936133;
            }
            var valuenew = value * factor;
            if (outValue == "m")
            {
                factor = 1;
            }
            else if (outValue == "mm")
            {
                factor = 1000;
            }
            else if (outValue == "cm")
            {
                factor = 100;
            }
            else if (outValue == "km")
            {
                factor = 0.001;
            }
            else if (outValue == "mi")
            {
                factor = 1 * 0.000621371192;
            }
            else if (outValue == "in")
            {
                factor = 1 * 39.3700787;
            }
            else if (outValue == "ft")
            {
                factor = 1 * 3.2808399;
            }
            else if (outValue == "yd")
            {
                factor = 1 * 1.0936133;
            }
            var valuefinal = valuenew * factor;
            Console.WriteLine(valuefinal + " " + outValue);
        }
    }
}
