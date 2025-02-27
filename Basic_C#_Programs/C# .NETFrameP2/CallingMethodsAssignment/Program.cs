using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking the user for a number input
            Console.WriteLine("Enter a number to perform math operations on:");

            // Reading user input and converting it to an integer
            int userNumber;
            while (!int.TryParse(Console.ReadLine(), out userNumber)) // Ensures valid integer input
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }

            // Calling the Add method and displaying the result
            int addResult = MathMethods.Add(userNumber);
            Console.WriteLine("Adding 10 to " + userNumber + " gives: " + addResult);

            // Calling the Multiply method and displaying the result
            int multiplyResult = MathMethods.Multiply(userNumber);
            Console.WriteLine("Multiplying " + userNumber + " by 2 gives: " + multiplyResult);

            // Calling the Subtract method and displaying the result
            int subtractResult = MathMethods.Subtract(userNumber);
            Console.WriteLine("Subtracting 5 from " + userNumber + " gives: " + subtractResult);

            // Ending the program
            Console.WriteLine("Math operations completed. Press any key to exit.");
            Console.ReadLine(); // Keeping the console open until the user presses a key
        }
    }
}
