using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Type Identifier");
            Console.WriteLine("=======================");
            Console.WriteLine();

            try
            {
                // Get the three sides from user input
                double side1 = GetSideLength("Enter the length of the first side: ");
                double side2 = GetSideLength("Enter the length of the second side: ");
                double side3 = GetSideLength("Enter the length of the third side: ");

                // Validate that the sides can form a triangle
                if (!IsValidTriangle(side1, side2, side3))
                {
                    Console.WriteLine("Error: The given sides cannot form a triangle.");
                    Console.WriteLine("The sum of any two sides must be greater than the third side.");
                    return;
                }

                // Determine and display the triangle type
                string triangleType = DetermineTriangleType(side1, side2, side3);
                Console.WriteLine();
                Console.WriteLine($"The triangle is: {triangleType}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static double GetSideLength(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out double side) && side > 0)
                {
                    return side;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive number.");
                }
            }
        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            // Triangle inequality theorem: sum of any two sides must be greater than the third side
            return a + b > c && a + c > b && b + c > a;
        }

        static string DetermineTriangleType(double a, double b, double c)
        {
            // Check if all sides are equal (Equilateral)
            if (Math.Abs(a - b) < 0.001 && Math.Abs(b - c) < 0.001)
            {
                return "Equilateral";
            }
            // Check if two sides are equal (Isosceles)
            else if (Math.Abs(a - b) < 0.001 || Math.Abs(a - c) < 0.001 || Math.Abs(b - c) < 0.001)
            {
                return "Isosceles";
            }
            // No sides are equal (Scalene)
            else
            {
                return "Scalene";
            }
        }
    }
} 