using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type "string" as its generic parameter.
            Employee<string> stringEmployee = new Employee<string>();
            // Assign a list of strings to the "Things" property.
            stringEmployee.Things = new List<string> { "Book", "Pen", "Laptop" };

            // Instantiate an Employee object with type "int" as its generic parameter.
            Employee<int> intEmployee = new Employee<int>();
            // Assign a list of integers to the "Things" property.
            intEmployee.Things = new List<int> { 1, 2, 3 };

            // Create a loop to print all items in the stringEmployee's Things list.
            Console.WriteLine("String: Employee Things:");
            foreach (string item in stringEmployee.Things)
            {
                Console.WriteLine(item);  // Print each string item to the Console.
            }

            // Create a loop to print all items in the intEmployee's Things list.
            Console.WriteLine("\nInt Employee Things:");
            foreach (int number in intEmployee.Things)
            {
                Console.WriteLine(number); // Print each integer number to the Console.
            }

            // Wait for the user to press Enter before closing the console window.
            Console.ReadLine();
        }
    }
}