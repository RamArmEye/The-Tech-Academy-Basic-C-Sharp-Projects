using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the NumberProcessor class
            NumberProcessor processor = new NumberProcessor();

            // Prompt user for input
            Console.Write("Please enter a number: ");

            // Read input and convert to integer with basic error handling
            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                // Call the DivideByTwo method with user input
                Console.WriteLine($"Original number: {userNumber}");
                processor.DivideByTwo(userNumber);

                // Demonstrate output parameter usage
                processor.GetNumberInfo(userNumber, out bool isEven);
                Console.WriteLine($"Is the number even? {isEven}");

                // Demonstrate method overloading
                Console.WriteLine(processor.ProcessNumber(userNumber));      // Uses int version
                Console.WriteLine(processor.ProcessNumber(userNumber + 0.5)); // Uses double version

                // Demonstrate static class usage
                MathHelper.GetDivisionDetails(userNumber, out int half, out int remainder);
                Console.WriteLine($"Half: {half}, Remainder: {remainder}");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Keep console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}