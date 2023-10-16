using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace if_number_contains_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 7201432;
            int number2 = 87501;

            bool contains3_1 = IfNumberContains3(number1);
            bool contains3_2 = IfNumberContains3(number2);

            Console.WriteLine(number1 + " contains the digit 3: " + contains3_1);
            Console.WriteLine(number2 + " contains the digit 3: " + contains3_2);
            Console.ReadLine();
        }

        static bool IfNumberContains3(int number)
        {
            // Check each digit of the number.
            while (number > 0)
            {
                int digit = number % 10;
                if (digit == 3)
                {
                    return true; // Found the digit 3.
                }
                else 
                number /= 10;
            }

            // If we've checked all digits and didn't find 3, return false.
            return false;
        }
    }
}
