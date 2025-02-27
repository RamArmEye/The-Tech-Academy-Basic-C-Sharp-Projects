using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class MathOperation
    {
        // Create a method that takes two integers as parameters
        // The second parameter is optional, with a default value of 5
        public int PerformOperation(int num1, int num2 = 5)
        {
            // Perform addition operation and return the result
            return num1 + num2;
        }
    }
}
