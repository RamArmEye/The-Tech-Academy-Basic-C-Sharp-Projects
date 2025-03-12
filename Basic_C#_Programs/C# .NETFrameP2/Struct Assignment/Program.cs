using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    // Create a struct called Number.
    public struct Number
    {
        // Define a property "Amount" of type decimal.
        public decimal Amount { get; set; }
    }

    // The Program class contains the Main() method, the entry point of the application.
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Number struct.
            Number myNumber = new Number();

            // Assign a value to the Amount property.
            myNumber.Amount = 123.45m; // 'm' denotes that the value is a decimal literal.

            // Print the value of Amount to the console.
            Console.WriteLine("The amount is: " + myNumber.Amount);

            // Wait for the user to press Enter before closing the console window.
            Console.ReadLine();
        }
    }
}
