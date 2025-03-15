using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console.
            Console.WriteLine("The current time is: " + DateTime.Now);

            // Ask the user to enter a number representing hours.
            Console.Write("\nEnter a number to see what the time will be in that many hours: ");
            // Read the user's input from the console and parse it to a float.
            float hoursToAdd = float.Parse(Console.ReadLine());

            // Calculate the future time by adding the specified number of hours to the current time.
            DateTime futureTime = DateTime.Now.AddHours(hoursToAdd);

            // Print the future time to the console.
            // The placeholder {0} is replaced by the number of hours, and {1} by the calculated future time.
            Console.WriteLine("In {0} hour(s), the time will be: {1}", hoursToAdd, futureTime);

            // Wait for the user to press Enter before closing the console window.
            Console.ReadLine();
        }
    }
}