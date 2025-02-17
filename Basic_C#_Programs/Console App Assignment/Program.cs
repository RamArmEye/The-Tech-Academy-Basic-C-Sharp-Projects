using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------
            // While Loop 
            // ------------------------------

            // Initialize a counter variable for the while loop.
            int counter = 0;

            // The while loop continues executing as long as the condition (counter < 10) is true.
            while (counter < 10)
            {
                // Output the current iteration of the while loop.
                Console.WriteLine("While loop iteration, counter = " + counter);

                // Increment the counter by 1.
                counter++;
            }

            // While loop has completed.
            Console.WriteLine("While loop completed.\n");

            // ------------------------------
            // Do-While Loop
            // ------------------------------

            // Initialize a counter variable for the do-while loop.
            int doCounter = 0;

            // The do-while loop executes its block at least once before checking the condition.
            do
            {
                // Output the current iteration of the do-while loop.
                Console.WriteLine("Do-while loop iteration, doCounter = " + doCounter);

                // Increment the doCounter by 1.
                doCounter++;
            }
            // The condition is checked after executing the block. The loop continues while doCounter is less than 5.
            while (doCounter < 5);

            // do-while loop has completed.
            Console.WriteLine("Do-while loop completed.\n");

            // ------------------------------
            // End of Program
            // ------------------------------

            // Wait for the user to press any key before closing the console window.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
