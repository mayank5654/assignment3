using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // Task 1: Convert a string to an integer using TryParse
                string intString = "42";
                int result1;
                if (int.TryParse(intString, out result1))
                {
                    int multipliedValue = result1 * 5;
                    Console.WriteLine($"Task 1: The result is {multipliedValue}");
                }
                else
                {
                    Console.WriteLine("Task 1: Error converting to integer.");
                }

                // Task 2: Convert a string to a DateTime object using Convert
                string dateString = "2023-10-31";
                try
                {
                    DateTime result2 = Convert.ToDateTime(dateString);
                    result2 = result2.AddMonths(-1);
                    Console.WriteLine($"Task 2: The result is {result2}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Task 2: Error converting to DateTime.");
                }

                // Task 3: Convert a string to a TimeSpan object using Parse
                string timeSpanString = "02:30:00";
                try
                {
                    TimeSpan result3 = TimeSpan.Parse(timeSpanString);
                    result3 = result3.Add(new TimeSpan(2, 0, 0));
                    Console.WriteLine($"Task 3: The result is {result3}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Task 3: Error converting to TimeSpan.");
                }
            
        }

    }
}

