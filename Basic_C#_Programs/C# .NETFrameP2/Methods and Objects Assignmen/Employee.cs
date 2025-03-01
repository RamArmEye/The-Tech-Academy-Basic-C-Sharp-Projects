using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignmen
{
    // The Employee class inherits from Person and thus has FirstName and LastName properties already.
    public class Employee : Person
    {
        // An integer property to store the ID of an employee.
        public int Id { get; set; }
    }
}