using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{

    // The "Program" class contains the Main() method,
    // which is the entry point of our console application.
    class Program
    {
        static void Main(string[] args)
        {
            // We create an instance of the "Employee" class and set its properties.
            // Notice we can instantiate "Employee" because it is not abstract.
            Employee employee = new Employee()
            {
                firstName = "Steve",
                lastName = "Stevenson"
            };

            // We call the "SayName()" method on our "employee" object.
            // This method was overridden in the "Employee" class and
            // will print out the first and last name to the console.
            employee.SayName();

            // This line prevents the console window from closing immediately
            // so we can see the output.
            Console.ReadLine();
        }
    }
}