using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the applicant for their age and read the input from the console.
            Console.WriteLine("What is your age?");
            // Convert the input string to an integer.
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask the applicant if they have ever had a DUI.
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            // Convert the input string to a boolean value.
            bool hasDui = Convert.ToBoolean(Console.ReadLine());

            // Ask the applicant for the number of speeding tickets they have.
            Console.WriteLine("How many speeding tickets do you have?");
            // Convert the input string to an integer.
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Check if the applicant qualifies:
            // - Must be over 15 years old.
            // - Must NOT have had a DUI.
            // - Must NOT have more than 3 speeding tickets.
            bool isQualified = (age > 15) && (!hasDui) && (speedingTickets <= 3);

            // Output the result of the qualification check.
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);
        }
    }
}
