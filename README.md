# Grade Calculator

A simple C# console application that converts numerical grades to letter grades.

## Features

- Prompts user to enter a numerical grade between 0 and 100
- Validates input to ensure it's a valid number within the specified range
- Converts numerical grades to letter grades using the following scale:
  - 90 and above: A
  - 80-89: B
  - 70-79: C
  - 60-69: D
  - Below 60: F
- Displays both the numerical and letter grade

## How to Run

1. Make sure you have .NET SDK installed on your machine
2. Open a terminal in the project directory
3. Run the following command:
   ```
   dotnet run
   ```
4. Enter a numerical grade when prompted
5. View the corresponding letter grade

## Project Structure

- `Program.cs` - Main application logic
- `GradeCalculator.csproj` - Project configuration file
- `README.md` - Project documentation

## Requirements

- .NET 8.0 or later
- C# 12.0 or later

## Assignment Information

This project was created for DCIT318 Assignment 1. 