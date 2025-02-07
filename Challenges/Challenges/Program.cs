using System;

namespace BasicMathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the first number
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the second number
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Perform addition and display the result
            double sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");

            // Perform subtraction and display the result
            double difference = num1 - num2;
            Console.WriteLine($"The difference between {num1} and {num2} is: {difference}");

            // Perform multiplication and display the result
            double product = num1 * num2;
            Console.WriteLine($"The product of {num1} and {num2} is: {product}");

            // Perform division and display the result
            if (num2 != 0) // Check to avoid division by zero
            {
                double quotient = num1 / num2;
                Console.WriteLine($"The quotient of {num1} divided by {num2} is: {quotient}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
