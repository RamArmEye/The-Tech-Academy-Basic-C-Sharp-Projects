using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmentSubmission
{ 
    // 2. Employee class inherit from Person and also implement IQuittable.
    public class Employee : Person, IQuittable
{
    // Implementing the abstract SayName() method from the Person class.
    public override void SayName()
    {
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }

    // 3++++ Implement the Quit() method from the IQuittable interface 
    public void Quit()
    {
        Console.WriteLine("I have decided to quit BOOORING job. Goodbye!");
        Console.WriteLine("Hello OSINT? CyberSec? ");
        }
   }
}