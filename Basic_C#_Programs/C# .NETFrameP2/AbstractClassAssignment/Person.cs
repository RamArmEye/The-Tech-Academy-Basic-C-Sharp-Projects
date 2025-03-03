using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // The "Employee" class inherits from the abstract "Person" class.
    // This means "Employee" must provide an implementation for any abstract members in "Person".
    public class Employee : Person
    {
        // Here we override the abstract method "SayName()" from the "Person" class.
        // This is where we provide the actual implementation for what "SayName()" should do.
        public override void SayName()
        {
            // We simply output the first and last name properties to the console.
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}