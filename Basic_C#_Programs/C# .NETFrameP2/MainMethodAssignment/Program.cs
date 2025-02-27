using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations math = new MathOperations();

            // Call the first method with an integer
            Console.WriteLine("Result of PerformOperation(22): " + math.PerformOperation(22));

            // Call the second method with a decimal
            Console.WriteLine("Result of PerformOperation(8.8m): " + math.PerformOperation(8.8m));

            // Call the third method with a string
            Console.WriteLine("Result of PerformOperation(\"235\"): " + math.PerformOperation("235"));

            // Keep the console open
            Console.ReadLine();
        }
    }
}