using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user for their age.
                Console.Write("Please enter your age: ");
                // Read the user's input from the console.
                string input = Console.ReadLine();

                // Parse the input to an integer. This will throw a FormatException if the input is not a valid number.
                int age = int.Parse(input);

                // Check if the entered age is zero or negative.
                if (age <= 0)
                {
                    // Throw an ArgumentException with a specific message if age is zero or negative.
                    throw new ArgumentException("Please enter a number greater than zero.");
                }

                // Calculate the birth year by subtracting the age from the current year.
                int birthYear = DateTime.Now.Year - age;

                // Display the year the user was born.
                Console.WriteLine("You were born in: " + birthYear);
            }
            catch (ArgumentException ex)
            {
                // Handle the case where the user entered zero or a negative number.
                Console.WriteLine("Input Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions that might occur (e.g., FormatException).
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Wait for the user to press Enter before closing the console window.
            Console.ReadLine();
        }
    }
}
