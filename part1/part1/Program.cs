using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // I. Using TryParse to convert a string to an integer
                string intString = "42";
                if (int.TryParse(intString, out int intValue))
                {
                    Console.WriteLine($"Using TryParse: The converted integer is {intValue}");
                }
                else
                {
                    Console.WriteLine("Using TryParse: Error converting to integer.");
                }

                // II. Using Convert to convert a string to a double
                string doubleString = "3.14";
                try
                {
                    double doubleValue = Convert.ToDouble(doubleString);
                    Console.WriteLine($"Using Convert: The converted double is {doubleValue}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Using Convert: Error converting to double.");
                }

                // III. Using Parse to convert a string to a decimal
                string decimalString = "123.456";
                try
                {
                    decimal decimalValue = decimal.Parse(decimalString);
                    Console.WriteLine($"Using Parse: The converted decimal is {decimalValue}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Using Parse: Error converting to decimal.");
                }
            
        }

    }
}

