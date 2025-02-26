using System; // Import the System namespace for basic input/output functionality

namespace StudentReport // Declare a namespace called StudentReport
{
    class Program // Define a class named Program (entry point of the application)
    {
        static void Main(string[] args) // Main method where the program execution begins
        {
            // Display the heading for the report
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");

            // Prompt the user for their name and store it in a variable
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // Prompt the user for the course they are taking and store it in a variable
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Prompt the user for the page number they are on and convert the input to an integer
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());

            // Ask the user if they need help and capture their response as a string
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();

            // Convert the string response to a boolean value (true or false)
            bool needHelpBool = bool.Parse(needHelp);

            // Ask the user to share any positive experiences they had
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            // Ask the user for additional feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Prompt the user for the number of hours they studied today and convert the input to an integer
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);

            // Display a thank-you message to the user
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
