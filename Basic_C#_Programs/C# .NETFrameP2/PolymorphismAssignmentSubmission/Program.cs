using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the Employee class and set its properties.
            Employee employee = new Employee
            {
                firstName = "Grafter 'Bob', ",
                lastName = "Son of older Grafter Steve 'Stevenson' looking for new opportunities"
            };

            // Call the SayName() method to show the Employee's name.
            employee.SayName();

            // Use polymorphism to create an object of type IQuittable.
            IQuittable quittable = employee;

            // Call the Quit() method on the IQuittable object, demonstrating polymorphism.
            quittable.Quit();

            // This line prevents the console window from closing immediately.
            Console.ReadLine();
        }
    }
}