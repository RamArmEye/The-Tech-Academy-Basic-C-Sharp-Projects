using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // This is the abstract class "Person".
    // Being abstract means it cannot be directly instantiated,
    // and it may contain abstract members that derived classes must implement.
    public abstract class Person
    {
        // Public auto-implemented properties for storing a person's first and last name.
        public string firstName { get; set; }
        public string lastName { get; set; }

        // This is an abstract method. Abstract methods have no implementation
        // in the abstract class and must be overridden in a derived class.
        public abstract void SayName();
    }
}