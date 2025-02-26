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
                "welcome To The",
                  "I'm Principal,",
                     "Our students with a"
};
            string[] wordend = {
                "Academy,",
                 ",",
                "learning experience."
};
            List<string> responses = new List<string>();

            // Ask the user to input some text.
            Console.WriteLine("Please enter a noun:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter the name of someone infamous:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter an adjective:");
            responses.Add(Console.ReadLine());

            // Create a loop that goes through each string in the Array, adding the user's text to the string.
            for (int i = 0; i < wordstart.Length; i++)
            {
                wordstart[i] += responses[i];
                Console.WriteLine(wordstart[i]);
            }
            Console.WriteLine("The strings we used:");

            // Then create a loop that prints off each string in the Array on a separate line.
            for (int i = 0; i < wordstart.Length; i++)
            {
                Console.WriteLine(wordstart[i]);
            }

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




            // Part 3
            Console.WriteLine("Is that a ghost!?");
            StringBuilder boo = new StringBuilder();
            boo.Append("B");

            // Create a loop where the comparison that's used to determine whether to continue iterating the loop is a "==" operator.
            while (boo.Length < 10)
            {
                boo.Append("o");
            }
            Console.WriteLine(boo);
            StringBuilder ahh = new StringBuilder();

            // Create a loop where the comparison that's used to determine whether to continue iterating the loop is a "<=" operator.
            while (ahh.Length <= 10)
            {
                ahh.Append("h");
            }
            Console.WriteLine(ahh);
            Console.ReadLine();

            // Part 4
            // Create a list of strings where each item in the list is unique.
            List<string> teams = new List<string>() { "Bucks", "Raptors", "Celtics", "Heat", "Pacers", "76ers", "Nets", "Magic", "Wizards", "Hornets", "Bulls", "Knicks", "Pistons", "Hawks", "Cavaliers" };

            // Ask the user to input text to search for in the List.
            Console.WriteLine("Enter team name:");
            int standing = 0;
            bool isValid = false;
            int index = 0;

            // Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            while (!isValid)
            {
                string teamrequest = Console.ReadLine();
                foreach (string team in teams)
                {
                    if (teamrequest == team)
                    {
                        standing = 12 + 1;
                        index = teams.IndexOf(team);
                        isValid = true;
                    }
                }
                if (!isValid)
                {
                    Console.WriteLine("That is not a valid team name. Enter again:");
                }
                // Add code to that above loop that stops it from executing once a match has been found.
                if (isValid == true)
                {
                    break;
                }
            }
            Console.WriteLine("Processing... Index is: " + index + ". So...");
            Console.WriteLine("Standing is: " + standing);

            // Part 5
            // Create a list of strings that has at least two identical strings in the list.
            List<string> Reserved = new List<string> { "Vacant", "Vacant", "Reserved", "Taken" };

            // Ask the user if they are joining a party that is already here type *Taken*, *Reserved*, or *Vacant*.
            Console.WriteLine("Welcome to Swill Taco! Due to COVID-19 we have a computerized check-in. If you have a reservation type *Taken* / *If you are joining a party that is already here type *Reserved* / If you are on your own type *Vacant*");
            string selection = Console.ReadLine();

            // Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            for (int i = 0; i < Reserved.Count; i++)
            {
                if (selection == Reserved[i])
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            // Part 6
            // Create a list of strings that has at least two identical strings in the list.
            List<string> names = new List<string> { "Jim", "Jim", "Tiffany", "Bob", "Kat", "Mary", "Mary" };

            // Create a list to track repeated names
            List<string> repeatCheck = new List<string>();

            // Create a loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            foreach (string name in names)
            {
                if (repeatCheck.Contains(name))
                {
                    Console.WriteLine("This name has been repeated. Use last name initial when referring to this student.");
                }
                else
                {
                    Console.WriteLine("This name has not been repeated.");
                }
                repeatCheck.Add(name);
            }
            Console.ReadLine();
        }
    }
}

