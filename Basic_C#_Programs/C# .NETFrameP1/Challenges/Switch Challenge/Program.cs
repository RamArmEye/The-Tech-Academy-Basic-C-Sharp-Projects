using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Challenge_code_and_learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a HashSet to track which months have been printed.
            HashSet<int> printedMonths = new HashSet<int>();

            // Continue prompting until all 12 months have been listed.
            while (printedMonths.Count < 12)
            {
                Console.Write("Enter a month number (1-12): ");
                string input = Console.ReadLine();
                int month;

                // Validate that the input is a number.
                if (!int.TryParse(input, out month))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                // Validate the month range.
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Month number must be between 1 and 12.");
                    continue;
                }

                // Check if the month has already been listed.
                if (printedMonths.Contains(month))
                {
                    Console.WriteLine("This month has already been listed. Please try a different month.");
                    continue;
                }

                string monthName;

                // Use switch to assign the English and Latin names.
                switch (month)
                {
                    case 1:
                        monthName = "January (Ianuarius)";
                        break;
                    case 2:
                        monthName = "February (Februarius)";
                        break;
                    case 3:
                        monthName = "March (Martius)";
                        break;
                    case 4:
                        monthName = "April (Aprilis)";
                        break;
                    case 5:
                        monthName = "May (Maius)";
                        break;
                    case 6:
                        monthName = "June (Junius)";
                        break;
                    case 7:
                        monthName = "July (Julius)";
                        break;
                    case 8:
                        monthName = "August (Augustus)";
                        break;
                    case 9:
                        monthName = "September (September)";
                        break;
                    case 10:
                        monthName = "October (October)";
                        break;
                    case 11:
                        monthName = "November (November)";
                        break;
                    case 12:
                        monthName = "December (December)";
                        break;
                    default:
                        monthName = "Invalid month";
                        break;
                }

                // Print the month and add it to the set of printed months.
                Console.WriteLine($"Month {month}: {monthName}");
                printedMonths.Add(month);
            }

            Console.WriteLine("All months have been listed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
