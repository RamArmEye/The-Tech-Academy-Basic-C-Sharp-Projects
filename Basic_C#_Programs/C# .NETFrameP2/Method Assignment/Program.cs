using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate MathOperation class
            MathOperation mathOp = new MathOperation();

            // Ask the user to input the first number
            Console.WriteLine("Enter an integer: ");
             int number1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user for a second number (optional)
            Console.WriteLine("Enter a second integer (or press Enter to use default value): ");
            string input = Console.ReadLine();

            // Check if the user entered a second number
            if (int.TryParse(input, out int number2))
            {
                // Call the method with two parameters
                int result = mathOp.PerformOperation(number1, number2);
                Console.WriteLine(number1 + " + " + number2 + " = " + result);
            }
            else
            {
                // Call the method with only one parameter (default value is used)
                int result = mathOp.PerformOperation(number1);
                Console.WriteLine(number1 + " + Default (5) = " + result);
            }

            // Keep the console open
            Console.ReadLine();
        }
    }
}
