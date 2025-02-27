using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathOperations
    {
        // First method that takes an integer and adds 10 to it
        public int PerformOperation(int number)
        {
            return number + 10; // Adding 10 to the input number and returning the result
        }

        // Second method that takes a decimal and multiplies it by 2, then returns an integer
        public int PerformOperation(decimal number)
        {
            int result = Convert.ToInt32(number) * 2; // Convert decimal to int and multiply by 2
            return result; // Returning the computed integer
        }

        // Third method that takes a string, converts it to an integer, and subtracts 5
        public int PerformOperation(string number)
        {
            int num = Convert.ToInt32(number); // Convert string to integer
            return num - 5; // Subtract 5 and return result
        }
    }
}
