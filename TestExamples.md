# Test Examples

Here are some example inputs and expected outputs for the Grade Calculator:

## Test Cases

| Input | Expected Output |
|-------|----------------|
| 95    | A              |
| 87    | B              |
| 75    | C              |
| 65    | D              |
| 45    | F              |
| 100   | A              |
| 0     | F              |
| 90    | A              |
| 89    | B              |
| 80    | B              |
| 79    | C              |
| 70    | C              |
| 69    | D              |
| 60    | D              |
| 59    | F              |

## Boundary Testing

- **90-100**: Should return A
- **80-89**: Should return B  
- **70-79**: Should return C
- **60-69**: Should return D
- **0-59**: Should return F

## Error Handling

The program should handle these invalid inputs gracefully:
- Non-numeric input (e.g., "abc")
- Empty input
- Numbers outside the 0-100 range (e.g., -5, 150)

## Sample Program Output

```
=== Grade Calculator ===
Enter a numerical grade between 0 and 100:
85

Numerical Grade: 85
Letter Grade: B

Press any key to exit...
``` 