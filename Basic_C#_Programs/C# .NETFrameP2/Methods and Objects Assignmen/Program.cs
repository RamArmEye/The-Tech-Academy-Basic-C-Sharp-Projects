using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignmen
{
    // The Program class contains the Main method, the entry point of our application.
    class Program
    {
        // The Main method is automatically called when the application starts.
        static void Main(string[] args)
        {
            // Instantiate an Employee object and assign values to its properties.
            // FirstName and LastName come from the Person base class.
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
                // Optionally, you can also set Id if you like, e.g., Id = 1
            };

            // Call the SayName() method, which is inherited from the Person class.
            employee.SayName();

            // This line prevents the console window from closing immediately,
            // allowing you to view the output.
            Console.ReadLine();
        }
    }
}