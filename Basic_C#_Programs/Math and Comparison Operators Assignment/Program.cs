using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_Operators_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Header
            Console.WriteLine("Anonymous Income Comparison Program");

            // Person 1 input
            Console.WriteLine("\nPerson 1");
            Console.Write("Hourly Rate? £ ");
            double hourlyRate1 = double.Parse(Console.ReadLine());
            Console.Write("Hours worked per week? ");
            double hoursPerWeek1 = double.Parse(Console.ReadLine());

            // Person 2 input
            Console.WriteLine("\nPerson 2");
            Console.Write("Hourly Rate? £");
            double hourlyRate2 = double.Parse(Console.ReadLine());
            Console.Write("Hours worked per week? ");
            double hoursPerWeek2 = double.Parse(Console.ReadLine());

            // Calculate annual salaries (assuming 52 weeks per year)
            double annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
            double annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

            // Display annual salaries
            Console.WriteLine("\nAnnual salary of Person 1:£");
            Console.WriteLine((int)annualSalary1);
            Console.WriteLine("\nAnnual salary of Person 2:£");
            Console.WriteLine((int)annualSalary2);

            // Compare salaries and display result
            Console.WriteLine("\nPerson 1 makes more money than Person 2");
            Console.WriteLine(annualSalary1 > annualSalary2);

            // Keep the console open
            Console.ReadLine();
        }
    }
}
