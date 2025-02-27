using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation mathOp = new MathOperation();

            // Call the method with two integers (A void method with two integer
            // parameters performs
            // an operation on num1 and displays num2)
            Console.WriteLine("Calling method with positional arguments:");
            mathOp.PerformOperation(10, 5);

            Console.WriteLine("=================================="); // Blank line for readability

            // Call the method with named parameters(Named parameters allow calling
            // the method by explicitly specifying parameter names,
            // making the code more readable)
            Console.WriteLine("Calling method with named parameters:");
            mathOp.PerformOperation(num1: 7, num2: 3);

            // Keep the console open
            Console.ReadLine();
        }
    }
}