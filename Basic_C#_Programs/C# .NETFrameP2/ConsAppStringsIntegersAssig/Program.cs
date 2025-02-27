using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of integers
        List<int> numbers = new List<int>() { 2, 33, 55, 70, 185, 223, 678, 932, 1011, 77000 };

        // Boolean flag to ensure valid input
        bool validInput = false;

        // Loop until the user enters a valid number (non-zero and not a string)
        while (!validInput)
        {
            try
            {
                // Prompt user for input
                Console.WriteLine("\nEnter a number to divide each number in the list by: ");
                float divisor = float.Parse(Console.ReadLine());

                // Check if the user entered zero
                if (divisor == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed. Please enter a non-zero number.");
                }
                else
                {
                    // Iterate through the list and divide each number by the user input
                    Console.WriteLine("\nResults:");
                    foreach (int number in numbers)
                    {
                        float result = number / divisor; // Perform division
                        Console.WriteLine($"{number} / {divisor} = {result}");
                    }

                    // Mark input as valid to exit the loop
                    validInput = true;
                }
            }
            // Catch block to handle invalid input (e.g., entering a string)
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
            }
        }

        // Message indicating the program has exited the try/catch block
        Console.WriteLine("\nThe program has successfully completed execution.");
    }
}
