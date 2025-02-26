using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Output_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example using the greater than operator (>)
            int num1 = 10;
            int num2 = 5;
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}.");
            }
            else
            {
                Console.WriteLine($"{num1} is not greater than {num2}.");
            }

            // Example using the lesser than or equal to operator (<=)
            int num3 = 3;
            int num4 = 3;
            if (num3 <= num4)
            {
                Console.WriteLine($"{num3} is less than or equal to {num4}.");
            }
            else
            {
                Console.WriteLine($"{num3} is not less than or equal to {num4}.");
            }

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
