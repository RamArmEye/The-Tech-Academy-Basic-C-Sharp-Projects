using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Concatenate three strings.
            string firstPart = "Hello";
            string secondPart = "Beautiful";
            string thirdPart = "World!";
            string concatenated = firstPart + ", " + secondPart + " " + thirdPart;
            Console.WriteLine("Concatenated String:");
            Console.WriteLine(concatenated);
            Console.WriteLine();  // Blank line for readability

            // 2. Convert a string to uppercase.
            string originalText = "This text will be converted to uppercase.";
            string upperText = originalText.ToUpper();
            Console.WriteLine("Uppercase Conversion:");
            Console.WriteLine(upperText);
            Console.WriteLine();  // Blank line for readability

            // 3. Use StringBuilder to build a paragraph one sentence at a time.
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("This is the first sentence. ");
            paragraph.Append("Here is the second sentence. ");
            paragraph.Append("Now comes the third sentence. ");
            paragraph.Append("Finally, this is the fourth sentence.");
            Console.WriteLine("Paragraph Built with StringBuilder:");
            Console.WriteLine(paragraph.ToString());

            // Wait for the user to press Enter before exiting.
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}
