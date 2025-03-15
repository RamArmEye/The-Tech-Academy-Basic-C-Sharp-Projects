using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Provides functionalities for file operations.

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the file path where the number will be logged using a verbatim string literal.
            string filePath = @"C:\   ENTER YOUR PATH    \numberLog.txt";

            // Ask the user for a number.
            Console.Write("Please enter a number: ");
            // Read the user's input from the console.
            string userInput = Console.ReadLine();

            // Log the number to a text file.
            // Write the user's input to the file at the specified filePath.
            File.WriteAllText(filePath, userInput);

            // Inform the user that the number has been saved.
            Console.WriteLine("Your number has been saved to the file.");

            // Read the text file back to the user.
            // Read all text from the file and store it in a variable.
            string fileContents = File.ReadAllText(filePath);

            // Print the contents of the file to the console.
            Console.WriteLine("The contents of the file are: " + fileContents);

            // Wait for the user to press Enter before closing the console window.
            Console.ReadLine();
        }
    }
}
