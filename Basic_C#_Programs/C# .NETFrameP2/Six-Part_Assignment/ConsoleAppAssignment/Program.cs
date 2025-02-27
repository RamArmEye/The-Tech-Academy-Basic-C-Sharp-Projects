using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            // Create a one - dimensional Array of strings.
            string[] wordstart = {
                "cruise in the",
                "rev up the",
                "drive my"
            };
            string[] wordend = {
                "Mustang,",
                "Camaro,",
                "Corvette."
            };
            List<string> responses = new List<string>();

            // Ask the user to input some text.
            Console.WriteLine("Please enter a car model:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter the name of a famous racecar driver:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter an adjective describing speed:");
            responses.Add(Console.ReadLine());

            // Create a loop that goes through each string in the Array, adding the user's text to the string with proper spacing.
            for (int i = 0; i < wordstart.Length; i++)
            {
                wordstart[i] = wordstart[i] + " " + responses[i] + " " + wordend[i];
                Console.WriteLine(wordstart[i]);
            }
            Console.WriteLine("The strings we used:");

            // Then create a loop that prints off each string in the Array on a separate line.
            for (int i = 0; i < wordstart.Length; i++)
            {
                Console.WriteLine(wordstart[i]);
            }

            // Part 2(error, fixed below)
            // Create an infinite loop (Uncomment line "i--;" for infinite loop.
            //i--;

            Console.ReadLine();

            // Part 2
            // Create an infinite loop
            while (true)
            {
                Console.WriteLine("This is an infinite loop. Press any key to continue...");
                Console.ReadKey();
                // Infinite loop fixed by adding a break condition or user input to exit
                // The loop will continue until the user presses a key, at which point it can be terminated manually
                break; // Uncomment this line and comment the Console.ReadKey() line to stop the loop after one iteration
            }

            Console.ReadLine();




            // Part 3 - A Funny Ghost Encounter
            Console.WriteLine("Did we just hit a pothole... or was that a ghost?");

            // Create a "Boooo" from our ghost.
            StringBuilder boo = new StringBuilder("B");
            while (boo.Length < 10)
            {
                boo.Append("o");
            }
            Console.WriteLine("The ghost whispers: " + boo.ToString() + "!");

            // Now let the ghost scream in horror (or maybe it's just ticklish).
            StringBuilder ahh = new StringBuilder();
            while (ahh.Length <= 10)
            {
                ahh.Append("h");
            }
            Console.WriteLine("Then it screams: " + ahh.ToString() + "!");

            // Extra humorous prompt to keep the mood light.
            Console.WriteLine("Run for your life... or grab some popcorn!");
            Console.ReadLine();


            // Part 4
            // Create a list of strings where each item in the list is unique.
            List<string> cars = new List<string>() { "Toyota", "Honda", "Ford", "RAV4", "Nissan", "Volkswagen", "Kia Sportage", "Subaru", "Mazda", "Ford Explorer" };

            // Ask the user to input text to search for in the List.
            Console.WriteLine("Enter car name:");
            int standing = 0;
            bool isValid = false;
            int index = 0;

            // Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            while (!isValid)
            {
                string carrequest = Console.ReadLine();
                foreach (string car in cars)
                {
                    if (carrequest == car)
                    {
                        standing = 12 + 1;
                        index = cars.IndexOf(car);
                        isValid = true;
                    }
                }
                if (!isValid)
                {
                    Console.WriteLine("That is not a valid car name. Enter again:");
                }
                // Add code to that above loop that stops it from executing once a match has been found.
                if (isValid == true)
                {
                    break;
                }
            }
            Console.WriteLine("Processing... Index is: " + index + ". So...");
            Console.WriteLine("Standing is: " + standing + ". That puts it in the 'Top Secret Garage' league—shh, don’t tell the others!");

            // Part 5
            // Create a list of strings that has at least two identical car rental statuses in the list.
            List<string> AvailableCars = new List<string> { "Ford", "Ford", "Chevrolet", "Toyota" };

            // Ask the user to select a car model to check availability at our rental service.
            Console.WriteLine("Welcome to TTT Car Rentals! Please enter a car model to check availability (e.g., Ford, Chevrolet, Toyota):");
            string selection = Console.ReadLine();

            // Flag to track if a match is found
            bool matchFound = false;

            // Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.
            for (int i = 0; i < AvailableCars.Count; i++)
            {
                if (selection == AvailableCars[i])
                {
                    Console.WriteLine("Available at slot: " + i);
                    matchFound = true;
                }
            }

            // Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
            if (!matchFound)
            {
                Console.WriteLine("Sorry, that car model is not available at TTT Car Rentals.");
            }

            Console.ReadLine();

            // Part 6
            // Create a list of strings that has at least two identical car-color combinations in the list.
            List<string> carColors = new List<string> { "Red Ford Mustang", "Red Ford Mustang", "Blue Chevrolet Camaro", "Black Toyota Prius", "Green Jeep Wrangler", "Silver Honda Civic", "Silver Honda Civic" };

            // Create a list to track repeated car-color combinations
            List<string> repeatCheck = new List<string>();

            // Create a loop that evaluates each item in the list, and displays a message showing the car-color combination and whether or not it has already appeared in the list.
            foreach (string carColor in carColors)
            {
                if (repeatCheck.Contains(carColor))
                {
                    Console.WriteLine("This car-color combination (" + carColor + ") has been repeated. Check for duplicates in the inventory!");
                }
                else
                {
                    Console.WriteLine("This car-color combination (" + carColor + ") has not been repeated.");
                }
                repeatCheck.Add(carColor);
            }
            Console.ReadLine();
        }
    }
}
