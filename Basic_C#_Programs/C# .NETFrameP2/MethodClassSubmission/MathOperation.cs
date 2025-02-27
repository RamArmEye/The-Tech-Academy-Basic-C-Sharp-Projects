using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class MathOperation
    {
        // Create a void method that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer (multiply by 5)
            int result = num1 * 5;

            // Display the result of the operation
            Console.WriteLine("The result of multiplying " + num1 + " by 5 is: " + result);

            // Display the second integer as required
            Console.WriteLine("The second number you provided is: " + num2);
        }
    }
}