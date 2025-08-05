# Test Cases for Ticket Price Calculator

## Test Scenarios

### 1. Child Discount (Age 12 and below)

- **Input**: Age = 5
- **Expected Output**: GHC 7.00
- **Message**: "You qualify for the child discount (GHC7)!"

### 2. Child Discount (Age 12)

- **Input**: Age = 12
- **Expected Output**: GHC 7.00
- **Message**: "You qualify for the child discount (GHC7)!"

### 3. Regular Adult Price (Age 13-64)

- **Input**: Age = 25
- **Expected Output**: GHC 10.00
- **Message**: "Regular adult price (GHC10)"

### 4. Senior Citizen Discount (Age 65)

- **Input**: Age = 65
- **Expected Output**: GHC 7.00
- **Message**: "You qualify for the senior citizen discount (GHC7)!"

### 5. Senior Citizen Discount (Age above 65)

- **Input**: Age = 70
- **Expected Output**: GHC 7.00
- **Message**: "You qualify for the senior citizen discount (GHC7)!"

### 6. Invalid Input

- **Input**: "abc" or empty string
- **Expected Output**: "Invalid input! Please enter a valid age (number)."

## Edge Cases

### 7. Age 0

- **Input**: Age = 0
- **Expected Output**: GHC 7.00 (Child discount)

### 8. Very High Age

- **Input**: Age = 120
- **Expected Output**: GHC 7.00 (Senior citizen discount)

### 9. Negative Age

- **Input**: Age = -5
- **Expected Output**: GHC 7.00 (Child discount - though this is logically incorrect)

## Sample Test Run

```
=== Ticket Price Calculator ===
Welcome to the Movie Theater!

Please enter your age: 25

Your age: 25
Ticket price: GHC10.00
Regular adult price (GHC10)

Press any key to exit...
```

## How to Test

1. Run the application using `dotnet run`
2. Enter different ages to test all scenarios
3. Try invalid inputs to test error handling
4. Verify that the correct prices and messages are displayed
