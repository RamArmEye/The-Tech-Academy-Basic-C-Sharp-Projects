using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number to be multiplied by 50: ");
            double userInput1 = Convert.ToDouble(Console.ReadLine()); // Convert input to double to handle large values
            double result1 = userInput1 * 50; // Multiply by 50
            Console.WriteLine("Result: " + result1); // Print the result

            // Prompt the user to enter a number
            Console.Write("Enter a number to add 25: ");
            double userInput2 = Convert.ToDouble(Console.ReadLine()); // Convert input to double
            double result2 = userInput2 + 25; // Add 25
            Console.WriteLine("Result: " + result2); // Print the result

            // Prompt the user to enter a number
            Console.Write("Enter a number to be divided by 12.5: ");
            double userInput3 = Convert.ToDouble(Console.ReadLine()); // Convert input to double
            double result3 = userInput3 / 12.5; // Divide by 12.5
            Console.WriteLine("Result: " + result3); // Print the result

            // Prompt the user to enter a number
            Console.Write("Enter a number to check if it's greater than 50: ");
            double userInput4 = Convert.ToDouble(Console.ReadLine()); // Convert input to double
            bool isGreaterThan50 = userInput4 > 50; // Check if greater than 50
            Console.WriteLine("Is the number greater than 50? " + isGreaterThan50); // Print true/false result

            // Prompt the user to enter a number
            Console.Write("Enter a number to be divided by 7 (to find the remainder): ");
            double userInput5 = Convert.ToDouble(Console.ReadLine()); // Convert input to double
            double remainder = userInput5 % 7; // Find remainder using modulus operator
            Console.WriteLine("Remainder when divided by 7: " + remainder); // Print the remainder

            // Prevent console from closing immediately
            Console.ReadLine();
        }
    }
}
