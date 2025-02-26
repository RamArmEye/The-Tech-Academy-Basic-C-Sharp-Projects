using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            // Use if, else if, and else statements to compare the numbers
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The first number is greater than the second number.");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("The first number is less than the second number.");
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }

            // Display a message and wait for the user to press a key before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
