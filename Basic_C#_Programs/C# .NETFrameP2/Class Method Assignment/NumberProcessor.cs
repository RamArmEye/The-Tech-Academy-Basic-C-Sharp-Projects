using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    public class NumberProcessor
    {
        // Void method that divides input by 2 and outputs result
        public void DivideByTwo(int number)
        {
            int result = number / 2;          // Performs integer division
            Console.WriteLine($"Result: {result}");  // Displays the result
        }

        // Method with output parameter
        public void GetNumberInfo(int number, out bool isEven)
        {
            isEven = (number % 2 == 0);      // Determines if number is even
        }

        // Original method to be overloaded
        public string ProcessNumber(int number)
        {
            return $"Processed number: {number}";  // Basic number processing
        }

        // Overloaded method with different parameter type
        public string ProcessNumber(double number)
        {
            return $"Processed decimal: {number:F2}";  // Formats to 2 decimal places
        }
    }
}