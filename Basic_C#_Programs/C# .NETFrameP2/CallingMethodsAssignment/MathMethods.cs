using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class MathMethods
    {
        // Method to add 10 to the given number
        public static int Add(int number)
        {
            int result = number + 10; // Adding 10 to input number
            return result; // Returning the result
        }

        // Method to multiply the given number by 2
        public static int Multiply(int number)
        {
            int result = number * 2; // Multiplying input number by 2
            return result; // Returning the result
        }

        // Method to subtract 5 from the given number
        public static int Subtract(int number)
        {
            int result = number - 5; // Subtracting 5 from input number
            return result; // Returning the result
        }
    }
}