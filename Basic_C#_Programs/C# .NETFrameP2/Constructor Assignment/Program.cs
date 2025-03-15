using System;
using System.Security.Claims;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Text;
//using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create const variables.
            // These constants do not change during the program’s execution.
            const string const1 = "Your favorite car is: ";
            const string const2 = "Your favorite state is: ";

            // Prompt the user to enter either a favorite car or a favorite state.
            Console.WriteLine("Enter your favorite car or favorite state: ");

            // 2. Create a variable using the 'var' keyword.
            // The compiler infers the type of 'answer' as 'string'.
            var answer = Console.ReadLine();

            // Check if the user input matches a typical U.S. state. 
            // (You can expand this list or change the logic to suit your needs.)
            if (answer.Equals("california", StringComparison.OrdinalIgnoreCase)
             || answer.Equals("texas", StringComparison.OrdinalIgnoreCase)
             || answer.Equals("florida", StringComparison.OrdinalIgnoreCase)
             || answer.Equals("new york", StringComparison.OrdinalIgnoreCase))
            {
                // If the user typed a known state, we call the constructor that expects a state.
                Console.WriteLine(const2);
                Chain newChain = new Chain(true, answer);

                // Pause so the console remains open until the user presses Enter.
                Console.ReadLine();
            }
            else
            {
                // Otherwise, treat the input as a favorite car and call the constructor for cars.
                Console.WriteLine(const1);
                Chain newChain = new Chain(answer);

                // Pause so the console remains open until the user presses Enter.
                Console.ReadLine();
            }
        }
    }
}