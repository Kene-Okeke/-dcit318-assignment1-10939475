# Triangle Type Identifier

A C# console application that determines the type of triangle based on the lengths of its three sides.

## Features

- Prompts user to enter three side lengths
- Validates that the sides can form a valid triangle
- Determines triangle type:
  - **Equilateral**: All three sides are equal
  - **Isosceles**: Two sides are equal
  - **Scalene**: No sides are equal
- Handles input validation and error cases

## How to Run

1. Make sure you have .NET 8.0 or later installed
2. Open a terminal in the project directory
3. Run the application:
   ```bash
   dotnet run
   ```

## Example Usage

```
Triangle Type Identifier
=======================

Enter the length of the first side: 5
Enter the length of the second side: 5
Enter the length of the third side: 5

The triangle is: Equilateral

Press any key to exit...
```

## Triangle Types

- **Equilateral**: All three sides have the same length (e.g., 5, 5, 5)
- **Isosceles**: Exactly two sides have the same length (e.g., 5, 5, 3)
- **Scalene**: All three sides have different lengths (e.g., 3, 4, 5)

## Validation

The application validates that the entered sides can form a valid triangle using the Triangle Inequality Theorem: the sum of any two sides must be greater than the third side.
