using System;
using System.Collections.Generic;

namespace ConsoleAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of car brands
            List<string> carBrands = new List<string>()
            { "Toyota", "Ford", "Honda", "BMW", "Tesla", "Mercedes", "Audi", "Nissan", "Chevrolet" };

            bool isValid = false;
            int indexSelection;

            // Display a preselected car brand
            Console.WriteLine("A preselected car brand is: " + carBrands[2]);

            // Ask the user to enter an index
            Console.WriteLine("Please enter a number between 0 and 8 to select a car brand: ");
            isValid = int.TryParse(Console.ReadLine(), out indexSelection);

            // Validate the index input
            while (!isValid || indexSelection < 0 || indexSelection >= carBrands.Count)
            {
                Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 8.");
                isValid = int.TryParse(Console.ReadLine(), out indexSelection);
            }

            Console.WriteLine("Your selected car brand is: " + carBrands[indexSelection]);

            // List of student names
            List<string> students = new List<string>()
            {
                "Alice", "Bob", "Charlie", "David", "Emma", "Frank", "Grace", "Henry", "Sophia"
            };

            // Display a preselected student name
            Console.WriteLine("\nA preselected student is: " + students[2]);

            // Ask the user for an index to display the student name
            Console.WriteLine("Please enter a number between 0 and 8 to select a student: ");
            isValid = int.TryParse(Console.ReadLine(), out indexSelection);

            // Validate the index input
            while (!isValid || indexSelection < 0 || indexSelection >= students.Count)
            {
                Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 8.");
                isValid = int.TryParse(Console.ReadLine(), out indexSelection);
            }

            Console.WriteLine("Your selected student is: " + students[indexSelection]);
        }
    }
}
