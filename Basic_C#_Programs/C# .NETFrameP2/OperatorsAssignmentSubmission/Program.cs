using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object with Id, FirstName, and LastName.
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

            // Create the second Employee object with the same Id.
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded '==' operator.
            if (employee1 == employee2)
            {
                Console.WriteLine("Employee objects are equal based on their Id.");
            }
            else
            {
                Console.WriteLine("Employee objects are not equal based on their Id.");
            }

            // Prevent the console window from closing immediately.
            Console.ReadLine();
        }
    }
}