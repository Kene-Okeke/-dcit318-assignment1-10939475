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
            string? input = Console.ReadLine();
            
            // Validate input
            if (string.IsNullOrEmpty(input) || !double.TryParse(input, out double grade))
            {
                Console.WriteLine("Invalid input. Please enter a valid number between 0 and 100.");
                return;
            }
            
            // Check if grade is within valid range
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100.");
                return;
            }
            
            // Determine letter grade
            string letterGrade = DetermineLetterGrade(grade);
            
            // Display result
            Console.WriteLine($"\nNumerical Grade: {grade}");
            Console.WriteLine($"Letter Grade: {letterGrade}");
            
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