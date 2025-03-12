using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    // Create an Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        // Unique identifier for each employee
        public int Id { get; set; }

        // Employee's first name
        public string FirstName { get; set; }

        // Employee's last name
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of at least 10 employees
            // At least two employees must have the first name "Joe"
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee() { Id = 2, FirstName = "Joe", LastName = "Johnson" },
                new Employee() { Id = 3, FirstName = "Emily", LastName = "Clark" },
                new Employee() { Id = 4, FirstName = "Michael", LastName = "Brown" },
                new Employee() { Id = 5, FirstName = "Sarah", LastName = "Davis" },
                new Employee() { Id = 6, FirstName = "Chris", LastName = "Wilson" },
                new Employee() { Id = 7, FirstName = "Anna", LastName = "Taylor" },
                new Employee() { Id = 8, FirstName = "James", LastName = "Anderson" },
                new Employee() { Id = 9, FirstName = "Maria", LastName = "Thomas" },
                new Employee() { Id = 10, FirstName = "David", LastName = "White" }
            };

            // Create a new list to store employees whose first name is "Joe"
            List<Employee> joes = new List<Employee>();

            // Use a foreach loop to find all employees with the first name "Joe"
            foreach (Employee employee in employees)
            {
                // Check if the employee's first name is "Joe"
                if (employee.FirstName == "Joe")
                {
                    // Add the employee to the joes list
                    joes.Add(employee);
                }
            }

            // Output the list of employees named Joe found by the foreach loop
            Console.WriteLine("Employees named Joe (found with foreach loop):");
            foreach (Employee joe in joes)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Do the same thing as above, but this time using a lambda expression
            List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Output the list of employees named Joe found by the lambda expression
            Console.WriteLine("\nEmployees named Joe (found with lambda expression):");
            foreach (Employee joe in joesLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Using a lambda expression, make a list of all employees with an Id greater than 5
            List<Employee> idGreaterThanFive = employees.Where(e => e.Id > 5).ToList();

            // Output the list of employees whose Id is greater than 5
            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (Employee employee in idGreaterThanFive)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}