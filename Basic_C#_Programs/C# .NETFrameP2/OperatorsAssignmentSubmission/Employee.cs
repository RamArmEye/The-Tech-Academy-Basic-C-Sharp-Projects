using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignmentSubmission
{
    // Employee class
    public class Employee
    {
        //Employee's unique identifier.
        public int Id { get; set; }
        // Employee's first name.
        public string FirstName { get; set; }
        // Employee's last name.
        public string LastName { get; set; }

        // Overload the '==' operator to compare two Employee objects by their Id.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are null, they are considered equal.
            if (emp1 is null && emp2 is null)
                return true;
            // If one of the objects is null, they are not equal.
            if (emp1 is null || emp2 is null)
                return false;
            // Compare the Id properties of both Employee objects.
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator. It must be paired with the '==' operator.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite of the '==' operator result.
            return !(emp1 == emp2);
        }
    }
}
