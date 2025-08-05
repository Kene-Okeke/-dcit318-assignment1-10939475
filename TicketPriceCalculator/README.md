# Ticket Price Calculator

A C# console application that calculates movie ticket prices based on customer age.

## Features

- Calculates ticket prices based on age categories
- Provides discounts for children (12 and below) and senior citizens (65 and above)
- Input validation for age entry
- Clear and user-friendly interface

## Pricing Structure

- **Regular Adult Price**: GHC 10.00 (ages 13-64)
- **Child Discount**: GHC 7.00 (ages 12 and below)
- **Senior Citizen Discount**: GHC 7.00 (ages 65 and above)

## How to Run

### Prerequisites
- .NET 8.0 SDK or later

### Running the Application
1. Navigate to the project directory
2. Run the following commands:
   ```bash
   dotnet restore
   dotnet build
   dotnet run
   ```

### Alternative (if .NET is not installed)
You can compile and run the application using a C# compiler like `mcs` (Mono C# compiler) if available on your system.

## Program Flow

1. Display welcome message
2. Prompt user to enter their age
3. Validate the input
4. Calculate ticket price based on age
5. Display the result with appropriate discount information
6. Wait for user to press any key to exit

## Code Structure

- `Program.cs`: Contains the main program logic
- `TicketPriceCalculator.csproj`: Project configuration file
- `CalculateTicketPrice()`: Method that implements the pricing logic

## Example Output

```
=== Ticket Price Calculator ===
Welcome to the Movie Theater!

Please enter your age: 25

Your age: 25
Ticket price: GHC10.00
Regular adult price (GHC10)

Press any key to exit...
```

## Author

Student ID: [Your Student ID]
Course: DCIT318
Assignment: Assignment 1 