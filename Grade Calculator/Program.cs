using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Grade Calculator ===");
            Console.WriteLine("Enter a numerical grade between 0 and 100:");
            
            // Get user input
            string input = Console.ReadLine();
            
            // Validate input
            if (double.TryParse(input, out double grade))
            {
                // Check if grade is within valid range
                if (grade >= 0 && grade <= 100)
                {
                    // Determine letter grade
                    string letterGrade = DetermineLetterGrade(grade);
                    
                    // Display result
                    Console.WriteLine($"\nNumerical Grade: {grade}");
                    Console.WriteLine($"Letter Grade: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
        static string DetermineLetterGrade(double grade)
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }
    }
} 