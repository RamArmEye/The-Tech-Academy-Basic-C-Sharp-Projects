using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message to the user.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight.
            Console.Write("Please enter the package weight in kg: ");
            // Read and convert the input to a double.
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the package weight exceeds 50.
            if (weight > 50)
            {
                // Display an error message if the package is too heavy.
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // End the program if the package is too heavy.
                return;
            }

            // Prompt the user to enter the package width.
            Console.Write("Please enter the package width in cm: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the package height.
            Console.Write("Please enter the package height in cm: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the package length.
            Console.Write("Please enter the package length in cm: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Calculate the total of the dimensions (width + height + length).
            double dimensionsTotal = width + height + length;

            // Check if the sum of the dimensions exceeds 50.
            if (dimensionsTotal > 50)
            {
                // Display an error message if the package is too big.
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // End the program if the package dimensions are too large.
                return;
            }

            // Calculate the shipping quote.
            // Multiply the three dimensions together, then multiply by the weight,
            // and finally divide the result by 100.
            double quote = (width * height * length * weight) / 100;

            // Display the shipping quote formatted as GB pounds amount.
            Console.WriteLine($"Your estimated total for shipping this package is: £{quote:0.00}");
            Console.WriteLine("Thank you!");
        }
    }
}
