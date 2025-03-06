using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week.
            Console.Write("Please enter the current day of the week: ");
            string userInput = Console.ReadLine();

            try
            {
                // Attempt to parse the user input into the DaysOfWeek enum.
                // The 'true' parameter makes the parsing case-insensitive.
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // Display the parsed day.
                Console.WriteLine("You entered: " + currentDay);
            }
            catch (Exception)
            {
                // If an error occurs during parsing, inform the user with an error message.
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Wait for the user to press Enter before closing the console window.
            Console.ReadLine();
        }
    }
}