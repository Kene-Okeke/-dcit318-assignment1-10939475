using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ticket Price Calculator ===");
            Console.WriteLine("Welcome to the Movie Theater!");
            Console.WriteLine();
            
            // Prompt user to enter their age
            Console.Write("Please enter your age: ");
            
            // Read and validate user input
            string? input = Console.ReadLine();
            
            if (int.TryParse(input, out int age))
            {
                // Calculate ticket price based on age
                decimal ticketPrice = CalculateTicketPrice(age);
                
                // Display the result
                Console.WriteLine();
                Console.WriteLine($"Your age: {age}");
                Console.WriteLine($"Ticket price: GHC{ticketPrice:F2}");
                
                // Show discount information if applicable
                if (age <= 12)
                {
                    Console.WriteLine("You qualify for the child discount (GHC7)!");
                }
                else if (age >= 65)
                {
                    Console.WriteLine("You qualify for the senior citizen discount (GHC7)!");
                }
                else
                {
                    Console.WriteLine("Regular adult price (GHC10)");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid age (number).");
            }
            
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Calculates the ticket price based on the customer's age
        /// </summary>
        /// <param name="age">The customer's age</param>
        /// <returns>The ticket price in GHC</returns>
        static decimal CalculateTicketPrice(int age)
        {
            // Senior citizens (65 and above) and children (12 and below) get discounted price
            if (age >= 65 || age <= 12)
            {
                return 7.00m; // Discounted price: GHC7
            }
            else
            {
                return 10.00m; // Regular price: GHC10
            }
        }
    }
} 