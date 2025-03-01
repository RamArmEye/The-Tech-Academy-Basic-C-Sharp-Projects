using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignmen
{
    // The Person class represents a generic person with a first and last name.
    public class Person
    {
        // Property for storing the first name of a person.
        public string FirstName { get; set; }

        // Property for storing the last name of a person.
        public string LastName { get; set; }

        // This method writes the person's full name to the console.
        public void SayName()
        {
            // Prints out "Name: " followed by the person's first and last name.
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }
}