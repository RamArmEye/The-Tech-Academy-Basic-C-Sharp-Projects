using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmentSubmission
{ 
// This is the abstract Person class from the previous assignment.
// Being abstract, it cannot be instantiated directly!!!.
    public abstract class Person
{
    // Public properties for storing a person's first and last name.
    public string firstName { get; set; }
    public string lastName { get; set; }

    // Abstract method
    public abstract void SayName();
    }
}
